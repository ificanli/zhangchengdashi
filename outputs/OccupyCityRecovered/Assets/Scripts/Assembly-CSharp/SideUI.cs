using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000040")]
public class SideUI : MonoBehaviour
{
	[Token(Token = "0x2000041")]
	public delegate bool CheckIsGiveReward();

	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x20")]
	public Button CloseBtn;

	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x28")]
	public Button ConfirmBtn;

	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI text;

	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x38")]
	private Action m_GiveRewardCallback;

	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x40")]
	private CheckIsGiveReward m_CheckIsGiveReward;

	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x48")]
	private bool _biliOpenByside;

	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x4C")]
	private int OpenTime;

	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x50")]
	private Action OnGet;

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x3D06D28", Offset = "0x3D02D28", VA = "0x3D06D28")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x3D04EF0", Offset = "0x3D00EF0", VA = "0x3D04EF0")]
	public void Show(int rewardNum, Action callback, CheckIsGiveReward checkIsGiveReward)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x3D06EE8", Offset = "0x3D02EE8", VA = "0x3D06EE8")]
	public void Show()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x3D06F24", Offset = "0x3D02F24", VA = "0x3D06F24")]
	public void Hide()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x3D06DB8", Offset = "0x3D02DB8", VA = "0x3D06DB8")]
	private void UpdateConfirmBtn()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x3D06F48", Offset = "0x3D02F48", VA = "0x3D06F48")]
	private bool CheckLaunchFormSide()
	{
		return default;
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x3D06F50", Offset = "0x3D02F50", VA = "0x3D06F50")]
	private void GoSide()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x3D06F54", Offset = "0x3D02F54", VA = "0x3D06F54")]
	public SideUI()
	{
	}
}
