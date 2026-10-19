using Il2CppDummyDll;
using Unity.Mathematics;

namespace Pathfinding.Util
{
	[Token(Token = "0x2000296")]
	public readonly struct ToPlaneMatrix
	{
		[Token(Token = "0x4000BCB")]
		[FieldOffset(Offset = "0x0")]
		public readonly float3x3 matrix;

		[Token(Token = "0x600105D")]
		[Address(RVA = "0x4493EC4", Offset = "0x448FEC4", VA = "0x4493EC4")]
		public ToPlaneMatrix(NativeMovementPlane plane)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ToPlaneMatrix..ctor RVA=0x4493EC4 Token=0x600105D");
}

		[Token(Token = "0x600105E")]
		[Address(RVA = "0x4493F10", Offset = "0x448FF10", VA = "0x4493F10")]
		public float2 ToPlane(float3 p)
		{
			return default;
		}

		[Token(Token = "0x600105F")]
		[Address(RVA = "0x4493F4C", Offset = "0x448FF4C", VA = "0x4493F4C")]
		public float3 ToXZPlane(float3 p)
		{
			return default;
		}

		[Token(Token = "0x6001060")]
		[Address(RVA = "0x4493F94", Offset = "0x448FF94", VA = "0x4493F94")]
		public float2 ToPlane(float3 p, out float elevation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ToPlaneMatrix.ToPlane RVA=0x4493F94 Token=0x6001060");
}
	}
}
