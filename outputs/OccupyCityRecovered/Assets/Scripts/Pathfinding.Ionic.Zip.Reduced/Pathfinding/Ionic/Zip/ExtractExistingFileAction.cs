using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000015")]
	public enum ExtractExistingFileAction
	{
		[Token(Token = "0x400002A")]
		Throw = 0,
		[Token(Token = "0x400002B")]
		OverwriteSilently = 1,
		[Token(Token = "0x400002C")]
		DoNotOverwrite = 2,
		[Token(Token = "0x400002D")]
		InvokeExtractProgressEvent = 3
	}
}
