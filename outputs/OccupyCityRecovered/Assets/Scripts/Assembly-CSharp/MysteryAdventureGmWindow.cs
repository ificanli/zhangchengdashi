using System.Runtime.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000062")]
public class MysteryAdventureGmWindow : MonoBehaviour
{
	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x0")]
	private static MysteryAdventureGmWindow _instance;

	[Token(Token = "0x4000204")]
	private const float ReferenceShortSide = 720f;

	[Token(Token = "0x4000205")]
	private const float ReferenceDpi = 320f;

	[Token(Token = "0x4000206")]
	private const float MinGuiScale = 0.85f;

	[Token(Token = "0x4000207")]
	private const float MaxGuiScale = 2.4f;

	[Token(Token = "0x4000208")]
	private const float MinUserScale = 0.2f;

	[Token(Token = "0x4000209")]
	private const float MaxUserScale = 1.4f;

	[Token(Token = "0x400020A")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 _scrollPos;

	[Token(Token = "0x400020B")]
	[FieldOffset(Offset = "0x28")]
	private float _guiScale;

	[Token(Token = "0x400020C")]
	[FieldOffset(Offset = "0x2C")]
	private float _userScale;

	[Token(Token = "0x400020D")]
	[FieldOffset(Offset = "0x30")]
	private GUIStyle _titleStyle;

	[Token(Token = "0x400020E")]
	[FieldOffset(Offset = "0x38")]
	private GUIStyle _sectionStyle;

	[Token(Token = "0x400020F")]
	[FieldOffset(Offset = "0x40")]
	private GUIStyle _statusStyle;

	[Token(Token = "0x4000210")]
	[FieldOffset(Offset = "0x48")]
	private GUIStyle _buttonStyle;

	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x50")]
	private GUIStyle _closeButtonStyle;

	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x58")]
	private GUIStyle _floatingEntryStyle;

	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x60")]
	private GUIStyle _verticalScrollbarStyle;

	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x68")]
	private GUIStyle _verticalScrollbarThumbStyle;

	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0x70")]
	private GUIStyle _scaleSliderStyle;

	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0x78")]
	private GUIStyle _scaleSliderThumbStyle;

	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0x80")]
	private float _cachedScale;

	[Token(Token = "0x4000218")]
	[FieldOffset(Offset = "0x88")]
	private Font gmFont;

	[Token(Token = "0x1700001D")]
	public static bool ShowFloatingEntry
	{
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x3D1C1B4", Offset = "0x3D181B4", VA = "0x3D1C1B4")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x3D1C1FC", Offset = "0x3D181FC", VA = "0x3D1C1FC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public static bool ShowWindow
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x3D1C24C", Offset = "0x3D1824C", VA = "0x3D1C24C")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x3D1C294", Offset = "0x3D18294", VA = "0x3D1C294")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x3D17C18", Offset = "0x3D13C18", VA = "0x3D17C18")]
	public static void Toggle()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x3D1C3F4", Offset = "0x3D183F4", VA = "0x3D1C3F4")]
	private static void CloseMainGmPanel()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x3D1C2E4", Offset = "0x3D182E4", VA = "0x3D1C2E4")]
	public static void EnsureCreated()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x3D1C41C", Offset = "0x3D1841C", VA = "0x3D1C41C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x3D1D848", Offset = "0x3D19848", VA = "0x3D1D848")]
	private void DrawFloatingEntry()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x3D1D978", Offset = "0x3D19978", VA = "0x3D1D978")]
	private void DrawFullWindow()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x3D1C51C", Offset = "0x3D1851C", VA = "0x3D1C51C")]
	private void EnsureStyles()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x3D1F79C", Offset = "0x3D1B79C", VA = "0x3D1F79C")]
	private static float CalculateAutoGuiScale()
	{
		return default;
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x3D1DC24", Offset = "0x3D19C24", VA = "0x3D1DC24")]
	private void DrawScaleSlider()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x3D1DF00", Offset = "0x3D19F00", VA = "0x3D1DF00")]
	private void DrawContent()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x3D1F830", Offset = "0x3D1B830", VA = "0x3D1F830")]
	private static string BuildDiscountShopSummary(MysteryAdventureManager manager)
	{
		return null;
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x3D1FB44", Offset = "0x3D1BB44", VA = "0x3D1FB44")]
	public MysteryAdventureGmWindow()
	{
	}
}
