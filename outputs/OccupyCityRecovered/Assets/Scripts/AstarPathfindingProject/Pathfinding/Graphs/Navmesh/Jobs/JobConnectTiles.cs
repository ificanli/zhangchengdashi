using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh.Jobs
{
	[Token(Token = "0x20001FA")]
	public struct JobConnectTiles : IJob
	{
		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GCHandle tiles;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int coordinateSum;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int direction;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int zOffset;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int zStride;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2 tileWorldSize;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IntRect tileRect;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxTileConnectionEdgeDistance;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker ConnectTilesMarker;

		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0x446F588", Offset = "0x446B588", VA = "0x446F588")]
		public static JobHandle ScheduleBatch(GCHandle tilesHandle, JobHandle dependency, IntRect tileRect, Vector2 tileWorldSize, float maxTileConnectionEdgeDistance)
		{
			return default;
		}

		[Token(Token = "0x6000D80")]
		[Address(RVA = "0x4471448", Offset = "0x446D448", VA = "0x4471448")]
		public static JobHandle ScheduleRecalculateBorders(GCHandle tilesHandle, JobHandle dependency, IntRect tileRect, IntRect innerRect, Vector2 tileWorldSize, float maxTileConnectionEdgeDistance)
		{
			return default;
		}

		[Token(Token = "0x6000D81")]
		[Address(RVA = "0x44716B8", Offset = "0x446D6B8", VA = "0x44716B8", Slot = "4")]
		public void Execute()
		{
		}
	}
}
