using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh
{
	[Token(Token = "0x20001A4")]
	[BurstCompile]
	internal static class ColliderMeshBuilder2D
	{
		[Token(Token = "0x20001A5")]
		public struct ShapeMesh
		{
			[Token(Token = "0x40007FB")]
			[FieldOffset(Offset = "0x0")]
			public Matrix4x4 matrix;

			[Token(Token = "0x40007FC")]
			[FieldOffset(Offset = "0x40")]
			public Bounds bounds;

			[Token(Token = "0x40007FD")]
			[FieldOffset(Offset = "0x58")]
			public int startIndex;

			[Token(Token = "0x40007FE")]
			[FieldOffset(Offset = "0x5C")]
			public int endIndex;

			[Token(Token = "0x40007FF")]
			[FieldOffset(Offset = "0x60")]
			public int tag;
		}

		[Token(Token = "0x20001A6")]
		public delegate int GenerateMeshesFromShapes_00000B65_0024PostfixBurstDelegate(ref UnsafeSpan<PhysicsShape2D> shapes, ref UnsafeSpan<float2> vertices, ref UnsafeSpan<Matrix4x4> shapeMatrices, ref UnsafeSpan<int> groupIndices, ref UnsafeList<float3> outputVertices, ref UnsafeList<int3> outputIndices, ref UnsafeSpan<ShapeMesh> outputShapeMeshes, float maxError);

		[Token(Token = "0x20001A7")]
		internal static class GenerateMeshesFromShapes_00000B65_0024BurstDirectCall
		{
			[Token(Token = "0x4000800")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000801")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6000C26")]
			[Address(RVA = "0x4587F1C", Offset = "0x4583F1C", VA = "0x4587F1C")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6000C27")]
			[Address(RVA = "0x4588038", Offset = "0x4584038", VA = "0x4588038")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6000C28")]
			[Address(RVA = "0x4588094", Offset = "0x4584094", VA = "0x4588094")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6000C29")]
			[Address(RVA = "0x458813C", Offset = "0x458413C", VA = "0x458813C")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000C2B")]
			[Address(RVA = "0x4586BD8", Offset = "0x4582BD8", VA = "0x4586BD8")]
			public static int Invoke(ref UnsafeSpan<PhysicsShape2D> shapes, ref UnsafeSpan<float2> vertices, ref UnsafeSpan<Matrix4x4> shapeMatrices, ref UnsafeSpan<int> groupIndices, ref UnsafeList<float3> outputVertices, ref UnsafeList<int3> outputIndices, ref UnsafeSpan<ShapeMesh> outputShapeMeshes, float maxError)
			{
				return default;
			}
		}

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x4585A20", Offset = "0x4581A20", VA = "0x4585A20")]
		private static int GetShapes(Collider2D coll, PhysicsShapeGroup2D group, HashSet<Rigidbody2D> handledRigidbodies)
		{
			return default;
		}

		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x4585B4C", Offset = "0x4581B4C", VA = "0x4585B4C")]
		public static int GenerateMeshesFromColliders(Collider2D[] colliders, int numColliders, float maxError, out UnsafeSpan<float3> outputVertices, out UnsafeSpan<int> outputIndices, out UnsafeSpan<ShapeMesh> outputShapeMeshes)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ColliderMeshBuilder2D.GenerateMeshesFromColliders RVA=0x4585B4C Token=0x6000C1E");
}

		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x4586514", Offset = "0x4582514", VA = "0x4586514")]
		private static void AddCapsuleMesh(float2 c1, float2 c2, ref Matrix4x4 shapeMatrix, float radius, float maxError, ref UnsafeList<float3> outputVertices, ref UnsafeList<int3> outputIndices, ref float3 mn, ref float3 mx)
		{
		}

		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x4586468", Offset = "0x4582468", VA = "0x4586468")]
		[BurstCompile]
		public static int GenerateMeshesFromShapes(ref UnsafeSpan<PhysicsShape2D> shapes, ref UnsafeSpan<float2> vertices, ref UnsafeSpan<Matrix4x4> shapeMatrices, ref UnsafeSpan<int> groupIndices, ref UnsafeList<float3> outputVertices, ref UnsafeList<int3> outputIndices, ref UnsafeSpan<ShapeMesh> outputShapeMeshes, float maxError)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x4586D00", Offset = "0x4582D00", VA = "0x4586D00")]
		[BurstCompile]
		public static int GenerateMeshesFromShapes_0024BurstManaged(ref UnsafeSpan<PhysicsShape2D> shapes, ref UnsafeSpan<float2> vertices, ref UnsafeSpan<Matrix4x4> shapeMatrices, ref UnsafeSpan<int> groupIndices, ref UnsafeList<float3> outputVertices, ref UnsafeList<int3> outputIndices, ref UnsafeSpan<ShapeMesh> outputShapeMeshes, float maxError)
		{
			return default;
		}
	}
}
