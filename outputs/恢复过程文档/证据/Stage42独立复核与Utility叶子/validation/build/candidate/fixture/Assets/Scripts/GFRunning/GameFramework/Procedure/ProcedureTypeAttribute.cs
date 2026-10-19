using System;
using Il2CppDummyDll;

namespace GameFramework.Procedure
{
	[Token(Token = "0x2000451")]
	internal sealed class ProcedureTypeAttribute : Attribute
	{
		[Token(Token = "0x4001E15")]
		[FieldOffset(Offset = "0x10")]
		public Type ProcedureType;

		[Token(Token = "0x6006A21")]
		[Address(RVA = "0x727A5C4", Offset = "0x72765C4", VA = "0x727A5C4")]
		public ProcedureTypeAttribute(Type ptype)
		{
		}
	}
}
