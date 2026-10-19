using System;
using Il2CppDummyDll;

namespace GameFramework.Obfuscator
{
	[Token(Token = "0x2000420")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public sealed class SkipConfuseAttribute : Attribute
	{
		[Token(Token = "0x60064B1")]
		[Address(RVA = "0x7232F1C", Offset = "0x722EF1C", VA = "0x7232F1C")]
		public SkipConfuseAttribute()
		{
		}
	}
}
