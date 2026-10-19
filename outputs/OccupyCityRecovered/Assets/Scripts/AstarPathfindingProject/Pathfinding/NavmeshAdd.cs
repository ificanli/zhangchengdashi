using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Util;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	[Token(Token = "0x2000129")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/navmeshadd.html")]
	public class NavmeshAdd : NavmeshClipper
	{
		[Token(Token = "0x200012A")]
		public enum MeshType
		{
			[Token(Token = "0x4000665")]
			Rectangle = 0,
			[Token(Token = "0x4000666")]
			CustomMesh = 1
		}

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MeshType type;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Mesh mesh;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3[] verts;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int[] tris;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector2 rectangleSize;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float meshScale;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 center;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("useRotation")]
		public bool useRotationAndScale;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Distance between positions to require an update of the navmesh\nA smaller distance gives better accuracy, but requires more updates when moving the object over time, so it is often slower.")]
		public float updateDistance;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("How many degrees rotation that is required for an update to the navmesh. Should be between 0 and 180.")]
		public float updateRotationDistance;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Transform tr;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color GizmoColor;

		[Token(Token = "0x170001C9")]
		public Vector3 Center
		{
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x4559BD8", Offset = "0x4555BD8", VA = "0x4559BD8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x4559974", Offset = "0x4555974", VA = "0x4559974", Slot = "19")]
		public override bool RequiresUpdate(GridLookup<NavmeshClipper>.Root previousState)
		{
			return default;
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x4559A7C", Offset = "0x4555A7C", VA = "0x4559A7C", Slot = "20")]
		public override void ForceUpdate()
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x4559B54", Offset = "0x4555B54", VA = "0x4559B54", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x4559B7C", Offset = "0x4555B7C", VA = "0x4559B7C", Slot = "17")]
		public override void NotifyUpdated(GridLookup<NavmeshClipper>.Root previousState)
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x4559C50", Offset = "0x4555C50", VA = "0x4559C50")]
		[ContextMenu("Rebuild Mesh")]
		public void RebuildMesh()
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x4559E94", Offset = "0x4555E94", VA = "0x4559E94", Slot = "18")]
		public override Bounds GetBounds(GraphTransform inverseTransform, float radiusMargin)
		{
			return default;
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x455A18C", Offset = "0x455618C", VA = "0x455A18C")]
		public void GetMesh(ref Int3[] vbuffer, out int[] tbuffer, out int vertexCount, [Optional] GraphTransform inverseTransform)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshAdd.GetMesh RVA=0x455A18C Token=0x60009D7");
}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x455A4FC", Offset = "0x45564FC", VA = "0x455A4FC")]
		public NavmeshAdd()
		{
		}
	}
}
