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
using UnityEngine;
using UnityEngine.UI;
using ljzs_lt;

[Token(Token = "0x20000C6")]
public class CheckInRewardPanel : UIPanel
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct _003CShow_003Ed__22 : IAsyncStateMachine
	{
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CheckInRewardPanel _003C_003E4__this;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public object[] args;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UniTask.Awaiter _003C_003Eu__1;

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x3E3D370", Offset = "0x3E39370", VA = "0x3E3D370", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x3E3D7F0", Offset = "0x3E397F0", VA = "0x3E3D7F0", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000424")]
	private const float CountdownRefreshInterval = 1f;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Button maskBtn;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private TextMeshProUGUI cycleTime;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Button closeBtn;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ScrollRect scrollView;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private RectTransform content;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private CheckInItem checkInItemTemplate;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private TextMeshProUGUI loginDays;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private RectTransform progressBG;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image progress;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private CumulativeRewardItem cumulativeRewardItemTemplate;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Button checkInBtn;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private AdButtonExtend reCheckInBtn;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Button cannotReCheckInBtn;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private GameObject claimedBtn;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly List<CheckInItem> _checkInItems;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly List<CumulativeRewardItem> _cumulativeRewardItems;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int _selectedDay;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float _countdownRefreshTimer;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private int _lastPollDay;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private int _lastPollSignedDays;

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x3E3B798", Offset = "0x3E37798", VA = "0x3E3B798", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x3E3B9A8", Offset = "0x3E379A8", VA = "0x3E3B9A8", Slot = "5")]
	[AsyncStateMachine(typeof(_003CShow_003Ed__22))]
	public override UniTask Show(params object[] args)
	{
		return default;
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x3E3BA44", Offset = "0x3E37A44", VA = "0x3E3BA44")]
	private void Update()
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x3E3BD38", Offset = "0x3E37D38", VA = "0x3E3BD38")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x3E3BEAC", Offset = "0x3E37EAC", VA = "0x3E3BEAC")]
	private void UpdatePollCache()
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x3E3BB84", Offset = "0x3E37B84", VA = "0x3E3BB84")]
	private bool HasDayOrSignStateChanged()
	{
		return default;
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x3E3BC08", Offset = "0x3E37C08", VA = "0x3E3BC08")]
	private void RefreshView(bool refreshCycleTime = true)
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x3E3C604", Offset = "0x3E38604", VA = "0x3E3C604")]
	private void RefreshAfterSignChange()
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x3E3C724", Offset = "0x3E38724", VA = "0x3E3C724")]
	private void RefreshAfterCumulativeClaim()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x3E3BB04", Offset = "0x3E37B04", VA = "0x3E3BB04")]
	private void RefreshCycleTime()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x3E3BF18", Offset = "0x3E37F18", VA = "0x3E3BF18")]
	private void RefreshDailyItems(List<CheckInRewardsConfig> rewards, int currentDay, bool canCheckInToday, bool canReCheckInToday)
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x3E3C13C", Offset = "0x3E3813C", VA = "0x3E3C13C")]
	private void RefreshCumulativeItems(List<CumulativeRewardConfig> rewards)
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x3E3C3A4", Offset = "0x3E383A4", VA = "0x3E3C3A4")]
	private void RefreshProgress(List<CumulativeRewardConfig> rewards)
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x3E3C500", Offset = "0x3E38500", VA = "0x3E3C500")]
	private void RefreshBottomBtn(int currentDay, bool canCheckInToday, bool canReCheckInToday)
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x3E3CE28", Offset = "0x3E38E28", VA = "0x3E3CE28")]
	private float GetCumulativeProgressFill(int signedDays, List<CumulativeRewardConfig> rewards)
	{
		return default;
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x3E3C790", Offset = "0x3E38790", VA = "0x3E3C790")]
	private CheckInItem GetCheckInItem(int index)
	{
		return null;
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x3E3C8DC", Offset = "0x3E388DC", VA = "0x3E3C8DC")]
	private CumulativeRewardItem GetCumulativeRewardItem(int index)
	{
		return null;
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x3E3CF4C", Offset = "0x3E38F4C", VA = "0x3E3CF4C")]
	private void OnCheckInItemClick(int day)
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x3E3D0A0", Offset = "0x3E390A0", VA = "0x3E3D0A0")]
	private void OnCheckInBtnClick()
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x3E3D108", Offset = "0x3E39108", VA = "0x3E3D108")]
	private void OnReCheckInAdFinish()
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x3E3D174", Offset = "0x3E39174", VA = "0x3E3D174")]
	private void OnCannotReCheckInBtnClick()
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x3E3D1B8", Offset = "0x3E391B8", VA = "0x3E3D1B8")]
	private void OnCumulativeRewardClick(int rewardId)
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x3E3D234", Offset = "0x3E39234", VA = "0x3E3D234")]
	private void HideSelf()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x3E3D29C", Offset = "0x3E3929C", VA = "0x3E3D29C")]
	public CheckInRewardPanel()
	{
	}
}
