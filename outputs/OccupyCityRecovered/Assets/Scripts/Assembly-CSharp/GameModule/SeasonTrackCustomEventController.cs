using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20005A5")]
	public class SeasonTrackCustomEventController
	{
		[Token(Token = "0x40030A1")]
		private const string WeeklyCompetition_StartGame = "WeeklyCompetition_StartGame";

		[Token(Token = "0x40030A2")]
		private const string WeeklyCompetition_FinishGame = "WeeklyCompetition_FinishGame";

		[Token(Token = "0x40030A3")]
		private const string WeeklyCompetition_FinishEvent = "WeeklyCompetition_FinishEvent";

		[Token(Token = "0x40030A4")]
		private const string WeeklyBattle_StartGame = "WeeklyBattle_StartGame";

		[Token(Token = "0x40030A5")]
		private const string WeeklyBattle_FinishGame = "WeeklyBattle_FinishGame";

		[Token(Token = "0x40030A6")]
		private const string ChampionsRush_FinishEvent = "ChampionsRush_FinishEvent";

		[Token(Token = "0x6001D61")]
		[Address(RVA = "0x3EDE604", Offset = "0x3EDA604", VA = "0x3EDE604")]
		public void TrackWeeklyCompetition_StartGame()
		{
		}

		[Token(Token = "0x6001D62")]
		[Address(RVA = "0x3EDE608", Offset = "0x3EDA608", VA = "0x3EDE608")]
		public void TrackWeeklyCompetition_FinishGame(bool win)
		{
		}

		[Token(Token = "0x6001D63")]
		[Address(RVA = "0x3EDE60C", Offset = "0x3EDA60C", VA = "0x3EDE60C")]
		public void TrackWeeklyCompetition_FinishEvent()
		{
		}

		[Token(Token = "0x6001D64")]
		[Address(RVA = "0x3EDE610", Offset = "0x3EDA610", VA = "0x3EDE610")]
		private void SelfTrackWeeklyCompetition_FinishEvent(int order)
		{
		}

		[Token(Token = "0x6001D65")]
		[Address(RVA = "0x3EDE614", Offset = "0x3EDA614", VA = "0x3EDE614")]
		public void WeeklyBattleStartGame()
		{
		}

		[Token(Token = "0x6001D66")]
		[Address(RVA = "0x3EDE618", Offset = "0x3EDA618", VA = "0x3EDE618")]
		public void WeeklyBattleFinishGame(bool isWin)
		{
		}

		[Token(Token = "0x6001D67")]
		[Address(RVA = "0x3EDE61C", Offset = "0x3EDA61C", VA = "0x3EDE61C")]
		public void ChampionsRushFinishEvent()
		{
		}

		[Token(Token = "0x6001D68")]
		[Address(RVA = "0x3EDE620", Offset = "0x3EDA620", VA = "0x3EDE620")]
		private void ChampionsRush(int order, int score)
		{
		}

		[Token(Token = "0x6001D69")]
		[Address(RVA = "0x3EDDD20", Offset = "0x3ED9D20", VA = "0x3EDDD20")]
		public SeasonTrackCustomEventController()
		{
		}
	}
}
