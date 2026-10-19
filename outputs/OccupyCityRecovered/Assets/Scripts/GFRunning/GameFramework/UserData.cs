using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x20003D3")]
	public class UserData
	{
		[Token(Token = "0x4001C96")]
		[FieldOffset(Offset = "0x10")]
		public List<UserVariable> UserDataList;

		[Token(Token = "0x6005FCA")]
		[Address(RVA = "0x71DC96C", Offset = "0x71D896C", VA = "0x71DC96C")]
		public UserData()
		{
		}
	}
}
