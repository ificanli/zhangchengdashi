using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x2000227")]
	[BurstCompile]
	public struct JobColliderHitsToBooleans : IJob
	{
		[Token(Token = "0x4000A34")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<ColliderHit> hits;

		[Token(Token = "0x4000A35")]
		[FieldOffset(Offset = "0x10")]
		[WriteOnly]
		public NativeArray<bool> result;

		[Token(Token = "0x6000E0A")]
		[Address(RVA = "0x447B4F0", Offset = "0x44774F0", VA = "0x447B4F0", Slot = "4")]
		public void Execute()
		{
		}
	}
}
