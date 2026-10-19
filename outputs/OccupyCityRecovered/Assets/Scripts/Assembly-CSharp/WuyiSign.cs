using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000044")]
public class WuyiSign : MonoBehaviour
{
	[Token(Token = "0x2000045")]
	public enum SignState
	{
		[Token(Token = "0x400012C")]
		NotYet = 0,
		[Token(Token = "0x400012D")]
		CanClaim = 1,
		[Token(Token = "0x400012E")]
		Claimed = 2
	}

	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PopUI;

	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x28")]
	public GameObject EnterBtn;

	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x30")]
	private GameObject EnterRed;

	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x38")]
	public Button ClaimBtn;

	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI ClaimBtnText;

	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI LeftTimeText;

	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x50")]
	public wuyiItem[] ItemArray;

	[Token(Token = "0x4000127")]
	private const int ActivityMonth = 5;

	[Token(Token = "0x4000128")]
	private const int ActivityStartDay = 1;

	[Token(Token = "0x4000129")]
	private const int ActivityDayCount = 5;

	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x58")]
	private string[] SignReward;

	[Token(Token = "0x1700000E")]
	private static int ActivityYear
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x3D073E4", Offset = "0x3D033E4", VA = "0x3D073E4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700000F")]
	public long ServerTime
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x3D07470", Offset = "0x3D03470", VA = "0x3D07470")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x3D074C0", Offset = "0x3D034C0", VA = "0x3D074C0")]
	public bool IsSign(int day)
	{
		return default;
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x3D0756C", Offset = "0x3D0356C", VA = "0x3D0756C")]
	public void SetSign(int day, bool isSign)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x3D07614", Offset = "0x3D03614", VA = "0x3D07614")]
	public bool IsActivityNotStart()
	{
		return default;
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x3D076C8", Offset = "0x3D036C8", VA = "0x3D076C8")]
	public bool IsActivityFinished()
	{
		return default;
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x3D07638", Offset = "0x3D03638", VA = "0x3D07638")]
	private long GetDayUnlockTimestamp(int day)
	{
		return default;
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x3D076EC", Offset = "0x3D036EC", VA = "0x3D076EC")]
	public int CheckDayLeftTime(int day)
	{
		return default;
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x3D07708", Offset = "0x3D03708", VA = "0x3D07708")]
	public SignState GetDayState(int day)
	{
		return default;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x3D07748", Offset = "0x3D03748", VA = "0x3D07748")]
	private int GetCanClaimDay()
	{
		return default;
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x3D0777C", Offset = "0x3D0377C", VA = "0x3D0777C")]
	public static void ResetAllData()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x3D07890", Offset = "0x3D03890", VA = "0x3D07890")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x3D078BC", Offset = "0x3D038BC", VA = "0x3D078BC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x3D07CDC", Offset = "0x3D03CDC", VA = "0x3D07CDC")]
	public void ShowPanel()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x3D07F40", Offset = "0x3D03F40", VA = "0x3D07F40")]
	public void HidePanel()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x3D07DAC", Offset = "0x3D03DAC", VA = "0x3D07DAC")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x3D07F6C", Offset = "0x3D03F6C", VA = "0x3D07F6C")]
	private void CliamReward()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x3D080F8", Offset = "0x3D040F8", VA = "0x3D080F8")]
	public WuyiSign()
	{
	}
}
