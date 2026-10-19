using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000023")]
	public class ClipperBase
	{
		[Token(Token = "0x2000024")]
		private struct IntersectListSort : IComparer<IntersectNode>
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x46194A8", Offset = "0x46154A8", VA = "0x46194A8", Slot = "4")]
			public readonly int Compare(IntersectNode a, IntersectNode b)
			{
				return default;
			}
		}

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x10")]
		private ClipType _cliptype;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x14")]
		private FillRule _fillrule;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x18")]
		private Active? _actives;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x20")]
		private Active? _sel;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<LocalMinima> _minimaList;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<IntersectNode> _intersectList;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<Vertex> _vertexList;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<OutRec> _outrecList;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<long> _scanlineList;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<HorzSegment> _horzSegList;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x58")]
		private readonly List<HorzJoin> _horzJoinList;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x60")]
		private readonly VertexPool _vertexPool;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x68")]
		private readonly GCArena<Active> _activeArena;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x70")]
		private int _currentLocMin;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x78")]
		private long _currentBotY;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x80")]
		private bool _isSortedMinimaList;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x81")]
		private bool _hasOpenPaths;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x82")]
		internal bool _using_polytree;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x83")]
		internal bool _succeeded;

		[Token(Token = "0x17000007")]
		public bool PreserveCollinear
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x460D1CC", Offset = "0x46091CC", VA = "0x460D1CC")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x460D1D4", Offset = "0x46091D4", VA = "0x460D1D4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool ReverseSolution
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x460D1E0", Offset = "0x46091E0", VA = "0x460D1E0")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x460D1E8", Offset = "0x46091E8", VA = "0x460D1E8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x460D1F4", Offset = "0x46091F4", VA = "0x460D1F4")]
		public ClipperBase()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x460D478", Offset = "0x4609478", VA = "0x460D478")]
		private static bool IsOdd(int val)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x460D480", Offset = "0x4609480", VA = "0x460D480")]
		private static bool IsHotEdge(Active ae)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x460D4A0", Offset = "0x46094A0", VA = "0x460D4A0")]
		private static bool IsOpen(Active ae)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x460D4B8", Offset = "0x46094B8", VA = "0x460D4B8")]
		private static bool IsOpenEnd(Active ae)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x460D4F0", Offset = "0x46094F0", VA = "0x460D4F0")]
		private static bool IsOpenEnd(Vertex v)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x460D510", Offset = "0x4609510", VA = "0x460D510")]
		private static Active GetPrevHotEdge(Active ae)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x460D53C", Offset = "0x460953C", VA = "0x460D53C")]
		private static bool IsFront(Active ae)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x460D564", Offset = "0x4609564", VA = "0x460D564")]
		private static double GetDx(Point64 pt1, Point64 pt2)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x460D59C", Offset = "0x460959C", VA = "0x460D59C")]
		private static long TopX(Active ae, long currentY)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x460D6A0", Offset = "0x46096A0", VA = "0x460D6A0")]
		private static bool IsHorizontal(Active ae)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x460D6C4", Offset = "0x46096C4", VA = "0x460D6C4")]
		private static bool IsHeadingRightHorz(Active ae)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x460D6EC", Offset = "0x46096EC", VA = "0x460D6EC")]
		private static bool IsHeadingLeftHorz(Active ae)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x460D714", Offset = "0x4609714", VA = "0x460D714")]
		private static void SwapActives(ref Active ae1, ref Active ae2)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x460D728", Offset = "0x4609728", VA = "0x460D728")]
		private static PathType GetPolyType(Active ae)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x460D740", Offset = "0x4609740", VA = "0x460D740")]
		private static bool IsSamePolyType(Active ae1, Active ae2)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x460D768", Offset = "0x4609768", VA = "0x460D768")]
		private static void SetDx(Active ae)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x460D7BC", Offset = "0x46097BC", VA = "0x460D7BC")]
		private static Vertex NextVertex(Active ae)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x460D7F0", Offset = "0x46097F0", VA = "0x460D7F0")]
		private static Vertex PrevPrevVertex(Active ae)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x460D838", Offset = "0x4609838", VA = "0x460D838")]
		private static bool IsMaxima(Vertex vertex)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x460D854", Offset = "0x4609854", VA = "0x460D854")]
		private static bool IsMaxima(Active ae)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x460D878", Offset = "0x4609878", VA = "0x460D878")]
		private static Active GetMaximaPair(Active ae)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x460D8AC", Offset = "0x46098AC", VA = "0x460D8AC")]
		private static Vertex GetCurrYMaximaVertex_Open(Active ae)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x460D938", Offset = "0x4609938", VA = "0x460D938")]
		private static Vertex GetCurrYMaximaVertex(Active ae)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x460D9AC", Offset = "0x46099AC", VA = "0x460D9AC")]
		private static void SetSides(OutRec outrec, Active startEdge, Active endEdge)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x460D9C4", Offset = "0x46099C4", VA = "0x460D9C4")]
		private static void SwapOutrecs(Active ae1, Active ae2)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x460DA40", Offset = "0x4609A40", VA = "0x460DA40")]
		private static void SetOwner(OutRec outrec, OutRec newOwner)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x460DAB0", Offset = "0x4609AB0", VA = "0x460DAB0")]
		private static double Area(OutPt op)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x460DB08", Offset = "0x4609B08", VA = "0x460DB08")]
		private static double AreaTriangle(Point64 pt1, Point64 pt2, Point64 pt3)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x460DB50", Offset = "0x4609B50", VA = "0x460DB50")]
		private static OutRec? GetRealOutRec(OutRec? outRec)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x460DB68", Offset = "0x4609B68", VA = "0x460DB68")]
		private static bool IsValidOwner(OutRec? outRec, OutRec? testOwner)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x460DB8C", Offset = "0x4609B8C", VA = "0x460DB8C")]
		private static void UncoupleOutRec(Active ae)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x460DBC8", Offset = "0x4609BC8", VA = "0x460DBC8")]
		private static bool OutrecIsAscending(Active hotEdge)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x460DBF0", Offset = "0x4609BF0", VA = "0x460DBF0")]
		private static void SwapFrontBackSides(OutRec outrec)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x460DC20", Offset = "0x4609C20", VA = "0x460DC20")]
		private static bool EdgesAdjacentInAEL(IntersectNode inode)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x460DC5C", Offset = "0x4609C5C", VA = "0x460DC5C")]
		protected void ClearSolutionOnly()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x460DDD8", Offset = "0x4609DD8", VA = "0x460DDD8")]
		public void Clear()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x460DFD8", Offset = "0x4609FD8", VA = "0x460DFD8")]
		protected void Reset()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x460E1B8", Offset = "0x460A1B8", VA = "0x460E1B8")]
		private void InsertScanline(long y)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x460E250", Offset = "0x460A250", VA = "0x460E250")]
		private bool PopScanline(out long y)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ClipperBase.PopScanline RVA=0x460E250 Token=0x60000FD");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x460E358", Offset = "0x460A358", VA = "0x460E358")]
		private bool HasLocMinAtY(long y)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x460E3E4", Offset = "0x460A3E4", VA = "0x460E3E4")]
		private LocalMinima PopLocalMinima()
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x460E440", Offset = "0x460A440", VA = "0x460E440")]
		public void AddSubject(List<Point64> path)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x460E450", Offset = "0x460A450", VA = "0x460E450")]
		public void AddOpenSubject(List<Point64> path)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x460E460", Offset = "0x460A460", VA = "0x460E460")]
		public void AddClip(List<Point64> path)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x460E470", Offset = "0x460A470", VA = "0x460E470")]
		protected void AddPath(List<Point64> path, PathType polytype, bool isOpen = false)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x460E594", Offset = "0x460A594", VA = "0x460E594")]
		protected void AddPaths(List<List<Point64>> paths, PathType polytype, bool isOpen = false)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x460E5C8", Offset = "0x460A5C8", VA = "0x460E5C8")]
		public unsafe void AddPath(Point64* path, int length, PathType polytype, bool isOpen = false)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x460E6B4", Offset = "0x460A6B4", VA = "0x460E6B4")]
		protected void AddReuseableData(ReuseableDataContainer64 reuseableData)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x460E8A4", Offset = "0x460A8A4", VA = "0x460E8A4")]
		private bool IsContributingClosed(Active ae)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x460EA7C", Offset = "0x460AA7C", VA = "0x460EA7C")]
		private bool IsContributingOpen(Active ae)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x460EB00", Offset = "0x460AB00", VA = "0x460EB00")]
		private void SetWindCountForClosedPathEdge(Active ae)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x460EC9C", Offset = "0x460AC9C", VA = "0x460EC9C")]
		private void SetWindCountForOpenPathEdge(Active ae)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x460ED6C", Offset = "0x460AD6C", VA = "0x460ED6C")]
		private static bool IsValidAelOrder(Active resident, Active newcomer)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x460F118", Offset = "0x460B118", VA = "0x460F118")]
		private void InsertLeftEdge(Active ae)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x460F1D4", Offset = "0x460B1D4", VA = "0x460F1D4")]
		private static void InsertRightEdge(Active ae, Active ae2)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x460F208", Offset = "0x460B208", VA = "0x460F208")]
		private void InsertLocalMinimaIntoAEL(long botY)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x460FF3C", Offset = "0x460BF3C", VA = "0x460FF3C")]
		private void PushHorz(Active ae)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x460FF5C", Offset = "0x460BF5C", VA = "0x460FF5C")]
		private bool PopHorz(out Active? ae)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ClipperBase.PopHorz RVA=0x460FF5C Token=0x6000110");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x460FF80", Offset = "0x460BF80", VA = "0x460FF80")]
		private OutPt AddLocalMinPoly(Active ae1, Active ae2, Point64 pt, bool isNew = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x4610108", Offset = "0x460C108", VA = "0x4610108")]
		private OutPt AddLocalMaxPoly(Active ae1, Active ae2, Point64 pt)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x461039C", Offset = "0x460C39C", VA = "0x461039C")]
		private static void JoinOutrecPaths(Active ae1, Active ae2)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x46104D4", Offset = "0x460C4D4", VA = "0x46104D4")]
		private static OutPt AddOutPt(Active ae, Point64 pt)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x46105E4", Offset = "0x460C5E4", VA = "0x46105E4")]
		private OutRec NewOutRec()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x46106C0", Offset = "0x460C6C0", VA = "0x46106C0")]
		private OutPt StartOpenPath(Active ae, Point64 pt)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x4610778", Offset = "0x460C778", VA = "0x4610778")]
		private void UpdateEdgeIntoAEL(Active ae)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x4610918", Offset = "0x460C918", VA = "0x4610918")]
		private static Active FindEdgeWithMatchingLocMin(Active e)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x460F818", Offset = "0x460B818", VA = "0x460F818")]
		private void IntersectEdges(Active ae1, Active ae2, Point64 pt)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x46109D8", Offset = "0x460C9D8", VA = "0x46109D8")]
		private void DeleteFromAEL(Active ae)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x4610A20", Offset = "0x460CA20", VA = "0x4610A20")]
		private void AdjustCurrXAndCopyToSEL(long topY)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x4610B6C", Offset = "0x460CB6C", VA = "0x4610B6C")]
		protected void ExecuteInternal(ClipType ct, FillRule fillRule)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x4611E70", Offset = "0x460DE70", VA = "0x4611E70")]
		private void DoIntersections(long topY)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x4612090", Offset = "0x460E090", VA = "0x4612090")]
		private void DisposeIntersectNodes()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x4612100", Offset = "0x460E100", VA = "0x4612100")]
		private void AddNewIntersectNode(Active ae1, Active ae2, long topY)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x4612430", Offset = "0x460E430", VA = "0x4612430")]
		private static Active ExtractFromSEL(Active ae)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x4612464", Offset = "0x460E464", VA = "0x4612464")]
		private static void Insert1Before2InSEL(Active ae1, Active ae2)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x4611EF4", Offset = "0x460DEF4", VA = "0x4611EF4")]
		private bool BuildIntersectList(long topY)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x4612494", Offset = "0x460E494", VA = "0x4612494")]
		private void ProcessIntersectList()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x4612740", Offset = "0x460E740", VA = "0x4612740")]
		private void SwapPositionsInAEL(Active ae1, Active ae2)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x4612784", Offset = "0x460E784", VA = "0x4612784")]
		private static bool ResetHorzDirection(Active horz, Vertex? vertexMax, out long leftX, out long rightX)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ClipperBase.ResetHorzDirection RVA=0x4612784 Token=0x6000125");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x4612808", Offset = "0x460E808", VA = "0x4612808")]
		private static void TrimHorz(Active horzEdge, bool preserveCollinear)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x461290C", Offset = "0x460E90C", VA = "0x461290C")]
		private void AddToHorzSegList(OutPt op)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x46129FC", Offset = "0x460E9FC", VA = "0x46129FC")]
		private OutPt GetLastOp(Active hotEdge)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x4610D38", Offset = "0x460CD38", VA = "0x4610D38")]
		private void DoHorizontal(Active horz)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x4612A30", Offset = "0x460EA30", VA = "0x4612A30")]
		private void DoTopOfScanbeam(long y)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x4612BDC", Offset = "0x460EBDC", VA = "0x4612BDC")]
		private Active DoMaxima(Active ae)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x4612E84", Offset = "0x460EE84", VA = "0x4612E84")]
		private static bool IsJoined(Active e)
		{
			return default;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x461033C", Offset = "0x460C33C", VA = "0x461033C")]
		private void Split(Active e, Point64 currPt)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x4612EA4", Offset = "0x460EEA4", VA = "0x4612EA4")]
		private void CheckJoinLeft(Active e, Point64 pt, bool checkCurrX = false)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x4613148", Offset = "0x460F148", VA = "0x4613148")]
		private void CheckJoinRight(Active e, Point64 pt, bool checkCurrX = false)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x46133EC", Offset = "0x460F3EC", VA = "0x46133EC")]
		private static void FixOutRecPts(OutRec outrec)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x461341C", Offset = "0x460F41C", VA = "0x461341C")]
		private static bool SetHorzSegHeadingForward(HorzSegment hs, OutPt opP, OutPt opN)
		{
			return default;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x4613468", Offset = "0x460F468", VA = "0x4613468")]
		private static bool UpdateHorzSegment(HorzSegment hs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x4613598", Offset = "0x460F598", VA = "0x4613598")]
		private static OutPt DuplicateOp(OutPt op, bool insert_after)
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x4613660", Offset = "0x460F660", VA = "0x4613660")]
		private int HorzSegSort(HorzSegment? hs1, HorzSegment? hs2)
		{
			return default;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x4611388", Offset = "0x460D388", VA = "0x4611388")]
		private void ConvertHorzSegsToJoins()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x46136C4", Offset = "0x460F6C4", VA = "0x46136C4")]
		private static List<Point64> GetCleanPath(OutPt op)
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x46138D4", Offset = "0x460F8D4", VA = "0x46138D4")]
		private static PointInPolygonResult PointInOpPolygon(Point64 pt, OutPt op)
		{
			return default;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x4613B9C", Offset = "0x460FB9C", VA = "0x4613B9C")]
		private static bool Path1InsidePath2(OutPt op1, OutPt op2)
		{
			return default;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x4613D0C", Offset = "0x460FD0C", VA = "0x4613D0C")]
		private void MoveSplits(OutRec fromOr, OutRec toOr)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x4611A14", Offset = "0x460DA14", VA = "0x4611A14")]
		private void ProcessHorzJoins()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x4613F2C", Offset = "0x460FF2C", VA = "0x4613F2C")]
		private static bool PtsReallyClose(Point64 pt1, Point64 pt2)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x4613FD0", Offset = "0x460FFD0", VA = "0x4613FD0")]
		private static bool IsVerySmallTriangle(OutPt op)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x4614174", Offset = "0x4610174", VA = "0x4614174")]
		private static bool IsValidClosedPath(OutPt? op)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x46141BC", Offset = "0x46101BC", VA = "0x46141BC")]
		private static OutPt DisposeOutPt(OutPt op)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x46141F4", Offset = "0x46101F4", VA = "0x46141F4")]
		private void CleanCollinear(OutRec? outrec)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x4614444", Offset = "0x4610444", VA = "0x4614444")]
		private void DoSplitOp(OutRec outrec, OutPt splitOp)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x4614934", Offset = "0x4610934", VA = "0x4614934")]
		private void FixSelfIntersects(OutRec outrec)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x4614A50", Offset = "0x4610A50", VA = "0x4614A50")]
		internal static bool BuildPath(OutPt? op, bool reverse, bool isOpen, List<Point64> path)
		{
			return default;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x4614C48", Offset = "0x4610C48", VA = "0x4614C48")]
		protected bool BuildPaths(List<List<Point64>> solutionClosed, List<List<Point64>> solutionOpen)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x4614F3C", Offset = "0x4610F3C", VA = "0x4614F3C")]
		private static Rect64 GetBounds(List<Point64> path)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x4615130", Offset = "0x4611130", VA = "0x4615130")]
		private bool CheckBounds(OutRec outrec)
		{
			return default;
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x46151E0", Offset = "0x46111E0", VA = "0x46151E0")]
		private bool CheckSplitOwner(OutRec outrec, List<int>? splits)
		{
			return default;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x46154D0", Offset = "0x46114D0", VA = "0x46154D0")]
		private void RecursiveCheckOwners(OutRec outrec, PolyPathBase polypath)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x461564C", Offset = "0x461164C", VA = "0x461564C")]
		protected void BuildTree(PolyPathBase polytree, List<List<Point64>> solutionOpen)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x461593C", Offset = "0x461193C", VA = "0x461593C")]
		public Rect64 GetBounds()
		{
			return default;
		}
	}
}
