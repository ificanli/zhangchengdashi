using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000530")]
	public static class MysteryAdventureReport
	{
		[Token(Token = "0x2000531")]
		public static class SubEvent
		{
			[Token(Token = "0x4002E9A")]
			public const string Enter = "dfwActivity_enter";

			[Token(Token = "0x4002E9B")]
			public const string CostDice = "dfwActivity_costDice";

			[Token(Token = "0x4002E9C")]
			public const string BoardCell = "dfwActivity_boardCell";

			[Token(Token = "0x4002E9D")]
			public const string LapReward = "dfwActivity_lapReward";

			[Token(Token = "0x4002E9E")]
			public const string Mystery = "dfwActivity_Mystery";

			[Token(Token = "0x4002E9F")]
			public const string DailyTask = "dfwActivity_dailyTask";

			[Token(Token = "0x4002EA0")]
			public const string DailyGift = "dfwActivity_dailyGift";

			[Token(Token = "0x4002EA1")]
			public const string SpendReward = "dfwActivity_spendReward";

			[Token(Token = "0x4002EA2")]
			public const string GetDice = "dfwActivity_getDice";
		}

		[Token(Token = "0x2000532")]
		public static class EnterWay
		{
			[Token(Token = "0x4002EA3")]
			public const string Button = "button";

			[Token(Token = "0x4002EA4")]
			public const string Pop = "pop";
		}

		[Token(Token = "0x2000533")]
		public static class GetDiceSource
		{
			[Token(Token = "0x4002EA5")]
			public const int NaturalRecover = 1;

			[Token(Token = "0x4002EA6")]
			public const int DailyTask = 2;

			[Token(Token = "0x4002EA7")]
			public const int DailyGift = 3;

			[Token(Token = "0x4002EA8")]
			public const int GameReward = 4;

			[Token(Token = "0x4002EA9")]
			public const int SpendReward = 5;

			[Token(Token = "0x4002EAA")]
			public const int Other = 6;
		}

		[Token(Token = "0x2000534")]
		private sealed class MysteryAdventureReportPayload
		{
			[Token(Token = "0x17000165")]
			public string SubEvent
			{
				[Token(Token = "0x6001AFD")]
				[Address(RVA = "0x3EB2754", Offset = "0x3EAE754", VA = "0x3EB2754")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000166")]
			public string Mode1
			{
				[Token(Token = "0x6001AFE")]
				[Address(RVA = "0x3EB275C", Offset = "0x3EAE75C", VA = "0x3EB275C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001AFF")]
				[Address(RVA = "0x3EB2764", Offset = "0x3EAE764", VA = "0x3EB2764")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000167")]
			public string Mode2
			{
				[Token(Token = "0x6001B00")]
				[Address(RVA = "0x3EB276C", Offset = "0x3EAE76C", VA = "0x3EB276C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001B01")]
				[Address(RVA = "0x3EB2774", Offset = "0x3EAE774", VA = "0x3EB2774")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000168")]
			public string Param1
			{
				[Token(Token = "0x6001B02")]
				[Address(RVA = "0x3EB277C", Offset = "0x3EAE77C", VA = "0x3EB277C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001B03")]
				[Address(RVA = "0x3EB2784", Offset = "0x3EAE784", VA = "0x3EB2784")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000169")]
			public string Param2
			{
				[Token(Token = "0x6001B04")]
				[Address(RVA = "0x3EB278C", Offset = "0x3EAE78C", VA = "0x3EB278C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001B05")]
				[Address(RVA = "0x3EB2794", Offset = "0x3EAE794", VA = "0x3EB2794")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700016A")]
			public string Param3
			{
				[Token(Token = "0x6001B06")]
				[Address(RVA = "0x3EB279C", Offset = "0x3EAE79C", VA = "0x3EB279C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001B07")]
				[Address(RVA = "0x3EB27A4", Offset = "0x3EAE7A4", VA = "0x3EB27A4")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700016B")]
			public string Param
			{
				[Token(Token = "0x6001B08")]
				[Address(RVA = "0x3EB27AC", Offset = "0x3EAE7AC", VA = "0x3EB27AC")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001B09")]
				[Address(RVA = "0x3EB27B4", Offset = "0x3EAE7B4", VA = "0x3EB27B4")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700016C")]
			public int? StepOld
			{
				[Token(Token = "0x6001B0A")]
				[Address(RVA = "0x3EB27BC", Offset = "0x3EAE7BC", VA = "0x3EB27BC")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001B0B")]
				[Address(RVA = "0x3EB27C4", Offset = "0x3EAE7C4", VA = "0x3EB27C4")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700016D")]
			public int? StepOld2
			{
				[Token(Token = "0x6001B0C")]
				[Address(RVA = "0x3EB27CC", Offset = "0x3EAE7CC", VA = "0x3EB27CC")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001B0D")]
				[Address(RVA = "0x3EB27D4", Offset = "0x3EAE7D4", VA = "0x3EB27D4")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700016E")]
			public int? StepOld3
			{
				[Token(Token = "0x6001B0E")]
				[Address(RVA = "0x3EB27DC", Offset = "0x3EAE7DC", VA = "0x3EB27DC")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001B0F")]
				[Address(RVA = "0x3EB27E4", Offset = "0x3EAE7E4", VA = "0x3EB27E4")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6001AFC")]
			[Address(RVA = "0x3EB1D14", Offset = "0x3EADD14", VA = "0x3EB1D14")]
			public MysteryAdventureReportPayload(string subEvent)
			{
			}
		}

		[Token(Token = "0x6001AEF")]
		[Address(RVA = "0x3EB1C98", Offset = "0x3EADC98", VA = "0x3EB1C98")]
		public static void ReportEnter(string enterWay)
		{
		}

		[Token(Token = "0x6001AF0")]
		[Address(RVA = "0x3EB1FEC", Offset = "0x3EADFEC", VA = "0x3EB1FEC")]
		public static void ReportCostDice(int cost, int diceValue)
		{
		}

		[Token(Token = "0x6001AF1")]
		[Address(RVA = "0x3EB2090", Offset = "0x3EAE090", VA = "0x3EB2090")]
		public static void ReportBoardCell(string rewardAssetId, int rewardCount, int lapCount, int cellId, int rewardMultiplier, int buildId)
		{
		}

		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0x3EB21E0", Offset = "0x3EAE1E0", VA = "0x3EB21E0")]
		public static void ReportBoardCellFromRewardRaw(string rewardRaw, int lapCount, int cellId, int rewardMultiplier, int buildId)
		{
		}

		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x3EAE430", Offset = "0x3EAA430", VA = "0x3EAE430")]
		public static void ReportLapReward(int rewardLevel, int lapCount, int rewardMultiplier)
		{
		}

		[Token(Token = "0x6001AF4")]
		[Address(RVA = "0x3EA8DFC", Offset = "0x3EA4DFC", VA = "0x3EA8DFC")]
		public static void ReportMystery(int ruinsEventId, int optionIndex, [Optional] string rewardAssetId, int rewardCount = 0)
		{
		}

		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x3EB2408", Offset = "0x3EAE408", VA = "0x3EB2408")]
		public static void ReportMysteryFromRewardRaw(int ruinsEventId, int optionIndex, string rewardRaw)
		{
		}

		[Token(Token = "0x6001AF6")]
		[Address(RVA = "0x3EB24F4", Offset = "0x3EAE4F4", VA = "0x3EB24F4")]
		public static void ReportDailyTask(int taskId)
		{
		}

		[Token(Token = "0x6001AF7")]
		[Address(RVA = "0x3EB2588", Offset = "0x3EAE588", VA = "0x3EB2588")]
		public static void ReportDailyGift(int giftId)
		{
		}

		[Token(Token = "0x6001AF8")]
		[Address(RVA = "0x3EB261C", Offset = "0x3EAE61C", VA = "0x3EB261C")]
		public static void ReportSpendReward(int tierId)
		{
		}

		[Token(Token = "0x6001AF9")]
		[Address(RVA = "0x3EB26B0", Offset = "0x3EAE6B0", VA = "0x3EB26B0")]
		public static void ReportGetDice(int count, int source)
		{
		}

		[Token(Token = "0x6001AFA")]
		[Address(RVA = "0x3EB1D3C", Offset = "0x3EADD3C", VA = "0x3EB1D3C")]
		private static void Report(MysteryAdventureReportPayload payload)
		{
		}

		[Token(Token = "0x6001AFB")]
		[Address(RVA = "0x3EB2320", Offset = "0x3EAE320", VA = "0x3EB2320")]
		private static bool TryParseRewardSegment(string segment, out string assetId, out int count)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventureReport.TryParseRewardSegment RVA=0x3EB2320 Token=0x6001AFB");
}
	}
}
