using System.Runtime.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000BA")]
public class WorldCupGmWindow : MonoBehaviour
{
	[Token(Token = "0x40003D5")]
	[FieldOffset(Offset = "0x0")]
	private static WorldCupGmWindow _instance;

	[Token(Token = "0x40003D8")]
	private const float ReferenceShortSide = 720f;

	[Token(Token = "0x40003D9")]
	private const float MinGuiScale = 2f;

	[Token(Token = "0x40003DA")]
	private const float MinUserScale = 0.5f;

	[Token(Token = "0x40003DB")]
	private const float MaxUserScale = 1.4f;

	[Token(Token = "0x40003DC")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 _scrollPos;

	[Token(Token = "0x40003DD")]
	[FieldOffset(Offset = "0x28")]
	private float _guiScale;

	[Token(Token = "0x40003DE")]
	[FieldOffset(Offset = "0x2C")]
	private float _userScale;

	[Token(Token = "0x40003DF")]
	[FieldOffset(Offset = "0x30")]
	private GUIStyle _titleStyle;

	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0x38")]
	private GUIStyle _sectionStyle;

	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0x40")]
	private GUIStyle _statusStyle;

	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0x48")]
	private GUIStyle _buttonStyle;

	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0x50")]
	private GUIStyle _closeButtonStyle;

	[Token(Token = "0x40003E4")]
	[FieldOffset(Offset = "0x58")]
	private GUIStyle _floatingEntryStyle;

	[Token(Token = "0x40003E5")]
	[FieldOffset(Offset = "0x60")]
	private GUIStyle _verticalScrollbarStyle;

	[Token(Token = "0x40003E6")]
	[FieldOffset(Offset = "0x68")]
	private GUIStyle _verticalScrollbarThumbStyle;

	[Token(Token = "0x40003E7")]
	[FieldOffset(Offset = "0x70")]
	private GUIStyle _scaleSliderStyle;

	[Token(Token = "0x40003E8")]
	[FieldOffset(Offset = "0x78")]
	private GUIStyle _scaleSliderThumbStyle;

	[Token(Token = "0x40003E9")]
	[FieldOffset(Offset = "0x80")]
	private GUIStyle _textFieldStyle;

	[Token(Token = "0x40003EA")]
	[FieldOffset(Offset = "0x88")]
	private float _cachedScale;

	[Token(Token = "0x40003EB")]
	[FieldOffset(Offset = "0x90")]
	private string _footballInput;

	[Token(Token = "0x40003EC")]
	[FieldOffset(Offset = "0x98")]
	private string _scoreInput;

	[Token(Token = "0x17000035")]
	public static bool ShowFloatingEntry
	{
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x3E34F50", Offset = "0x3E30F50", VA = "0x3E34F50")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x3E34F98", Offset = "0x3E30F98", VA = "0x3E34F98")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public static bool ShowWindow
	{
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x3E34FE8", Offset = "0x3E30FE8", VA = "0x3E34FE8")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x3E35030", Offset = "0x3E31030", VA = "0x3E35030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x3E35080", Offset = "0x3E31080", VA = "0x3E35080")]
	public static void Toggle()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x3E35260", Offset = "0x3E31260", VA = "0x3E35260")]
	private static void CloseMainGmPanel()
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x3E35150", Offset = "0x3E31150", VA = "0x3E35150")]
	public static void EnsureCreated()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x3E35288", Offset = "0x3E31288", VA = "0x3E35288")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x3E36AE4", Offset = "0x3E32AE4", VA = "0x3E36AE4")]
	private void DrawFloatingEntry()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x3E36C14", Offset = "0x3E32C14", VA = "0x3E36C14")]
	private void DrawFullWindow()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x3E35388", Offset = "0x3E31388", VA = "0x3E35388")]
	private void EnsureStyles()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x3E36E8C", Offset = "0x3E32E8C", VA = "0x3E36E8C")]
	private void DrawScaleSlider()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x3E37108", Offset = "0x3E33108", VA = "0x3E37108")]
	private void DrawContent()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x3E3853C", Offset = "0x3E3453C", VA = "0x3E3853C")]
	private static string BuildDailyTaskSummary(WorldCupActivityManager manager)
	{
		return null;
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x3E3898C", Offset = "0x3E3498C", VA = "0x3E3898C")]
	public WorldCupGmWindow()
	{
	}
}
