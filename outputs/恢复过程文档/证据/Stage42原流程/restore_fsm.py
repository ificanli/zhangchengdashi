import json
import re
from pathlib import Path

W = Path(__file__).resolve().parent
P = Path('Assets/Scripts/GFRunning/GameFramework/Fsm')
changes = []

def restore(filename, bodies, initializers=None):
    source = (W/'source-before'/P/filename).read_text(encoding='utf-8-sig')
    for token, body in bodies.items():
        anchor = source.index('[Token(Token = "0x'+token.upper()+'")]')
        start = source.index('{', anchor)
        # Method attributes do not contain braces; properties have their Token
        # on the getter itself. Match the actual body with balanced braces.
        depth = 1
        end = start + 1
        while depth:
            depth += (source[end] == '{') - (source[end] == '}')
            end += 1
        content = '\n' + '\n'.join('\t\t\t'+line if line else '' for line in body.strip().splitlines()) + '\n\t\t'
        source = source[:start+1]+content+source[end-1:]
        changes.append({'file':(P/filename).as_posix(),'token':'0x'+token.upper(),'body':body.strip()})
    if initializers:
        for before, after in initializers:
            if source.count(before) != 1:
                raise RuntimeError('Unexpected initializer match '+before)
            source = source.replace(before,after,1)
    out = W/'candidate'/P/filename
    out.parent.mkdir(parents=True,exist_ok=True)
    out.write_text(source,encoding='utf-8',newline='\r\n')

restore('FsmBase.cs', {
    '6006CC6':'// Native 0x7296B44 delegates to the named constructor with null.',
    '6006CC7':'m_Name = name ?? string.Empty;',
    '6006CC8':'return m_Name;',
    '6006CC9':'return m_FullName;',
    '6006CCA':'m_FullName = value;'
}, [('public FsmBase()', 'public FsmBase() : this(null)')])

restore('Fsm.cs', {
    '6006CAC':'''if (owner == null)
    throw new GameFrameworkException("FSM owner is invalid.");
if (states == null || states.Length == 0)
    throw new GameFrameworkException("FSM states is invalid.");
m_Owner = owner;
m_States = new Dictionary<string, FsmState<T>>();
m_Datas = new Dictionary<string, Variable>();
foreach (FsmState<T> state in states)
{
    if (state == null)
        throw new GameFrameworkException("FSM states is invalid.");
    string stateName = state.GetType().FullName;
    if (m_States.ContainsKey(stateName))
        throw new GameFrameworkException(string.Format("FSM '{0}' state '{1}' is already exist.", Utility.Text.GetFullName<T>(name), stateName));
    m_States.Add(stateName, state);
    state.OnInit(this);
}
m_CurrentStateTime = 0f;
m_CurrentState = null;
m_IsDestroyed = false;''',
    '6006CAD':'return m_Owner;',
    '6006CAE':'return typeof(T);',
    '6006CAF':'return m_States.Count;',
    '6006CB0':'return m_CurrentState != null;',
    '6006CB1':'return m_IsDestroyed;',
    '6006CB2':'return m_CurrentState;',
    '6006CB3':'return m_CurrentState == null ? null : m_CurrentState.GetType().FullName;',
    '6006CB4':'return m_CurrentStateTime;',
    '6006CB5':'''if (m_CurrentState != null)
{
    m_CurrentStateTime += elapseSeconds;
    m_CurrentState.OnUpdate(this, elapseSeconds, realElapseSeconds);
}''',
    '6006CB6':'''if (m_CurrentState != null)
{
    m_CurrentState.OnLeave(this, true);
    m_CurrentState = null;
    m_CurrentStateTime = 0f;
}
foreach (KeyValuePair<string, FsmState<T>> state in m_States)
    state.Value.OnDestroy(this);
m_States.Clear();
m_Datas.Clear();
m_IsDestroyed = true;''',
    '6006CB7':'Start(typeof(TState), args);',
    '6006CB8':'''if (IsRunning)
    throw new GameFrameworkException("FSM is running, can not start again.");
FsmState<T> state = GetState(stateType);
if (state == null)
    throw new GameFrameworkException(string.Format("FSM '{0}' can not start state '{1}' which is not exist.", Utility.Text.GetFullName<T>(Name), stateType.FullName));
m_CurrentStateTime = 0f;
m_CurrentState = state;
if (args != null && args.Length > 0)
    state.OnEnter(this, args);
else
    state.OnEnter(this);''',
    '6006CB9':'return HasState(typeof(TState));',
    '6006CBA':'return m_States.ContainsKey(stateType.FullName);',
    '6006CBB':'return (TState)GetState(typeof(TState));',
    '6006CBC':'''FsmState<T> state;
return m_States.TryGetValue(stateType.FullName, out state) ? state : null;''',
    '6006CBD':'''if (m_CurrentState == null)
    throw new GameFrameworkException("Current state is invalid.");
m_CurrentState.OnEvent(this, sender, eventId, null);''',
    '6006CBE':'''if (m_CurrentState == null)
    throw new GameFrameworkException("Current state is invalid.");
m_CurrentState.OnEvent(this, sender, eventId, userData);''',
    '6006CBF':'''if (string.IsNullOrEmpty(name))
    throw new GameFrameworkException("Data name is invalid.");
return m_Datas.ContainsKey(name);''',
    '6006CC0':'''if (string.IsNullOrEmpty(name))
    throw new GameFrameworkException("Data name is invalid.");
Variable data;
return m_Datas.TryGetValue(name, out data) ? data : null;''',
    '6006CC1':'return (TData)GetData(name);',
    '6006CC2':'''if (string.IsNullOrEmpty(name))
    throw new GameFrameworkException("Data name is invalid.");
m_Datas[name] = data;''',
    '6006CC3':'''if (string.IsNullOrEmpty(name))
    throw new GameFrameworkException("Data name is invalid.");
return m_Datas.Remove(name);''',
    '6006CC4':'ChangeState(typeof(TState), args);',
    '6006CC5':'''if (m_CurrentState == null)
    throw new GameFrameworkException("Current state is invalid.");
FsmState<T> state = GetState(stateType);
if (state == null)
    throw new GameFrameworkException(string.Format("FSM '{0}' can not change state to '{1}' which is not exist.", Utility.Text.GetFullName<T>(Name), stateType.FullName));
m_CurrentState.OnLeave(this, false);
m_CurrentStateTime = 0f;
m_CurrentState = state;
if (args != null && args.Length > 0)
    state.OnEnter(this, args);
else
    state.OnEnter(this);'''
}, [('public Fsm(string name, T owner, params FsmState<T>[] states)', 'public Fsm(string name, T owner, params FsmState<T>[] states) : base(name)')])

restore('FsmManager.cs', {
    '6006CD7':'''m_Fsms = new Dictionary<string, FsmBase>();
m_TempFsms = new List<FsmBase>();''',
    '6006CD8':'return 80;',
    '6006CD9':'return m_Fsms.Count;',
    '6006CDA':'''for (int i = 0; i < m_TempFsms.Count; i++)
{
    FsmBase fsm = m_TempFsms[i];
    if (!fsm.IsDestroyed)
        fsm.Update(elapseSeconds, realElapseSeconds);
}''',
    '6006CDB':'''foreach (KeyValuePair<string, FsmBase> fsm in m_Fsms)
    fsm.Value.Shutdown();
m_Fsms.Clear();
m_TempFsms.Clear();
x_0080_008D_00B1f_0086 = false;''',
    '6006CDC':'return HasFsm<T>(string.Empty);',
    '6006CDD':'return m_Fsms.ContainsKey(Utility.Text.GetFullName<T>(name));',
    '6006CDE':'return GetFsm<T>(string.Empty);',
    '6006CDF':'''FsmBase fsm;
return m_Fsms.TryGetValue(Utility.Text.GetFullName<T>(name), out fsm) ? (Fsm<T>)fsm : null;''',
    '6006CE0':'''FsmBase[] fsms = new FsmBase[m_Fsms.Count];
int index = 0;
foreach (KeyValuePair<string, FsmBase> fsm in m_Fsms)
    fsms[index++] = fsm.Value;
return fsms;''',
    '6006CE1':'return CreateFsm(string.Empty, owner, states);',
    '6006CE2':'''if (HasFsm<T>(name))
    throw new GameFrameworkException(string.Format("Already exist FSM '{0}'.", Utility.Text.GetFullName<T>(name)));
Fsm<T> fsm = new Fsm<T>(name, owner, states);
fsm.FullName = Utility.Text.GetFullName<T>(name);
m_Fsms.Add(fsm.FullName, fsm);
m_TempFsms.Add(fsm);
return fsm;''',
    '6006CE3':'return DestroyFsm<T>(string.Empty);',
    '6006CE4':'''string fullName = Utility.Text.GetFullName<T>(name);
FsmBase fsm;
if (!m_Fsms.TryGetValue(fullName, out fsm))
    return false;
fsm.Shutdown();
m_Fsms.Remove(fullName);
m_TempFsms.Remove(fsm);
return true;''',
    '6006CE5':'''if (fsm == null)
    throw new GameFrameworkException("FSM is invalid.");
return DestroyFsm<T>(fsm.Name);''',
    '6006CE6':'''x_0080_008D_00B1f_0086 = true;
Àª_00A6_00A3_00BDE?.Invoke();''',
    '6006CE7':'// Original ARM64 method is RET.'
}, [('private List<FsmBase> m_deleteFsm;', 'private List<FsmBase> m_deleteFsm = new List<FsmBase>();')])

restore('FsmState.cs', {
    '6006CE8':'m_EventHandlers = new Dictionary<int, FsmEventHandler<T>>();',
    '6006CE9':'// Original default lifecycle method is RET.',
    '6006CEA':'// Original no-argument lifecycle method is RET.',
    '6006CEB':'// Original argument lifecycle method is independently RET.',
    '6006CEC':'// Original default lifecycle method is RET.',
    '6006CED':'// Original default lifecycle method is RET.',
    '6006CEE':'m_EventHandlers.Clear();',
    '6006CEF':'''if (eventHandler == null)
    throw new GameFrameworkException("Event handler is invalid.");
if (m_EventHandlers.ContainsKey(eventId))
    m_EventHandlers[eventId] += eventHandler;
else
    m_EventHandlers[eventId] = eventHandler;''',
    '6006CF0':'''if (eventHandler == null)
    throw new GameFrameworkException("Event handler is invalid.");
if (m_EventHandlers.ContainsKey(eventId))
    m_EventHandlers[eventId] -= eventHandler;''',
    '6006CF1':'''if (fsm == null)
    throw new GameFrameworkException("FSM is invalid.");
((Fsm<T>)fsm).ChangeState<TState>(args);''',
    '6006CF2':'''if (fsm == null)
    throw new GameFrameworkException("FSM is invalid.");
((Fsm<T>)fsm).ChangeState(stateType, args);''',
    '6006CF3':'''FsmEventHandler<T> handler;
if (m_EventHandlers.TryGetValue(eventId, out handler) && handler != null)
    handler(fsm, sender, userData);'''
})

(W/'fsm-restored-bodies.json').write_text(json.dumps(changes,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({'candidate_files':4,'mapped_methods':len(changes)}))
