using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Pathfinding
{
	[Token(Token = "0x2000131")]
	[BurstCompile]
	internal static class NavmeshCutJobs
	{
		[Token(Token = "0x2000132")]
		public struct JobCalculateContour
		{
			[Token(Token = "0x4000694")]
			[FieldOffset(Offset = "0x0")]
			public unsafe UnsafeList<float2>* outputVertices;

			[Token(Token = "0x4000695")]
			[FieldOffset(Offset = "0x8")]
			public unsafe UnsafeList<NavmeshCut.ContourBurst>* outputContours;

			[Token(Token = "0x4000696")]
			[FieldOffset(Offset = "0x10")]
			public unsafe UnsafeList<NavmeshCut.ContourBurst>* meshContours;

			[Token(Token = "0x4000697")]
			[FieldOffset(Offset = "0x18")]
			public unsafe UnsafeList<float3>* meshContourVertices;

			[Token(Token = "0x4000698")]
			[FieldOffset(Offset = "0x20")]
			public float4x4 matrix;

			[Token(Token = "0x4000699")]
			[FieldOffset(Offset = "0x60")]
			public float4x4 localToWorldMatrix;

			[Token(Token = "0x400069A")]
			[FieldOffset(Offset = "0xA0")]
			public float radiusMargin;

			[Token(Token = "0x400069B")]
			[FieldOffset(Offset = "0xA4")]
			public int circleResolution;

			[Token(Token = "0x400069C")]
			[FieldOffset(Offset = "0xA8")]
			public float circleRadius;

			[Token(Token = "0x400069D")]
			[FieldOffset(Offset = "0xAC")]
			public float2 rectangleSize;

			[Token(Token = "0x400069E")]
			[FieldOffset(Offset = "0xB4")]
			public float height;

			[Token(Token = "0x400069F")]
			[FieldOffset(Offset = "0xB8")]
			public float meshScale;

			[Token(Token = "0x40006A0")]
			[FieldOffset(Offset = "0xBC")]
			public NavmeshCut.MeshType meshType;

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x455E0E4", Offset = "0x455A0E4", VA = "0x455E0E4")]
			public void Execute()
			{
			}

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x455F288", Offset = "0x455B288", VA = "0x455F288")]
			private unsafe void WindCounterClockwise(UnsafeList<float2>* vertices, int startIndex, int endIndex)
			{
			}
		}

		[Token(Token = "0x2000133")]
		private struct AngleComparator : IComparer<float2>
		{
			[Token(Token = "0x40006A1")]
			[FieldOffset(Offset = "0x0")]
			public float2 origin;

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x455F428", Offset = "0x455B428", VA = "0x455F428", Slot = "4")]
			public int Compare(float2 lhs, float2 rhs)
			{
				return default;
			}
		}

		[Token(Token = "0x2000134")]
		public delegate void CalculateContour_00000988_0024PostfixBurstDelegate(ref JobCalculateContour job);

		[Token(Token = "0x2000135")]
		internal static class CalculateContour_00000988_0024BurstDirectCall
		{
			[Token(Token = "0x40006A2")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x40006A3")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x455F624", Offset = "0x455B624", VA = "0x455F624")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x455F740", Offset = "0x455B740", VA = "0x455F740")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x455F79C", Offset = "0x455B79C", VA = "0x455F79C")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x455F844", Offset = "0x455B844", VA = "0x455F844")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x455D38C", Offset = "0x455938C", VA = "0x455D38C")]
			public static void Invoke(ref JobCalculateContour job)
			{
			}
		}

		[Token(Token = "0x4000693")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float4[] BoxCorners;

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x455C038", Offset = "0x4558038", VA = "0x455C038")]
		[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
		public static void CalculateContour(ref JobCalculateContour job)
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x455D450", Offset = "0x4559450", VA = "0x455D450")]
		private static float ApproximateCircleWithPolylineRadius(float radius, int resolution)
		{
			return default;
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x455D4E0", Offset = "0x45594E0", VA = "0x455D4E0")]
		public unsafe static void CapsuleConvexHullXZ(float4x4 matrix, UnsafeList<float2>* points, float height, float radius, float radiusMargin, int circleResolution, out int numPoints, out float minY, out float maxY)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshCutJobs.CapsuleConvexHullXZ RVA=0x455D4E0 Token=0x60009F8");
}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x455DB48", Offset = "0x4559B48", VA = "0x455DB48")]
		public unsafe static void BoxConvexHullXZ(float4x4 matrix, UnsafeList<float2>* points, out int numPoints, out float minY, out float maxY)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshCutJobs.BoxConvexHullXZ RVA=0x455DB48 Token=0x60009F9");
}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x455DE18", Offset = "0x4559E18", VA = "0x455DE18")]
		public unsafe static int ConvexHull(float2* points, int nPoints, float vertexMergeDistance)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x455E0E0", Offset = "0x455A0E0", VA = "0x455E0E0")]
		[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
		public static void CalculateContour_0024BurstManaged(ref JobCalculateContour job)
		{
		}
	}
}
