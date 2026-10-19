using Il2CppDummyDll;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Util
{
	[Token(Token = "0x2000297")]
	public readonly struct ToWorldMatrix
	{
		[Token(Token = "0x4000BCC")]
		[FieldOffset(Offset = "0x0")]
		public readonly float3x3 matrix;

		[Token(Token = "0x6001061")]
		[Address(RVA = "0x4493FEC", Offset = "0x448FFEC", VA = "0x4493FEC")]
		public ToWorldMatrix(NativeMovementPlane plane)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ToWorldMatrix..ctor RVA=0x4493FEC Token=0x6001061");
}

		[Token(Token = "0x6001062")]
		[Address(RVA = "0x449402C", Offset = "0x449002C", VA = "0x449402C")]
		public ToWorldMatrix(float3x3 matrix)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ToWorldMatrix..ctor RVA=0x449402C Token=0x6001062");
}

		[Token(Token = "0x6001063")]
		[Address(RVA = "0x4494040", Offset = "0x4490040", VA = "0x4494040")]
		public float3 ToWorld(float2 p, float elevation = 0f)
		{
			return default;
		}

		[Token(Token = "0x6001064")]
		[Address(RVA = "0x4494088", Offset = "0x4490088", VA = "0x4494088")]
		public Bounds ToWorld(Bounds bounds)
		{
			return default;
		}
	}
}
