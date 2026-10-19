using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000089")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/nodelink3.html")]
	[AddComponentMenu("Pathfinding/Link3")]
	public class NodeLink3 : GraphModifier
	{
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x0")]
		protected static Dictionary<GraphNode, NodeLink3> reference;

		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x40")]
		public Transform end;

		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x48")]
		public float costFactor;

		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x50")]
		private NodeLink3Node startNode;

		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x58")]
		private NodeLink3Node endNode;

		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x60")]
		private MeshNode connectedNode1;

		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x68")]
		private MeshNode connectedNode2;

		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 clamped1;

		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 clamped2;

		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x88")]
		private bool postScanCalled;

		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Color GizmosColor;

		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Color GizmosColorSelected;

		[Token(Token = "0x170000F3")]
		public Transform StartTransform
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x4507E50", Offset = "0x4503E50", VA = "0x4507E50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F4")]
		public Transform EndTransform
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x4507E58", Offset = "0x4503E58", VA = "0x4507E58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F5")]
		public GraphNode StartNode
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x4507E60", Offset = "0x4503E60", VA = "0x4507E60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F6")]
		public GraphNode EndNode
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x4507E68", Offset = "0x4503E68", VA = "0x4507E68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x4507DB8", Offset = "0x4503DB8", VA = "0x4507DB8")]
		public static NodeLink3 GetNodeLink(GraphNode node)
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x4507E70", Offset = "0x4503E70", VA = "0x4507E70", Slot = "18")]
		public override void OnPostScan()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x4507F78", Offset = "0x4503F78", VA = "0x4507F78")]
		public void InternalOnPostScan()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x4509250", Offset = "0x4505250", VA = "0x4509250", Slot = "25")]
		public override void OnGraphsPostUpdateBeforeAreaRecalculation()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x450934C", Offset = "0x450534C", VA = "0x450934C", Slot = "15")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x4509494", Offset = "0x4505494", VA = "0x4509494", Slot = "16")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x450960C", Offset = "0x450560C", VA = "0x450960C")]
		private void RemoveConnections(GraphNode node)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x4509630", Offset = "0x4505630", VA = "0x4509630")]
		[ContextMenu("Recalculate neighbours")]
		private void ContextApplyForce()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x4508260", Offset = "0x4504260", VA = "0x4508260")]
		public void Apply(bool forceNewCheck)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x450978C", Offset = "0x450578C", VA = "0x450978C", Slot = "6")]
		public override void DrawGizmos()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x4509DD0", Offset = "0x4505DD0", VA = "0x4509DD0")]
		public NodeLink3()
		{
		}
	}
}
