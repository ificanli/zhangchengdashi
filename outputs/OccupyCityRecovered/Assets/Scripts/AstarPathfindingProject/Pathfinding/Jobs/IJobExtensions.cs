using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Jobs;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x2000195")]
	public static class IJobExtensions
	{
		[Token(Token = "0x2000196")]
		private struct ManagedJob : IJob
		{
			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GCHandle handle;

			[Token(Token = "0x6000BE9")]
			[Address(RVA = "0x458330C", Offset = "0x457F30C", VA = "0x458330C", Slot = "4")]
			public void Execute()
			{ ((IJob)handle.Target).Execute(); handle.Free(); }
		}

		[Token(Token = "0x2000197")]
		private struct ManagedActionJob : IJob
		{
			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GCHandle handle;

			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x458340C", Offset = "0x457F40C", VA = "0x458340C", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x2000198")]
		[CompilerGenerated]
		private sealed class _003CExecuteMainThreadJob_003Ed__7<T> : IEnumerator<JobHandle>, IEnumerator, IDisposable where T : struct, IJobTimeSliced
		{
			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private JobHandle _003C_003E2__current;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public JobDependencyTracker tracker;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T data;

			[Token(Token = "0x170001F9")]
JobHandle System.Collections.Generic.IEnumerator<Unity.Jobs.JobHandle>.Current
			{
				[Token(Token = "0x6000BEE")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001FA")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BF0")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000BEB")]
			[DebuggerHidden]
			public _003CExecuteMainThreadJob_003Ed__7(int _003C_003E1__state)
			{ this._003C_003E1__state=_003C_003E1__state; }

			[Token(Token = "0x6000BEC")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BED")]
bool System.Collections.IEnumerator.MoveNext()
			{
 int state=_003C_003E1__state;
 if (state==1 || state==2) {
  _003C_003E1__state=-1;
  if (!data.Execute(tracker.timeSlice)) { _003C_003E2__current=default;_003C_003E1__state=2;return true; }
  return false;
 }
 if (state!=0) return false;
 _003C_003E1__state=-1;
 if (tracker.forceLinearDependencies) { data.Execute(); return false; }
 _003C_003E2__current=JobDependencyAnalyzer<T>.GetDependencies(ref data,tracker);
 _003C_003E1__state=1; return true;
}

			[Token(Token = "0x6000BEE")]
			[DebuggerHidden]
			private JobHandle System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current()
			{ return _003C_003E2__current; }

			[Token(Token = "0x6000BEF")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{ throw new NotSupportedException(); }

			[Token(Token = "0x6000BF0")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{ return _003C_003E2__current; }
		}

		[Token(Token = "0x6000BE3")]
		public static JobHandle Schedule<T>(this T data, JobDependencyTracker tracker) where T : struct, IJob
		{
 if (tracker.forceLinearDependencies) { Unity.Jobs.IJobExtensions.Run(data); return default; }
 var dependency=JobDependencyAnalyzer<T>.GetDependencies(ref data,tracker);
 var job=Unity.Jobs.IJobExtensions.Schedule(data,dependency);
 JobDependencyAnalyzer<T>.Scheduled(ref data,tracker,job);
 return job;
}

		[Token(Token = "0x6000BE4")]
		public static JobHandle ScheduleBatch<T>(this T data, int arrayLength, int minIndicesPerJobCount, JobDependencyTracker tracker, [Optional] JobHandle additionalDependency) where T : struct, IJobParallelForBatched
		{
 if (tracker.forceLinearDependencies) {
  additionalDependency.Complete();
  JobParallelForBatchedExtensions.RunBatch(data,arrayLength);
  return default;
 }
 var dependency=JobDependencyAnalyzer<T>.GetDependencies(ref data,tracker,additionalDependency);
 var job=JobParallelForBatchedExtensions.ScheduleBatch(data,arrayLength,minIndicesPerJobCount,dependency);
 JobDependencyAnalyzer<T>.Scheduled(ref data,tracker,job);
 return job;
}

		[Token(Token = "0x6000BE5")]
		public static JobHandle ScheduleManaged<T>(this T data, JobHandle dependsOn) where T : struct, IJob
		{ return Unity.Jobs.IJobExtensions.Schedule(new ManagedJob { handle = GCHandle.Alloc(data) }, dependsOn); }

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x45832A4", Offset = "0x457F2A4", VA = "0x45832A4")]
		public static JobHandle ScheduleManaged(this Action data, JobHandle dependsOn)
		{
			return default;
		}

		[Token(Token = "0x6000BE7")]
		public static JobHandle GetDependencies<T>(this T data, JobDependencyTracker tracker) where T : struct, IJob
		{
			return default;
		}

		[Token(Token = "0x6000BE8")]
		[IteratorStateMachine(typeof(_003CExecuteMainThreadJob_003Ed__7<>))]
		public static IEnumerator<JobHandle> ExecuteMainThreadJob<T>(this T data, JobDependencyTracker tracker) where T : struct, IJobTimeSliced
		{ return new _003CExecuteMainThreadJob_003Ed__7<T>(0) { tracker=tracker,data=data }; }
	}
}
