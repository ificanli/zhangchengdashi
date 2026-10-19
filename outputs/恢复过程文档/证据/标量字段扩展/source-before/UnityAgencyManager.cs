using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using L_Tools;

[Token(Token = "0x200001D")]
public class UnityAgencyManager : SingletonComponent<UnityAgencyManager>
{
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<UME, UnityAgency> keyValuePairs;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x28")]
	private float lastRealRunTime;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x2C")]
	private float realTimeDelta;

	[Token(Token = "0x17000006")]
	public float RealTimeDelta
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x3D02BD0", Offset = "0x3CFEBD0", VA = "0x3D02BD0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x3D02BD8", Offset = "0x3CFEBD8", VA = "0x3D02BD8")]
	public void AddEvent(UME ume, Action action)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x3D02CCC", Offset = "0x3CFECCC", VA = "0x3D02CCC")]
	public void AddEvent(UME ume, Action<bool> action)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x3D02DC0", Offset = "0x3CFEDC0", VA = "0x3D02DC0")]
	public void RemoveEvent(UME ume, Action action)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x3D02E6C", Offset = "0x3CFEE6C", VA = "0x3D02E6C")]
	public void RemoveEvent(UME ume, Action<bool> action)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x3D02F18", Offset = "0x3CFEF18", VA = "0x3D02F18")]
	private void RunEvent(UME e)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x3D02FB0", Offset = "0x3CFEFB0", VA = "0x3D02FB0")]
	private void RunEvent(UME e, bool arg)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x3D0305C", Offset = "0x3CFF05C", VA = "0x3D0305C")]
	private void Update()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x3D03094", Offset = "0x3CFF094", VA = "0x3D03094")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x3D030A0", Offset = "0x3CFF0A0", VA = "0x3D030A0")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x3D030AC", Offset = "0x3CFF0AC", VA = "0x3D030AC")]
	public UnityAgencyManager()
	{
	}
}
