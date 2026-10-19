using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x2000230")]
	[BurstCompile]
	public struct JobPrepareGridRaycastThick : IJob
	{
		[Token(Token = "0x4000A67")]
		[FieldOffset(Offset = "0x0")]
		public Matrix4x4 graphToWorld;

		[Token(Token = "0x4000A68")]
		[FieldOffset(Offset = "0x40")]
		public IntBounds bounds;

		[Token(Token = "0x4000A69")]
		[FieldOffset(Offset = "0x58")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000A6A")]
		[FieldOffset(Offset = "0x64")]
		public Vector3 raycastDirection;

		[Token(Token = "0x4000A6B")]
		[FieldOffset(Offset = "0x70")]
		public LayerMask raycastMask;

		[Token(Token = "0x4000A6C")]
		[FieldOffset(Offset = "0x74")]
		public PhysicsScene physicsScene;

		[Token(Token = "0x4000A6D")]
		[FieldOffset(Offset = "0x78")]
		public float radius;

		[Token(Token = "0x4000A6E")]
		[FieldOffset(Offset = "0x80")]
		[WriteOnly]
		public NativeArray<SpherecastCommand> raycastCommands;

		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x447C7D8", Offset = "0x44787D8", VA = "0x447C7D8", Slot = "4")]
		public void Execute()
		{
		}
	}
}
