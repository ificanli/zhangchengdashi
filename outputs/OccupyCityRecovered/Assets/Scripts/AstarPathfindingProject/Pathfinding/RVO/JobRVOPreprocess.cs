using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002AF")]
	[BurstCompile(CompileSynchronously = false, FloatMode = FloatMode.Fast)]
	public struct JobRVOPreprocess<MovementPlaneWrapper> : IJob where MovementPlaneWrapper : struct, IMovementPlaneWrapper
	{
		[Token(Token = "0x4000C39")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.AgentData agentData;

		[Token(Token = "0x4000C3A")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.AgentOutputData previousOutput;

		[Token(Token = "0x4000C3B")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public SimulatorBurst.TemporaryAgentData temporaryAgentData;

		[Token(Token = "0x4000C3C")]
		[FieldOffset(Offset = "0x0")]
		public int startIndex;

		[Token(Token = "0x4000C3D")]
		[FieldOffset(Offset = "0x0")]
		public int endIndex;

		[Token(Token = "0x60010FB")]
		public void Execute()
		{
		}
	}
}
