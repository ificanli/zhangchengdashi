using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000035")]
	public class RectClip64
	{
		[Token(Token = "0x2000036")]
		protected enum Location
		{
			[Token(Token = "0x40000C3")]
			left = 0,
			[Token(Token = "0x40000C4")]
			top = 1,
			[Token(Token = "0x40000C5")]
			right = 2,
			[Token(Token = "0x40000C6")]
			bottom = 3,
			[Token(Token = "0x40000C7")]
			inside = 4
		}

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x10")]
		protected readonly Rect64 rect_;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x30")]
		protected readonly Point64 mp_;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x40")]
		protected readonly List<Point64> rectPath_;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x48")]
		protected Rect64 pathBounds_;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x68")]
		protected List<OutPt2?> results_;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x70")]
		protected List<OutPt2?>[] edges_;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x78")]
		protected int currIdx_;

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x4620F08", Offset = "0x461CF08", VA = "0x4620F08")]
		internal RectClip64(Rect64 rect)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x4621074", Offset = "0x461D074", VA = "0x4621074")]
		internal OutPt2 Add(Point64 pt, bool startingNewPath = false)
		{
			return null;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x4621244", Offset = "0x461D244", VA = "0x4621244")]
		private static bool Path1ContainsPath2(List<Point64> path1, List<Point64> path2)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x4621428", Offset = "0x461D428", VA = "0x4621428")]
		private static bool IsClockwise(Location prev, Location curr, Point64 prevPt, Point64 currPt, Point64 rectMidPoint)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x4621540", Offset = "0x461D540", VA = "0x4621540")]
		private static bool AreOpposites(Location prev, Location curr)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x46215AC", Offset = "0x461D5AC", VA = "0x46215AC")]
		private static bool HeadingClockwise(Location prev, Location curr)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x46215D0", Offset = "0x461D5D0", VA = "0x46215D0")]
		private static Location GetAdjacentLocation(Location loc, bool isClockwise)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x46215F8", Offset = "0x461D5F8", VA = "0x46215F8")]
		private static OutPt2 UnlinkOp(OutPt2 op)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x4621638", Offset = "0x461D638", VA = "0x4621638")]
		private static OutPt2 UnlinkOpBack(OutPt2 op)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x462167C", Offset = "0x461D67C", VA = "0x462167C")]
		private static uint GetEdgesForPt(Point64 pt, Rect64 rec)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x46216C8", Offset = "0x461D6C8", VA = "0x46216C8")]
		private static bool IsHeadingClockwise(Point64 pt1, Point64 pt2, int edgeIdx)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x4621704", Offset = "0x461D704", VA = "0x4621704")]
		private static bool HasHorzOverlap(Point64 left1, Point64 right1, Point64 left2, Point64 right2)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x462171C", Offset = "0x461D71C", VA = "0x462171C")]
		private static bool HasVertOverlap(Point64 top1, Point64 bottom1, Point64 top2, Point64 bottom2)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x4621734", Offset = "0x461D734", VA = "0x4621734")]
		private static void AddToEdge(List<OutPt2?> edge, OutPt2 op)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x46217E8", Offset = "0x461D7E8", VA = "0x46217E8")]
		private static void UncoupleEdge(OutPt2 op)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x46218A4", Offset = "0x461D8A4", VA = "0x46218A4")]
		private static void SetNewOwner(OutPt2 op, int newIdx)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x46218DC", Offset = "0x461D8DC", VA = "0x46218DC")]
		private void AddCorner(Location prev, Location curr)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x4621978", Offset = "0x461D978", VA = "0x4621978")]
		private void AddCorner(ref Location loc, bool isClockwise)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x4621A80", Offset = "0x461DA80", VA = "0x4621A80")]
		protected static bool GetLocation(Rect64 rec, Point64 pt, out Location loc)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RectClip64.GetLocation RVA=0x4621A80 Token=0x60001D0");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x4621B84", Offset = "0x461DB84", VA = "0x4621B84")]
		private static bool IsHorizontal(Point64 pt1, Point64 pt2)
		{
			return default;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x4621B90", Offset = "0x461DB90", VA = "0x4621B90")]
		private static bool GetSegmentIntersection(Point64 p1, Point64 p2, Point64 p3, Point64 p4, out Point64 ip)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RectClip64.GetSegmentIntersection RVA=0x4621B90 Token=0x60001D2");
}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x4621FC4", Offset = "0x461DFC4", VA = "0x4621FC4")]
		protected static bool GetIntersection(List<Point64> rectPath, Point64 p, Point64 p2, ref Location loc, out Point64 ip)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RectClip64.GetIntersection RVA=0x4621FC4 Token=0x60001D3");
}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x462253C", Offset = "0x461E53C", VA = "0x462253C")]
		protected void GetNextLocation(List<Point64> path, ref Location loc, ref int i, int highI)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x46228F4", Offset = "0x461E8F4", VA = "0x46228F4")]
		private bool StartLocsAreClockwise(List<Location> startLocs)
		{
			return default;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x46229E8", Offset = "0x461E9E8", VA = "0x46229E8")]
		private void ExecuteInternal(List<Point64> path)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x4623700", Offset = "0x461F700", VA = "0x4623700")]
		public List<List<Point64>> Execute(List<List<Point64>> paths)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x4623CD8", Offset = "0x461FCD8", VA = "0x4623CD8")]
		private void CheckEdges()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x46240B8", Offset = "0x46200B8", VA = "0x46240B8")]
		private void TidyEdgePair(int idx, List<OutPt2?> cw, List<OutPt2?> ccw)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x46248B4", Offset = "0x46208B4", VA = "0x46248B4")]
		private List<Point64> GetPath(OutPt2? op)
		{
			return null;
		}
	}
}
