using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x200022E")]
	[BurstCompile]
	public struct JobPrepareCapsuleCommands : IJob
	{
		[Token(Token = "0x4000A59")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 direction;

		[Token(Token = "0x4000A5A")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 originOffset;

		[Token(Token = "0x4000A5B")]
		[FieldOffset(Offset = "0x18")]
		public float radius;

		[Token(Token = "0x4000A5C")]
		[FieldOffset(Offset = "0x1C")]
		public LayerMask mask;

		[Token(Token = "0x4000A5D")]
		[FieldOffset(Offset = "0x20")]
		public PhysicsScene physicsScene;

		[Token(Token = "0x4000A5E")]
		[FieldOffset(Offset = "0x28")]
		[ReadOnly]
		public NativeArray<Vector3> origins;

		[Token(Token = "0x4000A5F")]
		[FieldOffset(Offset = "0x38")]
		[WriteOnly]
		public NativeArray<OverlapCapsuleCommand> commands;

		[Token(Token = "0x6000E15")]
		[Address(RVA = "0x447C18C", Offset = "0x447818C", VA = "0x447C18C", Slot = "4")]
		public void Execute()
		{
		}
	}
}
