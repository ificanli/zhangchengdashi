using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Burst;
using Unity.Collections;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002B3")]
	[BurstCompile(CompileSynchronously = false, FloatMode = FloatMode.Fast)]
	public struct JobRVOCalculateNeighbours<MovementPlaneWrapper> : IJobParallelForBatched where MovementPlaneWrapper : struct, IMovementPlaneWrapper
	{
		[Token(Token = "0x4000C4E")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.AgentData agentData;

		[Token(Token = "0x4000C4F")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public RVOQuadtreeBurst quadtree;

		[Token(Token = "0x4000C50")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<int> outNeighbours;

		[Token(Token = "0x4000C51")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public SimulatorBurst.AgentOutputData output;

		[Token(Token = "0x1700027B")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x6001104")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001105")]
		public void Execute(int startIndex, int count)
		{
		}

		[Token(Token = "0x6001106")]
		private void CalculateNeighbours(int agentIndex, NativeArray<int> neighbours, NativeArray<float> neighbourDistances)
		{
		}
	}
}
