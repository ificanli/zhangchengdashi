using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Burst;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh.Jobs
{
	[Token(Token = "0x20001FE")]
	[BurstCompile(FloatMode = FloatMode.Fast)]
	public struct JobTransformTileCoordinates : IJob
	{
		[Token(Token = "0x4000990")]
		[FieldOffset(Offset = "0x0")]
		public UnsafeSpan<Int3> vertices;

		[Token(Token = "0x4000991")]
		[FieldOffset(Offset = "0x10")]
		public Matrix4x4 matrix;

		[Token(Token = "0x6000D86")]
		[Address(RVA = "0x4470C24", Offset = "0x446CC24", VA = "0x4470C24", Slot = "4")]
		public void Execute()
		{
		}
	}
}
