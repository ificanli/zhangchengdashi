using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x200017E")]
	[BurstCompile]
	public struct JobMaxHitCount : IJob
	{
		[Token(Token = "0x4000790")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<RaycastHit> hits;

		[Token(Token = "0x4000791")]
		[FieldOffset(Offset = "0x10")]
		public int maxHits;

		[Token(Token = "0x4000792")]
		[FieldOffset(Offset = "0x14")]
		public int layerStride;

		[Token(Token = "0x4000793")]
		[FieldOffset(Offset = "0x18")]
		[WriteOnly]
		public NativeArray<int> maxHitCount;

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x458197C", Offset = "0x457D97C", VA = "0x458197C", Slot = "4")]
		public void Execute()
		{
 int layers=0;
 for (;layers<maxHits;layers++) {
  bool found=false;int first=unchecked(layerStride*layers);
  for (int i=first;i<unchecked(first+layerStride);i++) {
   Unity.Mathematics.float3 normal=hits[i].normal;
   if (Unity.Mathematics.math.any(normal!=Unity.Mathematics.float3.zero)) { found=true;break; }
  }
  if (!found) break;
 }
 maxHitCount[0]=System.Math.Max(1,layers);
}
	}
}
