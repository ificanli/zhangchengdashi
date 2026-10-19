using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poco
{
	[Token(Token = "0x2000016")]
	public class AbstractNode
	{
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x10")]
		private List<string> requiredAttrs;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x787E0B0", Offset = "0x787A0B0", VA = "0x787E0B0", Slot = "4")]
		public virtual AbstractNode getParent()
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x787E0B8", Offset = "0x787A0B8", VA = "0x787E0B8", Slot = "5")]
		public virtual List<AbstractNode> getChildren()
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x787E0C0", Offset = "0x787A0C0", VA = "0x787E0C0", Slot = "6")]
		public virtual object getAttr(string attrName)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x787E748", Offset = "0x787A748", VA = "0x787E748", Slot = "7")]
		public virtual void setAttr(string attrName, object val)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x787E74C", Offset = "0x787A74C", VA = "0x787E74C", Slot = "8")]
		public virtual Dictionary<string, object> enumerateAttrs()
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x787E90C", Offset = "0x787A90C", VA = "0x787E90C")]
		public AbstractNode()
		{
		}
	}
}
