using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000077")]
public class GameClubUI : MonoBehaviour
{
	[Token(Token = "0x4000224")]
	[FieldOffset(Offset = "0x0")]
	public static GameClubUI Instance;

	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PopUI;

	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x28")]
	public Button CloseBtn;

	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x30")]
	public Button ClubBtn;

	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI RewardText;

	[Token(Token = "0x4000229")]
	[FieldOffset(Offset = "0x40")]
	public Button BGMask;

	[Token(Token = "0x400022A")]
	[FieldOffset(Offset = "0x48")]
	private DailyTask _dailyTask_wx_share;

	[Token(Token = "0x400022B")]
	[FieldOffset(Offset = "0x50")]
	private int rewardId;

	[Token(Token = "0x400022C")]
	[FieldOffset(Offset = "0x54")]
	private int rewardNum;

	[Token(Token = "0x400022D")]
	private const string DailyTaskKey = "WX_GameClub_Reward";

	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0x8")]
	public static bool isClickClubBtn;

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x3D2079C", Offset = "0x3D1C79C", VA = "0x3D2079C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x3D20898", Offset = "0x3D1C898", VA = "0x3D20898")]
	private void OnClubBtnClick()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x3D20B28", Offset = "0x3D1CB28", VA = "0x3D20B28")]
	public bool IsGiveSideReward()
	{
		return default;
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x3D208F4", Offset = "0x3D1C8F4", VA = "0x3D208F4")]
	public void GiveSideReward()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x3D20B50", Offset = "0x3D1CB50", VA = "0x3D20B50")]
	private void Update()
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x3D20B5C", Offset = "0x3D1CB5C", VA = "0x3D20B5C")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x3D20B54", Offset = "0x3D1CB54", VA = "0x3D20B54")]
	public bool CheckEnterGameClub()
	{
		return default;
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x3D20A44", Offset = "0x3D1CA44", VA = "0x3D20A44")]
	private void RefreshButton()
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x3D20BA0", Offset = "0x3D1CBA0", VA = "0x3D20BA0")]
	public void ShowPop()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x3D20D40", Offset = "0x3D1CD40", VA = "0x3D20D40")]
	public GameClubUI()
	{
	}
}
