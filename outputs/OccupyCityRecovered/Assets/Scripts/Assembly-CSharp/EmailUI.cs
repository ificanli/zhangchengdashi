using System.Collections.Generic;
using CommonGameModule.Email;
using Il2CppDummyDll;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200004A")]
public class EmailUI : MonoBehaviour
{
	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0x20")]
	public LoopListView2 loopListView;

	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x28")]
	public EmailDetalUI DetalUI;

	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x30")]
	public Button GetAllBtn;

	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x38")]
	public Button DelAllReadBtn;

	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x40")]
	private List<EmailData> emailDataList;

	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x48")]
	private bool mIsInit;

	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x50")]
	public GameObject NoEmailTip;

	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x58")]
	public RectTransform NoRewardTip;

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x3D09A84", Offset = "0x3D05A84", VA = "0x3D09A84")]
	private void Awake()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x3D09BAC", Offset = "0x3D05BAC", VA = "0x3D09BAC")]
	public void Show()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x3D09EA4", Offset = "0x3D05EA4", VA = "0x3D09EA4")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x3D09FD0", Offset = "0x3D05FD0", VA = "0x3D09FD0")]
	public void GetAllReward()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x3D0A7E0", Offset = "0x3D067E0", VA = "0x3D0A7E0")]
	public void DeleteAllReaded()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x3D0AAA4", Offset = "0x3D06AA4", VA = "0x3D0AAA4")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x3D0AADC", Offset = "0x3D06ADC", VA = "0x3D0AADC")]
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x3D0AC2C", Offset = "0x3D06C2C", VA = "0x3D0AC2C")]
	public EmailUI()
	{
	}
}
