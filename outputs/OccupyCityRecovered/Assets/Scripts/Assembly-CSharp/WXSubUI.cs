using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200007B")]
public class WXSubUI : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct _003CWait2Sec_003Ed__17 : IAsyncStateMachine
	{
		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WXSubUI _003C_003E4__this;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private object _003C_003Eu__1;

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x3D220D8", Offset = "0x3D1E0D8", VA = "0x3D220D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x3D222FC", Offset = "0x3D1E2FC", VA = "0x3D222FC", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static WXSubUI Instance;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject PopUI;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Button CloseBtn;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Button ClickBtn;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI ClickText;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI RewardText;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Button BGMask;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private DailyTask _dailyTask_wx_share;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int rewardId;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int rewardNum;

	[Token(Token = "0x4000247")]
	private const string DailyTaskKey = "WX_Sub_Reward";

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x3D21A3C", Offset = "0x3D1DA3C", VA = "0x3D21A3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x3D21B84", Offset = "0x3D1DB84", VA = "0x3D21B84")]
	public bool IsGiveSideReward()
	{
		return default;
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x3D21BAC", Offset = "0x3D1DBAC", VA = "0x3D21BAC")]
	public void GiveSideReward()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x3D21B40", Offset = "0x3D1DB40", VA = "0x3D21B40")]
	private void Hide()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x3D21CFC", Offset = "0x3D1DCFC", VA = "0x3D21CFC")]
	private void RefreshButton()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x3D21EC4", Offset = "0x3D1DEC4", VA = "0x3D21EC4")]
	public void ShowPop()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x3D22028", Offset = "0x3D1E028", VA = "0x3D22028")]
	[AsyncStateMachine(typeof(_003CWait2Sec_003Ed__17))]
	private void Wait2Sec()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x3D220B8", Offset = "0x3D1E0B8", VA = "0x3D220B8")]
	public void ClickToSubGameUpdate()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x3D220BC", Offset = "0x3D1E0BC", VA = "0x3D220BC")]
	public WXSubUI()
	{
	}
}
