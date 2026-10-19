using Beebyte.Obfuscator;
using Il2CppDummyDll;
using Unity.Burst;

namespace RVO2
{
	[Token(Token = "0x2000F04")]
	[BurstCompile]
	[Skip]
	public struct DistanceObstacle
	{
		[Token(Token = "0x4006822")]
		[FieldOffset(Offset = "0x0")]
		public float distance;

		[Token(Token = "0x4006823")]
		[FieldOffset(Offset = "0x8")]
		public unsafe Obstacle* obstacle;

		[Token(Token = "0x6005A5D")]
		[Address(RVA = "0x4392258", Offset = "0x438E258", VA = "0x4392258")]
		public unsafe DistanceObstacle(float distance, Obstacle* obstacle)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DistanceObstacle..ctor RVA=0x4392258 Token=0x6005A5D");
}
	}
}
