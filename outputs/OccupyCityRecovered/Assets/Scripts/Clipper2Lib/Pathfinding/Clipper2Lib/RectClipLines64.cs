using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000037")]
	public class RectClipLines64 : RectClip64
	{
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x4624B44", Offset = "0x4620B44", VA = "0x4624B44")]
		internal RectClipLines64(Rect64 rect) : base(rect)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x4624B68", Offset = "0x4620B68", VA = "0x4624B68")]
		public new List<List<Point64>> Execute(List<List<Point64>> paths)
		{
			return null;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x4625458", Offset = "0x4621458", VA = "0x4625458")]
		private List<Point64> GetPath(OutPt2? op)
		{
			return null;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x4625044", Offset = "0x4621044", VA = "0x4625044")]
		private void ExecuteInternal(List<Point64> path)
		{
		}
	}
}
