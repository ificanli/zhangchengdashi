using System;
using System.Collections.Generic;
using GameFramework.SDK;
using Il2CppDummyDll;
using L_Tools;
using L_Tools.FakeMediation;
using UnityEngine;

[Token(Token = "0x2000008")]
public class ADSIMHelper : SingletonComponent<ADSIMHelper>
{
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x0")]
	public static bool isSimulate;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, VideoBtnData> _videoBtnData;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x28")]
	private FakeMediationBehaviour _faakeAds;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x30")]
	public GameObject _faakeAdsPrefab;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x3CFDEE4", Offset = "0x3CF9EE4", VA = "0x3CFDEE4", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x3CFE1E4", Offset = "0x3CFA1E4", VA = "0x3CFE1E4")]
	public int GetVideoBtnData(string reportLable)
	{
		return default;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x3CFE268", Offset = "0x3CFA268", VA = "0x3CFE268")]
	public void ShowRewardedVideo(Action<bool> onReward, string rewardType)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x3CFE7D8", Offset = "0x3CFA7D8", VA = "0x3CFE7D8")]
	public void ShowInterstitial()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x3CFE858", Offset = "0x3CFA858", VA = "0x3CFE858")]
	public void ShowBanner()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x3CFE904", Offset = "0x3CFA904", VA = "0x3CFE904")]
	public void HideBanner()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x3CFE6EC", Offset = "0x3CFA6EC", VA = "0x3CFE6EC")]
	public void ReportVideoEvent(VideoEvent videoEvent, string reportLable)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x3CFEDA0", Offset = "0x3CFADA0", VA = "0x3CFEDA0")]
	public ADSIMHelper()
	{
	}
}
