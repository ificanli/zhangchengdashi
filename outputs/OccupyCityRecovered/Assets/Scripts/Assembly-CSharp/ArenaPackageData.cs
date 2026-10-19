using System;
using DataModule;
using Il2CppDummyDll;
using Newtonsoft.Json;

[Serializable]
[Token(Token = "0x2000097")]
public class ArenaPackageData
{
	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x10")]
	public string Id;

	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x18")]
	[JsonProperty("ut")]
	public DateTime UnlockTime;

	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x20")]
	[JsonProperty("pn")]
	public int PurchaseNumber;

	[Token(Token = "0x40002E9")]
	[FieldOffset(Offset = "0x28")]
	[JsonProperty("tk")]
	public string TimeKey;

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x3D26FEC", Offset = "0x3D22FEC", VA = "0x3D26FEC")]
	public bool IsUnlocked()
	{
		return default;
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x3D2704C", Offset = "0x3D2304C", VA = "0x3D2704C")]
	public bool PackageIsPastDue()
	{
		return default;
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x3D27254", Offset = "0x3D23254", VA = "0x3D27254")]
	public bool PackageIsPurchase()
	{
		return default;
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x3D27190", Offset = "0x3D23190", VA = "0x3D27190")]
	public ShopArenaPackInfos GetArenaPackageConfig()
	{
		return null;
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x3D2727C", Offset = "0x3D2327C", VA = "0x3D2727C")]
	public ArenaPackageData()
	{
	}
}
