using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	[Token(Token = "0x2000017")]
	[UniqueComponent(tag = "ai")]
	[DisallowMultipleComponent]
	[AddComponentMenu("Pathfinding/AI/AIPath (2D,3D)")]
	public class AIPath : AIBase, IAstarAI
	{
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x1AC")]
		public float maxAcceleration;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x1B0")]
		[FormerlySerializedAs("turningSpeed")]
		public float rotationSpeed;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x1B4")]
		public float slowdownDistance;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x1B8")]
		public float pickNextWaypointDist;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x1BC")]
		public bool alwaysDrawGizmos;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x1BD")]
		public bool slowWhenNotFacingTarget;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x1BE")]
		public bool preventMovingBackwards;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x1BF")]
		public bool constrainInsideGraph;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x1C0")]
		protected Path path;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x1C8")]
		protected PathInterpolator.Cursor interpolator;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x1E8")]
		protected PathInterpolator interpolatorPath;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x1F4")]
		private Vector2 rotationFilterState;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x1FC")]
		private Vector2 rotationFilterState2;

		[Token(Token = "0x1700003E")]
		public float remainingDistance
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x444EB18", Offset = "0x444AB18", VA = "0x444EB18", Slot = "69")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003F")]
		public override bool reachedDestination
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x444EC54", Offset = "0x444AC54", VA = "0x444EC54", Slot = "31")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000040")]
		public bool reachedEndOfPath
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x444EE3C", Offset = "0x444AE3C", VA = "0x444EE3C", Slot = "71")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x444EE44", Offset = "0x444AE44", VA = "0x444EE44")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public bool hasPath
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x444EE50", Offset = "0x444AE50", VA = "0x444EE50", Slot = "81")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000042")]
		public bool pathPending
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x444EE5C", Offset = "0x444AE5C", VA = "0x444EE5C", Slot = "82")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000043")]
		public Vector3 steeringTarget
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x444EE64", Offset = "0x444AE64", VA = "0x444EE64", Slot = "89")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000044")]
		public override Vector3 endOfPath
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x444EEA8", Offset = "0x444AEA8", VA = "0x444EEA8", Slot = "30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000045")]
float IAstarAI.radius
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x444EF14", Offset = "0x444AF14", VA = "0x444EF14", Slot = "56")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_radius();
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x444EF1C", Offset = "0x444AF1C", VA = "0x444EF1C", Slot = "57")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_radius(value);
			}
		}

		[Token(Token = "0x17000046")]
float IAstarAI.height
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x444EF24", Offset = "0x444AF24", VA = "0x444EF24", Slot = "58")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_height();
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x444EF2C", Offset = "0x444AF2C", VA = "0x444EF2C", Slot = "59")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_height(value);
			}
		}

		[Token(Token = "0x17000047")]
float IAstarAI.maxSpeed
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x444EF34", Offset = "0x444AF34", VA = "0x444EF34", Slot = "63")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_maxSpeed();
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x444EF3C", Offset = "0x444AF3C", VA = "0x444EF3C", Slot = "64")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_maxSpeed(value);
			}
		}

		[Token(Token = "0x17000048")]
bool IAstarAI.canSearch
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x444EF44", Offset = "0x444AF44", VA = "0x444EF44", Slot = "75")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_canSearch();
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x444EF68", Offset = "0x444AF68", VA = "0x444EF68", Slot = "76")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_canSearch(value);
			}
		}

		[Token(Token = "0x17000049")]
bool IAstarAI.simulateMovement
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x444EF9C", Offset = "0x444AF9C", VA = "0x444EF9C", Slot = "77")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_simulateMovement();
			}
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x444EFA4", Offset = "0x444AFA4", VA = "0x444EFA4", Slot = "78")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_simulateMovement(value);
			}
		}

		[Token(Token = "0x1700004A")]
NativeMovementPlane IAstarAI.movementPlane
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x444EFB0", Offset = "0x444AFB0", VA = "0x444EFB0", Slot = "92")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_movementPlane();
			}
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x444EB0C", Offset = "0x444AB0C", VA = "0x444EB0C", Slot = "41")]
		public override void Teleport(Vector3 newPosition, bool clearPath = true)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x444EF14", Offset = "0x444AF14", VA = "0x444EF14", Slot = "56")]
		private float Pathfinding_002EIAstarAI_002Eget_radius()
		{
			return default;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x444EF1C", Offset = "0x444AF1C", VA = "0x444EF1C", Slot = "57")]
		private void Pathfinding_002EIAstarAI_002Eset_radius(float value)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x444EF24", Offset = "0x444AF24", VA = "0x444EF24", Slot = "58")]
		private float Pathfinding_002EIAstarAI_002Eget_height()
		{
			return default;
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x444EF2C", Offset = "0x444AF2C", VA = "0x444EF2C", Slot = "59")]
		private void Pathfinding_002EIAstarAI_002Eset_height(float value)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x444EF34", Offset = "0x444AF34", VA = "0x444EF34", Slot = "63")]
		private float Pathfinding_002EIAstarAI_002Eget_maxSpeed()
		{
			return default;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x444EF3C", Offset = "0x444AF3C", VA = "0x444EF3C", Slot = "64")]
		private void Pathfinding_002EIAstarAI_002Eset_maxSpeed(float value)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x444EF44", Offset = "0x444AF44", VA = "0x444EF44", Slot = "75")]
		private bool Pathfinding_002EIAstarAI_002Eget_canSearch()
		{
			return default;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x444EF68", Offset = "0x444AF68", VA = "0x444EF68", Slot = "76")]
		private void Pathfinding_002EIAstarAI_002Eset_canSearch(bool value)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x444EF9C", Offset = "0x444AF9C", VA = "0x444EF9C", Slot = "77")]
		private bool Pathfinding_002EIAstarAI_002Eget_simulateMovement()
		{
			return default;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x444EFA4", Offset = "0x444AFA4", VA = "0x444EFA4", Slot = "78")]
		private void Pathfinding_002EIAstarAI_002Eset_simulateMovement(bool value)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x444EFB0", Offset = "0x444AFB0", VA = "0x444EFB0", Slot = "92")]
		private NativeMovementPlane Pathfinding_002EIAstarAI_002Eget_movementPlane()
		{
			return default;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x444EFF8", Offset = "0x444AFF8", VA = "0x444EFF8", Slot = "93")]
		public void GetRemainingPath(List<Vector3> buffer, out bool stale)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AIPath.GetRemainingPath RVA=0x444EFF8 Token=0x6000125");
}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x444F104", Offset = "0x444B104", VA = "0x444F104", Slot = "94")]
		public void GetRemainingPath(List<Vector3> buffer, List<PathPartWithLinkInfo> partsBuffer, out bool stale)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AIPath.GetRemainingPath RVA=0x444F104 Token=0x6000126");
}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x444F260", Offset = "0x444B260", VA = "0x444F260", Slot = "42")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x444F2C0", Offset = "0x444B2C0", VA = "0x444F2C0", Slot = "101")]
		public virtual void OnTargetReached()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x444F2C4", Offset = "0x444B2C4", VA = "0x444F2C4", Slot = "102")]
		protected virtual void UpdateMovementPlane()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x444F608", Offset = "0x444B608", VA = "0x444F608", Slot = "48")]
		protected override void OnPathComplete(Path newPath)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x444F964", Offset = "0x444B964", VA = "0x444F964", Slot = "49")]
		protected override void ClearPath()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x444F9B0", Offset = "0x444B9B0", VA = "0x444F9B0", Slot = "44")]
		protected override void MovementUpdateInternal(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AIPath.MovementUpdateInternal RVA=0x444F9B0 Token=0x600012C");
}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x445020C", Offset = "0x444C20C", VA = "0x445020C", Slot = "103")]
		protected virtual void CalculateNextRotation(float slowdown, bool avoidingOtherAgents, out Quaternion nextRotation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AIPath.CalculateNextRotation RVA=0x445020C Token=0x600012D");
}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x44502DC", Offset = "0x444C2DC", VA = "0x44502DC", Slot = "54")]
		protected override Vector3 ClampToNavmesh(Vector3 position, out bool positionChanged)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AIPath.ClampToNavmesh RVA=0x44502DC Token=0x600012E");
}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x44505E0", Offset = "0x444C5E0", VA = "0x44505E0", Slot = "14")]
		protected override void OnUpgradeSerializedData(ref Migrations migrations, bool unityThread)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x444900C", Offset = "0x444500C", VA = "0x444900C")]
		public AIPath()
		{
		}
	}
}
