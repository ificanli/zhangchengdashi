using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace andywiecko.BurstTriangulator
{
	[Token(Token = "0x2000013")]
	public static class Extensions
	{
		[Token(Token = "0x600005B")]
		[Obsolete("Use AsNativeArray(out Handle) instead! You can learn more in the project manual.")]
		public static NativeArray<T> AsNativeArray<T>(this T[] array) where T : unmanaged
		{
			return default;
		}

		[Token(Token = "0x600005C")]
		public static NativeArray<T> AsNativeArray<T>(this T[] array, out Handle handle) where T : unmanaged
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Extensions.AsNativeArray RVA= Token=0x600005C");
}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x3CF359C", Offset = "0x3CEF59C", VA = "0x3CF359C")]
		public static void Run(this Triangulator<float2> @this)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x3CF3640", Offset = "0x3CEF640", VA = "0x3CF3640")]
		public static JobHandle Schedule(this Triangulator<float2> @this, [Optional] JobHandle dependencies)
		{
			return default;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x3CF36FC", Offset = "0x3CEF6FC", VA = "0x3CF36FC")]
		public static void Run(this Triangulator<Vector2> @this)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x3CF3950", Offset = "0x3CEF950", VA = "0x3CF3950")]
		public static JobHandle Schedule(this Triangulator<Vector2> @this, [Optional] JobHandle dependencies)
		{
			return default;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x3CF3434", Offset = "0x3CEF434", VA = "0x3CF3434")]
		public static void Run(this Triangulator<double2> @this)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x3CF34E0", Offset = "0x3CEF4E0", VA = "0x3CF34E0")]
		public static JobHandle Schedule(this Triangulator<double2> @this, [Optional] JobHandle dependencies)
		{
			return default;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x3CF3B5C", Offset = "0x3CEFB5C", VA = "0x3CF3B5C")]
		public static void Run(this Triangulator<int2> @this)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x3CF3C00", Offset = "0x3CEFC00", VA = "0x3CF3C00")]
		public static JobHandle Schedule(this Triangulator<int2> @this, [Optional] JobHandle dependencies)
		{
			return default;
		}
	}
}
