using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Util;
using Unity.Burst;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000052")]
	[BurstCompile]
	public static class Polygon
	{
		[Token(Token = "0x2000053")]
		public struct BarycentricTriangleInterpolator
		{
			[Token(Token = "0x40001FC")]
			[FieldOffset(Offset = "0x0")]
			private int2 origin;

			[Token(Token = "0x40001FD")]
			[FieldOffset(Offset = "0x8")]
			private double2x2 barycentricMapping;

			[Token(Token = "0x40001FE")]
			[FieldOffset(Offset = "0x28")]
			private double3 thresholds;

			[Token(Token = "0x40001FF")]
			[FieldOffset(Offset = "0x40")]
			private double3 linear1;

			[Token(Token = "0x4000200")]
			[FieldOffset(Offset = "0x58")]
			private double3 linear2;

			[Token(Token = "0x4000201")]
			[FieldOffset(Offset = "0x70")]
			private double3 linear3;

			[Token(Token = "0x4000202")]
			[FieldOffset(Offset = "0x88")]
			private double3 ys;

			[Token(Token = "0x6000363")]
			[Address(RVA = "0x44F18D0", Offset = "0x44ED8D0", VA = "0x44F18D0")]
			public BarycentricTriangleInterpolator(Int3 p1, Int3 p2, Int3 p3)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Polygon.BarycentricTriangleInterpolator..ctor RVA=0x44F18D0 Token=0x6000363");
}

			[Token(Token = "0x6000364")]
			[Address(RVA = "0x44F1B10", Offset = "0x44EDB10", VA = "0x44F1B10")]
			public int SampleY(int2 p)
			{
				return default;
			}
		}

		[Token(Token = "0x2000054")]
		public delegate bool ContainsPoint_00000352_0024PostfixBurstDelegate(ref int3 aWorld, ref int3 bWorld, ref int3 cWorld, ref int3 pWorld, ref NativeMovementPlane movementPlane);

		[Token(Token = "0x2000055")]
		internal static class ContainsPoint_00000352_0024BurstDirectCall
		{
			[Token(Token = "0x4000203")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000204")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x600036A")]
			[Address(RVA = "0x44F1ECC", Offset = "0x44EDECC", VA = "0x44F1ECC")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x600036B")]
			[Address(RVA = "0x44F1FE8", Offset = "0x44EDFE8", VA = "0x44F1FE8")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x600036C")]
			[Address(RVA = "0x44F2044", Offset = "0x44EE044", VA = "0x44F2044")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x600036D")]
			[Address(RVA = "0x44F20EC", Offset = "0x44EE0EC", VA = "0x44F20EC")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x600036F")]
			[Address(RVA = "0x44F20F4", Offset = "0x44EE0F4", VA = "0x44F20F4")]
			public static bool Invoke(ref int3 aWorld, ref int3 bWorld, ref int3 cWorld, ref int3 pWorld, ref NativeMovementPlane movementPlane)
			{
				return default;
			}
		}

		[Token(Token = "0x2000056")]
		public delegate bool ClosestPointOnTriangleByRef_00000358_0024PostfixBurstDelegate(in float3 a, in float3 b, in float3 c, in float3 p, [NoAlias] out float3 output);

		[Token(Token = "0x2000057")]
		internal static class ClosestPointOnTriangleByRef_00000358_0024BurstDirectCall
		{
			[Token(Token = "0x4000205")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000206")]
			[FieldOffset(Offset = "0x8")]
			private static unsafe IntPtr DeferredCompilation = BurstCompiler.CompileILPPMethod2(((ClosestPointOnTriangleByRef_00000358_0024PostfixBurstDelegate)Polygon.ClosestPointOnTriangleByRef).Method.MethodHandle);

			[Token(Token = "0x6000374")]
			[Address(RVA = "0x44F2464", Offset = "0x44EE464", VA = "0x44F2464")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
                if (Pointer == IntPtr.Zero)
                {
                    unsafe
                    {
                        Pointer = (IntPtr)BurstCompiler.GetILPPMethodFunctionPointer2(DeferredCompilation,
                            ((ClosestPointOnTriangleByRef_00000358_0024PostfixBurstDelegate)Polygon.ClosestPointOnTriangleByRef_0024BurstManaged).Method.MethodHandle,
                            typeof(ClosestPointOnTriangleByRef_00000358_0024PostfixBurstDelegate).TypeHandle);
                    }
                }
                P_0 = Pointer;
            }

			[Token(Token = "0x6000375")]
			[Address(RVA = "0x44F2580", Offset = "0x44EE580", VA = "0x44F2580")]
			private static IntPtr GetFunctionPointer()
			{
                IntPtr pointer = IntPtr.Zero;
                GetFunctionPointerDiscard(ref pointer);
                return pointer;
            }

			[Token(Token = "0x6000376")]
			[Address(RVA = "0x44F25DC", Offset = "0x44EE5DC", VA = "0x44F25DC")]
			public static void Constructor()
			{
                unsafe { DeferredCompilation = BurstCompiler.CompileILPPMethod2(((ClosestPointOnTriangleByRef_00000358_0024PostfixBurstDelegate)Polygon.ClosestPointOnTriangleByRef).Method.MethodHandle); }
            }

			[Token(Token = "0x6000377")]
			[Address(RVA = "0x44F2684", Offset = "0x44EE684", VA = "0x44F2684")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000379")]
			[Address(RVA = "0x44F268C", Offset = "0x44EE68C", VA = "0x44F268C")]
			public static bool Invoke(in float3 a, in float3 b, in float3 c, in float3 p, [NoAlias] out float3 output)
			{
                if (BurstCompiler.IsEnabled)
                {
                    IntPtr pointer = GetFunctionPointer();
                    if (pointer != IntPtr.Zero)
                    {
                        unsafe
                        {
                            float3 result;
                            bool inside;
                            fixed (float3* pa = &a)
                            fixed (float3* pb = &b)
                            fixed (float3* pc = &c)
                            fixed (float3* pp = &p)
                            {
                                var target = (delegate* unmanaged[Cdecl]<float3*, float3*, float3*, float3*, float3*, bool>)(void*)pointer;
                                inside = target(pa, pb, pc, pp, &result);
                            }
                            output = result;
                            return inside;
                        }
                    }
                }
                return Polygon.ClosestPointOnTriangleByRef_0024BurstManaged(in a, in b, in c, in p, out output);
            }
		}

		[Token(Token = "0x2000058")]
		public delegate void ClosestPointOnTriangleProjected_0000035B_0024PostfixBurstDelegate(ref Int3 vi1, ref Int3 vi2, ref Int3 vi3, ref BBTree.ProjectionParams projection, ref float3 point, [NoAlias] out float3 closest, [NoAlias] out float sqrDist, [NoAlias] out float distAlongProjection);

		[Token(Token = "0x2000059")]
		internal static class ClosestPointOnTriangleProjected_0000035B_0024BurstDirectCall
		{
			[Token(Token = "0x4000207")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000208")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x600037E")]
			[Address(RVA = "0x44F29DC", Offset = "0x44EE9DC", VA = "0x44F29DC")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x600037F")]
			[Address(RVA = "0x44F2AF8", Offset = "0x44EEAF8", VA = "0x44F2AF8")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0x44F2B54", Offset = "0x44EEB54", VA = "0x44F2B54")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6000381")]
			[Address(RVA = "0x44F2BFC", Offset = "0x44EEBFC", VA = "0x44F2BFC")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000383")]
			[Address(RVA = "0x44F2C04", Offset = "0x44EEC04", VA = "0x44F2C04")]
			public static void Invoke(ref Int3 vi1, ref Int3 vi2, ref Int3 vi3, ref BBTree.ProjectionParams projection, ref float3 point, [NoAlias] out float3 closest, [NoAlias] out float sqrDist, [NoAlias] out float distAlongProjection)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Polygon.ClosestPointOnTriangleProjected_0000035B_0024BurstDirectCall.Invoke RVA=0x44F2C04 Token=0x6000383");
}
		}

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Int3, int> cached_Int3_int_dict;

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x4465E9C", Offset = "0x4461E9C", VA = "0x4465E9C")]
		public static bool ContainsPointXZ(Vector3 a, Vector3 b, Vector3 c, Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x4465F3C", Offset = "0x4461F3C", VA = "0x4465F3C")]
		public static bool ContainsPointXZ(Int3 a, Int3 b, Int3 c, Int3 p)
		{
			return default;
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x4465FA8", Offset = "0x4461FA8", VA = "0x4465FA8")]
		public static bool ContainsPoint(Vector2Int a, Vector2Int b, Vector2Int c, Vector2Int p)
		{
			return default;
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x4466050", Offset = "0x4462050", VA = "0x4466050")]
		public static bool ContainsPoint(Vector2[] polyPoints, Vector2 p)
		{
			return default;
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x4466118", Offset = "0x4462118", VA = "0x4466118")]
		public static bool ContainsPointXZ(Vector3[] polyPoints, Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x44661E8", Offset = "0x44621E8", VA = "0x44661E8")]
		[BurstCompile]
		public static bool ContainsPoint(ref int3 aWorld, ref int3 bWorld, ref int3 cWorld, ref int3 pWorld, ref NativeMovementPlane movementPlane)
		{
			return default;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x4466270", Offset = "0x4462270", VA = "0x4466270")]
		public static bool ContainsPoint(ref int3 aWorld, ref int3 bWorld, ref int3 cWorld, ref int3 pWorld, in float2x3 planeProjection)
		{
			return default;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x44664B8", Offset = "0x44624B8", VA = "0x44664B8")]
		public static Vector3[] ConvexHullXZ(Vector3[] points)
		{
			return null;
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x44667E8", Offset = "0x44627E8", VA = "0x44667E8")]
		public static Vector2 ClosestPointOnTriangle(Vector2 a, Vector2 b, Vector2 c, Vector2 p)
		{
			return default;
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x446697C", Offset = "0x446297C", VA = "0x446697C")]
		public static Vector3 ClosestPointOnTriangleXZ(Vector3 a, Vector3 b, Vector3 c, Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x4466B9C", Offset = "0x4462B9C", VA = "0x4466B9C")]
		public static float3 ClosestPointOnTriangle(float3 a, float3 b, float3 c, float3 p)
		{
			return default;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x4466C48", Offset = "0x4462C48", VA = "0x4466C48")]
		[BurstCompile]
		public static bool ClosestPointOnTriangleByRef(in float3 a, in float3 b, in float3 c, in float3 p, [NoAlias] out float3 output)
		{
            return ClosestPointOnTriangleByRef_00000358_0024BurstDirectCall.Invoke(in a, in b, in c, in p, out output);
        }

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x4466CD0", Offset = "0x4462CD0", VA = "0x4466CD0")]
		public static float3 ClosestPointOnTriangleBarycentric(float2 a, float2 b, float2 c, float2 p)
		{
			return default;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x4466E68", Offset = "0x4462E68", VA = "0x4466E68")]
		public static float3 ClosestPointOnTriangleBarycentric(float3 a, float3 b, float3 c, float3 p)
		{
            float3 ab = b - a;
            float3 ac = c - a;
            float3 ap = p - a;
            float d1 = ab.z * ap.z + (ab.x * ap.x + ab.y * ap.y);
            float d2 = ac.z * ap.z + (ac.x * ap.x + ac.y * ap.y);
            if (d1 <= 0f && d2 <= 0f) return new float3(1f, 0f, 0f);
            float3 bp = p - b;
            float d3 = ab.z * bp.z + (ab.x * bp.x + ab.y * bp.y);
            float d4 = ac.z * bp.z + (ac.x * bp.x + ac.y * bp.y);
            if (d3 >= 0f && d4 <= d3) return new float3(0f, 1f, 0f);
            float vc = d1 * d4 - d3 * d2;
            if (d1 >= 0f && d3 <= 0f && vc <= 0f)
            {
                float v = d1 / (d1 - d3);
                return new float3(1f - v, v, 0f);
            }
            float3 cp = p - c;
            float d5 = ab.z * cp.z + (ab.x * cp.x + ab.y * cp.y);
            float d6 = ac.z * cp.z + (ac.x * cp.x + ac.y * cp.y);
            if (d6 >= 0f && d5 <= d6) return new float3(0f, 0f, 1f);
            float vb = d5 * d2 - d1 * d6;
            if (d2 >= 0f && d6 <= 0f && vb <= 0f)
            {
                float w = d2 / (d2 - d6);
                return new float3(1f - w, 0f, w);
            }
            float va = d3 * d6 - d5 * d4;
            float edgeB = d4 - d3;
            if (edgeB >= 0f)
            {
                float edgeC = d5 - d6;
                if (edgeC >= 0f && va <= 0f)
                {
                    float w = edgeB / (edgeB + edgeC);
                    return new float3(0f, 1f - w, w);
                }
            }
            float inverse = 1f / (vc + (va + vb));
            float interiorV = vb * inverse;
            float interiorW = vc * inverse;
            return new float3((1f - interiorV) - interiorW, interiorV, interiorW);
        }

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x4467054", Offset = "0x4463054", VA = "0x4467054")]
		[BurstCompile]
		public static void ClosestPointOnTriangleProjected(ref Int3 vi1, ref Int3 vi2, ref Int3 vi3, ref BBTree.ProjectionParams projection, ref float3 point, [NoAlias] out float3 closest, [NoAlias] out float sqrDist, [NoAlias] out float distAlongProjection)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Polygon.ClosestPointOnTriangleProjected RVA=0x4467054 Token=0x600035B");
}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x4467104", Offset = "0x4463104", VA = "0x4467104")]
		public static void CompressMesh(List<Int3> vertices, List<int> triangles, List<uint> tags, out Int3[] outVertices, out int[] outTriangles, out uint[] outTags)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Polygon.CompressMesh RVA=0x4467104 Token=0x600035C");
}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x4467580", Offset = "0x4463580", VA = "0x4467580")]
		public static void TraceContours(Dictionary<int, int> outline, HashSet<int> hasInEdge, Action<List<int>, bool> results)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x446790C", Offset = "0x446390C", VA = "0x446790C")]
		public static void Subdivide(List<Vector3> points, List<Vector3> result, int subSegments)
		{
            float denominator = (float)subSegments;
            for (int i = 0; i < unchecked(points.Count - 1); i = unchecked(i + 1))
            {
                for (int j = 0; j < subSegments; j = unchecked(j + 1))
                {
                    Vector3 start = points[i];
                    Vector3 end = points[unchecked(i + 1)];
                    float t = (float)j / denominator;
                    if (t > 1f) t = 1f;
                    if (t < 0f) t = 0f;
                    result.Add(new Vector3(
                        start.x + t * (end.x - start.x),
                        start.y + t * (end.y - start.y),
                        start.z + t * (end.z - start.z)));
                }
            }
            result.Add(points[unchecked(points.Count - 1)]);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x4467BCC", Offset = "0x4463BCC", VA = "0x4467BCC")]
		[BurstCompile]
		public static bool ContainsPoint_0024BurstManaged(ref int3 aWorld, ref int3 bWorld, ref int3 cWorld, ref int3 pWorld, ref NativeMovementPlane movementPlane)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x4467C9C", Offset = "0x4463C9C", VA = "0x4467C9C")]
		[BurstCompile]
		public static bool ClosestPointOnTriangleByRef_0024BurstManaged(in float3 a, in float3 b, in float3 c, in float3 p, [NoAlias] out float3 output)
		{
            float3 ab = b - a;
            float3 ac = c - a;
            float3 ap = p - a;
            float d1 = ab.z * ap.z + (ab.x * ap.x + ab.y * ap.y);
            float d2 = ac.z * ap.z + (ac.x * ap.x + ac.y * ap.y);
            if (d1 <= 0f && d2 <= 0f) { output = a; return false; }
            float3 bp = p - b;
            float d3 = ab.z * bp.z + (ab.x * bp.x + ab.y * bp.y);
            float d4 = ac.z * bp.z + (ac.x * bp.x + ac.y * bp.y);
            if (d3 >= 0f && d4 <= d3) { output = b; return false; }
            float vc = d1 * d4 - d3 * d2;
            if (d1 >= 0f && d3 <= 0f && vc <= 0f)
            {
                float v = d1 / (d1 - d3);
                output = a + ab * v;
                return false;
            }
            float3 cp = p - c;
            float d5 = ab.z * cp.z + (ab.x * cp.x + ab.y * cp.y);
            float d6 = ac.z * cp.z + (ac.x * cp.x + ac.y * cp.y);
            if (d6 >= 0f && d5 <= d6) { output = c; return false; }
            float vb = d5 * d2 - d1 * d6;
            if (d2 >= 0f && d6 <= 0f && vb <= 0f)
            {
                float w = d2 / (d2 - d6);
                output = a + ac * w;
                return false;
            }
            float va = d3 * d6 - d5 * d4;
            float edgeB = d4 - d3;
            if (edgeB >= 0f)
            {
                float edgeC = d5 - d6;
                if (edgeC >= 0f && va <= 0f)
                {
                    float w = edgeB / (edgeB + edgeC);
                    output = b + (c - b) * w;
                    return false;
                }
            }
            float inverse = 1f / (vc + (va + vb));
            float interiorV = vb * inverse;
            float interiorW = vc * inverse;
            output = ac * interiorW + (a + ab * interiorV);
            return true;
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x4467EE8", Offset = "0x4463EE8", VA = "0x4467EE8")]
		[BurstCompile]
		public static void ClosestPointOnTriangleProjected_0024BurstManaged(ref Int3 vi1, ref Int3 vi2, ref Int3 vi3, ref BBTree.ProjectionParams projection, ref float3 point, [NoAlias] out float3 closest, [NoAlias] out float sqrDist, [NoAlias] out float distAlongProjection)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Polygon.ClosestPointOnTriangleProjected_0024BurstManaged RVA=0x4467EE8 Token=0x6000362");
}
	}
}
