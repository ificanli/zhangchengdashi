using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SDKModule;
using TMPro;
using UIFramework;
using UIModuleO;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000D4")]
public class SubGameChaosTrailsPanel : UIPanel
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct _003CShow_003Ed__31 : IAsyncStateMachine
	{
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SubGameChaosTrailsPanel _003C_003E4__this;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public object[] args;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UniTask.Awaiter _003C_003Eu__1;

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x3E43C6C", Offset = "0x3E3FC6C", VA = "0x3E43C6C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x3E4413C", Offset = "0x3E4013C", VA = "0x3E4413C", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Button tipsBtn;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private TextMeshProUGUI openTime;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject mainRoot;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private RectTransform buffLayout;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private SubGameChaosTrailsBuffItem itemTemplate;

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AdButtonExtend refreshBtn;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private TextMeshProUGUI refreshTimes;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Button diamondRefreshBtn;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private TextMeshProUGUI diamondRefreshTimesLimitText;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private TextMeshProUGUI diamondCostText;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Button enterBtn;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private TextMeshProUGUI leftRewardTimes;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private GameObject openTimerObj;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private TextMeshProUGUI openTimer;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private ChestSlotsView chestSlotsView;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Button exitBtn;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private GameObject tipsPanel;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Button tipsMaskBtn;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Button tipsCloseBtn;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private TextMeshProUGUI tips1Text;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly List<SubGameChaosTrailsBuffItem> _buffItems;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private bool _eventsRegistered;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
	private bool _isRefreshingView;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
	private bool _openCountdownRunning;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float _openCountdownElapsed;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool _isDiamondRefreshPhase;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private Color _diamondCostColorEnough;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private readonly Color _diamondCostColorNotEnough;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Action<string> _onDiamondResourceChanged;

	[Token(Token = "0x40004CA")]
	private const string DiamondRefreshLimitTipText = "已达刷新次数上限";

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x3E41F60", Offset = "0x3E3DF60", VA = "0x3E41F60", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x3E42260", Offset = "0x3E3E260", VA = "0x3E42260", Slot = "5")]
	[AsyncStateMachine(typeof(_003CShow_003Ed__31))]
	public override UniTask Show(params object[] args)
	{
		return default;
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x3E422FC", Offset = "0x3E3E2FC", VA = "0x3E422FC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x3E42798", Offset = "0x3E3E798", VA = "0x3E42798")]
	private void RegisterEvents()
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x3E42580", Offset = "0x3E3E580", VA = "0x3E42580")]
	private void UnregisterEvents()
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x3E429F0", Offset = "0x3E3E9F0", VA = "0x3E429F0")]
	private void OnDataChanged(object obj)
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x3E42BB0", Offset = "0x3E3EBB0", VA = "0x3E42BB0")]
	private void OnOpenWindowStateChanged(object obj)
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x3E42BD8", Offset = "0x3E3EBD8", VA = "0x3E42BD8")]
	private void OnDiamondResourceChanged(string count)
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x3E42DA8", Offset = "0x3E3EDA8", VA = "0x3E42DA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x3E42A18", Offset = "0x3E3EA18", VA = "0x3E42A18")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x3E43030", Offset = "0x3E3F030", VA = "0x3E43030")]
	private void RefreshOpenWindowState()
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x3E43794", Offset = "0x3E3F794", VA = "0x3E43794")]
	private void StartOpenCountdown()
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x3E42570", Offset = "0x3E3E570", VA = "0x3E42570")]
	private void StopOpenCountdown()
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x3E42DFC", Offset = "0x3E3EDFC", VA = "0x3E42DFC")]
	private void UpdateOpenTimerText()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x3E43710", Offset = "0x3E3F710", VA = "0x3E43710")]
	private void RefreshChestSlots()
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x3E43558", Offset = "0x3E3F558", VA = "0x3E43558")]
	private void RefreshBuffDisplay()
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x3E437A4", Offset = "0x3E3F7A4", VA = "0x3E437A4")]
	private SubGameChaosTrailsBuffItem GetBuffItem(int index)
	{
		return null;
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x3E43138", Offset = "0x3E3F138", VA = "0x3E43138")]
	private void RefreshActionState()
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x3E43400", Offset = "0x3E3F400", VA = "0x3E43400")]
	private void RefreshLeftRewardTimes()
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x3E42C0C", Offset = "0x3E3EC0C", VA = "0x3E42C0C")]
	private void RefreshDiamondCostColor(bool isDiamondPhase)
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x3E438F0", Offset = "0x3E3F8F0", VA = "0x3E438F0")]
	private void OnDiamondRefreshBtnClick()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x3E43A20", Offset = "0x3E3FA20", VA = "0x3E43A20")]
	private void OnRefreshAdFinish()
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x3E43AD0", Offset = "0x3E3FAD0", VA = "0x3E43AD0")]
	private void OnEnterBtnClick()
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x3E43B28", Offset = "0x3E3FB28", VA = "0x3E43B28")]
	private void OnTipsBtnClick()
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x3E43B48", Offset = "0x3E3FB48", VA = "0x3E43B48")]
	private void HideTipsPanel()
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x3E42F50", Offset = "0x3E3EF50", VA = "0x3E42F50")]
	private void RefreshTipsText(string openTimeText)
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x3E43B68", Offset = "0x3E3FB68", VA = "0x3E43B68")]
	private void HideSelf()
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x3E43BD0", Offset = "0x3E3FBD0", VA = "0x3E43BD0")]
	public SubGameChaosTrailsPanel()
	{
	}
}
