using Il2CppDummyDll;

[Token(Token = "0x2000082")]
public class SimpleCounter
{
	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x10")]
	private float duration;

	[Token(Token = "0x400028E")]
	[FieldOffset(Offset = "0x14")]
	private float maxTime;

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x3D22670", Offset = "0x3D1E670", VA = "0x3D22670")]
	public void Start(float duration)
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x3D2267C", Offset = "0x3D1E67C", VA = "0x3D2267C")]
	public void Reset()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x3D226A0", Offset = "0x3D1E6A0", VA = "0x3D226A0")]
	public bool Ended()
	{
		return default;
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x3D226C4", Offset = "0x3D1E6C4", VA = "0x3D226C4")]
	public SimpleCounter()
	{
	}
}
