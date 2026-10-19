using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Serialization;
using Pathfinding.Util;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	[Token(Token = "0x200012C")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/navmeshcut.html")]
	[ExecuteAlways]
	[AddComponentMenu("Pathfinding/Navmesh/Navmesh Cut")]
	public class NavmeshCut : NavmeshClipper
	{
		[Token(Token = "0x200012D")]
		public enum MeshType
		{
			[Token(Token = "0x4000683")]
			Rectangle = 0,
			[Token(Token = "0x4000684")]
			Circle = 1,
			[Token(Token = "0x4000685")]
			CustomMesh = 2,
			[Token(Token = "0x4000686")]
			Box = 3,
			[Token(Token = "0x4000687")]
			Sphere = 4,
			[Token(Token = "0x4000688")]
			Capsule = 5
		}

		[Token(Token = "0x200012E")]
		public enum RadiusExpansionMode
		{
			[Token(Token = "0x400068A")]
			DontExpand = 0,
			[Token(Token = "0x400068B")]
			ExpandByAgentRadius = 1
		}

		[Token(Token = "0x200012F")]
		public struct Contour
		{
			[Token(Token = "0x400068C")]
			[FieldOffset(Offset = "0x0")]
			public float ymin;

			[Token(Token = "0x400068D")]
			[FieldOffset(Offset = "0x4")]
			public float ymax;

			[Token(Token = "0x400068E")]
			[FieldOffset(Offset = "0x8")]
			public List<Vector2> contour;
		}

		[Token(Token = "0x2000130")]
		public struct ContourBurst
		{
			[Token(Token = "0x400068F")]
			[FieldOffset(Offset = "0x0")]
			public int startIndex;

			[Token(Token = "0x4000690")]
			[FieldOffset(Offset = "0x4")]
			public int endIndex;

			[Token(Token = "0x4000691")]
			[FieldOffset(Offset = "0x8")]
			public float ymin;

			[Token(Token = "0x4000692")]
			[FieldOffset(Offset = "0xC")]
			public float ymax;
		}

		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Shape of the cut")]
		public MeshType type;

		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("The contour(s) of the mesh will be extracted. This mesh should only be a 2D surface, not a volume (see documentation).")]
		public Mesh mesh;

		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 rectangleSize;

		[Token(Token = "0x400066F")]
		[FieldOffset(Offset = "0x48")]
		public float circleRadius;

		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x4C")]
		public int circleResolution;

		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x50")]
		public float height;

		[Token(Token = "0x4000672")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("Scale of the custom mesh")]
		public float meshScale;

		[Token(Token = "0x4000673")]
		[FieldOffset(Offset = "0x58")]
		public Vector3 center;

		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("Distance between positions to require an update of the navmesh\nA smaller distance gives better accuracy, but requires more updates when moving the object over time, so it is often slower.")]
		public float updateDistance;

		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Only makes a split in the navmesh, but does not remove the geometry to make a hole")]
		public bool isDual;

		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0x6C")]
		public RadiusExpansionMode radiusExpansionMode;

		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0x70")]
		public bool cutsAddedGeom;

		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0x74")]
		[Tooltip("How many degrees rotation that is required for an update to the navmesh. Should be between 0 and 180.")]
		public float updateRotationDistance;

		[Token(Token = "0x4000679")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("Includes rotation in calculations. This is slower since a lot more matrix multiplications are needed but gives more flexibility.")]
		[FormerlySerializedAs("useRotation")]
		public bool useRotationAndScale;

		[Token(Token = "0x400067A")]
		[FieldOffset(Offset = "0x80")]
		private NativeList<float3> meshContourVertices;

		[Token(Token = "0x400067B")]
		[FieldOffset(Offset = "0x88")]
		private NativeList<ContourBurst> meshContours;

		[Token(Token = "0x400067C")]
		[FieldOffset(Offset = "0x90")]
		protected Transform tr;

		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0x98")]
		private Mesh lastMesh;

		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Vector2Int, int> edges;

		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<int, int> pointers;

		[Token(Token = "0x4000680")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Color GizmoColor;

		[Token(Token = "0x4000681")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Color GizmoColor2;

		[Token(Token = "0x170001CB")]
		private Matrix4x4 contourTransformationMatrix
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x455BC64", Offset = "0x4557C64", VA = "0x455BC64")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x455AD10", Offset = "0x4556D10", VA = "0x455AD10", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x455AD38", Offset = "0x4556D38", VA = "0x455AD38", Slot = "16")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x455ADD4", Offset = "0x4556DD4", VA = "0x455ADD4", Slot = "20")]
		public override void ForceUpdate()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x455AEAC", Offset = "0x4556EAC", VA = "0x455AEAC", Slot = "19")]
		public override bool RequiresUpdate(GridLookup<NavmeshClipper>.Root previousState)
		{
			return default;
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x455AFB4", Offset = "0x4556FB4", VA = "0x455AFB4", Slot = "21")]
		public virtual void UsedForCut()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x455AFB8", Offset = "0x4556FB8", VA = "0x455AFB8", Slot = "17")]
		public override void NotifyUpdated(GridLookup<NavmeshClipper>.Root previousState)
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x455B014", Offset = "0x4557014", VA = "0x455B014")]
		private void CalculateMeshContour()
		{
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x455B710", Offset = "0x4557710", VA = "0x455B710", Slot = "18")]
		public override Bounds GetBounds(GraphTransform inverseTransform, float radiusMargin)
		{
			return default;
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x455BD44", Offset = "0x4557D44", VA = "0x455BD44")]
		public void GetContour(List<Contour> buffer, Matrix4x4 matrix, float radiusMargin)
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x455BA54", Offset = "0x4557A54", VA = "0x455BA54")]
		public unsafe void GetContourBurst(UnsafeList<float2>* outputVertices, UnsafeList<ContourBurst>* outputContours, Matrix4x4 matrix, float radiusMargin)
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x455C08C", Offset = "0x455808C", VA = "0x455C08C")]
		private static NavmeshBase ClosestGraph(Vector3 position)
		{
			return null;
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x455C240", Offset = "0x4558240", VA = "0x455C240", Slot = "6")]
		public override void DrawGizmos()
		{
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x455D1A4", Offset = "0x45591A4", VA = "0x455D1A4", Slot = "14")]
		protected override void OnUpgradeSerializedData(ref Migrations migrations, bool unityThread)
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x455D1E8", Offset = "0x45591E8", VA = "0x455D1E8")]
		public NavmeshCut()
		{
		}
	}
}
