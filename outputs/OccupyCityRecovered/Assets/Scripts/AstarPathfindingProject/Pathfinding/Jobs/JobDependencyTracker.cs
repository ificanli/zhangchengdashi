using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Pooling;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x200018C")]
	public class JobDependencyTracker : IAstarPooledObject
	{
		[Token(Token = "0x200018D")]
		internal struct JobInstance
		{
			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public JobHandle handle;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int hash;
		}

		[Token(Token = "0x200018E")]
		internal struct NativeArraySlot
		{
			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long hash;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public JobInstance lastWrite;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<JobInstance> lastReads;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool initialized;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			public bool hasWrite;
		}

		[Token(Token = "0x200018F")]
		private struct JobRaycastCommandDummy : IJob
		{
			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<RaycastCommand> commands;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[WriteOnly]
			public NativeArray<RaycastHit> results;

			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x45831D0", Offset = "0x457F1D0", VA = "0x45831D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x2000190")]
		private struct JobSpherecastCommandDummy : IJob
		{
			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<SpherecastCommand> commands;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[WriteOnly]
			public NativeArray<RaycastHit> results;

			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x45831D4", Offset = "0x457F1D4", VA = "0x45831D4", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x2000191")]
		private struct JobOverlapCapsuleCommandDummy : IJob
		{
			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<OverlapCapsuleCommand> commands;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[WriteOnly]
			public NativeArray<ColliderHit> results;

			[Token(Token = "0x6000BDC")]
			[Address(RVA = "0x45831D8", Offset = "0x457F1D8", VA = "0x45831D8", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x2000192")]
		private struct JobOverlapSphereCommandDummy : IJob
		{
			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<OverlapSphereCommand> commands;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[WriteOnly]
			public NativeArray<ColliderHit> results;

			[Token(Token = "0x6000BDD")]
			[Address(RVA = "0x45831DC", Offset = "0x457F1DC", VA = "0x45831DC", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal List<NativeArraySlot> slots = ListPool<NativeArraySlot>.Claim();

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DisposeArena arena;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal NativeArray<JobHandle> dependenciesScratchBuffer;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private LinearDependencies linearDependencies;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal TimeSlice timeSlice = TimeSlice.Infinite;

		[Token(Token = "0x170001F4")]
		public bool forceLinearDependencies
		{
			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0x45824D4", Offset = "0x457E4D4", VA = "0x45824D4")]
			get
			{ if (linearDependencies==LinearDependencies.Check) SetLinearDependencies(false); return linearDependencies==LinearDependencies.Enabled; }
		}

		[Token(Token = "0x170001F5")]
		public JobHandle AllWritesDependency
		{
			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x4582570", Offset = "0x457E570", VA = "0x4582570")]
			get
			{
 var handles=new NativeArray<JobHandle>(slots.Count,Allocator.Temp,NativeArrayOptions.UninitializedMemory);
 for (int i=0;i<slots.Count;i++) handles[i]=slots[i].lastWrite.handle;
 var result=JobHandle.CombineDependencies(handles);
 handles.Dispose();
 return result;
}
		}

		[Token(Token = "0x170001F6")]
		private bool supportsMultithreading
		{
			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x45826B0", Offset = "0x457E6B0", VA = "0x45826B0")]
			get
			{ return Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobWorkerCount > 0; }
		}

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x4582500", Offset = "0x457E500", VA = "0x4582500")]
		public void SetLinearDependencies(bool linearDependencies)
		{
 bool linear = Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobWorkerCount < 1 || linearDependencies;
 if (linear) AllWritesDependency.Complete();
 this.linearDependencies = linear ? LinearDependencies.Enabled : LinearDependencies.Disabled;
}

		[Token(Token = "0x6000BCC")]
		public NativeArray<T> NewNativeArray<T>(int length, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct
		{
 var result = new NativeArray<T>(length, allocator, options);
 Track(result, options == NativeArrayOptions.ClearMemory);
 return result;
}

		[Token(Token = "0x6000BCD")]
		public void Track<T>(NativeArray<T> array, bool initialized = true) where T : struct
		{
 long hash;
 unsafe { hash=(long)Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks(array); }
 slots.Add(new NativeArraySlot { hash=hash, lastReads=ListPool<JobInstance>.Claim(), initialized=initialized });
 if (arena==null) arena=new DisposeArena();
 arena.Add(array);
}

		[Token(Token = "0x6000BCE")]
		public void Persist<T>(NativeArray<T> array) where T : struct
		{ if (arena!=null) arena.Remove(array); }

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x45826CC", Offset = "0x457E6CC", VA = "0x45826CC")]
		public JobHandle ScheduleBatch(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob)
		{
 if (forceLinearDependencies) { var linearJob=RaycastCommand.ScheduleBatch(commands,results,minCommandsPerJob); linearJob.Complete(); return default; }
 var data=new JobRaycastCommandDummy { commands=commands,results=results };
 var dependency=JobDependencyAnalyzer<JobRaycastCommandDummy>.GetDependencies(ref data,this);
 var job=RaycastCommand.ScheduleBatch(commands,results,minCommandsPerJob,dependency);
 JobDependencyAnalyzer<JobRaycastCommandDummy>.Scheduled(ref data,this,job);
 return job;
}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x4582848", Offset = "0x457E848", VA = "0x4582848")]
		public JobHandle ScheduleBatch(NativeArray<SpherecastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob)
		{
 if (forceLinearDependencies) { var linearJob=SpherecastCommand.ScheduleBatch(commands,results,minCommandsPerJob); linearJob.Complete(); return default; }
 var data=new JobSpherecastCommandDummy { commands=commands,results=results };
 var dependency=JobDependencyAnalyzer<JobSpherecastCommandDummy>.GetDependencies(ref data,this);
 var job=SpherecastCommand.ScheduleBatch(commands,results,minCommandsPerJob,dependency);
 JobDependencyAnalyzer<JobSpherecastCommandDummy>.Scheduled(ref data,this,job);
 return job;
}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x45829C4", Offset = "0x457E9C4", VA = "0x45829C4")]
		public JobHandle ScheduleBatch(NativeArray<OverlapCapsuleCommand> commands, NativeArray<ColliderHit> results, int minCommandsPerJob)
		{
			return default;
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x4582B48", Offset = "0x457EB48", VA = "0x4582B48")]
		public JobHandle ScheduleBatch(NativeArray<OverlapSphereCommand> commands, NativeArray<ColliderHit> results, int minCommandsPerJob)
		{
			return default;
		}

		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x4582CCC", Offset = "0x457ECCC", VA = "0x4582CCC")]
		public void DeferFree(GCHandle handle, JobHandle dependsOn)
		{ if (arena==null) arena=new DisposeArena(); arena.Add(handle); }

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x4582D40", Offset = "0x457ED40", VA = "0x4582D40")]
		internal void JobReadsFrom(JobHandle job, long nativeArrayHash, int jobHash)
		{
 for (int i=0;i<slots.Count;i++) {
  var slot=slots[i];
  if (slot.hash==nativeArrayHash) {
   slot.lastReads.Add(new JobInstance { handle=job,hash=jobHash });
   return;
  }
 }
}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x4582E74", Offset = "0x457EE74", VA = "0x4582E74")]
		internal void JobWritesTo(JobHandle job, long nativeArrayHash, int jobHash)
		{
 for (int i=0;i<slots.Count;i++) {
  var slot=slots[i];
  if (slot.hash==nativeArrayHash) {
   slot.lastReads.Clear();
   slot.lastWrite=new JobInstance { handle=job,hash=jobHash };
   slot.initialized=true; slot.hasWrite=true;
   slots[i]=slot;
   return;
  }
 }
}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x4582F94", Offset = "0x457EF94", VA = "0x4582F94")]
		private void Dispose()
		{
 for (int i=0;i<slots.Count;i++) ListPool<JobInstance>.Release(slots[i].lastReads);
 slots.Clear();
 if (arena!=null) arena.DisposeAll();
 linearDependencies=LinearDependencies.Check;
 if (dependenciesScratchBuffer.IsCreated) dependenciesScratchBuffer.Dispose();
}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x45830EC", Offset = "0x457F0EC", VA = "0x45830EC")]
		public void ClearMemory()
		{ AllWritesDependency.Complete(); Dispose(); }

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x4583120", Offset = "0x457F120", VA = "0x4583120", Slot = "4")]
void IAstarPooledObject.OnEnterPool()
		{ Dispose(); }

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x4583124", Offset = "0x457F124", VA = "0x4583124")]
		public JobDependencyTracker()
		{}
	}
}
