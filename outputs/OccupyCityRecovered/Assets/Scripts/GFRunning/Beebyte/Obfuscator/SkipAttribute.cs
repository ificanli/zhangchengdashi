using System;
using Il2CppDummyDll;

namespace Beebyte.Obfuscator
{
	[Token(Token = "0x200006D")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipAttribute : Attribute
	{
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x709C350", Offset = "0x7098350", VA = "0x709C350")]
		public SkipAttribute()
		{
		}
	}
}
