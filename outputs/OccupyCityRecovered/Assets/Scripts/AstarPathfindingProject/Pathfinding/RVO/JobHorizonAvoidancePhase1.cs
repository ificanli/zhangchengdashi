using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002B0")]
	[BurstCompile(FloatMode = FloatMode.Fast)]
	public struct JobHorizonAvoidancePhase1<MovementPlaneWrapper> : IJobParallelForBatched where MovementPlaneWrapper : struct, IMovementPlaneWrapper
	{
		[Token(Token = "0x4000C3E")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.AgentData agentData;

		[Token(Token = "0x4000C3F")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<float2> desiredTargetPointInVelocitySpace;

		[Token(Token = "0x4000C40")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<int> neighbours;

		[Token(Token = "0x4000C41")]
		[FieldOffset(Offset = "0x0")]
		public SimulatorBurst.HorizonAgentData horizonAgentData;

		[Token(Token = "0x17000278")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x60010FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60010FD")]
		private static void Sort<T>(NativeSlice<T> arr, NativeSlice<float> keys) where T : struct
		{
		}

		[Token(Token = "0x60010FE")]
		public static float DeltaAngle(float current, float target)
		{
			return default;
		}

		[Token(Token = "0x60010FF")]
		public void Execute(int startIndex, int count)
		{
		}
	}
}
