using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002B2")]
	[BurstCompile(FloatMode = FloatMode.Fast)]
	public struct JobHardCollisions<MovementPlaneWrapper> : IJobParallelForBatched where MovementPlaneWrapper : struct, IMovementPlaneWrapper
	{
		[Token(Token = "0x4000C48")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.AgentData agentData;

		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<int> neighbours;

		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public NativeArray<float2> collisionVelocityOffsets;

		[Token(Token = "0x4000C4B")]
		[FieldOffset(Offset = "0x0")]
		public float deltaTime;

		[Token(Token = "0x4000C4C")]
		[FieldOffset(Offset = "0x0")]
		public bool enabled;

		[Token(Token = "0x4000C4D")]
		private const float CollisionStrength = 0.8f;

		[Token(Token = "0x1700027A")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x6001102")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001103")]
		public void Execute(int startIndex, int count)
		{
		}
	}
}
