using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Jobs;
using Pathfinding.Serialization;
using Unity.Jobs;

namespace Pathfinding.Graphs.Grid.Rules
{
	[Token(Token = "0x2000210")]
	[JsonOptIn]
	public class GridGraphRules
	{
		[Token(Token = "0x2000211")]
		public class Context
		{
			[Token(Token = "0x40009CC")]
			[FieldOffset(Offset = "0x10")]
			public GridGraph graph;

			[Token(Token = "0x40009CD")]
			[FieldOffset(Offset = "0x18")]
			public GridGraphScanData data;

			[Token(Token = "0x17000219")]
			public JobDependencyTracker tracker
			{
				[Token(Token = "0x6000DD7")]
				[Address(RVA = "0x4478270", Offset = "0x4474270", VA = "0x4478270")]
				get
				{ return data.dependencyTracker; }
			}

			[Token(Token = "0x6000DD8")]
			[Address(RVA = "0x4478278", Offset = "0x4474278", VA = "0x4478278")]
			public Context()
			{}
		}

		[Token(Token = "0x2000212")]
		[CompilerGenerated]
		private sealed class _003CExecuteRule_003Ed__13 : IEnumerator<JobHandle>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009CE")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40009CF")]
			[FieldOffset(Offset = "0x18")]
			private JobHandle _003C_003E2__current;

			[Token(Token = "0x40009D0")]
			[FieldOffset(Offset = "0x28")]
			public GridGraphRules _003C_003E4__this;

			[Token(Token = "0x40009D1")]
			[FieldOffset(Offset = "0x30")]
			public GridGraphRule.Pass rule;

			[Token(Token = "0x40009D2")]
			[FieldOffset(Offset = "0x38")]
			public Context context;

			[Token(Token = "0x1700021A")]
JobHandle System.Collections.Generic.IEnumerator<Unity.Jobs.JobHandle>.Current
			{
				[Token(Token = "0x6000DDC")]
				[Address(RVA = "0x44783FC", Offset = "0x44743FC", VA = "0x44783FC", Slot = "4")]
				[DebuggerHidden]
				get
				{ return _003C_003E2__current; }
			}

			[Token(Token = "0x1700021B")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000DDE")]
				[Address(RVA = "0x4478440", Offset = "0x4474440", VA = "0x4478440", Slot = "7")]
				[DebuggerHidden]
				get
				{ return _003C_003E2__current; }
			}

			[Token(Token = "0x6000DD9")]
			[Address(RVA = "0x4478280", Offset = "0x4474280", VA = "0x4478280")]
			[DebuggerHidden]
			public _003CExecuteRule_003Ed__13(int _003C_003E1__state)
			{ this._003C_003E1__state=_003C_003E1__state; }

			[Token(Token = "0x6000DDA")]
			[Address(RVA = "0x44782A8", Offset = "0x44742A8", VA = "0x44782A8", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{}

			[Token(Token = "0x6000DDB")]
			[Address(RVA = "0x44782AC", Offset = "0x44742AC", VA = "0x44782AC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
 var owner=_003C_003E4__this;
 switch (_003C_003E1__state) {
  case 0:
   _003C_003E1__state=-1;
   if (owner.jobSystemCallbacks==null) owner.Rebuild();
   CallActions(owner.jobSystemCallbacks[(int)rule],context);
   var actions=owner.mainThreadCallbacks[(int)rule];
   if (actions==null || actions.Count<1) return false;
   if (!context.tracker.forceLinearDependencies) {
    _003C_003E2__current=context.tracker.AllWritesDependency;
    _003C_003E1__state=1;
    return true;
   }
   break;
  case 1: _003C_003E1__state=-1;break;
  default:return false;
 }
 CallActions(owner.mainThreadCallbacks[(int)rule],context);
 return false;
}

			[Token(Token = "0x6000DDC")]
			[Address(RVA = "0x44783FC", Offset = "0x44743FC", VA = "0x44783FC", Slot = "4")]
			[DebuggerHidden]
			private JobHandle System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current()
			{
				return default;
			}

			[Token(Token = "0x6000DDD")]
			[Address(RVA = "0x4478408", Offset = "0x4474408", VA = "0x4478408", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{ throw new NotSupportedException(); }

			[Token(Token = "0x6000DDE")]
			[Address(RVA = "0x4478440", Offset = "0x4474440", VA = "0x4478440", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40009C8")]
		[FieldOffset(Offset = "0x10")]
		private List<Action<Context>>[] jobSystemCallbacks;

		[Token(Token = "0x40009C9")]
		[FieldOffset(Offset = "0x18")]
		private List<Action<Context>>[] mainThreadCallbacks;

		[Token(Token = "0x40009CA")]
		[FieldOffset(Offset = "0x20")]
		[JsonMember]
		private List<GridGraphRule> rules = new List<GridGraphRule>();

		[Token(Token = "0x40009CB")]
		[FieldOffset(Offset = "0x28")]
		private long lastHash;

		[Token(Token = "0x6000DC9")]
		[Address(RVA = "0x4476E8C", Offset = "0x4472E8C", VA = "0x4476E8C")]
		public void AddRule(GridGraphRule rule)
		{ rules.Add(rule); lastHash=-1; }

		[Token(Token = "0x6000DCA")]
		[Address(RVA = "0x4476F34", Offset = "0x4472F34", VA = "0x4476F34")]
		public void RemoveRule(GridGraphRule rule)
		{ rules.Remove(rule); lastHash=-1; }

		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0x4476F98", Offset = "0x4472F98", VA = "0x4476F98")]
		public IReadOnlyList<GridGraphRule> GetRules()
		{ if (rules==null) rules=new List<GridGraphRule>(); return rules.AsReadOnly(); }

		[Token(Token = "0x6000DCC")]
		[Address(RVA = "0x4477030", Offset = "0x4473030", VA = "0x4477030")]
		private long Hash()
		{ long hash=196613; for (int i=0;i<rules.Count;i++) if (rules[i]!=null && rules[i].enabled) hash=unchecked((1572869L*hash)^rules[i].Hash); return hash; }

		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x4477124", Offset = "0x4473124", VA = "0x4477124")]
		public void RebuildIfNecessary()
		{ long hash=Hash(); if (hash!=lastHash || jobSystemCallbacks==null || mainThreadCallbacks==null) { lastHash=hash; Rebuild(); } }

		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x4477164", Offset = "0x4473164", VA = "0x4477164")]
		public void Rebuild()
		{
 if (rules==null) rules=new List<GridGraphRule>();
 if (jobSystemCallbacks==null) jobSystemCallbacks=new List<Action<Context>>[6];
 for (int i=0;i<jobSystemCallbacks.Length;i++) if (jobSystemCallbacks[i]!=null) jobSystemCallbacks[i].Clear();
 if (mainThreadCallbacks==null) mainThreadCallbacks=new List<Action<Context>>[6];
 for (int i=0;i<mainThreadCallbacks.Length;i++) if (mainThreadCallbacks[i]!=null) mainThreadCallbacks[i].Clear();
 for (int i=0;i<rules.Count;i++) if (rules[i].enabled) rules[i].Register(this);
}

		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x447737C", Offset = "0x447337C", VA = "0x447737C")]
		public void DisposeUnmanagedData()
		{ if (rules!=null) for (int i=0;i<rules.Count;i++) if (rules[i]!=null) { rules[i].DisposeUnmanagedData(); rules[i].SetDirty(); } }

		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x4477448", Offset = "0x4473448", VA = "0x4477448")]
		private static void CallActions(List<Action<Context>> actions, Context context)
		{ try { if (actions!=null) for (int i=0;i<actions.Count;i++) actions[i](context); } catch (Exception exception) { UnityEngine.Debug.LogException(exception); } }

		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x447759C", Offset = "0x447359C", VA = "0x447759C")]
		[IteratorStateMachine(typeof(_003CExecuteRule_003Ed__13))]
		public IEnumerator<JobHandle> ExecuteRule(GridGraphRule.Pass rule, Context context)
		{ return new _003CExecuteRule_003Ed__13(0) { _003C_003E4__this=this,rule=rule,context=context }; }

		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x447761C", Offset = "0x447361C", VA = "0x447761C")]
		public void ExecuteRuleMainThread(GridGraphRule.Pass rule, Context context)
		{
 if (jobSystemCallbacks==null) Rebuild();
 var jobs=jobSystemCallbacks[(int)rule];
 if (jobs!=null && jobs.Count>0) throw new Exception("A job system pass has been added for the "+rule.ToString()+" pass. "+rule.ToString()+" only supports main thread callbacks.");
 if (context.tracker!=null) context.tracker.AllWritesDependency.Complete();
 CallActions(mainThreadCallbacks[(int)rule],context);
}

		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x447785C", Offset = "0x447385C", VA = "0x447785C")]
		public void AddJobSystemPass(GridGraphRule.Pass pass, Action<Context> action)
		{ if (jobSystemCallbacks[(int)pass]==null) jobSystemCallbacks[(int)pass]=new List<Action<Context>>(); jobSystemCallbacks[(int)pass].Add(action); }

		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x44779CC", Offset = "0x44739CC", VA = "0x44779CC")]
		public void AddMainThreadPass(GridGraphRule.Pass pass, Action<Context> action)
		{ if (mainThreadCallbacks[(int)pass]==null) mainThreadCallbacks[(int)pass]=new List<Action<Context>>(); mainThreadCallbacks[(int)pass].Add(action); }

		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x4477B3C", Offset = "0x4473B3C", VA = "0x4477B3C")]
		[Obsolete("Use AddJobSystemPass or AddMainThreadPass instead")]
		public void Add(GridGraphRule.Pass pass, Action<Context> action)
		{ AddJobSystemPass(pass,action); }

		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x4477B40", Offset = "0x4473B40", VA = "0x4477B40")]
		public GridGraphRules()
		{}
	}
}
