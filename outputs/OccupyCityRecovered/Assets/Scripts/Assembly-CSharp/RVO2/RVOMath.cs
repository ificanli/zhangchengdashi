using System;
using System.Runtime.CompilerServices;
using Beebyte.Obfuscator;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Mathematics;

namespace RVO2
{
	[Token(Token = "0x2000F0D")]
	[Skip]
	[BurstCompile]
	public struct RVOMath
	{
		[Token(Token = "0x2000F0E")]
		public delegate float fabs_0000A001_0024PostfixBurstDelegate(float scalar);

		[Token(Token = "0x2000F0F")]
		internal static class fabs_0000A001_0024BurstDirectCall
		{
			[Token(Token = "0x4006854")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4006855")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6005A89")]
			[Address(RVA = "0x4395A80", Offset = "0x4391A80", VA = "0x4395A80")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6005A8A")]
			[Address(RVA = "0x4395B9C", Offset = "0x4391B9C", VA = "0x4395B9C")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6005A8B")]
			[Address(RVA = "0x4395BF8", Offset = "0x4391BF8", VA = "0x4395BF8")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6005A8C")]
			[Address(RVA = "0x4395CA0", Offset = "0x4391CA0", VA = "0x4395CA0")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6005A8E")]
			[Address(RVA = "0x439560C", Offset = "0x439160C", VA = "0x439560C")]
			public static float Invoke(float scalar)
			{
				return default;
			}
		}

		[Token(Token = "0x2000F10")]
		public delegate float sqr_0000A003_0024PostfixBurstDelegate(float scalar);

		[Token(Token = "0x2000F11")]
		internal static class sqr_0000A003_0024BurstDirectCall
		{
			[Token(Token = "0x4006856")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4006857")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6005A93")]
			[Address(RVA = "0x4395DF4", Offset = "0x4391DF4", VA = "0x4395DF4")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6005A94")]
			[Address(RVA = "0x4395F10", Offset = "0x4391F10", VA = "0x4395F10")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6005A95")]
			[Address(RVA = "0x4395F6C", Offset = "0x4391F6C", VA = "0x4395F6C")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6005A96")]
			[Address(RVA = "0x4396014", Offset = "0x4392014", VA = "0x4396014")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6005A98")]
			[Address(RVA = "0x43956EC", Offset = "0x43916EC", VA = "0x43956EC")]
			public static float Invoke(float scalar)
			{
				return default;
			}
		}

		[Token(Token = "0x2000F12")]
		public delegate float sqrt_0000A004_0024PostfixBurstDelegate(float scalar);

		[Token(Token = "0x2000F13")]
		internal static class sqrt_0000A004_0024BurstDirectCall
		{
			[Token(Token = "0x4006858")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4006859")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6005A9D")]
			[Address(RVA = "0x4396168", Offset = "0x4392168", VA = "0x4396168")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6005A9E")]
			[Address(RVA = "0x4396284", Offset = "0x4392284", VA = "0x4396284")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6005A9F")]
			[Address(RVA = "0x43962E0", Offset = "0x43922E0", VA = "0x43962E0")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6005AA0")]
			[Address(RVA = "0x4396388", Offset = "0x4392388", VA = "0x4396388")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6005AA2")]
			[Address(RVA = "0x4395794", Offset = "0x4391794", VA = "0x4395794")]
			public static float Invoke(float scalar)
			{
				return default;
			}
		}

		[Token(Token = "0x4006853")]
		internal const float RVO_EPSILON = 1E-05f;

		[Token(Token = "0x6005A79")]
		[Address(RVA = "0x4395598", Offset = "0x4391598", VA = "0x4395598")]
		public static float abs(Vector2 vector)
		{
			return default;
		}

		[Token(Token = "0x6005A7A")]
		[Address(RVA = "0x43955A8", Offset = "0x43915A8", VA = "0x43955A8")]
		public static float absSq(Vector2 vector)
		{
			return default;
		}

		[Token(Token = "0x6005A7B")]
		[Address(RVA = "0x43955C8", Offset = "0x43915C8", VA = "0x43955C8")]
		public static Vector2 normalize(Vector2 vector)
		{
			return default;
		}

		[Token(Token = "0x6005A7C")]
		[Address(RVA = "0x439305C", Offset = "0x438F05C", VA = "0x439305C")]
		internal static float det(float2 vector1, float2 vector2)
		{
			return default;
		}

		[Token(Token = "0x6005A7D")]
		[Address(RVA = "0x4393AE0", Offset = "0x438FAE0", VA = "0x4393AE0")]
		internal static float distSqPointLineSegment(float2 vector1, float2 vector2, float2 vector3)
		{
			return default;
		}

		[Token(Token = "0x6005A7E")]
		[Address(RVA = "0x4393EE0", Offset = "0x438FEE0", VA = "0x4393EE0")]
		[Skip]
		[BurstCompile]
		internal static float fabs(float scalar)
		{
			return default;
		}

		[Token(Token = "0x6005A7F")]
		[Address(RVA = "0x43954A0", Offset = "0x43914A0", VA = "0x43954A0")]
		internal static float leftOf(float2 a, float2 b, float2 c)
		{
			return default;
		}

		[Token(Token = "0x6005A80")]
		[Address(RVA = "0x4392340", Offset = "0x438E340", VA = "0x4392340")]
		[Skip]
		[BurstCompile]
		internal static float sqr(float scalar)
		{
			return default;
		}

		[Token(Token = "0x6005A81")]
		[Address(RVA = "0x439306C", Offset = "0x438F06C", VA = "0x439306C")]
		[BurstCompile]
		[Skip]
		internal static float sqrt(float scalar)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6005A82")]
		[Address(RVA = "0x4395874", Offset = "0x4391874", VA = "0x4395874")]
		[Skip]
		[BurstCompile]
		public static float fabs_0024BurstManaged(float scalar)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6005A83")]
		[Address(RVA = "0x43958D0", Offset = "0x43918D0", VA = "0x43958D0")]
		[BurstCompile]
		[Skip]
		public static float sqr_0024BurstManaged(float scalar)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6005A84")]
		[Address(RVA = "0x43958D8", Offset = "0x43918D8", VA = "0x43958D8")]
		[BurstCompile]
		[Skip]
		public static float sqrt_0024BurstManaged(float scalar)
		{
			return default;
		}
	}
}
