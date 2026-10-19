using Il2CppDummyDll;
using Pathfinding.Drawing;
using Pathfinding.ECS.RVO;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002D2")]
	public struct RVOQuadtreeBurst
	{
		[Token(Token = "0x20002D3")]
		[BurstCompile(CompileSynchronously = true, FloatMode = FloatMode.Fast)]
		public struct JobBuild : IJob
		{
			[Token(Token = "0x4000D00")]
			[FieldOffset(Offset = "0x0")]
			public NativeArray<int> agents;

			[Token(Token = "0x4000D01")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float3> agentPositions;

			[Token(Token = "0x4000D02")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<AgentIndex> agentVersions;

			[Token(Token = "0x4000D03")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float> agentSpeeds;

			[Token(Token = "0x4000D04")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float> agentRadii;

			[Token(Token = "0x4000D05")]
			[FieldOffset(Offset = "0x50")]
			[WriteOnly]
			public NativeArray<float3> outBoundingBox;

			[Token(Token = "0x4000D06")]
			[FieldOffset(Offset = "0x60")]
			[WriteOnly]
			public NativeArray<int> outAgentCount;

			[Token(Token = "0x4000D07")]
			[FieldOffset(Offset = "0x70")]
			public NativeArray<int> outChildPointers;

			[Token(Token = "0x4000D08")]
			[FieldOffset(Offset = "0x80")]
			public NativeArray<float> outMaxSpeeds;

			[Token(Token = "0x4000D09")]
			[FieldOffset(Offset = "0x90")]
			public NativeArray<float> outMaxRadius;

			[Token(Token = "0x4000D0A")]
			[FieldOffset(Offset = "0xA0")]
			public NativeArray<float> outArea;

			[Token(Token = "0x4000D0B")]
			[FieldOffset(Offset = "0xB0")]
			[WriteOnly]
			public NativeArray<float3> outAgentPositions;

			[Token(Token = "0x4000D0C")]
			[FieldOffset(Offset = "0xC0")]
			[WriteOnly]
			public NativeArray<float> outAgentRadii;

			[Token(Token = "0x4000D0D")]
			[FieldOffset(Offset = "0xD0")]
			public int numAgents;

			[Token(Token = "0x4000D0E")]
			[FieldOffset(Offset = "0xD4")]
			public MovementPlane movementPlane;

			[Token(Token = "0x60011D4")]
			[Address(RVA = "0x44A3BD0", Offset = "0x449FBD0", VA = "0x44A3BD0")]
			private static int Partition(NativeSlice<int> indices, int startIndex, int endIndex, NativeSlice<float> coordinates, float splitPoint)
			{
				return default;
			}

			[Token(Token = "0x60011D5")]
			[Address(RVA = "0x44A3CFC", Offset = "0x449FCFC", VA = "0x44A3CFC")]
			private void BuildNode(float3 boundsMin, float3 boundsMax, int depth, int agentsStart, int agentsEnd, int nodeOffset, ref int firstFreeChild)
			{
			}

			[Token(Token = "0x60011D6")]
			[Address(RVA = "0x44A45C4", Offset = "0x44A05C4", VA = "0x44A45C4")]
			private void CalculateSpeeds(int nodeCount)
			{
			}

			[Token(Token = "0x60011D7")]
			[Address(RVA = "0x44A483C", Offset = "0x44A083C", VA = "0x44A483C", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x20002D4")]
		public struct QuadtreeQuery
		{
			[Token(Token = "0x4000D0F")]
			[FieldOffset(Offset = "0x0")]
			public float3 position;

			[Token(Token = "0x4000D10")]
			[FieldOffset(Offset = "0xC")]
			public float speed;

			[Token(Token = "0x4000D11")]
			[FieldOffset(Offset = "0x10")]
			public float timeHorizon;

			[Token(Token = "0x4000D12")]
			[FieldOffset(Offset = "0x14")]
			public float agentRadius;

			[Token(Token = "0x4000D13")]
			[FieldOffset(Offset = "0x18")]
			public int outputStartIndex;

			[Token(Token = "0x4000D14")]
			[FieldOffset(Offset = "0x1C")]
			public int maxCount;

			[Token(Token = "0x4000D15")]
			[FieldOffset(Offset = "0x20")]
			public RVOLayer layerMask;

			[Token(Token = "0x4000D16")]
			[FieldOffset(Offset = "0x28")]
			public NativeArray<RVOLayer> layers;

			[Token(Token = "0x4000D17")]
			[FieldOffset(Offset = "0x38")]
			public NativeArray<int> result;

			[Token(Token = "0x4000D18")]
			[FieldOffset(Offset = "0x48")]
			public NativeArray<float> resultDistances;
		}

		[Token(Token = "0x20002D5")]
		[BurstCompile]
		public struct DebugDrawJob : IJob
		{
			[Token(Token = "0x4000D19")]
			[FieldOffset(Offset = "0x0")]
			public CommandBuilder draw;

			[Token(Token = "0x4000D1A")]
			[FieldOffset(Offset = "0x18")]
			[ReadOnly]
			public RVOQuadtreeBurst quadtree;

			[Token(Token = "0x60011D8")]
			[Address(RVA = "0x44A4AE4", Offset = "0x44A0AE4", VA = "0x44A4AE4", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x4000CEE")]
		private const int LeafSize = 16;

		[Token(Token = "0x4000CEF")]
		private const int MaxDepth = 10;

		[Token(Token = "0x4000CF0")]
		[FieldOffset(Offset = "0x0")]
		private NativeArray<int> agents;

		[Token(Token = "0x4000CF1")]
		[FieldOffset(Offset = "0x10")]
		private NativeArray<int> childPointers;

		[Token(Token = "0x4000CF2")]
		[FieldOffset(Offset = "0x20")]
		private NativeArray<float3> boundingBoxBuffer;

		[Token(Token = "0x4000CF3")]
		[FieldOffset(Offset = "0x30")]
		private NativeArray<int> agentCountBuffer;

		[Token(Token = "0x4000CF4")]
		[FieldOffset(Offset = "0x40")]
		private NativeArray<float3> agentPositions;

		[Token(Token = "0x4000CF5")]
		[FieldOffset(Offset = "0x50")]
		private NativeArray<float> agentRadii;

		[Token(Token = "0x4000CF6")]
		[FieldOffset(Offset = "0x60")]
		private NativeArray<float> maxSpeeds;

		[Token(Token = "0x4000CF7")]
		[FieldOffset(Offset = "0x70")]
		private NativeArray<float> maxRadius;

		[Token(Token = "0x4000CF8")]
		[FieldOffset(Offset = "0x80")]
		private NativeArray<float> nodeAreas;

		[Token(Token = "0x4000CF9")]
		[FieldOffset(Offset = "0x90")]
		private MovementPlane movementPlane;

		[Token(Token = "0x4000CFA")]
		private const int LeafNodeBit = 1073741824;

		[Token(Token = "0x4000CFB")]
		private const int BitPackingShift = 15;

		[Token(Token = "0x4000CFC")]
		private const int BitPackingMask = 32767;

		[Token(Token = "0x4000CFD")]
		private const int MaxAgents = 32767;

		[Token(Token = "0x4000CFE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] ChildLookup;

		[Token(Token = "0x4000CFF")]
		private const float DistanceInfinity = 1E+30f;

		[Token(Token = "0x170002B5")]
		public Rect bounds
		{
			[Token(Token = "0x60011C9")]
			[Address(RVA = "0x44A18E0", Offset = "0x449D8E0", VA = "0x44A18E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60011C8")]
		[Address(RVA = "0x44A1820", Offset = "0x449D820", VA = "0x44A1820")]
		static RVOQuadtreeBurst()
		{
		}

		[Token(Token = "0x60011CA")]
		[Address(RVA = "0x44A1944", Offset = "0x449D944", VA = "0x44A1944")]
		private static int InnerNodeCountUpperBound(int numAgents, MovementPlane movementPlane)
		{
			return default;
		}

		[Token(Token = "0x60011CB")]
		[Address(RVA = "0x44A1970", Offset = "0x449D970", VA = "0x44A1970")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60011CC")]
		[Address(RVA = "0x44A1A48", Offset = "0x449DA48", VA = "0x44A1A48")]
		private void Reserve(int minSize)
		{
		}

		[Token(Token = "0x60011CD")]
		[Address(RVA = "0x44A1C64", Offset = "0x449DC64", VA = "0x44A1C64")]
		public JobBuild BuildJob(NativeArray<float3> agentPositions, NativeArray<AgentIndex> agentVersions, NativeArray<float> agentSpeeds, NativeArray<float> agentRadii, int numAgents, MovementPlane movementPlane)
		{
			return default;
		}

		[Token(Token = "0x60011CE")]
		[Address(RVA = "0x44A1DD8", Offset = "0x449DDD8", VA = "0x44A1DD8")]
		public int QueryKNearest(QuadtreeQuery query)
		{
			return default;
		}

		[Token(Token = "0x60011CF")]
		[Address(RVA = "0x44A1F44", Offset = "0x449DF44", VA = "0x44A1F44")]
		private void QueryRec(ref QuadtreeQuery query, int treeNodeIndex, float3 nodeMin, float3 nodeMax, ref float maxRadius)
		{
		}

		[Token(Token = "0x60011D0")]
		[Address(RVA = "0x44A2754", Offset = "0x449E754", VA = "0x44A2754")]
		public float QueryArea(float3 position, float radius)
		{
			return default;
		}

		[Token(Token = "0x60011D1")]
		[Address(RVA = "0x44A284C", Offset = "0x449E84C", VA = "0x44A284C")]
		private float QueryAreaRec(int treeNodeIndex, float3 p, float radius, float3 nodeMin, float3 nodeMax)
		{
			return default;
		}

		[Token(Token = "0x60011D2")]
		[Address(RVA = "0x44A33B4", Offset = "0x449F3B4", VA = "0x44A33B4")]
		public void DebugDraw(CommandBuilder draw)
		{
		}

		[Token(Token = "0x60011D3")]
		[Address(RVA = "0x44A3574", Offset = "0x449F574", VA = "0x44A3574")]
		private void DebugDraw(int nodeIndex, float3 nodeMin, float3 nodeMax, CommandBuilder draw)
		{
		}
	}
}
