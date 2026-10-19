using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200016E")]
	[AddComponentMenu("Pathfinding/Procedural Graph Mover")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/proceduralgraphmover.html")]
	public class ProceduralGraphMover : VersionedMonoBehaviour
	{
		[Token(Token = "0x4000766")]
		[FieldOffset(Offset = "0x28")]
		public float updateDistance;

		[Token(Token = "0x4000767")]
		[FieldOffset(Offset = "0x30")]
		public Transform target;

		[Token(Token = "0x4000769")]
		[FieldOffset(Offset = "0x40")]
		public NavGraph graph;

		[Token(Token = "0x400076A")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public int graphIndex;

		[Token(Token = "0x170001EB")]
		public bool updatingGraph
		{
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x457F754", Offset = "0x457B754", VA = "0x457F754")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x457F75C", Offset = "0x457B75C", VA = "0x457F75C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x457F768", Offset = "0x457B768", VA = "0x457F768")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x457FD2C", Offset = "0x457BD2C", VA = "0x457FD2C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x457FDF4", Offset = "0x457BDF4", VA = "0x457FDF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x457FBB8", Offset = "0x457BBB8", VA = "0x457FBB8")]
		public void UpdateGraph(bool async = true)
		{
		}

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x4580054", Offset = "0x457C054", VA = "0x4580054")]
		private void UpdateGridGraph(GridGraph graph, bool async)
		{
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x4580240", Offset = "0x457C240", VA = "0x4580240")]
		private static Vector2Int RecastGraphTileShift(RecastGraph graph, Vector3 targetCenter)
		{
			return default;
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x4580370", Offset = "0x457C370", VA = "0x4580370")]
		private void UpdateRecastGraph(RecastGraph graph, Vector2Int delta, bool async)
		{
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x4580574", Offset = "0x457C574", VA = "0x4580574")]
		public ProceduralGraphMover()
		{
		}
	}
}
