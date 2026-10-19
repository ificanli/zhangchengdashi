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
	[Token(Token = "0x2000B7F")]
	public class SpecialSummonGiftPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B80")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__101 : IAsyncStateMachine
		{
			[Token(Token = "0x40053CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40053CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40053CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SpecialSummonGiftPanelComponents _003C_003E4__this;

			[Token(Token = "0x40053CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600468E")]
			[Address(RVA = "0x4216900", Offset = "0x4212900", VA = "0x4216900", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600468F")]
			[Address(RVA = "0x4216B78", Offset = "0x4212B78", VA = "0x4216B78", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40053C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendMask;

		[Token(Token = "0x40053C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendCloseBtn;

		[Token(Token = "0x40053C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ScrollRect _scrollRectGiftsScroll;

		[Token(Token = "0x40053C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x40053C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SpecialSummonGiftItem _specialSummonGiftItemGiftItem;

		[Token(Token = "0x17000BE6")]
		public ButtonExtend ButtonExtendMask
		{
			[Token(Token = "0x6004680")]
			[Address(RVA = "0x42163D4", Offset = "0x42123D4", VA = "0x42163D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BE7")]
		public ButtonExtend ButtonExtendCloseBtn
		{
			[Token(Token = "0x6004681")]
			[Address(RVA = "0x421649C", Offset = "0x421249C", VA = "0x421649C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BE8")]
		public ScrollRect ScrollRectGiftsScroll
		{
			[Token(Token = "0x6004682")]
			[Address(RVA = "0x4216564", Offset = "0x4212564", VA = "0x4216564")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BE9")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x6004683")]
			[Address(RVA = "0x4215BAC", Offset = "0x4211BAC", VA = "0x4215BAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BEA")]
		public SpecialSummonGiftItem SpecialSummonGiftItemGiftItem
		{
			[Token(Token = "0x6004684")]
			[Address(RVA = "0x4215AE4", Offset = "0x4211AE4", VA = "0x4215AE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004685")]
		[Address(RVA = "0x421662C", Offset = "0x421262C", VA = "0x421662C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004686")]
		[Address(RVA = "0x421676C", Offset = "0x421276C", VA = "0x421676C", Slot = "12")]
		protected virtual void OnButtonExtendMaskClicked()
		{
		}

		[Token(Token = "0x6004687")]
		[Address(RVA = "0x42167D8", Offset = "0x42127D8", VA = "0x42167D8", Slot = "13")]
		protected virtual void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6004688")]
		[Address(RVA = "0x4216844", Offset = "0x4212844", VA = "0x4216844", Slot = "14")]
		protected virtual void OnScrollRectGiftsScrollValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6004689")]
		[Address(RVA = "0x42154D8", Offset = "0x42114D8", VA = "0x42154D8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600468A")]
		[Address(RVA = "0x4215DEC", Offset = "0x4211DEC", VA = "0x4215DEC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__101))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600468B")]
		[Address(RVA = "0x421593C", Offset = "0x421193C", VA = "0x421593C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600468C")]
		[Address(RVA = "0x4215DE0", Offset = "0x4211DE0", VA = "0x4215DE0")]
		public SpecialSummonGiftPanelComponents()
		{
		}
	}
}
