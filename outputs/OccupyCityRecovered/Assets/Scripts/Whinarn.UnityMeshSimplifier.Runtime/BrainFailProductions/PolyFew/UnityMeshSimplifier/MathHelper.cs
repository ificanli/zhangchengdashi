using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x200001F")]
	public static class MathHelper
	{
		[Token(Token = "0x40000DC")]
		public const float PI = (float)Math.PI;

		[Token(Token = "0x40000DD")]
		public const double PId = Math.PI;

		[Token(Token = "0x40000DE")]
		public const float Deg2Rad = (float)Math.PI / 180f;

		[Token(Token = "0x40000DF")]
		public const double Deg2Radd = Math.PI / 180.0;

		[Token(Token = "0x40000E0")]
		public const float Rad2Deg = 180f / (float)Math.PI;

		[Token(Token = "0x40000E1")]
		public const double Rad2Degd = 180.0 / Math.PI;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x856A354", Offset = "0x8566354", VA = "0x856A354")]
		public static double Min(double val1, double val2, double val3)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x856A384", Offset = "0x8566384", VA = "0x856A384")]
		public static double Clamp(double value, double min, double max)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x856A3A4", Offset = "0x85663A4", VA = "0x856A3A4")]
		public static double TriangleArea(ref Vector3d p0, ref Vector3d p1, ref Vector3d p2)
		{
			return default;
		}
	}
}
