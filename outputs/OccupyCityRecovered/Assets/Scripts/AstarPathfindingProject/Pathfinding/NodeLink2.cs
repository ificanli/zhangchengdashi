using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000087")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/nodelink2.html")]
	[AddComponentMenu("Pathfinding/Link2")]
	public class NodeLink2 : GraphModifier
	{
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x40")]
		public Transform end;

		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x48")]
		public float costFactor;

		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x4C")]
		public bool oneWay;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x50")]
		public PathfindingTag pathfindingTag;

		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x54")]
		public GraphMask graphMask;

		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x58")]
		protected OffMeshLinks.OffMeshLinkSource linkSource;

		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x60")]
		private IOffMeshLinkHandler onTraverseOffMeshLinkHandler;

		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color GizmosColor;

		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color GizmosColorSelected;

		[Token(Token = "0x170000EF")]
		public Transform StartTransform
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x4506220", Offset = "0x4502220", VA = "0x4506220")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		public Transform EndTransform
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x4506228", Offset = "0x4502228", VA = "0x4506228")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F1")]
		internal bool isActive
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x45062FC", Offset = "0x45022FC", VA = "0x45062FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F2")]
		public IOffMeshLinkHandler onTraverseOffMeshLink
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x4506318", Offset = "0x4502318", VA = "0x4506318")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x4506320", Offset = "0x4502320", VA = "0x4506320")]
			set
			{
			}
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x4506230", Offset = "0x4502230", VA = "0x4506230")]
		public static NodeLink2 GetNodeLink(GraphNode node)
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x4506334", Offset = "0x4502334", VA = "0x4506334", Slot = "18")]
		public override void OnPostScan()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x450659C", Offset = "0x450259C", VA = "0x450659C", Slot = "15")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x45066CC", Offset = "0x45026CC", VA = "0x45066CC")]
		private static void OnUpdate(NodeLink2[] components, int count)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x4506338", Offset = "0x4502338", VA = "0x4506338")]
		private void TryAddLink()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x450689C", Offset = "0x450289C", VA = "0x450689C")]
		private void RemoveLink()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x4506978", Offset = "0x4502978", VA = "0x4506978", Slot = "16")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x45069F4", Offset = "0x45029F4", VA = "0x45069F4")]
		[ContextMenu("Recalculate neighbours")]
		private void ContextApplyForce()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x4506A04", Offset = "0x4502A04", VA = "0x4506A04", Slot = "26")]
		public virtual void Apply()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x44FA208", Offset = "0x44F6208", VA = "0x44FA208", Slot = "6")]
		public override void DrawGizmos()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x44FAB8C", Offset = "0x44F6B8C", VA = "0x44FAB8C")]
		public NodeLink2()
		{
		}
	}
}
