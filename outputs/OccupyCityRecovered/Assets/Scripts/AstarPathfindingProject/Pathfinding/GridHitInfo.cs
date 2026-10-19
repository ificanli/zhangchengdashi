using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x20000D5")]
	public struct GridHitInfo
	{
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x0")]
		public GridNodeBase node;

		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x8")]
		public int direction;
	}
}
