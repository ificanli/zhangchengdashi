using Il2CppDummyDll;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000051")]
	public static class AstarMath
	{
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x0")]
		private static Unity.Mathematics.Random GlobalRandom;

		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x8")]
		private static object GlobalRandomLock;

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x4465964", Offset = "0x4461964", VA = "0x4465964")]
		public static float ThreadSafeRandomFloat()
		{
			return default;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x4465A9C", Offset = "0x4461A9C", VA = "0x4465A9C")]
		public static float2 ThreadSafeRandomFloat2()
		{
			return default;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x4465C00", Offset = "0x4461C00", VA = "0x4465C00")]
		public static long SaturatingConvertFloatToLong(float v)
		{
			return default;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x4465C30", Offset = "0x4461C30", VA = "0x4465C30")]
		public static float MapTo(float startMin, float startMax, float targetMin, float targetMax, float value)
		{
			return default;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x4465C74", Offset = "0x4461C74", VA = "0x4465C74")]
		private static int Bit(int a, int b)
		{
			return default;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x445CEE4", Offset = "0x4458EE4", VA = "0x445CEE4")]
		public static Color IntToColor(int i, float a)
		{
			return default;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x4465C80", Offset = "0x4461C80", VA = "0x4465C80")]
		public static Color HSVToRGB(float h, float s, float v)
		{
			return default;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x4465DCC", Offset = "0x4461DCC", VA = "0x4465DCC")]
		public static float DeltaAngle(float angle1, float angle2)
		{
			return default;
		}
	}
}
