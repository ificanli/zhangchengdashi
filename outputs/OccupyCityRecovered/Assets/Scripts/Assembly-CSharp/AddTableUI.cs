using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200002F")]
public class AddTableUI : MonoBehaviour
{
	[Token(Token = "0x2000030")]
	public delegate bool CheckIsGiveReward();

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x20")]
	public Button CloseBtn;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x28")]
	public Button ConfirmBtn;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI text;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x38")]
	private Action m_GiveRewardCallback;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x40")]
	private CheckIsGiveReward m_CheckIsGiveReward;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x48")]
	private int OpenTime;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x50")]
	private Action OnGet;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x3D0490C", Offset = "0x3D0090C", VA = "0x3D0490C")]
	public void Awake()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x3D04A5C", Offset = "0x3D00A5C", VA = "0x3D04A5C")]
	public void OnMiniGameOnShow(object[] args)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x3D04A60", Offset = "0x3D00A60", VA = "0x3D04A60")]
	public void Show(int rewardNum, Action callback, CheckIsGiveReward checkIsGiveReward)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x3D04AA0", Offset = "0x3D00AA0", VA = "0x3D04AA0")]
	public void Show()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x3D04ADC", Offset = "0x3D00ADC", VA = "0x3D04ADC")]
	public void Hide()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x3D049A4", Offset = "0x3D009A4", VA = "0x3D049A4")]
	private void UpdateConfirmBtn()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x3D04B00", Offset = "0x3D00B00", VA = "0x3D04B00")]
	private void GoSide()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x3D04B04", Offset = "0x3D00B04", VA = "0x3D04B04")]
	public AddTableUI()
	{
	}
}
