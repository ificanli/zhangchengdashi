using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x2000236")]
	public struct JobWriteNodeData : IJobParallelForBatched
	{
		[Token(Token = "0x4000A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GCHandle nodesHandle;

		[Token(Token = "0x4000A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint graphIndex;

		[Token(Token = "0x4000A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int3 nodeArrayBounds;

		[Token(Token = "0x4000A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntBounds dataBounds;

		[Token(Token = "0x4000A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntBounds writeMask;

		[Token(Token = "0x4000A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[ReadOnly]
		public NativeArray<Vector3> nodePositions;

		[Token(Token = "0x4000A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[ReadOnly]
		public NativeArray<uint> nodePenalties;

		[Token(Token = "0x4000A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[ReadOnly]
		public NativeArray<int> nodeTags;

		[Token(Token = "0x4000A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[ReadOnly]
		public NativeArray<ulong> nodeConnections;

		[Token(Token = "0x4000A99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[ReadOnly]
		public NativeArray<bool> nodeWalkableWithErosion;

		[Token(Token = "0x4000A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[ReadOnly]
		public NativeArray<bool> nodeWalkable;

		[Token(Token = "0x17000221")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x6000E1F")]
			[Address(RVA = "0x447D54C", Offset = "0x447954C", VA = "0x447D54C", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000E20")]
		[Address(RVA = "0x447D554", Offset = "0x4479554", VA = "0x447D554", Slot = "5")]
		public void Execute(int startIndex, int count)
		{
		}
	}
}
