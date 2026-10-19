using Il2CppDummyDll;

[Token(Token = "0x2000054")]
public struct PlayerBattlePowerChangeInfo
{
	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x0")]
	public int OldTotalPower;

	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x4")]
	public int NewTotalPower;

	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x8")]
	public int OldDeckPower;

	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0xC")]
	public int NewDeckPower;

	[Token(Token = "0x17000010")]
	public int TotalDelta
	{
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x3D0D3B0", Offset = "0x3D093B0", VA = "0x3D0D3B0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000011")]
	public int DeckDelta
	{
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x3D0D3BC", Offset = "0x3D093BC", VA = "0x3D0D3BC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000012")]
	public bool HasTotalChange
	{
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x3D0D3C8", Offset = "0x3D093C8", VA = "0x3D0D3C8")]
		get
		{
			return default;
		}
	}
}
