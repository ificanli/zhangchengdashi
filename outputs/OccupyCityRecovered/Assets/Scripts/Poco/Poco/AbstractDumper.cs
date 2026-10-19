using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poco
{
	[Token(Token = "0x2000014")]
	public class AbstractDumper : IDumper
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x787DC68", Offset = "0x7879C68", VA = "0x787DC68", Slot = "8")]
		public virtual AbstractNode getRoot()
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x787DC70", Offset = "0x7879C70", VA = "0x787DC70", Slot = "5")]
		public Dictionary<string, object> dumpHierarchy()
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x7879CB8", Offset = "0x7875CB8", VA = "0x7879CB8", Slot = "6")]
		public Dictionary<string, object> dumpHierarchy(bool onlyVisibleNode)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x787DC98", Offset = "0x7879C98", VA = "0x787DC98")]
		private Dictionary<string, object> dumpHierarchyImpl(AbstractNode node, bool onlyVisibleNode)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x787E0A0", Offset = "0x787A0A0", VA = "0x787E0A0", Slot = "9")]
		public virtual List<float> getPortSize()
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x787E0A8", Offset = "0x787A0A8", VA = "0x787E0A8")]
		public AbstractDumper()
		{
		}
	}
}
