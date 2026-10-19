using System;
using Il2CppDummyDll;

namespace Pathfinding.Serialization
{
	[Token(Token = "0x200024F")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class JsonDynamicTypeAliasAttribute : Attribute
	{
		[Token(Token = "0x4000AEA")]
		[FieldOffset(Offset = "0x10")]
		public string alias;

		[Token(Token = "0x4000AEB")]
		[FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x6000E98")]
		[Address(RVA = "0x4482FCC", Offset = "0x447EFCC", VA = "0x4482FCC")]
		public JsonDynamicTypeAliasAttribute(string alias, Type type)
		{
		}
	}
}
