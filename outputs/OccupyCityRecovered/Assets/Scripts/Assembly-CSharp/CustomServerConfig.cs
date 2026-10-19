using Il2CppDummyDll;
using L_Tools;

[Token(Token = "0x200004C")]
public class CustomServerConfig
{
	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x0")]
	public static IpConfig APP_Tuiguang;

	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x8")]
	public static IpConfig APP_iOS;

	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x10")]
	public static IpConfig APP_Oppo;

	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x18")]
	public static IpConfig APP_Vivo;

	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0x20")]
	public static IpConfig APP_Android;

	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x28")]
	public static IpConfig APP_HongMeng;

	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x30")]
	public static IpConfig XYX_Weixin;

	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x38")]
	public static IpConfig XYX_Weixin_mj0;

	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x40")]
	public static IpConfig XYX_Weixin_mj1;

	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x48")]
	public static IpConfig XYX_Weixin_mj2;

	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x50")]
	public static IpConfig XYX_Douyin;

	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0x58")]
	public static IpConfig XYX_Douyin_mj0;

	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x60")]
	public static IpConfig XYX_Douyin_mj1;

	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x68")]
	public static IpConfig XYX_Douyin_mj2;

	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x70")]
	public static IpConfig XYX_Kuaishou;

	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x78")]
	public static IpConfig XYX_Zhifubao;

	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x80")]
	public static IpConfig XYX_Bilibili;

	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x88")]
	public static IpConfig XYX_Oppo;

	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x90")]
	public static IpConfig XYX_Vivo;

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x3D0AF80", Offset = "0x3D06F80", VA = "0x3D0AF80")]
	public static IpConfig GetIpConfig(PlatformEnum platform)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x3D0B1D4", Offset = "0x3D071D4", VA = "0x3D0B1D4")]
	public CustomServerConfig()
	{
	}
}
