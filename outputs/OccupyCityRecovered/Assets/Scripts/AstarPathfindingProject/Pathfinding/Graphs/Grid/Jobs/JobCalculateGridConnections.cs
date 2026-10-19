using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Jobs;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x2000225")]
	[BurstCompile(FloatMode = FloatMode.Fast, CompileSynchronously = true)]
	public struct JobCalculateGridConnections : IJobParallelForBatched
	{
		[Token(Token = "0x4000A22")]
		[FieldOffset(Offset = "0x0")]
		public float maxStepHeight;

		[Token(Token = "0x4000A23")]
		[FieldOffset(Offset = "0x4")]
		public float4x4 graphToWorld;

		[Token(Token = "0x4000A24")]
		[FieldOffset(Offset = "0x44")]
		public IntBounds bounds;

		[Token(Token = "0x4000A25")]
		[FieldOffset(Offset = "0x5C")]
		public int3 arrayBounds;

		[Token(Token = "0x4000A26")]
		[FieldOffset(Offset = "0x68")]
		public NumNeighbours neighbours;

		[Token(Token = "0x4000A27")]
		[FieldOffset(Offset = "0x6C")]
		public float characterHeight;

		[Token(Token = "0x4000A28")]
		[FieldOffset(Offset = "0x70")]
		public bool use2D;

		[Token(Token = "0x4000A29")]
		[FieldOffset(Offset = "0x71")]
		public bool cutCorners;

		[Token(Token = "0x4000A2A")]
		[FieldOffset(Offset = "0x72")]
		public bool maxStepUsesSlope;

		[Token(Token = "0x4000A2B")]
		[FieldOffset(Offset = "0x73")]
		public bool layeredDataLayout;

		[Token(Token = "0x4000A2C")]
		[FieldOffset(Offset = "0x78")]
		[ReadOnly]
		public UnsafeSpan<bool> nodeWalkable;

		[Token(Token = "0x4000A2D")]
		[FieldOffset(Offset = "0x88")]
		[ReadOnly]
		public UnsafeSpan<float4> nodeNormals;

		[Token(Token = "0x4000A2E")]
		[FieldOffset(Offset = "0x98")]
		[ReadOnly]
		public UnsafeSpan<Vector3> nodePositions;

		[Token(Token = "0x4000A2F")]
		[FieldOffset(Offset = "0xA8")]
		[WriteOnly]
		public UnsafeSpan<ulong> nodeConnections;

		[Token(Token = "0x1700021E")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x6000DFF")]
			[Address(RVA = "0x447A364", Offset = "0x4476364", VA = "0x447A364", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000E00")]
		[Address(RVA = "0x447A36C", Offset = "0x447636C", VA = "0x447A36C")]
		public static bool IsValidConnection(float y, float y2, float maxStepHeight)
		{
			return default;
		}

		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x447A37C", Offset = "0x447637C", VA = "0x447A37C")]
		public static bool IsValidConnection(float2 yRange, float2 yRange2, float maxStepHeight, float characterHeight)
		{
			return default;
		}

		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x447A404", Offset = "0x4476404", VA = "0x447A404")]
		private static float ConnectionY(UnsafeSpan<float3> nodePositions, UnsafeSpan<float4> nodeNormals, NativeArray<float4> normalToHeightOffset, int nodeIndex, int dir, float4 up, bool reverse)
		{
			return default;
		}

		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x447A5F0", Offset = "0x44765F0", VA = "0x447A5F0")]
		private static float2 ConnectionYRange(UnsafeSpan<float3> nodePositions, UnsafeSpan<float4> nodeNormals, NativeArray<float4> normalToHeightOffset, int nodeIndex, int layerStride, int y, int maxY, int dir, float4 up, bool reverse)
		{
			return default;
		}

		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x447A78C", Offset = "0x447678C", VA = "0x447A78C")]
		private static NativeArray<float4> HeightOffsetProjections(float4x4 graphToWorldTranform, bool maxStepUsesSlope)
		{
			return default;
		}

		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x447A8F8", Offset = "0x44768F8", VA = "0x447A8F8", Slot = "5")]
		public void Execute(int start, int count)
		{
		}

		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x447AF20", Offset = "0x4476F20", VA = "0x447AF20")]
		public void ExecuteFlat(int start, int count)
		{
		}

		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x447AA44", Offset = "0x4476A44", VA = "0x447AA44")]
		public void ExecuteLayered(int start, int count)
		{
		}
	}
}
