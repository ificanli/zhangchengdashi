using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Drawing;
using Unity.Burst;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

namespace Pathfinding.ECS
{
	[Token(Token = "0x200031E")]
	[BurstCompile]
	[WithNone(new Type[] { typeof(AgentOffMeshLinkTraversal) })]
	[WithAll(new Type[]
	{
		typeof(SimulateMovement),
		typeof(SimulateMovementControl)
	})]
	public partial struct JobControl : IJobEntity, IJobEntityChunkBeginEnd, IJobChunk
	{

		[Token(Token = "0x4000E03")]
		[FieldOffset(Offset = "0x0")]
		public float dt;

		[Token(Token = "0x4000E04")]
		[FieldOffset(Offset = "0x8")]
		public CommandBuilder draw;

		[Token(Token = "0x4000E05")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		[NativeDisableContainerSafetyRestriction]
		public NavmeshEdges.NavmeshBorderData navmeshEdgeData;

		[Token(Token = "0x4000E06")]
		[FieldOffset(Offset = "0x50")]
		[NativeDisableContainerSafetyRestriction]
		public NativeList<float2> edgesScratch;

		[Token(Token = "0x4000E07")]
		[FieldOffset(Offset = "0x58")]
		[NativeDisableContainerSafetyRestriction]
		public NativeList<int> indicesScratch;

		[Token(Token = "0x4000E08")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerConvertObstacles;

		[Token(Token = "0x6001374")]
		[Address(RVA = "0x44B89BC", Offset = "0x44B49BC", VA = "0x44B89BC")]
		public static float3 ClampToNavmesh(float3 position, float3 closestOnNavmesh, in AgentCylinderShape shape, in AgentMovementPlane movementPlane)
		{
			return default;
		}

		[Token(Token = "0x6001375")]
		[Address(RVA = "0x44B8A68", Offset = "0x44B4A68", VA = "0x44B8A68")]
		public bool OnChunkBegin(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
			return default;
		}

		[Token(Token = "0x6001376")]
		[Address(RVA = "0x44B8B40", Offset = "0x44B4B40", VA = "0x44B8B40")]
		public void OnChunkEnd(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask, bool chunkWasExecuted)
		{
		}

		[Token(Token = "0x6001377")]
		[Address(RVA = "0x44B8B44", Offset = "0x44B4B44", VA = "0x44B8B44")]
		public void Execute(ref LocalTransform transform, ref MovementState state, in DestinationPoint destination, in AgentCylinderShape shape, in AgentMovementPlane movementPlane, in MovementSettings settings, in ResolvedMovement resolvedMovement, ref MovementControl controlOutput)
		{
		}

		[Token(Token = "0x6001391")]
		[Address(RVA = "0x44BA1B0", Offset = "0x44B61B0", VA = "0x44BA1B0", Slot = "4")]
bool IJobEntityChunkBeginEnd.OnChunkBegin(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
			return default;
		}

		[Token(Token = "0x6001392")]
		[Address(RVA = "0x44BA210", Offset = "0x44B6210", VA = "0x44BA210", Slot = "5")]
void IJobEntityChunkBeginEnd.OnChunkEnd(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask, bool chunkWasExecuted)
		{
		}

		[Token(Token = "0x6001393")]
		[Address(RVA = "0x44BA264", Offset = "0x44B6264", VA = "0x44BA264", Slot = "6")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}
	}
}
