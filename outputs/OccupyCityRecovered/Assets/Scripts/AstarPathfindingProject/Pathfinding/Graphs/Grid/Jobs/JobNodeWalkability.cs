using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x200022D")]
	[BurstCompile(FloatMode = FloatMode.Fast)]
	public struct JobNodeWalkability : IJob
	{
		[Token(Token = "0x4000A50")]
		[FieldOffset(Offset = "0x0")]
		public bool useRaycastNormal;

		[Token(Token = "0x4000A51")]
		[FieldOffset(Offset = "0x4")]
		public float maxSlope;

		[Token(Token = "0x4000A52")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 up;

		[Token(Token = "0x4000A53")]
		[FieldOffset(Offset = "0x14")]
		public bool unwalkableWhenNoGround;

		[Token(Token = "0x4000A54")]
		[FieldOffset(Offset = "0x18")]
		public float characterHeight;

		[Token(Token = "0x4000A55")]
		[FieldOffset(Offset = "0x1C")]
		public int layerStride;

		[Token(Token = "0x4000A56")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public NativeArray<float3> nodePositions;

		[Token(Token = "0x4000A57")]
		[FieldOffset(Offset = "0x30")]
		public NativeArray<float4> nodeNormals;

		[Token(Token = "0x4000A58")]
		[FieldOffset(Offset = "0x40")]
		[WriteOnly]
		public NativeArray<bool> nodeWalkable;

		[Token(Token = "0x6000E14")]
		[Address(RVA = "0x447BF84", Offset = "0x4477F84", VA = "0x447BF84", Slot = "4")]
		public void Execute()
		{
 float threshold=(float)System.Math.Cos((double)(maxSlope*0.01745329238474369f));
 var up4=new float4(up.x,up.y,up.z,0f);
 for (int i=0;i<nodeNormals.Length;i++) {
  bool found=true;
  var normal=nodeNormals[i];
  if (math.all(normal==default(float4))) {
   if (unwalkableWhenNoGround || i>=layerStride) { nodeWalkable[i]=false; continue; }
   found=false;
   normal=up4;
   nodeNormals[i]=normal;
  }
  if (found && useRaycastNormal && !(math.dot(up4,normal)>=threshold)) { nodeWalkable[i]=false; continue; }
  int above=unchecked(i+layerStride);
  nodeWalkable[i]=above>=nodeNormals.Length || math.all(nodeNormals[above]==default(float4)) || math.dot(new float3(up.x,up.y,up.z),nodePositions[above]-nodePositions[i])>=characterHeight;
 }
}
	}
}
