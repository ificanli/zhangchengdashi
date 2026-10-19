using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000143")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/blockmanager.html")]
	public class BlockManager : VersionedMonoBehaviour
	{
		[Token(Token = "0x2000144")]
		public enum BlockMode
		{
			[Token(Token = "0x40006D9")]
			AllExceptSelector = 0,
			[Token(Token = "0x40006DA")]
			OnlySelector = 1
		}

		[Token(Token = "0x2000145")]
		public class TraversalProvider : ITraversalProvider
		{
			[Token(Token = "0x40006DB")]
			[FieldOffset(Offset = "0x10")]
			private readonly BlockManager blockManager;

			[Token(Token = "0x40006DD")]
			[FieldOffset(Offset = "0x20")]
			private readonly List<SingleNodeBlocker> selector;

			[Token(Token = "0x170001D5")]
			public BlockMode mode
			{
				[Token(Token = "0x6000A71")]
				[Address(RVA = "0x45652A4", Offset = "0x45612A4", VA = "0x45652A4")]
				[CompilerGenerated]
				get
				{
					return default;
				}
				[Token(Token = "0x6000A72")]
				[Address(RVA = "0x45652AC", Offset = "0x45612AC", VA = "0x45652AC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x45652B4", Offset = "0x45612B4", VA = "0x45652B4")]
			public TraversalProvider(BlockManager blockManager, BlockMode mode, List<SingleNodeBlocker> selector)
			{
			}

			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x45653B8", Offset = "0x45613B8", VA = "0x45653B8", Slot = "5")]
			public bool CanTraverse(ref TraversalConstraint traversalConstraint, GraphNode node)
			{
				return default;
			}
		}

		[Token(Token = "0x40006D7")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<GraphNode, List<SingleNodeBlocker>> blocked;

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x4564CB4", Offset = "0x4560CB4", VA = "0x4564CB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x4564D8C", Offset = "0x4560D8C", VA = "0x4564D8C")]
		public bool NodeContainsAnyOf(GraphNode node, List<SingleNodeBlocker> selector)
		{
			return default;
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x4564EA4", Offset = "0x4560EA4", VA = "0x4564EA4")]
		public bool NodeContainsAnyExcept(GraphNode node, List<SingleNodeBlocker> selector)
		{
			return default;
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x4564FC8", Offset = "0x4560FC8", VA = "0x4564FC8")]
		public void InternalBlock(GraphNode node, SingleNodeBlocker blocker)
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x45650F8", Offset = "0x45610F8", VA = "0x45650F8")]
		public void InternalUnblock(GraphNode node, SingleNodeBlocker blocker)
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x4565228", Offset = "0x4561228", VA = "0x4565228")]
		public BlockManager()
		{
		}
	}
}
