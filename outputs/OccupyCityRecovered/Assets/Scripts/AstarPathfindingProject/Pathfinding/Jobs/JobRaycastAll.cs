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
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED JobRaycastAll..ctor RVA=0x4580E70 Token=0x6000B85");
}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x4580FC8", Offset = "0x457CFC8", VA = "0x4580FC8")]
		public JobHandle Schedule(JobHandle dependency)
		{
			return default;
		}
	}
}
