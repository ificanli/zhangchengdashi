using System;
using Il2CppDummyDll;
using TMPro;
using UIModuleO;
using UnityEngine;
using UnityEngine.UI;
using ljzs_lt;

[Token(Token = "0x20000C5")]
public class CheckInItem : MonoBehaviour
{
	[Token(Token = "0x400040E")]
	private const int RewardTypeBaseRes = 0;

	[Token(Token = "0x400040F")]
	private const float NonCardRewardIconScale = 1.5f;

	[Token(Token = "0x4000410")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button selectBtn;

	[Token(Token = "0x4000411")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject normalBG;

	[Token(Token = "0x4000412")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject goldBG;

	[Token(Token = "0x4000413")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject selected;

	[Token(Token = "0x4000414")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TextMeshProUGUI title;

	[Token(Token = "0x4000415")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RewardItemUI reward;

	[Token(Token = "0x4000416")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform rewardIcon;

	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject reCheckIn;

	[Token(Token = "0x4000418")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private TextMeshProUGUI reCheckInText;

	[Token(Token = "0x4000419")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject claimed;

	[Token(Token = "0x400041A")]
	[FieldOffset(Offset = "0x70")]
	private int _day;

	[Token(Token = "0x400041B")]
	[FieldOffset(Offset = "0x78")]
	private Action<int> _onClick;

	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0x80")]
	private bool _clickListenerRegistered;

	[Token(Token = "0x400041D")]
	[FieldOffset(Offset = "0x84")]
	private int _cachedDay;

	[Token(Token = "0x400041E")]
	[FieldOffset(Offset = "0x88")]
	private int _cachedCurrentDay;

	[Token(Token = "0x400041F")]
	[FieldOffset(Offset = "0x8C")]
	private CheckInRewardManager.CheckInDayState _cachedState;

	[Token(Token = "0x4000420")]
	[FieldOffset(Offset = "0x90")]
	private bool _cachedIsSelected;

	[Token(Token = "0x4000421")]
	[FieldOffset(Offset = "0x94")]
	private int _cachedRewardId;

	[Token(Token = "0x4000422")]
	[FieldOffset(Offset = "0x98")]
	private int _cachedRewardNum;

	[Token(Token = "0x4000423")]
	[FieldOffset(Offset = "0x9C")]
	private int _cachedRewardType;

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x3E3B108", Offset = "0x3E37108", VA = "0x3E3B108")]
	public void SetSelected(bool isSelected)
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x3E3B148", Offset = "0x3E37148", VA = "0x3E3B148")]
	public void SetInfo(int day, int currentDay, CheckInRewardsConfig config, CheckInRewardManager.CheckInDayState state, bool isSelected, Action<int> onClick)
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x3E3B474", Offset = "0x3E37474", VA = "0x3E3B474")]
	private void RefreshRewardDisplay(CheckInRewardsConfig config)
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x3E3B6BC", Offset = "0x3E376BC", VA = "0x3E3B6BC")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x3E3B6DC", Offset = "0x3E376DC", VA = "0x3E3B6DC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x3E3B77C", Offset = "0x3E3777C", VA = "0x3E3B77C")]
	public CheckInItem()
	{
	}
}
