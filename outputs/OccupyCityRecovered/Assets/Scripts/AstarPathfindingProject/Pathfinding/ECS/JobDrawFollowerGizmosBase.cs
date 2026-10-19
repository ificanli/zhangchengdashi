using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Drawing;
using Unity.Burst;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;
using UnityEngine;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000326")]
	[BurstCompile]
	public partial struct JobDrawFollowerGizmosBase : IJobEntity, IJobEntityChunkBeginEnd, IJobChunk
	{

		[Token(Token = "0x200032A")]
		public delegate void DrawGizmos_00001251_0024PostfixBurstDelegate(ref CommandBuilder draw, in LocalTransform transform, in AgentCylinderShape shape, in DestinationPoint destination, bool draw2D);

		[Token(Token = "0x200032B")]
		internal static class DrawGizmos_00001251_0024BurstDirectCall
		{
			[Token(Token = "0x4000E30")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000E31")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x60013DF")]
			[Address(RVA = "0x44BD830", Offset = "0x44B9830", VA = "0x44BD830")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x60013E0")]
			[Address(RVA = "0x44BD94C", Offset = "0x44B994C", VA = "0x44BD94C")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x60013E1")]
			[Address(RVA = "0x44BD9A8", Offset = "0x44B99A8", VA = "0x44BD9A8")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x60013E2")]
			[Address(RVA = "0x44BDA50", Offset = "0x44B9A50", VA = "0x44BDA50")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x60013E4")]
			[Address(RVA = "0x44BBF54", Offset = "0x44B7F54", VA = "0x44BBF54")]
			public static void Invoke(ref CommandBuilder draw, in LocalTransform transform, in AgentCylinderShape shape, in DestinationPoint destination, bool draw2D)
			{
			}
		}

		[Token(Token = "0x4000E27")]
		[FieldOffset(Offset = "0x0")]
		public CommandBuilder draw;

		[Token(Token = "0x4000E28")]
		[FieldOffset(Offset = "0x18")]
		private OrientationMode orientation;

		[Token(Token = "0x4000E29")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Color ShapeGizmoColor;

		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x44BBDE0", Offset = "0x44B7DE0", VA = "0x44BBDE0")]
		public bool OnChunkBegin(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
			return default;
		}

		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x44BBE44", Offset = "0x44B7E44", VA = "0x44BBE44")]
		public void OnChunkEnd(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask, bool chunkWasExecuted)
		{
		}

		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x44BBE48", Offset = "0x44B7E48", VA = "0x44BBE48")]
		public void Execute(in LocalTransform transform, in AgentCylinderShape shape, in DestinationPoint destination)
		{
		}

		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x44BBED0", Offset = "0x44B7ED0", VA = "0x44BBED0")]
		[BurstCompile]
		public static void DrawGizmos(ref CommandBuilder draw, in LocalTransform transform, in AgentCylinderShape shape, in DestinationPoint destination, bool draw2D)
		{
		}

		[Token(Token = "0x60013CC")]
		[Address(RVA = "0x44BCB38", Offset = "0x44B8B38", VA = "0x44BCB38", Slot = "4")]
bool IJobEntityChunkBeginEnd.OnChunkBegin(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
			return default;
		}

		[Token(Token = "0x60013CD")]
		[Address(RVA = "0x44BCBA8", Offset = "0x44B8BA8", VA = "0x44BCBA8", Slot = "5")]
void IJobEntityChunkBeginEnd.OnChunkEnd(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask, bool chunkWasExecuted)
		{
		}

		[Token(Token = "0x60013CE")]
		[Address(RVA = "0x44BCBFC", Offset = "0x44B8BFC", VA = "0x44BCBFC", Slot = "6")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60013CF")]
		[Address(RVA = "0x44BCC78", Offset = "0x44B8C78", VA = "0x44BCC78")]
		[BurstCompile]
		public static void DrawGizmos_0024BurstManaged(ref CommandBuilder draw, in LocalTransform transform, in AgentCylinderShape shape, in DestinationPoint destination, bool draw2D)
		{
		}
	}
}
