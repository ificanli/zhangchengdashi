using System;
using Il2CppDummyDll;

namespace Beebyte.Obfuscator
{
	[Token(Token = "0x200006A")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method)]
	public class ObfuscateLiteralsAttribute : Attribute
	{
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x709C200", Offset = "0x7098200", VA = "0x709C200")]
		public ObfuscateLiteralsAttribute()
		{
		}
	}
}
