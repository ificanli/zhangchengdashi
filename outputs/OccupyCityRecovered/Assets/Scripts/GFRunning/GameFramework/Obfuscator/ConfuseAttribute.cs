using System;
using Il2CppDummyDll;

namespace GameFramework.Obfuscator
{
	[Token(Token = "0x2000422")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public sealed class ConfuseAttribute : Attribute
	{
		[Token(Token = "0x60064B3")]
		[Address(RVA = "0x7232F2C", Offset = "0x722EF2C", VA = "0x7232F2C")]
		public ConfuseAttribute()
		{
		}
	}
}
