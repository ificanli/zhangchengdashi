using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000079")]
public class ShareUI : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct _003CWait2Sec_003Ed__16 : IAsyncStateMachine
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ShareUI _003C_003E4__this;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private object _003C_003Eu__1;

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x3D2180C", Offset = "0x3D1D80C", VA = "0x3D2180C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x3D21A30", Offset = "0x3D1DA30", VA = "0x3D21A30", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ShareUI Instance;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject PopUI;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Button CloseBtn;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Button ClickBtn;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI ClickText;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI RewardText;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Button BGMask;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private DailyTask _dailyTask_wx_share;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int rewardId;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int rewardNum;

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x3D21074", Offset = "0x3D1D074", VA = "0x3D21074")]
	private void Awake()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x3D211BC", Offset = "0x3D1D1BC", VA = "0x3D211BC")]
	public bool IsGiveSideReward()
	{
		return default;
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x3D211E4", Offset = "0x3D1D1E4", VA = "0x3D211E4")]
	public void GiveSideReward()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x3D21178", Offset = "0x3D1D178", VA = "0x3D21178")]
	private void Hide()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x3D21334", Offset = "0x3D1D334", VA = "0x3D21334")]
	private void RefreshButton()
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x3D20E58", Offset = "0x3D1CE58", VA = "0x3D20E58")]
	public void ShowPop()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x3D214FC", Offset = "0x3D1D4FC", VA = "0x3D214FC")]
	[AsyncStateMachine(typeof(_003CWait2Sec_003Ed__16))]
	private void Wait2Sec()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x3D2158C", Offset = "0x3D1D58C", VA = "0x3D2158C")]
	private void OnShareBtnClick()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x3D217F0", Offset = "0x3D1D7F0", VA = "0x3D217F0")]
	public ShareUI()
	{
	}
}
