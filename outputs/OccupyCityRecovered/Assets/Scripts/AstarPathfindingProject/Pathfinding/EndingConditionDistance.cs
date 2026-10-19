using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x2000138")]
	public class EndingConditionDistance : PathEndingCondition
	{
		[Token(Token = "0x40006B3")]
		[FieldOffset(Offset = "0x18")]
		public int maxGScore;

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x45610F4", Offset = "0x455D0F4", VA = "0x45610F4")]
		public EndingConditionDistance(Path p, int maxGScore)
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x4561924", Offset = "0x455D924", VA = "0x4561924", Slot = "4")]
		public override bool TargetFound(GraphNode node, uint H, uint G)
		{
			return default;
		}
	}
}
