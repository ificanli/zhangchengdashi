using System.Runtime.CompilerServices;
using GameFramework;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YooAsset;

[Token(Token = "0x2000007")]
public class MLangImage : MonoBehaviour, IUILang
{
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string key;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	private Image target;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x30")]
	public bool autoSetSize;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x40")]
	private AssetOperationHandle handle;

	[Token(Token = "0x17000005")]
	public string Key
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x7067174", Offset = "0x7063174", VA = "0x7067174", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x706717C", Offset = "0x706317C", VA = "0x706717C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public string Value
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x706742C", Offset = "0x706342C", VA = "0x706742C", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x7067434", Offset = "0x7063434", VA = "0x7067434", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public Image Target
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x706743C", Offset = "0x706343C", VA = "0x706743C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x70674E0", Offset = "0x70634E0", VA = "0x70674E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x7067638", Offset = "0x7063638", VA = "0x7067638")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x706764C", Offset = "0x706364C", VA = "0x706764C", Slot = "8")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x706728C", Offset = "0x706328C", VA = "0x706728C")]
	private void SetSprite(string spriteName, string atlas, bool autoSetSize)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x70678A4", Offset = "0x70638A4", VA = "0x70678A4")]
	public MLangImage()
	{
	}
}
