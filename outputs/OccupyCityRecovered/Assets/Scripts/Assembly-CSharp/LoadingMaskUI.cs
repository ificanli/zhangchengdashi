using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using L_Tools;
using UnityEngine;

[Token(Token = "0x2000017")]
public class LoadingMaskUI : SingletonComponent<LoadingMaskUI>
{
	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject loadingMask;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float LastShowTime;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float maxShowTime;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Action<bool> onShowComplete;

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x3D019A0", Offset = "0x3CFD9A0", VA = "0x3D019A0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x3D01C28", Offset = "0x3CFDC28", VA = "0x3D01C28")]
	private void Update()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x3CFE6A4", Offset = "0x3CFA6A4", VA = "0x3CFE6A4")]
	public void ShowLoadingMask([Optional][DefaultParameterValue(60)] int maxShowTime, [Optional] Action<bool> onShowComplete)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x3CFEF5C", Offset = "0x3CFAF5C", VA = "0x3CFEF5C")]
	public void HideLoadingMask()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x3D01CF4", Offset = "0x3CFDCF4", VA = "0x3D01CF4")]
	public LoadingMaskUI()
	{
	}
}
