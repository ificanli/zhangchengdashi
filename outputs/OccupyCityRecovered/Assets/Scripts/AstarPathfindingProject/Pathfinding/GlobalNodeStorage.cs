using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Jobs;

namespace Pathfinding
{
	[Token(Token = "0x20000A1")]
	internal class GlobalNodeStorage
	{
		[Token(Token = "0x20000A2")]
		public struct PathfindingThreadData
		{
			[Token(Token = "0x400036D")]
			[FieldOffset(Offset = "0x0")]
			public UnsafeSpan<PathNode> pathNodes;
		}

		[Token(Token = "0x20000A3")]
		private class IndexedStack<T>
		{
			[Token(Token = "0x400036E")]
			[FieldOffset(Offset = "0x0")]
			private T[] buffer;

			[Token(Token = "0x1700011D")]
			public int Count
			{
				[Token(Token = "0x6000574")]
				[CompilerGenerated]
				get
				{
					return default;
				}
				[Token(Token = "0x6000575")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000576")]
			public void Push(T v)
			{
			}

			[Token(Token = "0x6000577")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000578")]
			public T Pop()
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GlobalNodeStorage.IndexedStack.Pop RVA= Token=0x6000578");
}

			[Token(Token = "0x6000579")]
			public void PopMany(T[] resultBuffer, int popCount)
			{
			}

			[Token(Token = "0x600057A")]
			public IndexedStack()
			{
			}
		}

		[Token(Token = "0x20000A4")]
		private struct JobAllocateNodes<T> : IJob where T : GraphNode
		{
			[Token(Token = "0x4000370")]
			[FieldOffset(Offset = "0x0")]
			public T[] result;

			[Token(Token = "0x4000371")]
			[FieldOffset(Offset = "0x0")]
			public int count;

			[Token(Token = "0x4000372")]
			[FieldOffset(Offset = "0x0")]
			public GlobalNodeStorage nodeStorage;

			[Token(Token = "0x4000373")]
			[FieldOffset(Offset = "0x0")]
			public uint variantsPerNode;

			[Token(Token = "0x4000374")]
			[FieldOffset(Offset = "0x0")]
			public Func<T> createNode;

			[Token(Token = "0x1700011E")]
			public bool allowBoundsChecks
			{
				[Token(Token = "0x600057B")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600057C")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x10")]
		private readonly AstarPath astar;

		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x18")]
		private JobHandle lastAllocationJob;

		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x28")]
		public uint nextNodeIndex;

		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x2C")]
		public uint reservedPathNodeData;

		[Token(Token = "0x4000368")]
		private const int InitialTemporaryNodes = 256;

		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x34")]
		private int temporaryNodeCount;

		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x38")]
		private readonly IndexedStack<uint>[] nodeIndexPools;

		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x40")]
		public PathfindingThreadData[] pathfindingThreadData;

		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x48")]
		private GraphNode[] nodes;

		[Token(Token = "0x1700011C")]
		public uint destroyedNodesVersion
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x450F4F4", Offset = "0x450B4F4", VA = "0x450F4F4")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x450F4FC", Offset = "0x450B4FC", VA = "0x450F4FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x450F504", Offset = "0x450B504", VA = "0x450F504")]
		public GlobalNodeStorage(AstarPath astar)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x450F6C8", Offset = "0x450B6C8", VA = "0x450F6C8")]
		public GraphNode GetNode(uint nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x450F6F8", Offset = "0x450B6F8", VA = "0x450F6F8")]
		private void DisposeThreadData()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x450F7C0", Offset = "0x450B7C0", VA = "0x450F7C0")]
		public void SetThreadCount(int threadCount)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x450F974", Offset = "0x450B974", VA = "0x450F974")]
		public void GrowTemporaryNodeStorage(int threadID)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x450FB48", Offset = "0x450BB48", VA = "0x450FB48")]
		public void InitializeNode(GraphNode node)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x450FD88", Offset = "0x450BD88", VA = "0x450FD88")]
		private void ReserveNodeIndices(uint nextNodeIndex)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x450FEA4", Offset = "0x450BEA4", VA = "0x450FEA4")]
		public void DestroyNode(GraphNode node)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x4510138", Offset = "0x450C138", VA = "0x4510138")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000573")]
		public JobHandle AllocateNodesJob<T>(T[] result, int count, Func<T> createNode, uint variantsPerNode) where T : GraphNode
		{
			return default;
		}
	}
}
