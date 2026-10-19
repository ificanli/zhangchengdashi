using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000025")]
public class WXAddTableUI : MonoBehaviour
{
	[Token(Token = "0x2000026")]
	public delegate bool CheckIsGiveReward();

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x20")]
	public Button RewardBtn;

	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x28")]
	public Button closeBtn;

	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI RewardBtnText;

	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI rewardNumText;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x40")]
	private Action<bool> m_GiveRewardCallback;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x48")]
	private CheckIsGiveReward m_CheckIsGiveReward;

	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x50")]
	private float time;

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x3D03500", Offset = "0x3CFF500", VA = "0x3D03500")]
	public void Awake()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x3D03524", Offset = "0x3CFF524", VA = "0x3D03524")]
	public void Show(int rewardNum, Action<bool> callback, CheckIsGiveReward checkIsGiveReward)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x3D03650", Offset = "0x3CFF650", VA = "0x3D03650")]
	private bool HasEnterFromDesktop()
	{
		return default;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x3D03658", Offset = "0x3CFF658", VA = "0x3D03658")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x3D035A8", Offset = "0x3CFF5A8", VA = "0x3D035A8")]
	private void UpdateRewardBtnText()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x3D036B8", Offset = "0x3CFF6B8", VA = "0x3D036B8")]
	private void OnClose()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x3D036DC", Offset = "0x3CFF6DC", VA = "0x3D036DC")]
	private void OnClick()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x3D036E0", Offset = "0x3CFF6E0", VA = "0x3D036E0")]
	public WXAddTableUI()
	{
	}
}
