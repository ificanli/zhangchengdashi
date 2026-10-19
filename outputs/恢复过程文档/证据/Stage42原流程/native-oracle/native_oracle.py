"""Stage 42: execute original APK ARM64 bytes; mock only external runtime boundaries.

The state-machine business branches, stores, callback selection, loops and float
arithmetic run in Unicorn. This is not a second Python FSM implementation.
"""
from pathlib import Path
import hashlib
import json
import math
import re
import struct
import sys

HERE = Path(__file__).resolve().parent
ROOT = HERE.parents[2]
sys.path.insert(0, str(ROOT / 'work/tools/unicorn-recovery'))
from unicorn import Uc, UC_ARCH_ARM64, UC_MODE_ARM, UC_HOOK_CODE
import unicorn.arm64_const as A

ELF = (ROOT / 'work/ida-input/libil2cpp-arm64.so').read_bytes()
MAP = json.loads((ROOT / 'outputs/IDA分析材料/Il2Cpp导出/script.json').read_text(encoding='utf-8-sig'))
METHODS = {}
for row in MAP['ScriptMethod']:
    METHODS.setdefault(row['Name'], []).append(row['Address'])
STRINGS = {row['Address']: row['Value'] for row in MAP['ScriptString']}
ASM = ROOT / 'work/parallel-42-fsm/ida/pseudocode'

def addr(name):
    return METHODS[name][0]

def elf_bytes(va, size):
    # Resolve ELF PT_LOAD rather than assuming VA == file offset.
    phoff = struct.unpack_from('<Q', ELF, 32)[0]
    entsize, count = struct.unpack_from('<HH', ELF, 54)
    for i in range(count):
        typ, flags, off, virt, phys, fsz, msz, align = struct.unpack_from('<IIQQQQQQ', ELF, phoff+i*entsize)
        if typ == 1 and virt <= va and va+size <= virt+fsz:
            return ELF[off+va-virt:off+va-virt+size]
    raise ValueError((hex(va), size))

FSM_CTOR = 0x52a8890
FSM_UPDATE = 0x52a8bf0
FSM_SHUTDOWN = 0x52a8c18
FSM_START = 0x52a8dbc
FSM_CHANGE = 0x52a9308
MANAGER_UPDATE = 0x7296d08
DICT = 'System.Collections.Generic.Dictionary<object, object>$$'
ENUM = 'System.Collections.Generic.Dictionary.Enumerator<object, object>$$'

class Native:
    def __init__(self):
        self.cpu = Uc(UC_ARCH_ARM64, UC_MODE_ARM)
        self.pages = set()
        self.heap = 0x21000000
        self.trace = []
        self.error = None
        self.dicts = {}
        self.enums = {}
        self.lists = {}
        self.state_names = {}
        self.types = {}
        self.fullnames = {}
        self.callback_actions = {}
        self.exception_messages = {}
        self.stop_callback = None
        self.instructions = 0
        self.entry_counts = {}
        self.hooks = {}
        self.return_contexts = []
        self.suppress_return = False
        self.write(0x20000000, bytes(0x100000))
        self.self = 0x20001000
        self.method = 0x20002000
        self.context = 0x20003000
        self.table = 0x20004000
        self.klass = 0x20005000
        self.typeklass = 0x20006000
        self.stateklass = 0x20007000
        self.sentinel = 0x31000000
        self.write(self.sentinel, b'\x1f\x20\x03\xd5')
        self.write(0x32000000, bytes(0x20000))
        self.ptr(self.self, self.klass)
        self.ptr(self.method+0x20, self.context)
        self.ptr(self.context+0xc0, self.table)
        for off in range(0, 0x200, 8):
            self.ptr(self.table+off, self.method)
        self.dictklass = self.alloc(0x200)
        self.byte(self.dictklass+0x135, 1)
        self.ptr(self.table+0x18, self.dictklass)
        for start, size in [(0x52a8474,0x100c),(0x7296d08,0xc8)]:
            self.write(start, elf_bytes(start,size))
        # Recover GOT and metadata slot operands from saved original assembly.
        for p in ASM.glob('*.asm.txt'):
            asm = p.read_text()
            for got, slot in re.findall(r'#off_([0-9A-F]+)@PAGEOFF\];\s*(?:off|qword|unk)_([0-9A-F]+)', asm):
                self.ptr(int(got,16), int(slot,16))
                self.ptr(int(slot,16), self.method)
            for guard in re.findall(r'byte_(900[0-9A-F]+)', asm):
                self.byte(int(guard,16), 1)
        self.bind(0x3c3d294, self.resolve_metadata)
        self.bind(0x3c3d4c4, self.new_object)
        self.bind(0x35c5de8, self.check_not_null)
        self.bind(0x3c3d4cc, self.null_error)
        self.bind(0x3c3d3a0, self.throw_error)
        self.bind(0x3c3d4d4, lambda: self.abort('IndexOutOfRangeException'))
        self.bind(0x35fb8e0, lambda: self.reg('x0', self.readptr(self.self+0x10)))
        self.bind(0x750aa4c, self.format_message)
        for a in METHODS['GameFramework.GameFrameworkException$$.ctor']:
            self.bind(a,self.exception_ctor)
        for a in METHODS['GameFramework.Fsm.FsmBase$$.ctor']:
            self.bind(a,self.base_ctor)
        self.bind(addr('System.Object$$GetType'), self.get_type)
        for name, fn in [('TryGetValue',self.try_get),('ContainsKey',self.contains),('Add',self.add),('Clear',self.clear),('GetEnumerator',self.enumerator)]:
            self.bind(addr(DICT+name),fn)
        for a in METHODS[DICT+'.ctor']:
            self.bind(a,self.dict_ctor)
        self.bind(addr(ENUM+'MoveNext'),self.move_next)
        self.bind(addr(ENUM+'Dispose'),self.dispose)
        self.bind(addr('System.Collections.Generic.List<object>$$get_Item'),self.list_item)
        self.bind(0x30000000,self.fullname)
        self.bind(0x30000400,self.finish_reentry)
        self.ptr(self.typeklass+0x308,0x30000000)
        self.ptr(self.typeklass+0x310,self.method)
        for i,(off,name) in enumerate([(0x178,'init'),(0x188,'enter'),(0x198,'enter_args'),(0x1a8,'update'),(0x1b8,'leave'),(0x1c8,'destroy')]):
            thunk=0x30000100+i*0x10
            self.bind(thunk,lambda name=name:self.callback(name))
            self.ptr(self.stateklass+off,thunk)
            self.ptr(self.stateklass+off+8,self.method)
        # Actual getters and update are original bytes, including manager dispatch.
        self.ptr(self.klass+0x1b8,0x52a8b90)
        self.ptr(self.klass+0x1c0,self.method)
        self.ptr(self.klass+0x1c8,0x52a8ba0)
        self.ptr(self.klass+0x1d0,self.method)
        self.ptr(self.klass+0x1f8,FSM_UPDATE)
        self.ptr(self.klass+0x200,self.method)
        self.cpu.hook_add(UC_HOOK_CODE,self.hook)

    def write(self,address,data):
        for page in range(address&~4095,(address+len(data)+4095)&~4095,4096):
            if page not in self.pages:
                self.cpu.mem_map(page,4096)
                self.pages.add(page)
        self.cpu.mem_write(address,data)
    def alloc(self,size=0x100):
        address=self.heap
        self.heap+=(size+0xff)&~0xff
        self.write(address,bytes(size))
        return address
    def ptr(self,address,value):self.write(address,struct.pack('<Q',value))
    def int(self,address,value):self.write(address,struct.pack('<i',value))
    def byte(self,address,value):self.write(address,bytes([value]))
    def readptr(self,address):return struct.unpack('<Q',self.cpu.mem_read(address,8))[0]
    def readfloat(self,address):return struct.unpack('<f',self.cpu.mem_read(address,4))[0]
    def time(self,value):self.write(self.self+0x40,struct.pack('<f',value))
    def reg(self,name,value=None):
        reg=getattr(A,'UC_ARM64_REG_'+name.upper())
        if value is None:return self.cpu.reg_read(reg)
        self.cpu.reg_write(reg,value)
    def sf(self,name):return struct.unpack('<f',struct.pack('<I',self.reg(name)&0xffffffff))[0]
    def ret(self):self.reg('pc',self.reg('x30'))
    def abort(self,error):self.error=error;self.cpu.emu_stop()
    def bind(self,address,fn):
        self.hooks[address]=fn
        self.write(address,b'\xc0\x03\x5f\xd6')
    def hook(self,cpu,address,size,data):
        self.instructions+=1
        if address in [FSM_CTOR,FSM_UPDATE,FSM_SHUTDOWN,FSM_START,FSM_CHANGE,MANAGER_UPDATE,0x52a8f74]:
            self.entry_counts[hex(address)]=self.entry_counts.get(hex(address),0)+1
        if address in self.hooks:
            self.suppress_return=False
            self.hooks[address]()
            if self.error is None and not self.suppress_return:self.ret()
    def defer_native(self,entry,args):
        # Enter actual original instructions as a callback would. Save CPU state
        # at the boundary; original FSM memory writes remain after nested return.
        self.return_contexts.append(self.cpu.context_save())
        for i,value in enumerate(args):self.reg('x'+str(i),value)
        self.reg('x30',0x30000400)
        self.reg('pc',entry)
        self.suppress_return=True
    def finish_reentry(self):
        self.cpu.context_restore(self.return_contexts.pop())
    def resolve_metadata(self):pass
    def new_object(self):self.reg('x0',self.alloc())
    def check_not_null(self):
        if self.reg('x0')==0:self.null_error()
    def null_error(self):self.abort('NullReferenceException')
    def throw_error(self):self.abort(self.exception_messages.get(self.reg('x0'),'GameFrameworkException'))
    def exception_ctor(self):self.exception_messages[self.reg('x0')]='GameFrameworkException: '+self.text(self.reg('x1'))
    def text(self,p):
        if isinstance(p,str):return p
        return STRINGS.get(p,self.fullnames.get(p,hex(p)))
    def format_message(self):
        template=self.text(self.reg('x0'))
        try:value=template.format(self.text(self.reg('x1')),self.text(self.reg('x2')))
        except Exception:value=template
        p=self.alloc();self.fullnames[p]=value;self.reg('x0',p)
    def base_ctor(self):
        self.ptr(self.reg('x0')+0x10,self.reg('x1'))
    def get_type(self):self.reg('x0',self.types[self.reg('x0')])
    def fullname(self):self.reg('x0',self.fullnames[self.reg('x0')])
    def dict_ctor(self):self.dicts[self.reg('x0')]={}
    def contains(self):self.reg('w0',int(self.reg('x1') in self.dicts[self.reg('x0')]))
    def add(self):self.dicts[self.reg('x0')][self.reg('x1')]=self.reg('x2')
    def try_get(self):
        value=self.dicts[self.reg('x0')].get(self.reg('x1'),0)
        self.ptr(self.reg('x2'),value);self.reg('w0',int(value!=0))
    def clear(self):
        self.trace.append({'event':'clear_states' if self.reg('x0')==self.readptr(self.self+0x28) else 'clear_data','current':self.state_name(self.readptr(self.self+0x38)),'time':self.readfloat(self.self+0x40),'destroyed':bool(self.cpu.mem_read(self.self+0x44,1)[0])})
        self.dicts[self.reg('x0')].clear()
    def enumerator(self):
        p=self.reg('x8')
        self.enums[p]=iter(list(self.dicts[self.reg('x0')].values()))
    def move_next(self):
        p=self.reg('x0');value=next(self.enums[p],None)
        if value is not None:self.ptr(p+0x18,value)
        self.reg('w0',int(value is not None))
    def dispose(self):self.trace.append({'event':'dispose_enumerator'})
    def list_item(self):
        items=self.lists[self.reg('x0')];i=self.reg('w1')
        if i>=len(items):return self.abort('IndexOutOfRangeException')
        self.reg('x0',items[i])
    def state_name(self,p):return self.state_names.get(p,hex(p) if p else None)
    def callback(self,name):
        state=self.reg('x0');fsm=self.reg('x1')
        row={'event':name,'state':self.state_name(state),'current':self.state_name(self.readptr(fsm+0x38)),'time':self.readfloat(fsm+0x40),'destroyed':bool(self.cpu.mem_read(fsm+0x44,1)[0])}
        if name=='enter_args':row['args']=hex(self.reg('x2'))
        if name=='leave':row['isShutdown']=bool(self.reg('w2'))
        if name=='update':row.update(elapse=self.sf('s0'),realElapse=self.sf('s1'))
        self.trace.append(row)
        if self.stop_callback==(name,self.state_name(state)):
            return self.abort('CallbackAbort: '+name+':'+self.state_name(state))
        action=self.callback_actions.get((name,self.state_name(state)))
        if action:action(self,fsm)
    def array(self,items):
        p=self.alloc(0x20+len(items)*8);self.ptr(p+0x18,len(items))
        for i,item in enumerate(items):self.ptr(p+0x20+i*8,item)
        return p
    def state(self,name,type_key=None):
        p=self.alloc();typ=self.alloc();key=type_key or self.alloc()
        self.ptr(p,self.stateklass);self.ptr(typ,self.typeklass)
        self.state_names[p]=name;self.types[p]=typ;self.fullnames[typ]=key;self.fullnames[key]=type_key or name
        return p,typ,key
    def ready(self,current='A',time=7.25,destroyed=False):
        self.states={}
        dictionary=self.alloc();data=self.alloc()
        self.ptr(self.self+0x28,dictionary);self.ptr(self.self+0x30,data)
        self.dicts[dictionary]={};self.dicts[data]={123:456}
        for name in ['A','B','C']:
            p,typ,key=self.state(name);self.states[name]=(p,typ,key);self.dicts[dictionary][key]=p
        self.ptr(self.self+0x38,self.states[current][0] if current else 0)
        self.time(time);self.byte(self.self+0x44,int(destroyed))
    def run(self,start,args=(),floats=()):
        self.reg('sp',0x32010000);self.reg('x30',self.sentinel)
        for i,value in enumerate(args):self.reg('x'+str(i),value)
        for i,value in enumerate(floats):self.reg('s'+str(i),struct.unpack('<I',struct.pack('<f',value))[0])
        try:self.cpu.emu_start(start,self.sentinel,count=20000)
        except Exception as exc:
            raise RuntimeError({'entry':hex(start),'pc':hex(self.reg('pc')),'x0':hex(self.reg('x0')),'x1':hex(self.reg('x1')),'trace':self.trace,'error':str(exc)}) from exc
        if self.error is None:assert self.reg('pc')==self.sentinel,hex(self.reg('pc'))
        return self.result()
    def result(self):
        return {'trace':self.trace,'error':self.error,'current':self.state_name(self.readptr(self.self+0x38)),'time':self.readfloat(self.self+0x40),'destroyed':bool(self.cpu.mem_read(self.self+0x44,1)[0]),'instructionCount':self.instructions,'nativeEntries':self.entry_counts}

def case(name,fn):
    n=Native();result=fn(n);result['case']=name
    return result

def main():
    rows=[]
    def start(n,args_kind='null',running=False,missing=False,destroyed=False,abort=False):
        n.ready(current='A' if running else None,destroyed=destroyed)
        args=0 if args_kind=='null' else n.array([] if args_kind=='empty' else [0x55])
        typ=n.states['B'][1]
        if missing:
            _,typ,_=n.state('Missing')
        if abort:n.stop_callback=('enter','B')
        result=n.run(FSM_START,[n.self,typ,args,n.method])
        if running:assert result['error']=='GameFrameworkException: FSM is running, can not start again.',result
        elif missing:assert result['error'] and not result['trace'],result
        else:
            assert result['current']=='B' and result['time']==0,result
            assert result['trace'][0]['event']==('enter_args' if args_kind=='nonempty' else 'enter'),result
        return result
    for k in ['null','empty','nonempty']:rows.append(case('start_'+k,lambda n,k=k:start(n,k)))
    rows.append(case('start_already_running',lambda n:start(n,running=True)))
    rows.append(case('start_missing_state',lambda n:start(n,missing=True)))
    rows.append(case('start_destroyed_is_not_guarded',lambda n:start(n,destroyed=True)))
    rows.append(case('start_enter_abort_commits_state',lambda n:start(n,abort=True)))
    def null_type(n,entry):
        n.ready(current='A' if entry==FSM_CHANGE else None)
        result=n.run(entry,[n.self,0,0,n.method])
        assert result['error']=='NullReferenceException' and not result['trace'],result
        return result
    rows.append(case('start_null_type',lambda n:null_type(n,FSM_START)))
    rows.append(case('change_null_type',lambda n:null_type(n,FSM_CHANGE)))
    def change(n,target='B',kind='null',running=True,abort=None,missing=False):
        n.ready(current='A' if running else None)
        args=0 if kind=='null' else n.array([] if kind=='empty' else [0x55])
        typ=n.states[target][1]
        if missing:_,typ,_=n.state('Missing')
        if abort:n.stop_callback=(abort,'A' if abort=='leave' else target)
        result=n.run(FSM_CHANGE,[n.self,typ,args,n.method])
        if not running or missing:assert result['error'] and not result['trace'],result
        elif abort=='leave':assert result['current']=='A' and result['time']==7.25 and len(result['trace'])==1,result
        else:
            assert result['current']==target and result['time']==0,result
            assert [x['event'] for x in result['trace']]==['leave','enter_args' if kind=='nonempty' else 'enter'],result
            assert result['trace'][0]['current']=='A' and result['trace'][0]['time']==7.25 and not result['trace'][0]['isShutdown'],result
            assert result['trace'][1]['current']==target and result['trace'][1]['time']==0,result
        return result
    for k in ['null','empty','nonempty']:rows.append(case('change_'+k,lambda n,k=k:change(n,kind=k)))
    rows.append(case('change_same_state',lambda n:change(n,target='A')))
    rows.append(case('change_not_running',lambda n:change(n,running=False)))
    rows.append(case('change_missing_state',lambda n:change(n,missing=True)))
    rows.append(case('change_leave_abort_preserves_old',lambda n:change(n,abort='leave')))
    rows.append(case('change_enter_abort_commits_new',lambda n:change(n,abort='enter')))
    def reenter(n,where):
        n.ready(current='A')
        if where=='enter':
            n.callback_actions[('enter','B')]=lambda machine,fsm:machine.defer_native(FSM_CHANGE,[fsm,machine.states['C'][1],0,machine.method])
            result=n.run(FSM_CHANGE,[n.self,n.states['B'][1],0,n.method])
            expect=[('leave','A'),('enter','B'),('leave','B'),('enter','C')]
            assert result['current']=='C',result
        elif where=='leave':
            def leave(machine,fsm):
                del machine.callback_actions[('leave','A')]
                machine.defer_native(FSM_CHANGE,[fsm,machine.states['C'][1],0,machine.method])
            n.callback_actions[('leave','A')]=leave
            result=n.run(FSM_CHANGE,[n.self,n.states['B'][1],0,n.method])
            expect=[('leave','A'),('leave','A'),('enter','C'),('enter','B')]
            assert result['current']=='B',result
        elif where=='update':
            n.callback_actions[('update','A')]=lambda machine,fsm:machine.defer_native(FSM_CHANGE,[fsm,machine.states['B'][1],0,machine.method])
            result=n.run(FSM_UPDATE,[n.self,n.method],[.125,.5])
            expect=[('update','A'),('leave','A'),('enter','B')]
            assert result['current']=='B' and result['trace'][1]['time']==7.375,result
        elif where=='shutdown_leave':
            def leave(machine,fsm):
                del machine.callback_actions[('leave','A')]
                machine.defer_native(FSM_CHANGE,[fsm,machine.states['B'][1],0,machine.method])
            n.callback_actions[('leave','A')]=leave
            result=n.run(FSM_SHUTDOWN,[n.self,n.method])
            expect=[('leave','A'),('leave','A'),('enter','B')]+[('destroy',s) for s in ['A','B','C']]+[('dispose_enumerator',None),('clear_states',None),('clear_data',None)]
            assert result['current'] is None and result['destroyed'],result
        assert [(x['event'],x.get('state')) for x in result['trace']]==expect,result
        assert not n.return_contexts,result
        return result
    for k in ['enter','leave','update','shutdown_leave']:rows.append(case('native_reentry_'+k,lambda n,k=k:reenter(n,k)))
    def update(n,current='A',elapsed=.125,real=.25,initial=7.25,destroyed=False):
        n.ready(current=current,time=initial,destroyed=destroyed)
        result=n.run(FSM_UPDATE,[n.self,n.method],[elapsed,real])
        expected=struct.unpack('<f',struct.pack('<f',initial+elapsed))[0] if current else initial
        assert result['time']==expected,result
        assert len(result['trace'])==int(bool(current)),result
        if current:assert result['trace'][0]['elapse']==elapsed and result['trace'][0]['realElapse']==real,result
        return result
    rows.append(case('update_running_float32',lambda n:update(n,initial=16777216.,elapsed=1.,real=13.5)))
    rows.append(case('update_no_current_no_increment',lambda n:update(n,current=None)))
    rows.append(case('update_destroyed_flag_does_not_guard_direct_call',lambda n:update(n,destroyed=True)))
    rows.append(case('update_negative_delta',lambda n:update(n,elapsed=-.5,real=-1.5)))
    def shutdown(n,current='A',abort=None):
        n.ready(current=current)
        if abort:n.stop_callback=(abort,'A')
        result=n.run(FSM_SHUTDOWN,[n.self,n.method])
        if abort=='leave':assert result['current']=='A' and result['time']==7.25 and not result['destroyed'],result
        elif abort=='destroy':assert result['current'] is None and result['time']==0 and not result['destroyed'],result
        else:
            assert result['destroyed'] and result['current'] is None,result
            assert [x['event'] for x in result['trace']]==(['leave'] if current else [])+['destroy']*3+['dispose_enumerator','clear_states','clear_data'],result
            assert all(not x.get('destroyed',False) for x in result['trace']),result
            assert not n.dicts[n.readptr(n.self+0x28)] and not n.dicts[n.readptr(n.self+0x30)],result
            if current:assert result['time']==0 and result['trace'][0]['time']==7.25 and result['trace'][0]['isShutdown'],result
            else:assert result['time']==7.25,result
        return result
    rows.append(case('shutdown_running',lambda n:shutdown(n)))
    rows.append(case('shutdown_no_current_preserves_time',lambda n:shutdown(n,current=None)))
    rows.append(case('shutdown_leave_abort_preserves_old',lambda n:shutdown(n,abort='leave')))
    rows.append(case('shutdown_destroy_abort_after_clear_current',lambda n:shutdown(n,abort='destroy')))
    def ctor(n,kind='normal'):
        states=[n.state(x)[0] for x in ['A','B','C']]
        if kind=='duplicate':states[1]=states[0]
        if kind=='null_element':states[1]=0
        array=0 if kind=='null_states' else n.array([] if kind=='empty_states' else states)
        owner=0 if kind=='null_owner' else n.alloc()
        if kind=='init_abort':n.stop_callback=('init','A')
        if kind=='init_reenter_start':
            n.callback_actions[('init','A')]=lambda machine,fsm:machine.defer_native(FSM_START,[fsm,machine.types[states[0]],0,machine.method])
        result=n.run(FSM_CTOR,[n.self,0,owner,array,n.method])
        if kind=='normal':
            assert [x['event'] for x in result['trace']]==['init']*3 and result['current'] is None and result['time']==0 and not result['destroyed'],result
        elif kind=='init_reenter_start':
            assert [(x['event'],x.get('state')) for x in result['trace']]==[('init','A'),('enter','A'),('init','B'),('init','C')],result
            assert result['current'] is None and result['time']==0,result
        elif kind=='init_abort':
            assert result['error']=='CallbackAbort: init:A' and len(n.dicts[n.readptr(n.self+0x28)])==1,result
        else:
            assert result['error'],result
            assert len(result['trace'])==int(kind in ['duplicate','null_element']),result
        return result
    for k in ['normal','null_owner','null_states','empty_states','null_element','duplicate','init_abort','init_reenter_start']:rows.append(case('ctor_'+k,lambda n,k=k:ctor(n,k)))
    def manager(n,mode='normal'):
        manager=n.alloc();lst=n.alloc();items=[];n.ptr(manager+0x28,lst);n.lists[lst]=items
        for i,name in enumerate(['A','B','C']):
            f=n.alloc();n.ptr(f,n.klass);p,typ,key=n.state(name);n.ptr(f+0x38,p);n.write(f+0x40,struct.pack('<f',1.));items.append(f)
        def sync():n.int(lst+0x18,len(items))
        sync()
        if mode=='skip_destroyed':n.byte(items[1]+0x44,1)
        if mode=='append_during_update':
            def append(machine,fsm):
                f=machine.alloc();machine.ptr(f,machine.klass);p,_,_=machine.state('D');machine.ptr(f+0x38,p);items.append(f);sync()
            n.callback_actions[('update','A')]=append
        if mode=='remove_current_during_update':
            n.callback_actions[('update','A')]=lambda machine,fsm:(items.pop(0),sync())
        if mode=='clear_during_update':
            n.callback_actions[('update','A')]=lambda machine,fsm:(items.clear(),sync())
        if mode=='null_element':items[1]=0
        result=n.run(MANAGER_UPDATE,[manager,n.method],[.125,.5])
        names=[x['state'] for x in result['trace']]
        expect={'normal':['A','B','C'],'skip_destroyed':['A','C'],'append_during_update':['A','B','C','D'],'remove_current_during_update':['A','C'],'clear_during_update':['A'],'null_element':['A']}[mode]
        assert names==expect,result
        assert all(x['elapse']==.125 and x['realElapse']==.5 for x in result['trace']),result
        if mode=='null_element':assert result['error']=='NullReferenceException',result
        else:assert result['error'] is None,result
        return result
    for k in ['normal','skip_destroyed','append_during_update','remove_current_during_update','clear_during_update','null_element']:rows.append(case('manager_'+k,lambda n,k=k:manager(n,k)))
    report={'method':'Actual ARM64 ELF bytes under Unicorn 2.1.4','elfSha256':hashlib.sha256(ELF).hexdigest(),'passed':len(rows),'cases':rows,'boundaries':['IL2CPP metadata resolution / object allocation / type reflection','System Dictionary operations and enumerator payload','System List index access (count reads and index increments execute natively)','State virtual callbacks record actual ABI arguments, field visibility and optional external mutation','FsmBase constructor stores name at native offset; its implementation is not counted as tested','CallbackAbort stops emulation at the callback boundary; C++/managed exception unwinding is not emulated'],'codeHashes':{hex(a):hashlib.sha256(elf_bytes(a,b-a)).hexdigest() for a,b in [(FSM_CTOR,0x52a8b00),(FSM_UPDATE,0x52a8c18),(FSM_SHUTDOWN,FSM_START),(FSM_START,0x52a8f20),(0x52a8f74,0x52a8fe0),(FSM_CHANGE,0x52a9480),(MANAGER_UPDATE,0x7296dd0)]}}
    (HERE/'native-results.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
    print('Original ARM64 executions:',len(rows),'passed')
    print('Results:',HERE/'native-results.json')

if __name__=='__main__':main()
