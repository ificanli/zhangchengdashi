using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x2000564")]
	public class ReportEventsManager : ManagerBase<ReportEventsManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000566")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__40 : IAsyncStateMachine
		{
			[Token(Token = "0x4002F93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002F94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x6001BEB")]
			[Address(RVA = "0x3EC7F38", Offset = "0x3EC3F38", VA = "0x3EC7F38", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001BEC")]
			[Address(RVA = "0x3EC7FEC", Offset = "0x3EC3FEC", VA = "0x3EC7FEC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002F77")]
		private const string ExpUpGrade = "LevelUp";

		[Token(Token = "0x4002F78")]
		private const string DanUpGrade = "RankPromoted";

		[Token(Token = "0x4002F79")]
		private const string UnLockNewArena = "NewArenaUnlock";

		[Token(Token = "0x4002F7A")]
		private const string MainTowerUpgradeAttack = "MainCityUpgradeAttack";

		[Token(Token = "0x4002F7B")]
		private const string MainTowerUpgradeHp = "MainCityUpgradeHp";

		[Token(Token = "0x4002F7C")]
		private const string MainTowerUpgradeCd = "MainCityUpgradeAttackSpeed";

		[Token(Token = "0x4002F7D")]
		private const string UpgradeCard = "card_upgraded";

		[Token(Token = "0x4002F7E")]
		private const string GetNewCard = "CardUnlock";

		[Token(Token = "0x4002F7F")]
		private const string BattleEnd = "BattleCompleted";

		[Token(Token = "0x4002F80")]
		private const string ChangeName = "ChangeName";

		[Token(Token = "0x4002F81")]
		private const string Item_Transaction = "item_transaction";

		[Token(Token = "0x4002F82")]
		private const string CardCollect = "card_collection";

		[Token(Token = "0x4002F83")]
		private const string GameStart = "game_start";

		[Token(Token = "0x4002F84")]
		private const string GameFinish = "game_finish";

		[Token(Token = "0x4002F85")]
		private const string AppOpen = "app_open";

		[Token(Token = "0x4002F86")]
		private const string UnLockArena = "custom_unlock_arena";

		[Token(Token = "0x4002F87")]
		private const string ChainStart = "chain_start";

		[Token(Token = "0x4002F88")]
		private const string ChainEnd = "chain_end";

		[Token(Token = "0x4002F89")]
		private const string OfferShown = "offer_shown";

		[Token(Token = "0x4002F8A")]
		private const string ShopOpened = "shop_opened";

		[Token(Token = "0x4002F8B")]
		private const string UnitUpgrade = "unit_upgrade";

		[Token(Token = "0x4002F8C")]
		private const string UnlockedUnit = "unlocked_unit";

		[Token(Token = "0x4002F8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private long _battleStartTimestamp;

		[Token(Token = "0x1700016F")]
		public int UserExpLevel
		{
			[Token(Token = "0x6001BB7")]
			[Address(RVA = "0x3EC064C", Offset = "0x3EBC64C", VA = "0x3EC064C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000170")]
		private int DanLevel
		{
			[Token(Token = "0x6001BB8")]
			[Address(RVA = "0x3EC069C", Offset = "0x3EBC69C", VA = "0x3EC069C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000171")]
		private int MaxArenaLevel
		{
			[Token(Token = "0x6001BB9")]
			[Address(RVA = "0x3EC0704", Offset = "0x3EBC704", VA = "0x3EC0704")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000172")]
		private float CardAverageLevel
		{
			[Token(Token = "0x6001BBA")]
			[Address(RVA = "0x3EC0754", Offset = "0x3EBC754", VA = "0x3EC0754")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000173")]
		private float CardAverageLevelJieSuan
		{
			[Token(Token = "0x6001BBB")]
			[Address(RVA = "0x3EC09DC", Offset = "0x3EBC9DC", VA = "0x3EC09DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000174")]
		private int GetMaintowerAttackLevel
		{
			[Token(Token = "0x6001BBC")]
			[Address(RVA = "0x3EC0C78", Offset = "0x3EBCC78", VA = "0x3EC0C78")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000175")]
		private int GetMaintowerHpLevel
		{
			[Token(Token = "0x6001BBD")]
			[Address(RVA = "0x3EC0D14", Offset = "0x3EBCD14", VA = "0x3EC0D14")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000176")]
		private int GetMaintowerCdLevel
		{
			[Token(Token = "0x6001BBE")]
			[Address(RVA = "0x3EC0DB0", Offset = "0x3EBCDB0", VA = "0x3EC0DB0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000177")]
		private int CardSumLevel
		{
			[Token(Token = "0x6001BBF")]
			[Address(RVA = "0x3EC0E4C", Offset = "0x3EBCE4C", VA = "0x3EC0E4C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001BC0")]
		[Address(RVA = "0x3EC0FD0", Offset = "0x3EBCFD0", VA = "0x3EC0FD0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__40))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001BC1")]
		[Address(RVA = "0x3EC105C", Offset = "0x3EBD05C", VA = "0x3EC105C")]
		public void ExpUpGradeRbi(bool isGetSuccess)
		{
		}

		[Token(Token = "0x6001BC2")]
		[Address(RVA = "0x3EC1228", Offset = "0x3EBD228", VA = "0x3EC1228")]
		public void DanUpGradeRbi()
		{
		}

		[Token(Token = "0x6001BC3")]
		[Address(RVA = "0x3EC13D0", Offset = "0x3EBD3D0", VA = "0x3EC13D0")]
		public void UnLockNewArenaRbi()
		{
		}

		[Token(Token = "0x6001BC4")]
		[Address(RVA = "0x3EC1578", Offset = "0x3EBD578", VA = "0x3EC1578")]
		public void MainTowerUpgradeAttackRbi()
		{
		}

		[Token(Token = "0x6001BC5")]
		[Address(RVA = "0x3EC1720", Offset = "0x3EBD720", VA = "0x3EC1720")]
		public void MainTowerUpgradeHpRbi()
		{
		}

		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0x3EC18C8", Offset = "0x3EBD8C8", VA = "0x3EC18C8")]
		public void MainTowerUpgradeCdRbi()
		{
		}

		[Token(Token = "0x6001BC7")]
		[Address(RVA = "0x3EC1A70", Offset = "0x3EBDA70", VA = "0x3EC1A70")]
		public void ArenaUnLockRbi()
		{
		}

		[Token(Token = "0x6001BC8")]
		[Address(RVA = "0x3EC1A74", Offset = "0x3EBDA74", VA = "0x3EC1A74")]
		public void UpgradeCardRbi(string cardID)
		{
		}

		[Token(Token = "0x6001BC9")]
		[Address(RVA = "0x3EC1A78", Offset = "0x3EBDA78", VA = "0x3EC1A78")]
		public void GetNewCardRbi(string cardID)
		{
		}

		[Token(Token = "0x6001BCA")]
		[Address(RVA = "0x3EC1D10", Offset = "0x3EBDD10", VA = "0x3EC1D10")]
		public void BattleEndRbi(bool isVictory)
		{
		}

		[Token(Token = "0x6001BCB")]
		[Address(RVA = "0x3EC2228", Offset = "0x3EBE228", VA = "0x3EC2228")]
		public void ChangeNameRbi()
		{
		}

		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x3EC22F8", Offset = "0x3EBE2F8", VA = "0x3EC22F8")]
		public void ItemTransaction(string resId, bool earn, CurrencyTransactionSceneType type, int changeNum, int newCount, bool isIap = false, CurrencyType currencyUsedType = CurrencyType.gems)
		{
		}

		[Token(Token = "0x6001BCD")]
		[Address(RVA = "0x3EC25A4", Offset = "0x3EBE5A4", VA = "0x3EC25A4")]
		public void ChainStartEvent()
		{
		}

		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x3EC25A8", Offset = "0x3EBE5A8", VA = "0x3EC25A8")]
		public void ChainEndEvent()
		{
		}

		[Token(Token = "0x6001BCF")]
		[Address(RVA = "0x3EC25AC", Offset = "0x3EBE5AC", VA = "0x3EC25AC")]
		public void ShopOpenedEvent()
		{
		}

		[Token(Token = "0x6001BD0")]
		[Address(RVA = "0x3EC25B0", Offset = "0x3EBE5B0", VA = "0x3EC25B0")]
		public void UnitUpgradeEvent()
		{
		}

		[Token(Token = "0x6001BD1")]
		[Address(RVA = "0x3EC25B4", Offset = "0x3EBE5B4", VA = "0x3EC25B4")]
		public void UnlockedUnitEvent()
		{
		}

		[Token(Token = "0x6001BD2")]
		[Address(RVA = "0x3EC25B8", Offset = "0x3EBE5B8", VA = "0x3EC25B8")]
		public void CardCollection()
		{
		}

		[Token(Token = "0x6001BD3")]
		[Address(RVA = "0x3EC25BC", Offset = "0x3EBE5BC", VA = "0x3EC25BC")]
		public void AppOpenEvent()
		{
		}

		[Token(Token = "0x6001BD4")]
		[Address(RVA = "0x3EC25C0", Offset = "0x3EBE5C0", VA = "0x3EC25C0")]
		private void EnsureCardBattleStatisticsInitialized()
		{
		}

		[Token(Token = "0x6001BD5")]
		[Address(RVA = "0x3EC27EC", Offset = "0x3EBE7EC", VA = "0x3EC27EC")]
		private string BuildAppOpenCollectionJson()
		{
			return null;
		}

		[Token(Token = "0x6001BD6")]
		[Address(RVA = "0x3EC2C84", Offset = "0x3EBEC84", VA = "0x3EC2C84")]
		private void UpdateCardBattleStatistics(bool levelComplete, GameType gametype)
		{
		}

		[Token(Token = "0x6001BD7")]
		[Address(RVA = "0x3EC3088", Offset = "0x3EBF088", VA = "0x3EC3088")]
		private static string GetReportModeNameForGameType(GameType gametype)
		{
			return null;
		}

		[Token(Token = "0x6001BD8")]
		[Address(RVA = "0x3EC3108", Offset = "0x3EBF108", VA = "0x3EC3108")]
		private void GetBattleCardReportData(out string group, out string fetter, out int cardlevelcount)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ReportEventsManager.GetBattleCardReportData RVA=0x3EC3108 Token=0x6001BD8");
}

		[Token(Token = "0x6001BD9")]
		[Address(RVA = "0x3EC371C", Offset = "0x3EBF71C", VA = "0x3EC371C")]
		public void OnGameStart(GameType gametype)
		{
		}

		[Token(Token = "0x6001BDA")]
		[Address(RVA = "0x3EC3C60", Offset = "0x3EBFC60", VA = "0x3EC3C60")]
		public void OnGameFinish(bool levelComplete, int score, GameType gametype)
		{
		}

		[Token(Token = "0x6001BDB")]
		[Address(RVA = "0x3EC4954", Offset = "0x3EC0954", VA = "0x3EC4954")]
		public void Report_Develop(string name, int level1, string develop_param1 = "", string develop_param2 = "", string develop_param3 = "")
		{
		}

		[Token(Token = "0x6001BDC")]
		[Address(RVA = "0x3EC4B88", Offset = "0x3EC0B88", VA = "0x3EC4B88")]
		public void LogFK(string str)
		{
		}

		[Token(Token = "0x6001BDD")]
		[Address(RVA = "0x3EC4BE0", Offset = "0x3EC0BE0", VA = "0x3EC4BE0")]
		public void ReportResNumError(int resID, int geted, int used, int left)
		{
		}

		[Token(Token = "0x6001BDE")]
		[Address(RVA = "0x3EC4BE4", Offset = "0x3EC0BE4", VA = "0x3EC4BE4")]
		public void ReportGemStartCheckNumTooBig(int NowGem)
		{
		}

		[Token(Token = "0x6001BDF")]
		[Address(RVA = "0x3EC4CD0", Offset = "0x3EC0CD0", VA = "0x3EC4CD0")]
		public void ReportGemChangeTooBig(int lastDayGem, int NowGem)
		{
		}

		[Token(Token = "0x6001BE0")]
		[Address(RVA = "0x3EC485C", Offset = "0x3EC085C", VA = "0x3EC485C")]
		public void ReportBattleFinishTimeError(long finishTime)
		{
		}

		[Token(Token = "0x6001BE1")]
		[Address(RVA = "0x3EC45D4", Offset = "0x3EC05D4", VA = "0x3EC45D4")]
		public void ReportBattleCoinError(int startcoin, int get, int used, int left)
		{
		}

		[Token(Token = "0x6001BE2")]
		[Address(RVA = "0x3EC1224", Offset = "0x3EBD224", VA = "0x3EC1224")]
		private void DesignEvent(string eventName, params object[] objects)
		{
		}

		[Token(Token = "0x6001BE3")]
		[Address(RVA = "0x3EC4E60", Offset = "0x3EC0E60", VA = "0x3EC4E60")]
		public void TrackOfferShown(string productId, string placement)
		{
		}

		[Token(Token = "0x6001BE4")]
		[Address(RVA = "0x3EC4E64", Offset = "0x3EC0E64", VA = "0x3EC4E64")]
		public ReportEventsManager()
		{
		}
	}
}
