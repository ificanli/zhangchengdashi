using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x200000C")]
	public class PathsD : List<PathD>
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x46001D4", Offset = "0x45FC1D4", VA = "0x46001D4")]
		public PathsD()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4600240", Offset = "0x45FC240", VA = "0x4600240")]
		public PathsD(int capacity = 0)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x46002BC", Offset = "0x45FC2BC", VA = "0x46002BC")]
		public PathsD(IEnumerable<PathD> paths)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x4600338", Offset = "0x45FC338", VA = "0x4600338")]
		public string ToString(int precision = 2)
		{
			return null;
		}
	}
}
