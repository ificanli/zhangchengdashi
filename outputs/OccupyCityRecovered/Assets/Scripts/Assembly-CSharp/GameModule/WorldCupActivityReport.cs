using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000606")]
	public static class WorldCupActivityReport
	{
		[Token(Token = "0x2000607")]
		public static class SubEvent
		{
			[Token(Token = "0x4003231")]
			public const string Enter = "sjbActivity_enter";

			[Token(Token = "0x4003232")]
			public const string CostBall = "sjbActivity_costBall";

			[Token(Token = "0x4003233")]
			public const string Redeem = "sjbActivity_redeem";

			[Token(Token = "0x4003234")]
			public const string DailyTask = "sjbActivity_dailyTask";

			[Token(Token = "0x4003235")]
			public const string DailyGift = "sjbActivity_dailyGift";

			[Token(Token = "0x4003236")]
			public const string GetBall = "sjbActivity_getBall";
		}

		[Token(Token = "0x2000608")]
		public static class EnterWay
		{
			[Token(Token = "0x4003237")]
			public const string Button = "button-主页入口";

			[Token(Token = "0x4003238")]
			public const string Pop = "pop-启动弹窗";
		}

		[Token(Token = "0x2000609")]
		public static class GetBallSource
		{
			[Token(Token = "0x4003239")]
			public const int DailyTask = 1;

			[Token(Token = "0x400323A")]
			public const int DailyGift = 3;

			[Token(Token = "0x400323B")]
			public const int Other = 99;
		}

		[Token(Token = "0x200060A")]
		private sealed class WorldCupActivityReportPayload
		{
			[Token(Token = "0x170001B8")]
			public string SubEvent
			{
				[Token(Token = "0x6002032")]
				[Address(RVA = "0x3F0E1F0", Offset = "0x3F0A1F0", VA = "0x3F0E1F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001B9")]
			public string Mode1
			{
				[Token(Token = "0x6002033")]
				[Address(RVA = "0x3F0E1F8", Offset = "0x3F0A1F8", VA = "0x3F0E1F8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6002034")]
				[Address(RVA = "0x3F0E200", Offset = "0x3F0A200", VA = "0x3F0E200")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170001BA")]
			public string Mode2
			{
				[Token(Token = "0x6002035")]
				[Address(RVA = "0x3F0E208", Offset = "0x3F0A208", VA = "0x3F0E208")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6002036")]
				[Address(RVA = "0x3F0E210", Offset = "0x3F0A210", VA = "0x3F0E210")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170001BB")]
			public string Param1
			{
				[Token(Token = "0x6002037")]
				[Address(RVA = "0x3F0E218", Offset = "0x3F0A218", VA = "0x3F0E218")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6002038")]
				[Address(RVA = "0x3F0E220", Offset = "0x3F0A220", VA = "0x3F0E220")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170001BC")]
			public string Param2
			{
				[Token(Token = "0x6002039")]
				[Address(RVA = "0x3F0E228", Offset = "0x3F0A228", VA = "0x3F0E228")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600203A")]
				[Address(RVA = "0x3F0E230", Offset = "0x3F0A230", VA = "0x3F0E230")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170001BD")]
			public string Param3
			{
				[Token(Token = "0x600203B")]
				[Address(RVA = "0x3F0E238", Offset = "0x3F0A238", VA = "0x3F0E238")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600203C")]
				[Address(RVA = "0x3F0E240", Offset = "0x3F0A240", VA = "0x3F0E240")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170001BE")]
			public string Param
			{
				[Token(Token = "0x600203D")]
				[Address(RVA = "0x3F0E248", Offset = "0x3F0A248", VA = "0x3F0E248")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600203E")]
				[Address(RVA = "0x3F0E250", Offset = "0x3F0A250", VA = "0x3F0E250")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170001BF")]
			public int? StepOld
			{
				[Token(Token = "0x600203F")]
				[Address(RVA = "0x3F0E258", Offset = "0x3F0A258", VA = "0x3F0E258")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6002040")]
				[Address(RVA = "0x3F0E260", Offset = "0x3F0A260", VA = "0x3F0E260")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170001C0")]
			public int? StepOld2
			{
				[Token(Token = "0x6002041")]
				[Address(RVA = "0x3F0E268", Offset = "0x3F0A268", VA = "0x3F0E268")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6002042")]
				[Address(RVA = "0x3F0E270", Offset = "0x3F0A270", VA = "0x3F0E270")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170001C1")]
			public int? StepOld3
			{
				[Token(Token = "0x6002043")]
				[Address(RVA = "0x3F0E278", Offset = "0x3F0A278", VA = "0x3F0E278")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6002044")]
				[Address(RVA = "0x3F0E280", Offset = "0x3F0A280", VA = "0x3F0E280")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6002031")]
			[Address(RVA = "0x3F0DCBC", Offset = "0x3F09CBC", VA = "0x3F0DCBC")]
			public WorldCupActivityReportPayload(string subEvent)
			{
			}
		}

		[Token(Token = "0x600202A")]
		[Address(RVA = "0x3F0DC40", Offset = "0x3F09C40", VA = "0x3F0DC40")]
		public static void ReportEnter(string enterWay)
		{
		}

		[Token(Token = "0x600202B")]
		[Address(RVA = "0x3F0DFA4", Offset = "0x3F09FA4", VA = "0x3F0DFA4")]
		public static void ReportCostBallShoot(int footballCost, bool isGoal, int scoreGain, int itemId, int itemCount)
		{
		}

		[Token(Token = "0x600202C")]
		[Address(RVA = "0x3F0E108", Offset = "0x3F0A108", VA = "0x3F0E108")]
		public static void ReportRedeem(int exchangeId, int scoreCost, int remainBuyCount)
		{
		}

		[Token(Token = "0x600202D")]
		[Address(RVA = "0x3F0C9E4", Offset = "0x3F089E4", VA = "0x3F0C9E4")]
		public static void ReportDailyTask(int taskId)
		{
		}

		[Token(Token = "0x600202E")]
		[Address(RVA = "0x3F0B7F0", Offset = "0x3F077F0", VA = "0x3F0B7F0")]
		public static void ReportDailyGift(int giftId)
		{
		}

		[Token(Token = "0x600202F")]
		[Address(RVA = "0x3F06D30", Offset = "0x3F02D30", VA = "0x3F06D30")]
		public static void ReportGetBall(int count, int source)
		{
		}

		[Token(Token = "0x6002030")]
		[Address(RVA = "0x3F0DCE4", Offset = "0x3F09CE4", VA = "0x3F0DCE4")]
		private static void Report(WorldCupActivityReportPayload payload)
		{
		}
	}
}
