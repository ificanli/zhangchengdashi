using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000025")]
	public class Clipper64 : ClipperBase
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x46194E8", Offset = "0x46154E8", VA = "0x46194E8")]
		internal new void AddPath(List<Point64> path, PathType polytype, bool isOpen = false)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x46194F4", Offset = "0x46154F4", VA = "0x46194F4")]
		public new void AddReuseableData(ReuseableDataContainer64 reuseableData)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x46194FC", Offset = "0x46154FC", VA = "0x46194FC")]
		internal new void AddPaths(List<List<Point64>> paths, PathType polytype, bool isOpen = false)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x4619534", Offset = "0x4615534", VA = "0x4619534")]
		public void AddSubject(List<List<Point64>> paths)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x4619558", Offset = "0x4615558", VA = "0x4619558")]
		public void AddOpenSubject(List<List<Point64>> paths)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x4619580", Offset = "0x4615580", VA = "0x4619580")]
		public void AddClip(List<List<Point64>> paths)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x46195A8", Offset = "0x46155A8", VA = "0x46195A8")]
		public bool Execute(ClipType clipType, FillRule fillRule, List<List<Point64>> solutionClosed, List<List<Point64>> solutionOpen)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x4619704", Offset = "0x4615704", VA = "0x4619704")]
		public bool Execute(ClipType clipType, FillRule fillRule, List<List<Point64>> solutionClosed)
		{
			return default;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x461979C", Offset = "0x461579C", VA = "0x461979C")]
		public bool Execute(ClipType clipType, FillRule fillRule, PolyTree64 polytree, List<List<Point64>> openPaths)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x4619928", Offset = "0x4615928", VA = "0x4619928")]
		public bool Execute(ClipType clipType, FillRule fillRule, PolyTree64 polytree)
		{
			return default;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x46199C0", Offset = "0x46159C0", VA = "0x46199C0")]
		public Clipper64()
		{
		}
	}
}
