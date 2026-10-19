using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A9D")]
	public class PropDetailsPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A9E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__102 : IAsyncStateMachine
		{
			[Token(Token = "0x4004E4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004E4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004E4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropDetailsPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004E50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004016")]
			[Address(RVA = "0x41A21B8", Offset = "0x419E1B8", VA = "0x41A21B8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004017")]
			[Address(RVA = "0x41A2430", Offset = "0x419E430", VA = "0x41A2430", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004E46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Canvas _canvasPropDetailsPanel;

		[Token(Token = "0x4004E47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformTouchBack;

		[Token(Token = "0x4004E48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendTouchBack;

		[Token(Token = "0x4004E49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformBubble;

		[Token(Token = "0x4004E4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIName;

		[Token(Token = "0x4004E4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUIHint;

		[Token(Token = "0x4004E4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageArrows;

		[Token(Token = "0x170009F2")]
		public Canvas CanvasPropDetailsPanel
		{
			[Token(Token = "0x6004008")]
			[Address(RVA = "0x419FE80", Offset = "0x419BE80", VA = "0x419FE80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F3")]
		public RectTransform RectTransformTouchBack
		{
			[Token(Token = "0x6004009")]
			[Address(RVA = "0x41A10B8", Offset = "0x419D0B8", VA = "0x41A10B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F4")]
		public ButtonExtend ButtonExtendTouchBack
		{
			[Token(Token = "0x600400A")]
			[Address(RVA = "0x41A1F90", Offset = "0x419DF90", VA = "0x41A1F90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F5")]
		public RectTransform RectTransformBubble
		{
			[Token(Token = "0x600400B")]
			[Address(RVA = "0x41A0984", Offset = "0x419C984", VA = "0x41A0984")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F6")]
		public TextMeshProUGUI TextMeshProUGUIName
		{
			[Token(Token = "0x600400C")]
			[Address(RVA = "0x41A0F28", Offset = "0x419CF28", VA = "0x41A0F28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F7")]
		public TextMeshProUGUI TextMeshProUGUIHint
		{
			[Token(Token = "0x600400D")]
			[Address(RVA = "0x41A0FF0", Offset = "0x419CFF0", VA = "0x41A0FF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F8")]
		public Image ImageArrows
		{
			[Token(Token = "0x600400E")]
			[Address(RVA = "0x419FDB8", Offset = "0x419BDB8", VA = "0x419FDB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600400F")]
		[Address(RVA = "0x41A2058", Offset = "0x419E058", VA = "0x41A2058")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004010")]
		[Address(RVA = "0x419FFF0", Offset = "0x419BFF0", VA = "0x419FFF0", Slot = "12")]
		protected virtual void OnButtonExtendTouchBackClicked()
		{
		}

		[Token(Token = "0x6004011")]
		[Address(RVA = "0x41A20E0", Offset = "0x419E0E0", VA = "0x41A20E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004012")]
		[Address(RVA = "0x41A198C", Offset = "0x419D98C", VA = "0x41A198C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__102))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004013")]
		[Address(RVA = "0x41A20FC", Offset = "0x419E0FC", VA = "0x41A20FC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004014")]
		[Address(RVA = "0x41A189C", Offset = "0x419D89C", VA = "0x41A189C")]
		public PropDetailsPanelComponents()
		{
		}
	}
}
