using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BadgeGraph;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using SDKModule;
using TMPro;
using UIModuleO;
using UIModuleO.UIAnim;
using UnityEngine;
using ljzs_lt;

[Token(Token = "0x20000CD")]
public class SpecialSummonGiftItem : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct _003CRefreshRewardsAsync_003Ed__34 : IAsyncStateMachine
	{
		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpecialSummonGiftItem _003C_003E4__this;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RewardConfig _003CrewardConfig_003E5__2;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UniTask.Awaiter _003C_003Eu__1;

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x3E40160", Offset = "0x3E3C160", VA = "0x3E40160", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x3E40790", Offset = "0x3E3C790", VA = "0x3E40790", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000472")]
	private const string ClaimedDailyText = "明天再来";

	[Token(Token = "0x4000473")]
	private const int PackTypeFree = 0;

	[Token(Token = "0x4000474")]
	private const int PackTypeAd = 1;

	[Token(Token = "0x4000475")]
	private const int PackTypeIap = 2;

	[Token(Token = "0x4000476")]
	private const int LimitTypeDaily = 0;

	[Token(Token = "0x4000477")]
	private const int LimitTypeWeekly = 1;

	[Token(Token = "0x4000478")]
	private const string LimitLabelDaily = "每日限购：";

	[Token(Token = "0x4000479")]
	private const string LimitLabelWeekly = "每周限购：";

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private BadgeButton badge;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject giftBGFree;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject giftBG;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TextMeshProUGUI giftTitle;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TextMeshProUGUI giftGetLimit;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private BenefitValueItem benefit;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform giftRewardsContent;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private SpecialSummonGiftRewardItem giftRewardItemTemplate;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject claimedBtn;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private TextMeshProUGUI claimedBtnText;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private ButtonExtend freeBtn;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private AdButtonExtend adBtn;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private HWIAPButton iapBtn;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private LimitedPropPackConfig _pack;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Action _onClaimSuccess;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool _badgeBound;

	[Token(Token = "0x17000039")]
	public bool NeedsWeeklyCountdownRefresh
	{
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x3E3F648", Offset = "0x3E3B648", VA = "0x3E3F648")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x3E3F680", Offset = "0x3E3B680", VA = "0x3E3F680")]
	public void Setup(LimitedPropPackConfig pack, Action onClaimSuccess)
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x3E3F84C", Offset = "0x3E3B84C", VA = "0x3E3F84C")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x3E3FFC4", Offset = "0x3E3BFC4", VA = "0x3E3FFC4")]
	public void RefreshWeeklyCountdownText()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x3E3F72C", Offset = "0x3E3B72C", VA = "0x3E3F72C")]
	private void BindFreeBadgeIfNeeded()
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x3E3FCD8", Offset = "0x3E3BCD8", VA = "0x3E3FCD8")]
	private void RegisterButtons()
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x3E400AC", Offset = "0x3E3C0AC", VA = "0x3E400AC")]
	private void OnFreeBtnClicked()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x3E400EC", Offset = "0x3E3C0EC", VA = "0x3E400EC")]
	private void OnAdClaimSuccess()
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x3E4012C", Offset = "0x3E3C12C", VA = "0x3E4012C")]
	private void OnIapPurchaseUiCallback(bool success)
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x3E3F7D0", Offset = "0x3E3B7D0", VA = "0x3E3F7D0")]
	[AsyncStateMachine(typeof(_003CRefreshRewardsAsync_003Ed__34))]
	private UniTaskVoid RefreshRewardsAsync()
	{
		return default;
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x3E4014C", Offset = "0x3E3C14C", VA = "0x3E4014C")]
	public SpecialSummonGiftItem()
	{
	}
}
