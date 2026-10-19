using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000013")]
	public static class Clipper
	{
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x0")]
		private static Rect64 invalidRect64;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x20")]
		private static RectD invalidRectD;

		[Token(Token = "0x17000005")]
		public static Rect64 InvalidRect64
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x4601220", Offset = "0x45FD220", VA = "0x4601220")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000006")]
		public static RectD InvalidRectD
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x4601280", Offset = "0x45FD280", VA = "0x4601280")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x46012DC", Offset = "0x45FD2DC", VA = "0x46012DC")]
		public static List<List<Point64>> Intersect(List<List<Point64>> subject, List<List<Point64>> clip, FillRule fillRule)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x46014B0", Offset = "0x45FD4B0", VA = "0x46014B0")]
		public static PathsD Intersect(PathsD subject, PathsD clip, FillRule fillRule, int precision = 2)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x46016F4", Offset = "0x45FD6F4", VA = "0x46016F4")]
		public static List<List<Point64>> Union(List<List<Point64>> subject, FillRule fillRule)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x4601760", Offset = "0x45FD760", VA = "0x4601760")]
		public static List<List<Point64>> Union(List<List<Point64>> subject, List<List<Point64>> clip, FillRule fillRule)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x46017D0", Offset = "0x45FD7D0", VA = "0x46017D0")]
		public static PathsD Union(PathsD subject, FillRule fillRule)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x4601840", Offset = "0x45FD840", VA = "0x4601840")]
		public static PathsD Union(PathsD subject, PathsD clip, FillRule fillRule, int precision = 2)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x46018C0", Offset = "0x45FD8C0", VA = "0x46018C0")]
		public static List<List<Point64>> Difference(List<List<Point64>> subject, List<List<Point64>> clip, FillRule fillRule)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x4601930", Offset = "0x45FD930", VA = "0x4601930")]
		public static PathsD Difference(PathsD subject, PathsD clip, FillRule fillRule, int precision = 2)
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x46019B0", Offset = "0x45FD9B0", VA = "0x46019B0")]
		public static List<List<Point64>> Xor(List<List<Point64>> subject, List<List<Point64>> clip, FillRule fillRule)
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x4601A20", Offset = "0x45FDA20", VA = "0x4601A20")]
		public static PathsD Xor(PathsD subject, PathsD clip, FillRule fillRule, int precision = 2)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x460134C", Offset = "0x45FD34C", VA = "0x460134C")]
		public static List<List<Point64>> BooleanOp(ClipType clipType, List<List<Point64>>? subject, List<List<Point64>>? clip, FillRule fillRule)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x4601AA0", Offset = "0x45FDAA0", VA = "0x4601AA0")]
		public static void BooleanOp(ClipType clipType, List<List<Point64>>? subject, List<List<Point64>>? clip, PolyTree64 polytree, FillRule fillRule)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x4601530", Offset = "0x45FD530", VA = "0x4601530")]
		public static PathsD BooleanOp(ClipType clipType, PathsD subject, PathsD? clip, FillRule fillRule, int precision = 2)
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x4601BE0", Offset = "0x45FDBE0", VA = "0x4601BE0")]
		public static void BooleanOp(ClipType clipType, PathsD? subject, PathsD? clip, PolyTreeD polytree, FillRule fillRule, int precision = 2)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x4601D68", Offset = "0x45FDD68", VA = "0x4601D68")]
		public static List<List<Point64>> InflatePaths(List<List<Point64>> paths, double delta, JoinType joinType, EndType endType, double miterLimit = 2.0)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x4601E68", Offset = "0x45FDE68", VA = "0x4601E68")]
		public static PathsD InflatePaths(PathsD paths, double delta, JoinType joinType, EndType endType, double miterLimit = 2.0, int precision = 2)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x46024D4", Offset = "0x45FE4D4", VA = "0x46024D4")]
		public static List<List<Point64>> RectClip(Rect64 rect, List<List<Point64>> paths)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x46025D8", Offset = "0x45FE5D8", VA = "0x46025D8")]
		public static List<List<Point64>> RectClip(Rect64 rect, List<Point64> path)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x4602754", Offset = "0x45FE754", VA = "0x4602754")]
		public static PathsD RectClip(RectD rect, PathsD paths, int precision = 2)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x46029B8", Offset = "0x45FE9B8", VA = "0x46029B8")]
		public static PathsD RectClip(RectD rect, PathD path, int precision = 2)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x4602B28", Offset = "0x45FEB28", VA = "0x4602B28")]
		public static List<List<Point64>> RectClipLines(Rect64 rect, List<List<Point64>> paths)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x4602C2C", Offset = "0x45FEC2C", VA = "0x4602C2C")]
		public static List<List<Point64>> RectClipLines(Rect64 rect, List<Point64> path)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x4602DA8", Offset = "0x45FEDA8", VA = "0x4602DA8")]
		public static PathsD RectClipLines(RectD rect, PathsD paths, int precision = 2)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x460300C", Offset = "0x45FF00C", VA = "0x460300C")]
		public static PathsD RectClipLines(RectD rect, PathD path, int precision = 2)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x460317C", Offset = "0x45FF17C", VA = "0x460317C")]
		public static List<List<Point64>> MinkowskiSum(List<Point64> pattern, List<Point64> path, bool isClosed)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x4603188", Offset = "0x45FF188", VA = "0x4603188")]
		public static PathsD MinkowskiSum(PathD pattern, PathD path, bool isClosed)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x4603198", Offset = "0x45FF198", VA = "0x4603198")]
		public static List<List<Point64>> MinkowskiDiff(List<Point64> pattern, List<Point64> path, bool isClosed)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x46031A4", Offset = "0x45FF1A4", VA = "0x46031A4")]
		public static PathsD MinkowskiDiff(PathD pattern, PathD path, bool isClosed)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x46031B4", Offset = "0x45FF1B4", VA = "0x46031B4")]
		public static double Area(List<Point64> path)
		{
			return default;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x4603370", Offset = "0x45FF370", VA = "0x4603370")]
		public static double Area(List<List<Point64>> paths)
		{
			return default;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x46034F4", Offset = "0x45FF4F4", VA = "0x46034F4")]
		public static double Area(PathD path)
		{
			return default;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x46036AC", Offset = "0x45FF6AC", VA = "0x46036AC")]
		public static double Area(PathsD paths)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x4603830", Offset = "0x45FF830", VA = "0x4603830")]
		public static bool IsPositive(List<Point64> poly)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x4603890", Offset = "0x45FF890", VA = "0x4603890")]
		public static bool IsPositive(PathD poly)
		{
			return default;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x46038F0", Offset = "0x45FF8F0", VA = "0x46038F0")]
		public static string Path64ToString(List<Point64> path)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x4603A90", Offset = "0x45FFA90", VA = "0x4603A90")]
		public static string Paths64ToString(List<List<Point64>> paths)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x4603C2C", Offset = "0x45FFC2C", VA = "0x4603C2C")]
		public static string PathDToString(PathD path)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x4603DD0", Offset = "0x45FFDD0", VA = "0x4603DD0")]
		public static string PathsDToString(PathsD paths)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x4603F6C", Offset = "0x45FFF6C", VA = "0x4603F6C")]
		public static List<Point64> OffsetPath(List<Point64> path, long dx, long dy)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x460418C", Offset = "0x460018C", VA = "0x460418C")]
		public static Point64 ScalePoint64(Point64 pt, double scale)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x46042B0", Offset = "0x46002B0", VA = "0x46042B0")]
		public static PointD ScalePointD(Point64 pt, double scale)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x46042C8", Offset = "0x46002C8", VA = "0x46042C8")]
		public static Rect64 ScaleRect(RectD rec, double scale)
		{
			return default;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x4604320", Offset = "0x4600320", VA = "0x4604320")]
		public static List<Point64> ScalePath(List<Point64> path, double scale)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x46045D4", Offset = "0x46005D4", VA = "0x46045D4")]
		public static List<List<Point64>> ScalePaths(List<List<Point64>> paths, double scale)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x46048B0", Offset = "0x46008B0", VA = "0x46048B0")]
		public static PathD ScalePath(PathD path, double scale)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x4604B34", Offset = "0x4600B34", VA = "0x4604B34")]
		public static PathsD ScalePaths(PathsD paths, double scale)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x4604DF8", Offset = "0x4600DF8", VA = "0x4604DF8")]
		public static List<Point64> ScalePath64(PathD path, double scale)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x460203C", Offset = "0x45FE03C", VA = "0x460203C")]
		public static List<List<Point64>> ScalePaths64(PathsD paths, double scale)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x460501C", Offset = "0x460101C", VA = "0x460501C")]
		public static PathD ScalePathD(List<Point64> path, double scale)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x4602294", Offset = "0x45FE294", VA = "0x4602294")]
		public static PathsD ScalePathsD(List<List<Point64>> paths, double scale)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x460522C", Offset = "0x460122C", VA = "0x460522C")]
		public static List<Point64> Path64(PathD path)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x4605440", Offset = "0x4601440", VA = "0x4605440")]
		public static List<List<Point64>> Paths64(PathsD paths)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x4605688", Offset = "0x4601688", VA = "0x4605688")]
		public static PathsD PathsD(List<List<Point64>> paths)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x46058B8", Offset = "0x46018B8", VA = "0x46058B8")]
		public static PathD PathD(List<Point64> path)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x4605AB0", Offset = "0x4601AB0", VA = "0x4605AB0")]
		public static List<Point64> TranslatePath(List<Point64> path, long dx, long dy)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x4605CD0", Offset = "0x4601CD0", VA = "0x4605CD0")]
		public static List<List<Point64>> TranslatePaths(List<List<Point64>> paths, long dx, long dy)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x4605F34", Offset = "0x4601F34", VA = "0x4605F34")]
		public static PathD TranslatePath(PathD path, double dx, double dy)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x460613C", Offset = "0x460213C", VA = "0x460613C")]
		public static PathsD TranslatePaths(PathsD paths, double dx, double dy)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x4606384", Offset = "0x4602384", VA = "0x4606384")]
		public static List<Point64> ReversePath(List<Point64> path)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x4606424", Offset = "0x4602424", VA = "0x4606424")]
		public static PathD ReversePath(PathD path)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x46064A4", Offset = "0x46024A4", VA = "0x46064A4")]
		public static List<List<Point64>> ReversePaths(List<List<Point64>> paths)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x46066EC", Offset = "0x46026EC", VA = "0x46066EC")]
		public static PathsD ReversePaths(PathsD paths)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x460691C", Offset = "0x460291C", VA = "0x460691C")]
		public static Rect64 GetBounds(List<Point64> path)
		{
			return default;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x4606B08", Offset = "0x4602B08", VA = "0x4606B08")]
		public static Rect64 GetBounds(List<List<Point64>> paths)
		{
			return default;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x4606E10", Offset = "0x4602E10", VA = "0x4606E10")]
		public static RectD GetBounds(PathD path)
		{
			return default;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x4607048", Offset = "0x4603048", VA = "0x4607048")]
		public static RectD GetBounds(PathsD paths)
		{
			return default;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x4607394", Offset = "0x4603394", VA = "0x4607394")]
		public static List<Point64> MakePath(int[] arr)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x46074D0", Offset = "0x46034D0", VA = "0x46074D0")]
		public static List<Point64> MakePath(long[] arr)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x460760C", Offset = "0x460360C", VA = "0x460760C")]
		public static PathD MakePath(double[] arr)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x4607730", Offset = "0x4603730", VA = "0x4607730")]
		public static double Sqr(double val)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x4607738", Offset = "0x4603738", VA = "0x4607738")]
		public static double Sqr(long val)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x4607744", Offset = "0x4603744", VA = "0x4607744")]
		public static double DistanceSqr(Point64 pt1, Point64 pt2)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x46077CC", Offset = "0x46037CC", VA = "0x46077CC")]
		public static Point64 MidPoint(Point64 pt1, Point64 pt2)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x46077F0", Offset = "0x46037F0", VA = "0x46077F0")]
		public static PointD MidPoint(PointD pt1, PointD pt2)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x4607808", Offset = "0x4603808", VA = "0x4607808")]
		public static void InflateRect(ref Rect64 rec, int dx, int dy)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x460782C", Offset = "0x460382C", VA = "0x460782C")]
		public static void InflateRect(ref RectD rec, double dx, double dy)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x4607844", Offset = "0x4603844", VA = "0x4607844")]
		public static bool PointsNearEqual(PointD pt1, PointD pt2, double distanceSqrd)
		{
			return default;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x46078D8", Offset = "0x46038D8", VA = "0x46078D8")]
		public static PathD StripNearDuplicates(PathD path, double minEdgeLenSqrd, bool isClosedPath)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x4607BDC", Offset = "0x4603BDC", VA = "0x4607BDC")]
		public static List<Point64> StripDuplicates(List<Point64> path, bool isClosedPath)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x4607E14", Offset = "0x4603E14", VA = "0x4607E14")]
		private static void AddPolyNodeToPaths(PolyPath64 polyPath, List<List<Point64>> paths)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x4607FCC", Offset = "0x4603FCC", VA = "0x4607FCC")]
		public static List<List<Point64>> PolyTreeToPaths64(PolyTree64 polyTree)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x4608138", Offset = "0x4604138", VA = "0x4608138")]
		public static void AddPolyNodeToPathsD(PolyPathD polyPath, PathsD paths)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x46082F0", Offset = "0x46042F0", VA = "0x46082F0")]
		public static PathsD PolyTreeToPathsD(PolyTreeD polyTree)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x4608614", Offset = "0x4604614", VA = "0x4608614")]
		public static double PerpendicDistFromLineSqrd(PointD pt, PointD line1, PointD line2)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x46086CC", Offset = "0x46046CC", VA = "0x46086CC")]
		public static double PerpendicDistFromLineSqrd(Point64 pt, Point64 line1, Point64 line2)
		{
			return default;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x46087AC", Offset = "0x46047AC", VA = "0x46087AC")]
		internal static void RDP(List<Point64> path, int begin, int end, double epsSqrd, List<bool> flags)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x4608AAC", Offset = "0x4604AAC", VA = "0x4608AAC")]
		public static List<Point64> RamerDouglasPeucker(List<Point64> path, double epsilon)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x4608D1C", Offset = "0x4604D1C", VA = "0x4608D1C")]
		public static List<List<Point64>> RamerDouglasPeucker(List<List<Point64>> paths, double epsilon)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x4608F74", Offset = "0x4604F74", VA = "0x4608F74")]
		internal static void RDP(PathD path, int begin, int end, double epsSqrd, List<bool> flags)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x4609220", Offset = "0x4605220", VA = "0x4609220")]
		public static PathD RamerDouglasPeucker(PathD path, double epsilon)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x460946C", Offset = "0x460546C", VA = "0x460946C")]
		public static PathsD RamerDouglasPeucker(PathsD paths, double epsilon)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x46096AC", Offset = "0x46056AC", VA = "0x46096AC")]
		private static int GetNext(int current, int high, ref bool[] flags)
		{
			return default;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x4609714", Offset = "0x4605714", VA = "0x4609714")]
		private static int GetPrior(int current, int high, ref bool[] flags)
		{
			return default;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x46097B8", Offset = "0x46057B8", VA = "0x46097B8")]
		public static List<Point64> SimplifyPath(List<Point64> path, double epsilon, bool isClosedPath = true)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x460A26C", Offset = "0x460626C", VA = "0x460A26C")]
		public static List<List<Point64>> SimplifyPaths(List<List<Point64>> paths, double epsilon, bool isClosedPaths = true)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x460A4D4", Offset = "0x46064D4", VA = "0x460A4D4")]
		public static PathD SimplifyPath(PathD path, double epsilon, bool isClosedPath = true)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x460AE28", Offset = "0x4606E28", VA = "0x460AE28")]
		public static PathsD SimplifyPaths(PathsD paths, double epsilon, bool isClosedPath = true)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x460B078", Offset = "0x4607078", VA = "0x460B078")]
		public static List<Point64> TrimCollinear(List<Point64> path, bool isOpen = false)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x460B7F4", Offset = "0x46077F4", VA = "0x460B7F4")]
		public static PathD TrimCollinear(PathD path, int precision, bool isOpen = false)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x460B93C", Offset = "0x460793C", VA = "0x460B93C")]
		public static PointInPolygonResult PointInPolygon(Point64 pt, List<Point64> polygon)
		{
			return default;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x460B9A8", Offset = "0x46079A8", VA = "0x460B9A8")]
		public static PointInPolygonResult PointInPolygon(PointD pt, PathD polygon, int precision = 2)
		{
			return default;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x460BB18", Offset = "0x4607B18", VA = "0x460BB18")]
		public static List<Point64> Ellipse(Point64 center, double radiusX, double radiusY = 0.0, int steps = 0)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x460BDCC", Offset = "0x4607DCC", VA = "0x460BDCC")]
		public static PathD Ellipse(PointD center, double radiusX, double radiusY = 0.0, int steps = 0)
		{
			return null;
		}
	}
}
