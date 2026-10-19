using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DBTSDK.NewReport.JsonProperties;
using Il2CppDummyDll;
using UnityEngine;

namespace DBTSDK
{
	[Token(Token = "0x20001C7")]
	public class ReportManager : MonoBehaviour
	{
		[Token(Token = "0x20001C8")]
		internal class GameLevelReport
		{
			[Token(Token = "0x20001C9")]
			private enum LeveLReportState
			{
				[Token(Token = "0x40005F6")]
				LvNoStart = 0,
				[Token(Token = "0x40005F7")]
				LvCanRevive = 1,
				[Token(Token = "0x40005F8")]
				LvQuit = 2,
				[Token(Token = "0x40005F9")]
				TempNone = 100,
				[Token(Token = "0x40005FA")]
				LvRunning = 101,
				[Token(Token = "0x40005FB")]
				LvPause = 102
			}

			[Token(Token = "0x40005F1")]
			[FieldOffset(Offset = "0x10")]
			internal bool DrivingPauseLv;

			[Token(Token = "0x40005F2")]
			[FieldOffset(Offset = "0x14")]
			private LeveLReportState m_LvReportState;

			[Token(Token = "0x40005F3")]
			[FieldOffset(Offset = "0x18")]
			internal int lvId;

			[Token(Token = "0x40005F4")]
			[FieldOffset(Offset = "0x20")]
			internal Timer lvTimer;

			[Token(Token = "0x6001773")]
			[Address(RVA = "0x7390F0C", Offset = "0x738CF0C", VA = "0x7390F0C")]
			internal GameLevelReport()
			{
			}

			[Token(Token = "0x6001774")]
			[Address(RVA = "0x739420C", Offset = "0x739020C", VA = "0x739420C")]
			private void ReportGameLvTimes(int time, int TotleTimes)
			{
			}

			[Token(Token = "0x6001775")]
			[Address(RVA = "0x7393830", Offset = "0x738F830", VA = "0x7393830")]
			internal void Update()
			{
			}

			[Token(Token = "0x6001776")]
			[Address(RVA = "0x7390CB0", Offset = "0x738CCB0", VA = "0x7390CB0")]
			internal void GameFocus(bool IsFocus)
			{
			}

			[Token(Token = "0x6001777")]
			[Address(RVA = "0x7390BF8", Offset = "0x738CBF8", VA = "0x7390BF8")]
			internal void GamePause(bool IsPause)
			{
			}

			[Token(Token = "0x6001778")]
			[Address(RVA = "0x7388930", Offset = "0x7384930", VA = "0x7388930")]
			internal void Start(game_start game_Start)
			{
			}

			[Token(Token = "0x6001779")]
			[Address(RVA = "0x7388C00", Offset = "0x7384C00", VA = "0x7388C00")]
			internal void Quit()
			{
			}

			[Token(Token = "0x600177A")]
			[Address(RVA = "0x7394390", Offset = "0x7390390", VA = "0x7394390")]
			private void LVGameForeground()
			{
			}

			[Token(Token = "0x600177B")]
			[Address(RVA = "0x7394680", Offset = "0x7390680", VA = "0x7394680")]
			private void LVGameBackground()
			{
			}

			[Token(Token = "0x600177C")]
			[Address(RVA = "0x73948BC", Offset = "0x73908BC", VA = "0x73948BC")]
			internal void Pause()
			{
			}

			[Token(Token = "0x600177D")]
			[Address(RVA = "0x738A138", Offset = "0x7386138", VA = "0x738A138")]
			internal void Pause(game_pause game_Pause)
			{
			}

			[Token(Token = "0x600177E")]
			[Address(RVA = "0x7394990", Offset = "0x7390990", VA = "0x7394990")]
			internal void Continue()
			{
			}

			[Token(Token = "0x600177F")]
			[Address(RVA = "0x738A388", Offset = "0x7386388", VA = "0x738A388")]
			internal void Continue(game_continue game_Continue)
			{
			}

			[Token(Token = "0x6001780")]
			[Address(RVA = "0x73896B4", Offset = "0x73856B4", VA = "0x73896B4")]
			internal void Fail(game_fail game_Fail)
			{
			}

			[Token(Token = "0x6001781")]
			[Address(RVA = "0x7389C44", Offset = "0x7385C44", VA = "0x7389C44")]
			internal void Complete(game_complete game_Complete)
			{
			}

			[Token(Token = "0x6001782")]
			[Address(RVA = "0x7389E84", Offset = "0x7385E84", VA = "0x7389E84")]
			internal void GameDraw(game_draw game_draw)
			{
			}

			[Token(Token = "0x6001783")]
			[Address(RVA = "0x7388D5C", Offset = "0x7384D5C", VA = "0x7388D5C")]
			internal void Progress(game_progress game_Progress)
			{
			}

			[Token(Token = "0x6001784")]
			[Address(RVA = "0x7389068", Offset = "0x7385068", VA = "0x7389068")]
			internal void Foul(game_foul game_Foul)
			{
			}

			[Token(Token = "0x6001785")]
			[Address(RVA = "0x7389294", Offset = "0x7385294", VA = "0x7389294")]
			internal void Revive(game_revive game_Revive)
			{
			}

			[Token(Token = "0x6001786")]
			[Address(RVA = "0x7394BC4", Offset = "0x7390BC4", VA = "0x7394BC4")]
			private void Draw()
			{
			}

			[Token(Token = "0x6001787")]
			[Address(RVA = "0x738A634", Offset = "0x7386634", VA = "0x738A634")]
			internal void Skip(game_skip game_skip)
			{
			}

			[Token(Token = "0x6001788")]
			[Address(RVA = "0x7391328", Offset = "0x738D328", VA = "0x7391328")]
			internal void Stop()
			{
			}

			[Token(Token = "0x6001789")]
			[Address(RVA = "0x7394B0C", Offset = "0x7390B0C", VA = "0x7394B0C")]
			private void PauseLv(bool IsPause = true)
			{
			}

			[Token(Token = "0x600178A")]
			[Address(RVA = "0x7394A64", Offset = "0x7390A64", VA = "0x7394A64")]
			private bool CheckLvRunning()
			{
				return default;
			}

			[Token(Token = "0x600178B")]
			[Address(RVA = "0x7394B58", Offset = "0x7390B58", VA = "0x7394B58")]
			private void ReportError(string ErrorMsg)
			{
			}
		}

		[Token(Token = "0x20001CA")]
		public class game_pay_event : NewReportJsonPropertiesBase
		{
			[Token(Token = "0x170000F4")]
			public string type
			{
				[Token(Token = "0x600178C")]
				[Address(RVA = "0x7394BFC", Offset = "0x7390BFC", VA = "0x7394BFC")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600178D")]
				[Address(RVA = "0x7394C04", Offset = "0x7390C04", VA = "0x7394C04")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170000F5")]
			public string status
			{
				[Token(Token = "0x600178E")]
				[Address(RVA = "0x7394C0C", Offset = "0x7390C0C", VA = "0x7394C0C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600178F")]
				[Address(RVA = "0x7394C14", Offset = "0x7390C14", VA = "0x7394C14")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170000F6")]
			public string msg
			{
				[Token(Token = "0x6001790")]
				[Address(RVA = "0x7394C1C", Offset = "0x7390C1C", VA = "0x7394C1C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001791")]
				[Address(RVA = "0x7394C24", Offset = "0x7390C24", VA = "0x7394C24")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6001792")]
			[Address(RVA = "0x7394C2C", Offset = "0x7390C2C", VA = "0x7394C2C")]
			public game_pay_event()
			{
			}
		}

		[Token(Token = "0x20001CB")]
		public class in_app_purchase : NewReportJsonPropertiesBase
		{
			[Token(Token = "0x170000F7")]
			public string action
			{
				[Token(Token = "0x6001793")]
				[Address(RVA = "0x7394C84", Offset = "0x7390C84", VA = "0x7394C84")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001794")]
				[Address(RVA = "0x7394C8C", Offset = "0x7390C8C", VA = "0x7394C8C")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170000F8")]
			public string sku
			{
				[Token(Token = "0x6001795")]
				[Address(RVA = "0x7394C94", Offset = "0x7390C94", VA = "0x7394C94")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001796")]
				[Address(RVA = "0x7394C9C", Offset = "0x7390C9C", VA = "0x7394C9C")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6001797")]
			[Address(RVA = "0x7394CA4", Offset = "0x7390CA4", VA = "0x7394CA4")]
			public in_app_purchase()
			{
			}
		}

		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0x0")]
		public static int mode_Level;

		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x4")]
		public static UseReportType useReportType;

		[Token(Token = "0x40005E0")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, NewReportJsonProperties> dicJsonData;

		[Token(Token = "0x40005E1")]
		[FieldOffset(Offset = "0x28")]
		private int levelLoopTimer;

		[Token(Token = "0x40005E2")]
		[FieldOffset(Offset = "0x2C")]
		private bool EnterLvReport;

		[Token(Token = "0x40005E3")]
		public const int InvalidValue = -9999;

		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0x30")]
		private string _video_activity_mode3;

		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x38")]
		private int? _modeLevelScore;

		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x40")]
		private int? _modeLevelProgress;

		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0x48")]
		private float netReportInterval;

		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0x4C")]
		private float netReportWeekTime;

		[Token(Token = "0x40005E9")]
		private const string FilterheadJar = "jar";

		[Token(Token = "0x40005EA")]
		private const string FilterheadFile = "file";

		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0x50")]
		private GameLevelReport m_levelReport;

		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x58")]
		private Timer gameTimer;

		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x60")]
		private Timer modeTimer;

		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0x8")]
		public static ReportManager Instance;

		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, int> dicGameModelLoopTimer;

		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x70")]
		private bool IsalreadyAddListener;

		[Token(Token = "0x170000EE")]
		private bool isUseOldReport
		{
			[Token(Token = "0x600168D")]
			[Address(RVA = "0x7387BB8", Offset = "0x7383BB8", VA = "0x7387BB8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000EF")]
		private bool isUseNewReport
		{
			[Token(Token = "0x600168E")]
			[Address(RVA = "0x7387C3C", Offset = "0x7383C3C", VA = "0x7387C3C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F0")]
		public string VideoActivityMode3
		{
			[Token(Token = "0x60016AD")]
			[Address(RVA = "0x738A90C", Offset = "0x738690C", VA = "0x738A90C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public int SetViodeReportModeLevelScore
		{
			[Token(Token = "0x60016AE")]
			[Address(RVA = "0x738A914", Offset = "0x7386914", VA = "0x738A914")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public int SetViodeReportModeLevelProgress
		{
			[Token(Token = "0x60016AF")]
			[Address(RVA = "0x738A97C", Offset = "0x738697C", VA = "0x738A97C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public int lvTimes
		{
			[Token(Token = "0x6001747")]
			[Address(RVA = "0x7390A4C", Offset = "0x738CA4C", VA = "0x7390A4C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600168A")]
		public void ReportAttEvent<T>(T JsonData) where T : AFReportBaseData
		{
		}

		[Token(Token = "0x600168B")]
		public void ReportToGravity<T>(T obj) where T : NewReportJsonProperties
		{
		}

		[Token(Token = "0x600168C")]
		[Address(RVA = "0x73878E4", Offset = "0x73838E4", VA = "0x73878E4")]
		public void ReportToGravity(string eventId, string jsonProperties)
		{
		}

		[Token(Token = "0x600168F")]
		[Address(RVA = "0x7387CC4", Offset = "0x7383CC4", VA = "0x7387CC4")]
		private void NewStartMineGame()
		{
		}

		[Token(Token = "0x6001690")]
		[Address(RVA = "0x7388074", Offset = "0x7384074", VA = "0x7388074")]
		private void NewReportGamePlayTime(int times)
		{
		}

		[Token(Token = "0x6001691")]
		[Address(RVA = "0x738813C", Offset = "0x738413C", VA = "0x738813C")]
		private void NewStartGameModel(string mineGameModel)
		{
		}

		[Token(Token = "0x6001692")]
		[Address(RVA = "0x73881C8", Offset = "0x73841C8", VA = "0x73881C8")]
		private int GetGameLevelTime()
		{
			return default;
		}

		[Token(Token = "0x6001693")]
		[Address(RVA = "0x7388244", Offset = "0x7384244", VA = "0x7388244")]
		private void StopGameLoopTimer(bool IsReportLastTimes = true)
		{
		}

		[Token(Token = "0x6001694")]
		[Address(RVA = "0x7388348", Offset = "0x7384348", VA = "0x7388348")]
		private void LoopTimerRemove(int timer)
		{
		}

		[Token(Token = "0x6001695")]
		[Address(RVA = "0x7388350", Offset = "0x7384350", VA = "0x7388350")]
		private void PauseGameLoopTimer()
		{
		}

		[Token(Token = "0x6001696")]
		[Address(RVA = "0x738842C", Offset = "0x738442C", VA = "0x738842C")]
		private void PauseLoopTimer(int timer)
		{
		}

		[Token(Token = "0x6001697")]
		[Address(RVA = "0x73884AC", Offset = "0x73844AC", VA = "0x73884AC")]
		private void PlayGameLoopTimer()
		{
		}

		[Token(Token = "0x6001698")]
		[Address(RVA = "0x7388528", Offset = "0x7384528", VA = "0x7388528")]
		public void NewReportGameStart(game_start game_Start, int LevelId = 0)
		{
		}

		[Token(Token = "0x6001699")]
		[Address(RVA = "0x7388B34", Offset = "0x7384B34", VA = "0x7388B34")]
		public void NewReportGameStart(game_start game_Start, int? LevelId)
		{
		}

		[Token(Token = "0x600169A")]
		[Address(RVA = "0x738834C", Offset = "0x738434C", VA = "0x738834C")]
		private void ReportGameTimes(int time)
		{
		}

		[Token(Token = "0x600169B")]
		[Address(RVA = "0x7388BA0", Offset = "0x7384BA0", VA = "0x7388BA0")]
		public void NewReportGameQuit(game_quit gameQuit)
		{
		}

		[Token(Token = "0x600169C")]
		[Address(RVA = "0x7388D00", Offset = "0x7384D00", VA = "0x7388D00")]
		public void NewReportGameQuit()
		{
		}

		[Token(Token = "0x600169D")]
		[Address(RVA = "0x7388D18", Offset = "0x7384D18", VA = "0x7388D18")]
		public void NewReportGameProgress(game_progress game_Progress)
		{
		}

		[Token(Token = "0x600169E")]
		[Address(RVA = "0x7388F44", Offset = "0x7384F44", VA = "0x7388F44")]
		[Obsolete("框架自带前后台上报")]
		public void NewReport_game_foreground(game_foreground game_foreground)
		{
		}

		[Token(Token = "0x600169F")]
		[Address(RVA = "0x7388F48", Offset = "0x7384F48", VA = "0x7388F48")]
		[Obsolete("框架自带前后台上报")]
		public void NewReport_game_background(game_background game_background)
		{
		}

		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x7388F4C", Offset = "0x7384F4C", VA = "0x7388F4C")]
		private void NewReportGameLevelTime(level_gaming level_gaming)
		{
		}

		[Token(Token = "0x60016A1")]
		[Address(RVA = "0x7389024", Offset = "0x7385024", VA = "0x7389024")]
		public void NewReportGameFoul(game_foul game_Foul)
		{
		}

		[Token(Token = "0x60016A2")]
		[Address(RVA = "0x7389250", Offset = "0x7385250", VA = "0x7389250")]
		public void NewReportGameRevive(game_revive game_Revive)
		{
		}

		[Token(Token = "0x60016A3")]
		[Address(RVA = "0x73894C4", Offset = "0x73854C4", VA = "0x73894C4")]
		public void NewReportGameFail(game_fail game_Fail, int LevelId = 0)
		{
		}

		[Token(Token = "0x60016A4")]
		[Address(RVA = "0x73898B4", Offset = "0x73858B4", VA = "0x73898B4")]
		public void NewReportGameFail(game_fail game_Fail, int? LevelId)
		{
		}

		[Token(Token = "0x60016A5")]
		[Address(RVA = "0x738991C", Offset = "0x738591C", VA = "0x738991C")]
		public void NewReportGameComplete(game_complete game_Complete, int LevelId = 0)
		{
		}

		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x7389E40", Offset = "0x7385E40", VA = "0x7389E40")]
		public void NewReportGameDraw(game_draw game_draw)
		{
		}

		[Token(Token = "0x60016A7")]
		[Address(RVA = "0x738A080", Offset = "0x7386080", VA = "0x738A080")]
		public void NewReportGameComplete(game_complete game_Complete, int? LevelId)
		{
		}

		[Token(Token = "0x60016A8")]
		[Address(RVA = "0x738A0EC", Offset = "0x73860EC", VA = "0x738A0EC")]
		public void NewReportGamePause(game_pause game_Pause)
		{
		}

		[Token(Token = "0x60016A9")]
		[Address(RVA = "0x738A340", Offset = "0x7386340", VA = "0x738A340")]
		public void NewReportGameContinue(game_continue game_Continue)
		{
		}

		[Token(Token = "0x60016AA")]
		[Address(RVA = "0x738A5F0", Offset = "0x73865F0", VA = "0x738A5F0")]
		public void NewReportGameSkip(game_skip game_skip)
		{
		}

		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x738A7B4", Offset = "0x73867B4", VA = "0x738A7B4")]
		public void NewReportOpenUI(string UIName, string UImode = "", string LastUIName = "", string LastUIMode = "")
		{
		}

		[Token(Token = "0x60016AC")]
		[Address(RVA = "0x738A874", Offset = "0x7386874", VA = "0x738A874")]
		public void NewReportCloseUI(string UIName, int _duration, string UImode = "")
		{
		}

		[Token(Token = "0x60016B0")]
		[Address(RVA = "0x738A9E4", Offset = "0x73869E4", VA = "0x738A9E4")]
		public void NewReportVideoUnable(string video_name)
		{
		}

		[Token(Token = "0x60016B1")]
		[Address(RVA = "0x738AB48", Offset = "0x7386B48", VA = "0x738AB48")]
		public void NewReportVideoUnable(video_unable nable)
		{
		}

		[Token(Token = "0x60016B2")]
		[Address(RVA = "0x738AC24", Offset = "0x7386C24", VA = "0x738AC24")]
		public void NewReportVideoNoAds(string video_name)
		{
		}

		[Token(Token = "0x60016B3")]
		[Address(RVA = "0x738ADA4", Offset = "0x7386DA4", VA = "0x738ADA4")]
		public void NewReportVideoNoAds(video_noAds noads)
		{
		}

		[Token(Token = "0x60016B4")]
		[Address(RVA = "0x738AE80", Offset = "0x7386E80", VA = "0x738AE80")]
		public void NewReportVideoShow(string video_name, string video_param1, string video_param2)
		{
		}

		[Token(Token = "0x60016B5")]
		[Address(RVA = "0x738B014", Offset = "0x7387014", VA = "0x738B014")]
		public void NewReportVideoShow(video_show videoBase)
		{
		}

		[Token(Token = "0x60016B6")]
		[Address(RVA = "0x738B0F0", Offset = "0x73870F0", VA = "0x738B0F0")]
		public void NewReportVideoClick(string video_name, string video_param1, string video_param2)
		{
		}

		[Token(Token = "0x60016B7")]
		[Address(RVA = "0x738B294", Offset = "0x7387294", VA = "0x738B294")]
		public void NewReportVideoClick(video_click videoBase)
		{
		}

		[Token(Token = "0x60016B8")]
		[Address(RVA = "0x738B370", Offset = "0x7387370", VA = "0x738B370")]
		public void NewReportVideoSuccess(string video_name, string video_param1, string video_param2)
		{
		}

		[Token(Token = "0x60016B9")]
		[Address(RVA = "0x738B514", Offset = "0x7387514", VA = "0x738B514")]
		public void NewReportVideoSuccess(video_success videoBase)
		{
		}

		[Token(Token = "0x60016BA")]
		[Address(RVA = "0x738B5F0", Offset = "0x73875F0", VA = "0x738B5F0")]
		public void NewReportVideoFail(string video_name, string video_param1, string video_param2)
		{
		}

		[Token(Token = "0x60016BB")]
		[Address(RVA = "0x738B794", Offset = "0x7387794", VA = "0x738B794")]
		public void NewReportVideoFail(video_fail videoBase)
		{
		}

		[Token(Token = "0x60016BC")]
		[Address(RVA = "0x738B870", Offset = "0x7387870", VA = "0x738B870")]
		public void NewReportVideoPlay(string video_name, string video_param1, string video_param2)
		{
		}

		[Token(Token = "0x60016BD")]
		[Address(RVA = "0x738BA14", Offset = "0x7387A14", VA = "0x738BA14")]
		public void NewReportVideoPlay(video_play videoBase)
		{
		}

		[Token(Token = "0x60016BE")]
		[Address(RVA = "0x738BAF0", Offset = "0x7387AF0", VA = "0x738BAF0")]
		public void NewReportSkinUnlock(skin_unlock Skin_unlock)
		{
		}

		[Token(Token = "0x60016BF")]
		[Address(RVA = "0x738BB54", Offset = "0x7387B54", VA = "0x738BB54")]
		public void NewReportSkinUse(skin_use Skin_name)
		{
		}

		[Token(Token = "0x60016C0")]
		[Address(RVA = "0x738BBB8", Offset = "0x7387BB8", VA = "0x738BBB8")]
		internal void NewReportPayShow(params pay_show[] pay_show)
		{
		}

		[Token(Token = "0x60016C1")]
		[Address(RVA = "0x738BD04", Offset = "0x7387D04", VA = "0x738BD04")]
		internal void NewReportPayEvent(string type, string status, string msg)
		{
		}

		[Token(Token = "0x60016C2")]
		[Address(RVA = "0x738BDA4", Offset = "0x7387DA4", VA = "0x738BDA4")]
		internal void NewReoirtPayClick_WebGL(string sku)
		{
		}

		[Token(Token = "0x60016C3")]
		[Address(RVA = "0x738BE48", Offset = "0x7387E48", VA = "0x738BE48")]
		public void ReportGMToolOpen()
		{
		}

		[Token(Token = "0x60016C4")]
		[Address(RVA = "0x738BEE0", Offset = "0x7387EE0", VA = "0x738BEE0")]
		public void ReportGMLogOpen()
		{
		}

		[Token(Token = "0x60016C5")]
		[Address(RVA = "0x738BF78", Offset = "0x7387F78", VA = "0x738BF78")]
		internal void ReportGetDType()
		{
		}

		[Token(Token = "0x60016C6")]
		[Address(RVA = "0x738C010", Offset = "0x7388010", VA = "0x738C010")]
		internal void ReportMinigameLaunchProgress()
		{
		}

		[Token(Token = "0x60016C7")]
		[Address(RVA = "0x738C1F0", Offset = "0x73881F0", VA = "0x738C1F0")]
		public void ReportLoginUserIDChange(string preUserId, string userId)
		{
		}

		[Token(Token = "0x60016C8")]
		[Address(RVA = "0x738C310", Offset = "0x7388310", VA = "0x738C310")]
		[Obsolete("使用Reportclient_Event((int)DBTSDK.UnityEventCode 代替", false)]
		public void Reportclient_error(int errorId, string errorMsg)
		{
		}

		[Token(Token = "0x60016C9")]
		[Address(RVA = "0x738C3E0", Offset = "0x73883E0", VA = "0x738C3E0")]
		public void Reportclient_Event(int eventId, string msg)
		{
		}

		[Token(Token = "0x60016CA")]
		[Address(RVA = "0x738C4AC", Offset = "0x73884AC", VA = "0x738C4AC")]
		public void ReportSaveUserData(string Info)
		{
		}

		[Token(Token = "0x60016CB")]
		[Address(RVA = "0x738C538", Offset = "0x7388538", VA = "0x738C538")]
		internal void ReportOnlineConfigParams(string key, string result, string serial_num)
		{
		}

		[Token(Token = "0x60016CC")]
		[Address(RVA = "0x738C5D8", Offset = "0x73885D8", VA = "0x738C5D8")]
		public void ReportGameNetInfo(int netType, string url, string result, int errorCode, string errorMsg, int time)
		{
		}

		[Token(Token = "0x60016CD")]
		[Obsolete("此方法已过时，请使用框架封装的方法，以NewReport_上报数据类名 开头的方法进行上报。Time=2021.03.22", true)]
		public void NewReportCustomize<T>(T JsonData) where T : NewReportJsonProperties
		{
		}

		[Token(Token = "0x60016CE")]
		private void OnNewEvent<T>(T obj) where T : NewReportJsonProperties
		{
		}

		[Token(Token = "0x60016CF")]
		private void OnNewEventOnlyOnce<T>(T obj) where T : NewReportJsonProperties
		{
		}

		[Token(Token = "0x60016D0")]
		[Address(RVA = "0x738C8EC", Offset = "0x73888EC", VA = "0x738C8EC")]
		private bool CheckWebGLEventOnce(string eventId)
		{
			return default;
		}

		[Token(Token = "0x60016D1")]
		public T GetNewReportJsonData<T>(bool ClearProperties = true, bool IsNew = false) where T : NewReportJsonPropertiesBase, new()
		{
			return null;
		}

		[Token(Token = "0x60016D2")]
		public void Report31Event<T>(T eventObj) where T : NewReportJsonProperties
		{
		}

		[Token(Token = "0x60016D3")]
		[Address(RVA = "0x738CC10", Offset = "0x7388C10", VA = "0x738CC10")]
		public void NewReport_game_share(game_share ReportClass)
		{
		}

		[Token(Token = "0x60016D4")]
		[Address(RVA = "0x738CC68", Offset = "0x7388C68", VA = "0x738CC68")]
		public void NewReport_game_evaluate(game_evaluate ReportClass)
		{
		}

		[Token(Token = "0x60016D5")]
		[Address(RVA = "0x738CD2C", Offset = "0x7388D2C", VA = "0x738CD2C")]
		public void NewReport_game_ui_sort(game_ui_sort ReportClass)
		{
		}

		[Token(Token = "0x60016D6")]
		[Address(RVA = "0x738CD84", Offset = "0x7388D84", VA = "0x738CD84")]
		public void NewReport_game_start(game_start ReportClass)
		{
		}

		[Token(Token = "0x60016D7")]
		[Address(RVA = "0x738CE48", Offset = "0x7388E48", VA = "0x738CE48")]
		public void NewReport_game_complete(game_complete ReportClass)
		{
		}

		[Token(Token = "0x60016D8")]
		[Address(RVA = "0x738CF0C", Offset = "0x7388F0C", VA = "0x738CF0C")]
		public void NewReport_game_stuck(game_stuck ReportClass)
		{
		}

		[Token(Token = "0x60016D9")]
		[Address(RVA = "0x738CFD0", Offset = "0x7388FD0", VA = "0x738CFD0")]
		public void NewReport_game_quit(game_quit ReportClass)
		{
		}

		[Token(Token = "0x60016DA")]
		[Address(RVA = "0x738D094", Offset = "0x7389094", VA = "0x738D094")]
		public void NewReport_game_unlock(game_unlock ReportClass)
		{
		}

		[Token(Token = "0x60016DB")]
		[Address(RVA = "0x738D158", Offset = "0x7389158", VA = "0x738D158")]
		public void NewReport_game_loadstart(game_loadstart ReportClass)
		{
		}

		[Token(Token = "0x60016DC")]
		[Address(RVA = "0x738D21C", Offset = "0x738921C", VA = "0x738D21C")]
		public void NewReport_game_loadover(game_loadover ReportClass)
		{
		}

		[Token(Token = "0x60016DD")]
		[Address(RVA = "0x738D2E0", Offset = "0x73892E0", VA = "0x738D2E0")]
		public void NewReport_game_loadfail(game_loadfail ReportClass)
		{
		}

		[Token(Token = "0x60016DE")]
		[Address(RVA = "0x738D3A4", Offset = "0x73893A4", VA = "0x738D3A4")]
		public void NewReport_game_click(game_click ReportClass)
		{
		}

		[Token(Token = "0x60016DF")]
		[Address(RVA = "0x738D468", Offset = "0x7389468", VA = "0x738D468")]
		public void NewReport_game_round_start(game_round_start ReportClass)
		{
		}

		[Token(Token = "0x60016E0")]
		[Address(RVA = "0x738D52C", Offset = "0x738952C", VA = "0x738D52C")]
		public void NewReport_game_round_complete(game_round_complete ReportClass)
		{
		}

		[Token(Token = "0x60016E1")]
		[Address(RVA = "0x738D5F0", Offset = "0x73895F0", VA = "0x738D5F0")]
		public void NewReport_game_behavior(game_behavior ReportClass)
		{
		}

		[Token(Token = "0x60016E2")]
		[Address(RVA = "0x738D6B4", Offset = "0x73896B4", VA = "0x738D6B4")]
		public void NewReport_game_difficulty_adjust(game_difficulty_adjust ReportClass)
		{
		}

		[Token(Token = "0x60016E3")]
		[Address(RVA = "0x738D778", Offset = "0x7389778", VA = "0x738D778")]
		public void NewReport_game_replay(game_replay ReportClass)
		{
		}

		[Token(Token = "0x60016E4")]
		[Address(RVA = "0x738D83C", Offset = "0x738983C", VA = "0x738D83C")]
		public void NewReport_item_get(item_get ReportClass)
		{
		}

		[Token(Token = "0x60016E5")]
		[Address(RVA = "0x738D900", Offset = "0x7389900", VA = "0x738D900")]
		public void NewReport_item_cost(item_cost ReportClass)
		{
		}

		[Token(Token = "0x60016E6")]
		[Address(RVA = "0x738D9C4", Offset = "0x73899C4", VA = "0x738D9C4")]
		public void NewReport_item_use(item_use ReportClass)
		{
		}

		[Token(Token = "0x60016E7")]
		[Address(RVA = "0x738DA88", Offset = "0x7389A88", VA = "0x738DA88")]
		public void NewReport_item_buy(item_buy ReportClass)
		{
		}

		[Token(Token = "0x60016E8")]
		[Address(RVA = "0x738DB4C", Offset = "0x7389B4C", VA = "0x738DB4C")]
		public void NewReport_tools_unlock(tools_unlock ReportClass)
		{
		}

		[Token(Token = "0x60016E9")]
		[Address(RVA = "0x738DBA4", Offset = "0x7389BA4", VA = "0x738DBA4")]
		public void NewReport_tools_fail(tools_fail ReportClass)
		{
		}

		[Token(Token = "0x60016EA")]
		[Address(RVA = "0x738DC68", Offset = "0x7389C68", VA = "0x738DC68")]
		public void NewReport_tools_use(tools_use ReportClass)
		{
		}

		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x738DD2C", Offset = "0x7389D2C", VA = "0x738DD2C")]
		public void NewReport_activity_warmup(activity_warmup ReportClass)
		{
		}

		[Token(Token = "0x60016EC")]
		[Address(RVA = "0x738DDF0", Offset = "0x7389DF0", VA = "0x738DDF0")]
		public void NewReport_activity_unlock(activity_unlock ReportClass)
		{
		}

		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x738DEB4", Offset = "0x7389EB4", VA = "0x738DEB4")]
		public void NewReport_activity_enter(activity_enter ReportClass)
		{
		}

		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x738DF78", Offset = "0x7389F78", VA = "0x738DF78")]
		public void NewReport_activity_start(activity_start ReportClass)
		{
		}

		[Token(Token = "0x60016EF")]
		[Address(RVA = "0x738E03C", Offset = "0x738A03C", VA = "0x738E03C")]
		public void NewReport_activity_fail(activity_fail ReportClass)
		{
		}

		[Token(Token = "0x60016F0")]
		[Address(RVA = "0x738E100", Offset = "0x738A100", VA = "0x738E100")]
		public void NewReport_activity_success(activity_success ReportClass)
		{
		}

		[Token(Token = "0x60016F1")]
		[Address(RVA = "0x738E1C4", Offset = "0x738A1C4", VA = "0x738E1C4")]
		public void NewReport_activity_reward(activity_reward ReportClass)
		{
		}

		[Token(Token = "0x60016F2")]
		[Address(RVA = "0x738E288", Offset = "0x738A288", VA = "0x738E288")]
		public void NewReport_activity_reset(activity_reset ReportClass)
		{
		}

		[Token(Token = "0x60016F3")]
		[Address(RVA = "0x738E34C", Offset = "0x738A34C", VA = "0x738E34C")]
		public void NewReport_activity_giveup(activity_giveup ReportClass)
		{
		}

		[Token(Token = "0x60016F4")]
		[Address(RVA = "0x738E410", Offset = "0x738A410", VA = "0x738E410")]
		public void NewReport_activity_complete(activity_complete ReportClass)
		{
		}

		[Token(Token = "0x60016F5")]
		[Address(RVA = "0x738E4D4", Offset = "0x738A4D4", VA = "0x738E4D4")]
		public void NewReport_activity_register(activity_register ReportClass)
		{
		}

		[Token(Token = "0x60016F6")]
		[Address(RVA = "0x738E598", Offset = "0x738A598", VA = "0x738E598")]
		public void NewReport_challenge_competition(challenge_competition ReportClass)
		{
		}

		[Token(Token = "0x60016F7")]
		[Address(RVA = "0x738E5F0", Offset = "0x738A5F0", VA = "0x738E5F0")]
		public void NewReport_live_activity_start(live_activity_start ReportClass)
		{
		}

		[Token(Token = "0x60016F8")]
		[Address(RVA = "0x738E648", Offset = "0x738A648", VA = "0x738E648")]
		public void NewReport_live_activity_click(live_activity_click ReportClass)
		{
		}

		[Token(Token = "0x60016F9")]
		[Address(RVA = "0x738E6A0", Offset = "0x738A6A0", VA = "0x738E6A0")]
		public void NewReport_live_activity_update(live_activity_update ReportClass)
		{
		}

		[Token(Token = "0x60016FA")]
		[Address(RVA = "0x738E6F8", Offset = "0x738A6F8", VA = "0x738E6F8")]
		public void NewReport_live_activity_complete(live_activity_complete ReportClass)
		{
		}

		[Token(Token = "0x60016FB")]
		[Address(RVA = "0x738E750", Offset = "0x738A750", VA = "0x738E750")]
		public void NewReport_develop_enter(develop_enter ReportClass)
		{
		}

		[Token(Token = "0x60016FC")]
		[Address(RVA = "0x738E7A8", Offset = "0x738A7A8", VA = "0x738E7A8")]
		public void NewReport_develop_trail(develop_trail ReportClass)
		{
		}

		[Token(Token = "0x60016FD")]
		[Address(RVA = "0x738E800", Offset = "0x738A800", VA = "0x738E800")]
		public void NewReport_develop_unlock(develop_unlock ReportClass)
		{
		}

		[Token(Token = "0x60016FE")]
		[Address(RVA = "0x738E8C4", Offset = "0x738A8C4", VA = "0x738E8C4")]
		public void NewReport_develop_start(develop_start ReportClass)
		{
		}

		[Token(Token = "0x60016FF")]
		[Address(RVA = "0x738E91C", Offset = "0x738A91C", VA = "0x738E91C")]
		public void NewReport_develop_action(develop_action ReportClass)
		{
		}

		[Token(Token = "0x6001700")]
		[Address(RVA = "0x738E9E0", Offset = "0x738A9E0", VA = "0x738E9E0")]
		public void NewReport_develop_use(develop_use ReportClass)
		{
		}

		[Token(Token = "0x6001701")]
		[Address(RVA = "0x738EAA4", Offset = "0x738AAA4", VA = "0x738EAA4")]
		public void NewReport_develop_levelup(develop_levelup ReportClass)
		{
		}

		[Token(Token = "0x6001702")]
		[Address(RVA = "0x738EB68", Offset = "0x738AB68", VA = "0x738EB68")]
		public void NewReport_develop_speedup(develop_speedup ReportClass)
		{
		}

		[Token(Token = "0x6001703")]
		[Address(RVA = "0x738EBC0", Offset = "0x738ABC0", VA = "0x738EBC0")]
		public void NewReport_develop_complete(develop_complete ReportClass)
		{
		}

		[Token(Token = "0x6001704")]
		[Address(RVA = "0x738EC18", Offset = "0x738AC18", VA = "0x738EC18")]
		public void NewReport_develop_destroy(develop_destroy ReportClass)
		{
		}

		[Token(Token = "0x6001705")]
		[Address(RVA = "0x738EC70", Offset = "0x738AC70", VA = "0x738EC70")]
		public void NewReport_ui_open(ui_open ReportClass)
		{
		}

		[Token(Token = "0x6001706")]
		[Address(RVA = "0x738ED34", Offset = "0x738AD34", VA = "0x738ED34")]
		public void NewReport_ui_close(ui_close ReportClass)
		{
		}

		[Token(Token = "0x6001707")]
		[Address(RVA = "0x738EDF8", Offset = "0x738ADF8", VA = "0x738EDF8")]
		public void NewReport_element_show(element_show ReportClass)
		{
		}

		[Token(Token = "0x6001708")]
		[Address(RVA = "0x738EE50", Offset = "0x738AE50", VA = "0x738EE50")]
		public void NewReport_element_use(element_use ReportClass)
		{
		}

		[Token(Token = "0x6001709")]
		[Address(RVA = "0x738EF14", Offset = "0x738AF14", VA = "0x738EF14")]
		public void NewReport_element_result(element_result ReportClass)
		{
		}

		[Token(Token = "0x600170A")]
		[Address(RVA = "0x738EFD8", Offset = "0x738AFD8", VA = "0x738EFD8")]
		public void NewReport_popup_show(popup_show ReportClass)
		{
		}

		[Token(Token = "0x600170B")]
		[Address(RVA = "0x738F09C", Offset = "0x738B09C", VA = "0x738F09C")]
		public void NewReport_popup_redirect(popup_redirect ReportClass)
		{
		}

		[Token(Token = "0x600170C")]
		[Address(RVA = "0x738F160", Offset = "0x738B160", VA = "0x738F160")]
		public void NewReport_res_downloadstart(res_downloadstart ReportClass)
		{
		}

		[Token(Token = "0x600170D")]
		[Address(RVA = "0x738F1B8", Offset = "0x738B1B8", VA = "0x738F1B8")]
		public void NewReport_res_downloadover(res_downloadover ReportClass)
		{
		}

		[Token(Token = "0x600170E")]
		[Address(RVA = "0x738F210", Offset = "0x738B210", VA = "0x738F210")]
		public void NewReport_res_downloadfail(res_downloadfail ReportClass)
		{
		}

		[Token(Token = "0x600170F")]
		[Address(RVA = "0x738F268", Offset = "0x738B268", VA = "0x738F268")]
		public void NewReport_res_read_fail(res_read_fail ReportClass)
		{
		}

		[Token(Token = "0x6001710")]
		[Address(RVA = "0x738F2C0", Offset = "0x738B2C0", VA = "0x738F2C0")]
		public void NewReport_mail_check(mail_check ReportClass)
		{
		}

		[Token(Token = "0x6001711")]
		[Address(RVA = "0x738F318", Offset = "0x738B318", VA = "0x738F318")]
		public void NewReport_mail_delete(mail_delete ReportClass)
		{
		}

		[Token(Token = "0x6001712")]
		[Address(RVA = "0x738F370", Offset = "0x738B370", VA = "0x738F370")]
		public void NewReport_mail_receive(mail_receive ReportClass)
		{
		}

		[Token(Token = "0x6001713")]
		[Address(RVA = "0x738F3C8", Offset = "0x738B3C8", VA = "0x738F3C8")]
		public void NewReport_video_refuse(video_refuse ReportClass)
		{
		}

		[Token(Token = "0x6001714")]
		[Address(RVA = "0x738F48C", Offset = "0x738B48C", VA = "0x738F48C")]
		public void NewReport_video_popup_success(video_popup_success ReportClass)
		{
		}

		[Token(Token = "0x6001715")]
		[Address(RVA = "0x738F550", Offset = "0x738B550", VA = "0x738F550")]
		public void NewReport_video_popup_fail(video_popup_fail ReportClass)
		{
		}

		[Token(Token = "0x6001716")]
		[Address(RVA = "0x738F614", Offset = "0x738B614", VA = "0x738F614")]
		public void NewReport_insert_all(insert_all ReportClass)
		{
		}

		[Token(Token = "0x6001717")]
		[Address(RVA = "0x738F6D8", Offset = "0x738B6D8", VA = "0x738F6D8")]
		public void NewReport_insert_nonet(insert_nonet ReportClass)
		{
		}

		[Token(Token = "0x6001718")]
		[Address(RVA = "0x738F79C", Offset = "0x738B79C", VA = "0x738F79C")]
		public void NewReport_insert_select(insert_select ReportClass)
		{
		}

		[Token(Token = "0x6001719")]
		[Address(RVA = "0x738F860", Offset = "0x738B860", VA = "0x738F860")]
		public void NewReport_insert_show(insert_show ReportClass)
		{
		}

		[Token(Token = "0x600171A")]
		[Address(RVA = "0x738F924", Offset = "0x738B924", VA = "0x738F924")]
		public void NewReport_inters_click(inters_click ReportClass)
		{
		}

		[Token(Token = "0x600171B")]
		[Address(RVA = "0x738F97C", Offset = "0x738B97C", VA = "0x738F97C")]
		public void NewReport_insert_close(insert_close ReportClass)
		{
		}

		[Token(Token = "0x600171C")]
		[Address(RVA = "0x738FA40", Offset = "0x738BA40", VA = "0x738FA40")]
		public void NewReport_insert_show_level(insert_show_level ReportClass)
		{
		}

		[Token(Token = "0x600171D")]
		[Address(RVA = "0x738FA98", Offset = "0x738BA98", VA = "0x738FA98")]
		public void NewReport_tcp_delay(tcp_delay ReportClass)
		{
		}

		[Token(Token = "0x600171E")]
		[Address(RVA = "0x738FAF0", Offset = "0x738BAF0", VA = "0x738FAF0")]
		public void NewReport_login_register(login_register ReportClass)
		{
		}

		[Token(Token = "0x600171F")]
		[Address(RVA = "0x738FB48", Offset = "0x738BB48", VA = "0x738FB48")]
		public void NewReport_login_bind(login_bind ReportClass)
		{
		}

		[Token(Token = "0x6001720")]
		[Address(RVA = "0x738FBA0", Offset = "0x738BBA0", VA = "0x738FBA0")]
		public void NewReport_login_request(login_request ReportClass)
		{
		}

		[Token(Token = "0x6001721")]
		[Address(RVA = "0x738FBF8", Offset = "0x738BBF8", VA = "0x738FBF8")]
		public void NewReport_login_success(login_success ReportClass)
		{
		}

		[Token(Token = "0x6001722")]
		[Address(RVA = "0x738FC50", Offset = "0x738BC50", VA = "0x738FC50")]
		public void NewReport_login_fail(login_fail ReportClass)
		{
		}

		[Token(Token = "0x6001723")]
		[Address(RVA = "0x738FCA8", Offset = "0x738BCA8", VA = "0x738FCA8")]
		public void NewReport_login_enterfsm(login_enterfsm ReportClass)
		{
		}

		[Token(Token = "0x6001724")]
		[Address(RVA = "0x738FD00", Offset = "0x738BD00", VA = "0x738FD00")]
		public void NewReport_login_leavefsm(login_leavefsm ReportClass)
		{
		}

		[Token(Token = "0x6001725")]
		[Address(RVA = "0x738FD58", Offset = "0x738BD58", VA = "0x738FD58")]
		public void NewReport_login_sdk(login_sdk ReportClass)
		{
		}

		[Token(Token = "0x6001726")]
		[Address(RVA = "0x738FDB0", Offset = "0x738BDB0", VA = "0x738FDB0")]
		public void NewReport_login_startserver(login_startserver ReportClass)
		{
		}

		[Token(Token = "0x6001727")]
		[Address(RVA = "0x738FE08", Offset = "0x738BE08", VA = "0x738FE08")]
		public void NewReport_login_server(login_server ReportClass)
		{
		}

		[Token(Token = "0x6001728")]
		[Address(RVA = "0x738FE60", Offset = "0x738BE60", VA = "0x738FE60")]
		public void NewReport_login_startsyndata(login_startsyndata ReportClass)
		{
		}

		[Token(Token = "0x6001729")]
		[Address(RVA = "0x738FEB8", Offset = "0x738BEB8", VA = "0x738FEB8")]
		public void NewReport_login_SynDatachangeuser(login_SynDatachangeuser ReportClass)
		{
		}

		[Token(Token = "0x600172A")]
		[Address(RVA = "0x738FF10", Offset = "0x738BF10", VA = "0x738FF10")]
		public void NewReport_login_focusupdate(login_focusupdate ReportClass)
		{
		}

		[Token(Token = "0x600172B")]
		[Address(RVA = "0x738FF68", Offset = "0x738BF68", VA = "0x738FF68")]
		public void NewReport_login_focusupload(login_focusupload ReportClass)
		{
		}

		[Token(Token = "0x600172C")]
		[Address(RVA = "0x738FFC0", Offset = "0x738BFC0", VA = "0x738FFC0")]
		public void NewReport_login_synData_needUpdateData(login_synData_needUpdateData ReportClass)
		{
		}

		[Token(Token = "0x600172D")]
		[Address(RVA = "0x7390018", Offset = "0x738C018", VA = "0x7390018")]
		public void NewReport_login_syndata_needuploaddata(login_syndata_needuploaddata ReportClass)
		{
		}

		[Token(Token = "0x600172E")]
		[Address(RVA = "0x7390070", Offset = "0x738C070", VA = "0x7390070")]
		public void NewReport_login_syndata_actionsuccess(login_syndata_actionsuccess ReportClass)
		{
		}

		[Token(Token = "0x600172F")]
		[Address(RVA = "0x73900C8", Offset = "0x738C0C8", VA = "0x73900C8")]
		public void NewReport_login_syndata_fsmsuccess(login_syndata_fsmsuccess ReportClass)
		{
		}

		[Token(Token = "0x6001730")]
		[Address(RVA = "0x7390120", Offset = "0x738C120", VA = "0x7390120")]
		public void NewReport_login_nethttperror(login_nethttperror ReportClass)
		{
		}

		[Token(Token = "0x6001731")]
		[Address(RVA = "0x7390178", Offset = "0x738C178", VA = "0x7390178")]
		public void NewReport_login_download_request(login_download_request ReportClass)
		{
		}

		[Token(Token = "0x6001732")]
		[Address(RVA = "0x73901D0", Offset = "0x738C1D0", VA = "0x73901D0")]
		public void NewReport_login_download_success(login_download_success ReportClass)
		{
		}

		[Token(Token = "0x6001733")]
		[Address(RVA = "0x7390228", Offset = "0x738C228", VA = "0x7390228")]
		public void NewReport_login_download_fail(login_download_fail ReportClass)
		{
		}

		[Token(Token = "0x6001734")]
		[Address(RVA = "0x7390280", Offset = "0x738C280", VA = "0x7390280")]
		public void NewReport_login_upload_request(login_upload_request ReportClass)
		{
		}

		[Token(Token = "0x6001735")]
		[Address(RVA = "0x73902D8", Offset = "0x738C2D8", VA = "0x73902D8")]
		public void NewReport_login_upload_success(login_upload_success ReportClass)
		{
		}

		[Token(Token = "0x6001736")]
		[Address(RVA = "0x7390330", Offset = "0x738C330", VA = "0x7390330")]
		public void NewReport_login_upload_fail(login_upload_fail ReportClass)
		{
		}

		[Token(Token = "0x6001737")]
		[Address(RVA = "0x7390388", Offset = "0x738C388", VA = "0x7390388")]
		public void NewReport_user_level_update(user_level_update ReportClass)
		{
		}

		[Token(Token = "0x6001738")]
		[Address(RVA = "0x73903E0", Offset = "0x738C3E0", VA = "0x73903E0")]
		public void NewReport_login_userloginout(login_userloginout ReportClass)
		{
		}

		[Token(Token = "0x6001739")]
		[Address(RVA = "0x7390438", Offset = "0x738C438", VA = "0x7390438")]
		public void NewReport_pay_success_custom(pay_success_custom ReportClass)
		{
		}

		[Token(Token = "0x600173A")]
		[Address(RVA = "0x73904FC", Offset = "0x738C4FC", VA = "0x73904FC")]
		public void NewReport_unity_online_config_params(unity_online_config_params ReportClass)
		{
		}

		[Token(Token = "0x600173B")]
		[Address(RVA = "0x7390554", Offset = "0x738C554", VA = "0x7390554")]
		public void NewReport_minigame_launch_progress(minigame_launch_progress ReportClass)
		{
		}

		[Token(Token = "0x600173C")]
		[Address(RVA = "0x73905AC", Offset = "0x738C5AC", VA = "0x73905AC")]
		public void NewReport_ttfeed_entry(ttfeed_entry ReportClass)
		{
		}

		[Token(Token = "0x600173D")]
		[Address(RVA = "0x7390604", Offset = "0x738C604", VA = "0x7390604")]
		public void NewReport_ttfeed_subscribe(ttfeed_subscribe ReportClass)
		{
		}

		[Token(Token = "0x600173E")]
		[Address(RVA = "0x739065C", Offset = "0x738C65C", VA = "0x739065C")]
		public void NewReport_ttfeed_game_ready(ttfeed_game_ready ReportClass)
		{
		}

		[Token(Token = "0x600173F")]
		[Address(RVA = "0x73906B4", Offset = "0x738C6B4", VA = "0x73906B4")]
		public void NewReport_ttfeed_reportev(ttfeed_reportev ReportClass)
		{
		}

		[Token(Token = "0x6001740")]
		[Address(RVA = "0x739070C", Offset = "0x738C70C", VA = "0x739070C")]
		public void NewReport_user_tag_update(user_tag_update ReportClass)
		{
		}

		[Token(Token = "0x6001741")]
		[Address(RVA = "0x7390764", Offset = "0x738C764", VA = "0x7390764")]
		public void NewReport_user_cheat(user_cheat ReportClass)
		{
		}

		[Token(Token = "0x6001742")]
		[Address(RVA = "0x73907BC", Offset = "0x738C7BC", VA = "0x73907BC")]
		public void NewReport_dealing_card(dealing_card ReportClass)
		{
		}

		[Token(Token = "0x6001743")]
		[Address(RVA = "0x7390880", Offset = "0x738C880", VA = "0x7390880")]
		public void NewReport_game_service_login(game_service_login ReportClass)
		{
		}

		[Token(Token = "0x6001744")]
		[Address(RVA = "0x73908D8", Offset = "0x738C8D8", VA = "0x73908D8")]
		public void NewReport_loading_event(loading_event ReportClass)
		{
		}

		[Token(Token = "0x6001745")]
		[Address(RVA = "0x7390930", Offset = "0x738C930", VA = "0x7390930")]
		public void NewReport_resume_request(resume_request ReportClass)
		{
		}

		[Token(Token = "0x6001746")]
		[Address(RVA = "0x73909F4", Offset = "0x738C9F4", VA = "0x73909F4")]
		public void NewReport_resume_success(resume_success ReportClass)
		{
		}

		[Token(Token = "0x6001748")]
		[Address(RVA = "0x7390A70", Offset = "0x738CA70", VA = "0x7390A70")]
		private void GamePause(object[] Args)
		{
		}

		[Token(Token = "0x6001749")]
		[Address(RVA = "0x7390C14", Offset = "0x738CC14", VA = "0x7390C14")]
		private void GameFocus(object[] Args)
		{
		}

		[Token(Token = "0x600174A")]
		[Address(RVA = "0x7390CCC", Offset = "0x738CCCC", VA = "0x7390CCC")]
		private void NewReportGamePlayTime(int times, int TotleTimes)
		{
		}

		[Token(Token = "0x600174B")]
		[Address(RVA = "0x7390D04", Offset = "0x738CD04", VA = "0x7390D04")]
		private void NewReportGameModelPlayTime(int times, int TotleTimes)
		{
		}

		[Token(Token = "0x600174C")]
		[Address(RVA = "0x7390E3C", Offset = "0x738CE3C", VA = "0x7390E3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600174D")]
		[Address(RVA = "0x7390FC0", Offset = "0x738CFC0", VA = "0x7390FC0")]
		public void InitReportManager()
		{
		}

		[Token(Token = "0x600174E")]
		[Address(RVA = "0x7391114", Offset = "0x738D114", VA = "0x7391114")]
		private void MineGameExitLogic(object[] Args)
		{
		}

		[Token(Token = "0x600174F")]
		[Address(RVA = "0x7391350", Offset = "0x738D350", VA = "0x7391350")]
		public void ReportGameStartTimes()
		{
		}

		[Token(Token = "0x6001750")]
		[Address(RVA = "0x73914C0", Offset = "0x738D4C0", VA = "0x73914C0")]
		public void StartMineGame()
		{
		}

		[Token(Token = "0x6001751")]
		[Address(RVA = "0x739160C", Offset = "0x738D60C", VA = "0x739160C")]
		public void ReportGamePlayTime(int times)
		{
		}

		[Token(Token = "0x6001752")]
		[Address(RVA = "0x7391610", Offset = "0x738D610", VA = "0x7391610")]
		public void StartGameModel(MineGameModel mineGameModel)
		{
		}

		[Token(Token = "0x6001753")]
		[Address(RVA = "0x739168C", Offset = "0x738D68C", VA = "0x739168C")]
		public void StartGameModel(string mineGameModel)
		{
		}

		[Token(Token = "0x6001754")]
		[Address(RVA = "0x7391EB8", Offset = "0x738DEB8", VA = "0x7391EB8")]
		private void ReportGameModelPlayTime(int times)
		{
		}

		[Token(Token = "0x6001755")]
		[Address(RVA = "0x73920F4", Offset = "0x738E0F4", VA = "0x73920F4")]
		private void AddGmaeModeTimer(string mineGameModel)
		{
		}

		[Token(Token = "0x6001756")]
		[Address(RVA = "0x73923B8", Offset = "0x738E3B8", VA = "0x73923B8")]
		private void ReportGameModelTimes(int times)
		{
		}

		[Token(Token = "0x6001757")]
		[Address(RVA = "0x73923BC", Offset = "0x738E3BC", VA = "0x73923BC")]
		private void StopGameModeTimer(string mineGameModel)
		{
		}

		[Token(Token = "0x6001758")]
		[Address(RVA = "0x739252C", Offset = "0x738E52C", VA = "0x739252C")]
		private void RemoveGameModeLoopTimer(int time)
		{
		}

		[Token(Token = "0x6001759")]
		[Address(RVA = "0x7392530", Offset = "0x738E530", VA = "0x7392530")]
		[Obsolete("此方法属于旧版上报，请使用新版上报替换", true)]
		public void StartLevel(int LevelId)
		{
		}

		[Token(Token = "0x600175A")]
		[Address(RVA = "0x73927EC", Offset = "0x738E7EC", VA = "0x73927EC")]
		[Obsolete("此方法属于旧版上报，请使用新版上报替换", true)]
		public void OverLevel(int LevelId, bool IsSuccess)
		{
		}

		[Token(Token = "0x600175B")]
		[Address(RVA = "0x7392AB0", Offset = "0x738EAB0", VA = "0x7392AB0")]
		internal void ReportVideo(string videFlag)
		{
		}

		[Token(Token = "0x600175C")]
		[Address(RVA = "0x73888A4", Offset = "0x73848A4", VA = "0x73888A4")]
		[Obsolete("老上报接口过时，请使用对应的NewReport_事件名接口")]
		public void ReportEvent(string key, string label, int count = 0)
		{
		}

		[Token(Token = "0x600175D")]
		[Address(RVA = "0x7392094", Offset = "0x738E094", VA = "0x7392094")]
		private void ReportGameTimes(string key, int ms, string label = "")
		{
		}

		[Token(Token = "0x600175E")]
		[Address(RVA = "0x73888F4", Offset = "0x73848F4", VA = "0x73888F4")]
		[Obsolete("老上报接口过时")]
		public void OnEvenToOnlyOnce(string event_id, string label)
		{
		}

		[Token(Token = "0x600175F")]
		[Address(RVA = "0x7393578", Offset = "0x738F578", VA = "0x7393578")]
		[Obsolete("老上报接口过时")]
		public void OnEvenToOnlyOnce(string event_id, string label, int n)
		{
		}

		[Token(Token = "0x6001760")]
		[Address(RVA = "0x73936BC", Offset = "0x738F6BC", VA = "0x73936BC")]
		public void TrackVideo(int type)
		{
		}

		[Token(Token = "0x6001761")]
		[Address(RVA = "0x73937F0", Offset = "0x738F7F0", VA = "0x73937F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6001762")]
		[Address(RVA = "0x7393860", Offset = "0x738F860", VA = "0x7393860")]
		private void Start()
		{
		}

		[Token(Token = "0x6001763")]
		[Address(RVA = "0x7392ED8", Offset = "0x738EED8", VA = "0x7392ED8")]
		internal void OnEvent(string event_id, string label)
		{
		}

		[Token(Token = "0x6001764")]
		[Address(RVA = "0x7393024", Offset = "0x738F024", VA = "0x7393024")]
		internal void OnEvent(string event_id, string label, int n)
		{
		}

		[Token(Token = "0x6001765")]
		[Address(RVA = "0x739317C", Offset = "0x738F17C", VA = "0x739317C")]
		internal void OnEventDuration(string event_id, int ms)
		{
		}

		[Token(Token = "0x6001766")]
		[Address(RVA = "0x73932C8", Offset = "0x738F2C8", VA = "0x73932C8")]
		internal void OnEventDuration(string event_id, string label, int ms)
		{
		}

		[Token(Token = "0x6001767")]
		[Address(RVA = "0x7393864", Offset = "0x738F864", VA = "0x7393864")]
		internal void OnEventOnlyOnce(string event_id, string label)
		{
		}

		[Token(Token = "0x6001768")]
		[Address(RVA = "0x7393420", Offset = "0x738F420", VA = "0x7393420")]
		internal void OnEventOnlyOnce(string event_id, string label, int n)
		{
		}

		[Token(Token = "0x6001769")]
		[Address(RVA = "0x73936C0", Offset = "0x738F6C0", VA = "0x73936C0")]
		internal void TrackVideoStatic(int type)
		{
		}

		[Token(Token = "0x600176A")]
		[Address(RVA = "0x73939B0", Offset = "0x738F9B0", VA = "0x73939B0")]
		public void OnEventHomeApp()
		{
		}

		[Token(Token = "0x600176B")]
		[Address(RVA = "0x7393AD4", Offset = "0x738FAD4", VA = "0x7393AD4")]
		internal void OnNewEvent(string eventId)
		{
		}

		[Token(Token = "0x600176C")]
		[Address(RVA = "0x7393C04", Offset = "0x738FC04", VA = "0x7393C04")]
		internal void OnNewEvent(string eventId, string jsonProperties)
		{
		}

		[Token(Token = "0x600176D")]
		[Address(RVA = "0x7393D50", Offset = "0x738FD50", VA = "0x7393D50")]
		internal void OnNewEventOnlyOnce(string eventId)
		{
		}

		[Token(Token = "0x600176E")]
		[Address(RVA = "0x7393E80", Offset = "0x738FE80", VA = "0x7393E80")]
		internal void OnNewEventOnlyOnce(string eventId, string jsonProperties)
		{
		}

		[Token(Token = "0x600176F")]
		[Address(RVA = "0x7387A6C", Offset = "0x7383A6C", VA = "0x7387A6C")]
		internal void OnNewEventToGravity(string eventId, string jsonProperties)
		{
		}

		[Token(Token = "0x6001770")]
		[Address(RVA = "0x7393FCC", Offset = "0x738FFCC", VA = "0x7393FCC")]
		public void OnNewEventToApplovin(string eventId, string jsonProperties)
		{
		}

		[Token(Token = "0x6001771")]
		[Address(RVA = "0x7394118", Offset = "0x7390118", VA = "0x7394118")]
		public ReportManager()
		{
		}
	}
}
