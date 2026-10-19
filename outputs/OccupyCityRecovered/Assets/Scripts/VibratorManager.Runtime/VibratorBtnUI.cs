using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000004")]
public class VibratorBtnUI : MonoBehaviour
{
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x20")]
	public Button btn;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x28")]
	public Image btnImg;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x30")]
	public Sprite vibratorOnSprite;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x38")]
	public Sprite vibratorOffSprite;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x40")]
	private bool _isFirstLoad;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x854C42C", Offset = "0x854842C", VA = "0x854C42C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x854C4E8", Offset = "0x85484E8", VA = "0x854C4E8")]
	private void Start()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x854C668", Offset = "0x8548668", VA = "0x854C668")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x854C698", Offset = "0x8548698", VA = "0x854C698")]
	private void UpdateInfo(bool isVibratorEnable)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x854C6EC", Offset = "0x85486EC", VA = "0x854C6EC")]
	public VibratorBtnUI()
	{
	}
}
