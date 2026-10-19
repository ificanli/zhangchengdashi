using System.Collections.Generic;
using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001DC")]
	public class SDKLoginInfo
	{
		[Token(Token = "0x20001DD")]
		public class AccountInfo
		{
			[Token(Token = "0x400066C")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x400066D")]
			[FieldOffset(Offset = "0x18")]
			public string openId;

			[Token(Token = "0x400066E")]
			[FieldOffset(Offset = "0x20")]
			public int subType;

			[Token(Token = "0x400066F")]
			[FieldOffset(Offset = "0x24")]
			public int type;

			[Token(Token = "0x4000670")]
			[FieldOffset(Offset = "0x28")]
			public string unionId;

			[Token(Token = "0x60018C2")]
			[Address(RVA = "0x70A2EA8", Offset = "0x709EEA8", VA = "0x70A2EA8")]
			public AccountInfo()
			{
			}
		}

		[Token(Token = "0x20001DE")]
		public class UserInfo
		{
			[Token(Token = "0x4000671")]
			[FieldOffset(Offset = "0x10")]
			public string deviceId;

			[Token(Token = "0x4000672")]
			[FieldOffset(Offset = "0x18")]
			public string fsLogin;

			[Token(Token = "0x4000673")]
			[FieldOffset(Offset = "0x20")]
			public string icon;

			[Token(Token = "0x4000674")]
			[FieldOffset(Offset = "0x28")]
			public string loginDays;

			[Token(Token = "0x4000675")]
			[FieldOffset(Offset = "0x30")]
			public string openId;

			[Token(Token = "0x4000676")]
			[FieldOffset(Offset = "0x38")]
			public string userName;

			[Token(Token = "0x4000677")]
			[FieldOffset(Offset = "0x40")]
			public string userType;

			[Token(Token = "0x4000678")]
			[FieldOffset(Offset = "0x48")]
			public bool visitorFlag;

			[Token(Token = "0x60018C3")]
			[Address(RVA = "0x70A2EB0", Offset = "0x709EEB0", VA = "0x70A2EB0")]
			public UserInfo()
			{
			}
		}

		[Token(Token = "0x4000667")]
		[FieldOffset(Offset = "0x10")]
		public List<AccountInfo> accountInfo;

		[Token(Token = "0x4000668")]
		[FieldOffset(Offset = "0x18")]
		public string status;

		[Token(Token = "0x4000669")]
		[FieldOffset(Offset = "0x20")]
		public string token;

		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x28")]
		public string userId;

		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x30")]
		public UserInfo userInfo;

		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x70A2EA0", Offset = "0x709EEA0", VA = "0x70A2EA0")]
		public SDKLoginInfo()
		{
		}
	}
}
