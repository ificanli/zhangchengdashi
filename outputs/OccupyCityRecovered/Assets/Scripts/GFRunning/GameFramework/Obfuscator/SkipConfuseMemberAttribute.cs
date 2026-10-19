using System;
using Il2CppDummyDll;

namespace GameFramework.Obfuscator
{
	[Token(Token = "0x2000421")]
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event, AllowMultiple = false, Inherited = false)]
	public sealed class SkipConfuseMemberAttribute : Attribute
	{
		[Token(Token = "0x60064B2")]
		[Address(RVA = "0x7232F24", Offset = "0x722EF24", VA = "0x7232F24")]
		public SkipConfuseMemberAttribute()
		{
		}
	}
}
