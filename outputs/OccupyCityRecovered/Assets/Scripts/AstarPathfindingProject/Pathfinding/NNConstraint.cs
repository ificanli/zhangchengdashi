using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x2000069")]
	[Obsolete("Use NearestNodeConstraint struct instead. Check the upgrade guide for version 5.4 for more info.")]
	public class NNConstraint
	{
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x10")]
		public GraphMask graphMask;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x14")]
		public bool constrainArea;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x18")]
		public int area;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x1C")]
		public DistanceMetric distanceMetric;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x2C")]
		public bool constrainWalkability;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x2D")]
		public bool walkable;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x2E")]
		public bool constrainTags;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x30")]
		public int tags;

		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x34")]
		public bool constrainDistance;

		[Token(Token = "0x170000E2")]
		[Obsolete("Use distanceMetric = DistanceMetric.ClosestAsSeenFromAbove() instead")]
		public bool distanceXZ
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x44F9298", Offset = "0x44F5298", VA = "0x44F9298")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x44F9310", Offset = "0x44F5310", VA = "0x44F9310")]
			set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		[Obsolete("Use NNConstraint.Walkable instead. It is equivalent, but the name is more descriptive")]
		public static NNConstraint Default
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x44F9470", Offset = "0x44F5470", VA = "0x44F9470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		public static NNConstraint Walkable
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x44F9538", Offset = "0x44F5538", VA = "0x44F9538")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		public static NNConstraint None
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x44F95BC", Offset = "0x44F55BC", VA = "0x44F95BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x44F9398", Offset = "0x44F5398", VA = "0x44F9398", Slot = "4")]
		public virtual bool SuitableGraph(int graphIndex, NavGraph graph)
		{
			return default;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x44F93A4", Offset = "0x44F53A4", VA = "0x44F93A4", Slot = "5")]
		public virtual bool Suitable(GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x44F944C", Offset = "0x44F544C", VA = "0x44F944C")]
		public void UseSettings(PathRequestSettings settings)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x44F94F4", Offset = "0x44F54F4", VA = "0x44F94F4")]
		public NNConstraint()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x44F965C", Offset = "0x44F565C", VA = "0x44F965C")]
		public TraversalConstraint ToTraversalConstraint()
		{
			return default;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x44F9674", Offset = "0x44F5674", VA = "0x44F9674")]
		public NearestNodeConstraint ToNearestNodeConstraint()
		{
			return default;
		}
	}
}
