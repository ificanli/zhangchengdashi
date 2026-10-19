using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002B4")]
	[BurstCompile(CompileSynchronously = false, FloatMode = FloatMode.Fast)]
	public struct JobDestinationReached<MovementPlaneWrapper> : IJob where MovementPlaneWrapper : struct, IMovementPlaneWrapper
	{
		[Token(Token = "0x20002B5")]
		private struct TempAgentData
		{
			[Token(Token = "0x4000C59")]
			[FieldOffset(Offset = "0x0")]
			public bool blockedAndSlow;

			[Token(Token = "0x4000C5A")]
			[FieldOffset(Offset = "0x0")]
			public float distToEndSq;
		}

		[Token(Token = "0x4000C52")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.AgentData agentData;

		[Token(Token = "0x4000C53")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.TemporaryAgentData temporaryAgentData;

		[Token(Token = "0x4000C54")]
		[FieldOffset(Offset = "0x0")]
		public SimulatorBurst.AgentOutputData output;

		[Token(Token = "0x4000C55")]
		[FieldOffset(Offset = "0x0")]
		public int numAgents;

		[Token(Token = "0x4000C56")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerInvert;

		[Token(Token = "0x4000C57")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerAlloc;

		[Token(Token = "0x4000C58")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerFirstPass;

		[Token(Token = "0x6001107")]
		public void Execute()
		{
		}
	}
}
