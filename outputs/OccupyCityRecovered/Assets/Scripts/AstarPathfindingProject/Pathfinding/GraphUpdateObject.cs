using System;
using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200002F")]
	public class GraphUpdateObject
	{
		[Token(Token = "0x2000030")]
		public struct GraphUpdateData
		{
			[Token(Token = "0x4000174")]
			[FieldOffset(Offset = "0x0")]
			public NativeArray<Vector3> nodePositions;

			[Token(Token = "0x4000175")]
			[FieldOffset(Offset = "0x10")]
			public NativeArray<uint> nodePenalties;

			[Token(Token = "0x4000176")]
			[FieldOffset(Offset = "0x20")]
			public NativeArray<bool> nodeWalkable;

			[Token(Token = "0x4000177")]
			[FieldOffset(Offset = "0x30")]
			public NativeArray<int> nodeTags;

			[Token(Token = "0x4000178")]
			[FieldOffset(Offset = "0x40")]
			public NativeArray<float4> nodeNormals;

			[Token(Token = "0x4000179")]
			[FieldOffset(Offset = "0x50")]
			public NativeArray<int> nodeIndices;
		}

		[Token(Token = "0x2000031")]
		[BurstCompile]
		public struct JobGraphUpdate : IJob
		{
			[Token(Token = "0x400017A")]
			[FieldOffset(Offset = "0x0")]
			public GraphUpdateShape.BurstShape shape;

			[Token(Token = "0x400017B")]
			[FieldOffset(Offset = "0x38")]
			public GraphUpdateData data;

			[Token(Token = "0x400017C")]
			[FieldOffset(Offset = "0x98")]
			public Bounds bounds;

			[Token(Token = "0x400017D")]
			[FieldOffset(Offset = "0xB0")]
			public int penaltyDelta;

			[Token(Token = "0x400017E")]
			[FieldOffset(Offset = "0xB4")]
			public bool modifyWalkability;

			[Token(Token = "0x400017F")]
			[FieldOffset(Offset = "0xB5")]
			public bool walkabilityValue;

			[Token(Token = "0x4000180")]
			[FieldOffset(Offset = "0xB6")]
			public bool modifyTag;

			[Token(Token = "0x4000181")]
			[FieldOffset(Offset = "0xB8")]
			public int tagValue;

			[Token(Token = "0x6000263")]
			[Address(RVA = "0x445DBEC", Offset = "0x4459BEC", VA = "0x445DBEC", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x10")]
		public Bounds bounds;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x28")]
		public bool updatePhysics;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x29")]
		public bool resetPenaltyOnPhysics;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x2A")]
		public bool updateErosion;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x2C")]
		public GraphMask graphMask;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x30")]
		public int addPenalty;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x34")]
		public bool modifyWalkability;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x35")]
		public bool setWalkability;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x36")]
		public bool modifyTag;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x38")]
		public PathfindingTag setTag;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x3C")]
		[Obsolete("This field does not do anything anymore. Use AstarPath.Snapshot instead.")]
		public bool trackChangedNodes;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x40")]
		public GraphUpdateShape shape;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x48")]
		internal int internalStage;

		[Token(Token = "0x4000170")]
		internal const int STAGE_CREATED = -1;

		[Token(Token = "0x4000171")]
		internal const int STAGE_PENDING = -2;

		[Token(Token = "0x4000172")]
		internal const int STAGE_ABORTED = -3;

		[Token(Token = "0x4000173")]
		internal const int STAGE_APPLIED = 0;

		[Token(Token = "0x170000B8")]
		[Obsolete("Use the graphMask field instead")]
		public NNConstraintGraphUpdateObjectProxy nnConstraint
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x445D90C", Offset = "0x445990C", VA = "0x445D90C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public GraphUpdateStage stage
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x445D968", Offset = "0x4459968", VA = "0x445D968")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x445D990", Offset = "0x4459990", VA = "0x445D990", Slot = "4")]
		public virtual void WillUpdateNode(GraphNode node)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x445D994", Offset = "0x4459994", VA = "0x445D994", Slot = "5")]
		[Obsolete("Use AstarPath.Snapshot instead", true)]
		public virtual void RevertFromBackup()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x445D998", Offset = "0x4459998", VA = "0x445D998", Slot = "6")]
		public virtual void Apply(GraphNode node)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x445DA24", Offset = "0x4459A24", VA = "0x445DA24", Slot = "7")]
		public virtual void ApplyJob(GraphUpdateData data, JobDependencyTracker dependencyTracker)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x445DB78", Offset = "0x4459B78", VA = "0x445DB78")]
		public GraphUpdateObject()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x445DB9C", Offset = "0x4459B9C", VA = "0x445DB9C")]
		public GraphUpdateObject(Bounds b)
		{
		}
	}
}
