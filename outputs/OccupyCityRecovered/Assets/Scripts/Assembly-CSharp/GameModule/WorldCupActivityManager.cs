using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;
using ljzs_lt;

namespace GameModule
{
	[Token(Token = "0x20005EE")]
	public class WorldCupActivityManager : ManagerBase<WorldCupActivityManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005EF")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x40031C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40031C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40031C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupActivityManager _003C_003E4__this;

			[Token(Token = "0x40031C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001F84")]
			[Address(RVA = "0x3F079B4", Offset = "0x3F039B4", VA = "0x3F079B4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001F85")]
			[Address(RVA = "0x3F080F8", Offset = "0x3F040F8", VA = "0x3F080F8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20005F0")]
		[CompilerGenerated]
		private sealed class _003CShowActivityPanelCoroutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40031C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40031C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40031C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WorldCupActivityManager _003C_003E4__this;

			[Token(Token = "0x40031C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int openTarget;

			[Token(Token = "0x40031CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string enterWay;

			[Token(Token = "0x170001AB")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6001F89")]
				[Address(RVA = "0x3F0846C", Offset = "0x3F0446C", VA = "0x3F0846C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001AC")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6001F8B")]
				[Address(RVA = "0x3F084AC", Offset = "0x3F044AC", VA = "0x3F084AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001F86")]
			[Address(RVA = "0x3F06564", Offset = "0x3F02564", VA = "0x3F06564")]
			[DebuggerHidden]
			public _003CShowActivityPanelCoroutine_003Ed__31(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6001F87")]
			[Address(RVA = "0x3F08104", Offset = "0x3F04104", VA = "0x3F08104", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6001F88")]
			[Address(RVA = "0x3F08108", Offset = "0x3F04108", VA = "0x3F08108", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001F89")]
			[Address(RVA = "0x3F0846C", Offset = "0x3F0446C", VA = "0x3F0846C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001F8A")]
			[Address(RVA = "0x3F08474", Offset = "0x3F04474", VA = "0x3F08474", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6001F8B")]
			[Address(RVA = "0x3F084AC", Offset = "0x3F044AC", VA = "0x3F084AC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005F1")]
		[CompilerGenerated]
		private struct _003CShowFaceSlapPanelAsync_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x40031CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40031CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40031CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001F8C")]
			[Address(RVA = "0x3F084B4", Offset = "0x3F044B4", VA = "0x3F084B4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001F8D")]
			[Address(RVA = "0x3F08990", Offset = "0x3F04990", VA = "0x3F08990", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40031BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WorldCupActivityState _state;

		[Token(Token = "0x40031BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WorldCupDailySideService _daily;

		[Token(Token = "0x40031BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WorldCupPointShopService _pointShop;

		[Token(Token = "0x40031BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WorldCupActivityGm _gm;

		[Token(Token = "0x40031BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WorldCupShootService _shoot;

		[Token(Token = "0x40031BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private WorldCupFaceSlapHelper _faceSlapHelper;

		[Token(Token = "0x40031C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _grantFootballSourceOverride;

		[Token(Token = "0x40031C1")]
		public const int RequiredUnlockArenaLevel = 3;

		[Token(Token = "0x170001A6")]
		public WorldCupActivityState State
		{
			[Token(Token = "0x6001F43")]
			[Address(RVA = "0x3F05470", Offset = "0x3F01470", VA = "0x3F05470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A7")]
		public WorldCupActivityGm Gm
		{
			[Token(Token = "0x6001F44")]
			[Address(RVA = "0x3F05478", Offset = "0x3F01478", VA = "0x3F05478")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A8")]
		public WorldCupDailySideService DailySide
		{
			[Token(Token = "0x6001F45")]
			[Address(RVA = "0x3F05480", Offset = "0x3F01480", VA = "0x3F05480")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A9")]
		public WorldCupPointShopService PointShop
		{
			[Token(Token = "0x6001F46")]
			[Address(RVA = "0x3F05488", Offset = "0x3F01488", VA = "0x3F05488")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AA")]
		internal WorldCupShootService ShootService
		{
			[Token(Token = "0x6001F7C")]
			[Address(RVA = "0x3F078B8", Offset = "0x3F038B8", VA = "0x3F078B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001F47")]
		[Address(RVA = "0x3F05490", Offset = "0x3F01490", VA = "0x3F05490")]
		private void Awake()
		{
		}

		[Token(Token = "0x6001F48")]
		[Address(RVA = "0x3F05B68", Offset = "0x3F01B68", VA = "0x3F05B68", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__17))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001F49")]
		[Address(RVA = "0x3F05BF4", Offset = "0x3F01BF4", VA = "0x3F05BF4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6001F4A")]
		[Address(RVA = "0x3F05EFC", Offset = "0x3F01EFC", VA = "0x3F05EFC")]
		private void OnGameManagerInitComplete()
		{
		}

		[Token(Token = "0x6001F4B")]
		[Address(RVA = "0x3F060CC", Offset = "0x3F020CC", VA = "0x3F060CC")]
		private void OnArenaUnlockChanged(object unused)
		{
		}

		[Token(Token = "0x6001F4C")]
		[Address(RVA = "0x3F060DC", Offset = "0x3F020DC", VA = "0x3F060DC")]
		private void OnDailyRefreshAtServerMidnight()
		{
		}

		[Token(Token = "0x6001F4D")]
		[Address(RVA = "0x3F061A4", Offset = "0x3F021A4", VA = "0x3F061A4")]
		private void RefreshAll()
		{
		}

		[Token(Token = "0x6001F4E")]
		[Address(RVA = "0x3F060D4", Offset = "0x3F020D4", VA = "0x3F060D4")]
		private void RefreshRuntimeState()
		{
		}

		[Token(Token = "0x6001F4F")]
		[Address(RVA = "0x3F062A4", Offset = "0x3F022A4", VA = "0x3F062A4")]
		public void RefreshActivityStateAfterExpired()
		{
		}

		[Token(Token = "0x6001F50")]
		[Address(RVA = "0x3F062C0", Offset = "0x3F022C0", VA = "0x3F062C0")]
		public void OnEntryButtonClicked()
		{
		}

		[Token(Token = "0x6001F51")]
		[Address(RVA = "0x3F063B0", Offset = "0x3F023B0", VA = "0x3F063B0")]
		[AsyncStateMachine(typeof(_003CShowFaceSlapPanelAsync_003Ed__26))]
		private UniTask ShowFaceSlapPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x6001F52")]
		[Address(RVA = "0x3F0638C", Offset = "0x3F0238C", VA = "0x3F0638C")]
		public void ShowActivityPanel(string enterWay = "button-主页入口")
		{
		}

		[Token(Token = "0x6001F53")]
		[Address(RVA = "0x3F064AC", Offset = "0x3F024AC", VA = "0x3F064AC")]
		public bool CanEnterPointShop()
		{
			return default;
		}

		[Token(Token = "0x6001F54")]
		[Address(RVA = "0x3F06514", Offset = "0x3F02514", VA = "0x3F06514")]
		public void ShowPointShopFromMainPanel()
		{
		}

		[Token(Token = "0x6001F55")]
		[Address(RVA = "0x3F0653C", Offset = "0x3F0253C", VA = "0x3F0653C")]
		public void ShowDailyGiftFromMainPanel()
		{
		}

		[Token(Token = "0x6001F56")]
		[Address(RVA = "0x3F06434", Offset = "0x3F02434", VA = "0x3F06434")]
		[IteratorStateMachine(typeof(_003CShowActivityPanelCoroutine_003Ed__31))]
		private IEnumerator ShowActivityPanelCoroutine(string enterWay, int openTarget)
		{
			return null;
		}

		[Token(Token = "0x6001F57")]
		[Address(RVA = "0x3F0658C", Offset = "0x3F0258C", VA = "0x3F0658C")]
		public PlayerWorldCupActivityData GetData()
		{
			return null;
		}

		[Token(Token = "0x6001F58")]
		[Address(RVA = "0x3F06620", Offset = "0x3F02620", VA = "0x3F06620")]
		public WorldCupActivityPhase GetCurrentPhase()
		{
			return default;
		}

		[Token(Token = "0x6001F59")]
		[Address(RVA = "0x3F06178", Offset = "0x3F02178", VA = "0x3F06178")]
		public bool IsPlayPhaseOpen()
		{
			return default;
		}

		[Token(Token = "0x6001F5A")]
		[Address(RVA = "0x3F0677C", Offset = "0x3F0277C", VA = "0x3F0677C")]
		public bool IsShopOpen()
		{
			return default;
		}

		[Token(Token = "0x6001F5B")]
		[Address(RVA = "0x3F06790", Offset = "0x3F02790", VA = "0x3F06790")]
		public bool CanOperatePlayFeature()
		{
			return default;
		}

		[Token(Token = "0x6001F5C")]
		[Address(RVA = "0x3F067F8", Offset = "0x3F027F8", VA = "0x3F067F8")]
		public bool CanOperateShopFeature()
		{
			return default;
		}

		[Token(Token = "0x6001F5D")]
		[Address(RVA = "0x3F06834", Offset = "0x3F02834", VA = "0x3F06834")]
		public bool IsActivityActive()
		{
			return default;
		}

		[Token(Token = "0x6001F5E")]
		[Address(RVA = "0x3F06908", Offset = "0x3F02908", VA = "0x3F06908")]
		public bool ShouldShowEntryButton()
		{
			return default;
		}

		[Token(Token = "0x6001F5F")]
		[Address(RVA = "0x3F06938", Offset = "0x3F02938", VA = "0x3F06938")]
		public string GetCountdownDisplayText()
		{
			return null;
		}

		[Token(Token = "0x6001F60")]
		[Address(RVA = "0x3F06A74", Offset = "0x3F02A74", VA = "0x3F06A74")]
		public string GetActivityEntryCountdownStr()
		{
			return null;
		}

		[Token(Token = "0x6001F61")]
		[Address(RVA = "0x3F06378", Offset = "0x3F02378", VA = "0x3F06378")]
		public bool TryShowProgressUnlockTip()
		{
			return default;
		}

		[Token(Token = "0x6001F62")]
		[Address(RVA = "0x3F06BA0", Offset = "0x3F02BA0", VA = "0x3F06BA0")]
		public bool TryConsumeFootball(int count)
		{
			return default;
		}

		[Token(Token = "0x6001F63")]
		[Address(RVA = "0x3F06C64", Offset = "0x3F02C64", VA = "0x3F06C64")]
		public void SetGrantFootballSourceOverride(int source)
		{
		}

		[Token(Token = "0x6001F64")]
		[Address(RVA = "0x3F06C6C", Offset = "0x3F02C6C", VA = "0x3F06C6C")]
		public void ClearGrantFootballSourceOverride()
		{
		}

		[Token(Token = "0x6001F65")]
		[Address(RVA = "0x3F06C74", Offset = "0x3F02C74", VA = "0x3F06C74")]
		public void GrantFootball(int grantCount, int defaultSource = 99)
		{
		}

		[Token(Token = "0x6001F66")]
		[Address(RVA = "0x3F06DD4", Offset = "0x3F02DD4", VA = "0x3F06DD4")]
		public void AddFootball(int count, string _)
		{
		}

		[Token(Token = "0x6001F67")]
		[Address(RVA = "0x3F06DDC", Offset = "0x3F02DDC", VA = "0x3F06DDC")]
		public void AddActivityScore(int count, string _)
		{
		}

		[Token(Token = "0x6001F68")]
		[Address(RVA = "0x3F06E44", Offset = "0x3F02E44", VA = "0x3F06E44")]
		public void TryEnqueueLoginFaceSlapPopup(int packIndex)
		{
		}

		[Token(Token = "0x6001F69")]
		[Address(RVA = "0x3F06F0C", Offset = "0x3F02F0C", VA = "0x3F06F0C")]
		public void PersistLoginFaceSlapDismissIfNeeded(bool dontShowToday)
		{
		}

		[Token(Token = "0x6001F6A")]
		[Address(RVA = "0x3F07074", Offset = "0x3F03074", VA = "0x3F07074")]
		public WorldCupDailyTaskRecord GetDailyTaskRecord(int configId)
		{
			return null;
		}

		[Token(Token = "0x6001F6B")]
		[Address(RVA = "0x3F070C0", Offset = "0x3F030C0", VA = "0x3F070C0")]
		public IReadOnlyList<WorldCupDailyTaskRecord> GetDailyTaskRecords()
		{
			return null;
		}

		[Token(Token = "0x6001F6C")]
		[Address(RVA = "0x3F070F8", Offset = "0x3F030F8", VA = "0x3F070F8")]
		public string GetDailyRefreshCountdownStr()
		{
			return null;
		}

		[Token(Token = "0x6001F6D")]
		[Address(RVA = "0x3F071B0", Offset = "0x3F031B0", VA = "0x3F071B0")]
		public void EnsureDailyRefreshData()
		{
		}

		[Token(Token = "0x6001F6E")]
		[Address(RVA = "0x3F071F0", Offset = "0x3F031F0", VA = "0x3F071F0")]
		public bool HasClaimableDailyTaskReward()
		{
			return default;
		}

		[Token(Token = "0x6001F6F")]
		[Address(RVA = "0x3F07228", Offset = "0x3F03228", VA = "0x3F07228")]
		public int GetPackDailyBuyCount(int packId)
		{
			return default;
		}

		[Token(Token = "0x6001F70")]
		[Address(RVA = "0x3F07260", Offset = "0x3F03260", VA = "0x3F07260")]
		public bool HasClaimableDailyGift()
		{
			return default;
		}

		[Token(Token = "0x6001F71")]
		[Address(RVA = "0x3F07298", Offset = "0x3F03298", VA = "0x3F07298")]
		public bool HasDailySideEntryRedDot()
		{
			return default;
		}

		[Token(Token = "0x6001F72")]
		[Address(RVA = "0x3F07320", Offset = "0x3F03320", VA = "0x3F07320")]
		public string GetDailyGiftPlacement()
		{
			return null;
		}

		[Token(Token = "0x6001F73")]
		[Address(RVA = "0x3F073AC", Offset = "0x3F033AC", VA = "0x3F073AC")]
		public int GetPackRemainBuyCount(WorldCupdailyPriceConfig config)
		{
			return default;
		}

		[Token(Token = "0x6001F74")]
		[Address(RVA = "0x3F07400", Offset = "0x3F03400", VA = "0x3F07400")]
		public bool TryClaimFreeDailyGift(int configId, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupActivityManager.TryClaimFreeDailyGift RVA=0x3F07400 Token=0x6001F74");
}

		[Token(Token = "0x6001F75")]
		[Address(RVA = "0x3F07438", Offset = "0x3F03438", VA = "0x3F07438")]
		public bool TryGrantPurchasedDailyGift(int configId, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupActivityManager.TryGrantPurchasedDailyGift RVA=0x3F07438 Token=0x6001F75");
}

		[Token(Token = "0x6001F76")]
		[Address(RVA = "0x3F07470", Offset = "0x3F03470", VA = "0x3F07470")]
		public bool TryClaimDailyTaskReward(int configId, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupActivityManager.TryClaimDailyTaskReward RVA=0x3F07470 Token=0x6001F76");
}

		[Token(Token = "0x6001F77")]
		[Address(RVA = "0x3F074A8", Offset = "0x3F034A8", VA = "0x3F074A8")]
		public int GetPointShopBuyCount(int configId)
		{
			return default;
		}

		[Token(Token = "0x6001F78")]
		[Address(RVA = "0x3F074F4", Offset = "0x3F034F4", VA = "0x3F074F4")]
		public int GetPointShopRemainBuyCount(PointShopConfig config)
		{
			return default;
		}

		[Token(Token = "0x6001F79")]
		[Address(RVA = "0x3F07560", Offset = "0x3F03560", VA = "0x3F07560")]
		public bool IsPointShopSoldOut(PointShopConfig config)
		{
			return default;
		}

		[Token(Token = "0x6001F7A")]
		[Address(RVA = "0x3F075B4", Offset = "0x3F035B4", VA = "0x3F075B4")]
		public bool TryPurchasePointShopItem(int configId, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupActivityManager.TryPurchasePointShopItem RVA=0x3F075B4 Token=0x6001F7A");
}

		[Token(Token = "0x6001F7B")]
		[Address(RVA = "0x3F07788", Offset = "0x3F03788", VA = "0x3F07788")]
		public bool TryValidatePointShopPurchase(int configId, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupActivityManager.TryValidatePointShopPurchase RVA=0x3F07788 Token=0x6001F7B");
}

		[Token(Token = "0x6001F7D")]
		[Address(RVA = "0x3F078C0", Offset = "0x3F038C0", VA = "0x3F078C0")]
		public WorldCupActivityManager()
		{
		}
	}
}
