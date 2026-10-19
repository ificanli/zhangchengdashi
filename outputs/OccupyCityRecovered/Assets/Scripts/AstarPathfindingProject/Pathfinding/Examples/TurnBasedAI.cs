using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	[Token(Token = "0x20002DE")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/turnbasedai.html")]
	public class TurnBasedAI : VersionedMonoBehaviour
	{
		[Token(Token = "0x4000D47")]
		[FieldOffset(Offset = "0x28")]
		public int movementPoints;

		[Token(Token = "0x4000D48")]
		[FieldOffset(Offset = "0x30")]
		public BlockManager blockManager;

		[Token(Token = "0x4000D49")]
		[FieldOffset(Offset = "0x38")]
		public SingleNodeBlocker blocker;

		[Token(Token = "0x4000D4A")]
		[FieldOffset(Offset = "0x40")]
		public GraphNode targetNode;

		[Token(Token = "0x4000D4B")]
		[FieldOffset(Offset = "0x48")]
		public BlockManager.TraversalProvider traversalProvider;

		[Token(Token = "0x6001215")]
		[Address(RVA = "0x44A7C8C", Offset = "0x44A3C8C", VA = "0x44A7C8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6001216")]
		[Address(RVA = "0x44A7CA8", Offset = "0x44A3CA8", VA = "0x44A7CA8", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6001217")]
		[Address(RVA = "0x44A7DD0", Offset = "0x44A3DD0", VA = "0x44A7DD0")]
		public TurnBasedAI()
		{
		}
	}
}
