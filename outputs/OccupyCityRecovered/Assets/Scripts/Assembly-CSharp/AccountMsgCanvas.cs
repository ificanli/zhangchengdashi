using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200004E")]
public class AccountMsgCanvas : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct _003CSetContent_003Ed__17 : IAsyncStateMachine
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string titleText;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string messageText;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string btnContent;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action btnCallback;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool needShowFeedback;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool isShowBlockUI;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UniTask<GameObject>.Awaiter _003C_003Eu__2;

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x3D0BA14", Offset = "0x3D07A14", VA = "0x3D0BA14", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x3D0C098", Offset = "0x3D08098", VA = "0x3D0C098", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400016B")]
	private const string ResourcePath = "Assets/_Res/Addressable/01FirstBundle/Prefabs/UI/Panels/AccountMsgCanvas.prefab";

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject _cachedPrefab;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static AccountMsgCanvas _instance;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static bool _isCreating;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI title;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI message;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject feedbackBtnRoot;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Button feedbackBtn;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Button btn;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private TextMeshProUGUI btnText;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject userProtocolBtnRoot;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Button userProtocolBtn;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Action _btnCallback;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool isShowBlockUI;

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x3D0B550", Offset = "0x3D07550", VA = "0x3D0B550")]
	private void Awake()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x3D0B6C4", Offset = "0x3D076C4", VA = "0x3D0B6C4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x3D0B75C", Offset = "0x3D0775C", VA = "0x3D0B75C")]
	private void OnClickExit()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x3D0B7A4", Offset = "0x3D077A4", VA = "0x3D0B7A4")]
	[AsyncStateMachine(typeof(_003CSetContent_003Ed__17))]
	public static void SetContent(string titleText, string messageText, string btnContent, Action btnCallback, bool needShowFeedback = false, bool isShowBlockUI = false)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x3D0B878", Offset = "0x3D07878", VA = "0x3D0B878")]
	private void ApplyContent(string titleText, string messageText, string btnContent, Action btnCallback, bool needShowFeedback)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x3D0B9B8", Offset = "0x3D079B8", VA = "0x3D0B9B8")]
	public static void ExitGame()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x3D0BA0C", Offset = "0x3D07A0C", VA = "0x3D0BA0C")]
	public AccountMsgCanvas()
	{
	}
}
