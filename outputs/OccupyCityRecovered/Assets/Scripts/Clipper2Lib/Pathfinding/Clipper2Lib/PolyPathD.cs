using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x200002A")]
	public class PolyPathD : PolyPathBase
	{
		[Token(Token = "0x1700000F")]
		internal double Scale
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x461B890", Offset = "0x4617890", VA = "0x461B890")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x461B898", Offset = "0x4617898", VA = "0x461B898")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public PathD? Polygon
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x461B8A0", Offset = "0x46178A0", VA = "0x461B8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x461B8A8", Offset = "0x46178A8", VA = "0x461B8A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[IndexerName("Child")]
		[Token(Token = "0x17000011")]
		public PolyPathD this[int index]
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x461BB44", Offset = "0x4617B44", VA = "0x461BB44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x461B8B0", Offset = "0x46178B0", VA = "0x461B8B0")]
		public PolyPathD([Optional] PolyPathBase? parent)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x461B8B4", Offset = "0x46178B4", VA = "0x461B8B4", Slot = "5")]
		public override PolyPathBase AddChild(List<Point64> p)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x461BA34", Offset = "0x4617A34", VA = "0x461BA34")]
		public PolyPathBase AddChild(PathD p)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x461BC38", Offset = "0x4617C38", VA = "0x461BC38")]
		public double Area()
		{
			return default;
		}
	}
}
