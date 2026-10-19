using System;
using Il2CppDummyDll;

namespace Beebyte.Obfuscator
{
	[Token(Token = "0x200006E")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipRenameAttribute : Attribute
	{
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x709C358", Offset = "0x7098358", VA = "0x709C358")]
		public SkipRenameAttribute()
		{
		}
	}
}
