using Il2CppDummyDll;
using Pathfinding.Util;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002BB")]
	public struct XYMovementPlane : IMovementPlaneWrapper
	{
		[Token(Token = "0x1700027E")]
		public float4x4 matrix
		{
			[Token(Token = "0x600112F")]
			[Address(RVA = "0x449B5B8", Offset = "0x44975B8", VA = "0x449B5B8", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600112B")]
		[Address(RVA = "0x449B564", Offset = "0x4497564", VA = "0x449B564", Slot = "4")]
		public float2 ToPlane(float3 p)
		{
			return default;
		}

		[Token(Token = "0x600112C")]
		[Address(RVA = "0x449B568", Offset = "0x4497568", VA = "0x449B568", Slot = "5")]
		public float2 ToPlane(float3 p, out float elevation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED XYMovementPlane.ToPlane RVA=0x449B568 Token=0x600112C");
}

		[Token(Token = "0x600112D")]
		[Address(RVA = "0x449B570", Offset = "0x4497570", VA = "0x449B570", Slot = "6")]
		public float3 ToWorld(float2 p, float elevation = 0f)
		{
			return default;
		}

		[Token(Token = "0x600112E")]
		[Address(RVA = "0x449B574", Offset = "0x4497574", VA = "0x449B574", Slot = "7")]
		public Bounds ToWorld(Bounds bounds)
		{
			return default;
		}

		[Token(Token = "0x6001130")]
		[Address(RVA = "0x449B610", Offset = "0x4497610", VA = "0x449B610", Slot = "9")]
		public void Set(NativeMovementPlane plane)
		{
		}
	}
}
