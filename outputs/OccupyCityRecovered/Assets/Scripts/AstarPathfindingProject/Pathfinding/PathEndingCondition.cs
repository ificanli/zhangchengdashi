using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x2000140")]
	public abstract class PathEndingCondition
	{
		[Token(Token = "0x40006D4")]
		[FieldOffset(Offset = "0x10")]
		protected Path path;

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x4564AE4", Offset = "0x4560AE4", VA = "0x4564AE4")]
		protected PathEndingCondition()
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x4564AEC", Offset = "0x4560AEC", VA = "0x4564AEC")]
		public PathEndingCondition(Path p)
		{
		}

		[Token(Token = "0x6000A66")]
		public abstract bool TargetFound(GraphNode node, uint H, uint G);
	}
}
