using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E8D")]
	public class BasePropertyTemp
	{
		[Token(Token = "0x4006573")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4006574")]
		[FieldOffset(Offset = "0x18")]
		public int hp;

		[Token(Token = "0x4006575")]
		[FieldOffset(Offset = "0x1C")]
		public int maxHp;

		[Token(Token = "0x60058B6")]
		[Address(RVA = "0x4364E44", Offset = "0x4360E44", VA = "0x4364E44")]
		public BasePropertyTemp()
		{
		}
	}
}
