using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x2000232")]
	[BurstCompile]
	public struct JobPrepareSphereCommands : IJob
	{
		[Token(Token = "0x4000A76")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 originOffset;

		[Token(Token = "0x4000A77")]
		[FieldOffset(Offset = "0xC")]
		public float radius;

		[Token(Token = "0x4000A78")]
		[FieldOffset(Offset = "0x10")]
		public LayerMask mask;

		[Token(Token = "0x4000A79")]
		[FieldOffset(Offset = "0x14")]
		public PhysicsScene physicsScene;

		[Token(Token = "0x4000A7A")]
		[FieldOffset(Offset = "0x18")]
		[ReadOnly]
		public NativeArray<Vector3> origins;

		[Token(Token = "0x4000A7B")]
		[FieldOffset(Offset = "0x28")]
		[WriteOnly]
		public NativeArray<OverlapSphereCommand> commands;

		[Token(Token = "0x6000E19")]
		[Address(RVA = "0x447CEE8", Offset = "0x4478EE8", VA = "0x447CEE8", Slot = "4")]
		public void Execute()
		{
		}
	}
}
