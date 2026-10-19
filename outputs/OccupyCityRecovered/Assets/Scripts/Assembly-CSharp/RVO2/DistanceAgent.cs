using Beebyte.Obfuscator;
using Il2CppDummyDll;
using Unity.Burst;

namespace RVO2
{
	[Token(Token = "0x2000F05")]
	[Skip]
	[BurstCompile]
	public struct DistanceAgent
	{
		[Token(Token = "0x4006824")]
		[FieldOffset(Offset = "0x0")]
		public float distance;

		[Token(Token = "0x4006825")]
		[FieldOffset(Offset = "0x8")]
		public unsafe Agent* agent;

		[Token(Token = "0x6005A5E")]
		[Address(RVA = "0x4392264", Offset = "0x438E264", VA = "0x4392264")]
		public unsafe DistanceAgent(float distance, Agent* agent)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DistanceAgent..ctor RVA=0x4392264 Token=0x6005A5E");
}
	}
}
