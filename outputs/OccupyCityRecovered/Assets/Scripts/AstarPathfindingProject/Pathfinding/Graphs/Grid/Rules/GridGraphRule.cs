using Il2CppDummyDll;
using Pathfinding.Serialization;

namespace Pathfinding.Graphs.Grid.Rules
{
	[Token(Token = "0x2000213")]
	[JsonDynamicTypeAlias("Pathfinding.RuleElevationPenalty", typeof(RuleElevationPenalty))]
	[JsonDynamicType]
	[JsonDynamicTypeAlias("Pathfinding.RuleTexture", typeof(RuleTexture))]
	[JsonDynamicTypeAlias("Pathfinding.RuleAnglePenalty", typeof(RuleAnglePenalty))]
	[JsonDynamicTypeAlias("Pathfinding.RulePerLayerModifications", typeof(RulePerLayerModifications))]
	public abstract class GridGraphRule
	{
		[Token(Token = "0x2000214")]
		public enum Pass
		{
			[Token(Token = "0x40009D6")]
			BeforeCollision = 0,
			[Token(Token = "0x40009D7")]
			BeforeConnections = 1,
			[Token(Token = "0x40009D8")]
			AfterConnections = 2,
			[Token(Token = "0x40009D9")]
			AfterErosion = 3,
			[Token(Token = "0x40009DA")]
			PostProcess = 4,
			[Token(Token = "0x40009DB")]
			AfterApplied = 5
		}

		[Token(Token = "0x40009D3")]
		[FieldOffset(Offset = "0x10")]
		[JsonMember]
		public bool enabled;

		[Token(Token = "0x40009D4")]
		[FieldOffset(Offset = "0x14")]
		private int dirty;

		[Token(Token = "0x1700021C")]
		public virtual int Hash
		{
			[Token(Token = "0x6000DDF")]
			[Address(RVA = "0x447849C", Offset = "0x447449C", VA = "0x447849C", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x44784A4", Offset = "0x44744A4", VA = "0x44784A4", Slot = "5")]
		public virtual void SetDirty()
		{
		}

		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x44784B4", Offset = "0x44744B4", VA = "0x44784B4", Slot = "6")]
		public virtual void DisposeUnmanagedData()
		{
		}

		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x44784B8", Offset = "0x44744B8", VA = "0x44784B8", Slot = "7")]
		public virtual void Register(GridGraphRules rules)
		{
		}

		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x44784BC", Offset = "0x44744BC", VA = "0x44784BC")]
		protected GridGraphRule()
		{
		}
	}
}
