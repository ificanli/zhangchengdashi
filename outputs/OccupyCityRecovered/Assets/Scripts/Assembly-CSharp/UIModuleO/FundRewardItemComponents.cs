using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200089D")]
	public class FundRewardItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200089E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__94 : IAsyncStateMachine
		{
			[Token(Token = "0x4004149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400414A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400414B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FundRewardItemComponents _003C_003E4__this;

			[Token(Token = "0x400414C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60030CC")]
			[Address(RVA = "0x405389C", Offset = "0x404F89C", VA = "0x405389C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60030CD")]
			[Address(RVA = "0x4053B14", Offset = "0x404FB14", VA = "0x4053B14", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ScrollRect _scrollRectAllItems;

		[Token(Token = "0x4004145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ClickDragDetector _clickDragDetectorAllItems;

		[Token(Token = "0x4004146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x4004147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformFundRewardItemUI;

		[Token(Token = "0x4004148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ButtonExtend _buttonExtendClaimBtn;

		[Token(Token = "0x17000604")]
		public ScrollRect ScrollRectAllItems
		{
			[Token(Token = "0x60030BF")]
			[Address(RVA = "0x4053564", Offset = "0x404F564", VA = "0x4053564")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000605")]
		public ClickDragDetector ClickDragDetectorAllItems
		{
			[Token(Token = "0x60030C0")]
			[Address(RVA = "0x4051BB8", Offset = "0x404DBB8", VA = "0x4051BB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000606")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x60030C1")]
			[Address(RVA = "0x40529C8", Offset = "0x404E9C8", VA = "0x40529C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000607")]
		public RectTransform RectTransformFundRewardItemUI
		{
			[Token(Token = "0x60030C2")]
			[Address(RVA = "0x4052900", Offset = "0x404E900", VA = "0x4052900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000608")]
		public ButtonExtend ButtonExtendClaimBtn
		{
			[Token(Token = "0x60030C3")]
			[Address(RVA = "0x405349C", Offset = "0x404F49C", VA = "0x405349C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60030C4")]
		[Address(RVA = "0x4053638", Offset = "0x404F638", VA = "0x4053638")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60030C5")]
		[Address(RVA = "0x405372C", Offset = "0x404F72C", VA = "0x405372C", Slot = "12")]
		protected virtual void OnScrollRectAllItemsValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x60030C6")]
		[Address(RVA = "0x40523A0", Offset = "0x404E3A0", VA = "0x40523A0", Slot = "13")]
		protected virtual void OnButtonExtendClaimBtnClicked()
		{
		}

		[Token(Token = "0x60030C7")]
		[Address(RVA = "0x4051B9C", Offset = "0x404DB9C", VA = "0x4051B9C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60030C8")]
		[Address(RVA = "0x4052C14", Offset = "0x404EC14", VA = "0x4052C14", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__94))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60030C9")]
		[Address(RVA = "0x40537E0", Offset = "0x404F7E0", VA = "0x40537E0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60030CA")]
		[Address(RVA = "0x4052C08", Offset = "0x404EC08", VA = "0x4052C08")]
		public FundRewardItemComponents()
		{
		}
	}
}
