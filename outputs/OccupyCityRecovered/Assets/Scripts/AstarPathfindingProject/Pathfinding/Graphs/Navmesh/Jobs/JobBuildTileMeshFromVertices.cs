using Il2CppDummyDll;
using Pathfinding.Sync;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh.Jobs
{
	[Token(Token = "0x20001F4")]
	[BurstCompile(FloatMode = FloatMode.Default)]
	public struct JobBuildTileMeshFromVertices : IJob
	{
		[Token(Token = "0x20001F5")]
		[BurstCompile(FloatMode = FloatMode.Fast)]
		public struct JobTransformTileCoordinates : IJob
		{
			[Token(Token = "0x4000944")]
			[FieldOffset(Offset = "0x0")]
			public NativeArray<Vector3> vertices;

			[Token(Token = "0x4000945")]
			[FieldOffset(Offset = "0x10")]
			public NativeArray<Int3> outputVertices;

			[Token(Token = "0x4000946")]
			[FieldOffset(Offset = "0x20")]
			public Matrix4x4 matrix;

			[Token(Token = "0x6000D77")]
			[Address(RVA = "0x446FDF8", Offset = "0x446BDF8", VA = "0x446FDF8", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x400093F")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<Vector3> vertices;

		[Token(Token = "0x4000940")]
		[FieldOffset(Offset = "0x10")]
		public NativeArray<int> indices;

		[Token(Token = "0x4000941")]
		[FieldOffset(Offset = "0x20")]
		public Matrix4x4 meshToGraph;

		[Token(Token = "0x4000942")]
		[FieldOffset(Offset = "0x60")]
		public NativeArray<TileMesh.TileMeshUnsafe> outputBuffers;

		[Token(Token = "0x4000943")]
		[FieldOffset(Offset = "0x70")]
		public bool recalculateNormals;

		[Token(Token = "0x6000D75")]
		[Address(RVA = "0x446F734", Offset = "0x446B734", VA = "0x446F734")]
		public static Promise<TileBuilder.TileBuilderOutput> Schedule(NativeArray<Vector3> vertices, NativeArray<int> indices, Matrix4x4 meshToGraph, bool recalculateNormals)
		{
			return default;
		}

		[Token(Token = "0x6000D76")]
		[Address(RVA = "0x446FA38", Offset = "0x446BA38", VA = "0x446FA38", Slot = "4")]
		public void Execute()
		{
		}
	}
}
