using System;
using Il2CppDummyDll;

namespace Beebyte.Obfuscator
{
	[Token(Token = "0x200006F")]
	[AttributeUsage(AttributeTargets.Method)]
	public class SuppressLogAttribute : Attribute
	{
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x10")]
		private readonly MessageCode _009C_007D_007Cy_00AE_0086;

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x709C360", Offset = "0x7098360", VA = "0x709C360")]
		public SuppressLogAttribute(MessageCode GbPPHI)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x709C388", Offset = "0x7098388", VA = "0x709C388")]
		private SuppressLogAttribute()
		{
		}
	}
}
