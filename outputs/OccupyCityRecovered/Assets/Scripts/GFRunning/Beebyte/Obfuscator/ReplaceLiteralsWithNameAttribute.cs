using System;
using Il2CppDummyDll;

namespace Beebyte.Obfuscator
{
	[Token(Token = "0x200006C")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class ReplaceLiteralsWithNameAttribute : Attribute
	{
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x709C348", Offset = "0x7098348", VA = "0x709C348")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
}
