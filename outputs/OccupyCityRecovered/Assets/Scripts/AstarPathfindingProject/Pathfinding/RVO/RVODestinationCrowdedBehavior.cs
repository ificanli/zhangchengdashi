using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.RVO
{
	[Serializable]
	[Token(Token = "0x20002AC")]
	public struct RVODestinationCrowdedBehavior
	{
		[Token(Token = "0x20002AD")]
		[BurstCompile(CompileSynchronously = false, FloatMode = FloatMode.Fast)]
		public struct JobDensityCheck : IJobParallelForBatched
		{
			[Token(Token = "0x20002AE")]
			public struct QueryData
			{
				[Token(Token = "0x4000C36")]
				[FieldOffset(Offset = "0x0")]
				public float3 agentDestination;

				[Token(Token = "0x4000C37")]
				[FieldOffset(Offset = "0xC")]
				public int agentIndex;

				[Token(Token = "0x4000C38")]
				[FieldOffset(Offset = "0x10")]
				public float densityThreshold;
			}

			[Token(Token = "0x4000C2B")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			private RVOQuadtreeBurst quadtree;

			[Token(Token = "0x4000C2C")]
			[FieldOffset(Offset = "0x98")]
			[ReadOnly]
			public NativeArray<QueryData> data;

			[Token(Token = "0x4000C2D")]
			[FieldOffset(Offset = "0xA8")]
			[ReadOnly]
			public NativeArray<float3> agentPosition;

			[Token(Token = "0x4000C2E")]
			[FieldOffset(Offset = "0xB8")]
			[ReadOnly]
			private NativeArray<float3> agentTargetPoint;

			[Token(Token = "0x4000C2F")]
			[FieldOffset(Offset = "0xC8")]
			[ReadOnly]
			private NativeArray<float> agentRadius;

			[Token(Token = "0x4000C30")]
			[FieldOffset(Offset = "0xD8")]
			[ReadOnly]
			private NativeArray<float> agentDesiredSpeed;

			[Token(Token = "0x4000C31")]
			[FieldOffset(Offset = "0xE8")]
			[ReadOnly]
			private NativeArray<float3> agentOutputTargetPoint;

			[Token(Token = "0x4000C32")]
			[FieldOffset(Offset = "0xF8")]
			[ReadOnly]
			private NativeArray<float> agentOutputSpeed;

			[Token(Token = "0x4000C33")]
			[FieldOffset(Offset = "0x108")]
			[WriteOnly]
			public NativeArray<bool> outThresholdResult;

			[Token(Token = "0x4000C34")]
			[FieldOffset(Offset = "0x118")]
			public NativeArray<float> progressAverage;

			[Token(Token = "0x4000C35")]
			[FieldOffset(Offset = "0x128")]
			public float deltaTime;

			[Token(Token = "0x17000277")]
			public bool allowBoundsChecks
			{
				[Token(Token = "0x60010F4")]
				[Address(RVA = "0x449AE80", Offset = "0x4496E80", VA = "0x449AE80", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60010F5")]
			[Address(RVA = "0x449AE88", Offset = "0x4496E88", VA = "0x449AE88")]
			public JobDensityCheck(int size, float deltaTime, SimulatorBurst simulator)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RVODestinationCrowdedBehavior.JobDensityCheck..ctor RVA=0x449AE88 Token=0x60010F5");
}

			[Token(Token = "0x60010F6")]
			[Address(RVA = "0x449AFDC", Offset = "0x4496FDC", VA = "0x449AFDC")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60010F7")]
			[Address(RVA = "0x449B06C", Offset = "0x449706C", VA = "0x449B06C")]
			public void Set(int index, int rvoAgentIndex, float3 destination, float densityThreshold, float progressAverage)
			{
			}

			[Token(Token = "0x60010F8")]
			[Address(RVA = "0x449B094", Offset = "0x4497094", VA = "0x449B094", Slot = "5")]
void IJobParallelForBatched.Execute(int start, int count)
			{
			}

			[Token(Token = "0x60010F9")]
			[Address(RVA = "0x449B4C4", Offset = "0x44974C4", VA = "0x449B4C4")]
			private float AgentDensityInCircle(float3 position, float radius)
			{
				return default;
			}

			[Token(Token = "0x60010FA")]
			[Address(RVA = "0x449B0D8", Offset = "0x44970D8", VA = "0x449B0D8")]
			private void Execute(int i)
			{
			}
		}

		[Token(Token = "0x4000C1A")]
		[FieldOffset(Offset = "0x0")]
		public bool enabled;

		[Token(Token = "0x4000C1B")]
		[FieldOffset(Offset = "0x4")]
		[Range(0f, 1f)]
		public float densityThreshold;

		[Token(Token = "0x4000C1C")]
		[FieldOffset(Offset = "0x8")]
		public bool returnAfterBeingPushedAway;

		[Token(Token = "0x4000C1D")]
		[FieldOffset(Offset = "0xC")]
		public float progressAverage;

		[Token(Token = "0x4000C1E")]
		[FieldOffset(Offset = "0x10")]
		private bool wasEnabled;

		[Token(Token = "0x4000C1F")]
		[FieldOffset(Offset = "0x14")]
		private float timer1;

		[Token(Token = "0x4000C20")]
		[FieldOffset(Offset = "0x18")]
		private float shouldStopDelayTimer;

		[Token(Token = "0x4000C21")]
		[FieldOffset(Offset = "0x1C")]
		private bool lastShouldStopResult;

		[Token(Token = "0x4000C22")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 lastShouldStopDestination;

		[Token(Token = "0x4000C23")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 reachedDestinationPoint;

		[Token(Token = "0x4000C24")]
		[FieldOffset(Offset = "0x38")]
		public bool lastJobDensityResult;

		[Token(Token = "0x4000C25")]
		private const float MaximumCirclePackingDensity = 0.9069f;

		[Token(Token = "0x4000C27")]
		[FieldOffset(Offset = "0x3A")]
		private bool wasStopped;

		[Token(Token = "0x4000C28")]
		private const float DefaultPriority = 1f;

		[Token(Token = "0x4000C29")]
		private const float StoppedPriority = 0.1f;

		[Token(Token = "0x4000C2A")]
		private const float MoveBackPriority = 0.5f;

		[Token(Token = "0x17000276")]
		public bool reachedDestination
		{
			[Token(Token = "0x60010F1")]
			[Address(RVA = "0x449AB5C", Offset = "0x4496B5C", VA = "0x449AB5C")]
			[CompilerGenerated]
			readonly get
			{
				return default;
			}
			[Token(Token = "0x60010F2")]
			[Address(RVA = "0x449AB64", Offset = "0x4496B64", VA = "0x449AB64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60010ED")]
		[Address(RVA = "0x449AA2C", Offset = "0x4496A2C", VA = "0x449AA2C")]
		public void ReadJobResult(ref JobDensityCheck jobResult, int index)
		{
		}

		[Token(Token = "0x60010EE")]
		[Address(RVA = "0x449AAF4", Offset = "0x4496AF4", VA = "0x449AAF4")]
		public RVODestinationCrowdedBehavior(bool enabled, float densityFraction, bool returnAfterBeingPushedAway)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RVODestinationCrowdedBehavior..ctor RVA=0x449AAF4 Token=0x60010EE");
}

		[Token(Token = "0x60010EF")]
		[Address(RVA = "0x449AB38", Offset = "0x4496B38", VA = "0x449AB38")]
		public void ClearDestinationReached()
		{
		}

		[Token(Token = "0x60010F0")]
		[Address(RVA = "0x449AB48", Offset = "0x4496B48", VA = "0x449AB48")]
		public void OnDestinationChanged(Vector3 newDestination, bool reachedDestination)
		{
		}

		[Token(Token = "0x60010F3")]
		[Address(RVA = "0x449AB70", Offset = "0x4496B70", VA = "0x449AB70")]
		public void Update(bool rvoControllerEnabled, bool reachedDestination, ref bool isStopped, ref float rvoPriorityMultiplier, ref float rvoFlowFollowingStrength, Vector3 agentPosition)
		{
		}
	}
}
