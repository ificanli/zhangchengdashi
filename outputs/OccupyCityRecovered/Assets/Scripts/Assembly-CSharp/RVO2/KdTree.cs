using System;
using Beebyte.Obfuscator;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace RVO2
{
	[Token(Token = "0x2000F07")]
	[BurstCompile]
	[Skip]
	public struct KdTree
	{
		[Token(Token = "0x2000F08")]
		[BurstCompile]
		[Skip]
		public struct AgentTreeNode
		{
			[Token(Token = "0x400683E")]
			[FieldOffset(Offset = "0x0")]
			internal int begin_;

			[Token(Token = "0x400683F")]
			[FieldOffset(Offset = "0x4")]
			internal int end_;

			[Token(Token = "0x4006840")]
			[FieldOffset(Offset = "0x8")]
			internal int left_;

			[Token(Token = "0x4006841")]
			[FieldOffset(Offset = "0xC")]
			internal int right_;

			[Token(Token = "0x4006842")]
			[FieldOffset(Offset = "0x10")]
			internal float maxX_;

			[Token(Token = "0x4006843")]
			[FieldOffset(Offset = "0x14")]
			internal float maxY_;

			[Token(Token = "0x4006844")]
			[FieldOffset(Offset = "0x18")]
			internal float minX_;

			[Token(Token = "0x4006845")]
			[FieldOffset(Offset = "0x1C")]
			internal float minY_;
		}

		[Token(Token = "0x2000F09")]
		[BurstCompile]
		[Skip]
		public struct FloatPair
		{
			[Token(Token = "0x4006846")]
			[FieldOffset(Offset = "0x0")]
			private float a_;

			[Token(Token = "0x4006847")]
			[FieldOffset(Offset = "0x4")]
			private float b_;

			[Token(Token = "0x6005A74")]
			[Address(RVA = "0x43954C0", Offset = "0x43914C0", VA = "0x43954C0")]
			internal FloatPair(float a, float b)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED KdTree.FloatPair..ctor RVA=0x43954C0 Token=0x6005A74");
}

			[Token(Token = "0x6005A75")]
			[Address(RVA = "0x43954F4", Offset = "0x43914F4", VA = "0x43954F4")]
			public static bool operator <(FloatPair pair1, FloatPair pair2)
			{
				return default;
			}

			[Token(Token = "0x6005A76")]
			[Address(RVA = "0x4395520", Offset = "0x4391520", VA = "0x4395520")]
			public static bool operator <=(FloatPair pair1, FloatPair pair2)
			{
				return default;
			}

			[Token(Token = "0x6005A77")]
			[Address(RVA = "0x439555C", Offset = "0x439155C", VA = "0x439555C")]
			public static bool operator >(FloatPair pair1, FloatPair pair2)
			{
				return default;
			}

			[Token(Token = "0x6005A78")]
			[Address(RVA = "0x43954C8", Offset = "0x43914C8", VA = "0x43954C8")]
			public static bool operator >=(FloatPair pair1, FloatPair pair2)
			{
				return default;
			}
		}

		[Token(Token = "0x2000F0A")]
		[BurstCompile]
		[Skip]
		public struct ObstacleTreeNode
		{
			[Token(Token = "0x4006848")]
			[FieldOffset(Offset = "0x0")]
			internal unsafe Obstacle* obstacle_;

			[Token(Token = "0x4006849")]
			[FieldOffset(Offset = "0x8")]
			internal unsafe ObstacleTreeNode* left_;

			[Token(Token = "0x400684A")]
			[FieldOffset(Offset = "0x10")]
			internal unsafe ObstacleTreeNode* right_;
		}

		[Token(Token = "0x4006837")]
		private const int MAX_LEAF_SIZE = 10;

		[Token(Token = "0x4006838")]
		[FieldOffset(Offset = "0x0")]
		public unsafe UnsafeList<IntPtr>* agentsPtr_;

		[Token(Token = "0x4006839")]
		[FieldOffset(Offset = "0x8")]
		public unsafe UnsafeList<AgentTreeNode>* agentTree_;

		[Token(Token = "0x400683A")]
		[FieldOffset(Offset = "0x10")]
		public unsafe UnsafeList<ObstacleTreeNode>* treeNodeList;

		[Token(Token = "0x400683B")]
		[FieldOffset(Offset = "0x18")]
		public unsafe ObstacleTreeNode* obstacleTree_;

		[Token(Token = "0x400683C")]
		[FieldOffset(Offset = "0x20")]
		public unsafe UnsafeList<Agent>* agentList;

		[Token(Token = "0x400683D")]
		[FieldOffset(Offset = "0x28")]
		public unsafe UnsafeList<Obstacle>* obstacleList;

		[Token(Token = "0x6005A67")]
		[Address(RVA = "0x4393F3C", Offset = "0x438FF3C", VA = "0x4393F3C")]
		internal void Dispose()
		{
		}

		[Token(Token = "0x6005A68")]
		[Address(RVA = "0x4393F40", Offset = "0x438FF40", VA = "0x4393F40")]
		public int GetMaxNode(int nodeNum)
		{
			return default;
		}

		[Token(Token = "0x6005A69")]
		[Address(RVA = "0x43923A4", Offset = "0x438E3A4", VA = "0x43923A4")]
		internal unsafe void computeAgentNeighbors(Agent* agent, ref float rangeSq)
		{
		}

		[Token(Token = "0x6005A6A")]
		[Address(RVA = "0x439239C", Offset = "0x438E39C", VA = "0x439239C")]
		internal unsafe void computeObstacleNeighbors(Agent* agent, float rangeSq)
		{
		}

		[Token(Token = "0x6005A6B")]
		[Address(RVA = "0x43943E4", Offset = "0x43903E4", VA = "0x43943E4")]
		internal bool queryVisibility(float2 q1, float2 q2, float radius)
		{
			return default;
		}

		[Token(Token = "0x6005A6C")]
		[Address(RVA = "0x4394684", Offset = "0x4390684", VA = "0x4394684")]
		internal int queryNearAgent(float2 point, float radius)
		{
			return default;
		}

		[Token(Token = "0x6005A6D")]
		[Address(RVA = "0x4394A18", Offset = "0x4390A18", VA = "0x4394A18")]
		[BurstCompile]
		[Skip]
		private unsafe Agent* ParseAgent(int index)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED KdTree.ParseAgent RVA=0x4394A18 Token=0x6005A6D");
}

		[Token(Token = "0x6005A6E")]
		[Address(RVA = "0x4394A60", Offset = "0x4390A60", VA = "0x4394A60")]
		public void buildAgentTreeRecursive(int begin, int end, int node)
		{
		}

		[Token(Token = "0x6005A6F")]
		[Address(RVA = "0x4394DC8", Offset = "0x4390DC8", VA = "0x4394DC8")]
		public unsafe ObstacleTreeNode* buildObstacleTreeRecursive(NativeArray<IntPtr> obstacles)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED KdTree.buildObstacleTreeRecursive RVA=0x4394DC8 Token=0x6005A6F");
}

		[Token(Token = "0x6005A70")]
		[Address(RVA = "0x43946D4", Offset = "0x43906D4", VA = "0x43946D4")]
		private void queryAgentTreeRecursive(float2 position, ref float rangeSq, ref int agentNo, int node)
		{
		}

		[Token(Token = "0x6005A71")]
		[Address(RVA = "0x4393FC8", Offset = "0x438FFC8", VA = "0x4393FC8")]
		private unsafe void queryAgentTreeRecursive(Agent* agent, ref float rangeSq, int node)
		{
		}

		[Token(Token = "0x6005A72")]
		[Address(RVA = "0x43942E0", Offset = "0x43902E0", VA = "0x43942E0")]
		private unsafe void queryObstacleTreeRecursive(Agent* agent, float rangeSq, ObstacleTreeNode* node)
		{
		}

		[Token(Token = "0x6005A73")]
		[Address(RVA = "0x43943EC", Offset = "0x43903EC", VA = "0x43943EC")]
		private unsafe bool queryVisibilityRecursive(float2 q1, float2 q2, float radius, ObstacleTreeNode* node)
		{
			return default;
		}
	}
}
