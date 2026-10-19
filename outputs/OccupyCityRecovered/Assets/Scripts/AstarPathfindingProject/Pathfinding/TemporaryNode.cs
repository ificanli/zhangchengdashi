using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x20000BD")]
	public struct TemporaryNode
	{
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x0")]
		public uint associatedNode;

		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x4")]
		public Int3 position;

		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x10")]
		public int targetIndex;

		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x14")]
		public TemporaryNodeType type;
	}
}
