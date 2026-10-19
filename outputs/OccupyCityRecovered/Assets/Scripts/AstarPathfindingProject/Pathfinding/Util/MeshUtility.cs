using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Util
{
	[Token(Token = "0x20002A6")]
	[BurstCompile]
	internal static class MeshUtility
	{
		[Token(Token = "0x20002A7")]
		[BurstCompile]
		public struct JobMergeNearbyVertices : IJob
		{
			[Token(Token = "0x20002A8")]
			private struct CoordinateSorter : IComparer<int>
			{
				[Token(Token = "0x4000C13")]
				[FieldOffset(Offset = "0x0")]
				public UnsafeSpan<int3> vertices;

				[Token(Token = "0x60010E0")]
				[Address(RVA = "0x4499F8C", Offset = "0x4495F8C", VA = "0x4499F8C", Slot = "4")]
				public int Compare(int a, int b)
				{
					return default;
				}
			}

			[Token(Token = "0x4000C10")]
			[FieldOffset(Offset = "0x0")]
			public NativeList<Int3> vertices;

			[Token(Token = "0x4000C11")]
			[FieldOffset(Offset = "0x8")]
			public NativeList<int> triangles;

			[Token(Token = "0x4000C12")]
			[FieldOffset(Offset = "0x10")]
			public int mergeRadiusSq;

			[Token(Token = "0x60010DF")]
			[Address(RVA = "0x4499664", Offset = "0x4495664", VA = "0x4499664", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x20002A9")]
		[BurstCompile]
		public struct JobRemoveDegenerateTriangles : IJob
		{
			[Token(Token = "0x4000C14")]
			[FieldOffset(Offset = "0x0")]
			public NativeList<Int3> vertices;

			[Token(Token = "0x4000C15")]
			[FieldOffset(Offset = "0x8")]
			public NativeList<int> triangles;

			[Token(Token = "0x4000C16")]
			[FieldOffset(Offset = "0x10")]
			public NativeList<int> tags;

			[Token(Token = "0x4000C17")]
			[FieldOffset(Offset = "0x18")]
			public bool verbose;

			[Token(Token = "0x60010E1")]
			[Address(RVA = "0x449A08C", Offset = "0x449608C", VA = "0x449A08C")]
			public static int3 cross(int3 lhs, int3 rhs)
			{
				return default;
			}

			[Token(Token = "0x60010E2")]
			[Address(RVA = "0x449A0C8", Offset = "0x44960C8", VA = "0x449A0C8", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x20002AA")]
		public delegate void MakeTrianglesClockwise_00000F9D_0024PostfixBurstDelegate(ref UnsafeSpan<Int3> vertices, ref UnsafeSpan<int> triangles);

		[Token(Token = "0x20002AB")]
		internal static class MakeTrianglesClockwise_00000F9D_0024BurstDirectCall
		{
			[Token(Token = "0x4000C18")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000C19")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x60010E7")]
			[Address(RVA = "0x449A804", Offset = "0x4496804", VA = "0x449A804")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x60010E8")]
			[Address(RVA = "0x449A920", Offset = "0x4496920", VA = "0x449A920")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x60010E9")]
			[Address(RVA = "0x449A97C", Offset = "0x449697C", VA = "0x449A97C")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x60010EA")]
			[Address(RVA = "0x449AA24", Offset = "0x4496A24", VA = "0x449AA24")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x60010EC")]
			[Address(RVA = "0x44992D8", Offset = "0x44952D8", VA = "0x44992D8")]
			public static void Invoke(ref UnsafeSpan<Int3> vertices, ref UnsafeSpan<int> triangles)
			{
			}
		}

		[Token(Token = "0x60010DC")]
		[Address(RVA = "0x4499094", Offset = "0x4495094", VA = "0x4499094")]
		public static void GetMeshData(Mesh.MeshDataArray meshData, int meshIndex, out NativeArray<Vector3> vertices, out NativeArray<int> indices)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshUtility.GetMeshData RVA=0x4499094 Token=0x60010DC");
}

		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x4499274", Offset = "0x4495274", VA = "0x4499274")]
		[BurstCompile]
		public static void MakeTrianglesClockwise(ref UnsafeSpan<Int3> vertices, ref UnsafeSpan<int> triangles)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60010DE")]
		[Address(RVA = "0x4499394", Offset = "0x4495394", VA = "0x4499394")]
		[BurstCompile]
		public static void MakeTrianglesClockwise_0024BurstManaged(ref UnsafeSpan<Int3> vertices, ref UnsafeSpan<int> triangles)
		{
		}
	}
}
