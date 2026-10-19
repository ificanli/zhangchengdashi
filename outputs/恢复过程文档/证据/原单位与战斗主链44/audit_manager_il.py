import json,re
from pathlib import Path
W=Path(__file__).resolve().parent
full=(W/'compile/il/Assembly-CSharp.il').read_text(encoding='utf-8-sig')
start=full.index('.class public auto ansi beforefieldinit GameModule.BattleGameManager\n');end=full.index('} // end of class GameModule.BattleGameManager',start)+len('} // end of class GameModule.BattleGameManager')
il=full[start:end];(W/'compile/manager.il.txt').write_text(il,encoding='utf-8')
def state(name):
 m=re.search(r"\t\.class nested[^\n]*'<"+name+r">d__\d+'",il);assert m,name
 stop=il.index('\n\t} // end of class',m.start());return il[m.start():stop]
init=state('Init');begin=state('BeginStartCountDown');game=state('GameEnd');count=state('CountDownEnd');iterator=state('Countdown')
checks={
 'Init_one_await':init.count('::AwaitUnsafeOnCompleted<')==1,
 'Init_13_original_listeners':init.count('::StartListening(')==13,
 'GameEnd_one_await':game.count('::AwaitUnsafeOnCompleted<')==1,
 'GameEnd_async_void_exception': 'AsyncVoidMethodBuilder::SetException' in game,
 'Begin_one_await':begin.count('::AwaitUnsafeOnCompleted<')==1,
 'Begin_real_Unity_equality':'UnityEngine.Object::op_Equality' in begin,
 'CountDownEnd_async_void_no_await':count.count('::AwaitUnsafeOnCompleted<')==0 and 'AsyncVoidMethodBuilder::SetException' in count,
 'Countdown_new_compiler_iterator': 'WaitForSeconds::.ctor' in iterator and '::get_IsGamePaused()' in iterator,
 'Countdown_original_Random_upper101':'ldc.i4.s 101' in iterator,
 'Constructor_dictionary_before_base':il.rfind('Dictionary`2<int32, valuetype GameModule.BattleGameManager/AnimationPauseSnapshot>::.ctor()')<il.rfind('ManagerBase`1<class GameModule.BattleGameManager>::.ctor()'),
 'Format_two_original_overloads':'System.String::Format(string, object, object)' in il and 'System.String::Format(string, object[])' in il,
 'Pause_managed_type_test':'isinst [Assembly-CSharp-firstpass]AnimationInstancing.AnimationInstancing' in il or 'isinst AnimationInstancing.AnimationInstancing' in il,
}
(W/'manager-il-audit.json').write_text(json.dumps(checks,indent=2),encoding='utf-8');print(json.dumps(checks,indent=2));assert all(checks.values())
