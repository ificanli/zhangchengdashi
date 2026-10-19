using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x2000353")]
	public class GameFrameWorkLang
	{
		[Token(Token = "0x2000354")]
		public enum GameFrameWorkLangKey
		{
			[Token(Token = "0x40019EF")]
			VideoNoReady = 0,
			[Token(Token = "0x40019F0")]
			AntiAddictionTips = 1,
			[Token(Token = "0x40019F1")]
			BuyFailed = 2,
			[Token(Token = "0x40019F2")]
			UnFinishOrderTips = 3,
			[Token(Token = "0x40019F3")]
			True = 4,
			[Token(Token = "0x40019F4")]
			Fasle = 5,
			[Token(Token = "0x40019F5")]
			IapRestoreSuc = 6,
			[Token(Token = "0x40019F6")]
			IapBuySuc = 7,
			[Token(Token = "0x40019F7")]
			TimeOutTipes = 8,
			[Token(Token = "0x40019F8")]
			Evaluate_Title = 9,
			[Token(Token = "0x40019F9")]
			Evaluate_unLike = 10,
			[Token(Token = "0x40019FA")]
			Evaluate_wait = 11,
			[Token(Token = "0x40019FB")]
			Evaluate_GoEvaluate = 12,
			[Token(Token = "0x40019FC")]
			Login_Reconnect = 13,
			[Token(Token = "0x40019FD")]
			Iap_ContinueBuy = 14,
			[Token(Token = "0x40019FE")]
			Login_GoLogin = 15,
			[Token(Token = "0x40019FF")]
			Login_LoginTimeOut = 16,
			[Token(Token = "0x4001A00")]
			Iap_UserTourist = 17
		}

		[Token(Token = "0x40019EB")]
		[FieldOffset(Offset = "0x0")]
		public static string[,] LangList;

		[Token(Token = "0x40019EC")]
		[FieldOffset(Offset = "0x8")]
		private static GameFrameWorkLang _instance;

		[Token(Token = "0x40019ED")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, GFLanguageConfig> dicLang;

		[Token(Token = "0x170010DE")]
		private static GameFrameWorkLang Instance
		{
			[Token(Token = "0x600578D")]
			[Address(RVA = "0x716D448", Offset = "0x7169448", VA = "0x716D448")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600578C")]
		[Address(RVA = "0x716D2F4", Offset = "0x71692F4", VA = "0x716D2F4")]
		public static string Get(GameFrameWorkLangKey gameFrameWorkLangKey)
		{
			return null;
		}

		[Token(Token = "0x600578E")]
		[Address(RVA = "0x716D504", Offset = "0x7169504", VA = "0x716D504")]
		private void LoadLangConfig()
		{
		}

		[Token(Token = "0x600578F")]
		[Address(RVA = "0x716D9AC", Offset = "0x71699AC", VA = "0x716D9AC")]
		public static string Get(string key)
		{
			return null;
		}

		[Token(Token = "0x6005790")]
		[Address(RVA = "0x716DA80", Offset = "0x7169A80", VA = "0x716DA80")]
		public static string Get(string key, ELangType type)
		{
			return null;
		}

		[Token(Token = "0x6005791")]
		[Address(RVA = "0x716D4FC", Offset = "0x71694FC", VA = "0x716D4FC")]
		public GameFrameWorkLang()
		{
		}
	}
}
