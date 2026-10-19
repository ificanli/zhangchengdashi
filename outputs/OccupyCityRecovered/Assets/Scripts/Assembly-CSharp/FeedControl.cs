using Il2CppDummyDll;
using L_Tools;

[Token(Token = "0x2000034")]
public class FeedControl : SingletonComponent<FeedControl>
{
	[Token(Token = "0x40000D9")]
	private const string SubSceneNames_offline = "CONTENT13809255938";

	[Token(Token = "0x40000DA")]
	private const string SubSceneName_box = "CONTENT13464453634";

	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x20")]
	private new bool isInit;

	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x21")]
	private bool hasSub;

	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x24")]
	public FeedEnum EnterEntry;

	[Token(Token = "0x1700000C")]
	public bool isGetSubReward
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x3D055E0", Offset = "0x3D015E0", VA = "0x3D055E0")]
		get
		{
			return default;
		}
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x3D05658", Offset = "0x3D01658", VA = "0x3D05658")]
		set
		{
		}
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x3D052B0", Offset = "0x3D012B0", VA = "0x3D052B0")]
	public void SwitchFeedUI_box(bool isShow)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x3D05448", Offset = "0x3D01448", VA = "0x3D05448")]
	public void SwitchFeedUI_offline(bool isShow)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x3D056D4", Offset = "0x3D016D4", VA = "0x3D056D4")]
	public void Init()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x3D056D8", Offset = "0x3D016D8", VA = "0x3D056D8")]
	public bool IsSub()
	{
		return default;
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x3D056E0", Offset = "0x3D016E0", VA = "0x3D056E0")]
	public void Sub()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x3D056E4", Offset = "0x3D016E4", VA = "0x3D056E4")]
	private void OnSuccess()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x3D05B98", Offset = "0x3D01B98", VA = "0x3D05B98")]
	public void GiveReward()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x3D05CA4", Offset = "0x3D01CA4", VA = "0x3D05CA4")]
	private void OnFail()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x3D05D54", Offset = "0x3D01D54", VA = "0x3D05D54")]
	public void OnGameInitFinish_Box()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x3D05E1C", Offset = "0x3D01E1C", VA = "0x3D05E1C")]
	public void OnGameInitFinish_OfflineEarnings()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x3D05EE4", Offset = "0x3D01EE4", VA = "0x3D05EE4")]
	public void OnGameInitFinish_FirstGame()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x3D05F4C", Offset = "0x3D01F4C", VA = "0x3D05F4C")]
	public void SubToServer_Box(int min)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x3D05F50", Offset = "0x3D01F50", VA = "0x3D05F50")]
	public void SubToServer_OfflineEarnings(int min)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x3D05F54", Offset = "0x3D01F54", VA = "0x3D05F54")]
	public void DeleteSubToServer_Box()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x3D05F58", Offset = "0x3D01F58", VA = "0x3D05F58")]
	public void DeleteSubToServer_OfflineEarnings()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x3D05F5C", Offset = "0x3D01F5C", VA = "0x3D05F5C")]
	public FeedControl()
	{
	}
}
