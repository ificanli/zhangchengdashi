using Il2CppDummyDll;
using Pathfinding.ECS.RVO;
using Pathfinding.Jobs;
using Pathfinding.Util;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002B1")]
	[BurstCompile(FloatMode = FloatMode.Fast)]
	public struct JobHorizonAvoidancePhase2<MovementPlaneWrapper> : IJobParallelForBatched where MovementPlaneWrapper : struct, IMovementPlaneWrapper
	{
		[Token(Token = "0x4000C42")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<int> neighbours;

		[Token(Token = "0x4000C43")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<AgentIndex> versions;

		[Token(Token = "0x4000C44")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<float3> desiredVelocity;

		[Token(Token = "0x4000C45")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<float2> desiredTargetPointInVelocitySpace;

		[Token(Token = "0x4000C46")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<NativeMovementPlane> movementPlane;

		[Token(Token = "0x4000C47")]
		[FieldOffset(Offset = "0x0")]
		public SimulatorBurst.HorizonAgentData horizonAgentData;

		[Token(Token = "0x17000279")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x6001100")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001101")]
		public void Execute(int startIndex, int count)
		{
		}
	}
}
