using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001FB")]
	public enum ErrorCode
	{
		[Token(Token = "0x4000718")]
		UserDataReadError = 1001,
		[Token(Token = "0x4000719")]
		DNSError = 1002,
		[Token(Token = "0x400071A")]
		LangDataError = 1003,
		[Token(Token = "0x400071B")]
		LangConfigError = 1004,
		[Token(Token = "0x400071C")]
		DataManagerSaveError = 1005,
		[Token(Token = "0x400071D")]
		DataManagerReadError = 1006,
		[Token(Token = "0x400071E")]
		DNetDatadError = 1007,
		[Token(Token = "0x400071F")]
		ENetDatadError = 1008,
		[Token(Token = "0x4000720")]
		AbLoadError = 1009,
		[Token(Token = "0x4000721")]
		ReadLoginInfoError = 1010,
		[Token(Token = "0x4000722")]
		SaveLoginInfoError = 1011,
		[Token(Token = "0x4000723")]
		NoMergeDataFromCloud = 1013,
		[Token(Token = "0x4000724")]
		XError = 1014,
		[Token(Token = "0x4000725")]
		LvReportError = 1100,
		[Token(Token = "0x4000726")]
		CompressLocalDataError = 1101,
		[Token(Token = "0x4000727")]
		DeComLocalDataError = 1102
	}
}
