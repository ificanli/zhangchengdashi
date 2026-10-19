using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DataModule
{
	[Token(Token = "0x2000E24")]
	public class SaveConflictCanvas : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E26")]
		[CompilerGenerated]
		private struct _003COpenSaveConflictCanvas_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x40062A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40062AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40062AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<bool> btnCallback;

			[Token(Token = "0x40062AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CompareResult compareResult;

			[Token(Token = "0x40062AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40062AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6005724")]
			[Address(RVA = "0x434CAF8", Offset = "0x4348AF8", VA = "0x434CAF8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005725")]
			[Address(RVA = "0x434D138", Offset = "0x4349138", VA = "0x434D138", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400629C")]
		private const string ResourcePath = "Assets/_Res/Addressable/01FirstBundle/Prefabs/UI/Panels/SaveConflictCanvas.prefab";

		[Token(Token = "0x400629D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameObject _cachedPrefab;

		[Token(Token = "0x400629E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static SaveConflictCanvas _instance;

		[Token(Token = "0x400629F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool _isCreating;

		[Token(Token = "0x40062A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SaveDataPanel localPanel;

		[Token(Token = "0x40062A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SaveDataPanel serverPanel;

		[Token(Token = "0x40062A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject WaitingPanel;

		[Token(Token = "0x40062A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject ConfirmPanel;

		[Token(Token = "0x40062A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Button ConfirmBtn;

		[Token(Token = "0x40062A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI ConfirmText;

		[Token(Token = "0x40062A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action<bool> _btnCallback;

		[Token(Token = "0x6005718")]
		[Address(RVA = "0x434C550", Offset = "0x4348550", VA = "0x434C550")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005719")]
		[Address(RVA = "0x434C5B8", Offset = "0x43485B8", VA = "0x434C5B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600571A")]
		[Address(RVA = "0x434C650", Offset = "0x4348650", VA = "0x434C650")]
		[AsyncStateMachine(typeof(_003COpenSaveConflictCanvas_003Ed__13))]
		public static void OpenSaveConflictCanvas(Action<bool> btnCallback, CompareResult compareResult)
		{
		}

		[Token(Token = "0x600571B")]
		[Address(RVA = "0x434C6F0", Offset = "0x43486F0", VA = "0x434C6F0")]
		private void ApplyContent([Optional] Action<bool> btnCallback, [Optional] CompareResult compareResult)
		{
		}

		[Token(Token = "0x600571C")]
		[Address(RVA = "0x434C76C", Offset = "0x434876C", VA = "0x434C76C")]
		public void ApplyData(CompareResult compareResult)
		{
		}

		[Token(Token = "0x600571D")]
		[Address(RVA = "0x434C864", Offset = "0x4348864", VA = "0x434C864")]
		private void OnChoice(bool isLocal)
		{
		}

		[Token(Token = "0x600571E")]
		[Address(RVA = "0x434CA38", Offset = "0x4348A38", VA = "0x434CA38")]
		public static void ExitGame()
		{
		}

		[Token(Token = "0x600571F")]
		[Address(RVA = "0x434CA8C", Offset = "0x4348A8C", VA = "0x434CA8C")]
		public SaveConflictCanvas()
		{
		}
	}
}
