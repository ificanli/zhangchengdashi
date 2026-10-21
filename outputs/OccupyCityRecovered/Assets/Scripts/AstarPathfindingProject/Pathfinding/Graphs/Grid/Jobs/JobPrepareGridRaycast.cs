using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x200022F")]
	[BurstCompile]
	public struct JobPrepareGridRaycast : IJob
	{
		[Token(Token = "0x4000A60")]
		[FieldOffset(Offset = "0x0")]
		public Matrix4x4 graphToWorld;

		[Token(Token = "0x4000A61")]
		[FieldOffset(Offset = "0x40")]
		public IntBounds bounds;

		[Token(Token = "0x4000A62")]
		[FieldOffset(Offset = "0x58")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000A63")]
		[FieldOffset(Offset = "0x64")]
		public Vector3 raycastDirection;

		[Token(Token = "0x4000A64")]
		[FieldOffset(Offset = "0x70")]
		public LayerMask raycastMask;

		[Token(Token = "0x4000A65")]
		[FieldOffset(Offset = "0x74")]
		public PhysicsScene physicsScene;

		[Token(Token = "0x4000A66")]
		[FieldOffset(Offset = "0x78")]
		[WriteOnly]
		public NativeArray<RaycastCommand> raycastCommands;

		[Token(Token = "0x6000E16")]
		[Address(RVA = "0x447C424", Offset = "0x4478424", VA = "0x447C424", Slot = "4")]
		public void Execute()
		{
 var size=bounds.size;
 var commands=Pathfinding.Collections.SpanExtensions.AsUnsafeSpan(raycastCommands);
 var template=new RaycastCommand(physicsScene,Vector3.zero,raycastDirection.normalized,new QueryParameters(raycastMask,false,QueryTriggerInteraction.Ignore,false),raycastDirection.magnitude);
 Pathfinding.Collections.SpanExtensions.Fill(commands,template);
 for (int z=0;z<size.z;z++) for (int x=0;x<size.x;x++) commands[unchecked(x+z*size.x)].from=JobNodeGridLayout.NodePosition(graphToWorld,unchecked(bounds.min.x+x),unchecked(bounds.min.z+z),0f)+raycastOffset;
}
	}
}
