using Il2CppDummyDll;

[Token(Token = "0x200021B")]
internal abstract class X_009A_00BCti_009D
{
	[Token(Token = "0x400076E")]
	[FieldOffset(Offset = "0x10")]
	protected int needOpenUICount;

	[Token(Token = "0x400076F")]
	[FieldOffset(Offset = "0x14")]
	protected float needGameTimes;

	[Token(Token = "0x4000770")]
	[FieldOffset(Offset = "0x18")]
	protected bool isNeedRequestPermission;

	[Token(Token = "0x17000118")]
	internal virtual int _007C_00AE_00A7_00AE_00B1I
	{
		[Token(Token = "0x6001B78")]
		[Address(RVA = "0x70E0C04", Offset = "0x70DCC04", VA = "0x70E0C04", Slot = "4")]
		get
		{
			return _007F_008DM_00A4F_008D();
		}
	}

	[Token(Token = "0x6001B78")]
	[Address(RVA = "0x70E0C04", Offset = "0x70DCC04", VA = "0x70E0C04", Slot = "4")]
	internal virtual int _007F_008DM_00A4F_008D()
	{
		return default;
	}

	[Token(Token = "0x6001B79")]
	internal abstract bool _00B6_0090bZv_00B4(int _0096Tp_0087_00A7_00A7, float _0085LWt_00A3_00AC);

	[Token(Token = "0x6001B7A")]
	internal abstract void _00ADB_009E_0097_009EP();

	[Token(Token = "0x6001B7B")]
	[Address(RVA = "0x70E0C0C", Offset = "0x70DCC0C", VA = "0x70E0C0C", Slot = "7")]
	public virtual void ActivelyRequestPermission()
	{
	}

	[Token(Token = "0x6001B7C")]
	[Address(RVA = "0x70E04FC", Offset = "0x70DC4FC", VA = "0x70E04FC")]
	protected bool ParsingParams(string K_00B3I_00B7_00B6_00AE)
	{
		return default;
	}

	[Token(Token = "0x6001B7D")]
	[Address(RVA = "0x70E04E8", Offset = "0x70DC4E8", VA = "0x70E04E8")]
	protected X_009A_00BCti_009D()
	{
	}
}
