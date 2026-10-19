using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E20")]
	public enum ComflictStatus
	{
		[Token(Token = "0x4006285")]
		UseLocalData = 0,
		[Token(Token = "0x4006286")]
		UseServerData = 1,
		[Token(Token = "0x4006287")]
		CompareData = 2
	}
}
