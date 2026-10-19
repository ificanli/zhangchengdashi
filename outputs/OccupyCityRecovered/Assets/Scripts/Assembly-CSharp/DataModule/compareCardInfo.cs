using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E15")]
	public class compareCardInfo
	{
		[Token(Token = "0x4006231")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4006232")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4006233")]
		[FieldOffset(Offset = "0x20")]
		public int rare;

		[Token(Token = "0x4006234")]
		[FieldOffset(Offset = "0x24")]
		public int level;

		[Token(Token = "0x4006235")]
		[FieldOffset(Offset = "0x28")]
		public string count;

		[Token(Token = "0x60056D7")]
		[Address(RVA = "0x4341420", Offset = "0x433D420", VA = "0x4341420")]
		public compareCardInfo()
		{
		}
	}
}
