using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.RVO;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Serialization;

namespace Pathfinding
{
	[Token(Token = "0x2000015")]
	[RequireComponent(typeof(Seeker))]
	public abstract class AIBase : VersionedMonoBehaviour
	{
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x28")]
		public float radius;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x2C")]
		public float height;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("canMove")]
		public bool simulateMovement;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x34")]
		[FormerlySerializedAs("speed")]
		public float maxSpeed;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 gravity;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x44")]
		public LayerMask groundMask;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x48")]
		public float endReachedDistance;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x4C")]
		public CloseToDestinationMode whenCloseToDestination;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x50")]
		public RVODestinationCrowdedBehavior rvoDensityBehavior;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x8C")]
		[FormerlySerializedAs("repathRate")]
		[HideInInspector]
		[SerializeField]
		private float repathRateCompatibility;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x90")]
		[HideInInspector]
		[SerializeField]
		[FormerlySerializedAs("repeatedlySearchPaths")]
		[FormerlySerializedAs("canSearch")]
		private bool canSearchCompability;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x91")]
		[FormerlySerializedAs("rotationIn2D")]
		public OrientationMode orientation;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x92")]
		public bool enableRotation;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x94")]
		protected Vector3 simulatedPosition;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0xA0")]
		protected Quaternion simulatedRotation;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0xB0")]
		protected Vector3 accumulatedMovementDelta;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0xBC")]
		protected Vector2 velocity2D;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0xC4")]
		protected float verticalVelocity;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0xC8")]
		protected Seeker seeker;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0xD0")]
		protected Transform tr;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0xD8")]
		protected Rigidbody rigid;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0xE0")]
		protected Rigidbody2D rigid2D;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0xE8")]
		protected CharacterController controller;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0xF0")]
		protected RVOController rvoController;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0xF8")]
		public SimpleMovementPlane movementPlane;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x120")]
		public AutoRepathPolicy autoRepath;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x12C")]
		protected float lastDeltaTime;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x130")]
		protected Vector3 prevPosition1;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x13C")]
		protected Vector3 prevPosition2;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x148")]
		protected Vector2 lastDeltaPosition;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x150")]
		protected bool waitingForPathCalculation;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x154")]
		protected float lastRepath;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x158")]
		protected bool startHasRun;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x15C")]
		private Vector3 destinationBackingField;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x178")]
		protected OnPathDelegate onPathComplete;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x180")]
		protected RaycastHit lastRaycastHit;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Color ShapeGizmoColor;

		[Token(Token = "0x17000012")]
		public float repathRate
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x44499A8", Offset = "0x44459A8", VA = "0x44499A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x44499C4", Offset = "0x44459C4", VA = "0x44499C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public bool canSearch
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x44499E0", Offset = "0x44459E0", VA = "0x44499E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x4449A04", Offset = "0x4445A04", VA = "0x4449A04")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		[Obsolete("Renamed to simulateMovement")]
		public bool canMove
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x4449A38", Offset = "0x4445A38", VA = "0x4449A38", Slot = "15")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x4449A40", Offset = "0x4445A40", VA = "0x4449A40", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Vector3 position
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x4449A4C", Offset = "0x4445A4C", VA = "0x4449A4C", Slot = "17")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000016")]
		public virtual Quaternion rotation
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x4449A80", Offset = "0x4445A80", VA = "0x4449A80", Slot = "18")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x4449AB4", Offset = "0x4445AB4", VA = "0x4449AB4", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public bool updatePosition
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x4449AE8", Offset = "0x4445AE8", VA = "0x4449AE8", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x4449AF0", Offset = "0x4445AF0", VA = "0x4449AF0", Slot = "21")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public bool updateRotation
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x4449AFC", Offset = "0x4445AFC", VA = "0x4449AFC", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x4449B04", Offset = "0x4445B04", VA = "0x4449B04", Slot = "23")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		protected bool usingGravity
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x4449B10", Offset = "0x4445B10", VA = "0x4449B10")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x4449B18", Offset = "0x4445B18", VA = "0x4449B18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Vector3 destination
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x4449B24", Offset = "0x4445B24", VA = "0x4449B24", Slot = "24")]
			get
			{
				return default;
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x4449B34", Offset = "0x4445B34", VA = "0x4449B34", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Vector3 velocity
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x4449C14", Offset = "0x4445C14", VA = "0x4449C14", Slot = "26")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001C")]
		public Vector3 desiredVelocity
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x4449C9C", Offset = "0x4445C9C", VA = "0x4449C9C", Slot = "27")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001D")]
		public Vector3 desiredVelocityWithoutLocalAvoidance
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x4449D88", Offset = "0x4445D88", VA = "0x4449D88", Slot = "28")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x4449E04", Offset = "0x4445E04", VA = "0x4449E04", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public abstract Vector3 endOfPath
		{
			[Token(Token = "0x60000A1")]
			get;
		}

		[Token(Token = "0x1700001F")]
		public abstract bool reachedDestination
		{
			[Token(Token = "0x60000A2")]
			get;
		}

		[Token(Token = "0x17000020")]
		public bool isStopped
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x4449E90", Offset = "0x4445E90", VA = "0x4449E90", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x4449E98", Offset = "0x4445E98", VA = "0x4449E98", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Action onSearchPath
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x4449EA4", Offset = "0x4445EA4", VA = "0x4449EA4", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x4449EAC", Offset = "0x4445EAC", VA = "0x4449EAC", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		protected virtual bool shouldRecalculatePath
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x4449EB4", Offset = "0x4445EB4", VA = "0x4449EB4", Slot = "36")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x4449F74", Offset = "0x4445F74", VA = "0x4449F74", Slot = "37")]
		public virtual void FindComponents()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x444816C", Offset = "0x444416C", VA = "0x444816C", Slot = "38")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x444A1DC", Offset = "0x44461DC", VA = "0x444A1DC")]
		private static void OnUpdate(AIBase[] components, int count, TransformAccessArray transforms, BatchedEvents.Event ev)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x444A77C", Offset = "0x444677C", VA = "0x444A77C", Slot = "39")]
		protected virtual void OnUpdate(float dt)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x444A9B8", Offset = "0x44469B8", VA = "0x444A9B8", Slot = "40")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x444A154", Offset = "0x4446154", VA = "0x444A154")]
		private void Init()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x444A9C4", Offset = "0x44469C4", VA = "0x444A9C4", Slot = "41")]
		public virtual void Teleport(Vector3 newPosition, bool clearPath = true)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x444AB2C", Offset = "0x4446B2C", VA = "0x444AB2C")]
		protected void CancelCurrentPathRequest()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x444ABB8", Offset = "0x4446BB8", VA = "0x444ABB8", Slot = "42")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x444A9A4", Offset = "0x44469A4", VA = "0x444A9A4", Slot = "43")]
		public void MovementUpdate(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AIBase.MovementUpdate RVA=0x444A9A4 Token=0x60000B1");
}

		[Token(Token = "0x60000B2")]
		protected abstract void MovementUpdateInternal(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation);

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x444AC90", Offset = "0x4446C90", VA = "0x444AC90", Slot = "45")]
		protected virtual void CalculatePathRequestEndpoints(out Vector3 start, out Vector3 end)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AIBase.CalculatePathRequestEndpoints RVA=0x444AC90 Token=0x60000B3");
}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x444ACE0", Offset = "0x4446CE0", VA = "0x444ACE0", Slot = "46")]
		public virtual void SearchPath()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x444AF80", Offset = "0x4446F80", VA = "0x444AF80", Slot = "47")]
		public virtual Vector3 GetFeetPosition()
		{
			return default;
		}

		[Token(Token = "0x60000B6")]
		protected abstract void OnPathComplete(Path newPath);

		[Token(Token = "0x60000B7")]
		protected abstract void ClearPath();

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x444AD7C", Offset = "0x4446D7C", VA = "0x444AD7C", Slot = "50")]
		public void SetPath(Path path, bool updateDestinationFromPath = true)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x444AF84", Offset = "0x4446F84", VA = "0x444AF84", Slot = "51")]
		protected virtual void ApplyGravity(float deltaTime)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x444B09C", Offset = "0x444709C", VA = "0x444B09C")]
		protected Vector2 CalculateDeltaToMoveThisFrame(Vector3 position, float distanceToEndOfPath, float deltaTime)
		{
			return default;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x444B240", Offset = "0x4447240", VA = "0x444B240")]
		public Quaternion SimulateRotationTowards(Vector3 direction, float maxDegrees)
		{
			return default;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x444B2D4", Offset = "0x44472D4", VA = "0x444B2D4")]
		protected Quaternion SimulateRotationTowards(Vector2 direction, float maxDegreesMainAxis, float maxDegreesOffAxis = float.PositiveInfinity)
		{
			return default;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x444B918", Offset = "0x4447918", VA = "0x444B918", Slot = "52")]
		public virtual void Move(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x444B938", Offset = "0x4447938", VA = "0x444B938", Slot = "53")]
		public virtual void FinalizeMovement(Vector3 nextPosition, Quaternion nextRotation)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x444B994", Offset = "0x4447994", VA = "0x444B994")]
		private void FinalizeRotation(Quaternion nextRotation)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x444BB14", Offset = "0x4447B14", VA = "0x444BB14")]
		private void FinalizePosition(Vector3 nextPosition)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x444C07C", Offset = "0x444807C", VA = "0x444C07C")]
		protected void UpdateVelocity()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x444C0BC", Offset = "0x44480BC", VA = "0x444C0BC", Slot = "54")]
		protected virtual Vector3 ClampToNavmesh(Vector3 position, out bool positionChanged)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AIBase.ClampToNavmesh RVA=0x444C0BC Token=0x60000C2");
}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x444BE4C", Offset = "0x4447E4C", VA = "0x444BE4C")]
		protected Vector3 RaycastPosition(Vector3 position, float lastElevation)
		{
			return default;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x444C0C4", Offset = "0x44480C4", VA = "0x444C0C4", Slot = "55")]
		protected virtual void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x444C13C", Offset = "0x444813C", VA = "0x444C13C", Slot = "6")]
		public override void DrawGizmos()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x444C5AC", Offset = "0x44485AC", VA = "0x444C5AC", Slot = "13")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x444C5C8", Offset = "0x44485C8", VA = "0x444C5C8")]
		private void ResetShape()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x444C664", Offset = "0x4448664", VA = "0x444C664", Slot = "14")]
		protected override void OnUpgradeSerializedData(ref Migrations migrations, bool unityThread)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x444C6EC", Offset = "0x44486EC", VA = "0x444C6EC")]
		protected AIBase()
		{
		}
	}
}
