using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	[Token(Token = "0x2000005")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public class RegisterAssetReferenceAttributeForwardToChildAttribute : Attribute
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		public readonly Type AttributeType;

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x788484C", Offset = "0x788084C", VA = "0x788484C")]
		public RegisterAssetReferenceAttributeForwardToChildAttribute(Type attributeType)
		{
		}
	}
}
