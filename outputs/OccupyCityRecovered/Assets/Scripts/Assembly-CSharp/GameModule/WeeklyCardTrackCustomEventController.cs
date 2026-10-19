using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20004BA")]
	public class WeeklyCardTrackCustomEventController
	{
		[Token(Token = "0x600179C")]
		[Address(RVA = "0x3E5F7D8", Offset = "0x3E5B7D8", VA = "0x3E5F7D8")]
		public void TrackWeeklyCardsEntry(WeeklyCardActivityManager.CycleCardType cardType)
		{
		}

		[Token(Token = "0x600179D")]
		[Address(RVA = "0x3E5B9E8", Offset = "0x3E579E8", VA = "0x3E5B9E8")]
		public void TrackWeeklyCardsFirstTaskCompleted()
		{
		}

		[Token(Token = "0x600179E")]
		[Address(RVA = "0x3E5C4BC", Offset = "0x3E584BC", VA = "0x3E5C4BC")]
		public void TrackWeeklyCardsTaskCompletionSummary(int completedTasksCount, int totalProgressPoints, bool hasPurchasedWeeklyCard, WeeklyCardActivityManager.CycleCardType cardType)
		{
		}

		[Token(Token = "0x600179F")]
		[Address(RVA = "0x3E5AF74", Offset = "0x3E56F74", VA = "0x3E5AF74")]
		public void TrackWeeklyCardsPurchase(WeeklyCardActivityManager.CycleCardType cardType, string iapId)
		{
		}

		[Token(Token = "0x60017A0")]
		[Address(RVA = "0x3E5F7DC", Offset = "0x3E5B7DC", VA = "0x3E5F7DC")]
		private string GetCycleCardTypeNameForTracking(WeeklyCardActivityManager.CycleCardType cardType)
		{
			return null;
		}

		[Token(Token = "0x60017A1")]
		[Address(RVA = "0x3E5F428", Offset = "0x3E5B428", VA = "0x3E5F428")]
		public WeeklyCardTrackCustomEventController()
		{
		}
	}
}
