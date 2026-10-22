using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200014B")]
	[BurstCompile]
	public static class Funnel
	{
		[Token(Token = "0x200014C")]
		public struct FunnelPortals
		{
			[Token(Token = "0x40006F2")]
			[FieldOffset(Offset = "0x0")]
			public List<Vector3> left;

			[Token(Token = "0x40006F3")]
			[FieldOffset(Offset = "0x8")]
			public List<Vector3> right;
		}

		[Token(Token = "0x200014D")]
		public enum PartType
		{
			[Token(Token = "0x40006F5")]
			OffMeshLink = 0,
			[Token(Token = "0x40006F6")]
			NodeSequence = 1
		}

		[Token(Token = "0x200014E")]
		public struct PathPart
		{
			[Token(Token = "0x40006F7")]
			[FieldOffset(Offset = "0x0")]
			public int startIndex;

			[Token(Token = "0x40006F8")]
			[FieldOffset(Offset = "0x4")]
			public int endIndex;

			[Token(Token = "0x40006F9")]
			[FieldOffset(Offset = "0x8")]
			public Vector3 startPoint;

			[Token(Token = "0x40006FA")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 endPoint;

			[Token(Token = "0x40006FB")]
			[FieldOffset(Offset = "0x20")]
			public PartType type;
		}

		[Token(Token = "0x200014F")]
		[BurstCompile]
		public struct FunnelState
		{
			[Token(Token = "0x2000150")]
			public delegate void PushStart_00000A34_0024PostfixBurstDelegate(ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref NativeCircularBuffer<float4> unwrappedPortals, ref float3 newLeftPortal, ref float3 newRightPortal, ref float3 projectionAxis);

			[Token(Token = "0x2000151")]
			internal static class PushStart_00000A34_0024BurstDirectCall
			{
				[Token(Token = "0x4000700")]
				[FieldOffset(Offset = "0x0")]
				private static IntPtr Pointer;

				[Token(Token = "0x4000701")]
				[FieldOffset(Offset = "0x8")]
				private static IntPtr DeferredCompilation = BurstCompiler.CompileILPPMethod2(((PushStart_00000A34_0024PostfixBurstDelegate)FunnelState.PushStart).Method.MethodHandle);

				[Token(Token = "0x6000AC0")]
				[Address(RVA = "0x456C194", Offset = "0x4568194", VA = "0x456C194")]
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr P_0)
				{
                    if (Pointer == IntPtr.Zero)
                    {
                        unsafe
                        {
                            Pointer = (IntPtr)BurstCompiler.GetILPPMethodFunctionPointer2(DeferredCompilation,
                                ((PushStart_00000A34_0024PostfixBurstDelegate)FunnelState.PushStart_0024BurstManaged).Method.MethodHandle,
                                typeof(PushStart_00000A34_0024PostfixBurstDelegate).TypeHandle);
                        }
                    }
                    P_0 = Pointer;
                }

				[Token(Token = "0x6000AC1")]
				[Address(RVA = "0x456C2B0", Offset = "0x45682B0", VA = "0x456C2B0")]
				private static IntPtr GetFunctionPointer()
				{
                    IntPtr result = IntPtr.Zero;
                    GetFunctionPointerDiscard(ref result);
                    return result;
                }

				[Token(Token = "0x6000AC2")]
				[Address(RVA = "0x456C30C", Offset = "0x456830C", VA = "0x456C30C")]
				public static void Constructor()
				{
                    DeferredCompilation = BurstCompiler.CompileILPPMethod2(
                        ((PushStart_00000A34_0024PostfixBurstDelegate)FunnelState.PushStart).Method.MethodHandle);
                }

				[Token(Token = "0x6000AC3")]
				[Address(RVA = "0x456C3B4", Offset = "0x45683B4", VA = "0x456C3B4")]
				public static void Initialize()
				{
				}

				[Token(Token = "0x6000AC5")]
				[Address(RVA = "0x456A718", Offset = "0x4566718", VA = "0x456A718")]
				public static void Invoke(ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref NativeCircularBuffer<float4> unwrappedPortals, ref float3 newLeftPortal, ref float3 newRightPortal, ref float3 projectionAxis)
				{
                    if (BurstCompiler.IsEnabled)
                    {
                        IntPtr functionPointer = GetFunctionPointer();
                        if (functionPointer != IntPtr.Zero)
                        {
                            unsafe
                            {
                                var target = (delegate* unmanaged[Cdecl]<ref NativeCircularBuffer<float3>, ref NativeCircularBuffer<float3>, ref NativeCircularBuffer<float4>, ref float3, ref float3, ref float3, void>)(void*)functionPointer;
                                target(ref leftPortals, ref rightPortals, ref unwrappedPortals, ref newLeftPortal, ref newRightPortal, ref projectionAxis);
                                return;
                            }
                        }
                    }
                    FunnelState.PushStart_0024BurstManaged(ref leftPortals, ref rightPortals, ref unwrappedPortals, ref newLeftPortal, ref newRightPortal, ref projectionAxis);
                }
			}

			[Token(Token = "0x2000152")]
			public delegate void ConvertCornerIndicesToPathProjected_00000A3E_0024PostfixBurstDelegate(ref FunnelState funnelState, ref UnsafeSpan<int> indices, bool splitAtEveryPortal, in float3 startPoint, in float3 endPoint, bool lastCorner, in float3 projectionAxis, ref UnsafeSpan<float3> result, in float3 up);

			[Token(Token = "0x2000153")]
			internal static class ConvertCornerIndicesToPathProjected_00000A3E_0024BurstDirectCall
			{
				[Token(Token = "0x4000702")]
				[FieldOffset(Offset = "0x0")]
				private static IntPtr Pointer;

				[Token(Token = "0x4000703")]
				[FieldOffset(Offset = "0x8")]
				private static IntPtr DeferredCompilation = BurstCompiler.CompileILPPMethod2(((ConvertCornerIndicesToPathProjected_00000A3E_0024PostfixBurstDelegate)FunnelState.ConvertCornerIndicesToPathProjected).Method.MethodHandle);

				[Token(Token = "0x6000ACA")]
				[Address(RVA = "0x456C650", Offset = "0x4568650", VA = "0x456C650")]
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr P_0)
				{
                    if (Pointer == IntPtr.Zero)
                    {
                        unsafe
                        {
                            Pointer = (IntPtr)BurstCompiler.GetILPPMethodFunctionPointer2(DeferredCompilation,
                                ((ConvertCornerIndicesToPathProjected_00000A3E_0024PostfixBurstDelegate)FunnelState.ConvertCornerIndicesToPathProjected_0024BurstManaged).Method.MethodHandle,
                                typeof(ConvertCornerIndicesToPathProjected_00000A3E_0024PostfixBurstDelegate).TypeHandle);
                        }
                    }
                    P_0 = Pointer;
                }

				[Token(Token = "0x6000ACB")]
				[Address(RVA = "0x456C76C", Offset = "0x456876C", VA = "0x456C76C")]
				private static IntPtr GetFunctionPointer()
				{
                    IntPtr result = IntPtr.Zero;
                    GetFunctionPointerDiscard(ref result);
                    return result;
                }

				[Token(Token = "0x6000ACC")]
				[Address(RVA = "0x456C7C8", Offset = "0x45687C8", VA = "0x456C7C8")]
				public static void Constructor()
				{
                    DeferredCompilation = BurstCompiler.CompileILPPMethod2(
                        ((ConvertCornerIndicesToPathProjected_00000A3E_0024PostfixBurstDelegate)FunnelState.ConvertCornerIndicesToPathProjected).Method.MethodHandle);
                }

				[Token(Token = "0x6000ACD")]
				[Address(RVA = "0x456C870", Offset = "0x4568870", VA = "0x456C870")]
				public static void Initialize()
				{
				}

				[Token(Token = "0x6000ACF")]
				[Address(RVA = "0x456B63C", Offset = "0x456763C", VA = "0x456B63C")]
				public static void Invoke(ref FunnelState funnelState, ref UnsafeSpan<int> indices, bool splitAtEveryPortal, in float3 startPoint, in float3 endPoint, bool lastCorner, in float3 projectionAxis, ref UnsafeSpan<float3> result, in float3 up)
				{
                    if (BurstCompiler.IsEnabled)
                    {
                        IntPtr functionPointer = GetFunctionPointer();
                        if (functionPointer != IntPtr.Zero)
                        {
                            unsafe
                            {
                                var target = (delegate* unmanaged[Cdecl]<ref FunnelState, ref UnsafeSpan<int>, bool, in float3, in float3, bool, in float3, ref UnsafeSpan<float3>, in float3, void>)(void*)functionPointer;
                                target(ref funnelState, ref indices, splitAtEveryPortal, in startPoint, in endPoint, lastCorner, in projectionAxis, ref result, in up);
                                return;
                            }
                        }
                    }
                    FunnelState.ConvertCornerIndicesToPathProjected_0024BurstManaged(ref funnelState, ref indices, splitAtEveryPortal, in startPoint, in endPoint, lastCorner, in projectionAxis, ref result, in up);
                }
			}

			[Token(Token = "0x40006FC")]
			[FieldOffset(Offset = "0x0")]
			public NativeCircularBuffer<float3> leftFunnel;

			[Token(Token = "0x40006FD")]
			[FieldOffset(Offset = "0x18")]
			public NativeCircularBuffer<float3> rightFunnel;

			[Token(Token = "0x40006FE")]
			[FieldOffset(Offset = "0x30")]
			public NativeCircularBuffer<float4> unwrappedPortals;

			[Token(Token = "0x40006FF")]
			[FieldOffset(Offset = "0x48")]
			public float3 projectionAxis;

			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x4569BFC", Offset = "0x4565BFC", VA = "0x4569BFC")]
			public FunnelState(int initialCapacity, Allocator allocator)
			{
                leftFunnel = new NativeCircularBuffer<float3>(initialCapacity, allocator);
                rightFunnel = new NativeCircularBuffer<float3>(initialCapacity, allocator);
                unwrappedPortals = new NativeCircularBuffer<float4>(initialCapacity, allocator);
                projectionAxis = float3.zero;
            }

			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x4568DE4", Offset = "0x4564DE4", VA = "0x4568DE4")]
			public FunnelState(FunnelPortals portals, Allocator allocator) : this(portals.left.Count, allocator)
			{
                if (portals.left.Count != portals.right.Count)
                    throw new ArgumentException("portals.left.Count != portals.right.Count");
                for (int i = 0; i < portals.left.Count; i = unchecked(i + 1))
                    PushEnd(portals.left[i], portals.right[i]);
            }

			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x4569EE0", Offset = "0x4565EE0", VA = "0x4569EE0")]
			public FunnelState Clone()
			{
                return new FunnelState
                {
                    leftFunnel = leftFunnel.Clone(),
                    rightFunnel = rightFunnel.Clone(),
                    unwrappedPortals = unwrappedPortals.Clone(),
                    projectionAxis = projectionAxis
                };
            }

			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x4569FD8", Offset = "0x4565FD8", VA = "0x4569FD8")]
			public void Clear()
			{
                leftFunnel.Clear();
                rightFunnel.Clear();
                unwrappedPortals.Clear();
                projectionAxis = float3.zero;
            }

			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x4568F30", Offset = "0x4564F30", VA = "0x4568F30")]
			public void PopStart()
			{
                leftFunnel.PopStart();
                rightFunnel.PopStart();
                if (unwrappedPortals.Length > 0) unwrappedPortals.PopStart();
            }

			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x4568FC8", Offset = "0x4564FC8", VA = "0x4568FC8")]
			public void PopEnd()
			{
                leftFunnel.PopEnd();
                rightFunnel.PopEnd();
                unwrappedPortals.TrimTo(leftFunnel.Length);
            }

			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x456A084", Offset = "0x4566084", VA = "0x456A084")]
			public void Pop(bool fromStart)
			{
                if (fromStart) PopStart();
                else PopEnd();
            }

			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x456A090", Offset = "0x4566090", VA = "0x456A090")]
			public void PushStart(float3 newLeftPortal, float3 newRightPortal)
			{
                PushStart(ref leftFunnel, ref rightFunnel, ref unwrappedPortals,
                    ref newLeftPortal, ref newRightPortal, ref projectionAxis);
            }

			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x456A160", Offset = "0x4566160", VA = "0x456A160")]
			private static bool DifferentSidesOfLine(float3 start, float3 end, float3 a, float3 b)
			{
            // Original ARM64 normalizesafe threshold is the smallest normal float, not an arbitrary epsilon.
                float dx = end.x - start.x;
                float dy = end.y - start.y;
                float dz = end.z - start.z;
                float lengthSq = dz * dz + (dx * dx + dy * dy);
                float inverseLength = 1f / (float)System.Math.Sqrt(lengthSq);
                float nx = lengthSq > 1.17549435E-38f ? dx * inverseLength : 0f;
                float ny = lengthSq > 1.17549435E-38f ? dy * inverseLength : 0f;
                float nz = lengthSq > 1.17549435E-38f ? dz * inverseLength : 0f;
                float ax = a.x - start.x, ay = a.y - start.y, az = a.z - start.z;
                float bx = b.x - start.x, by = b.y - start.y, bz = b.z - start.z;
                float ad = az * nz + (ax * nx + ay * ny);
                float bd = bz * nz + (bx * nx + by * ny);
                ax = ax - nx * ad; ay = ay - ny * ad; az = az - nz * ad;
                bx = bx - nx * bd; by = by - ny * bd; bz = bz - nz * bd;
                return az * bz + (ax * bx + ay * by) < 0f;
        }

			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x456A300", Offset = "0x4566300", VA = "0x456A300")]
			public bool IsReasonableToPopStart(float3 startPoint, float3 endPoint)
			{
                if (leftFunnel.Length == 0) return false;
                int i = 1;
                while (i < leftFunnel.Length && VectorMath.IsColinear((Vector3)leftFunnel[0], (Vector3)rightFunnel[0], (Vector3)leftFunnel[i]))
                    i = unchecked(i + 1);
                return !DifferentSidesOfLine(leftFunnel[0], rightFunnel[0], startPoint, i < leftFunnel.Length ? leftFunnel[i] : endPoint);
            }

			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x456A508", Offset = "0x4566508", VA = "0x456A508")]
			public bool IsReasonableToPopEnd(float3 startPoint, float3 endPoint)
			{
                if (leftFunnel.Length == 0) return false;
                int i = unchecked(leftFunnel.Length - 1);
                while (i >= 0 && VectorMath.IsColinear((Vector3)leftFunnel.Last, (Vector3)rightFunnel.Last, (Vector3)leftFunnel[i]))
                    i = unchecked(i - 1);
                return !DifferentSidesOfLine(leftFunnel.Last, rightFunnel.Last, endPoint, i >= 0 ? leftFunnel[i] : startPoint);
            }

			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x456A0CC", Offset = "0x45660CC", VA = "0x456A0CC")]
			[BurstCompile]
			private static void PushStart(ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref NativeCircularBuffer<float4> unwrappedPortals, ref float3 newLeftPortal, ref float3 newRightPortal, ref float3 projectionAxis)
			{ PushStart_00000A34_0024BurstDirectCall.Invoke(ref leftPortals, ref rightPortals, ref unwrappedPortals, ref newLeftPortal, ref newRightPortal, ref projectionAxis); }

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x456A81C", Offset = "0x456681C", VA = "0x456A81C")]
			public void Splice(int startIndex, int toRemove, List<float3> newLeftPortal, List<float3> newRightPortal)
			{
                leftFunnel.Splice(startIndex, toRemove, newLeftPortal);
                rightFunnel.Splice(startIndex, toRemove, newRightPortal);
                unwrappedPortals.TrimTo(startIndex);
            }

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x4569D44", Offset = "0x4565D44", VA = "0x4569D44")]
			public void PushEnd(Vector3 newLeftPortal, Vector3 newRightPortal)
			{
                leftFunnel.PushEnd(newLeftPortal);
                rightFunnel.PushEnd(newRightPortal);
            }

			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x456A8D4", Offset = "0x45668D4", VA = "0x456A8D4")]
			public void Push(bool toStart, Vector3 newLeftPortal, Vector3 newRightPortal)
			{
                if (toStart) PushStart(newLeftPortal, newRightPortal);
                else PushEnd(newLeftPortal, newRightPortal);
            }

			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x456919C", Offset = "0x456519C", VA = "0x456919C")]
			public void Dispose()
			{
                leftFunnel.Dispose();
                rightFunnel.Dispose();
                unwrappedPortals.Dispose();
            }

			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x456A974", Offset = "0x4566974", VA = "0x456A974")]
			public int CalculateNextCornerIndices(int maxCorners, NativeArray<int> result, float3 startPoint, float3 endPoint, out bool lastCorner)
			{
                if (Math.Min(leftFunnel.Length, maxCorners) > result.Length)
                    throw new ArgumentException("result array may not be large enough to hold all corners");
                UnsafeSpan<int> span = result.AsUnsafeSpan();
                return Funnel.Calculate(ref unwrappedPortals, ref leftFunnel, ref rightFunnel,
                    ref startPoint, ref endPoint, ref span, maxCorners, ref projectionAxis, out lastCorner);
            }

			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x4569054", Offset = "0x4565054", VA = "0x4569054")]
			public void CalculateNextCorners(int maxCorners, bool splitAtEveryPortal, float3 startPoint, float3 endPoint, NativeList<float3> result)
			{
                var indices = new NativeArray<int>(Math.Min(leftFunnel.Length, maxCorners), Allocator.Temp, NativeArrayOptions.ClearMemory);
                bool lastCorner;
                int count = CalculateNextCornerIndices(maxCorners, indices, startPoint, endPoint, out lastCorner);
                ConvertCornerIndicesToPath(indices, count, splitAtEveryPortal, startPoint, endPoint, lastCorner, result);
                indices.Dispose();
            }

			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x456AAB4", Offset = "0x4566AB4", VA = "0x456AAB4")]
			public void ConvertCornerIndicesToPath(NativeArray<int> indices, int numCorners, bool splitAtEveryPortal, float3 startPoint, float3 endPoint, bool lastCorner, NativeList<float3> result)
			{
                if (result.Capacity < numCorners) result.Capacity = numCorners;
                result.Add(startPoint);
                if (leftFunnel.Length != 0)
                {
                    if (splitAtEveryPortal)
                    {
                        float2 previous = Unwrap(leftFunnel.First, rightFunnel.First,
                            unwrappedPortals.First.xy, unwrappedPortals.First.zw, startPoint, -1f, projectionAxis);
                        int startIndex = 0;
                        for (int i = 0; i < numCorners; i = unchecked(i + 1))
                        {
                            int encoded = indices[i];
                            int index = encoded & FunnelPortalIndexMask;
                            bool rightSide = (encoded & RightSideBit) != 0;
                            float4 portal = unwrappedPortals[index];
                            float2 next = rightSide ? portal.zw : portal.xy;
                            CalculatePortalIntersections(startIndex, unchecked(index - 1), leftFunnel, rightFunnel,
                                unwrappedPortals, previous, next, result);
                            result.Add(rightSide ? rightFunnel[index] : leftFunnel[index]);
                            startIndex = unchecked(index + 1);
                            previous = next;
                        }
                        if (lastCorner)
                        {
                            float2 end = Unwrap(leftFunnel.Last, rightFunnel.Last,
                                unwrappedPortals.Last.xy, unwrappedPortals.Last.zw, endPoint, 1f, projectionAxis);
                            CalculatePortalIntersections(startIndex, unwrappedPortals.Length, leftFunnel, rightFunnel,
                                unwrappedPortals, previous, end, result);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < numCorners; i = unchecked(i + 1))
                        {
                            int encoded = indices[i];
                            int index = encoded & FunnelPortalIndexMask;
                            result.Add((encoded & RightSideBit) != 0 ? rightFunnel[index] : leftFunnel[index]);
                        }
                    }
                }
                if (lastCorner) result.Add(endPoint);
            }

			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x456B124", Offset = "0x4567124", VA = "0x456B124")]
			public void ConvertCornerIndicesToPathProjected(UnsafeSpan<int> indices, bool splitAtEveryPortal, float3 startPoint, float3 endPoint, bool lastCorner, NativeList<float3> result, float3 up)
			{
                int length = unchecked(indices.Length + (lastCorner ? 2 : 1));
                if (result.Capacity < length) result.Capacity = length;
                result.ResizeUninitialized(length);
                UnsafeSpan<float3> output = result.AsUnsafeSpan();
                ConvertCornerIndicesToPathProjected(ref this, ref indices, splitAtEveryPortal,
                    in startPoint, in endPoint, lastCorner, in projectionAxis, ref output, in up);
            }

			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x456B368", Offset = "0x4567368", VA = "0x456B368")]
			public float4x3 UnwrappedPortalsToWorldMatrix(float3 up)
			{
                int selected = -1;
                float4 portal = default;
                int cacheCount = unwrappedPortals.Length;
                for (int i = 0; i < cacheCount; i = unchecked(i + 1))
                {
                    portal = unwrappedPortals[i];
                    float dx = portal.x - portal.z;
                    float dy = portal.y - portal.w;
                    float lengthSquared = dx * dx + dy * dy;
                    if (!(lengthSquared <= 9.99999975e-06f))
                    {
                        selected = i;
                        break;
                    }
                }
                if (selected < 0)
                    return new float4x3(new float4(1f, 0f, 0f, 0f), new float4(0f, 0f, 0f, 0f), new float4(0f, 1f, 0f, 1f));
                float3 left = leftFunnel[selected];
                float3 right = rightFunnel[selected];
                float s0 = 0f, s1 = 0f, s2 = 0f, s3 = 0f, s4 = 0f, s5 = 0f, s6 = 0f, s7 = 0f, s8 = 0f, s9 = 0f, s10 = 0f, s11 = 0f, s12 = 0f, s13 = 0f, s14 = 0f, s15 = 0f, s16 = 0f, s17 = 0f, s18 = 0f, s19 = 0f, s20 = 0f, s21 = 0f, s22 = 0f, s23 = 0f, s24 = 0f, s25 = 0f, s26 = 0f, s27 = 0f, s28 = 0f, s29 = 0f, s30 = 0f, s31 = 0f;
                s0 = portal.z; s1 = portal.w; s6 = portal.x; s7 = portal.y;
                s8 = up.z; s9 = up.y; s10 = up.x;
                s21 = left.x; s22 = left.y; s23 = left.z;
                s24 = right.x; s25 = right.y; s26 = right.z;
                s5 = s0 - s6; // 0x456b468
                s16 = s1 - s7; // 0x456b46c
                s1 = s5 * s5; // 0x456b47c
                s19 = s16 * s16; // 0x456b480
                s0 = 1f; // 0x456b484
                s1 = s1 + s19; // 0x456b488
                s19 = s0 / s1; // 0x456b48c
                s17 = -s7; // 0x456b498
                s18 = 0f; // 0x456b49c
                s1 = s5 * s19; // 0x456b4a0
                s5 = s16 * s19; // 0x456b4a4
                s16 = s6 * s5; // 0x456b4a8
                s17 = s5 * s17; // 0x456b4ac
                s6 = s6 * s1; // 0x456b4b0
                s7 = s7 * s1; // 0x456b4b4
                s20 = s5 * s18; // 0x456b4b8
                s19 = s1 * s18; // 0x456b4c4
                s17 = s17 - s6; // 0x456b4c8
                s6 = s16 - s7; // 0x456b4cc
                s16 = s20 + s18; // 0x456b4d0
                s7 = s19 + s18; // 0x456b4e4
                s16 = s19 + s16; // 0x456b4e8
                s19 = s17 * s18; // 0x456b4ec
                s7 = s7 - s20; // 0x456b4f0
                s20 = s6 * s18; // 0x456b4f4
                s19 = s19 + s18; // 0x456b4f8
                s19 = s20 + s19; // 0x456b4fc
                s0 = s19 + s0; // 0x456b500
                s19 = s24 - s21; // 0x456b504
                s20 = s25 - s22; // 0x456b508
                s24 = s26 - s23; // 0x456b50c
                s4 = s8 * s18; // 0x456b510
                s27 = s9 * s19; // 0x456b514
                s28 = s8 * s20; // 0x456b518
                s29 = s10 * s24; // 0x456b51c
                s30 = s10 * s20; // 0x456b520
                s31 = s9 * s24; // 0x456b524
                s8 = s8 * s19; // 0x456b528
                s2 = s10 * s18; // 0x456b52c
                s3 = s9 * s18; // 0x456b530
                s9 = s1 * s19; // 0x456b534
                s10 = s1 * s20; // 0x456b538
                s11 = s1 * s24; // 0x456b53c
                s12 = s5 * s19; // 0x456b540
                s13 = s5 * s20; // 0x456b544
                s14 = s5 * s24; // 0x456b548
                s19 = s17 * s19; // 0x456b54c
                s20 = s17 * s20; // 0x456b550
                s17 = s17 * s24; // 0x456b554
                s24 = s27 - s30; // 0x456b558
                s27 = s28 - s31; // 0x456b55c
                s28 = s29 - s8; // 0x456b560
                s29 = s2 + s9; // 0x456b564
                s30 = s3 + s10; // 0x456b568
                s31 = s4 + s11; // 0x456b56c
                s8 = s2 + s12; // 0x456b570
                s9 = s3 + s13; // 0x456b574
                s10 = s4 + s14; // 0x456b578
                s2 = s2 + s19; // 0x456b57c
                s3 = s3 + s20; // 0x456b580
                s4 = s4 + s17; // 0x456b584
                s17 = s5 * s27; // 0x456b588
                s19 = s5 * s28; // 0x456b58c
                s5 = s5 * s24; // 0x456b590
                s20 = s1 * s27; // 0x456b594
                s11 = s1 * s28; // 0x456b598
                s1 = s1 * s24; // 0x456b59c
                s27 = s6 * s27; // 0x456b5a0
                s28 = s6 * s28; // 0x456b5a4
                s6 = s6 * s24; // 0x456b5a8
                s7 = s7 + s18; // 0x456b5ac
                s16 = s16 + s18; // 0x456b5b0
                s25 = s21 * s18; // 0x456b5b4
                s26 = s22 * s18; // 0x456b5b8
                s18 = s23 * s18; // 0x456b5bc
                s17 = s29 - s17; // 0x456b5c0
                s19 = s30 - s19; // 0x456b5c4
                s5 = s31 - s5; // 0x456b5c8
                s20 = s8 + s20; // 0x456b5cc
                s24 = s9 + s11; // 0x456b5d0
                s1 = s10 + s1; // 0x456b5d4
                s2 = s2 + s27; // 0x456b5d8
                s3 = s3 + s28; // 0x456b5dc
                s4 = s4 + s6; // 0x456b5e0
                s6 = s25 + s17; // 0x456b5e4
                s17 = s26 + s19; // 0x456b5e8
                s5 = s18 + s5; // 0x456b5ec
                s19 = s25 + s20; // 0x456b5f0
                s20 = s26 + s24; // 0x456b5f4
                s18 = s18 + s1; // 0x456b5f8
                s2 = s21 + s2; // 0x456b5fc
                s3 = s22 + s3; // 0x456b600
                s1 = s23 + s4; // 0x456b604
                return new float4x3(new float4(s6, s17, s5, s7), new float4(s19, s20, s18, s16), new float4(s2, s3, s1, s0));
            }

			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x456B2B4", Offset = "0x45672B4", VA = "0x456B2B4")]
			[BurstCompile]
			public static void ConvertCornerIndicesToPathProjected(ref FunnelState funnelState, ref UnsafeSpan<int> indices, bool splitAtEveryPortal, in float3 startPoint, in float3 endPoint, bool lastCorner, in float3 projectionAxis, ref UnsafeSpan<float3> result, in float3 up)
			{ ConvertCornerIndicesToPathProjected_00000A3E_0024BurstDirectCall.Invoke(ref funnelState, ref indices, splitAtEveryPortal, in startPoint, in endPoint, lastCorner, in projectionAxis, ref result, in up); }

			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x456AF8C", Offset = "0x4566F8C", VA = "0x456AF8C")]
			private static void CalculatePortalIntersections(int startIndex, int endIndex, NativeCircularBuffer<float3> leftPortals, NativeCircularBuffer<float3> rightPortals, NativeCircularBuffer<float4> unwrappedPortals, float2 from, float2 to, NativeList<float3> result)
			{
                float2 direction = to - from;
                for (int i = startIndex; i < endIndex; i = unchecked(i + 1))
                {
                    float4 portal = unwrappedPortals[i];
                    float factor;
                    if (!VectorMath.LineLineIntersectionFactor(portal.xy, portal.zw - portal.xy, from, direction, out factor))
                        factor = 0.5f;
                    float3 left = leftPortals[i];
                    float3 right = rightPortals[i];
                    result.Add(new float3(
                        left.x + (right.x - left.x) * factor,
                        left.y + (right.y - left.y) * factor,
                        left.z + (right.z - left.z) * factor));
                }
            }

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x456B76C", Offset = "0x456776C", VA = "0x456B76C")]
			[BurstCompile]
			public static void PushStart_0024BurstManaged(ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref NativeCircularBuffer<float4> unwrappedPortals, ref float3 newLeftPortal, ref float3 newRightPortal, ref float3 projectionAxis)
			{
                if (unwrappedPortals.Length != 0)
                {
                    float4 first = unwrappedPortals.First;
                    float2 newRightUnwrapped = Unwrap(leftPortals.First, rightPortals.First,
                        first.xy, first.zw, newRightPortal, -1f, projectionAxis);
                    float2 newLeftUnwrapped = Unwrap(leftPortals.First, newRightPortal,
                        first.xy, newRightUnwrapped, newLeftPortal, -1f, projectionAxis);
                    leftPortals.PushStart(newLeftPortal);
                    rightPortals.PushStart(newRightPortal);
                    unwrappedPortals.PushStart(new float4(newLeftUnwrapped, newRightUnwrapped));
                }
                else
                {
                    leftPortals.PushStart(newLeftPortal);
                    rightPortals.PushStart(newRightPortal);
                }
            }

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x456BB98", Offset = "0x4567B98", VA = "0x456BB98")]
			[BurstCompile]
			public static void ConvertCornerIndicesToPathProjected_0024BurstManaged(ref FunnelState funnelState, ref UnsafeSpan<int> indices, bool splitAtEveryPortal, in float3 startPoint, in float3 endPoint, bool lastCorner, in float3 projectionAxis, ref UnsafeSpan<float3> result, in float3 up)
			{
                result[0] = startPoint;
                if (funnelState.leftFunnel.Length == 0)
                {
                    if (lastCorner) result[1] = endPoint;
                    return;
                }
                float4x3 matrix = funnelState.UnwrappedPortalsToWorldMatrix(up);
                if (splitAtEveryPortal) throw new NotSupportedException();
                int outputIndex = 1;
                for (int i = 0; i < indices.Length; i = unchecked(i + 1))
                {
                    int encoded = indices[i];
                    int index = encoded & FunnelPortalIndexMask;
                    if ((uint)outputIndex >= (uint)result.Length) throw new IndexOutOfRangeException();
                    float4 portal = funnelState.unwrappedPortals[index];
                    float2 uv = (encoded & RightSideBit) != 0 ? portal.zw : portal.xy;
                    result[outputIndex] = new float3(
                        matrix.c2.x + (matrix.c0.x * uv.x + matrix.c1.x * uv.y),
                        matrix.c2.y + (matrix.c0.y * uv.x + matrix.c1.y * uv.y),
                        matrix.c2.z + (matrix.c0.z * uv.x + matrix.c1.z * uv.y));
                    outputIndex = unchecked(outputIndex + 1);
                }
                if (lastCorner)
                {
                    float2 uv = Unwrap(funnelState.leftFunnel.Last, funnelState.rightFunnel.Last,
                        funnelState.unwrappedPortals.Last.xy, funnelState.unwrappedPortals.Last.zw,
                        endPoint, 1f, projectionAxis);
                    if ((uint)outputIndex >= (uint)result.Length) throw new IndexOutOfRangeException();
                    result[outputIndex] = new float3(
                        matrix.c2.x + (matrix.c0.x * uv.x + matrix.c1.x * uv.y),
                        matrix.c2.y + (matrix.c0.y * uv.x + matrix.c1.y * uv.y),
                        matrix.c2.z + (matrix.c0.z * uv.x + matrix.c1.z * uv.y));
                }
            }
		}

		[Token(Token = "0x2000154")]
		public delegate int Calculate_00000A26_0024PostfixBurstDelegate(ref NativeCircularBuffer<float4> unwrappedPortals, ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref float3 startPoint, ref float3 endPoint, ref UnsafeSpan<int> funnelPath, int maxCorners, ref float3 projectionAxis, out bool lastCorner);

		[Token(Token = "0x2000155")]
		internal static class Calculate_00000A26_0024BurstDirectCall
		{
			[Token(Token = "0x4000704")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000705")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation = BurstCompiler.CompileILPPMethod2(((Calculate_00000A26_0024PostfixBurstDelegate)Funnel.Calculate).Method.MethodHandle);

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x456CB20", Offset = "0x4568B20", VA = "0x456CB20")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
                    if (Pointer == IntPtr.Zero)
                    {
                        unsafe
                        {
                            Pointer = (IntPtr)BurstCompiler.GetILPPMethodFunctionPointer2(
                                DeferredCompilation,
                                ((Calculate_00000A26_0024PostfixBurstDelegate)Funnel.Calculate_0024BurstManaged).Method.MethodHandle,
                                typeof(Calculate_00000A26_0024PostfixBurstDelegate).TypeHandle);
                        }
                    }
                    P_0 = Pointer;
                }

			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x456CC3C", Offset = "0x4568C3C", VA = "0x456CC3C")]
			private static IntPtr GetFunctionPointer()
			{
                    IntPtr result = IntPtr.Zero;
                    GetFunctionPointerDiscard(ref result);
                    return result;
                }

			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x456CC98", Offset = "0x4568C98", VA = "0x456CC98")]
			public static void Constructor()
			{
                    DeferredCompilation = BurstCompiler.CompileILPPMethod2(
                        ((Calculate_00000A26_0024PostfixBurstDelegate)Funnel.Calculate).Method.MethodHandle);
                }

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x456CD40", Offset = "0x4568D40", VA = "0x456CD40")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x45692CC", Offset = "0x45652CC", VA = "0x45692CC")]
			public static int Invoke(ref NativeCircularBuffer<float4> unwrappedPortals, ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref float3 startPoint, ref float3 endPoint, ref UnsafeSpan<int> funnelPath, int maxCorners, ref float3 projectionAxis, out bool lastCorner)
			{
                    if (BurstCompiler.IsEnabled)
                    {
                        IntPtr functionPointer = GetFunctionPointer();
                        if (functionPointer != IntPtr.Zero)
                        {
                            unsafe
                            {
                                var target = (delegate* unmanaged[Cdecl]<ref NativeCircularBuffer<float4>, ref NativeCircularBuffer<float3>, ref NativeCircularBuffer<float3>, ref float3, ref float3, ref UnsafeSpan<int>, int, ref float3, out bool, int>)(void*)functionPointer;
                                return target(ref unwrappedPortals, ref leftPortals, ref rightPortals, ref startPoint, ref endPoint, ref funnelPath, maxCorners, ref projectionAxis, out lastCorner);
                            }
                        }
                    }
                    return Funnel.Calculate_0024BurstManaged(ref unwrappedPortals, ref leftPortals, ref rightPortals, ref startPoint, ref endPoint, ref funnelPath, maxCorners, ref projectionAxis, out lastCorner);
                }
		}

		[Token(Token = "0x40006F0")]
		public const int RightSideBit = 1073741824;

		[Token(Token = "0x40006F1")]
		public const int FunnelPortalIndexMask = 1073741823;

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x45669A4", Offset = "0x45629A4", VA = "0x45669A4")]
		public static List<PathPart> SplitIntoParts(Path path)
		{
            List<GraphNode> nodes = path.path;
            List<PathPart> result = Pathfinding.Pooling.ListPool<PathPart>.Claim();
            if (nodes == null || nodes.Count == 0) return result;
            for (int i = 0; i < nodes.Count;)
            {
                GraphNode node = nodes[i];
                int end;
                PathPart part;
                if (node is TriangleMeshNode || node is GridNodeBase)
                {
                    uint graphIndex = node.GraphIndex;
                    end = i;
                    while (end < nodes.Count)
                    {
                        if (nodes[end].GraphIndex != graphIndex && !(nodes[end] is NodeLink3Node)) break;
                        end = unchecked(end + 1);
                    }
                    part = new PathPart {
                        startIndex = i,
                        endIndex = unchecked(end - 1),
                        type = PartType.NodeSequence
                    };
                    if (i == 0) part.startPoint = path.vectorPath[0];
                    else
                    {
                        Int3 position = nodes[unchecked(i - 1)].position;
                        part.startPoint = new Vector3((float)position.x * 0.001f, (float)position.y * 0.001f, (float)position.z * 0.001f);
                    }
                    if (end == nodes.Count) part.endPoint = path.vectorPath[unchecked(path.vectorPath.Count - 1)];
                    else
                    {
                        Int3 position = nodes[end].position;
                        part.endPoint = new Vector3((float)position.x * 0.001f, (float)position.y * 0.001f, (float)position.z * 0.001f);
                    }
                }
                else if (node is LinkNode)
                {
                    uint graphIndex = node.GraphIndex;
                    end = i;
                    while (end < nodes.Count && nodes[end].GraphIndex == graphIndex) end = unchecked(end + 1);
                    int linkCount = unchecked(end - i);
                    if (linkCount == 1)
                    {
                        if (i > 0 && unchecked(i + 1) < nodes.Count && nodes[unchecked(i - 1)] == nodes[unchecked(i + 1)])
                        {
                            nodes.RemoveRange(i, 2);
                            throw new System.Exception("Link node connected back to the previous node in the path. This should not happen.");
                        }
                        nodes.RemoveAt(i);
                        continue;
                    }
                    if (linkCount != 2) throw new System.Exception("Off mesh link included more than two nodes: " + linkCount);
                    Int3 start = nodes[i].position;
                    Int3 finish = nodes[unchecked(end - 1)].position;
                    part = new PathPart {
                        startIndex = i,
                        endIndex = unchecked(end - 1),
                        startPoint = new Vector3((float)start.x * 0.001f, (float)start.y * 0.001f, (float)start.z * 0.001f),
                        endPoint = new Vector3((float)finish.x * 0.001f, (float)finish.y * 0.001f, (float)finish.z * 0.001f),
                        type = PartType.OffMeshLink
                    };
                }
                else throw new System.Exception("Unsupported node type or null node");
                result.Add(part);
                i = end;
            }
            if (result[0].type == PartType.OffMeshLink) result.RemoveAt(0);
            if (result[unchecked(result.Count - 1)].type == PartType.OffMeshLink) result.RemoveAt(unchecked(result.Count - 1));
            return result;
        }

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x45670C0", Offset = "0x45630C0", VA = "0x45670C0")]
		public static void Simplify(List<PathPart> parts, ref List<GraphNode> nodes, ref TraversalCosts traversalCosts, ref TraversalConstraint traversalConstraint)
		{
            List<GraphNode> result = Pathfinding.Pooling.ListPool<GraphNode>.Claim();
            for (int i = 0; i < parts.Count; i = unchecked(i + 1))
            {
                PathPart part = parts[i];
                int resultStart = result.Count;
                IRaycastableGraph graph;
                if (part.type == PartType.NodeSequence && (graph = nodes[part.startIndex].Graph as IRaycastableGraph) != null)
                {
                    Simplify(part, graph, nodes, result, ref traversalCosts, ref traversalConstraint);
                    parts[i] = new PathPart {
                        startIndex = resultStart,
                        endIndex = unchecked(result.Count - 1),
                        startPoint = part.startPoint,
                        endPoint = part.endPoint,
                        type = PartType.NodeSequence
                    };
                }
                else
                {
                    for (int j = part.startIndex; j <= part.endIndex; j = unchecked(j + 1)) result.Add(nodes[j]);
                    parts[i] = new PathPart {
                        startIndex = resultStart,
                        endIndex = unchecked(result.Count - 1),
                        startPoint = part.startPoint,
                        endPoint = part.endPoint,
                        type = part.type
                    };
                }
            }
            Pathfinding.Pooling.ListPool<GraphNode>.Release(ref nodes);
            nodes = result;
        }

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x45673D8", Offset = "0x45633D8", VA = "0x45673D8")]
		public static void Simplify(PathPart part, IRaycastableGraph graph, List<GraphNode> nodes, List<GraphNode> result, ref TraversalCosts traversalCosts, ref TraversalConstraint traversalConstraint)
		{
            [Token(Token = "0x6000AA0")]
            [Address(RVA = "0x4567F44", Offset = "0x4563F44", VA = "0x4567F44")]
            static bool PathTraversable(List<GraphNode> pathNodes, int firstIndex, int lastIndex, ref TraversalConstraint constraintContext)
            {
                for (int nodeIndex = firstIndex; nodeIndex <= lastIndex; nodeIndex = unchecked(nodeIndex + 1))
                {
                    if (nodeIndex == firstIndex)
                    {
                        if (!constraintContext.CanTraverse(pathNodes[firstIndex])) return false;
                    }
                    else
                    {
                        GraphNode previousNode = pathNodes[unchecked(nodeIndex - 1)];
                        GraphNode currentNode = pathNodes[nodeIndex];
                        if (!constraintContext.CanTraverse(previousNode, currentNode)) return false;
                    }
                }
                return true;
            }

            [Token(Token = "0x6000AA1")]
            [Address(RVA = "0x4567DE4", Offset = "0x4563DE4", VA = "0x4567DE4")]
            static void PathCost(List<GraphNode> pathNodes, int firstIndex, int lastIndex, ref TraversalCosts costContext, out long connectionCostSum, out float averageTraversalCost)
            {
                connectionCostSum = 0L;
                averageTraversalCost = 0f;
                long accumulatedConnectionCostLocal = 0L;
                float accumulatedAverageLocal = 0f;
                for (int nodeIndex = firstIndex; nodeIndex < lastIndex; nodeIndex = unchecked(nodeIndex + 1))
                {
                    GraphNode fromNode = pathNodes[nodeIndex];
                    GraphNode toNode = pathNodes[unchecked(nodeIndex + 1)];
                    connectionCostSum = unchecked(accumulatedConnectionCostLocal + (long)costContext.GetConnectionCost(fromNode, toNode));
                    accumulatedAverageLocal = averageTraversalCost;
                    GraphNode sampleNode = pathNodes[nodeIndex];
                    accumulatedAverageLocal += costContext.GetTraversalCostMultiplier(sampleNode);
                    averageTraversalCost = accumulatedAverageLocal;
                    accumulatedConnectionCostLocal = connectionCostSum;
                }
                GraphNode lastNode = pathNodes[lastIndex];
                averageTraversalCost = (accumulatedAverageLocal + costContext.GetTraversalCostMultiplier(lastNode)) / (float)unchecked(lastIndex - firstIndex + 1);
            }
            if (graph == null) throw new ArgumentNullException("graph");
            int startIndex = part.startIndex;
            int endIndex = part.endIndex;
            if (startIndex > endIndex) throw new ArgumentException("start > end");
            Vector3 startPoint = part.startPoint;
            Vector3 endPoint = part.endPoint;
            GraphHitInfo initialHit;
            GraphHitInfo searchHit;
            GraphHitInfo traceHit;
            if (!graph.Linecast(startPoint, endPoint, out initialHit) && initialHit.node == nodes[endIndex])
            {
                graph.Linecast(startPoint, endPoint, out initialHit, result);
                long originalConnectionCost;
                float originalAverageCost;
                PathCost(nodes, startIndex, endIndex, ref traversalCosts, out originalConnectionCost, out originalAverageCost);
                long shortcutConnectionCost;
                float shortcutAverageCost;
                PathCost(result, 0, unchecked(result.Count - 1), ref traversalCosts, out shortcutConnectionCost, out shortcutAverageCost);
                if (shortcutConnectionCost <= originalConnectionCost && !(shortcutAverageCost > originalAverageCost * 1.1f) &&
                    PathTraversable(result, 0, unchecked(result.Count - 1), ref traversalConstraint)) return;
                result.Clear();
            }
            int currentIndex = startIndex;
            for (int iteration = 1; ; iteration = unchecked(iteration + 1))
            {
                if (currentIndex == endIndex)
                {
                    GraphNode finalNode = nodes[endIndex];
                    result.Add(finalNode);
                    RemoveBacktracking(result, startIndex, unchecked(result.Count - 2));
                    return;
                }
                int nextIndex = unchecked(currentIndex + 1);
                int upper = unchecked(endIndex + 1);
                if (upper <= unchecked(currentIndex + 2))
                {
                    GraphNode currentNode = nodes[currentIndex];
                    result.Add(currentNode);
                    RemoveBacktracking(result, startIndex, unchecked(result.Count - 2));
                    currentIndex = nextIndex;
                }
                else
                {
                    int resultCountBeforeSearch = result.Count;
                    int lower = nextIndex;
                    int requiredUpper = unchecked(currentIndex + 2);
                    bool foundVisible = false;
                    while (true)
                    {
                        int middle = unchecked(upper + lower) / 2;
                        Vector3 fromPoint;
                        if (currentIndex == startIndex) fromPoint = startPoint;
                        else
                        {
                            Int3 position = nodes[currentIndex].position;
                            fromPoint = new Vector3((float)position.x * 0.001f, (float)position.y * 0.001f, (float)position.z * 0.001f);
                        }
                        Vector3 toPoint;
                        if (middle == endIndex) toPoint = endPoint;
                        else
                        {
                            Int3 position = nodes[middle].position;
                            toPoint = new Vector3((float)position.x * 0.001f, (float)position.y * 0.001f, (float)position.z * 0.001f);
                        }
                        bool blocked = graph.Linecast(fromPoint, toPoint, out searchHit);
                        if (!blocked && searchHit.node == nodes[middle])
                        {
                            foundVisible = true;
                            requiredUpper = unchecked(middle + 1);
                            lower = middle;
                            if (upper > requiredUpper) continue;
                            break;
                        }
                        upper = middle;
                        if (middle > requiredUpper) continue;
                        break;
                    }
                    if (!foundVisible)
                    {
                        GraphNode currentNode = nodes[currentIndex];
                        result.Add(currentNode);
                        RemoveBacktracking(result, startIndex, unchecked(result.Count - 2));
                        currentIndex = lower;
                    }
                    else
                    {
                        int visibleIndex = lower;
                        Vector3 fromPoint;
                        if (currentIndex == startIndex) fromPoint = startPoint;
                        else
                        {
                            Int3 position = nodes[currentIndex].position;
                            fromPoint = new Vector3((float)position.x * 0.001f, (float)position.y * 0.001f, (float)position.z * 0.001f);
                        }
                        Vector3 toPoint;
                        if (visibleIndex == endIndex) toPoint = endPoint;
                        else
                        {
                            Int3 position = nodes[visibleIndex].position;
                            toPoint = new Vector3((float)position.x * 0.001f, (float)position.y * 0.001f, (float)position.z * 0.001f);
                        }
                        graph.Linecast(fromPoint, toPoint, out traceHit, result);
                        long remainingConnectionCost;
                        float remainingAverageCost;
                        PathCost(nodes, currentIndex, endIndex, ref traversalCosts, out remainingConnectionCost, out remainingAverageCost);
                        long tracedConnectionCost;
                        float tracedAverageCost;
                        PathCost(result, 0, unchecked(result.Count - 1), ref traversalCosts, out tracedConnectionCost, out tracedAverageCost);
                        GraphNode tracedLastNode = result[unchecked(result.Count - 1)];
                        GraphNode targetNode = nodes[visibleIndex];
                        if (tracedLastNode == targetNode && tracedConnectionCost <= remainingConnectionCost &&
                            !(tracedAverageCost > remainingAverageCost * 1.1f) &&
                            PathTraversable(result, 0, unchecked(result.Count - 1), ref traversalConstraint))
                        {
                            RemoveBacktracking(result, startIndex, resultCountBeforeSearch);
                            result.RemoveAt(unchecked(result.Count - 1));
                            currentIndex = visibleIndex;
                        }
                        else
                        {
                            result.RemoveRange(resultCountBeforeSearch, unchecked(result.Count - resultCountBeforeSearch));
                            GraphNode currentNode = nodes[currentIndex];
                            result.Add(currentNode);
                            currentIndex = nextIndex;
                        }
                    }
                }
                if (iteration >= 1001)
                {
                    Debug.LogError("Was the path really long or have we got cought in an infinite loop?");
                    return;
                }
            }
        }

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x4568094", Offset = "0x4564094", VA = "0x4568094")]
		private static void RemoveBacktracking(List<GraphNode> nodes, int listStartIndex, int aroundIndex)
		{
            while (unchecked(aroundIndex - 1) > listStartIndex)
            {
                if (unchecked(aroundIndex + 1) >= nodes.Count) break;
                if (!ReferenceEquals(nodes[unchecked(aroundIndex - 1)], nodes[unchecked(aroundIndex + 1)])) break;
                nodes.RemoveRange(aroundIndex, 2);
                aroundIndex = unchecked(aroundIndex - 1);
            }
        }

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x456818C", Offset = "0x456418C", VA = "0x456818C")]
		public static FunnelPortals ConstructFunnelPortals(List<GraphNode> nodes, PathPart part)
		{
    // Token 0x6000A9A; original exact FDE [0x456818C, 0x45687E8).
    int nodeCount = nodes != null ? nodes.Count : 0;
    if (nodeCount == 0)
    {
        return new FunnelPortals
        {
            left = Pathfinding.Pooling.ListPool<Vector3>.Claim(0),
            right = Pathfinding.Pooling.ListPool<Vector3>.Claim(0)
        };
    }

    if (part.endIndex > nodeCount || part.endIndex < part.startIndex || part.startIndex < 0)
        throw new ArgumentOutOfRangeException();

    var left = Pathfinding.Pooling.ListPool<Vector3>.Claim(unchecked(nodeCount + 1));
    var right = Pathfinding.Pooling.ListPool<Vector3>.Claim(unchecked(nodes.Count + 1));
    left.Add(part.startPoint);
    right.Add(part.startPoint);

    Vector3 leftPortal = default(Vector3);
    Vector3 rightPortal = default(Vector3);
    for (int i = part.startIndex; i < part.endIndex; i = unchecked(i + 1))
    {
        if (nodes[i].GetPortal(nodes[unchecked(i + 1)], out leftPortal, out rightPortal))
        {
            left.Add(leftPortal);
            right.Add(rightPortal);
        }
        else
        {
            // Original SCVTF + FMUL at 0x4568474 et seq.; do not consume
            // the currently empty Int3.op_Explicit(Vector3) Token 0x60003B6.
            Int3 position = nodes[i].position;
            left.Add(new Vector3((float)position.x * 0.001f, (float)position.y * 0.001f, (float)position.z * 0.001f));
            position = nodes[i].position;
            right.Add(new Vector3((float)position.x * 0.001f, (float)position.y * 0.001f, (float)position.z * 0.001f));
            position = nodes[unchecked(i + 1)].position;
            left.Add(new Vector3((float)position.x * 0.001f, (float)position.y * 0.001f, (float)position.z * 0.001f));
            position = nodes[unchecked(i + 1)].position;
            right.Add(new Vector3((float)position.x * 0.001f, (float)position.y * 0.001f, (float)position.z * 0.001f));
        }
    }

    left.Add(part.endPoint);
    right.Add(part.endPoint);
    return new FunnelPortals { left = left, right = right };
}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x45687E8", Offset = "0x45647E8", VA = "0x45687E8")]
		private static float2 Unwrap(float3 leftPortal, float3 rightPortal, float2 leftUnwrappedPortal, float2 rightUnwrappedPortal, float3 point, float sideMultiplier, float3 projectionAxis)
		{
            // Original ARM64 0x45687E8: projection, reciprocal-infinity degeneracy, 0.002f endpoint snaps.
            if (projectionAxis.x != 0f || projectionAxis.y != 0f || projectionAxis.z != 0f)
            {
                float l = leftPortal.z * projectionAxis.z + (leftPortal.x * projectionAxis.x + leftPortal.y * projectionAxis.y);
                float r = rightPortal.z * projectionAxis.z + (rightPortal.x * projectionAxis.x + rightPortal.y * projectionAxis.y);
                float p = point.z * projectionAxis.z + (point.x * projectionAxis.x + point.y * projectionAxis.y);
                leftPortal = new float3(leftPortal.x - projectionAxis.x * l, leftPortal.y - projectionAxis.y * l, leftPortal.z - projectionAxis.z * l);
                rightPortal = new float3(rightPortal.x - projectionAxis.x * r, rightPortal.y - projectionAxis.y * r, rightPortal.z - projectionAxis.z * r);
                point = new float3(point.x - projectionAxis.x * p, point.y - projectionAxis.y * p, point.z - projectionAxis.z * p);
            }
            float dx = rightPortal.x - leftPortal.x;
            float dy = rightPortal.y - leftPortal.y;
            float dz = rightPortal.z - leftPortal.z;
            float px = point.x - leftPortal.x;
            float py = point.y - leftPortal.y;
            float pz = point.z - leftPortal.z;
            float invLengthSq = 1f / (dz * dz + (dx * dx + dy * dy));
            if (invLengthSq == float.PositiveInfinity)
            {
                float distance = (float)System.Math.Sqrt(pz * pz + (px * px + py * py));
                return new float2(leftUnwrappedPortal.x - distance, leftUnwrappedPortal.y + 0f);
            }
            float crossZ = px * dy - dx * py;
            float crossX = py * dz - dy * pz;
            float crossY = dx * pz - px * dz;
            float distanceFromLine = invLengthSq * (float)System.Math.Sqrt(crossZ * crossZ + (crossX * crossX + crossY * crossY));
            float along = (pz * dz + (px * dx + py * dy)) * invLengthSq;
            if (distanceFromLine < 0.002f)
            {
                if (System.Math.Abs(along) < 0.002f) return leftUnwrappedPortal;
                if (System.Math.Abs(along - 1f) < 0.002f) return rightUnwrappedPortal;
            }
            float ux = rightUnwrappedPortal.x - leftUnwrappedPortal.x;
            float uy = rightUnwrappedPortal.y - leftUnwrappedPortal.y;
            float perpendicular = distanceFromLine * sideMultiplier;
            return new float2(leftUnwrappedPortal.x + (ux * along - uy * perpendicular), leftUnwrappedPortal.y + (uy * along + ux * perpendicular));
        }

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x4568ACC", Offset = "0x4564ACC", VA = "0x4568ACC")]
		private static bool RightOrColinear(Vector2 a, Vector2 b)
		{
            return a.x * b.y - a.y * b.x <= 0f;
        }

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x4568AE4", Offset = "0x4564AE4", VA = "0x4568AE4")]
		private static bool LeftOrColinear(Vector2 a, Vector2 b)
		{
            return a.x * b.y - a.y * b.x >= 0f;
        }

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x4568AFC", Offset = "0x4564AFC", VA = "0x4568AFC")]
		public static List<Vector3> Calculate(FunnelPortals funnel, bool splitAtEveryPortal)
		{
            var state = new FunnelState(funnel, Allocator.Temp);
            float3 startPoint = state.leftFunnel.First;
            float3 endPoint = state.leftFunnel.Last;
            state.PopStart();
            state.PopEnd();
            var corners = new NativeList<float3>(Allocator.Temp);
            state.CalculateNextCorners(int.MaxValue, splitAtEveryPortal, startPoint, endPoint, corners);
            state.Dispose();
            var result = Pathfinding.Pooling.ListPool<Vector3>.Claim(corners.Length);
            for (int i = 0; i < corners.Length; i = unchecked(i + 1))
                result.Add((Vector3)corners[i]);
            corners.Dispose();
            return result;
        }

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x4569218", Offset = "0x4565218", VA = "0x4569218")]
		[BurstCompile]
		private static int Calculate(ref NativeCircularBuffer<float4> unwrappedPortals, ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref float3 startPoint, ref float3 endPoint, ref UnsafeSpan<int> funnelPath, int maxCorners, ref float3 projectionAxis, out bool lastCorner)
		{
            return Calculate_00000A26_0024BurstDirectCall.Invoke(ref unwrappedPortals, ref leftPortals, ref rightPortals, ref startPoint, ref endPoint, ref funnelPath, maxCorners, ref projectionAxis, out lastCorner);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x45693FC", Offset = "0x45653FC", VA = "0x45693FC")]
		[BurstCompile]
		public static int Calculate_0024BurstManaged(ref NativeCircularBuffer<float4> unwrappedPortals, ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref float3 startPoint, ref float3 endPoint, ref UnsafeSpan<int> funnelPath, int maxCorners, ref float3 projectionAxis, out bool lastCorner)
		{
    lastCorner = false;
    if (leftPortals.Length <= 0) {
        lastCorner = true;
        return 0;
    }
    if (maxCorners < 1) return 0;

    if (unwrappedPortals.Length == 0) {
        float3 delta = rightPortals[0] - leftPortals[0];
        float d = (float)System.Math.Sqrt(delta.z * delta.z +
                            (delta.x * delta.x + delta.y * delta.y));
        unwrappedPortals.PushEnd(new float4(0f, 0f, d, d));
    }

    float2 apex = Unwrap(leftPortals[0], rightPortals[0],
        unwrappedPortals[0].xy, unwrappedPortals[0].zw,
        startPoint, -1f, projectionAxis);
    float2 left = float2.zero;
    float2 right = float2.zero;
    int leftIndex = 0, rightIndex = 0, count = 0;

    for (int i = 0; i <= leftPortals.Length; ++i) {
        float2 currentLeft, currentRight;
        if (i == unwrappedPortals.Length) {
            float4 previous = unwrappedPortals[i - 1];
            if (i == leftPortals.Length) {
                float2 end = Unwrap(leftPortals[i - 1], rightPortals[i - 1],
                    previous.xy, previous.zw, endPoint, +1f, projectionAxis);
                currentLeft = currentRight = end - apex;
            } else {
                float2 newLeft = Unwrap(leftPortals[i - 1], rightPortals[i - 1],
                    previous.xy, previous.zw, leftPortals[i], +1f, projectionAxis);
                float2 newRight = Unwrap(leftPortals[i], rightPortals[i - 1],
                    newLeft, previous.zw, rightPortals[i], +1f, projectionAxis);
                unwrappedPortals.PushEnd(new float4(newLeft, newRight));
                currentLeft = newLeft - apex;
                currentRight = newRight - apex;
            }
        } else {
            float4 portal = unwrappedPortals[i];
            currentLeft = portal.xy - apex;
            currentRight = portal.zw - apex;
        }

        if (LeftOrColinear(right, currentRight)) {
            right = currentRight;
            rightIndex = i;
            if (!RightOrColinear(left, currentRight)) {
                // Preserve check before apex/cache access, as in 0x45699D8.
                if ((uint)count >= (uint)funnelPath.Length)
                    throw new System.IndexOutOfRangeException();
                apex = unwrappedPortals[leftIndex].xy;
                left = right = float2.zero;
                funnelPath[count++] = leftIndex;
                i = rightIndex = leftIndex;
                if (count >= maxCorners) return count;
                continue;
            }
        }
        if (RightOrColinear(left, currentLeft)) {
            if (LeftOrColinear(right, currentLeft)) {
                left = currentLeft;
                leftIndex = i;
            } else {
                // Preserve check before apex/cache access, as in 0x4569AC8.
                if ((uint)count >= (uint)funnelPath.Length)
                    throw new System.IndexOutOfRangeException();
                apex = unwrappedPortals[rightIndex].zw;
                left = right = float2.zero;
                funnelPath[count++] = rightIndex | 0x40000000;
                i = leftIndex = rightIndex;
                if (count >= maxCorners) return count;
            }
        }
    }
    lastCorner = true;
    return count;
}
	}
}
