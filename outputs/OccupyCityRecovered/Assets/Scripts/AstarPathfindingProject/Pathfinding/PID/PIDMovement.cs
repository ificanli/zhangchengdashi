using System;
using Il2CppDummyDll;
using Pathfinding.Drawing;
using Pathfinding.Util;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding.PID
{
	[Serializable]
	[Token(Token = "0x200025C")]
	[BurstCompile]
	public struct PIDMovement
	{
		[Token(Token = "0x200025D")]
		public struct PersistentState
		{
			[Token(Token = "0x4000B19")]
			[FieldOffset(Offset = "0x0")]
			public float maxDesiredWallDistance;
		}

		[Token(Token = "0x200025E")]
		[Flags]
		public enum DebugFlags
		{
			[Token(Token = "0x4000B1B")]
			Nothing = 0,
			[Token(Token = "0x4000B1C")]
			Position = 1,
			[Token(Token = "0x4000B1D")]
			Tangent = 2,
			[Token(Token = "0x4000B1E")]
			SidewaysClearance = 4,
			[Token(Token = "0x4000B1F")]
			ForwardClearance = 8,
			[Token(Token = "0x4000B20")]
			Obstacles = 0x10,
			[Token(Token = "0x4000B21")]
			Funnel = 0x20,
			[Token(Token = "0x4000B22")]
			Path = 0x40,
			[Token(Token = "0x4000B23")]
			ApproachWithOrientation = 0x80,
			[Token(Token = "0x4000B24")]
			Rotation = 0x100
		}

		[Token(Token = "0x200025F")]
		private struct EdgeBuffers
		{
			[Token(Token = "0x4000B25")]
			[FieldOffset(Offset = "0x0")]
			public FixedList512Bytes<float2> triangleRegionEdgesL;

			[Token(Token = "0x4000B26")]
			[FieldOffset(Offset = "0x200")]
			public FixedList512Bytes<float2> triangleRegionEdgesR;

			[Token(Token = "0x4000B27")]
			[FieldOffset(Offset = "0x400")]
			public FixedList512Bytes<float2> straightRegionEdgesL;

			[Token(Token = "0x4000B28")]
			[FieldOffset(Offset = "0x600")]
			public FixedList512Bytes<float2> straightRegionEdgesR;
		}

		[Token(Token = "0x2000260")]
		public struct ControlParams
		{
			[Token(Token = "0x4000B29")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 p;

			[Token(Token = "0x4000B2A")]
			[FieldOffset(Offset = "0xC")]
			public float speed;

			[Token(Token = "0x4000B2B")]
			[FieldOffset(Offset = "0x10")]
			public float rotation;

			[Token(Token = "0x4000B2C")]
			[FieldOffset(Offset = "0x14")]
			public float maxDesiredWallDistance;

			[Token(Token = "0x4000B2D")]
			[FieldOffset(Offset = "0x18")]
			public float3 endOfPath;

			[Token(Token = "0x4000B2E")]
			[FieldOffset(Offset = "0x24")]
			public float3 facingDirectionAtEndOfPath;

			[Token(Token = "0x4000B2F")]
			[FieldOffset(Offset = "0x30")]
			public NativeArray<float2> edges;

			[Token(Token = "0x4000B30")]
			[FieldOffset(Offset = "0x40")]
			public float3 nextCorner;

			[Token(Token = "0x4000B31")]
			[FieldOffset(Offset = "0x4C")]
			public float agentRadius;

			[Token(Token = "0x4000B32")]
			[FieldOffset(Offset = "0x50")]
			public float remainingDistance;

			[Token(Token = "0x4000B33")]
			[FieldOffset(Offset = "0x54")]
			public float3 closestOnNavmesh;

			[Token(Token = "0x4000B34")]
			[FieldOffset(Offset = "0x60")]
			public DebugFlags debugFlags;

			[Token(Token = "0x4000B35")]
			[FieldOffset(Offset = "0x64")]
			public NativeMovementPlane movementPlane;
		}

		[Token(Token = "0x4000B06")]
		[FieldOffset(Offset = "0x0")]
		public float rotationSpeed;

		[Token(Token = "0x4000B07")]
		[FieldOffset(Offset = "0x4")]
		public float speed;

		[Token(Token = "0x4000B08")]
		[FieldOffset(Offset = "0x8")]
		public float maxRotationSpeed;

		[Token(Token = "0x4000B09")]
		[FieldOffset(Offset = "0xC")]
		public float maxOnSpotRotationSpeed;

		[Token(Token = "0x4000B0A")]
		[FieldOffset(Offset = "0x10")]
		public float slowdownTime;

		[Token(Token = "0x4000B0B")]
		[FieldOffset(Offset = "0x14")]
		public float slowdownTimeWhenTurningOnSpot;

		[Token(Token = "0x4000B0C")]
		[FieldOffset(Offset = "0x18")]
		public float desiredWallDistance;

		[Token(Token = "0x4000B0D")]
		[FieldOffset(Offset = "0x1C")]
		public float leadInRadiusWhenApproachingDestination;

		[Token(Token = "0x4000B0E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private byte allowRotatingOnSpotBacking;

		[Token(Token = "0x4000B0F")]
		public const float DESTINATION_CLEARANCE_FACTOR = 4f;

		[Token(Token = "0x4000B10")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerSidewaysAvoidance = new ProfilerMarker("SidewaysAvoidance");

		[Token(Token = "0x4000B11")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker MarkerPID = new ProfilerMarker("PID");

		[Token(Token = "0x4000B12")]
		[FieldOffset(Offset = "0x10")]
		private static readonly ProfilerMarker MarkerOptimizeDirection = new ProfilerMarker("OptimizeDirection");

		[Token(Token = "0x4000B13")]
		[FieldOffset(Offset = "0x18")]
		private static readonly ProfilerMarker MarkerSmallestDistance = new ProfilerMarker("ClosestDistance");

		[Token(Token = "0x4000B14")]
		[FieldOffset(Offset = "0x20")]
		private static readonly ProfilerMarker MarkerConvertObstacles = new ProfilerMarker("ConvertObstacles");

		[Token(Token = "0x4000B15")]
		private const float ALLOWED_OVERLAP_FACTOR = 0.1f;

		[Token(Token = "0x4000B16")]
		private const float STEP_MULTIPLIER = 1f;

		[Token(Token = "0x4000B17")]
		private const float MAX_FRACTION_OF_REMAINING_DISTANCE = 0.9f;

		[Token(Token = "0x4000B18")]
		private const int OPTIMIZATION_ITERATIONS = 8;

		[Token(Token = "0x1700022D")]
		public bool allowRotatingOnSpot
		{
			[Token(Token = "0x6000ED7")]
			[Address(RVA = "0x4486CB8", Offset = "0x4482CB8", VA = "0x4486CB8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000ED8")]
			[Address(RVA = "0x4486CC8", Offset = "0x4482CC8", VA = "0x4486CC8")]
			set
			{ allowRotatingOnSpotBacking = value ? (byte)1 : (byte)0; }
		}

		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x4486CD4", Offset = "0x4482CD4", VA = "0x4486CD4")]
		public void ScaleByAgentScale(float agentScale)
		{
		}

		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x4486CF0", Offset = "0x4482CF0", VA = "0x4486CF0")]
		public float Speed(float remainingDistance)
		{
			return default;
		}

		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x4486D48", Offset = "0x4482D48", VA = "0x4486D48")]
		public float Accelerate(float speed, float timeToReachMaxSpeed, float dt)
		{
			return default;
		}

		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x4486DB0", Offset = "0x4482DB0", VA = "0x4486DB0")]
		public float CurveFollowingStrength(float signedDistToClearArea, float radiusToWall, float remainingDistance)
		{
			return default;
		}

		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0x4486F7C", Offset = "0x4482F7C", VA = "0x4486F7C")]
		private static bool ClipLineByHalfPlaneX(ref float2 a, ref float2 b, float x, float side)
		{
			return default;
		}

		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x4487008", Offset = "0x4483008", VA = "0x4487008")]
		private static void ClipLineByHalfPlaneYt(float2 a, float2 b, float y, float side, ref float mnT, ref float mxT)
		{
		}

		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x44870AC", Offset = "0x44830AC", VA = "0x44870AC")]
		private static float2 MaxAngle(float2 a, float2 b, float2 c, bool clockwise)
		{
			return default;
		}

		[Token(Token = "0x6000EE0")]
		[Address(RVA = "0x448713C", Offset = "0x448313C", VA = "0x448713C")]
		private static float2 MaxAngle(float2 a, float2 b, bool clockwise)
		{
			return default;
		}

		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x448718C", Offset = "0x448318C", VA = "0x448718C")]
		private static void DrawChisel(float2 start, float2 direction, float pointiness, float length, float width, CommandBuilder draw, Color col)
		{
		}

		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0x4487458", Offset = "0x4483458", VA = "0x4487458")]
		private static void SplitSegment(float2 e1, float2 e2, float desiredRadius, float length, float pointiness, ref EdgeBuffers buffers)
		{
		}

		[Token(Token = "0x6000EE3")]
		[Address(RVA = "0x44876F4", Offset = "0x44836F4", VA = "0x44876F4")]
		private static void SplitSegment2(float2 e1, float2 e2, float desiredRadius, float pointiness, ref EdgeBuffers buffers)
		{
		}

		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x44879BC", Offset = "0x44839BC", VA = "0x44879BC")]
		private static void SplitSegment3(float2 e1, float2 e2, float desiredRadius, bool inTriangularRegion, ref EdgeBuffers buffers)
		{
		}

		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x4487C0C", Offset = "0x4483C0C", VA = "0x4487C0C")]
		private static void SplitSegment4(float2 e1, float2 e2, bool inTriangularRegion, bool left, ref EdgeBuffers buffers)
		{
		}

		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x4487DB0", Offset = "0x4483DB0", VA = "0x4487DB0")]
		public static float2 OptimizeDirection(float2 start, float2 end, float desiredRadius, float remainingDistance, float pointiness, NativeArray<float2> edges, CommandBuilder draw, DebugFlags debugFlags)
		{
			return default;
		}

		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0x4488968", Offset = "0x4484968", VA = "0x4488968")]
		public static float SmallestDistanceWithinWedge(float2 point, float2 dir1, float2 dir2, float shrinkAmount, NativeArray<float2> edges)
		{
			return default;
		}

		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x4488D8C", Offset = "0x4484D8C", VA = "0x4488D8C")]
		public static float2 Linecast(float2 a, float2 b, NativeArray<float2> edges)
		{
			return default;
		}

		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0x4488E8C", Offset = "0x4484E8C", VA = "0x4488E8C")]
		public static Bounds InterestingEdgeBounds(ref PIDMovement settings, float3 position, float3 nextCorner, float height, NativeMovementPlane plane)
		{
			return default;
		}

		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0x44890D8", Offset = "0x44850D8", VA = "0x44890D8")]
		private static float2 OffsetCornerForApproach(float2 position2D, float2 endOfPath2D, float2 facingDir2D, ref PIDMovement settings, float2 nextCorner2D, ref float gammaAngle, ref float gammaAngleWeight, DebugFlags debugFlags, ref CommandBuilder draw, NativeArray<float2> edges)
		{
			return default;
		}

		[Token(Token = "0x6000EEB")]
		[Address(RVA = "0x4489728", Offset = "0x4485728", VA = "0x4489728")]
		public static AnglePIDControlOutput2D Control(ref PIDMovement settings, float dt, ref ControlParams controlParams, ref CommandBuilder draw, out float maxDesiredWallDistance)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PIDMovement.Control RVA=0x4489728 Token=0x6000EEB");
}
	}
}
