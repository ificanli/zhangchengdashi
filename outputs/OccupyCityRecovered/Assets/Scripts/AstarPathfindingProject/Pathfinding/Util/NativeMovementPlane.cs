using Il2CppDummyDll;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Util
{
	[Token(Token = "0x2000298")]
	public readonly struct NativeMovementPlane
	{
		[Token(Token = "0x4000BCD")]
		[FieldOffset(Offset = "0x0")]
		public readonly quaternion rotation;

		[Token(Token = "0x1700026D")]
		public float3 up
		{
			[Token(Token = "0x6001065")]
			[Address(RVA = "0x44941C8", Offset = "0x44901C8", VA = "0x44941C8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001066")]
		[Address(RVA = "0x449420C", Offset = "0x449020C", VA = "0x449420C")]
		public NativeMovementPlane(quaternion rotation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NativeMovementPlane..ctor RVA=0x449420C Token=0x6001066");
}

		[Token(Token = "0x6001067")]
		[Address(RVA = "0x449422C", Offset = "0x449022C", VA = "0x449422C")]
		public NativeMovementPlane(SimpleMovementPlane plane)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NativeMovementPlane..ctor RVA=0x449422C Token=0x6001067");
}

		[Token(Token = "0x6001068")]
		[Address(RVA = "0x449425C", Offset = "0x449025C", VA = "0x449425C")]
		public ToPlaneMatrix AsWorldToPlaneMatrix()
		{
			return default;
		}

		[Token(Token = "0x6001069")]
		[Address(RVA = "0x44942B8", Offset = "0x44902B8", VA = "0x44942B8")]
		public ToWorldMatrix AsPlaneToWorldMatrix()
		{
			return default;
		}

		[Token(Token = "0x600106A")]
		[Address(RVA = "0x4494308", Offset = "0x4490308", VA = "0x4494308")]
		public NativeMovementPlane MatchUpDirection(float3 up)
		{
			return default;
		}

		[Token(Token = "0x600106B")]
		[Address(RVA = "0x449452C", Offset = "0x449052C", VA = "0x449452C")]
		public float ProjectedLength(float3 v)
		{
			return default;
		}

		[Token(Token = "0x600106C")]
		[Address(RVA = "0x4494594", Offset = "0x4490594", VA = "0x4494594")]
		public float2 ToPlane(float3 p)
		{
			return default;
		}

		[Token(Token = "0x600106D")]
		[Address(RVA = "0x4494600", Offset = "0x4490600", VA = "0x4494600")]
		public float2 ToPlane(float3 p, out float elevation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NativeMovementPlane.ToPlane RVA=0x4494600 Token=0x600106D");
}

		[Token(Token = "0x600106E")]
		[Address(RVA = "0x4494688", Offset = "0x4490688", VA = "0x4494688")]
		public float3 ToWorld(float2 p, float elevation = 0f)
		{
			return default;
		}

		[Token(Token = "0x600106F")]
		[Address(RVA = "0x449470C", Offset = "0x449070C", VA = "0x449470C")]
		public float ToPlane(quaternion rotation)
		{
			return default;
		}

		[Token(Token = "0x6001070")]
		[Address(RVA = "0x4494794", Offset = "0x4490794", VA = "0x4494794")]
		public quaternion ToWorldRotation(float angle)
		{
			return default;
		}

		[Token(Token = "0x6001071")]
		[Address(RVA = "0x44948CC", Offset = "0x44908CC", VA = "0x44948CC")]
		public quaternion ToWorldRotationDelta(float deltaAngle)
		{
			return default;
		}

		[Token(Token = "0x6001072")]
		[Address(RVA = "0x44949E8", Offset = "0x44909E8", VA = "0x44949E8")]
		public Bounds ToWorld(Bounds bounds)
		{
			return default;
		}
	}
}
