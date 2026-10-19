using Il2CppDummyDll;
using Pathfinding.Util;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002BC")]
	public struct XZMovementPlane : IMovementPlaneWrapper
	{
		[Token(Token = "0x1700027F")]
		public float4x4 matrix
		{
			[Token(Token = "0x6001136")]
			[Address(RVA = "0x449B650", Offset = "0x4497650", VA = "0x449B650", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001131")]
		[Address(RVA = "0x449B614", Offset = "0x4497614", VA = "0x449B614", Slot = "4")]
		public float2 ToPlane(float3 p)
		{
			return default;
		}

		[Token(Token = "0x6001132")]
		[Address(RVA = "0x449B61C", Offset = "0x449761C", VA = "0x449B61C", Slot = "5")]
		public float2 ToPlane(float3 p, out float elevation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED XZMovementPlane.ToPlane RVA=0x449B61C Token=0x6001132");
}

		[Token(Token = "0x6001133")]
		[Address(RVA = "0x449B628", Offset = "0x4497628", VA = "0x449B628", Slot = "6")]
		public float3 ToWorld(float2 p, float elevation = 0f)
		{
			return default;
		}

		[Token(Token = "0x6001134")]
		[Address(RVA = "0x449B638", Offset = "0x4497638", VA = "0x449B638", Slot = "7")]
		public Bounds ToWorld(Bounds bounds)
		{
			return default;
		}

		[Token(Token = "0x6001135")]
		[Address(RVA = "0x449B64C", Offset = "0x449764C", VA = "0x449B64C", Slot = "9")]
		public void Set(NativeMovementPlane plane)
		{
		}
	}
}
