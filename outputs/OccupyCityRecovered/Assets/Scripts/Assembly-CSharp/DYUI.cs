using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000032")]
public class DYUI : MonoBehaviour
{
	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI titleText;

	[Token(Token = "0x40000CD")]
	private const string title_side = "侧边栏进入奖励";

	[Token(Token = "0x40000CE")]
	private const string title_addTable = "桌面进入奖励";

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x28")]
	public SideUI SideUI;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x30")]
	public AddTableUI AddTableUI;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x38")]
	public Button CloseButton;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x40")]
	private DailyTask _dailyTask_Side;

	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x48")]
	private DailyTask _dailyTask_AddTable;

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x3D04C20", Offset = "0x3D00C20", VA = "0x3D04C20")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x3D04D24", Offset = "0x3D00D24", VA = "0x3D04D24")]
	public void ShowSide()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x3D04F30", Offset = "0x3D00F30", VA = "0x3D04F30")]
	public void ShowTable()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x3D05074", Offset = "0x3D01074", VA = "0x3D05074")]
	public bool IsGiveSideReward()
	{
		return default;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x3D05098", Offset = "0x3D01098", VA = "0x3D05098")]
	public bool IsGiveAddTableReward()
	{
		return default;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x3D050BC", Offset = "0x3D010BC", VA = "0x3D050BC")]
	public void GiveSideReward()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x3D051A0", Offset = "0x3D011A0", VA = "0x3D051A0")]
	public void GiveAddTableReward()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x3D05284", Offset = "0x3D01284", VA = "0x3D05284")]
	public DYUI()
	{
	}
}
