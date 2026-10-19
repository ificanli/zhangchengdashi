using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000016")]
public class PlatformGOActiveControl : MonoBehaviour
{
	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] LinkGOs;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent<bool> OnActiveStateChange;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x30")]
	[Header("IOS")]
	public bool iOS;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x31")]
	[Header("安卓")]
	public bool Android;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x32")]
	[Header("微信")]
	public bool XYX_WX;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x33")]
	[Header("抖音")]
	public bool XYX_DY;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x34")]
	[Header("快手")]
	public bool XYX_KS;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x35")]
	[Header("达人GM")]
	public bool XYX_DRGM;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x36")]
	[Header("支付宝")]
	public bool XYX_AliPay;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x37")]
	[Header("B站")]
	public bool XYX_BILI;

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x3D01824", Offset = "0x3CFD824", VA = "0x3D01824")]
	private void Awake()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x3D01998", Offset = "0x3CFD998", VA = "0x3D01998")]
	public PlatformGOActiveControl()
	{
	}
}
