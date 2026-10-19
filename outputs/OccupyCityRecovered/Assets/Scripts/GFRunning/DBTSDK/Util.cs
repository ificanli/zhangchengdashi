using System.Collections.Generic;
using DBTSDK.Iap;
using GameFramework;
using GameFramework.Login;
using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x2000202")]
	public class Util
	{
		[Token(Token = "0x400074D")]
		private const string SaveFileName = "LoginUserInfo.txt";

		[Token(Token = "0x400074E")]
		private const string CommoditySaveFileName = "IapCommodity.txt";

		[Token(Token = "0x60019F4")]
		[Address(RVA = "0x70A3A58", Offset = "0x709FA58", VA = "0x70A3A58")]
		public static Dictionary<string, object> DataParse(string data)
		{
			return null;
		}

		[Token(Token = "0x60019F5")]
		[Address(RVA = "0x70A517C", Offset = "0x70A117C", VA = "0x70A517C")]
		public static List<Dictionary<string, object>> DataParses(string data)
		{
			return null;
		}

		[Token(Token = "0x60019F6")]
		[Address(RVA = "0x70B9118", Offset = "0x70B5118", VA = "0x70B9118")]
		private static Dictionary<string, object> DataParseUserInfo(string data)
		{
			return null;
		}

		[Token(Token = "0x60019F7")]
		[Address(RVA = "0x70B94BC", Offset = "0x70B54BC", VA = "0x70B94BC")]
		public static LoginUserData ResolveUserInfo(string userStr)
		{
			return null;
		}

		[Token(Token = "0x60019F8")]
		[Address(RVA = "0x70B9FA4", Offset = "0x70B5FA4", VA = "0x70B9FA4")]
		public static LoginUserData ReadLoginUserInfo()
		{
			return null;
		}

		[Token(Token = "0x60019F9")]
		[Address(RVA = "0x70BA3A0", Offset = "0x70B63A0", VA = "0x70BA3A0")]
		public static void SaveLoginUserInfo(LoginUserData loginUserData)
		{
		}

		[Token(Token = "0x60019FA")]
		[Address(RVA = "0x70BA6C0", Offset = "0x70B66C0", VA = "0x70BA6C0")]
		public static void DeleteLoginInfo()
		{
		}

		[Token(Token = "0x60019FB")]
		[Address(RVA = "0x70BA72C", Offset = "0x70B672C", VA = "0x70BA72C")]
		internal static List<Commodity> ReadCommodityInfo()
		{
			return null;
		}

		[Token(Token = "0x60019FC")]
		[Address(RVA = "0x70BA8F8", Offset = "0x70B68F8", VA = "0x70BA8F8")]
		internal static void SaveCommodityInfo(List<Commodity> commodities)
		{
		}

		[Token(Token = "0x60019FD")]
		[Address(RVA = "0x70BAA30", Offset = "0x70B6A30", VA = "0x70BAA30")]
		internal static void DeleteCommodityInfo()
		{
		}

		[Token(Token = "0x60019FE")]
		[Address(RVA = "0x70BAADC", Offset = "0x70B6ADC", VA = "0x70BAADC")]
		internal static void DeleteSDKCashInfo()
		{
		}

		[Token(Token = "0x60019FF")]
		[Address(RVA = "0x70A9994", Offset = "0x70A5994", VA = "0x70A9994")]
		public static (string, string) GetCDNGroupURLByTeam(TeamType teamType, bool IsRelease = false)
		{
			return default;
		}

		[Token(Token = "0x6001A00")]
		[Address(RVA = "0x70BAAEC", Offset = "0x70B6AEC", VA = "0x70BAAEC")]
		public Util()
		{
		}
	}
}
