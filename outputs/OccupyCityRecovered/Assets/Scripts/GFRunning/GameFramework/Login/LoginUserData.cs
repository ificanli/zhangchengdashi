using Il2CppDummyDll;

namespace GameFramework.Login
{
	[Token(Token = "0x20004EE")]
	public class LoginUserData
	{
		[Token(Token = "0x4002014")]
		[FieldOffset(Offset = "0x10")]
		public string userId;

		[Token(Token = "0x4002015")]
		[FieldOffset(Offset = "0x18")]
		public string userName;

		[Token(Token = "0x4002016")]
		[FieldOffset(Offset = "0x20")]
		public string password;

		[Token(Token = "0x4002017")]
		[FieldOffset(Offset = "0x28")]
		public string nickName;

		[Token(Token = "0x4002018")]
		[FieldOffset(Offset = "0x30")]
		public string icon;

		[Token(Token = "0x4002019")]
		[FieldOffset(Offset = "0x38")]
		public string phone;

		[Token(Token = "0x400201A")]
		[FieldOffset(Offset = "0x40")]
		public string age;

		[Token(Token = "0x400201B")]
		[FieldOffset(Offset = "0x48")]
		public string gender;

		[Token(Token = "0x400201C")]
		[FieldOffset(Offset = "0x50")]
		public string email;

		[Token(Token = "0x400201D")]
		[FieldOffset(Offset = "0x58")]
		public string type;

		[Token(Token = "0x400201E")]
		[FieldOffset(Offset = "0x60")]
		public string openId;

		[Token(Token = "0x400201F")]
		[FieldOffset(Offset = "0x68")]
		public string unionId;

		[Token(Token = "0x4002020")]
		[FieldOffset(Offset = "0x70")]
		public string qq_vipLevel;

		[Token(Token = "0x4002021")]
		[FieldOffset(Offset = "0x78")]
		public string qq_yellowVipLevel;

		[Token(Token = "0x4002022")]
		[FieldOffset(Offset = "0x80")]
		public string city;

		[Token(Token = "0x4002023")]
		[FieldOffset(Offset = "0x88")]
		public string province;

		[Token(Token = "0x4002024")]
		[FieldOffset(Offset = "0x90")]
		public string country;

		[Token(Token = "0x4002025")]
		[FieldOffset(Offset = "0x98")]
		public string lon;

		[Token(Token = "0x4002026")]
		[FieldOffset(Offset = "0xA0")]
		public string lat;

		[Token(Token = "0x4002027")]
		[FieldOffset(Offset = "0xA8")]
		public string app_version;

		[Token(Token = "0x4002028")]
		[FieldOffset(Offset = "0xB0")]
		public string app_name;

		[Token(Token = "0x4002029")]
		[FieldOffset(Offset = "0xB8")]
		public string plat;

		[Token(Token = "0x400202A")]
		[FieldOffset(Offset = "0xC0")]
		public string ext;

		[Token(Token = "0x400202B")]
		[FieldOffset(Offset = "0xC8")]
		public string deviceId;

		[Token(Token = "0x60074EF")]
		[Address(RVA = "0x7301260", Offset = "0x72FD260", VA = "0x7301260")]
		public LoginUserData()
		{
		}
	}
}
