using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	[Token(Token = "0x2000016")]
	[RequireComponent(typeof(Seeker))]
	[AddComponentMenu("Pathfinding/AI/AILerp (2D,3D)")]
	[UniqueComponent(tag = "ai")]
	[DisallowMultipleComponent]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/ailerp.html")]
	public class AILerp : VersionedMonoBehaviour, IAstarAI
	{
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x28")]
		public AutoRepathPolicy autoRepath;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("canMove")]
		public bool simulateMovement;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x34")]
		public float speed;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("rotationIn2D")]
		public OrientationMode orientation;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x39")]
		public bool enableRotation;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x3C")]
		public float rotationSpeed;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x40")]
		public bool interpolatePathSwitches;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x44")]
		public float switchPathInterpolationSpeed;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x60")]
		protected OnPathDelegate onPathComplete;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x78")]
		protected Seeker seeker;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x80")]
		protected Transform tr;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x88")]
		protected ABPath path;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x90")]
		protected bool canSearchAgain;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x94")]
		protected Vector3 previousMovementOrigin;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xA0")]
		protected Vector3 previousMovementDirection;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0xAC")]
		protected float pathSwitchInterpolationTime;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0xB0")]
		protected PathInterpolator.Cursor interpolator;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0xD0")]
		protected PathInterpolator interpolatorPath;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0xD8")]
		private bool startHasRun;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 previousPosition1;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 previousPosition2;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0xF4")]
		private Vector3 simulatedPosition;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x100")]
		private Quaternion simulatedRotation;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x110")]
		[HideInInspector]
		[FormerlySerializedAs("repathRate")]
		[SerializeField]
		private float repathRateCompatibility;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x114")]
		[FormerlySerializedAs("canSearch")]
		[HideInInspector]
		[SerializeField]
		private bool canSearchCompability;

		[Token(Token = "0x17000023")]
		public float repathRate
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x444C8F4", Offset = "0x44488F4", VA = "0x444C8F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x444C910", Offset = "0x4448910", VA = "0x444C910")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public bool canSearch
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x444C92C", Offset = "0x444892C", VA = "0x444C92C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x444C950", Offset = "0x4448950", VA = "0x444C950")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		[Obsolete("Renamed to simulateMovement")]
		public bool canMove
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x444C970", Offset = "0x4448970", VA = "0x444C970", Slot = "38")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x444C978", Offset = "0x4448978", VA = "0x444C978", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public bool reachedEndOfPath
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x444C984", Offset = "0x4448984", VA = "0x444C984", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x444C98C", Offset = "0x444898C", VA = "0x444C98C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public bool reachedDestination
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x444C998", Offset = "0x4448998", VA = "0x444C998", Slot = "29")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000028")]
		public Vector3 destination
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x444CAD4", Offset = "0x4448AD4", VA = "0x444CAD4", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x444CAE0", Offset = "0x4448AE0", VA = "0x444CAE0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public NativeMovementPlane movementPlane
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x444CAEC", Offset = "0x4448AEC", VA = "0x444CAEC", Slot = "51")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002A")]
		public bool updatePosition
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x444CCA8", Offset = "0x4448CA8", VA = "0x444CCA8", Slot = "42")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x444CCB0", Offset = "0x4448CB0", VA = "0x444CCB0", Slot = "43")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public bool updateRotation
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x444CCBC", Offset = "0x4448CBC", VA = "0x444CCBC", Slot = "44")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x444CCC4", Offset = "0x4448CC4", VA = "0x444CCC4", Slot = "45")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public Vector3 position
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x444CCD0", Offset = "0x4448CD0", VA = "0x444CCD0", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002D")]
		public Quaternion rotation
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x444CD04", Offset = "0x4448D04", VA = "0x444CD04", Slot = "20")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x444CD40", Offset = "0x4448D40", VA = "0x444CD40", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public Vector3 endOfPath
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x444CD7C", Offset = "0x4448D7C", VA = "0x444CD7C", Slot = "31")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002F")]
float IAstarAI.radius
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x444CDE8", Offset = "0x4448DE8", VA = "0x444CDE8", Slot = "15")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_radius();
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x444CDF0", Offset = "0x4448DF0", VA = "0x444CDF0", Slot = "16")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_radius(value);
			}
		}

		[Token(Token = "0x17000030")]
float IAstarAI.height
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x444CDF4", Offset = "0x4448DF4", VA = "0x444CDF4", Slot = "17")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_height();
			}
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x444CDFC", Offset = "0x4448DFC", VA = "0x444CDFC", Slot = "18")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_height(value);
			}
		}

		[Token(Token = "0x17000031")]
float IAstarAI.maxSpeed
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x444CE00", Offset = "0x4448E00", VA = "0x444CE00", Slot = "22")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_maxSpeed();
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x444CE08", Offset = "0x4448E08", VA = "0x444CE08", Slot = "23")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_maxSpeed(value);
			}
		}

		[Token(Token = "0x17000032")]
bool IAstarAI.canSearch
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x444CE10", Offset = "0x4448E10", VA = "0x444CE10", Slot = "34")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_canSearch();
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x444CE34", Offset = "0x4448E34", VA = "0x444CE34", Slot = "35")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_canSearch(value);
			}
		}

		[Token(Token = "0x17000033")]
bool IAstarAI.simulateMovement
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x444CE54", Offset = "0x4448E54", VA = "0x444CE54", Slot = "36")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_simulateMovement();
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x444CE5C", Offset = "0x4448E5C", VA = "0x444CE5C", Slot = "37")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_simulateMovement(value);
			}
		}

		[Token(Token = "0x17000034")]
		public Vector3 velocity
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x444CE68", Offset = "0x4448E68", VA = "0x444CE68", Slot = "24")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000035")]
Vector3 IAstarAI.desiredVelocity
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x444CF08", Offset = "0x4448F08", VA = "0x444CF08", Slot = "25")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_desiredVelocity();
			}
		}

		[Token(Token = "0x17000036")]
Vector3 IAstarAI.desiredVelocityWithoutLocalAvoidance
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x444CFA0", Offset = "0x4448FA0", VA = "0x444CFA0", Slot = "26")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_desiredVelocityWithoutLocalAvoidance();
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x444D038", Offset = "0x4449038", VA = "0x444D038", Slot = "27")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_desiredVelocityWithoutLocalAvoidance(value);
			}
		}

		[Token(Token = "0x17000037")]
Vector3 IAstarAI.steeringTarget
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x444D084", Offset = "0x4449084", VA = "0x444D084", Slot = "48")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_steeringTarget();
			}
		}

		[Token(Token = "0x17000038")]
		public float remainingDistance
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x444CA94", Offset = "0x4448A94", VA = "0x444CA94", Slot = "28")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x444D0FC", Offset = "0x44490FC", VA = "0x444D0FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public bool hasPath
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x444D180", Offset = "0x4449180", VA = "0x444D180", Slot = "40")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003A")]
		public bool pathPending
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x444D18C", Offset = "0x444918C", VA = "0x444D18C", Slot = "41")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003B")]
		public bool isStopped
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x444D19C", Offset = "0x444919C", VA = "0x444D19C", Slot = "46")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x444D1A4", Offset = "0x44491A4", VA = "0x444D1A4", Slot = "47")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public Action onSearchPath
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x444D1B0", Offset = "0x44491B0", VA = "0x444D1B0", Slot = "49")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x444D1B8", Offset = "0x44491B8", VA = "0x444D1B8", Slot = "50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		protected virtual bool shouldRecalculatePath
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x444D7B0", Offset = "0x44497B0", VA = "0x444D7B0", Slot = "62")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x444CDE4", Offset = "0x4448DE4", VA = "0x444CDE4", Slot = "57")]
void IAstarAI.Move(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x444CDE8", Offset = "0x4448DE8", VA = "0x444CDE8", Slot = "15")]
		private float Pathfinding_002EIAstarAI_002Eget_radius()
		{
			return default;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x444CDF0", Offset = "0x4448DF0", VA = "0x444CDF0", Slot = "16")]
		private void Pathfinding_002EIAstarAI_002Eset_radius(float value)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x444CDF4", Offset = "0x4448DF4", VA = "0x444CDF4", Slot = "17")]
		private float Pathfinding_002EIAstarAI_002Eget_height()
		{
			return default;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x444CDFC", Offset = "0x4448DFC", VA = "0x444CDFC", Slot = "18")]
		private void Pathfinding_002EIAstarAI_002Eset_height(float value)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x444CE00", Offset = "0x4448E00", VA = "0x444CE00", Slot = "22")]
		private float Pathfinding_002EIAstarAI_002Eget_maxSpeed()
		{
			return default;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x444CE08", Offset = "0x4448E08", VA = "0x444CE08", Slot = "23")]
		private void Pathfinding_002EIAstarAI_002Eset_maxSpeed(float value)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x444CE10", Offset = "0x4448E10", VA = "0x444CE10", Slot = "34")]
		private bool Pathfinding_002EIAstarAI_002Eget_canSearch()
		{
			return default;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x444CE34", Offset = "0x4448E34", VA = "0x444CE34", Slot = "35")]
		private void Pathfinding_002EIAstarAI_002Eset_canSearch(bool value)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x444CE54", Offset = "0x4448E54", VA = "0x444CE54", Slot = "36")]
		private bool Pathfinding_002EIAstarAI_002Eget_simulateMovement()
		{
			return default;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x444CE5C", Offset = "0x4448E5C", VA = "0x444CE5C", Slot = "37")]
		private void Pathfinding_002EIAstarAI_002Eset_simulateMovement(bool value)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x444CF08", Offset = "0x4448F08", VA = "0x444CF08", Slot = "25")]
		private Vector3 Pathfinding_002EIAstarAI_002Eget_desiredVelocity()
		{
			return default;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x444CFA0", Offset = "0x4448FA0", VA = "0x444CFA0", Slot = "26")]
		private Vector3 Pathfinding_002EIAstarAI_002Eget_desiredVelocityWithoutLocalAvoidance()
		{
			return default;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x444D038", Offset = "0x4449038", VA = "0x444D038", Slot = "27")]
		private void Pathfinding_002EIAstarAI_002Eset_desiredVelocityWithoutLocalAvoidance(Vector3 value)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x444D084", Offset = "0x4449084", VA = "0x444D084", Slot = "48")]
		private Vector3 Pathfinding_002EIAstarAI_002Eget_steeringTarget()
		{
			return default;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x444D1C0", Offset = "0x44491C0", VA = "0x444D1C0")]
		protected AILerp()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x444D2A4", Offset = "0x44492A4", VA = "0x444D2A4", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x444D368", Offset = "0x4449368", VA = "0x444D368", Slot = "60")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x444D3E4", Offset = "0x44493E4", VA = "0x444D3E4", Slot = "61")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x444D374", Offset = "0x4449374", VA = "0x444D374")]
		private void Init()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x444D50C", Offset = "0x444950C", VA = "0x444D50C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x444D51C", Offset = "0x444951C", VA = "0x444D51C", Slot = "52")]
		public void GetRemainingPath(List<Vector3> buffer, out bool stale)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AILerp.GetRemainingPath RVA=0x444D51C Token=0x60000FD");
}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x444D654", Offset = "0x4449654", VA = "0x444D654", Slot = "53")]
		public void GetRemainingPath(List<Vector3> buffer, List<PathPartWithLinkInfo> partsBuffer, out bool stale)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AILerp.GetRemainingPath RVA=0x444D654 Token=0x60000FE");
}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x444D454", Offset = "0x4449454", VA = "0x444D454", Slot = "56")]
		public void Teleport(Vector3 position, bool clearPath = true)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x444D85C", Offset = "0x444985C", VA = "0x444D85C", Slot = "63")]
		public virtual void SearchPath()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x444DAEC", Offset = "0x4449AEC", VA = "0x444DAEC", Slot = "64")]
		public virtual void OnTargetReached()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x444DAF0", Offset = "0x4449AF0", VA = "0x444DAF0", Slot = "65")]
		protected virtual void OnPathComplete(Path _p)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x444DD6C", Offset = "0x4449D6C", VA = "0x444DD6C", Slot = "66")]
		protected virtual void ClearPath()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x444D8D8", Offset = "0x44498D8", VA = "0x444D8D8", Slot = "55")]
		public void SetPath(Path path, bool updateDestinationFromPath = true)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x444DE24", Offset = "0x4449E24", VA = "0x444DE24", Slot = "67")]
		protected virtual void ConfigurePathSwitchInterpolation()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x444DFF0", Offset = "0x4449FF0", VA = "0x444DFF0", Slot = "68")]
		public virtual Vector3 GetFeetPosition()
		{
			return default;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x444DFF4", Offset = "0x4449FF4", VA = "0x444DFF4", Slot = "69")]
		protected virtual void ConfigureNewPath()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x444E2CC", Offset = "0x444A2CC", VA = "0x444E2CC", Slot = "70")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x444E350", Offset = "0x444A350", VA = "0x444E350", Slot = "58")]
		public void MovementUpdate(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AILerp.MovementUpdate RVA=0x444E350 Token=0x600010A");
}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x444E438", Offset = "0x444A438", VA = "0x444E438", Slot = "59")]
		public void FinalizeMovement(Vector3 nextPosition, Quaternion nextRotation)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x444E4E4", Offset = "0x444A4E4", VA = "0x444E4E4")]
		private Quaternion SimulateRotationTowards(Vector3 direction, float deltaTime)
		{
			return default;
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x444E710", Offset = "0x444A710", VA = "0x444E710", Slot = "71")]
		protected virtual Vector3 CalculateNextPosition(out Vector3 direction, float deltaTime)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AILerp.CalculateNextPosition RVA=0x444E710 Token=0x600010D");
}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x444E948", Offset = "0x444A948", VA = "0x444E948", Slot = "14")]
		protected override void OnUpgradeSerializedData(ref Migrations migrations, bool unityThread)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x444E9A4", Offset = "0x444A9A4", VA = "0x444E9A4", Slot = "6")]
		public override void DrawGizmos()
		{
		}
	}
}
