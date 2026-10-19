using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools.FeiShu
{
	[Token(Token = "0x2000048")]
	public static class FeiShuTools
	{
		[Token(Token = "0x40000E0")]
		private const string APP_ID = "cli_a7d53ab586fbd00e";

		[Token(Token = "0x40000E1")]
		private const string HEX_FEISHU = "i3t+Xuyq4geH0K+QK60hJTDVerOa8Qms3R6GKhZYUYQXYZ5+Z4oBeA==";

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string _groupId;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string _debugSystemVer;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _gfVer;

		[Token(Token = "0x1700002E")]
		private static string Feishu
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x4643440", Offset = "0x463F440", VA = "0x4643440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private static string GroupId
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x464352C", Offset = "0x463F52C", VA = "0x464352C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x4631FA0", Offset = "0x462DFA0", VA = "0x4631FA0")]
		public static void Init(DebuggerSystemSetting setting)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x4643658", Offset = "0x463F658", VA = "0x4643658")]
		public static void SendLogText(string logText)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x464399C", Offset = "0x463F99C", VA = "0x464399C")]
		public static void SendLogFile(string allLogText)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x4643CC8", Offset = "0x463FCC8", VA = "0x4643CC8")]
		[Obsolete("使用 SendAllLogsToFeishu 方法代替")]
		public static void SendLogsFileToFeishu(string filePath, string text)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x4643CD4", Offset = "0x463FCD4", VA = "0x4643CD4")]
		public static void SendAllLogsToFeishu(string text, [Optional] Action<string> onError)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x4643E70", Offset = "0x463FE70", VA = "0x4643E70")]
		public static void SendLogsTextToFeishu(string msg, [Optional] Action<string> onError)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x464400C", Offset = "0x464000C", VA = "0x464400C")]
		public static void GetChatGroupId(string groupName, Action<string> onGetChatIDSuccess)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x4643764", Offset = "0x463F764", VA = "0x4643764")]
		public static void SendLogsTextToServer(string msg)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x4643AA8", Offset = "0x463FAA8", VA = "0x4643AA8")]
		public static void SendLogsFileToServer(string text)
		{
		}
	}
}
