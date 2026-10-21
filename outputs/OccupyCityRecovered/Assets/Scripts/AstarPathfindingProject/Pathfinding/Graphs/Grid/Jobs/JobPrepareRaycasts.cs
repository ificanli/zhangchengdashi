using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x2000231")]
	[BurstCompile]
	public struct JobPrepareRaycasts : IJob
	{
		[Token(Token = "0x4000A6F")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 direction;

		[Token(Token = "0x4000A70")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 originOffset;

		[Token(Token = "0x4000A71")]
		[FieldOffset(Offset = "0x18")]
		public float distance;

		[Token(Token = "0x4000A72")]
		[FieldOffset(Offset = "0x1C")]
		public LayerMask mask;

		[Token(Token = "0x4000A73")]
		[FieldOffset(Offset = "0x20")]
		public PhysicsScene physicsScene;

		[Token(Token = "0x4000A74")]
		[FieldOffset(Offset = "0x28")]
		[ReadOnly]
		public NativeArray<Vector3> origins;

		[Token(Token = "0x4000A75")]
		[FieldOffset(Offset = "0x38")]
		[WriteOnly]
		public NativeArray<RaycastCommand> raycastCommands;

		[Token(Token = "0x6000E18")]
		[Address(RVA = "0x447CC10", Offset = "0x4478C10", VA = "0x447CC10", Slot = "4")]
		public void Execute()
		{
 var normalizedDirection = direction.normalized;
 var commands = Pathfinding.Collections.SpanExtensions.AsUnsafeSpan(raycastCommands);
 var query = new QueryParameters(mask, false, QueryTriggerInteraction.Ignore, false);
 var template = new RaycastCommand(physicsScene, Vector3.zero, normalizedDirection, query, distance);
 Pathfinding.Collections.SpanExtensions.Fill(commands, template);
 for (int i = 0; i < raycastCommands.Length; i++)
  commands[i].from = origins[i] + originOffset;
}
	}
}
