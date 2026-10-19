using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

[Serializable]
[Token(Token = "0x2000098")]
public class MysteriousStoreData
{
	[Token(Token = "0x40002EA")]
	[FieldOffset(Offset = "0x10")]
	[JsonProperty("cid")]
	public string ConfigId;

	[Token(Token = "0x40002EB")]
	[FieldOffset(Offset = "0x18")]
	[JsonProperty("i")]
	public int Index;

	[Token(Token = "0x40002EC")]
	[FieldOffset(Offset = "0x20")]
	[JsonProperty("aiid")]
	public string AssetsInfoId;

	[Token(Token = "0x40002ED")]
	[FieldOffset(Offset = "0x28")]
	[JsonProperty("c")]
	public int Count;

	[Token(Token = "0x40002EE")]
	[FieldOffset(Offset = "0x2C")]
	[JsonProperty("dc")]
	public float Discount;

	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0x30")]
	[JsonProperty("ig")]
	public bool IsGet;

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x3D272A8", Offset = "0x3D232A8", VA = "0x3D272A8")]
	public int GetSinglePrice()
	{
		return default;
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x3D27378", Offset = "0x3D23378", VA = "0x3D27378")]
	public MysteriousStoreData()
	{
	}
}
