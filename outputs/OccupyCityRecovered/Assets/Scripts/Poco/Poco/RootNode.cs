using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poco
{
	[Token(Token = "0x2000019")]
	public class RootNode : AbstractNode
	{
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x18")]
		private List<AbstractNode> children;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x7882144", Offset = "0x787E144", VA = "0x7882144")]
		public RootNode()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x78823A4", Offset = "0x787E3A4", VA = "0x78823A4", Slot = "5")]
		public override List<AbstractNode> getChildren()
		{
			return null;
		}
	}
}
