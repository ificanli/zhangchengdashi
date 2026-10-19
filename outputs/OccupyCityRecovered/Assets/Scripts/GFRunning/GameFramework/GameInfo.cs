using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x200032F")]
	public class GameInfo
	{
		[Token(Token = "0x400197B")]
		[FieldOffset(Offset = "0x10")]
		public int GameIndex;

		[Token(Token = "0x400197C")]
		[FieldOffset(Offset = "0x18")]
		public string GameName;

		[Token(Token = "0x400197D")]
		[FieldOffset(Offset = "0x20")]
		public GPAssetPackType GPAssetPackType;

		[Token(Token = "0x400197E")]
		[FieldOffset(Offset = "0x28")]
		public string GPAssetPackName;

		[Token(Token = "0x60055E4")]
		[Address(RVA = "0x715BEE0", Offset = "0x7157EE0", VA = "0x715BEE0")]
		public GameInfo()
		{
		}
	}
}
