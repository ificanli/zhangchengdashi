using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using TMPro;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200069B")]
	public class ActivityBtnComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200069C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__83 : IAsyncStateMachine
		{
			[Token(Token = "0x400352C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400352D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400352E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ActivityBtnComponents _003C_003E4__this;

			[Token(Token = "0x400352F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60022FD")]
			[Address(RVA = "0x3F40544", Offset = "0x3F3C544", VA = "0x3F40544", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60022FE")]
			[Address(RVA = "0x3F407BC", Offset = "0x3F3C7BC", VA = "0x3F407BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageIcon;

		[Token(Token = "0x4003527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SkeletonGraphic _skeletonGraphicSpineEff;

		[Token(Token = "0x4003528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformNameBg;

		[Token(Token = "0x4003529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUIName;

		[Token(Token = "0x400352A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformCutDowmBG;

		[Token(Token = "0x400352B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUICutDowmText;

		[Token(Token = "0x170001EC")]
		public Image ImageIcon
		{
			[Token(Token = "0x60022F1")]
			[Address(RVA = "0x3F3FF48", Offset = "0x3F3BF48", VA = "0x3F3FF48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001ED")]
		public SkeletonGraphic SkeletonGraphicSpineEff
		{
			[Token(Token = "0x60022F2")]
			[Address(RVA = "0x3F40010", Offset = "0x3F3C010", VA = "0x3F40010")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EE")]
		public RectTransform RectTransformNameBg
		{
			[Token(Token = "0x60022F3")]
			[Address(RVA = "0x3F3F5EC", Offset = "0x3F3B5EC", VA = "0x3F3F5EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EF")]
		public TextMeshProUGUI TextMeshProUGUIName
		{
			[Token(Token = "0x60022F4")]
			[Address(RVA = "0x3F3F524", Offset = "0x3F3B524", VA = "0x3F3F524")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F0")]
		public RectTransform RectTransformCutDowmBG
		{
			[Token(Token = "0x60022F5")]
			[Address(RVA = "0x3F3F2FC", Offset = "0x3F3B2FC", VA = "0x3F3F2FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F1")]
		public TextMeshProUGUI TextMeshProUGUICutDowmText
		{
			[Token(Token = "0x60022F6")]
			[Address(RVA = "0x3F3F870", Offset = "0x3F3B870", VA = "0x3F3F870")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60022F7")]
		[Address(RVA = "0x3F40484", Offset = "0x3F3C484", VA = "0x3F40484")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60022F8")]
		[Address(RVA = "0x3F3F3E0", Offset = "0x3F3B3E0", VA = "0x3F3F3E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60022F9")]
		[Address(RVA = "0x3F3F94C", Offset = "0x3F3B94C", VA = "0x3F3F94C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__83))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60022FA")]
		[Address(RVA = "0x3F40488", Offset = "0x3F3C488", VA = "0x3F40488", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60022FB")]
		[Address(RVA = "0x3F3F940", Offset = "0x3F3B940", VA = "0x3F3F940")]
		public ActivityBtnComponents()
		{
		}
	}
}
