using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000031")]
	public class ClipperOffset
	{
		[Token(Token = "0x2000032")]
		private class Group
		{
			[Token(Token = "0x40000B1")]
			[FieldOffset(Offset = "0x10")]
			internal List<List<Point64>> inPaths;

			[Token(Token = "0x40000B2")]
			[FieldOffset(Offset = "0x18")]
			internal JoinType joinType;

			[Token(Token = "0x40000B3")]
			[FieldOffset(Offset = "0x1C")]
			internal EndType endType;

			[Token(Token = "0x40000B4")]
			[FieldOffset(Offset = "0x20")]
			internal bool pathsReversed;

			[Token(Token = "0x40000B5")]
			[FieldOffset(Offset = "0x24")]
			internal int lowestPathIdx;

			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x461CF54", Offset = "0x4618F54", VA = "0x461CF54")]
			public Group(List<List<Point64>> paths, JoinType joinType, EndType endType = EndType.Polygon)
			{
			}
		}

		[Token(Token = "0x2000033")]
		public delegate double DeltaCallback64(List<Point64> path, PathD path_norms, int currPt, int prevPt);

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly double Tolerance;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<Group> _groupList;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x18")]
		private List<Point64> pathOut;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x20")]
		private readonly PathD _normals;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x28")]
		private List<List<Point64>> _solution;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x30")]
		private PolyTree64? _solutionTree;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x38")]
		private double _groupDelta;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x40")]
		private double _delta;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x48")]
		private double _mitLimSqr;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x50")]
		private double _stepsPerRad;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x58")]
		private double _stepSin;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x60")]
		private double _stepCos;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x68")]
		private JoinType _joinType;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x6C")]
		private EndType _endType;

		[Token(Token = "0x17000013")]
		public double ArcTolerance
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x461CAD0", Offset = "0x4618AD0", VA = "0x461CAD0")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x461CAD8", Offset = "0x4618AD8", VA = "0x461CAD8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public bool MergeGroups
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x461CAE0", Offset = "0x4618AE0", VA = "0x461CAE0")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x461CAE8", Offset = "0x4618AE8", VA = "0x461CAE8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public double MiterLimit
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x461CAF4", Offset = "0x4618AF4", VA = "0x461CAF4")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x461CAFC", Offset = "0x4618AFC", VA = "0x461CAFC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public bool PreserveCollinear
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x461CB04", Offset = "0x4618B04", VA = "0x461CB04")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x461CB0C", Offset = "0x4618B0C", VA = "0x461CB0C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public bool ReverseSolution
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x461CB18", Offset = "0x4618B18", VA = "0x461CB18")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x461CB20", Offset = "0x4618B20", VA = "0x461CB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public DeltaCallback64? DeltaCallback
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x461CB2C", Offset = "0x4618B2C", VA = "0x461CB2C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x461CB34", Offset = "0x4618B34", VA = "0x461CB34")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x461CB3C", Offset = "0x4618B3C", VA = "0x461CB3C")]
		public ClipperOffset(double miterLimit = 2.0, double arcTolerance = 0.0, bool preserveCollinear = false, bool reverseSolution = false)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x461CCB8", Offset = "0x4618CB8", VA = "0x461CCB8")]
		public void Clear()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x461CD28", Offset = "0x4618D28", VA = "0x461CD28")]
		public void AddPath(List<Point64> path, JoinType joinType, EndType endType)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x461CE50", Offset = "0x4618E50", VA = "0x461CE50")]
		public void AddPaths(List<List<Point64>> paths, JoinType joinType, EndType endType)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x461D280", Offset = "0x4619280", VA = "0x461D280")]
		private int CalcSolutionCapacity()
		{
			return default;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x461D420", Offset = "0x4619420", VA = "0x461D420")]
		internal bool CheckPathsReversed()
		{
			return default;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x461D56C", Offset = "0x461956C", VA = "0x461D56C")]
		private void ExecuteInternal(double delta)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x461E214", Offset = "0x461A214", VA = "0x461E214")]
		public void Execute(double delta, List<List<Point64>> solution)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x461E294", Offset = "0x461A294", VA = "0x461E294")]
		public void Execute(double delta, PolyTree64 solutionTree)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x461E368", Offset = "0x461A368", VA = "0x461E368")]
		internal static PointD GetUnitNormal(Point64 pt1, Point64 pt2)
		{
			return default;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x461E434", Offset = "0x461A434", VA = "0x461E434")]
		public void Execute(DeltaCallback64 deltaCallback, List<List<Point64>> solution)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x461E444", Offset = "0x461A444", VA = "0x461E444")]
		internal static int GetLowestPathIdx(List<List<Point64>> paths)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x461E624", Offset = "0x461A624", VA = "0x461E624")]
		private static PointD TranslatePoint(PointD pt, double dx, double dy)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x461E654", Offset = "0x461A654", VA = "0x461E654")]
		private static PointD ReflectPoint(PointD pt, PointD pivot)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x461E68C", Offset = "0x461A68C", VA = "0x461E68C")]
		private static bool AlmostZero(double value, double epsilon = 0.001)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x461E6F4", Offset = "0x461A6F4", VA = "0x461E6F4")]
		private static double Hypotenuse(double x, double y)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x461E77C", Offset = "0x461A77C", VA = "0x461E77C")]
		private static PointD NormalizeVector(PointD vec)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x461E8D0", Offset = "0x461A8D0", VA = "0x461E8D0")]
		private static PointD GetAvgUnitVector(PointD vec1, PointD vec2)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x461E968", Offset = "0x461A968", VA = "0x461E968")]
		private static PointD IntersectPoint(PointD pt1a, PointD pt1b, PointD pt2a, PointD pt2b)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x461EBA0", Offset = "0x461ABA0", VA = "0x461EBA0")]
		private Point64 GetPerpendic(Point64 pt, PointD norm)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x461EBE4", Offset = "0x461ABE4", VA = "0x461EBE4")]
		private PointD GetPerpendicD(Point64 pt, PointD norm)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x461EC28", Offset = "0x461AC28", VA = "0x461EC28")]
		private void DoBevel(List<Point64> path, int j, int k)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x461EFA4", Offset = "0x461AFA4", VA = "0x461EFA4")]
		private void DoSquare(List<Point64> path, int j, int k)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x461F5D8", Offset = "0x461B5D8", VA = "0x461F5D8")]
		private void DoMiter(List<Point64> path, int j, int k, double cosA)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x461F7B4", Offset = "0x461B7B4", VA = "0x461F7B4")]
		private void DoRound(List<Point64> path, int j, int k, double angle)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x461FBAC", Offset = "0x461BBAC", VA = "0x461FBAC")]
		private void BuildNormals(List<Point64> path)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x461FF64", Offset = "0x461BF64", VA = "0x461FF64")]
		private void OffsetPoint(Group group, List<Point64> path, int j, ref int k)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x462056C", Offset = "0x461C56C", VA = "0x462056C")]
		private void OffsetPolygon(Group group, List<Point64> path)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x46206A8", Offset = "0x461C6A8", VA = "0x46206A8")]
		private void OffsetOpenJoined(Group group, List<Point64> path)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x462074C", Offset = "0x461C74C", VA = "0x462074C")]
		private void OffsetOpenPath(Group group, List<Point64> path)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x461DBBC", Offset = "0x4619BBC", VA = "0x461DBBC")]
		private void DoGroupOffset(Group group)
		{
		}
	}
}
