using Beebyte.Obfuscator;
using Il2CppDummyDll;
using Unity.Burst;

namespace RVO2
{
	[Token(Token = "0x2000F16")]
	[Skip]
	[BurstCompile]
	public struct Vector2
	{
		[Token(Token = "0x4006869")]
		[FieldOffset(Offset = "0x0")]
		internal float x_;

		[Token(Token = "0x400686A")]
		[FieldOffset(Offset = "0x4")]
		internal float y_;

		[Token(Token = "0x6005AD9")]
		[Address(RVA = "0x43992B0", Offset = "0x43952B0", VA = "0x43992B0")]
		public Vector2(float x, float y)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Vector2..ctor RVA=0x43992B0 Token=0x6005AD9");
}

		[Token(Token = "0x6005ADA")]
		[Address(RVA = "0x43992B8", Offset = "0x43952B8", VA = "0x43992B8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6005ADB")]
		[Address(RVA = "0x439945C", Offset = "0x439545C", VA = "0x439945C")]
		public float x()
		{
			return default;
		}

		[Token(Token = "0x6005ADC")]
		[Address(RVA = "0x4399464", Offset = "0x4395464", VA = "0x4399464")]
		public float y()
		{
			return default;
		}

		[Token(Token = "0x6005ADD")]
		[Address(RVA = "0x43955B8", Offset = "0x43915B8", VA = "0x43955B8")]
		public static float operator *(Vector2 vector1, Vector2 vector2)
		{
			return default;
		}

		[Token(Token = "0x6005ADE")]
		[Address(RVA = "0x439946C", Offset = "0x439546C", VA = "0x439946C")]
		public static Vector2 operator *(float scalar, Vector2 vector)
		{
			return default;
		}

		[Token(Token = "0x6005ADF")]
		[Address(RVA = "0x439947C", Offset = "0x439547C", VA = "0x439947C")]
		public static Vector2 operator *(Vector2 vector, float scalar)
		{
			return default;
		}

		[Token(Token = "0x6005AE0")]
		[Address(RVA = "0x4395600", Offset = "0x4391600", VA = "0x4395600")]
		public static Vector2 operator /(Vector2 vector, float scalar)
		{
			return default;
		}

		[Token(Token = "0x6005AE1")]
		[Address(RVA = "0x4399488", Offset = "0x4395488", VA = "0x4399488")]
		public static Vector2 operator +(Vector2 vector1, Vector2 vector2)
		{
			return default;
		}

		[Token(Token = "0x6005AE2")]
		[Address(RVA = "0x4399494", Offset = "0x4395494", VA = "0x4399494")]
		public static Vector2 operator -(Vector2 vector1, Vector2 vector2)
		{
			return default;
		}

		[Token(Token = "0x6005AE3")]
		[Address(RVA = "0x43994A0", Offset = "0x43954A0", VA = "0x43994A0")]
		public static Vector2 operator -(Vector2 vector)
		{
			return default;
		}
	}
}
