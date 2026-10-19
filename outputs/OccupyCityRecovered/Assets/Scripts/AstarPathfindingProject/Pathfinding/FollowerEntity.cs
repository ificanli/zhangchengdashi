using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.ECS;
using Pathfinding.ECS.RVO;
using Pathfinding.PID;
using Pathfinding.Serialization;
using Pathfinding.Util;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000018")]
	[DisallowMultipleComponent]
	[UniqueComponent(tag = "rvo")]
	[UniqueComponent(tag = "ai")]
	[AddComponentMenu("Pathfinding/AI/Follower Entity (2D,3D)")]
	public sealed class FollowerEntity : VersionedMonoBehaviour, IAstarAI, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000019")]
		[Flags]
		private enum FollowerEntityMigrations
		{
			[Token(Token = "0x40000E6")]
			MigratePathfindingSettings = 1,
			[Token(Token = "0x40000E7")]
			MigrateMovementPlaneSource = 2,
			[Token(Token = "0x40000E8")]
			MigrateAutoRepathPolicy = 4,
			[Token(Token = "0x40000E9")]
			MigrateManagedSettings = 8
		}

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AgentCylinderShape shape;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MovementSettings movement;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ManagedState managedState;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ManagedSettings managedSettings;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool enableLocalAvoidanceBacking;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		[SerializeField]
		private bool enableGravityBacking;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private RVOAgent rvoSettingsBacking;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Pathfinding.ECS.AutoRepathPolicy autoRepathBacking;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private OrientationMode orientationBacking;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		[SerializeField]
		private MovementPlaneSource movementPlaneSourceBacking;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		[SerializeField]
		private bool syncPosition;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC3")]
		[SerializeField]
		private bool syncRotation;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Transform tr;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private FollowerEntityProxy proxy;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static EntityArchetype archetype;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static World archetypeWorld;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool didStart;

		[Token(Token = "0x1700004B")]
		public Entity entity
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x4450638", Offset = "0x444C638", VA = "0x4450638")]
			[IgnoredByDeepProfiler]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004C")]
		public World world
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x445068C", Offset = "0x444C68C", VA = "0x445068C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public float radius
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x4451F1C", Offset = "0x444DF1C", VA = "0x4451F1C", Slot = "15")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x4451F24", Offset = "0x444DF24", VA = "0x4451F24", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public float height
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x4451F90", Offset = "0x444DF90", VA = "0x4451F90", Slot = "17")]
			get
			{
				return default;
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x4451F98", Offset = "0x444DF98", VA = "0x4451F98", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public unsafe ref PathRequestSettings pathfindingSettings
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x4452004", Offset = "0x444E004", VA = "0x4452004")]
			get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FollowerEntity.pathfindingSettings.get RVA=0x4452004 Token=0x600013C");
}
		}

		[Token(Token = "0x17000050")]
		public RVOAgent rvoSettings
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x44520BC", Offset = "0x444E0BC", VA = "0x44520BC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x445215C", Offset = "0x444E15C", VA = "0x445215C")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public Vector3 position
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x4451C48", Offset = "0x444DC48", VA = "0x4451C48", Slot = "19")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x4452204", Offset = "0x444E204", VA = "0x4452204")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public bool isTraversingOffMeshLink
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x44522F4", Offset = "0x444E2F4", VA = "0x44522F4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000053")]
		public OffMeshLinks.OffMeshLinkTracer offMeshLink
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x445234C", Offset = "0x444E34C", VA = "0x445234C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000054")]
		public IOffMeshLinkHandler onTraverseOffMeshLink
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x44523D0", Offset = "0x444E3D0", VA = "0x44523D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x44523EC", Offset = "0x444E3EC", VA = "0x44523EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public GraphNode currentNode
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x44524B0", Offset = "0x444E4B0", VA = "0x44524B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public GraphHitInfo nearestNavmeshBorder
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x4452508", Offset = "0x444E508", VA = "0x4452508")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000057")]
		public Quaternion rotation
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x4452594", Offset = "0x444E594", VA = "0x4452594", Slot = "20")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x4452760", Offset = "0x444E760", VA = "0x4452760", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public MovementPlaneSource movementPlaneSource
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x44529C4", Offset = "0x444E9C4", VA = "0x44529C4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x44529CC", Offset = "0x444E9CC", VA = "0x44529CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public LayerMask groundMask
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x4452A38", Offset = "0x444EA38", VA = "0x4452A38")]
			get
			{
				return default;
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x4452A40", Offset = "0x444EA40", VA = "0x4452A40")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public PIDMovement.DebugFlags debugFlags
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x4452AAC", Offset = "0x444EAAC", VA = "0x4452AAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x4452AB4", Offset = "0x444EAB4", VA = "0x4452AB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public float maxSpeed
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x4452B20", Offset = "0x444EB20", VA = "0x4452B20", Slot = "22")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x4452B28", Offset = "0x444EB28", VA = "0x4452B28", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public float rotationSpeed
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x4452B94", Offset = "0x444EB94", VA = "0x4452B94")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x4452B9C", Offset = "0x444EB9C", VA = "0x4452B9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public float maxRotationSpeed
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x4452C08", Offset = "0x444EC08", VA = "0x4452C08")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x4452C10", Offset = "0x444EC10", VA = "0x4452C10")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public Vector3 velocity
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x4452C7C", Offset = "0x444EC7C", VA = "0x4452C7C", Slot = "24")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x4452CD4", Offset = "0x444ECD4", VA = "0x4452CD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public Vector3 desiredVelocity
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x4452D54", Offset = "0x444ED54", VA = "0x4452D54", Slot = "25")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000060")]
		public Vector3 desiredVelocityWithoutLocalAvoidance
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x4452DAC", Offset = "0x444EDAC", VA = "0x4452DAC", Slot = "26")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x4452E04", Offset = "0x444EE04", VA = "0x4452E04", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public float remainingDistance
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x4452E84", Offset = "0x444EE84", VA = "0x4452E84", Slot = "28")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000062")]
		public float stopDistance
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x4452EDC", Offset = "0x444EEDC", VA = "0x4452EDC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x4452EE4", Offset = "0x444EEE4", VA = "0x4452EE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public float positionSmoothing
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x4452F70", Offset = "0x444EF70", VA = "0x4452F70")]
			get
			{
				return default;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x4452F78", Offset = "0x444EF78", VA = "0x4452F78")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public float rotationSmoothing
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x4453004", Offset = "0x444F004", VA = "0x4453004")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x445300C", Offset = "0x444F00C", VA = "0x445300C")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public bool reachedDestination
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x4453098", Offset = "0x444F098", VA = "0x4453098", Slot = "29")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000066")]
		public bool reachedEndOfPath
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x44530F0", Offset = "0x444F0F0", VA = "0x44530F0", Slot = "30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000067")]
		public bool reachedCrowdedEndOfPath
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x4453148", Offset = "0x444F148", VA = "0x4453148")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000068")]
		public Vector3 endOfPath
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x44531A0", Offset = "0x444F1A0", VA = "0x44531A0", Slot = "31")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000069")]
		public Vector3 destination
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x4453218", Offset = "0x444F218", VA = "0x4453218", Slot = "32")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x4453270", Offset = "0x444F270", VA = "0x4453270", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public Vector3 destinationFacingDirection
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x44532F0", Offset = "0x444F2F0", VA = "0x44532F0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006B")]
		public Pathfinding.ECS.AutoRepathPolicy autoRepath
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x44533E8", Offset = "0x444F3E8", VA = "0x44533E8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x44533FC", Offset = "0x444F3FC", VA = "0x44533FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		[Obsolete("This has been superseded by autoRepath.mode")]
		public bool canSearch
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x44534A0", Offset = "0x444F4A0", VA = "0x44534A0", Slot = "34")]
			get
			{
				return default;
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x44534B0", Offset = "0x444F4B0", VA = "0x44534B0", Slot = "35")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public bool simulateMovement
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x44534FC", Offset = "0x444F4FC", VA = "0x44534FC", Slot = "36")]
			get
			{
				return default;
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x4453574", Offset = "0x444F574", VA = "0x4453574", Slot = "37")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		[Obsolete("Renamed to simulateMovement")]
		public bool canMove
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x44535DC", Offset = "0x444F5DC", VA = "0x44535DC", Slot = "38")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x44535E0", Offset = "0x444F5E0", VA = "0x44535E0", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public NativeMovementPlane movementPlane
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x44535E8", Offset = "0x444F5E8", VA = "0x44535E8", Slot = "51")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000070")]
		public bool enableGravity
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x4453690", Offset = "0x444F690", VA = "0x4453690")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x4453708", Offset = "0x444F708", VA = "0x4453708")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool enableLocalAvoidance
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x4453798", Offset = "0x444F798", VA = "0x4453798")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x4453810", Offset = "0x444F810", VA = "0x4453810")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public bool localAvoidanceTemporarilyDisabled
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x44539AC", Offset = "0x444F9AC", VA = "0x44539AC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000073")]
		public bool updatePosition
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x4453A04", Offset = "0x444FA04", VA = "0x4453A04", Slot = "42")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x4453A0C", Offset = "0x444FA0C", VA = "0x4453A0C", Slot = "43")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public bool updateRotation
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x4453A7C", Offset = "0x444FA7C", VA = "0x4453A7C", Slot = "44")]
			get
			{
				return default;
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x4453A84", Offset = "0x444FA84", VA = "0x4453A84", Slot = "45")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public OrientationMode orientation
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x4453AF4", Offset = "0x444FAF4", VA = "0x4453AF4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x4453AFC", Offset = "0x444FAFC", VA = "0x4453AFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public bool hasPath
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x4453B7C", Offset = "0x444FB7C", VA = "0x4453B7C", Slot = "40")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000077")]
		public bool pathPending
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x4453BD4", Offset = "0x444FBD4", VA = "0x4453BD4", Slot = "41")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000078")]
		public bool isStopped
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x4453C2C", Offset = "0x444FC2C", VA = "0x4453C2C", Slot = "46")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x4453CA4", Offset = "0x444FCA4", VA = "0x4453CA4", Slot = "47")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public MovementSettings movementSettings
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x4453D34", Offset = "0x444FD34", VA = "0x4453D34")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x4453D50", Offset = "0x444FD50", VA = "0x4453D50")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public Vector3 steeringTarget
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x4453E04", Offset = "0x444FE04", VA = "0x4453E04", Slot = "48")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007B")]
Action IAstarAI.onSearchPath
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x4453E7C", Offset = "0x444FE7C", VA = "0x4453E7C", Slot = "49")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_onSearchPath();
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x4453E84", Offset = "0x444FE84", VA = "0x4453E84", Slot = "50")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_onSearchPath(value);
			}
		}

		[Token(Token = "0x1700007C")]
		public ManagedMovementOverrides movementOverrides
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x4453ED0", Offset = "0x444FED0", VA = "0x4453ED0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007D")]
		public bool entityExists
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x4451BF0", Offset = "0x444DBF0", VA = "0x4451BF0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x44506E0", Offset = "0x444C6E0", VA = "0x44506E0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x4450C14", Offset = "0x444CC14", VA = "0x4450C14")]
		public static Entity CreateEntity(float3 position, quaternion rotation, float scale, ref AgentCylinderShape shape, ref MovementSettings movement, ref Pathfinding.ECS.AutoRepathPolicy autoRepath, ManagedState managedState, OrientationMode orientation, MovementPlaneSource movementPlaneSource, bool updatePosition, bool updateRotation, bool enableGravity, bool enableLocalAvoidance, RVOAgent rvoSettings, ManagedSettings managedSettings, PhysicsScene physicsScene)
		{
			return default;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x4447AD8", Offset = "0x4443AD8", VA = "0x4447AD8")]
		internal void RegisterRuntimeBaker(IRuntimeBaker baker)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x4451BB4", Offset = "0x444DBB4", VA = "0x4451BB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x4451E08", Offset = "0x444DE08", VA = "0x4451E08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x4453348", Offset = "0x444F348", VA = "0x4453348")]
		public void SetDestination(float3 destination, [System.Runtime.InteropServices.Optional] float3 facingDirection)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x4453E7C", Offset = "0x444FE7C", VA = "0x4453E7C", Slot = "49")]
		private Action Pathfinding_002EIAstarAI_002Eget_onSearchPath()
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x4453E84", Offset = "0x444FE84", VA = "0x4453E84", Slot = "50")]
		private void Pathfinding_002EIAstarAI_002Eset_onSearchPath(Action value)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x4453F28", Offset = "0x444FF28", VA = "0x4453F28", Slot = "59")]
void IAstarAI.FinalizeMovement(Vector3 nextPosition, Quaternion nextRotation)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x4453F74", Offset = "0x444FF74", VA = "0x4453F74", Slot = "52")]
		public void GetRemainingPath(List<Vector3> buffer, out bool stale)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FollowerEntity.GetRemainingPath RVA=0x4453F74 Token=0x6000188");
}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x4453FE4", Offset = "0x444FFE4", VA = "0x4453FE4", Slot = "53")]
		public void GetRemainingPath(List<Vector3> buffer, List<PathPartWithLinkInfo> partsBuffer, out bool stale)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FollowerEntity.GetRemainingPath RVA=0x4453FE4 Token=0x6000189");
}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x4454064", Offset = "0x4450064", VA = "0x4454064", Slot = "57")]
		public void Move(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x44540E4", Offset = "0x44500E4", VA = "0x44540E4", Slot = "58")]
void IAstarAI.MovementUpdate(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FollowerEntity.MovementUpdate RVA=0x44540E4 Token=0x600018B");
}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x4454130", Offset = "0x4450130", VA = "0x4454130", Slot = "54")]
		public void SearchPath()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x4451EC4", Offset = "0x444DEC4", VA = "0x4451EC4")]
		private void CancelCurrentPathRequest()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x4454188", Offset = "0x4450188", VA = "0x4454188", Slot = "55")]
		public void SetPath(Path path, bool updateDestinationFromPath = true)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x4451CD4", Offset = "0x444DCD4", VA = "0x4451CD4", Slot = "56")]
		public void Teleport(Vector3 newPosition, bool clearPath = true)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x4450BF8", Offset = "0x444CBF8", VA = "0x4450BF8")]
		private void FindComponents()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x44541F8", Offset = "0x44501F8", VA = "0x44541F8", Slot = "6")]
		public override void DrawGizmos()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x44544EC", Offset = "0x44504EC", VA = "0x44544EC", Slot = "14")]
		protected override void OnUpgradeSerializedData(ref Migrations migrations, bool unityThread)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x44546C8", Offset = "0x44506C8", VA = "0x44546C8")]
		public FollowerEntity()
		{
		}
	}
}
