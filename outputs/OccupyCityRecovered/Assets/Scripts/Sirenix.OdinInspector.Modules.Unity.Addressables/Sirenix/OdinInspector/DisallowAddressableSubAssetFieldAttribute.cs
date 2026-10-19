using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	[Token(Token = "0x2000004")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class DisallowAddressableSubAssetFieldAttribute : Attribute
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x7884844", Offset = "0x7880844", VA = "0x7884844")]
		public DisallowAddressableSubAssetFieldAttribute()
		{
		}
	}
}
