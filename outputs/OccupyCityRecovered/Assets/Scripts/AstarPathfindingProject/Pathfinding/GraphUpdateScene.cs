using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	[Token(Token = "0x2000064")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/graphupdatescene.html")]
	[AddComponentMenu("Pathfinding/GraphUpdateScene")]
	public class GraphUpdateScene : GraphModifier
	{
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x40")]
		public Vector3[] points;

		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x48")]
		private Vector3[] convexPoints;

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x50")]
		public bool convex;

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x54")]
		public float minBoundsHeight;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x58")]
		public int penaltyDelta;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x5C")]
		public bool modifyWalkability;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x5D")]
		public bool setWalkability;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x5E")]
		public bool applyOnStart;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x5F")]
		public bool applyOnScan;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x60")]
		public bool updatePhysics;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x61")]
		public bool resetPenaltyOnPhysics;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x62")]
		public bool updateErosion;

		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x63")]
		public bool modifyTag;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x64")]
		public PathfindingTag setTag;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public bool legacyMode;

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x6C")]
		private PathfindingTag setTagInvert;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x70")]
		private bool firstApplied;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x71")]
		[FormerlySerializedAs("useWorldSpace")]
		[SerializeField]
		private bool legacyUseWorldSpace;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		[FormerlySerializedAs("setTag")]
		private int setTagCompatibility;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color GizmoColorSelected;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color GizmoColorUnselected;

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x44F6B80", Offset = "0x44F2B80", VA = "0x44F6B80")]
		public void Start()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x44F6CE8", Offset = "0x44F2CE8", VA = "0x44F6CE8", Slot = "18")]
		public override void OnPostScan()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x44F6CF8", Offset = "0x44F2CF8", VA = "0x44F6CF8", Slot = "26")]
		public virtual void InvertSettings()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x44F6D4C", Offset = "0x44F2D4C", VA = "0x44F6D4C")]
		public void RecalcConvex()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x44F6DC0", Offset = "0x44F2DC0", VA = "0x44F6DC0")]
		public Bounds GetBounds()
		{
			return default;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x44F7318", Offset = "0x44F3318", VA = "0x44F7318", Slot = "27")]
		public virtual GraphUpdateObject GetGraphUpdate()
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x44F6BFC", Offset = "0x44F2BFC", VA = "0x44F6BFC")]
		public void Apply()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x44F7DAC", Offset = "0x44F3DAC", VA = "0x44F7DAC", Slot = "6")]
		public override void DrawGizmos()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x44F84EC", Offset = "0x44F44EC", VA = "0x44F84EC")]
		public void DisableLegacyMode()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x44F85BC", Offset = "0x44F45BC", VA = "0x44F85BC", Slot = "14")]
		protected override void OnUpgradeSerializedData(ref Migrations migrations, bool unityThread)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x44F8630", Offset = "0x44F4630", VA = "0x44F8630")]
		public GraphUpdateScene()
		{
		}
	}
}
