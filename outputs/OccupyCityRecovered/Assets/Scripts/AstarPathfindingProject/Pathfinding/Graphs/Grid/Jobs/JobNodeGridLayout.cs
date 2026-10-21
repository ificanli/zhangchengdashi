using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x200022C")]
	[BurstCompile(FloatMode = FloatMode.Fast)]
	public struct JobNodeGridLayout : IJob, GridIterationUtilities.ICellAction
	{
		[Token(Token = "0x4000A4D")]
		[FieldOffset(Offset = "0x0")]
		public Matrix4x4 graphToWorld;

		[Token(Token = "0x4000A4E")]
		[FieldOffset(Offset = "0x40")]
		public IntBounds bounds;

		[Token(Token = "0x4000A4F")]
		[FieldOffset(Offset = "0x58")]
		[WriteOnly]
		public NativeArray<Vector3> nodePositions;

		[Token(Token = "0x6000E11")]
		[Address(RVA = "0x447BEA4", Offset = "0x4477EA4", VA = "0x447BEA4")]
		public static Vector3 NodePosition(Matrix4x4 graphToWorld, int x, int z, float height = 0f)
		{
 return graphToWorld.MultiplyPoint3x4(new Vector3((float)x+0.5f,height,(float)z+0.5f));
}

		[Token(Token = "0x6000E12")]
		[Address(RVA = "0x447BEC4", Offset = "0x4477EC4", VA = "0x447BEC4", Slot = "4")]
		public void Execute()
		{ GridIterationUtilities.ForEachCellIn3DArray(bounds.size, ref this); }

		[Token(Token = "0x6000E13")]
		[Address(RVA = "0x447BF1C", Offset = "0x4477F1C", VA = "0x447BF1C", Slot = "5")]
		public void Execute(uint innerIndex, int x, int y, int z)
		{ nodePositions[unchecked((int)innerIndex)]=NodePosition(graphToWorld,unchecked(bounds.min.x+x),unchecked(bounds.min.z+z),0f); }
	}
}
