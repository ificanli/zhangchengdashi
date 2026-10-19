using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000BDB")]
	public class UpgradeMainTowerPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BDC")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__71 : IAsyncStateMachine
		{
			[Token(Token = "0x4005617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UpgradeMainTowerPanelComponents _003C_003E4__this;

			[Token(Token = "0x400561A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600494C")]
			[Address(RVA = "0x4246954", Offset = "0x4242954", VA = "0x4246954", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600494D")]
			[Address(RVA = "0x4246BCC", Offset = "0x4242BCC", VA = "0x4246BCC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformUIRoot;

		[Token(Token = "0x4005613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CanvasGroup _canvasGroupUIRoot;

		[Token(Token = "0x4005614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageLock;

		[Token(Token = "0x4005615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUIFeatureName;

		[Token(Token = "0x4005616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIUnlockConditions;

		[Token(Token = "0x17000CC6")]
		public RectTransform RectTransformUIRoot
		{
			[Token(Token = "0x6004941")]
			[Address(RVA = "0x42466E4", Offset = "0x42426E4", VA = "0x42466E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CC7")]
		public CanvasGroup CanvasGroupUIRoot
		{
			[Token(Token = "0x6004942")]
			[Address(RVA = "0x4245978", Offset = "0x4241978", VA = "0x4245978")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CC8")]
		public Image ImageLock
		{
			[Token(Token = "0x6004943")]
			[Address(RVA = "0x424661C", Offset = "0x424261C", VA = "0x424661C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CC9")]
		public TextMeshProUGUI TextMeshProUGUIFeatureName
		{
			[Token(Token = "0x6004944")]
			[Address(RVA = "0x42467AC", Offset = "0x42427AC", VA = "0x42467AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CCA")]
		public TextMeshProUGUI TextMeshProUGUIUnlockConditions
		{
			[Token(Token = "0x6004945")]
			[Address(RVA = "0x4246874", Offset = "0x4242874", VA = "0x4246874")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004946")]
		[Address(RVA = "0x4246948", Offset = "0x4242948", VA = "0x4246948")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004947")]
		[Address(RVA = "0x42458BC", Offset = "0x42418BC", VA = "0x42458BC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004948")]
		[Address(RVA = "0x42458C8", Offset = "0x42418C8", VA = "0x42458C8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__71))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004949")]
		[Address(RVA = "0x4245424", Offset = "0x4241424", VA = "0x4245424", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600494A")]
		[Address(RVA = "0x42458AC", Offset = "0x42418AC", VA = "0x42458AC")]
		public UpgradeMainTowerPanelComponents()
		{
		}
	}
}
