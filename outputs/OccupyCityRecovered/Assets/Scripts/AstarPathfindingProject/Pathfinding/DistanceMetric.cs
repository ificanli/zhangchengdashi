using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000029")]
	public struct DistanceMetric
	{
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 projectionAxis;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0xC")]
		public float distanceScaleAlongProjectionDirection;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DistanceMetric Euclidean = new DistanceMetric { projectionAxis = Vector3.zero, distanceScaleAlongProjectionDirection = 0 };

		[Token(Token = "0x170000B6")]
		public bool isProjectedDistance
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x445D39C", Offset = "0x445939C", VA = "0x445D39C")]
			get
			{ float x=projectionAxis.x,y=projectionAxis.y,z=projectionAxis.z; return !((z*z+(x*x+y*y)) < 9.999999439624929e-11f); }
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x445D41C", Offset = "0x445941C", VA = "0x445D41C")]
		public static DistanceMetric ClosestAsSeenFromAboveSoft()
		{
			return default;
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x445D468", Offset = "0x4459468", VA = "0x445D468")]
		public static DistanceMetric ClosestAsSeenFromAboveSoft(Vector3 up)
		{
			return default;
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x445D474", Offset = "0x4459474", VA = "0x445D474")]
		public static DistanceMetric ClosestAsSeenFromAbove()
		{
			return default;
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x445D4BC", Offset = "0x44594BC", VA = "0x445D4BC")]
		public static DistanceMetric ClosestAsSeenFromAbove(Vector3 up)
		{
			return default;
		}
	}
}
