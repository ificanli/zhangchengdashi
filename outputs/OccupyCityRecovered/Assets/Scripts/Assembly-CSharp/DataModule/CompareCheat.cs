using System.Collections.Generic;
using Il2CppDummyDll;
using L_Tools;
using ljzs_lt;

namespace DataModule
{
	[Token(Token = "0x2000E17")]
	public class CompareCheat : Singleton<CompareCheat>
	{
		[Token(Token = "0x2000E18")]
		private enum CheatCode
		{
			[Token(Token = "0x4006263")]
			Zuanshi_Big = 1001,
			[Token(Token = "0x4006264")]
			jinbi_Big = 1002,
			[Token(Token = "0x4006265")]
			wood_Big = 1003,
			[Token(Token = "0x4006266")]
			shuijing_Big = 1004,
			[Token(Token = "0x4006267")]
			card_big = 3001,
			[Token(Token = "0x4006268")]
			shenqi_big = 3002,
			[Token(Token = "0x4006269")]
			ziyuan_big = 3003,
			[Token(Token = "0x400626A")]
			lingdi_big = 3004
		}

		[Token(Token = "0x2000E19")]
		private enum xishu
		{
			[Token(Token = "0x400626C")]
			zuanshi = 0,
			[Token(Token = "0x400626D")]
			shuijing = 1,
			[Token(Token = "0x400626E")]
			play = 2,
			[Token(Token = "0x400626F")]
			win = 3,
			[Token(Token = "0x4006270")]
			Box = 4,
			[Token(Token = "0x4006271")]
			BoxOpenNum = 5
		}

		[Token(Token = "0x4006255")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, CompareCardInfoConfig> compareCardInfoDic;

		[Token(Token = "0x4006256")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, CompareShenqiInfoConfig> compareShenqiInfoDic;

		[Token(Token = "0x4006257")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[][] PropUpgradeCrystalTotalByRare;

		[Token(Token = "0x4006258")]
		[FieldOffset(Offset = "0x8")]
		public static int[] shenqiStarts;

		[Token(Token = "0x4006259")]
		[FieldOffset(Offset = "0x20")]
		private int[] zuanshi_xishu;

		[Token(Token = "0x400625A")]
		[FieldOffset(Offset = "0x28")]
		private int[] shuijing_xishu;

		[Token(Token = "0x400625B")]
		[FieldOffset(Offset = "0x30")]
		private int[] play;

		[Token(Token = "0x400625C")]
		[FieldOffset(Offset = "0x38")]
		public int[] win;

		[Token(Token = "0x400625D")]
		[FieldOffset(Offset = "0x40")]
		public int[] BoxOpenNum;

		[Token(Token = "0x400625E")]
		[FieldOffset(Offset = "0x48")]
		private int[] box;

		[Token(Token = "0x400625F")]
		[FieldOffset(Offset = "0x50")]
		private bool hasMonth;

		[Token(Token = "0x4006260")]
		[FieldOffset(Offset = "0x58")]
		private long LastCheckTime;

		[Token(Token = "0x4006261")]
		[FieldOffset(Offset = "0x60")]
		private CheatCode cheatCode;

		[Token(Token = "0x17000EAF")]
		private int payCount
		{
			[Token(Token = "0x60056DA")]
			[Address(RVA = "0x4342820", Offset = "0x433E820", VA = "0x4342820")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EB0")]
		private int PlayTime
		{
			[Token(Token = "0x60056DB")]
			[Address(RVA = "0x4342888", Offset = "0x433E888", VA = "0x4342888")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EB1")]
		private int WinTime
		{
			[Token(Token = "0x60056DC")]
			[Address(RVA = "0x43428F0", Offset = "0x433E8F0", VA = "0x43428F0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EB2")]
		private int WonTrophyCount
		{
			[Token(Token = "0x60056DD")]
			[Address(RVA = "0x4342958", Offset = "0x433E958", VA = "0x4342958")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EB3")]
		private int DanNum
		{
			[Token(Token = "0x60056DE")]
			[Address(RVA = "0x43429C0", Offset = "0x433E9C0", VA = "0x43429C0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EB4")]
		private int BoxOpenTime
		{
			[Token(Token = "0x60056DF")]
			[Address(RVA = "0x4342A28", Offset = "0x433EA28", VA = "0x4342A28")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60056E0")]
		[Address(RVA = "0x4342A90", Offset = "0x433EA90", VA = "0x4342A90")]
		public static int GetCardCount(int rare, int level)
		{
			return default;
		}

		[Token(Token = "0x60056E1")]
		[Address(RVA = "0x4342AF8", Offset = "0x433EAF8", VA = "0x4342AF8")]
		public static int GetShenqiStar(int star)
		{
			return default;
		}

		[Token(Token = "0x60056E2")]
		[Address(RVA = "0x4342B90", Offset = "0x433EB90", VA = "0x4342B90")]
		public bool StartCheck()
		{
			return default;
		}

		[Token(Token = "0x60056E3")]
		[Address(RVA = "0x43444A8", Offset = "0x43404A8", VA = "0x43444A8")]
		private bool CheckIsOk(long score, float fac)
		{
			return default;
		}

		[Token(Token = "0x60056E4")]
		[Address(RVA = "0x4343024", Offset = "0x433F024", VA = "0x4343024")]
		public void VaildLog(string str)
		{
		}

		[Token(Token = "0x60056E5")]
		[Address(RVA = "0x4343028", Offset = "0x433F028", VA = "0x4343028")]
		public bool CheckCore(string str)
		{
			return default;
		}

		[Token(Token = "0x60056E6")]
		[Address(RVA = "0x4343574", Offset = "0x433F574", VA = "0x4343574")]
		public long VaildCard()
		{
			return default;
		}

		[Token(Token = "0x60056E7")]
		[Address(RVA = "0x4343958", Offset = "0x433F958", VA = "0x4343958")]
		public long VaildShenqi()
		{
			return default;
		}

		[Token(Token = "0x60056E8")]
		[Address(RVA = "0x434400C", Offset = "0x434000C", VA = "0x434400C")]
		public long VaildResources()
		{
			return default;
		}

		[Token(Token = "0x60056E9")]
		[Address(RVA = "0x4344264", Offset = "0x4340264", VA = "0x4344264")]
		public long VaildMainCity()
		{
			return default;
		}

		[Token(Token = "0x60056EA")]
		[Address(RVA = "0x43449DC", Offset = "0x43409DC", VA = "0x43449DC")]
		private int GetXishu(xishu id)
		{
			return default;
		}

		[Token(Token = "0x60056EB")]
		[Address(RVA = "0x43448C0", Offset = "0x43408C0", VA = "0x43448C0")]
		public void DelayReportCheat()
		{
		}

		[Token(Token = "0x60056EC")]
		[Address(RVA = "0x4344C74", Offset = "0x4340C74", VA = "0x4344C74")]
		public CompareCheat()
		{
		}
	}
}
