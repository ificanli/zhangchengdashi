using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x200000B")]
	public class PathD : List<PointD>
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x45FFF14", Offset = "0x45FBF14", VA = "0x45FFF14")]
		public PathD()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x45FFE98", Offset = "0x45FBE98", VA = "0x45FFE98")]
		public PathD(int capacity = 0)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x45FFF80", Offset = "0x45FBF80", VA = "0x45FFF80")]
		public PathD(IEnumerable<PointD> path)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x45FFFFC", Offset = "0x45FBFFC", VA = "0x45FFFFC")]
		public string ToString(int precision = 2)
		{
			return null;
		}
	}
}
