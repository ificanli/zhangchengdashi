using GameFramework;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000008")]
public class UILangText : MonoBehaviour, IUILang
{
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string key;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x28")]
	private Text textTarget;

	[Token(Token = "0x17000008")]
	public string Key
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x7067988", Offset = "0x7063988", VA = "0x7067988", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x7067990", Offset = "0x7063990", VA = "0x7067990", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public string Value
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x7067B68", Offset = "0x7063B68", VA = "0x7067B68", Slot = "6")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x7067AA4", Offset = "0x7063AA4", VA = "0x7067AA4", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x70678B4", Offset = "0x70638B4", VA = "0x70678B4")]
	private void Start()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x7067C14", Offset = "0x7063C14", VA = "0x7067C14", Slot = "8")]
	public void Refresh()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x7067C9C", Offset = "0x7063C9C", VA = "0x7067C9C")]
	public UILangText()
	{
	}
}
