using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using L_Tools;

[Token(Token = "0x2000058")]
public class CheatControl : Singleton<CheatControl>
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct _003CLineArenaUnLockNext_003Ed__104 : IAsyncStateMachine
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isAddTrophyUnLock;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<UserArenaData> _003CarenaDataList_003E5__2;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _003Cindex_003E5__3;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _003CnoArenaComplete_003E5__4;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UniTask<UIFramework.UIPanel>.Awaiter _003C_003Eu__1;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UniTask.Awaiter _003C_003Eu__2;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x3D19344", Offset = "0x3D15344", VA = "0x3D19344", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x3D1A0FC", Offset = "0x3D160FC", VA = "0x3D1A0FC", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct _003COpenMysteryAdventureDiscountShopAsync_003Ed__77 : IAsyncStateMachine
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UniTask<string>.Awaiter _003C_003Eu__1;

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x3D1A108", Offset = "0x3D16108", VA = "0x3D1A108", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x3D1A4C4", Offset = "0x3D164C4", VA = "0x3D1A4C4", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct _003COpenMysteryAdventurePanelAsync_003Ed__62 : IAsyncStateMachine
	{
		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UniTask.Awaiter _003C_003Eu__1;

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x3D1A4D0", Offset = "0x3D164D0", VA = "0x3D1A4D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x3D1A95C", Offset = "0x3D1695C", VA = "0x3D1A95C", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct _003COpenMysteryAdventureRuinsEventAsync_003Ed__80 : IAsyncStateMachine
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int eventId;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UniTask<string>.Awaiter _003C_003Eu__1;

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x3D1A968", Offset = "0x3D16968", VA = "0x3D1A968", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x3D1AD28", Offset = "0x3D16D28", VA = "0x3D1AD28", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct _003COpenWorldCupActivityPanelAsync_003Ed__46 : IAsyncStateMachine
	{
		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float _003Cdeadline_003E5__2;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x3D1AD34", Offset = "0x3D16D34", VA = "0x3D1AD34", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x3D1B124", Offset = "0x3D17124", VA = "0x3D1B124", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct _003COpenWorldCupFaceSlapPanelAsync_003Ed__60 : IAsyncStateMachine
	{
		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UniTask.Awaiter _003C_003Eu__1;

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x3D1B130", Offset = "0x3D17130", VA = "0x3D1B130", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x3D1B60C", Offset = "0x3D1760C", VA = "0x3D1B60C", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool ShowPerfPanel;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool DisableHitEffect;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static bool DisableDeathEffect;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
	public static bool DisableDamageText;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static bool DisableHpBar;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
	public static bool DisableBattleSFX;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
	public static bool DisableBattleUI;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
	public static bool DisableBulletTrail;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static bool DisableSpawnEffect;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
	public static bool DisableCharacterOutline;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static float SpawnSpeedMultiplier;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static float DamageMultiplier;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static float TimeScaleMultiplier;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public readonly List<string> BattleCustomCards;

	[Token(Token = "0x40001C4")]
	private const int DefaultBattleCoinCheatAmount = 1000;

	[Token(Token = "0x17000017")]
	public bool NoAD
	{
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x3D10558", Offset = "0x3D0C558", VA = "0x3D10558")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x3D10560", Offset = "0x3D0C560", VA = "0x3D10560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public bool NoPay
	{
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x3D1056C", Offset = "0x3D0C56C", VA = "0x3D1056C")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x3D10574", Offset = "0x3D0C574", VA = "0x3D10574")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public bool GmIgnoreCheckInDayLimit
	{
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x3D10580", Offset = "0x3D0C580", VA = "0x3D10580")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x3D10588", Offset = "0x3D0C588", VA = "0x3D10588")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public string BattleCustomPropId
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x3D10594", Offset = "0x3D0C594", VA = "0x3D10594")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x3D1059C", Offset = "0x3D0C59C", VA = "0x3D1059C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public string PlayerBarracksOverrideRoleId
	{
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x3D105A4", Offset = "0x3D0C5A4", VA = "0x3D105A4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x3D105AC", Offset = "0x3D0C5AC", VA = "0x3D105AC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public string PlayerBarracksOverrideCardId
	{
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x3D105B4", Offset = "0x3D0C5B4", VA = "0x3D105B4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x3D105BC", Offset = "0x3D0C5BC", VA = "0x3D105BC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x3D104EC", Offset = "0x3D0C4EC", VA = "0x3D104EC")]
	public static void ResetPerfStates()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x3D105C4", Offset = "0x3D0C5C4", VA = "0x3D105C4")]
	public void Init()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x3D12094", Offset = "0x3D0E094", VA = "0x3D12094")]
	public void CheatBattleWin()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x3D1215C", Offset = "0x3D0E15C", VA = "0x3D1215C")]
	public void ToggleMysteryAdventureGmForceOpen([Optional] bool? enabled)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x3D122C4", Offset = "0x3D0E2C4", VA = "0x3D122C4")]
	public void ToggleWorldCupGmForceOpen([Optional] bool? enabled)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x3D12440", Offset = "0x3D0E440", VA = "0x3D12440")]
	public void OpenWorldCupActivityPanel()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x3D124CC", Offset = "0x3D0E4CC", VA = "0x3D124CC")]
	public void OpenWorldCupPointShopPanel()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x3D12460", Offset = "0x3D0E460", VA = "0x3D12460")]
	[AsyncStateMachine(typeof(_003COpenWorldCupActivityPanelAsync_003Ed__46))]
	private UniTaskVoid OpenWorldCupActivityPanelAsync()
	{
		return default;
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x3D125AC", Offset = "0x3D0E5AC", VA = "0x3D125AC")]
	public void AddWorldCupFootball(int amount = 10)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x3D12714", Offset = "0x3D0E714", VA = "0x3D12714")]
	public void AddWorldCupActivityScore(int amount = 100)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x3D1287C", Offset = "0x3D0E87C", VA = "0x3D1287C")]
	public void ResetWorldCupActivity()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x3D12980", Offset = "0x3D0E980", VA = "0x3D12980")]
	public void ClearWorldCupSave()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x3D12A84", Offset = "0x3D0EA84", VA = "0x3D12A84")]
	public void FillWorldCupFootball()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x3D12B8C", Offset = "0x3D0EB8C", VA = "0x3D12B8C")]
	public void SetWorldCupFixedGoalResult(int value)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x3D12CD8", Offset = "0x3D0ECD8", VA = "0x3D12CD8")]
	public void ClearWorldCupFixedGoalResult()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x3D12CE0", Offset = "0x3D0ECE0", VA = "0x3D12CE0")]
	public void ResetWorldCupDailyTasks()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x3D12DE4", Offset = "0x3D0EDE4", VA = "0x3D12DE4")]
	public void CompleteAllWorldCupDailyTasks()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x3D12EE8", Offset = "0x3D0EEE8", VA = "0x3D12EE8")]
	public void CompleteWorldCupDailyTask(int configId)
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x3D13050", Offset = "0x3D0F050", VA = "0x3D13050")]
	public void AddWorldCupDailyTaskProgress(int taskType, int delta = 1, int normalParam = 0)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x3D1317C", Offset = "0x3D0F17C", VA = "0x3D1317C")]
	public void ResetWorldCupDailyGift()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x3D13280", Offset = "0x3D0F280", VA = "0x3D13280")]
	public void OpenWorldCupFaceSlapPanel()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x3D132A0", Offset = "0x3D0F2A0", VA = "0x3D132A0")]
	[AsyncStateMachine(typeof(_003COpenWorldCupFaceSlapPanelAsync_003Ed__60))]
	private UniTaskVoid OpenWorldCupFaceSlapPanelAsync()
	{
		return default;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x3D1330C", Offset = "0x3D0F30C", VA = "0x3D1330C")]
	public void OpenMysteryAdventurePanel()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x3D1332C", Offset = "0x3D0F32C", VA = "0x3D1332C")]
	[AsyncStateMachine(typeof(_003COpenMysteryAdventurePanelAsync_003Ed__62))]
	private UniTaskVoid OpenMysteryAdventurePanelAsync()
	{
		return default;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x3D13398", Offset = "0x3D0F398", VA = "0x3D13398")]
	public void FillMysteryAdventureDice()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x3D1349C", Offset = "0x3D0F49C", VA = "0x3D1349C")]
	public void SetMysteryAdventureFixedDiceValue(int value)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x3D13600", Offset = "0x3D0F600", VA = "0x3D13600")]
	public void ClearMysteryAdventureFixedDiceValue()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x3D13700", Offset = "0x3D0F700", VA = "0x3D13700")]
	public void AddMysteryAdventureDice(int amount = 10)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x3D1388C", Offset = "0x3D0F88C", VA = "0x3D1388C")]
	public void ResetMysteryAdventureActivity()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x3D1398C", Offset = "0x3D0F98C", VA = "0x3D1398C")]
	public void ClearMysteryAdventureSave()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x3D13A8C", Offset = "0x3D0FA8C", VA = "0x3D13A8C")]
	public void ClearMysteryAdventureLapRewardProgress()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x3D13B8C", Offset = "0x3D0FB8C", VA = "0x3D13B8C")]
	public void GrantMysteryAdventureChestReward(bool deluxe)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x3D13D94", Offset = "0x3D0FD94", VA = "0x3D13D94")]
	public void GrantMysteryAdventureAltarReward()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x3D13DD8", Offset = "0x3D0FDD8", VA = "0x3D13DD8")]
	public void GrantMysteryAdventureBarracksReward()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x3D13E1C", Offset = "0x3D0FE1C", VA = "0x3D13E1C")]
	public void OpenMysteryAdventureDiscountShop()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x3D13EAC", Offset = "0x3D0FEAC", VA = "0x3D13EAC")]
	public void RerollMysteryAdventureDiscountShop()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x3D13FEC", Offset = "0x3D0FFEC", VA = "0x3D13FEC")]
	public void ClearMysteryAdventureDiscountShopPurchases()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x3D140EC", Offset = "0x3D100EC", VA = "0x3D140EC")]
	public void CloseMysteryAdventureDiscountShop()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x3D13E3C", Offset = "0x3D0FE3C", VA = "0x3D13E3C")]
	[AsyncStateMachine(typeof(_003COpenMysteryAdventureDiscountShopAsync_003Ed__77))]
	private UniTaskVoid OpenMysteryAdventureDiscountShopAsync()
	{
		return default;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x3D141EC", Offset = "0x3D101EC", VA = "0x3D141EC")]
	public void OpenMysteryAdventureRuinsEvent(int eventId = 0)
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x3D14284", Offset = "0x3D10284", VA = "0x3D14284")]
	public void CloseMysteryAdventureRuinsEvent()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x3D1420C", Offset = "0x3D1020C", VA = "0x3D1420C")]
	[AsyncStateMachine(typeof(_003COpenMysteryAdventureRuinsEventAsync_003Ed__80))]
	private UniTaskVoid OpenMysteryAdventureRuinsEventAsync(int eventId)
	{
		return default;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x3D14384", Offset = "0x3D10384", VA = "0x3D14384")]
	public void AddMysteryAdventureDiscountShopVisitCount(int count = 1)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x3D14510", Offset = "0x3D10510", VA = "0x3D14510")]
	public void ResetMysteryAdventureDailyTasks()
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x3D14610", Offset = "0x3D10610", VA = "0x3D14610")]
	public void AddMysteryAdventureDailyTaskProgress(int taskType, int delta = 1, int normalParam = 0)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x3D13C00", Offset = "0x3D0FC00", VA = "0x3D13C00")]
	private void GrantMysteryAdventureBuildReward(int buildId, string label)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x3D147A8", Offset = "0x3D107A8", VA = "0x3D147A8")]
	public void CheatBattleLose()
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x3D14870", Offset = "0x3D10870", VA = "0x3D14870")]
	public void CheatStartSubGamePVP(string str)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x3D14BF0", Offset = "0x3D10BF0", VA = "0x3D14BF0")]
	private static bool TryParseSubGameBuffCheatIds(string str, out List<int> buffIds, out string errorMessage)
	{
		return default;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x3D14F34", Offset = "0x3D10F34", VA = "0x3D14F34")]
	public void CheatAddBattleCoin(int count = 1000)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x3D14FFC", Offset = "0x3D10FFC", VA = "0x3D14FFC")]
	public void CheatChargeArtifact()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x3D15138", Offset = "0x3D11138", VA = "0x3D15138")]
	public void CheatSetArtifactData(string str)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x3D159D0", Offset = "0x3D119D0", VA = "0x3D159D0")]
	private static int GetExpectedArtifactTraitSlotCount(int level)
	{
		return default;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x3D15A8C", Offset = "0x3D11A8C", VA = "0x3D15A8C")]
	private static bool IsArtifactTraitSlotsMatched(UserPropData artifact, int expectedSlotCount)
	{
		return default;
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x3D156B4", Offset = "0x3D116B4", VA = "0x3D156B4")]
	private void CheatSyncArtifactTraitsForLevel(UserPropData artifact, int targetLevel)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x3D15478", Offset = "0x3D11478", VA = "0x3D15478")]
	private UserPropData CheatGetOrGrantPlayerArtifact(string propId)
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x3D15BF8", Offset = "0x3D11BF8", VA = "0x3D15BF8")]
	public void CheatKillAllEnemyRoles()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x3D15E70", Offset = "0x3D11E70", VA = "0x3D15E70")]
	public bool TryGetPlayerBarracksOverrideRole(bool isEnemy, out GlobalRoleInfo roleInfo, out GlobalHeroCardInfo cardInfo, out int cardLevel, out RareLevel rareLevel, out CardFettersType fettersType, out AtkWayType atkWayType)
	{
		return default;
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x3D160A8", Offset = "0x3D120A8", VA = "0x3D160A8")]
	private void SetPlayerBarracksOverrideRole(string input)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x3D162F0", Offset = "0x3D122F0", VA = "0x3D162F0")]
	private void ClearPlayerBarracksOverrideRole()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x3D168CC", Offset = "0x3D128CC", VA = "0x3D168CC")]
	private static void RefreshPlayerBarracksRoleOverrideInBattle()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x3D163B4", Offset = "0x3D123B4", VA = "0x3D163B4")]
	private bool TryResolveBarracksRole(string input, out GlobalRoleInfo roleInfo, out GlobalHeroCardInfo cardInfo)
	{
		return default;
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x3D16C00", Offset = "0x3D12C00", VA = "0x3D16C00")]
	private static GlobalArchitectureInfo FindBarracksArchitectureByCard(GlobalHeroCardInfo cardInfo)
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x3D16A74", Offset = "0x3D12A74", VA = "0x3D16A74")]
	private static GlobalArchitectureInfo FindBarracksArchitectureByRoleId(string roleId, [Optional] string cardId)
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x3D15D20", Offset = "0x3D11D20", VA = "0x3D15D20")]
	private static void KillAllRolesInBattleList(List<RoleBehaviour> roles)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x3D16D6C", Offset = "0x3D12D6C", VA = "0x3D16D6C")]
	[AsyncStateMachine(typeof(_003CLineArenaUnLockNext_003Ed__104))]
	private static void LineArenaUnLockNext(bool isAddTrophyUnLock = false)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x3D16E04", Offset = "0x3D12E04", VA = "0x3D16E04")]
	public CheatControl()
	{
	}
}
