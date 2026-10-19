using System;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000F9A")]
	public class ControlRegister : Attribute
	{
		[Token(Token = "0x4006B4B")]
		[FieldOffset(Offset = "0x10")]
		private int m_sortOrder;

		[Token(Token = "0x17000F9C")]
		public int SortOrder
		{
			[Token(Token = "0x6005D7A")]
			[Address(RVA = "0x43B9B60", Offset = "0x43B5B60", VA = "0x43B9B60")]
			get
			{
				return m_sortOrder;
			}
		}

		[Token(Token = "0x6005D7B")]
		[Address(RVA = "0x43B9B68", Offset = "0x43B5B68", VA = "0x43B9B68")]
		public ControlRegister(int SortOrder = 10)
		{
		}
	}
}
