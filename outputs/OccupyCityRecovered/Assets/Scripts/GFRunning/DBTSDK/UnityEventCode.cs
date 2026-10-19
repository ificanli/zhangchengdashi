using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001FC")]
	public enum UnityEventCode
	{
		[Token(Token = "0x4000729")]
		UserDataReadError = 1001,
		[Token(Token = "0x400072A")]
		DNSError = 1002,
		[Token(Token = "0x400072B")]
		LangDataError = 1003,
		[Token(Token = "0x400072C")]
		LangConfigError = 1004,
		[Token(Token = "0x400072D")]
		DataManagerSaveError = 1005,
		[Token(Token = "0x400072E")]
		DataManagerReadError = 1006,
		[Token(Token = "0x400072F")]
		DNetDatadError = 1007,
		[Token(Token = "0x4000730")]
		ENetDatadError = 1008,
		[Token(Token = "0x4000731")]
		AbLoadError = 1009,
		[Token(Token = "0x4000732")]
		ReadLoginInfoError = 1010,
		[Token(Token = "0x4000733")]
		SaveLoginInfoError = 1011,
		[Token(Token = "0x4000734")]
		QuitGame = 1012,
		[Token(Token = "0x4000735")]
		NoMergeDataFromCloud = 1013,
		[Token(Token = "0x4000736")]
		XError = 1014,
		[Token(Token = "0x4000737")]
		RMoudleInitStatus = 1015,
		[Token(Token = "0x4000738")]
		FestMLoadError = 1016,
		[Token(Token = "0x4000739")]
		LvReportError = 1100,
		[Token(Token = "0x400073A")]
		CompressLocalDataError = 1101,
		[Token(Token = "0x400073B")]
		DeComLocalDataError = 1102,
		[Token(Token = "0x400073C")]
		SetGameLoginAccountId = 1103
	}
}
