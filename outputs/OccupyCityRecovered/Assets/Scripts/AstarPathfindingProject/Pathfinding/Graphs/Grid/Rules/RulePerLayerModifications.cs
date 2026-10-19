using Il2CppDummyDll;
using Pathfinding.Util;

namespace Pathfinding.Graphs.Grid.Rules
{
	[Token(Token = "0x200021A")]
	[Preserve]
	public class RulePerLayerModifications : GridGraphRule
	{
		[Token(Token = "0x200021B")]
		public struct PerLayerRule
		{
			[Token(Token = "0x40009EF")]
			[FieldOffset(Offset = "0x0")]
			public int layer;

			[Token(Token = "0x40009F0")]
			[FieldOffset(Offset = "0x4")]
			public RuleAction action;

			[Token(Token = "0x40009F1")]
			[FieldOffset(Offset = "0x8")]
			public int tag;
		}

		[Token(Token = "0x200021C")]
		public enum RuleAction
		{
			[Token(Token = "0x40009F3")]
			SetTag = 0,
			[Token(Token = "0x40009F4")]
			MakeUnwalkable = 1
		}

		[Token(Token = "0x40009ED")]
		[FieldOffset(Offset = "0x18")]
		public PerLayerRule[] layerRules;

		[Token(Token = "0x40009EE")]
		private const int SetTagBit = 1073741824;

		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x4478E78", Offset = "0x4474E78", VA = "0x4478E78", Slot = "7")]
		public override void Register(GridGraphRules rules)
		{
		}

		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x447901C", Offset = "0x447501C", VA = "0x447901C")]
		public RulePerLayerModifications()
		{
		}
	}
}
