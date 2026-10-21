using System;
using Il2CppDummyDll;
using Pathfinding.Jobs;
using Pathfinding.Util;
using Unity.Collections;
using UnityEngine;

namespace Pathfinding.Graphs.Grid
{
	[Serializable]
	[Token(Token = "0x2000200")]
	public class GraphCollision
	{
		[Token(Token = "0x4000994")]
		[FieldOffset(Offset = "0x10")]
		public ColliderType type = ColliderType.Capsule;

		[Token(Token = "0x4000995")]
		[FieldOffset(Offset = "0x14")]
		public float diameter = 1f;

		[Token(Token = "0x4000996")]
		[FieldOffset(Offset = "0x18")]
		public float height = 2f;

		[Token(Token = "0x4000997")]
		[FieldOffset(Offset = "0x1C")]
		public float collisionOffset;

		[Token(Token = "0x4000998")]
		[FieldOffset(Offset = "0x20")]
		[Obsolete("Only the Both mode is supported now")]
		public RayDirection rayDirection = RayDirection.Both;

		[Token(Token = "0x4000999")]
		[FieldOffset(Offset = "0x24")]
		public LayerMask mask;

		[Token(Token = "0x400099A")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask heightMask = -1;

		[Token(Token = "0x400099B")]
		[FieldOffset(Offset = "0x2C")]
		public float fromHeight = 100f;

		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x30")]
		public bool thickRaycast;

		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0x34")]
		public float thickRaycastDiameter = 1f;

		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0x38")]
		public bool unwalkableWhenNoGround = true;

		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0x39")]
		public bool use2D;

		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x3A")]
		public bool collisionCheck = true;

		[Token(Token = "0x40009A1")]
		[FieldOffset(Offset = "0x3B")]
		public bool heightCheck = true;

		[Token(Token = "0x40009A2")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 up;

		[Token(Token = "0x40009A3")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 upheight;

		[Token(Token = "0x40009A4")]
		[FieldOffset(Offset = "0x54")]
		private ContactFilter2D contactFilter;

		[Token(Token = "0x40009A5")]
		[FieldOffset(Offset = "0x0")]
		private static Collider2D[] dummyArray = new Collider2D[1];

		[Token(Token = "0x40009A6")]
		[FieldOffset(Offset = "0x70")]
		private float finalRadius;

		[Token(Token = "0x40009A7")]
		[FieldOffset(Offset = "0x74")]
		private float finalRaycastRadius;

		[Token(Token = "0x40009A8")]
		public const float RaycastErrorMargin = 0.005f;

		[Token(Token = "0x40009A9")]
		[FieldOffset(Offset = "0x78")]
		private RaycastHit[] hitBuffer = new RaycastHit[8];

		[Token(Token = "0x6000D89")]
		[Address(RVA = "0x4472424", Offset = "0x446E424", VA = "0x4472424")]
		public void Initialize(GraphTransform transform, float scale)
		{
 up = (transform.Transform(Vector3.up) - transform.Transform(Vector3.zero)).normalized;
 upheight = up * height;
 finalRadius = (diameter * scale) * 0.5f;
 finalRaycastRadius = (thickRaycastDiameter * scale) * 0.5f;
 contactFilter = new ContactFilter2D { useLayerMask = true, layerMask = mask };
}

		[Token(Token = "0x6000D8A")]
		[Address(RVA = "0x4472608", Offset = "0x446E608", VA = "0x4472608")]
		public bool Check(Vector3 position)
		{
 if (!collisionCheck) return true;
 if (use2D) {
  if (unchecked((uint)type)<=1u) return Physics2D.OverlapCircle(position,finalRadius,contactFilter,dummyArray)==0;
  return Physics2D.OverlapPoint(position,contactFilter,dummyArray)==0;
 }
 position += up * collisionOffset;
 if (type==ColliderType.Sphere) return !Physics.CheckSphere(position,finalRadius,mask,QueryTriggerInteraction.Ignore);
 if (type==ColliderType.Capsule) return !Physics.CheckCapsule(position,position+upheight,finalRadius,mask,QueryTriggerInteraction.Ignore);
 return !Physics.Raycast(position,up,height,mask,QueryTriggerInteraction.Ignore)
     && !Physics.Raycast(position+upheight,-up,height,mask,QueryTriggerInteraction.Ignore);
}

		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x447299C", Offset = "0x446E99C", VA = "0x447299C")]
		public Vector3 CheckHeight(Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x44729CC", Offset = "0x446E9CC", VA = "0x44729CC")]
		public Vector3 CheckHeight(Vector3 position, out RaycastHit hit, out bool walkable)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GraphCollision.CheckHeight RVA=0x44729CC Token=0x6000D8C");
}

		[Token(Token = "0x6000D8D")]
		[Address(RVA = "0x4472CE0", Offset = "0x446ECE0", VA = "0x4472CE0")]
		public RaycastHit[] CheckHeightAll(Vector3 position, out int numHits)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GraphCollision.CheckHeightAll RVA=0x4472CE0 Token=0x6000D8D");
}

		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x4472EEC", Offset = "0x446EEEC", VA = "0x4472EEC")]
		public void JobCollisionRay(NativeArray<Vector3> nodePositions, NativeArray<bool> collisionCheckResult, Vector3 up, Allocator allocationMethod, JobDependencyTracker dependencyTracker)
		{
 var commandsDown=dependencyTracker.NewNativeArray<RaycastCommand>(nodePositions.Length,allocationMethod,NativeArrayOptions.ClearMemory);
 var commandsUp=dependencyTracker.NewNativeArray<RaycastCommand>(nodePositions.Length,allocationMethod,NativeArrayOptions.ClearMemory);
 var hitsDown=dependencyTracker.NewNativeArray<RaycastHit>(nodePositions.Length,allocationMethod,NativeArrayOptions.ClearMemory);
 var hitsUp=dependencyTracker.NewNativeArray<RaycastHit>(nodePositions.Length,allocationMethod,NativeArrayOptions.ClearMemory);
 new Pathfinding.Graphs.Grid.Jobs.JobPrepareRaycasts { direction=-up,originOffset=up*(height+collisionOffset),distance=height,mask=mask,physicsScene=Physics.defaultPhysicsScene,origins=nodePositions,raycastCommands=commandsDown }.Schedule(dependencyTracker);
 new Pathfinding.Graphs.Grid.Jobs.JobPrepareRaycasts { direction=up,originOffset=up*collisionOffset,distance=height,mask=mask,physicsScene=Physics.defaultPhysicsScene,origins=nodePositions,raycastCommands=commandsUp }.Schedule(dependencyTracker);
 dependencyTracker.ScheduleBatch(commandsDown,hitsDown,2048);
 dependencyTracker.ScheduleBatch(commandsUp,hitsUp,2048);
 new Pathfinding.Graphs.Grid.Jobs.JobMergeRaycastCollisionHits { hit1=hitsDown,hit2=hitsUp,result=collisionCheckResult }.Schedule(dependencyTracker);
}

		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0x44731A4", Offset = "0x446F1A4", VA = "0x44731A4")]
		public void JobCollisionCapsule(NativeArray<Vector3> nodePositions, NativeArray<bool> collisionCheckResult, Vector3 up, Allocator allocationMethod, JobDependencyTracker dependencyTracker)
		{
		}

		[Token(Token = "0x6000D90")]
		[Address(RVA = "0x447338C", Offset = "0x446F38C", VA = "0x447338C")]
		public void JobCollisionSphere(NativeArray<Vector3> nodePositions, NativeArray<bool> collisionCheckResult, Vector3 up, Allocator allocationMethod, JobDependencyTracker dependencyTracker)
		{
		}

		[Token(Token = "0x6000D91")]
		[Address(RVA = "0x4473554", Offset = "0x446F554", VA = "0x4473554")]
		public GraphCollision()
		{}
	}
}
