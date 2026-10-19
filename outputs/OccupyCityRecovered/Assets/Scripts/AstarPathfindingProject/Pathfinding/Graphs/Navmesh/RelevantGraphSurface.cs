using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh
{
	[Token(Token = "0x20001D6")]
	[AddComponentMenu("Pathfinding/Navmesh/RelevantGraphSurface")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/relevantgraphsurface.html")]
	public class RelevantGraphSurface : VersionedMonoBehaviour
	{
		[Token(Token = "0x40008B8")]
		[FieldOffset(Offset = "0x0")]
		private static RelevantGraphSurface root;

		[Token(Token = "0x40008B9")]
		[FieldOffset(Offset = "0x28")]
		public float maxRange;

		[Token(Token = "0x40008BA")]
		[FieldOffset(Offset = "0x30")]
		private RelevantGraphSurface prev;

		[Token(Token = "0x40008BB")]
		[FieldOffset(Offset = "0x38")]
		private RelevantGraphSurface next;

		[Token(Token = "0x40008BC")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 position;

		[Token(Token = "0x17000209")]
		public Vector3 Position
		{
			[Token(Token = "0x6000D1E")]
			[Address(RVA = "0x45A3294", Offset = "0x459F294", VA = "0x45A3294")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700020A")]
		public RelevantGraphSurface Next
		{
			[Token(Token = "0x6000D1F")]
			[Address(RVA = "0x45A32A0", Offset = "0x459F2A0", VA = "0x45A32A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020B")]
		public RelevantGraphSurface Prev
		{
			[Token(Token = "0x6000D20")]
			[Address(RVA = "0x45A32A8", Offset = "0x459F2A8", VA = "0x45A32A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020C")]
		public static RelevantGraphSurface Root
		{
			[Token(Token = "0x6000D21")]
			[Address(RVA = "0x45A32B0", Offset = "0x459F2B0", VA = "0x45A32B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x45A32F8", Offset = "0x459F2F8", VA = "0x45A32F8")]
		public void UpdatePosition()
		{
		}

		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x45A3328", Offset = "0x459F328", VA = "0x45A3328")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x45A33DC", Offset = "0x459F3DC", VA = "0x45A33DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x45A3538", Offset = "0x459F538", VA = "0x45A3538")]
		public static void UpdateAllPositions()
		{
		}

		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x45A35D0", Offset = "0x459F5D0", VA = "0x45A35D0")]
		public static void FindAllGraphSurfaces()
		{
		}

		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x45A3674", Offset = "0x459F674", VA = "0x45A3674", Slot = "6")]
		public override void DrawGizmos()
		{
		}

		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x45A3830", Offset = "0x459F830", VA = "0x45A3830")]
		public RelevantGraphSurface()
		{
		}
	}
}
