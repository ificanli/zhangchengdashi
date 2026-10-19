using System;
using System.Runtime.CompilerServices;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20005F2")]
	public class WorldCupActivityState
	{
		[Token(Token = "0x40031D1")]
		[FieldOffset(Offset = "0x13")]
		private bool _hasSyncedActivityData;

		[Token(Token = "0x40031D2")]
		[FieldOffset(Offset = "0x14")]
		private bool _syncedGmTestMode;

		[Token(Token = "0x40031D3")]
		[FieldOffset(Offset = "0x15")]
		private bool _syncedGmForceOpenActivity;

		[Token(Token = "0x40031D4")]
		[FieldOffset(Offset = "0x18")]
		private DateTime _nextActivityDataSyncTime;

		[Token(Token = "0x170001AD")]
		internal bool GmTestMode
		{
			[Token(Token = "0x6001F8E")]
			[Address(RVA = "0x3F0899C", Offset = "0x3F0499C", VA = "0x3F0899C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6001F8F")]
			[Address(RVA = "0x3F089A4", Offset = "0x3F049A4", VA = "0x3F089A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001AE")]
		internal bool GmForceOpenActivity
		{
			[Token(Token = "0x6001F90")]
			[Address(RVA = "0x3F089B0", Offset = "0x3F049B0", VA = "0x3F089B0")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6001F91")]
			[Address(RVA = "0x3F089B8", Offset = "0x3F049B8", VA = "0x3F089B8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001AF")]
		internal bool GmSaveCleared
		{
			[Token(Token = "0x6001F92")]
			[Address(RVA = "0x3F089C4", Offset = "0x3F049C4", VA = "0x3F089C4")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6001F93")]
			[Address(RVA = "0x3F089CC", Offset = "0x3F049CC", VA = "0x3F089CC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001B0")]
		private DbtSaveDataManager_PlayerWorldCupActivityData SaveManager
		{
			[Token(Token = "0x6001F94")]
			[Address(RVA = "0x3F089D8", Offset = "0x3F049D8", VA = "0x3F089D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001F95")]
		[Address(RVA = "0x3F0659C", Offset = "0x3F0259C", VA = "0x3F0659C")]
		public PlayerWorldCupActivityData GetData()
		{
			return null;
		}

		[Token(Token = "0x6001F96")]
		[Address(RVA = "0x3F06FFC", Offset = "0x3F02FFC", VA = "0x3F06FFC")]
		public void SaveData()
		{
		}

		[Token(Token = "0x6001F97")]
		[Address(RVA = "0x3F05A48", Offset = "0x3F01A48", VA = "0x3F05A48")]
		public void EnsureData()
		{
		}

		[Token(Token = "0x6001F98")]
		[Address(RVA = "0x3F06630", Offset = "0x3F02630", VA = "0x3F06630")]
		public WorldCupActivityPhase GetCurrentPhase()
		{
			return default;
		}

		[Token(Token = "0x6001F99")]
		[Address(RVA = "0x3F066CC", Offset = "0x3F026CC", VA = "0x3F066CC")]
		public bool IsPlayPhaseOpen()
		{
			return default;
		}

		[Token(Token = "0x6001F9A")]
		[Address(RVA = "0x3F0678C", Offset = "0x3F0278C", VA = "0x3F0678C")]
		public bool IsShopOpen()
		{
			return default;
		}

		[Token(Token = "0x6001F9B")]
		[Address(RVA = "0x3F067CC", Offset = "0x3F027CC", VA = "0x3F067CC")]
		internal bool CanOperatePlayFeature()
		{
			return default;
		}

		[Token(Token = "0x6001F9C")]
		[Address(RVA = "0x3F064E8", Offset = "0x3F024E8", VA = "0x3F064E8")]
		internal bool CanOperateShopFeature()
		{
			return default;
		}

		[Token(Token = "0x6001F9D")]
		[Address(RVA = "0x3F06844", Offset = "0x3F02844", VA = "0x3F06844")]
		public bool IsActivityActive()
		{
			return default;
		}

		[Token(Token = "0x6001F9E")]
		[Address(RVA = "0x3F06924", Offset = "0x3F02924", VA = "0x3F06924")]
		public bool ShouldShowEntryButton()
		{
			return default;
		}

		[Token(Token = "0x6001F9F")]
		[Address(RVA = "0x3F08A20", Offset = "0x3F04A20", VA = "0x3F08A20")]
		public WorldCupActivityWindow GetCurrentActivityWindow()
		{
			return default;
		}

		[Token(Token = "0x6001FA0")]
		[Address(RVA = "0x3F06990", Offset = "0x3F02990", VA = "0x3F06990")]
		public string GetCountdownDisplayText()
		{
			return null;
		}

		[Token(Token = "0x6001FA1")]
		[Address(RVA = "0x3F06ACC", Offset = "0x3F02ACC", VA = "0x3F06ACC")]
		public string GetActivityEntryCountdownStr()
		{
			return null;
		}

		[Token(Token = "0x6001FA2")]
		[Address(RVA = "0x3F06B9C", Offset = "0x3F02B9C", VA = "0x3F06B9C")]
		public bool TryShowProgressUnlockTip()
		{
			return default;
		}

		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0x3F06BF0", Offset = "0x3F02BF0", VA = "0x3F06BF0")]
		public bool TryConsumeFootball(int count)
		{
			return default;
		}

		[Token(Token = "0x6001FA4")]
		[Address(RVA = "0x3F06CE8", Offset = "0x3F02CE8", VA = "0x3F06CE8")]
		public void AddFootball(int count)
		{
		}

		[Token(Token = "0x6001FA5")]
		[Address(RVA = "0x3F06DFC", Offset = "0x3F02DFC", VA = "0x3F06DFC")]
		public void AddActivityScore(int count)
		{
		}

		[Token(Token = "0x6001FA6")]
		[Address(RVA = "0x3F093E4", Offset = "0x3F053E4", VA = "0x3F093E4")]
		public bool TryConsumeActivityScore(int count)
		{
			return default;
		}

		[Token(Token = "0x6001FA7")]
		[Address(RVA = "0x3F09434", Offset = "0x3F05434", VA = "0x3F09434")]
		public int GetActivityScore()
		{
			return default;
		}

		[Token(Token = "0x6001FA8")]
		[Address(RVA = "0x3F0944C", Offset = "0x3F0544C", VA = "0x3F0944C")]
		public PlayerWorldCupActivityData GetOrCreateSaveData()
		{
			return null;
		}

		[Token(Token = "0x6001FA9")]
		[Address(RVA = "0x3F09514", Offset = "0x3F05514", VA = "0x3F09514")]
		internal bool IsDailyRefreshAllowed()
		{
			return default;
		}

		[Token(Token = "0x6001FAA")]
		[Address(RVA = "0x3F09450", Offset = "0x3F05450", VA = "0x3F09450")]
		private PlayerWorldCupActivityData EnsureSaveData()
		{
			return null;
		}

		[Token(Token = "0x6001FAB")]
		[Address(RVA = "0x3F095E0", Offset = "0x3F055E0", VA = "0x3F095E0")]
		private PlayerWorldCupActivityData LoadOrCreateSaveData()
		{
			return null;
		}

		[Token(Token = "0x6001FAC")]
		[Address(RVA = "0x3F08D74", Offset = "0x3F04D74", VA = "0x3F08D74")]
		private bool IsGmForcePlayOpen()
		{
			return default;
		}

		[Token(Token = "0x6001FAD")]
		[Address(RVA = "0x3F09080", Offset = "0x3F05080", VA = "0x3F09080")]
		private bool TryFormatGmForceOpenCountdown(DateTime now, string prefix, out string text)
		{
			return default;
		}

		[Token(Token = "0x6001FAE")]
		[Address(RVA = "0x3F08A9C", Offset = "0x3F04A9C", VA = "0x3F08A9C")]
		private bool ShouldSyncActivityData(DateTime now)
		{
			return default;
		}

		[Token(Token = "0x6001FAF")]
		[Address(RVA = "0x3F08D28", Offset = "0x3F04D28", VA = "0x3F08D28")]
		private void CacheActivityDataSync(DateTime now, WorldCupActivityWindow window)
		{
		}

		[Token(Token = "0x6001FB0")]
		[Address(RVA = "0x3F09674", Offset = "0x3F05674", VA = "0x3F09674")]
		private static DateTime ResolveNextActivityDataSyncTime(DateTime now, WorldCupActivityWindow window)
		{
			return default;
		}

		[Token(Token = "0x6001FB1")]
		[Address(RVA = "0x3F08B74", Offset = "0x3F04B74", VA = "0x3F08B74")]
		private void SyncActivityDataWithOnlineParams(DateTime now, WorldCupActivityWindow window)
		{
		}

		[Token(Token = "0x6001FB2")]
		[Address(RVA = "0x3F05888", Offset = "0x3F01888", VA = "0x3F05888")]
		public WorldCupActivityState()
		{
		}
	}
}
