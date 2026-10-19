using System;
using Il2CppDummyDll;

namespace Beebyte.Obfuscator
{
	[Token(Token = "0x2000068")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class DoNotFakeAttribute : Attribute
	{
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x709C1F8", Offset = "0x70981F8", VA = "0x709C1F8")]
		public DoNotFakeAttribute()
		{
		}
	}
}
