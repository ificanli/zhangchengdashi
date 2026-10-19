using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x2000235")]
	[BurstCompile]
	public struct JobRelocateNodes : IJob, GridIterationUtilities.ICellAction
	{
		[Token(Token = "0x4000A8C")]
		[FieldOffset(Offset = "0x0")]
		public Matrix4x4 previousWorldToGraph;

		[Token(Token = "0x4000A8D")]
		[FieldOffset(Offset = "0x40")]
		public Matrix4x4 graphToWorld;

		[Token(Token = "0x4000A8E")]
		[FieldOffset(Offset = "0x80")]
		public NativeArray<Vector3> positions;

		[Token(Token = "0x4000A8F")]
		[FieldOffset(Offset = "0x90")]
		public IntBounds bounds;

		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x447D46C", Offset = "0x447946C", VA = "0x447D46C", Slot = "4")]
		public void Execute()
		{
		}

		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x447D4C4", Offset = "0x44794C4", VA = "0x447D4C4", Slot = "5")]
		public void Execute(uint innerIndex, int x, int y, int z)
		{
		}
	}
}
