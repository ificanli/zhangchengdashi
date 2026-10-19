using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Util
{
	[Token(Token = "0x200029A")]
	[GenerateTestsForBurstCompatibility]
	public readonly struct SimpleMovementPlane : IMovementPlane
	{
		[Token(Token = "0x4000BCE")]
		[FieldOffset(Offset = "0x0")]
		public readonly Quaternion rotation;

		[Token(Token = "0x4000BCF")]
		[FieldOffset(Offset = "0x10")]
		public readonly Quaternion inverseRotation;

		[Token(Token = "0x4000BD0")]
		[FieldOffset(Offset = "0x20")]
		private readonly byte plane;

		[Token(Token = "0x4000BD1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SimpleMovementPlane XYPlane;

		[Token(Token = "0x4000BD2")]
		[FieldOffset(Offset = "0x24")]
		public static readonly SimpleMovementPlane XZPlane;

		[Token(Token = "0x1700026E")]
		public bool isXY
		{
			[Token(Token = "0x6001074")]
			[Address(RVA = "0x4494BC0", Offset = "0x4490BC0", VA = "0x4494BC0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700026F")]
		public bool isXZ
		{
			[Token(Token = "0x6001075")]
			[Address(RVA = "0x4494BD0", Offset = "0x4490BD0", VA = "0x4494BD0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001076")]
		[Address(RVA = "0x4494BE0", Offset = "0x4490BE0", VA = "0x4494BE0")]
		public SimpleMovementPlane(Quaternion rotation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SimpleMovementPlane..ctor RVA=0x4494BE0 Token=0x6001076");
}

		[Token(Token = "0x6001077")]
		[Address(RVA = "0x4494D30", Offset = "0x4490D30", VA = "0x4494D30", Slot = "4")]
		public Vector2 ToPlane(Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x6001078")]
		[Address(RVA = "0x4494DF8", Offset = "0x4490DF8", VA = "0x4494DF8")]
		public float2 ToPlane(float3 point)
		{
			return default;
		}

		[Token(Token = "0x6001079")]
		[Address(RVA = "0x4494E54", Offset = "0x4490E54", VA = "0x4494E54", Slot = "5")]
		public Vector2 ToPlane(Vector3 point, out float elevation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SimpleMovementPlane.ToPlane RVA=0x4494E54 Token=0x6001079");
}

		[Token(Token = "0x600107A")]
		[Address(RVA = "0x4494F0C", Offset = "0x4490F0C", VA = "0x4494F0C")]
		public float2 ToPlane(float3 point, out float elevation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SimpleMovementPlane.ToPlane RVA=0x4494F0C Token=0x600107A");
}

		[Token(Token = "0x600107B")]
		[Address(RVA = "0x4494FC8", Offset = "0x4490FC8", VA = "0x4494FC8", Slot = "6")]
		public Vector3 ToWorld(Vector2 point, float elevation = 0f)
		{
			return default;
		}

		[Token(Token = "0x600107C")]
		[Address(RVA = "0x4494FEC", Offset = "0x4490FEC", VA = "0x4494FEC")]
		public float3 ToWorld(float2 point, float elevation = 0f)
		{
			return default;
		}

		[Token(Token = "0x600107D")]
		[Address(RVA = "0x4495020", Offset = "0x4491020", VA = "0x4495020", Slot = "7")]
		public SimpleMovementPlane ToSimpleMovementPlane()
		{
			return default;
		}

		[Token(Token = "0x600107E")]
		[Address(RVA = "0x4495034", Offset = "0x4491034", VA = "0x4495034")]
		public static bool operator ==(SimpleMovementPlane lhs, SimpleMovementPlane rhs)
		{
			return default;
		}

		[Token(Token = "0x600107F")]
		[Address(RVA = "0x449506C", Offset = "0x449106C", VA = "0x449506C")]
		public static bool operator !=(SimpleMovementPlane lhs, SimpleMovementPlane rhs)
		{
			return default;
		}

		[Token(Token = "0x6001080")]
		[Address(RVA = "0x44950A4", Offset = "0x44910A4", VA = "0x44950A4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default;
		}

		[Token(Token = "0x6001081")]
		[Address(RVA = "0x4495148", Offset = "0x4491148", VA = "0x4495148", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}
	}
}
