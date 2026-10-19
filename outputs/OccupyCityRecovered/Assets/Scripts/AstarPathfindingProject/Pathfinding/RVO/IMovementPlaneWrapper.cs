using Il2CppDummyDll;
using Pathfinding.Util;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002BA")]
	public interface IMovementPlaneWrapper
	{
		[Token(Token = "0x1700027D")]
		float4x4 matrix
		{
			[Token(Token = "0x6001129")]
			get;
		}

		[Token(Token = "0x6001125")]
		float2 ToPlane(float3 p);

		[Token(Token = "0x6001126")]
		float2 ToPlane(float3 p, out float elevation);

		[Token(Token = "0x6001127")]
		float3 ToWorld(float2 p, float elevation = 0f);

		[Token(Token = "0x6001128")]
		Bounds ToWorld(Bounds bounds);

		[Token(Token = "0x600112A")]
		void Set(NativeMovementPlane plane);
	}
}
