using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x200004C")]
	public static class DrawingUtilities
	{
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x0")]
		private static List<Component> componentBuffer;

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x46E9974", Offset = "0x46E5974", VA = "0x46E9974")]
		public static Bounds BoundsFrom(GameObject gameObject)
		{
			return default;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x46E9A08", Offset = "0x46E5A08", VA = "0x46E9A08")]
		public static Bounds BoundsFrom(Transform transform)
		{
			return default;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x46E9F18", Offset = "0x46E5F18", VA = "0x46E9F18")]
		public static Bounds BoundsFrom(List<Vector3> points)
		{
			return default;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x46EA0D4", Offset = "0x46E60D4", VA = "0x46EA0D4")]
		public static Bounds BoundsFrom(Vector3[] points)
		{
			return default;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x46EA200", Offset = "0x46E6200", VA = "0x46EA200")]
		public static Bounds BoundsFrom(NativeArray<float3> points)
		{
			return default;
		}
	}
}
