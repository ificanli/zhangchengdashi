using FishFlock.Utils;
using Il2CppDummyDll;
using UnityEngine;

namespace FishFlock
{
	[Token(Token = "0x2000DDC")]
	public class FishFlockController : MonoBehaviour
	{
		[Token(Token = "0x400610F")]
		[FieldOffset(Offset = "0x20")]
		public float swimmingAreaWidth;

		[Token(Token = "0x4006110")]
		[FieldOffset(Offset = "0x24")]
		public float swimmingAreaHeight;

		[Token(Token = "0x4006111")]
		[FieldOffset(Offset = "0x28")]
		public float swimmingAreaDepth;

		[Token(Token = "0x4006112")]
		[FieldOffset(Offset = "0x2C")]
		public FishMovementAxis FishMovementAxis;

		[Token(Token = "0x4006113")]
		[FieldOffset(Offset = "0x30")]
		public bool debugDraw;

		[Token(Token = "0x4006114")]
		[FieldOffset(Offset = "0x34")]
		public FlockRenderingMode renderingMode;

		[Token(Token = "0x4006115")]
		[FieldOffset(Offset = "0x38")]
		public FlockComputationMode computationMode;

		[Token(Token = "0x4006116")]
		[FieldOffset(Offset = "0x3C")]
		public int fishesCount;

		[Token(Token = "0x4006117")]
		[FieldOffset(Offset = "0x40")]
		[MinMax(0f, 10f)]
		public Vector2 speed;

		[Token(Token = "0x4006118")]
		[FieldOffset(Offset = "0x48")]
		[MinMax(0f, 10f)]
		public Vector2 rotation;

		[Token(Token = "0x4006119")]
		[FieldOffset(Offset = "0x50")]
		public float neighbourDistance;

		[Token(Token = "0x400611A")]
		[FieldOffset(Offset = "0x54")]
		public float spawnRadius;

		[Token(Token = "0x400611B")]
		[FieldOffset(Offset = "0x58")]
		[MinMax(0f, 10f)]
		public Vector2 scale;

		[Token(Token = "0x400611C")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 cohesionScale;

		[Token(Token = "0x400611D")]
		[FieldOffset(Offset = "0x6C")]
		public bool followTarget;

		[Token(Token = "0x400611E")]
		[FieldOffset(Offset = "0x70")]
		public Transform target;

		[Token(Token = "0x400611F")]
		[FieldOffset(Offset = "0x78")]
		[MinMax(1f, 5f)]
		public Vector2Int targetPointsAmount;

		[Token(Token = "0x4006120")]
		[FieldOffset(Offset = "0x80")]
		public bool recalculatePoints;

		[Token(Token = "0x4006121")]
		[FieldOffset(Offset = "0x84")]
		public float groupAreaSpeed;

		[Token(Token = "0x4006122")]
		[FieldOffset(Offset = "0x88")]
		private Vector3[] targetPositions;

		[Token(Token = "0x4006123")]
		[FieldOffset(Offset = "0x90")]
		private int currentTargetPosIndex;

		[Token(Token = "0x4006124")]
		[FieldOffset(Offset = "0x98")]
		public FlockGfxProfile gfxProfile;

		[Token(Token = "0x4006125")]
		[FieldOffset(Offset = "0xA0")]
		public ComputeShader computeShader;

		[Token(Token = "0x4006126")]
		[FieldOffset(Offset = "0xA8")]
		public int lookAheadSteps;

		[Token(Token = "0x4006127")]
		[FieldOffset(Offset = "0xAC")]
		public float force;

		[Token(Token = "0x4006128")]
		[FieldOffset(Offset = "0xB0")]
		public float colliderSizeOffset;

		[Token(Token = "0x4006129")]
		[FieldOffset(Offset = "0xB8")]
		public Collider[] colliders;

		[Token(Token = "0x400612A")]
		[FieldOffset(Offset = "0xC0")]
		public bool updateAtRuntime;

		[Token(Token = "0x400612B")]
		[FieldOffset(Offset = "0xC8")]
		private CollisionArea[] collisionData;

		[Token(Token = "0x400612C")]
		[FieldOffset(Offset = "0xD0")]
		private int collisionDataLength;

		[Token(Token = "0x400612D")]
		[FieldOffset(Offset = "0xD4")]
		[HideInInspector]
		public Vector3 groupAnchor;

		[Token(Token = "0x400612E")]
		[FieldOffset(Offset = "0xE0")]
		private Transform myTransform;

		[Token(Token = "0x400612F")]
		[FieldOffset(Offset = "0xE8")]
		private Bounds instancingBounds;

		[Token(Token = "0x4006130")]
		[FieldOffset(Offset = "0x100")]
		private ComputeBuffer fishBuffer;

		[Token(Token = "0x4006131")]
		[FieldOffset(Offset = "0x108")]
		private ComputeBuffer drawArgsBuffer;

		[Token(Token = "0x4006132")]
		[FieldOffset(Offset = "0x110")]
		private ComputeBuffer collisionBuffer;

		[Token(Token = "0x4006133")]
		[FieldOffset(Offset = "0x118")]
		private MaterialPropertyBlock props;

		[Token(Token = "0x4006134")]
		[FieldOffset(Offset = "0x120")]
		private int kernelHandle;

		[Token(Token = "0x4006135")]
		private const int GROUP_SIZE = 256;

		[Token(Token = "0x4006136")]
		[FieldOffset(Offset = "0x128")]
		public FishData[] fishesData;

		[Token(Token = "0x4006137")]
		[FieldOffset(Offset = "0x130")]
		private Transform[] fishesTransforms;

		[Token(Token = "0x4006138")]
		[FieldOffset(Offset = "0x138")]
		private int currentFishesCount;

		[Token(Token = "0x4006139")]
		[FieldOffset(Offset = "0x13C")]
		private int oldFishesCount;

		[Token(Token = "0x400613A")]
		[FieldOffset(Offset = "0x140")]
		private SimpleCounter refreshFishCounter;

		[Token(Token = "0x400613B")]
		[FieldOffset(Offset = "0x148")]
		private SimpleCounter refreshCollisionCounter;

		[Token(Token = "0x400613C")]
		[FieldOffset(Offset = "0x150")]
		private SimpleCounter refreshPredatorsCounter;

		[Token(Token = "0x400613D")]
		[FieldOffset(Offset = "0x158")]
		private float _neighbourDistance;

		[Token(Token = "0x400613E")]
		[FieldOffset(Offset = "0x15C")]
		private float intendedNeighbourDistance;

		[Token(Token = "0x400613F")]
		[FieldOffset(Offset = "0x160")]
		private float neighbourDistanceRateSmoothRate;

		[Token(Token = "0x4006140")]
		[FieldOffset(Offset = "0x168")]
		private Material _fishInstancedMaterial;

		[Token(Token = "0x4006141")]
		[FieldOffset(Offset = "0x170")]
		private bool initialized;

		[Token(Token = "0x4006142")]
		[FieldOffset(Offset = "0x178")]
		private Vector3[] oldPositions;

		[Token(Token = "0x4006143")]
		[FieldOffset(Offset = "0x180")]
		private float unityTime;

		[Token(Token = "0x4006144")]
		[FieldOffset(Offset = "0x184")]
		private float unityDeltaTime;

		[Token(Token = "0x4006145")]
		[FieldOffset(Offset = "0x188")]
		private ThreadProcess threadProcess;

		[Token(Token = "0x4006146")]
		[FieldOffset(Offset = "0x190")]
		private FlockPredator[] predators;

		[Token(Token = "0x4006147")]
		[FieldOffset(Offset = "0x198")]
		private ComputeBuffer predatorsBuffer;

		[Token(Token = "0x4006148")]
		[FieldOffset(Offset = "0x1A0")]
		private PredatorData[] predatorsData;

		[Token(Token = "0x4006149")]
		[FieldOffset(Offset = "0x1A8")]
		private int predatorsCount;

		[Token(Token = "0x400614A")]
		[FieldOffset(Offset = "0x1AC")]
		private Vector3 volumeSize;

		[Token(Token = "0x60055EE")]
		[Address(RVA = "0x43363F0", Offset = "0x43323F0", VA = "0x43363F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60055EF")]
		[Address(RVA = "0x4336870", Offset = "0x4332870", VA = "0x4336870")]
		private void InitializeFishes()
		{
		}

		[Token(Token = "0x60055F0")]
		[Address(RVA = "0x4336A68", Offset = "0x4332A68", VA = "0x4336A68")]
		private void UpdateCollisionData()
		{
		}

		[Token(Token = "0x60055F1")]
		[Address(RVA = "0x4336F3C", Offset = "0x4332F3C", VA = "0x4336F3C")]
		private void CreateFishData()
		{
		}

		[Token(Token = "0x60055F2")]
		[Address(RVA = "0x4337698", Offset = "0x4333698", VA = "0x4337698")]
		private FishData CreateBehaviour()
		{
			return default;
		}

		[Token(Token = "0x60055F3")]
		[Address(RVA = "0x433782C", Offset = "0x433382C", VA = "0x433782C")]
		private Vector3 Evade(FishData data, Vector3 positionToEvade, Vector3 vel)
		{
			return default;
		}

		[Token(Token = "0x60055F4")]
		[Address(RVA = "0x4337938", Offset = "0x4333938", VA = "0x4337938")]
		private Vector3 Flee(FishData data, Vector3 positionToEvade)
		{
			return default;
		}

		[Token(Token = "0x60055F5")]
		[Address(RVA = "0x4337A50", Offset = "0x4333A50", VA = "0x4337A50")]
		private void ComputeFlockBehaviours()
		{
		}

		[Token(Token = "0x60055F6")]
		[Address(RVA = "0x43384F0", Offset = "0x43344F0", VA = "0x43384F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60055F7")]
		[Address(RVA = "0x4339464", Offset = "0x4335464", VA = "0x4339464")]
		private void Rendering()
		{
		}

		[Token(Token = "0x60055F8")]
		[Address(RVA = "0x4339578", Offset = "0x4335578", VA = "0x4339578")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60055F9")]
		[Address(RVA = "0x4338E50", Offset = "0x4334E50", VA = "0x4338E50")]
		private void ClearAll()
		{
		}

		[Token(Token = "0x60055FA")]
		[Address(RVA = "0x43390C4", Offset = "0x43350C4", VA = "0x43390C4")]
		private void UpdateGroupAnchor()
		{
		}

		[Token(Token = "0x60055FB")]
		[Address(RVA = "0x43367B0", Offset = "0x43327B0", VA = "0x43367B0")]
		private void GeneratePath()
		{
		}

		[Token(Token = "0x60055FC")]
		[Address(RVA = "0x43397D8", Offset = "0x43357D8", VA = "0x43397D8")]
		public void SetGroupPosition(Vector3 at)
		{
		}

		[Token(Token = "0x60055FD")]
		[Address(RVA = "0x43396C0", Offset = "0x43356C0", VA = "0x43396C0")]
		public Vector3 RandomPos()
		{
			return default;
		}

		[Token(Token = "0x60055FE")]
		[Address(RVA = "0x4339904", Offset = "0x4335904", VA = "0x4339904")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60055FF")]
		[Address(RVA = "0x43384BC", Offset = "0x43344BC", VA = "0x43384BC")]
		private Vector3 GetSeparationVector(Vector3 diff, float len)
		{
			return default;
		}

		[Token(Token = "0x6005600")]
		[Address(RVA = "0x43384A0", Offset = "0x43344A0", VA = "0x43384A0")]
		private float VecMag(Vector3 v)
		{
			return default;
		}

		[Token(Token = "0x6005601")]
		[Address(RVA = "0x4339AE8", Offset = "0x4335AE8", VA = "0x4339AE8")]
		private Vector3 VecNormalized(Vector3 v)
		{
			return default;
		}

		[Token(Token = "0x6005602")]
		[Address(RVA = "0x4339B0C", Offset = "0x4335B0C", VA = "0x4339B0C")]
		public FishFlockController()
		{
		}
	}
}
