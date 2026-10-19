using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000065")]
	public class GraphUpdateShape
	{
		[Token(Token = "0x2000066")]
		public struct BurstShape
		{
			[Token(Token = "0x400023E")]
			[FieldOffset(Offset = "0x0")]
			[DeallocateOnJobCompletion]
			private NativeArray<Vector3> points;

			[Token(Token = "0x400023F")]
			[FieldOffset(Offset = "0x10")]
			private float3 origin;

			[Token(Token = "0x4000240")]
			[FieldOffset(Offset = "0x1C")]
			private float3 right;

			[Token(Token = "0x4000241")]
			[FieldOffset(Offset = "0x28")]
			private float3 forward;

			[Token(Token = "0x4000242")]
			[FieldOffset(Offset = "0x34")]
			private bool containsEverything;

			[Token(Token = "0x170000DD")]
			public static BurstShape Everything
			{
				[Token(Token = "0x60003F8")]
				[Address(RVA = "0x44F8E84", Offset = "0x44F4E84", VA = "0x44F8E84")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x44F8CF8", Offset = "0x44F4CF8", VA = "0x44F8CF8")]
			public BurstShape(GraphUpdateShape scene, Allocator allocator)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GraphUpdateShape.BurstShape..ctor RVA=0x44F8CF8 Token=0x60003F7");
}

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x44F8F8C", Offset = "0x44F4F8C", VA = "0x44F8F8C")]
			public bool Contains(float3 point)
			{
				return default;
			}
		}

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x10")]
		private Vector3[] _points;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x18")]
		private Vector3[] _convexPoints;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x20")]
		private bool _convex;

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 right;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 forward;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 up;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 origin;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x54")]
		public float minimumHeight;

		[Token(Token = "0x170000DB")]
		public Vector3[] points
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x44F8718", Offset = "0x44F4718", VA = "0x44F8718")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x44F8720", Offset = "0x44F4720", VA = "0x44F8720")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public bool convex
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x44F87A4", Offset = "0x44F47A4", VA = "0x44F87A4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x44F87AC", Offset = "0x44F47AC", VA = "0x44F87AC")]
			set
			{
			}
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x44F87E4", Offset = "0x44F47E4", VA = "0x44F87E4")]
		public GraphUpdateShape()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x44F7AC0", Offset = "0x44F3AC0", VA = "0x44F7AC0")]
		public GraphUpdateShape(Vector3[] points, bool convex, Matrix4x4 matrix, float minimumHeight)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x44F8734", Offset = "0x44F4734", VA = "0x44F8734")]
		private void CalculateConvexHull()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x44F7D30", Offset = "0x44F3D30", VA = "0x44F7D30")]
		public Bounds GetBounds()
		{
			return default;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x44F7130", Offset = "0x44F3130", VA = "0x44F7130")]
		public static Bounds GetBounds(Vector3[] points, Matrix4x4 matrix, float minimumHeight)
		{
			return default;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x44F88AC", Offset = "0x44F48AC", VA = "0x44F88AC")]
		private static Bounds GetBounds(Vector3[] points, Vector3 right, Vector3 up, Vector3 forward, Vector3 origin, float minimumHeight)
		{
			return default;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x44F8AD8", Offset = "0x44F4AD8", VA = "0x44F8AD8")]
		public bool Contains(GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x44F8B14", Offset = "0x44F4B14", VA = "0x44F8B14")]
		public bool Contains(Vector3 point)
		{
			return default;
		}
	}
}
