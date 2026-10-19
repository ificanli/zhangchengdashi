using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000011")]
	public static class InternalClipper
	{
		[Token(Token = "0x2000012")]
		public struct MultiplyUInt64Result
		{
			[Token(Token = "0x400002A")]
			[FieldOffset(Offset = "0x0")]
			public ulong lo64;

			[Token(Token = "0x400002B")]
			[FieldOffset(Offset = "0x8")]
			public ulong hi64;
		}

		[Token(Token = "0x4000021")]
		internal const long MaxInt64 = long.MaxValue;

		[Token(Token = "0x4000022")]
		internal const long MaxCoord = 2305843009213693951L;

		[Token(Token = "0x4000023")]
		internal const double max_coord = 2.305843009213694E+18;

		[Token(Token = "0x4000024")]
		internal const double min_coord = -2.305843009213694E+18;

		[Token(Token = "0x4000025")]
		internal const long Invalid64 = long.MaxValue;

		[Token(Token = "0x4000026")]
		internal const double defaultArcTolerance = 0.25;

		[Token(Token = "0x4000027")]
		internal const double floatingPointTolerance = 1E-12;

		[Token(Token = "0x4000028")]
		internal const double defaultMinimumEdgeLength = 0.1;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string precision_range_error;

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x46004D0", Offset = "0x45FC4D0", VA = "0x46004D0")]
		public static double CrossProduct(Point64 pt1, Point64 pt2, Point64 pt3)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x4600500", Offset = "0x45FC500", VA = "0x4600500")]
		internal static void CheckPrecision(int precision)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x4600574", Offset = "0x45FC574", VA = "0x4600574")]
		internal static bool IsAlmostZero(double value)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x46005E0", Offset = "0x45FC5E0", VA = "0x46005E0")]
		internal static int TriSign(long x)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x46005F8", Offset = "0x45FC5F8", VA = "0x46005F8")]
		public static MultiplyUInt64Result MultiplyUInt64(ulong a, ulong b)
		{
			return default;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x4600634", Offset = "0x45FC634", VA = "0x4600634")]
		internal static bool ProductsAreEqual(long a, long b, long c, long d)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x46007C0", Offset = "0x45FC7C0", VA = "0x46007C0")]
		internal static bool IsCollinear(Point64 pt1, Point64 sharedPt, Point64 pt2)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x460084C", Offset = "0x45FC84C", VA = "0x460084C")]
		internal static double DotProduct(Point64 pt1, Point64 pt2, Point64 pt3)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x460087C", Offset = "0x45FC87C", VA = "0x460087C")]
		internal static double CrossProduct(PointD vec1, PointD vec2)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x460088C", Offset = "0x45FC88C", VA = "0x460088C")]
		internal static double DotProduct(PointD vec1, PointD vec2)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x460089C", Offset = "0x45FC89C", VA = "0x460089C")]
		internal static long CheckCastInt64(double val)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x4600974", Offset = "0x45FC974", VA = "0x4600974")]
		public static bool GetSegmentIntersectPt(Point64 ln1a, Point64 ln1b, Point64 ln2a, Point64 ln2b, out Point64 ip)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED InternalClipper.GetSegmentIntersectPt RVA=0x4600974 Token=0x600004E");
}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x4600A44", Offset = "0x45FCA44", VA = "0x4600A44")]
		internal static bool SegsIntersect(Point64 seg1a, Point64 seg1b, Point64 seg2a, Point64 seg2b, bool inclusive = false)
		{
			return default;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x4600C34", Offset = "0x45FCC34", VA = "0x4600C34")]
		public static Point64 GetClosestPtOnSegment(Point64 offPt, Point64 seg1, Point64 seg2)
		{
			return default;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x4600DEC", Offset = "0x45FCDEC", VA = "0x4600DEC")]
		public static PointInPolygonResult PointInPolygon(Point64 pt, List<Point64> polygon)
		{
			return default;
		}
	}
}
