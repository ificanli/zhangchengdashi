using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001C5")]
	public class DomainIsolationMgr
	{
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x0")]
		private static GameDonmainInfo m_DonmainInfo;

		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0x8")]
		private static bool IsUse;

		[Token(Token = "0x600154E")]
		[Address(RVA = "0x7385410", Offset = "0x7381410", VA = "0x7385410")]
		public static void LoadDomainCongfig()
		{
		}

		[Token(Token = "0x600154F")]
		[Address(RVA = "0x738582C", Offset = "0x738182C", VA = "0x738582C")]
		public static void LogDonmainInfo()
		{
		}

		[Token(Token = "0x6001550")]
		[Address(RVA = "0x738593C", Offset = "0x738193C", VA = "0x738593C")]
		internal static string GetGameDonmain(string gameKey, string bizKey = "")
		{
			return null;
		}

		[Token(Token = "0x6001551")]
		[Address(RVA = "0x73859C0", Offset = "0x73819C0", VA = "0x73859C0")]
		private static bool FindGameDomain(string gameKey, string bizKey, out Game.Domains domain)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DomainIsolationMgr.FindGameDomain RVA=0x73859C0 Token=0x6001551");
}

		[Token(Token = "0x6001552")]
		[Address(RVA = "0x7385CFC", Offset = "0x7381CFC", VA = "0x7385CFC")]
		internal static string GetGameDonmainWithPort(string gameKey, string bizKey)
		{
			return null;
		}

		[Token(Token = "0x6001553")]
		[Address(RVA = "0x73861B4", Offset = "0x73821B4", VA = "0x73861B4")]
		public static (int, string) GetGameDonmainPort(string gameKey, string bizKey = "")
		{
			return default;
		}

		[Token(Token = "0x6001554")]
		[Address(RVA = "0x7386550", Offset = "0x7382550", VA = "0x7386550")]
		public static string[] GetSDKDomain(params string[] sdkBiz)
		{
			return null;
		}

		[Token(Token = "0x6001555")]
		[Address(RVA = "0x73868DC", Offset = "0x73828DC", VA = "0x73868DC")]
		public static string[] GetSDKDomain(params XYXSDKBiz[] sdkBizes)
		{
			return null;
		}

		[Token(Token = "0x6001556")]
		[Address(RVA = "0x7386AA0", Offset = "0x7382AA0", VA = "0x7386AA0")]
		public static string GetPubliish()
		{
			return null;
		}

		[Token(Token = "0x6001557")]
		[Address(RVA = "0x7386D70", Offset = "0x7382D70", VA = "0x7386D70")]
		public static string GetCDN(string cdnKey)
		{
			return null;
		}

		[Token(Token = "0x6001558")]
		[Address(RVA = "0x73871E0", Offset = "0x73831E0", VA = "0x73871E0")]
		public DomainIsolationMgr()
		{
		}
	}
}
