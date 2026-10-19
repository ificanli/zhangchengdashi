using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x200002E")]
	public class Minkowski
	{
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x461BE24", Offset = "0x4617E24", VA = "0x461BE24")]
		private static List<List<Point64>> MinkowskiInternal(List<Point64> pattern, List<Point64> path, bool isSum, bool isClosed)
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x461C7C0", Offset = "0x46187C0", VA = "0x461C7C0")]
		public static List<List<Point64>> Sum(List<Point64> pattern, List<Point64> path, bool isClosed)
		{
			return null;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x461C848", Offset = "0x4618848", VA = "0x461C848")]
		public static PathsD Sum(PathD pattern, PathD path, bool isClosed, int decimalPlaces = 2)
		{
			return null;
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x461C944", Offset = "0x4618944", VA = "0x461C944")]
		public static List<List<Point64>> Diff(List<Point64> pattern, List<Point64> path, bool isClosed)
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x461C9CC", Offset = "0x46189CC", VA = "0x461C9CC")]
		public static PathsD Diff(PathD pattern, PathD path, bool isClosed, int decimalPlaces = 2)
		{
			return null;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x461CAC8", Offset = "0x4618AC8", VA = "0x461CAC8")]
		public Minkowski()
		{
		}
	}
}
