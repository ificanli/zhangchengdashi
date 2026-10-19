using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000029")]
	public class PolyPath64 : PolyPathBase
	{
		[Token(Token = "0x1700000D")]
		public List<Point64>? Polygon
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x461B3B8", Offset = "0x46173B8", VA = "0x461B3B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x461B3C0", Offset = "0x46173C0", VA = "0x461B3C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public PolyPath64 this[int index]
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x461B4D4", Offset = "0x46174D4", VA = "0x461B4D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x461B3C8", Offset = "0x46173C8", VA = "0x461B3C8")]
		public PolyPath64([Optional] PolyPathBase? parent)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x461B3CC", Offset = "0x46173CC", VA = "0x461B3CC", Slot = "5")]
		public override PolyPathBase AddChild(List<Point64> p)
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x461B5C8", Offset = "0x46175C8", VA = "0x461B5C8")]
		public PolyPath64 Child(int index)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x461B6BC", Offset = "0x46176BC", VA = "0x461B6BC")]
		public double Area()
		{
			return default;
		}
	}
}
