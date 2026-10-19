using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x2000141")]
	public class ABPathEndingCondition : PathEndingCondition
	{
		[Token(Token = "0x40006D5")]
		[FieldOffset(Offset = "0x18")]
		protected ABPath abPath;

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x4564B60", Offset = "0x4560B60", VA = "0x4564B60")]
		public ABPathEndingCondition(ABPath p)
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x4564BD4", Offset = "0x4560BD4", VA = "0x4564BD4", Slot = "4")]
		public override bool TargetFound(GraphNode node, uint H, uint G)
		{
			return default;
		}
	}
}
