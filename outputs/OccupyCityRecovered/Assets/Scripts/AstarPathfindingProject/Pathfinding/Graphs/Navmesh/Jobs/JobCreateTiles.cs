using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh.Jobs
{
	[Token(Token = "0x20001FD")]
	public struct JobCreateTiles : IJob
	{
		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[NativeDisableContainerSafetyRestriction]
		public NativeArray<TileMesh.TileMeshUnsafe> preCutTileMeshes;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<TileMesh.TileMeshUnsafe> tileMeshes;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GCHandle tiles;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint graphIndex;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector2Int graphTileCount;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public IntRect tileRect;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint initialPenalty;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool recalculateNormals;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector2 tileWorldSize;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Matrix4x4 graphToWorldSpace;

		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x4471A30", Offset = "0x446DA30", VA = "0x4471A30", Slot = "4")]
		public void Execute()
		{
		}
	}
}
