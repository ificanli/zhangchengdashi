using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommonGameModule.Email;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UIModuleO;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000047")]
public class EmailDetalUI : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct _003CAwake_003Ed__9 : IAsyncStateMachine
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmailDetalUI _003C_003E4__this;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x3D08F8C", Offset = "0x3D04F8C", VA = "0x3D08F8C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x3D09308", Offset = "0x3D05308", VA = "0x3D09308", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI content;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject rewardItemUIPrefab;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RectTransform RewardContent;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject CloseBtn;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Button GetButton;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI GetText;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private EmailData _curShowingEmail;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<RewardItemUI> _rewardItemUIs;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Action OnClose;

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x3D0821C", Offset = "0x3D0421C", VA = "0x3D0821C")]
	[AsyncStateMachine(typeof(_003CAwake_003Ed__9))]
	private void Awake()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x3D082AC", Offset = "0x3D042AC", VA = "0x3D082AC")]
	public void Show(EmailData emailData)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x3D08718", Offset = "0x3D04718", VA = "0x3D08718")]
	private void FitContentHeight()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x3D087B4", Offset = "0x3D047B4", VA = "0x3D087B4")]
	public void InitReward()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x3D08C10", Offset = "0x3D04C10", VA = "0x3D08C10")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x3D08C74", Offset = "0x3D04C74", VA = "0x3D08C74")]
	private void Close()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x3D08D30", Offset = "0x3D04D30", VA = "0x3D08D30")]
	private void GetSingle()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x3D08B88", Offset = "0x3D04B88", VA = "0x3D08B88")]
	private string FixAttachment()
	{
		return null;
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x3D08F84", Offset = "0x3D04F84", VA = "0x3D08F84")]
	public EmailDetalUI()
	{
	}
}
