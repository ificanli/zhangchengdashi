using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000880")]
	public class ForgingDetailsItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000881")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__75 : IAsyncStateMachine
		{
			[Token(Token = "0x4004054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ForgingDetailsItemComponents _003C_003E4__this;

			[Token(Token = "0x4004057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002FD9")]
			[Address(RVA = "0x403D214", Offset = "0x4039214", VA = "0x403D214", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002FDA")]
			[Address(RVA = "0x403D48C", Offset = "0x403948C", VA = "0x403D48C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400404B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageForgingDetailsItem;

		[Token(Token = "0x400404C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformUnlock;

		[Token(Token = "0x400404D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageIcon;

		[Token(Token = "0x400404E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUIIntroduce;

		[Token(Token = "0x400404F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ButtonExtend _buttonExtendRefresh;

		[Token(Token = "0x4004050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformLockSpine;

		[Token(Token = "0x4004051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SkeletonGraphic _skeletonGraphicLockSpine;

		[Token(Token = "0x4004052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformLock;

		[Token(Token = "0x4004053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUILock;

		[Token(Token = "0x170005A2")]
		public Image ImageForgingDetailsItem
		{
			[Token(Token = "0x6002FC9")]
			[Address(RVA = "0x403CEA8", Offset = "0x4038EA8", VA = "0x403CEA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A3")]
		public RectTransform RectTransformUnlock
		{
			[Token(Token = "0x6002FCA")]
			[Address(RVA = "0x4039FC4", Offset = "0x4035FC4", VA = "0x4039FC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A4")]
		public Image ImageIcon
		{
			[Token(Token = "0x6002FCB")]
			[Address(RVA = "0x403BCE0", Offset = "0x4037CE0", VA = "0x403BCE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A5")]
		public TextMeshProUGUI TextMeshProUGUIIntroduce
		{
			[Token(Token = "0x6002FCC")]
			[Address(RVA = "0x403BDA8", Offset = "0x4037DA8", VA = "0x403BDA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A6")]
		public ButtonExtend ButtonExtendRefresh
		{
			[Token(Token = "0x6002FCD")]
			[Address(RVA = "0x403CF58", Offset = "0x4038F58", VA = "0x403CF58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A7")]
		public RectTransform RectTransformLockSpine
		{
			[Token(Token = "0x6002FCE")]
			[Address(RVA = "0x403BA88", Offset = "0x4037A88", VA = "0x403BA88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A8")]
		public SkeletonGraphic SkeletonGraphicLockSpine
		{
			[Token(Token = "0x6002FCF")]
			[Address(RVA = "0x403A204", Offset = "0x4036204", VA = "0x403A204")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A9")]
		public RectTransform RectTransformLock
		{
			[Token(Token = "0x6002FD0")]
			[Address(RVA = "0x403BB50", Offset = "0x4037B50", VA = "0x403BB50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005AA")]
		public TextMeshProUGUI TextMeshProUGUILock
		{
			[Token(Token = "0x6002FD1")]
			[Address(RVA = "0x403BC18", Offset = "0x4037C18", VA = "0x403BC18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002FD2")]
		[Address(RVA = "0x403D020", Offset = "0x4039020", VA = "0x403D020")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002FD3")]
		[Address(RVA = "0x403A7FC", Offset = "0x40367FC", VA = "0x403A7FC", Slot = "12")]
		protected virtual void OnButtonExtendRefreshClicked()
		{
		}

		[Token(Token = "0x6002FD4")]
		[Address(RVA = "0x403D0A8", Offset = "0x40390A8", VA = "0x403D0A8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002FD5")]
		[Address(RVA = "0x403D0C4", Offset = "0x40390C4", VA = "0x403D0C4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__75))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002FD6")]
		[Address(RVA = "0x403D158", Offset = "0x4039158", VA = "0x403D158", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002FD7")]
		[Address(RVA = "0x403A638", Offset = "0x4036638", VA = "0x403A638")]
		public ForgingDetailsItemComponents()
		{
		}
	}
}
