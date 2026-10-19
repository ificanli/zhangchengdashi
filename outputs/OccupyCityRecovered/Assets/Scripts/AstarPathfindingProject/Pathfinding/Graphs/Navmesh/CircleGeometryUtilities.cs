using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh
{
	[Token(Token = "0x20001A3")]
	[BurstCompile]
	internal struct CircleGeometryUtilities
	{
		[Token(Token = "0x40007FA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float[] circleRadiusAdjustmentFactors;

		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x45856B8", Offset = "0x45816B8", VA = "0x45856B8")]
		public static int CircleSteps(Matrix4x4 matrix, float radius, float maxError)
		{
			return default;
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x4585894", Offset = "0x4581894", VA = "0x4585894")]
		[GenerateTestsForBurstCompatibility]
		public static float CircleRadiusAdjustmentFactor(int steps)
		{
			return default;
		}
	}
}
