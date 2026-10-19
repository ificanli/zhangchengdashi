using Il2CppDummyDll;
using Pathfinding.Util;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002BD")]
	public struct ArbitraryMovementPlane : IMovementPlaneWrapper
	{
		[Token(Token = "0x4000C6B")]
		[FieldOffset(Offset = "0x0")]
		private NativeMovementPlane plane;

		[Token(Token = "0x17000280")]
		public float4x4 matrix
		{
			[Token(Token = "0x600113C")]
			[Address(RVA = "0x449B760", Offset = "0x4497760", VA = "0x449B760", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001137")]
		[Address(RVA = "0x449B704", Offset = "0x4497704", VA = "0x449B704", Slot = "4")]
		public float2 ToPlane(float3 p)
		{
			return default;
		}

		[Token(Token = "0x6001138")]
		[Address(RVA = "0x449B708", Offset = "0x4497708", VA = "0x449B708", Slot = "5")]
		public float2 ToPlane(float3 p, out float elevation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ArbitraryMovementPlane.ToPlane RVA=0x449B708 Token=0x6001138");
}

		[Token(Token = "0x6001139")]
		[Address(RVA = "0x449B70C", Offset = "0x449770C", VA = "0x449B70C", Slot = "6")]
		public float3 ToWorld(float2 p, float elevation = 0f)
		{
			return default;
		}

		[Token(Token = "0x600113A")]
		[Address(RVA = "0x449B710", Offset = "0x4497710", VA = "0x449B710", Slot = "7")]
		public Bounds ToWorld(Bounds bounds)
		{
			return default;
		}

		[Token(Token = "0x600113B")]
		[Address(RVA = "0x449B754", Offset = "0x4497754", VA = "0x449B754", Slot = "9")]
		public void Set(NativeMovementPlane plane)
		{
		}
	}
}
