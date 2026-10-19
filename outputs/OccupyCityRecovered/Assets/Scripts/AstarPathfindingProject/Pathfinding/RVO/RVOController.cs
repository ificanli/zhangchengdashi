using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002D6")]
	[UniqueComponent(tag = "rvo")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/rvocontroller.html")]
	[AddComponentMenu("Pathfinding/Local Avoidance/RVO Controller")]
	public class RVOController : VersionedMonoBehaviour
	{
		[Token(Token = "0x20002D7")]
		[Flags]
		private enum RVOControllerMigrations
		{
			[Token(Token = "0x4000D32")]
			MigrateScale = 0
		}

		[Token(Token = "0x4000D1B")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("radius")]
		[SerializeField]
		internal float radiusBackingField;

		[Token(Token = "0x4000D1C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[FormerlySerializedAs("height")]
		private float heightBackingField;

		[Token(Token = "0x4000D1D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("center")]
		private float centerBackingField;

		[Token(Token = "0x4000D1E")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("A locked unit cannot move. Other units will still avoid it. But avoidance quality is not the best")]
		public bool locked;

		[Token(Token = "0x4000D1F")]
		[FieldOffset(Offset = "0x35")]
		[Tooltip("Automatically set #locked to true when desired velocity is approximately zero")]
		public bool lockWhenNotMoving;

		[Token(Token = "0x4000D20")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("How far into the future to look for collisions with other agents (in seconds)")]
		public float agentTimeHorizon;

		[Token(Token = "0x4000D21")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("How far into the future to look for collisions with obstacles (in seconds)")]
		public float obstacleTimeHorizon;

		[Token(Token = "0x4000D22")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Max number of other agents to take into account.\nA smaller value can reduce CPU load, a higher value can lead to better local avoidance quality.")]
		public int maxNeighbours;

		[Token(Token = "0x4000D23")]
		[FieldOffset(Offset = "0x44")]
		public RVOLayer layer;

		[Token(Token = "0x4000D24")]
		[FieldOffset(Offset = "0x48")]
		[EnumFlag]
		public RVOLayer collidesWith;

		[Token(Token = "0x4000D25")]
		[FieldOffset(Offset = "0x4C")]
		[Obsolete]
		[HideInInspector]
		public float wallAvoidForce;

		[Token(Token = "0x4000D26")]
		[FieldOffset(Offset = "0x50")]
		[Obsolete]
		[HideInInspector]
		public float wallAvoidFalloff;

		[Token(Token = "0x4000D27")]
		[FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		[Tooltip("How strongly other agents will avoid this agent")]
		public float priority;

		[NonSerialized]
		[Token(Token = "0x4000D28")]
		[FieldOffset(Offset = "0x58")]
		public float priorityMultiplier;

		[NonSerialized]
		[Token(Token = "0x4000D29")]
		[FieldOffset(Offset = "0x5C")]
		public float flowFollowingStrength;

		[Token(Token = "0x4000D2A")]
		[FieldOffset(Offset = "0x60")]
		private GraphNode obstacleQuery;

		[Token(Token = "0x4000D2D")]
		[FieldOffset(Offset = "0x78")]
		protected Transform tr;

		[Token(Token = "0x4000D2E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[FormerlySerializedAs("ai")]
		private IAstarAI aiBackingField;

		[Token(Token = "0x4000D2F")]
		[FieldOffset(Offset = "0x88")]
		internal SimpleMovementPlane movementPlaneBackingField;

		[Token(Token = "0x4000D30")]
		[FieldOffset(Offset = "0xAC")]
		public AgentDebugFlags debug;

		[Token(Token = "0x170002B6")]
		public float radius
		{
			[Token(Token = "0x60011D9")]
			[Address(RVA = "0x44A4B68", Offset = "0x44A0B68", VA = "0x44A4B68")]
			get
			{
				return default;
			}
			[Token(Token = "0x60011DA")]
			[Address(RVA = "0x44A4CF4", Offset = "0x44A0CF4", VA = "0x44A4CF4")]
			set
			{
			}
		}

		[Token(Token = "0x170002B7")]
		public float height
		{
			[Token(Token = "0x60011DB")]
			[Address(RVA = "0x44A4DC4", Offset = "0x44A0DC4", VA = "0x44A4DC4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60011DC")]
			[Address(RVA = "0x44A4E8C", Offset = "0x44A0E8C", VA = "0x44A4E8C")]
			set
			{
			}
		}

		[Token(Token = "0x170002B8")]
		public float center
		{
			[Token(Token = "0x60011DD")]
			[Address(RVA = "0x44A4F5C", Offset = "0x44A0F5C", VA = "0x44A4F5C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60011DE")]
			[Address(RVA = "0x44A5028", Offset = "0x44A1028", VA = "0x44A5028")]
			set
			{
			}
		}

		[Token(Token = "0x170002B9")]
		public MovementPlane movementPlaneMode
		{
			[Token(Token = "0x60011DF")]
			[Address(RVA = "0x44A5030", Offset = "0x44A1030", VA = "0x44A5030")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002BA")]
		public SimpleMovementPlane movementPlane
		{
			[Token(Token = "0x60011E0")]
			[Address(RVA = "0x44A5094", Offset = "0x44A1094", VA = "0x44A5094")]
			get
			{
				return default;
			}
			[Token(Token = "0x60011E1")]
			[Address(RVA = "0x44A521C", Offset = "0x44A121C", VA = "0x44A521C")]
			set
			{
			}
		}

		[Token(Token = "0x170002BB")]
		public IAgent rvoAgent
		{
			[Token(Token = "0x60011E2")]
			[Address(RVA = "0x44A5370", Offset = "0x44A1370", VA = "0x44A5370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60011E3")]
			[Address(RVA = "0x44A5378", Offset = "0x44A1378", VA = "0x44A5378")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170002BC")]
		private SimulatorBurst simulator
		{
			[Token(Token = "0x60011E4")]
			[Address(RVA = "0x44A5380", Offset = "0x44A1380", VA = "0x44A5380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60011E5")]
			[Address(RVA = "0x44A5388", Offset = "0x44A1388", VA = "0x44A5388")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170002BD")]
		protected IAstarAI ai
		{
			[Token(Token = "0x60011E6")]
			[Address(RVA = "0x44A4C2C", Offset = "0x44A0C2C", VA = "0x44A4C2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011E7")]
			[Address(RVA = "0x44A5390", Offset = "0x44A1390", VA = "0x44A5390")]
			set
			{
			}
		}

		[Token(Token = "0x170002BE")]
		public Vector3 position
		{
			[Token(Token = "0x60011E8")]
			[Address(RVA = "0x44A5398", Offset = "0x44A1398", VA = "0x44A5398")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002BF")]
		public Vector3 velocity
		{
			[Token(Token = "0x60011E9")]
			[Address(RVA = "0x44A544C", Offset = "0x44A144C", VA = "0x44A544C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60011EA")]
			[Address(RVA = "0x44A55A0", Offset = "0x44A15A0", VA = "0x44A55A0")]
			set
			{
			}
		}

		[Token(Token = "0x170002C0")]
		public bool AvoidingAnyAgents
		{
			[Token(Token = "0x60011ED")]
			[Address(RVA = "0x44A5904", Offset = "0x44A1904", VA = "0x44A5904")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x44A54AC", Offset = "0x44A14AC", VA = "0x44A54AC")]
		public Vector3 CalculateMovementDelta(float deltaTime)
		{
			return default;
		}

		[Token(Token = "0x60011EC")]
		[Address(RVA = "0x44A567C", Offset = "0x44A167C", VA = "0x44A567C")]
		public Vector3 CalculateMovementDelta(Vector3 position, float deltaTime)
		{
			return default;
		}

		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x44A59B4", Offset = "0x44A19B4", VA = "0x44A59B4")]
		public void SetCollisionNormal(Vector3 normal)
		{
		}

		[Token(Token = "0x60011EF")]
		[Address(RVA = "0x44A5A90", Offset = "0x44A1A90", VA = "0x44A5A90")]
		public void SetObstacleQuery(GraphNode sourceNode)
		{
		}

		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x44A5A98", Offset = "0x44A1A98", VA = "0x44A5A98")]
		public Vector2 To2D(Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x44A5B3C", Offset = "0x44A1B3C", VA = "0x44A5B3C")]
		public Vector2 To2D(Vector3 p, out float elevation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RVOController.To2D RVA=0x44A5B3C Token=0x60011F1");
}

		[Token(Token = "0x60011F2")]
		[Address(RVA = "0x44A5BF0", Offset = "0x44A1BF0", VA = "0x44A5BF0")]
		public Vector3 To3D(Vector2 p, float elevationCoordinate)
		{
			return default;
		}

		[Token(Token = "0x60011F3")]
		[Address(RVA = "0x44A5C94", Offset = "0x44A1C94", VA = "0x44A5C94")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60011F4")]
		[Address(RVA = "0x44A5CBC", Offset = "0x44A1CBC", VA = "0x44A5CBC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60011F5")]
		[Address(RVA = "0x44A60C8", Offset = "0x44A20C8", VA = "0x44A60C8")]
		private void OnAgentDestroyed()
		{
		}

		[Token(Token = "0x60011F6")]
		[Address(RVA = "0x44A610C", Offset = "0x44A210C", VA = "0x44A610C")]
		protected void UpdateAgentProperties()
		{
		}

		[Token(Token = "0x60011F7")]
		[Address(RVA = "0x44A6AE8", Offset = "0x44A2AE8", VA = "0x44A6AE8")]
		public void SetTarget(Vector3 pos, float speed, float maxSpeed, Vector3 endOfPath)
		{
		}

		[Token(Token = "0x60011F8")]
		[Address(RVA = "0x44A6C24", Offset = "0x44A2C24", VA = "0x44A6C24")]
		public void Move(Vector3 velocity)
		{
		}

		[Token(Token = "0x60011F9")]
		[Address(RVA = "0x44A6EAC", Offset = "0x44A2EAC", VA = "0x44A6EAC", Slot = "6")]
		public override void DrawGizmos()
		{
		}

		[Token(Token = "0x60011FA")]
		[Address(RVA = "0x44A7180", Offset = "0x44A3180", VA = "0x44A7180", Slot = "14")]
		protected override void OnUpgradeSerializedData(ref Migrations migrations, bool unityThread)
		{
		}

		[Token(Token = "0x60011FB")]
		[Address(RVA = "0x44A72D0", Offset = "0x44A32D0", VA = "0x44A72D0")]
		public RVOController()
		{
		}
	}
}
