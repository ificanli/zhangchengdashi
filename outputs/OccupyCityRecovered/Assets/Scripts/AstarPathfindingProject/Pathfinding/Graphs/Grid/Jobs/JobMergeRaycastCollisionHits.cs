using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x200022B")]
	[BurstCompile]
	public struct JobMergeRaycastCollisionHits : IJob
	{
		[Token(Token = "0x4000A4A")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<RaycastHit> hit1;

		[Token(Token = "0x4000A4B")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<RaycastHit> hit2;

		[Token(Token = "0x4000A4C")]
		[FieldOffset(Offset = "0x20")]
		[WriteOnly]
		public NativeArray<bool> result;

		[Token(Token = "0x6000E10")]
		[Address(RVA = "0x447BD00", Offset = "0x4477D00", VA = "0x447BD00", Slot = "4")]
		public void Execute()
		{
		}
	}
}
