using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x2000142")]
	public class EndingConditionProximity : ABPathEndingCondition
	{
		[Token(Token = "0x40006D6")]
		[FieldOffset(Offset = "0x20")]
		public float maxDistance = 10f;

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x4564C00", Offset = "0x4560C00", VA = "0x4564C00")]
		public EndingConditionProximity(ABPath p, float maxDistance) : base(p)
		{
			this.maxDistance = maxDistance;
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x4564C2C", Offset = "0x4560C2C", VA = "0x4564C2C", Slot = "4")]
		public override bool TargetFound(GraphNode node, uint H, uint G)
		{
			return default;
		}
	}
}
