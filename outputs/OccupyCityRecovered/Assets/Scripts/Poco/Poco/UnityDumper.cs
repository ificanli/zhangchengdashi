using Il2CppDummyDll;

namespace Poco
{
	[Token(Token = "0x2000018")]
	public class UnityDumper : AbstractDumper
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x78820F4", Offset = "0x787E0F4", VA = "0x78820F4", Slot = "8")]
		public override AbstractNode getRoot()
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x787AF80", Offset = "0x7876F80", VA = "0x787AF80")]
		public UnityDumper()
		{
		}
	}
}
