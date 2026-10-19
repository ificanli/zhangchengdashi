using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh.Jobs
{
	[Token(Token = "0x20001FB")]
	internal struct JobConnectTilesSingle : IJob
	{
		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GCHandle tiles;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int tileIndex1;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int tileIndex2;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 tileWorldSize;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxTileConnectionEdgeDistance;

		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x4471938", Offset = "0x446D938", VA = "0x4471938", Slot = "4")]
		public void Execute()
		{
		}
	}
}
