using Il2CppDummyDll;
using Pathfinding.Graphs.Grid;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x2000180")]
	[BurstCompile(FloatMode = FloatMode.Fast)]
	public struct JobCopyHits : IJob, GridIterationUtilities.ISliceAction
	{
		[Token(Token = "0x4000796")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<RaycastHit> hits;

		[Token(Token = "0x4000797")]
		[FieldOffset(Offset = "0x10")]
		[WriteOnly]
		public NativeArray<Vector3> points;

		[Token(Token = "0x4000798")]
		[FieldOffset(Offset = "0x20")]
		[WriteOnly]
		public NativeArray<float4> normals;

		[Token(Token = "0x4000799")]
		[FieldOffset(Offset = "0x30")]
		public Slice3D slice;

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x4581BF8", Offset = "0x457DBF8", VA = "0x4581BF8", Slot = "4")]
		public void Execute()
		{
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x4581CB4", Offset = "0x457DCB4", VA = "0x4581CB4", Slot = "5")]
		public void Execute(uint outerIdx, uint innerIdx)
		{
		}
	}
}
