using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.ECS.RVO;
using Pathfinding.PID;
using Pathfinding.Util;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;
using UnityEngine;

namespace Pathfinding.ECS
{
	[Token(Token = "0x20002E1")]
	public struct FollowerEntityProxy : IAstarAI
	{
		[Token(Token = "0x20002E2")]
		private class EntityDoesNotExistException : Exception
		{
			[Token(Token = "0x6001287")]
			[Address(RVA = "0x44A91F4", Offset = "0x44A51F4", VA = "0x44A91F4")]
			public EntityDoesNotExistException()
			{
			}
		}

		[Token(Token = "0x4000D55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static NativeList<float3> nextCornersScratch;

		[Token(Token = "0x4000D56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static NativeArray<int> indicesScratch;

		[Token(Token = "0x4000D57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static EntityAccess<DestinationPoint> destinationPointAccessRW;

		[Token(Token = "0x4000D58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal static EntityAccess<DestinationPoint> destinationPointAccessRO;

		[Token(Token = "0x4000D59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal static EntityAccess<AgentMovementPlane> movementPlaneAccessRW;

		[Token(Token = "0x4000D5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		internal static EntityAccess<AgentMovementPlane> movementPlaneAccessRO;

		[Token(Token = "0x4000D5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		internal static EntityAccess<MovementState> movementStateAccessRW;

		[Token(Token = "0x4000D5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		internal static EntityAccess<MovementState> movementStateAccessRO;

		[Token(Token = "0x4000D5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		internal static EntityAccess<MovementStatistics> movementOutputAccessRW;

		[Token(Token = "0x4000D5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		internal static EntityAccess<ResolvedMovement> resolvedMovementAccessRO;

		[Token(Token = "0x4000D5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		internal static EntityAccess<ResolvedMovement> resolvedMovementAccessRW;

		[Token(Token = "0x4000D60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		internal static EntityAccess<MovementControl> movementControlAccessRO;

		[Token(Token = "0x4000D61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		internal static EntityAccess<MovementControl> movementControlAccessRW;

		[Token(Token = "0x4000D62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		internal static EntityAccess<MovementStatistics> movementStatisticsAccessRW;

		[Token(Token = "0x4000D63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		internal static EntityAccess<MovementStatistics> movementStatisticsAccessRO;

		[Token(Token = "0x4000D64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		internal static ManagedEntityAccess<ManagedState> managedStateAccessRO;

		[Token(Token = "0x4000D65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		internal static ManagedEntityAccess<ManagedState> managedStateAccessRW;

		[Token(Token = "0x4000D66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		internal static ManagedEntityAccess<ManagedSettings> managedSettingsAccessRO;

		[Token(Token = "0x4000D67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		internal static ManagedEntityAccess<ManagedSettings> managedSettingsAccessRW;

		[Token(Token = "0x4000D68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		internal static EntityAccess<AutoRepathPolicy> autoRepathPolicyRW;

		[Token(Token = "0x4000D69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		internal static EntityAccess<LocalTransform> localTransformAccessRO;

		[Token(Token = "0x4000D6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		internal static EntityAccess<LocalTransform> localTransformAccessRW;

		[Token(Token = "0x4000D6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		internal static EntityAccess<AgentCylinderShape> agentCylinderShapeAccessRO;

		[Token(Token = "0x4000D6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
		internal static EntityAccess<AgentCylinderShape> agentCylinderShapeAccessRW;

		[Token(Token = "0x4000D6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578")]
		internal static EntityAccess<MovementSettings> movementSettingsAccessRO;

		[Token(Token = "0x4000D6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
		internal static EntityAccess<MovementSettings> movementSettingsAccessRW;

		[Token(Token = "0x4000D6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F8")]
		internal static EntityAccess<AgentOffMeshLinkTraversal> agentOffMeshLinkTraversalRO;

		[Token(Token = "0x4000D70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x638")]
		internal static EntityAccess<ReadyToTraverseOffMeshLink> readyToTraverseOffMeshLinkRW;

		[Token(Token = "0x4000D71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x678")]
		internal static EntityAccess<RVOAgent> rvoSettingsAccessRO;

		[Token(Token = "0x4000D72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B8")]
		internal static EntityAccess<RVOAgent> rvoSettingsAccessRW;

		[Token(Token = "0x4000D73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F8")]
		internal static EntityStorageCache entityStorageCache;

		[Token(Token = "0x170002CC")]
		public Entity entity
		{
			[Token(Token = "0x6001222")]
			[Address(RVA = "0x44A8718", Offset = "0x44A4718", VA = "0x44A8718")]
			[IgnoredByDeepProfiler]
			[CompilerGenerated]
			readonly get
			{
				return default;
			}
			[Token(Token = "0x6001223")]
			[Address(RVA = "0x44A8720", Offset = "0x44A4720", VA = "0x44A8720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170002CD")]
		public World world
		{
			[Token(Token = "0x6001224")]
			[Address(RVA = "0x44A8728", Offset = "0x44A4728", VA = "0x44A8728")]
			[CompilerGenerated]
			[IgnoredByDeepProfiler]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001225")]
			[Address(RVA = "0x44A8730", Offset = "0x44A4730", VA = "0x44A8730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170002CE")]
		public bool entityExists
		{
			[Token(Token = "0x6001229")]
			[Address(RVA = "0x44A8AF0", Offset = "0x44A4AF0", VA = "0x44A8AF0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002CF")]
		internal bool likelyHasReasonableComponents
		{
			[Token(Token = "0x600122A")]
			[Address(RVA = "0x44A8BE8", Offset = "0x44A4BE8", VA = "0x44A8BE8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002D0")]
		public float radius
		{
			[Token(Token = "0x600122C")]
			[Address(RVA = "0x44A8E70", Offset = "0x44A4E70", VA = "0x44A8E70", Slot = "4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600122D")]
			[Address(RVA = "0x44A8F1C", Offset = "0x44A4F1C", VA = "0x44A8F1C", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x170002D1")]
		public float height
		{
			[Token(Token = "0x600122E")]
			[Address(RVA = "0x44A8FC8", Offset = "0x44A4FC8", VA = "0x44A8FC8", Slot = "6")]
			get
			{
				return default;
			}
			[Token(Token = "0x600122F")]
			[Address(RVA = "0x44A9074", Offset = "0x44A5074", VA = "0x44A9074", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170002D2")]
		public unsafe ref PathRequestSettings pathfindingSettings
		{
			[Token(Token = "0x6001230")]
			[Address(RVA = "0x44A9120", Offset = "0x44A5120", VA = "0x44A9120")]
			get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FollowerEntityProxy.pathfindingSettings.get RVA=0x44A9120 Token=0x6001230");
}
		}

		[Token(Token = "0x170002D3")]
		public RVOAgent rvoSettings
		{
			[Token(Token = "0x6001231")]
			[Address(RVA = "0x44A9264", Offset = "0x44A5264", VA = "0x44A9264")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001232")]
			[Address(RVA = "0x44A9494", Offset = "0x44A5494", VA = "0x44A9494")]
			set
			{
			}
		}

		[Token(Token = "0x170002D4")]
		public Vector3 position
		{
			[Token(Token = "0x6001233")]
			[Address(RVA = "0x44A967C", Offset = "0x44A567C", VA = "0x44A967C", Slot = "8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001234")]
			[Address(RVA = "0x44A973C", Offset = "0x44A573C", VA = "0x44A973C")]
			set
			{
			}
		}

		[Token(Token = "0x170002D5")]
		public bool isTraversingOffMeshLink
		{
			[Token(Token = "0x6001235")]
			[Address(RVA = "0x44AA088", Offset = "0x44A6088", VA = "0x44AA088")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002D6")]
		public OffMeshLinks.OffMeshLinkTracer offMeshLink
		{
			[Token(Token = "0x6001236")]
			[Address(RVA = "0x44AA170", Offset = "0x44A6170", VA = "0x44AA170")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002D7")]
		public IOffMeshLinkHandler onTraverseOffMeshLink
		{
			[Token(Token = "0x6001237")]
			[Address(RVA = "0x44AA484", Offset = "0x44A6484", VA = "0x44AA484")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001238")]
			[Address(RVA = "0x44AA530", Offset = "0x44A6530", VA = "0x44AA530")]
			set
			{
			}
		}

		[Token(Token = "0x170002D8")]
		public GraphNode currentNode
		{
			[Token(Token = "0x6001239")]
			[Address(RVA = "0x44AA5D8", Offset = "0x44A65D8", VA = "0x44AA5D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002D9")]
		public GraphHitInfo nearestNavmeshBorder
		{
			[Token(Token = "0x600123A")]
			[Address(RVA = "0x44AA6CC", Offset = "0x44A66CC", VA = "0x44AA6CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002DA")]
		public Quaternion rotation
		{
			[Token(Token = "0x600123B")]
			[Address(RVA = "0x44AA8C4", Offset = "0x44A68C4", VA = "0x44AA8C4", Slot = "9")]
			get
			{
				return default;
			}
			[Token(Token = "0x600123C")]
			[Address(RVA = "0x44AA9B4", Offset = "0x44A69B4", VA = "0x44AA9B4", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170002DB")]
		public MovementPlaneSource movementPlaneSource
		{
			[Token(Token = "0x600123D")]
			[Address(RVA = "0x44AAA98", Offset = "0x44A6A98", VA = "0x44AAA98")]
			get
			{
				return default;
			}
			[Token(Token = "0x600123E")]
			[Address(RVA = "0x44AAB7C", Offset = "0x44A6B7C", VA = "0x44AAB7C")]
			set
			{
			}
		}

		[Token(Token = "0x170002DC")]
		public LayerMask groundMask
		{
			[Token(Token = "0x600123F")]
			[Address(RVA = "0x44AAC60", Offset = "0x44A6C60", VA = "0x44AAC60")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001240")]
			[Address(RVA = "0x44AAD10", Offset = "0x44A6D10", VA = "0x44AAD10")]
			set
			{
			}
		}

		[Token(Token = "0x170002DD")]
		public PIDMovement.DebugFlags debugFlags
		{
			[Token(Token = "0x6001241")]
			[Address(RVA = "0x44AADBC", Offset = "0x44A6DBC", VA = "0x44AADBC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001242")]
			[Address(RVA = "0x44AAE6C", Offset = "0x44A6E6C", VA = "0x44AAE6C")]
			set
			{
			}
		}

		[Token(Token = "0x170002DE")]
		public float maxSpeed
		{
			[Token(Token = "0x6001243")]
			[Address(RVA = "0x44AAF18", Offset = "0x44A6F18", VA = "0x44AAF18", Slot = "11")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001244")]
			[Address(RVA = "0x44AAFC4", Offset = "0x44A6FC4", VA = "0x44AAFC4", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x170002DF")]
		public float rotationSpeed
		{
			[Token(Token = "0x6001245")]
			[Address(RVA = "0x44AB070", Offset = "0x44A7070", VA = "0x44AB070")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001246")]
			[Address(RVA = "0x44AB11C", Offset = "0x44A711C", VA = "0x44AB11C")]
			set
			{
			}
		}

		[Token(Token = "0x170002E0")]
		public float maxRotationSpeed
		{
			[Token(Token = "0x6001247")]
			[Address(RVA = "0x44AB1C8", Offset = "0x44A71C8", VA = "0x44AB1C8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001248")]
			[Address(RVA = "0x44AB274", Offset = "0x44A7274", VA = "0x44AB274")]
			set
			{
			}
		}

		[Token(Token = "0x170002E1")]
		public Vector3 velocity
		{
			[Token(Token = "0x6001249")]
			[Address(RVA = "0x44AB320", Offset = "0x44A7320", VA = "0x44AB320", Slot = "13")]
			get
			{
				return default;
			}
			[Token(Token = "0x600124A")]
			[Address(RVA = "0x44AB410", Offset = "0x44A7410", VA = "0x44AB410")]
			set
			{
			}
		}

		[Token(Token = "0x170002E2")]
		public Vector3 desiredVelocity
		{
			[Token(Token = "0x600124B")]
			[Address(RVA = "0x44AB4E4", Offset = "0x44A74E4", VA = "0x44AB4E4", Slot = "14")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002E3")]
		public Vector3 desiredVelocityWithoutLocalAvoidance
		{
			[Token(Token = "0x600124C")]
			[Address(RVA = "0x44AB6C0", Offset = "0x44A76C0", VA = "0x44AB6C0", Slot = "15")]
			get
			{
				return default;
			}
			[Token(Token = "0x600124D")]
			[Address(RVA = "0x44AB89C", Offset = "0x44A789C", VA = "0x44AB89C", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x170002E4")]
		public float remainingDistance
		{
			[Token(Token = "0x600124E")]
			[Address(RVA = "0x44AB8E8", Offset = "0x44A78E8", VA = "0x44AB8E8", Slot = "17")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002E5")]
		public float stopDistance
		{
			[Token(Token = "0x600124F")]
			[Address(RVA = "0x44ABCC8", Offset = "0x44A7CC8", VA = "0x44ABCC8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001250")]
			[Address(RVA = "0x44ABD74", Offset = "0x44A7D74", VA = "0x44ABD74")]
			set
			{
			}
		}

		[Token(Token = "0x170002E6")]
		public float positionSmoothing
		{
			[Token(Token = "0x6001251")]
			[Address(RVA = "0x44ABE20", Offset = "0x44A7E20", VA = "0x44ABE20")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001252")]
			[Address(RVA = "0x44ABECC", Offset = "0x44A7ECC", VA = "0x44ABECC")]
			set
			{
			}
		}

		[Token(Token = "0x170002E7")]
		public float rotationSmoothing
		{
			[Token(Token = "0x6001253")]
			[Address(RVA = "0x44ABF78", Offset = "0x44A7F78", VA = "0x44ABF78")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001254")]
			[Address(RVA = "0x44AC024", Offset = "0x44A8024", VA = "0x44AC024")]
			set
			{
			}
		}

		[Token(Token = "0x170002E8")]
		public bool reachedDestination
		{
			[Token(Token = "0x6001255")]
			[Address(RVA = "0x44AC0D0", Offset = "0x44A80D0", VA = "0x44AC0D0", Slot = "18")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002E9")]
		public bool reachedEndOfPath
		{
			[Token(Token = "0x6001256")]
			[Address(RVA = "0x44AC188", Offset = "0x44A8188", VA = "0x44AC188", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002EA")]
		public bool reachedCrowdedEndOfPath
		{
			[Token(Token = "0x6001257")]
			[Address(RVA = "0x44AC240", Offset = "0x44A8240", VA = "0x44AC240")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002EB")]
		public Vector3 endOfPath
		{
			[Token(Token = "0x6001258")]
			[Address(RVA = "0x44AC790", Offset = "0x44A8790", VA = "0x44AC790", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002EC")]
		public Vector3 destination
		{
			[Token(Token = "0x6001259")]
			[Address(RVA = "0x44AC8D4", Offset = "0x44A88D4", VA = "0x44AC8D4", Slot = "21")]
			get
			{
				return default;
			}
			[Token(Token = "0x600125A")]
			[Address(RVA = "0x44AC9C4", Offset = "0x44A89C4", VA = "0x44AC9C4", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x170002ED")]
		public Vector3 destinationFacingDirection
		{
			[Token(Token = "0x600125B")]
			[Address(RVA = "0x44AD460", Offset = "0x44A9460", VA = "0x44AD460")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002EE")]
		public AutoRepathPolicy autoRepath
		{
			[Token(Token = "0x600125D")]
			[Address(RVA = "0x44AD550", Offset = "0x44A9550", VA = "0x44AD550")]
			get
			{
				return default;
			}
			[Token(Token = "0x600125E")]
			[Address(RVA = "0x44AD614", Offset = "0x44A9614", VA = "0x44AD614")]
			set
			{
			}
		}

		[Token(Token = "0x170002EF")]
		[Obsolete("This has been superseded by autoRepath.mode")]
		public bool canSearch
		{
			[Token(Token = "0x600125F")]
			[Address(RVA = "0x44AD6CC", Offset = "0x44A96CC", VA = "0x44AD6CC", Slot = "23")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001260")]
			[Address(RVA = "0x44AD73C", Offset = "0x44A973C", VA = "0x44AD73C", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x170002F0")]
		public bool simulateMovement
		{
			[Token(Token = "0x6001261")]
			[Address(RVA = "0x44AD85C", Offset = "0x44A985C", VA = "0x44AD85C", Slot = "25")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001262")]
			[Address(RVA = "0x44AD944", Offset = "0x44A9944", VA = "0x44AD944", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x170002F1")]
		public NativeMovementPlane movementPlane
		{
			[Token(Token = "0x6001263")]
			[Address(RVA = "0x44AD9C4", Offset = "0x44A99C4", VA = "0x44AD9C4", Slot = "40")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002F2")]
		public bool enableGravity
		{
			[Token(Token = "0x6001264")]
			[Address(RVA = "0x44ADAAC", Offset = "0x44A9AAC", VA = "0x44ADAAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001265")]
			[Address(RVA = "0x44ADB94", Offset = "0x44A9B94", VA = "0x44ADB94")]
			set
			{
			}
		}

		[Token(Token = "0x170002F3")]
		public bool enableLocalAvoidance
		{
			[Token(Token = "0x6001266")]
			[Address(RVA = "0x44ADC14", Offset = "0x44A9C14", VA = "0x44ADC14")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002F4")]
		public bool localAvoidanceTemporarilyDisabled
		{
			[Token(Token = "0x6001267")]
			[Address(RVA = "0x44ADCFC", Offset = "0x44A9CFC", VA = "0x44ADCFC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002F5")]
		public bool updatePosition
		{
			[Token(Token = "0x6001268")]
			[Address(RVA = "0x44ADE48", Offset = "0x44A9E48", VA = "0x44ADE48", Slot = "31")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001269")]
			[Address(RVA = "0x44ADF30", Offset = "0x44A9F30", VA = "0x44ADF30", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x170002F6")]
		public bool updateRotation
		{
			[Token(Token = "0x600126A")]
			[Address(RVA = "0x44ADFB0", Offset = "0x44A9FB0", VA = "0x44ADFB0", Slot = "33")]
			get
			{
				return default;
			}
			[Token(Token = "0x600126B")]
			[Address(RVA = "0x44AE098", Offset = "0x44AA098", VA = "0x44AE098", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x170002F7")]
		public OrientationMode orientation
		{
			[Token(Token = "0x600126C")]
			[Address(RVA = "0x44AE118", Offset = "0x44AA118", VA = "0x44AE118")]
			get
			{
				return default;
			}
			[Token(Token = "0x600126D")]
			[Address(RVA = "0x44AE200", Offset = "0x44AA200", VA = "0x44AE200")]
			set
			{
			}
		}

		[Token(Token = "0x170002F8")]
		public bool hasPath
		{
			[Token(Token = "0x600126E")]
			[Address(RVA = "0x44AC6AC", Offset = "0x44A86AC", VA = "0x44AC6AC", Slot = "29")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002F9")]
		public bool pathPending
		{
			[Token(Token = "0x600126F")]
			[Address(RVA = "0x44AE288", Offset = "0x44AA288", VA = "0x44AE288", Slot = "30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002FA")]
		public bool isStopped
		{
			[Token(Token = "0x6001270")]
			[Address(RVA = "0x44AE33C", Offset = "0x44AA33C", VA = "0x44AE33C", Slot = "35")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001271")]
			[Address(RVA = "0x44AE3F4", Offset = "0x44AA3F4", VA = "0x44AE3F4", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x170002FB")]
		public MovementSettings movementSettings
		{
			[Token(Token = "0x6001272")]
			[Address(RVA = "0x44AE4A4", Offset = "0x44AA4A4", VA = "0x44AE4A4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001273")]
			[Address(RVA = "0x44AE578", Offset = "0x44AA578", VA = "0x44AE578")]
			set
			{
			}
		}

		[Token(Token = "0x170002FC")]
		public Vector3 steeringTarget
		{
			[Token(Token = "0x6001274")]
			[Address(RVA = "0x44AE62C", Offset = "0x44AA62C", VA = "0x44AE62C", Slot = "37")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002FD")]
		public ManagedMovementOverrides movementOverrides
		{
			[Token(Token = "0x6001275")]
			[Address(RVA = "0x44AE6FC", Offset = "0x44AA6FC", VA = "0x44AE6FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002FE")]
Action IAstarAI.onSearchPath		{
			[Token(Token = "0x6001276")]
			[Address(RVA = "0x44AE76C", Offset = "0x44AA76C", VA = "0x44AE76C", Slot = "38")]
			get
			{
				return Pathfinding_002EIAstarAI_002Eget_onSearchPath();
			}
			[Token(Token = "0x6001277")]
			[Address(RVA = "0x44AE774", Offset = "0x44AA774", VA = "0x44AE774", Slot = "39")]
			set
			{
				Pathfinding_002EIAstarAI_002Eset_onSearchPath(value);
			}
		}

		[Token(Token = "0x6001226")]
		[Address(RVA = "0x44A8738", Offset = "0x44A4738", VA = "0x44A8738")]
		private static void InitScratchData()
		{
		}

		[Token(Token = "0x6001227")]
		[Address(RVA = "0x44A8918", Offset = "0x44A4918", VA = "0x44A8918")]
		private static void DisposeScratchData()
		{
		}

		[Token(Token = "0x6001228")]
		[Address(RVA = "0x44A8A8C", Offset = "0x44A4A8C", VA = "0x44A8A8C")]
		public FollowerEntityProxy(World world, Entity entity)
		{
		}

		[Token(Token = "0x600122B")]
		[Address(RVA = "0x44A8D34", Offset = "0x44A4D34", VA = "0x44A8D34")]
		private void AssertEntityExists()
		{
		}

		[Token(Token = "0x600125C")]
		[Address(RVA = "0x44ACA6C", Offset = "0x44A8A6C", VA = "0x44ACA6C")]
		public void SetDestination(float3 destination, [System.Runtime.InteropServices.Optional] float3 facingDirection)
		{
		}

		[Token(Token = "0x6001276")]
		[Address(RVA = "0x44AE76C", Offset = "0x44AA76C", VA = "0x44AE76C", Slot = "38")]
		private Action Pathfinding_002EIAstarAI_002Eget_onSearchPath()
		{
			return null;
		}

		[Token(Token = "0x6001277")]
		[Address(RVA = "0x44AE774", Offset = "0x44AA774", VA = "0x44AE774", Slot = "39")]
		private void Pathfinding_002EIAstarAI_002Eset_onSearchPath(Action value)
		{
		}

		[Token(Token = "0x6001278")]
		[Address(RVA = "0x44AE7C0", Offset = "0x44AA7C0", VA = "0x44AE7C0", Slot = "48")]
void IAstarAI.FinalizeMovement(Vector3 nextPosition, Quaternion nextRotation)
		{
		}

		[Token(Token = "0x6001279")]
		[Address(RVA = "0x44AE80C", Offset = "0x44AA80C", VA = "0x44AE80C", Slot = "41")]
		public void GetRemainingPath(List<Vector3> buffer, out bool stale)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FollowerEntityProxy.GetRemainingPath RVA=0x44AE80C Token=0x6001279");
}

		[Token(Token = "0x600127A")]
		[Address(RVA = "0x44AE87C", Offset = "0x44AA87C", VA = "0x44AE87C", Slot = "42")]
		public void GetRemainingPath(List<Vector3> buffer, List<PathPartWithLinkInfo> partsBuffer, out bool stale)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FollowerEntityProxy.GetRemainingPath RVA=0x44AE87C Token=0x600127A");
}

		[Token(Token = "0x600127B")]
		[Address(RVA = "0x44AF1AC", Offset = "0x44AB1AC", VA = "0x44AF1AC", Slot = "46")]
		public void Move(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x600127C")]
		[Address(RVA = "0x44AF230", Offset = "0x44AB230", VA = "0x44AF230", Slot = "47")]
void IAstarAI.MovementUpdate(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FollowerEntityProxy.MovementUpdate RVA=0x44AF230 Token=0x600127C");
}

		[Token(Token = "0x600127D")]
		[Address(RVA = "0x44AF27C", Offset = "0x44AB27C", VA = "0x44AF27C", Slot = "43")]
		public void SearchPath()
		{
		}

		[Token(Token = "0x600127E")]
		[Address(RVA = "0x44B0084", Offset = "0x44AC084", VA = "0x44B0084")]
		internal void CancelCurrentPathRequest()
		{
		}

		[Token(Token = "0x600127F")]
		[Address(RVA = "0x44B012C", Offset = "0x44AC12C", VA = "0x44B012C")]
		internal void ClearPath()
		{
		}

		[Token(Token = "0x6001280")]
		internal static void ToggleComponent<T>(World world, Entity entity, bool enabled, bool mustExist) where T : struct, IComponentData
		{
		}

		[Token(Token = "0x6001281")]
		internal static void ToggleComponentEnabled<T>(World world, Entity entity, bool enabled, bool mustExist) where T : struct, IComponentData, IEnableableComponent
		{
		}

		[Token(Token = "0x6001282")]
		[Address(RVA = "0x44B0900", Offset = "0x44AC900", VA = "0x44B0900")]
		internal static void ResetControl(ref ResolvedMovement resolvedMovement, ref MovementControl controlOutput, ref AgentMovementPlane movementPlane, float3 position, quaternion rotation, float3 endOfPath)
		{
		}

		[Token(Token = "0x6001283")]
		[Address(RVA = "0x44AF3D4", Offset = "0x44AB3D4", VA = "0x44AF3D4", Slot = "44")]
		public void SetPath(Path path, bool updateDestinationFromPath = true)
		{
		}

		[Token(Token = "0x6001284")]
		[Address(RVA = "0x44B0A04", Offset = "0x44ACA04", VA = "0x44B0A04", Slot = "45")]
		public void Teleport(Vector3 newPosition, bool clearPath = true)
		{
		}

		[Token(Token = "0x6001285")]
		[Address(RVA = "0x44B131C", Offset = "0x44AD31C", VA = "0x44B131C")]
		public void Destroy()
		{
		}
	}
}
