using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000039")]
public class ProxyLoginMgr
{
	[Token(Token = "0x40000E9")]
	private const string QrCodePreviewUIPath = "Assets/_Res/Addressable/01FirstBundle/Prefabs/UI/PanelElements/QrCodePreviewUI.prefab";

	[Token(Token = "0x40000EA")]
	private const string ProxyLoginMsgPath = "Assets/_Res/Addressable/01FirstBundle/Prefabs/UI/Panels/ProxyLoginMsgCanvas.prefab";

	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x10")]
	public string _borrowConfirmTicket;

	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x18")]
	public string _borrowConfirmOpenId;

	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x0")]
	public static bool isProxyLogin;

	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x1")]
	public static bool _isProxyLoginSuccess;

	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x8")]
	private static GameObject _qrCodePreviewUIPrefab;

	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x10")]
	private static GameObject _proxyLoginMsgUIPrefab;

	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x18")]
	private static bool _isProxyLoginMsgUICreating;

	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x20")]
	private static QRCodePreviewUI _qrCodePreviewUI;

	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x28")]
	private static bool _isQRCodeUICreating;

	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x29")]
	private static bool _isGMRegistered;

	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x30")]
	private static ProxyLoginMgr instance;

	[Token(Token = "0x1700000D")]
	public static ProxyLoginMgr Instance
	{
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x3D063EC", Offset = "0x3D023EC", VA = "0x3D063EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x3D06458", Offset = "0x3D02458", VA = "0x3D06458")]
	public ProxyLoginMgr()
	{
	}
}
