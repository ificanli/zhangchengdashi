using System;
using Il2CppDummyDll;

namespace GameFramework.Obfuscator
{
	[Token(Token = "0x2000423")]
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event, AllowMultiple = false, Inherited = false)]
	public sealed class ConfuseMemberAttribute : Attribute
	{
		[Token(Token = "0x60064B4")]
		[Address(RVA = "0x7232F34", Offset = "0x722EF34", VA = "0x7232F34")]
		public ConfuseMemberAttribute()
		{
		}
	}
}
