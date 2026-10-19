using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Collections;
using UnityEngine;

namespace Pathfinding.Graphs.Util
{
	[Serializable]
	[Token(Token = "0x200019D")]
	public class EuclideanEmbedding
	{
		[Token(Token = "0x200019E")]
		private class EuclideanEmbeddingSearchPath : Path
		{
			[Token(Token = "0x40007E7")]
			[FieldOffset(Offset = "0xB0")]
			public UnsafeSpan<uint> costs;

			[Token(Token = "0x40007E8")]
			[FieldOffset(Offset = "0xC0")]
			public uint costIndexStride;

			[Token(Token = "0x40007E9")]
			[FieldOffset(Offset = "0xC4")]
			public uint pivotIndex;

			[Token(Token = "0x40007EA")]
			[FieldOffset(Offset = "0xC8")]
			public GraphNode startNode;

			[Token(Token = "0x40007EB")]
			[FieldOffset(Offset = "0xD0")]
			public uint furthestNodeScore;

			[Token(Token = "0x40007EC")]
			[FieldOffset(Offset = "0xD8")]
			public GraphNode furthestNode;

			[Token(Token = "0x6000C0B")]
			[Address(RVA = "0x4584D78", Offset = "0x4580D78", VA = "0x4584D78")]
			public static EuclideanEmbeddingSearchPath Construct(UnsafeSpan<uint> costs, uint costIndexStride, uint pivotIndex, GraphNode startNode)
			{
				return null;
			}

			[Token(Token = "0x6000C0C")]
			[Address(RVA = "0x4584E20", Offset = "0x4580E20", VA = "0x4584E20", Slot = "23")]
			protected override void OnFoundEndNode(ref SearchContext ctx, uint pathNode, uint hScore, uint gScore)
			{
			}

			[Token(Token = "0x6000C0D")]
			[Address(RVA = "0x4584E58", Offset = "0x4580E58", VA = "0x4584E58", Slot = "22")]
			protected override void OnHeapExhausted(ref SearchContext ctx)
			{
			}

			[Token(Token = "0x6000C0E")]
			[Address(RVA = "0x4584E64", Offset = "0x4580E64", VA = "0x4584E64", Slot = "24")]
			public override void OnVisitNode(ref SearchContext ctx, uint pathNode, uint hScore, uint gScore)
			{
			}

			[Token(Token = "0x6000C0F")]
			[Address(RVA = "0x458504C", Offset = "0x458104C", VA = "0x458504C", Slot = "20")]
			protected override void Prepare(ref SearchContext ctx)
			{
			}

			[Token(Token = "0x6000C10")]
			[Address(RVA = "0x4585148", Offset = "0x4581148", VA = "0x4585148")]
			public EuclideanEmbeddingSearchPath()
			{
			}
		}

		[Token(Token = "0x40007DC")]
		[FieldOffset(Offset = "0x10")]
		public HeuristicOptimizationMode mode;

		[Token(Token = "0x40007DD")]
		[FieldOffset(Offset = "0x14")]
		public int seed;

		[Token(Token = "0x40007DE")]
		[FieldOffset(Offset = "0x18")]
		public Transform pivotPointRoot;

		[Token(Token = "0x40007DF")]
		[FieldOffset(Offset = "0x20")]
		public int spreadOutCount;

		[NonSerialized]
		[Token(Token = "0x40007E0")]
		[FieldOffset(Offset = "0x24")]
		public bool dirty;

		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0x40")]
		private GraphNode[] pivots;

		[Token(Token = "0x40007E4")]
		private const uint ra = 12820163u;

		[Token(Token = "0x40007E5")]
		private const uint rc = 1140671485u;

		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0x48")]
		private uint rval;

		[Token(Token = "0x170001FB")]
		public NativeArray<uint> costs
		{
			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0x4583508", Offset = "0x457F508", VA = "0x4583508")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0x4583514", Offset = "0x457F514", VA = "0x4583514")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170001FC")]
		public int pivotCount
		{
			[Token(Token = "0x6000BFD")]
			[Address(RVA = "0x458351C", Offset = "0x457F51C", VA = "0x458351C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BFE")]
			[Address(RVA = "0x4583524", Offset = "0x457F524", VA = "0x4583524")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x458352C", Offset = "0x457F52C", VA = "0x458352C")]
		private uint GetRandom()
		{
			return default;
		}

		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x4583550", Offset = "0x457F550", VA = "0x4583550")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x45835CC", Offset = "0x457F5CC", VA = "0x45835CC")]
		public static uint GetHeuristic(UnsafeSpan<uint> costs, uint pivotCount, uint nodeIndex1, uint nodeIndex2)
		{
			return default;
		}

		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x4583744", Offset = "0x457F744", VA = "0x4583744")]
		private void GetClosestWalkableNodesToChildrenRecursively(Transform tr, List<GraphNode> nodes)
		{
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x4583BBC", Offset = "0x457FBBC", VA = "0x4583BBC")]
		private void PickNRandomNodes(int count, List<GraphNode> buffer)
		{
		}

		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x4583D38", Offset = "0x457FD38", VA = "0x4583D38")]
		private GraphNode PickAnyWalkableNode()
		{
			return null;
		}

		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x4583EEC", Offset = "0x457FEEC", VA = "0x4583EEC")]
		public void RecalculatePivots()
		{
		}

		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x45842CC", Offset = "0x45802CC", VA = "0x45842CC")]
		public void RecalculateCosts()
		{
		}

		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x4584300", Offset = "0x4580300", VA = "0x4584300")]
		private void RecalculateCostsInner()
		{
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x458468C", Offset = "0x458068C", VA = "0x458468C")]
		private void ApplyGridGraphEndpointSpecialCase()
		{
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x4584BFC", Offset = "0x4580BFC", VA = "0x4584BFC")]
		public void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x4584D68", Offset = "0x4580D68", VA = "0x4584D68")]
		public EuclideanEmbedding()
		{
		}
	}
}
