using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x2000173")]
	public struct JobRaycastAll
	{
		[Token(Token = "0x2000174")]
		[BurstCompile]
		private struct JobCreateCommands : IJobParallelFor
		{
			[Token(Token = "0x4000779")]
			[FieldOffset(Offset = "0x0")]
			public NativeArray<RaycastCommand> commands;

			[Token(Token = "0x400077A")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<RaycastHit> raycastHits;

			[Token(Token = "0x400077B")]
			[FieldOffset(Offset = "0x20")]
			public float minStep;

			[Token(Token = "0x400077C")]
			[FieldOffset(Offset = "0x24")]
			public PhysicsScene physicsScene;

			[Token(Token = "0x6000B87")]
			[Address(RVA = "0x458117C", Offset = "0x457D17C", VA = "0x458117C", Slot = "4")]
			public void Execute(int index)
			{
 var hit=raycastHits[index];
 if (hit.normal.sqrMagnitude<1e-10f) {
  commands[index]=new RaycastCommand(physicsScene,Vector3.zero,Vector3.up,new QueryParameters(0,false,QueryTriggerInteraction.Ignore,false),1f);
 } else {
  var old=commands[index];
  var origin=hit.point+old.direction.normalized*minStep;
  float distance=old.distance-Vector3.Distance(origin,old.from);
  commands[index]=new RaycastCommand(physicsScene,origin,old.direction,new QueryParameters(old.queryParameters.layerMask,false,QueryTriggerInteraction.Ignore,false),distance);
 }
}
		}

		[Token(Token = "0x2000175")]
		[BurstCompile]
		private struct JobCombineResults : IJob
		{
			[Token(Token = "0x400077D")]
			[FieldOffset(Offset = "0x0")]
			public int maxHits;

			[Token(Token = "0x400077E")]
			[FieldOffset(Offset = "0x8")]
			[ReadOnly]
			public NativeArray<RaycastHit> semiResults;

			[Token(Token = "0x400077F")]
			[FieldOffset(Offset = "0x18")]
			public NativeArray<RaycastHit> results;

			[Token(Token = "0x6000B88")]
			[Address(RVA = "0x45814D4", Offset = "0x457D4D4", VA = "0x45814D4", Slot = "4")]
			public void Execute()
			{
 int stride=maxHits==0?0:semiResults.Length==int.MinValue&&maxHits==-1?int.MinValue:semiResults.Length/maxHits;
 for (int i=0;i<stride;i++) {
  int write=i;
  for (int layer=unchecked(maxHits-1);layer>=0;layer--) {
   var hit=semiResults[unchecked(i+stride*layer)];Unity.Mathematics.float3 normal=hit.normal;
   if (Unity.Mathematics.math.any(normal!=Unity.Mathematics.float3.zero)) { results[write]=hit;write=unchecked(write+stride); }
  }
 }
}
		}

		[Token(Token = "0x4000773")]
		[FieldOffset(Offset = "0x0")]
		private int maxHits;

		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x4")]
		public readonly float minStep;

		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0x8")]
		private NativeArray<RaycastHit> results;

		[Token(Token = "0x4000776")]
		[FieldOffset(Offset = "0x18")]
		private NativeArray<RaycastHit> semiResults;

		[Token(Token = "0x4000777")]
		[FieldOffset(Offset = "0x28")]
		private NativeArray<RaycastCommand> commands;

		[Token(Token = "0x4000778")]
		[FieldOffset(Offset = "0x38")]
		public PhysicsScene physicsScene;

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x4580E70", Offset = "0x457CE70", VA = "0x4580E70")]
		public JobRaycastAll(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, PhysicsScene physicsScene, int maxHits, Allocator allocator, JobDependencyTracker dependencyTracker, float minStep = 0.0001f)
		{
 if (maxHits<=0) throw new System.ArgumentException("maxHits should be greater than zero");
 if (unchecked(commands.Length*maxHits)>results.Length) throw new System.ArgumentException("Results array length does not match maxHits count");
 if (minStep<0f) throw new System.ArgumentException("minStep should be more or equal to zero");
 this.results=results;this.maxHits=maxHits;this.minStep=minStep;this.commands=commands;this.physicsScene=physicsScene;
 semiResults=dependencyTracker.NewNativeArray<RaycastHit>(unchecked(commands.Length*maxHits),allocator,NativeArrayOptions.ClearMemory);
}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x4580FC8", Offset = "0x457CFC8", VA = "0x4580FC8")]
		public JobHandle Schedule(JobHandle dependency)
		{
 for (int i=0;i<maxHits;i++) {
  var sub=semiResults.GetSubArray(unchecked(commands.Length*i),commands.Length);
  dependency=RaycastCommand.ScheduleBatch(commands,sub,128,dependency);
  if (i<unchecked(maxHits-1)) dependency=new JobCreateCommands { commands=commands,raycastHits=sub,minStep=minStep,physicsScene=physicsScene }.Schedule(commands.Length,256,dependency);
 }
 return new JobCombineResults { maxHits=maxHits,semiResults=semiResults,results=results }.Schedule(dependency);
}
	}
}
