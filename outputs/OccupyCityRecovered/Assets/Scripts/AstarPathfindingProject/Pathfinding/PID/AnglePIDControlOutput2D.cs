using Il2CppDummyDll;
using Unity.Mathematics;

namespace Pathfinding.PID
{
	[Token(Token = "0x2000262")]
	public struct AnglePIDControlOutput2D
	{
		[Token(Token = "0x4000B37")]
		[FieldOffset(Offset = "0x0")]
		public float rotationDelta;

		[Token(Token = "0x4000B38")]
		[FieldOffset(Offset = "0x4")]
		public float targetRotation;

		[Token(Token = "0x4000B39")]
		[FieldOffset(Offset = "0x8")]
		public float2 positionDelta;

		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x448B4A4", Offset = "0x44874A4", VA = "0x448B4A4")]
		public AnglePIDControlOutput2D(float currentRotation, float targetRotation, float rotationDelta, float moveDistance)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AnglePIDControlOutput2D..ctor RVA=0x448B4A4 Token=0x6000EF1");
}

		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x448B590", Offset = "0x4487590", VA = "0x448B590")]
		public static AnglePIDControlOutput2D WithMovementAtEnd(float currentRotation, float targetRotation, float rotationDelta, float moveDistance)
		{
			return default;
		}
	}
}
