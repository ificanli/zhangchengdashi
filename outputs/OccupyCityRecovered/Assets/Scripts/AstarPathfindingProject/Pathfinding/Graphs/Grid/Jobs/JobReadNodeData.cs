using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Collections;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x2000233")]
	public struct JobReadNodeData : IJobParallelForBatched
	{
		[Token(Token = "0x2000234")]
		private struct Reader : GridIterationUtilities.ISliceAction
		{
			[Token(Token = "0x4000A85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GridNodeBase[] nodes;

			[Token(Token = "0x4000A86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public NativeArray<Vector3> nodePositions;

			[Token(Token = "0x4000A87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NativeArray<uint> nodePenalties;

			[Token(Token = "0x4000A88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public NativeArray<int> nodeTags;

			[Token(Token = "0x4000A89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public NativeArray<ulong> nodeConnections;

			[Token(Token = "0x4000A8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public NativeArray<bool> nodeWalkableWithErosion;

			[Token(Token = "0x4000A8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public NativeArray<bool> nodeWalkable;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000E1C")]
			[Address(RVA = "0x447D254", Offset = "0x4479254", VA = "0x447D254", Slot = "4")]
			public void Execute(uint outerIdx, uint innerIdx)
			{
			}
		}

		[Token(Token = "0x4000A7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GCHandle nodesHandle;

		[Token(Token = "0x4000A7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint graphIndex;

		[Token(Token = "0x4000A7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Slice3D slice;

		[Token(Token = "0x4000A7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[WriteOnly]
		public NativeArray<Vector3> nodePositions;

		[Token(Token = "0x4000A80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[WriteOnly]
		public NativeArray<uint> nodePenalties;

		[Token(Token = "0x4000A81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[WriteOnly]
		public NativeArray<int> nodeTags;

		[Token(Token = "0x4000A82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[WriteOnly]
		public NativeArray<ulong> nodeConnections;

		[Token(Token = "0x4000A83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[WriteOnly]
		public NativeArray<bool> nodeWalkableWithErosion;

		[Token(Token = "0x4000A84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[WriteOnly]
		public NativeArray<bool> nodeWalkable;

		[Token(Token = "0x17000220")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x6000E1A")]
			[Address(RVA = "0x447D14C", Offset = "0x447914C", VA = "0x447D14C", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x447D154", Offset = "0x4479154", VA = "0x447D154", Slot = "5")]
		public void Execute(int startIndex, int count)
		{
		}
	}
}
