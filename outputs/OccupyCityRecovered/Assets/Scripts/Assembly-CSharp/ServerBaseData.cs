using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000072")]
public abstract class ServerBaseData
{
	[Token(Token = "0x6000262")]
	[Address(RVA = "0x3D20310", Offset = "0x3D1C310", VA = "0x3D20310", Slot = "4")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x3D20314", Offset = "0x3D1C314", VA = "0x3D20314", Slot = "5")]
	public virtual void InitFromDefaults()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x3D20318", Offset = "0x3D1C318", VA = "0x3D20318")]
	protected ServerBaseData()
	{
	}
}
