using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using SuperScrollView;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200082A")]
	public class ExpressionViewComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200082B")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__195 : IAsyncStateMachine
		{
			[Token(Token = "0x4003E4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003E4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003E4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ExpressionViewComponents _003C_003E4__this;

			[Token(Token = "0x4003E4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002DBA")]
			[Address(RVA = "0x401187C", Offset = "0x400D87C", VA = "0x401187C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002DBB")]
			[Address(RVA = "0x4011AF4", Offset = "0x400DAF4", VA = "0x4011AF4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003E42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformUsing;

		[Token(Token = "0x4003E43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ExpressionViewUsingItem _expressionViewUsingItemExpressionViewUsingItem1;

		[Token(Token = "0x4003E44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ExpressionViewUsingItem _expressionViewUsingItemExpressionViewUsingItem2;

		[Token(Token = "0x4003E45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ExpressionViewUsingItem _expressionViewUsingItemExpressionViewUsingItem3;

		[Token(Token = "0x4003E46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ExpressionViewUsingItem _expressionViewUsingItemExpressionViewUsingItem4;

		[Token(Token = "0x4003E47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformEmojiTitleBg;

		[Token(Token = "0x4003E48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ScrollRect _scrollRectEmojiScrollView;

		[Token(Token = "0x4003E49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private LoopGridView _loopGridViewEmojiScrollView;

		[Token(Token = "0x4003E4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformReplace;

		[Token(Token = "0x4003E4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private SkeletonGraphic _skeletonGraphicReplaceSpine;

		[Token(Token = "0x17000520")]
		public RectTransform RectTransformUsing
		{
			[Token(Token = "0x6002DA9")]
			[Address(RVA = "0x401067C", Offset = "0x400C67C", VA = "0x401067C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000521")]
		public ExpressionViewUsingItem ExpressionViewUsingItemExpressionViewUsingItem1
		{
			[Token(Token = "0x6002DAA")]
			[Address(RVA = "0x400E4BC", Offset = "0x400A4BC", VA = "0x400E4BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000522")]
		public ExpressionViewUsingItem ExpressionViewUsingItemExpressionViewUsingItem2
		{
			[Token(Token = "0x6002DAB")]
			[Address(RVA = "0x400E584", Offset = "0x400A584", VA = "0x400E584")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000523")]
		public ExpressionViewUsingItem ExpressionViewUsingItemExpressionViewUsingItem3
		{
			[Token(Token = "0x6002DAC")]
			[Address(RVA = "0x400E64C", Offset = "0x400A64C", VA = "0x400E64C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000524")]
		public ExpressionViewUsingItem ExpressionViewUsingItemExpressionViewUsingItem4
		{
			[Token(Token = "0x6002DAD")]
			[Address(RVA = "0x400E714", Offset = "0x400A714", VA = "0x400E714")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000525")]
		public RectTransform RectTransformEmojiTitleBg
		{
			[Token(Token = "0x6002DAE")]
			[Address(RVA = "0x400F844", Offset = "0x400B844", VA = "0x400F844")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000526")]
		public ScrollRect ScrollRectEmojiScrollView
		{
			[Token(Token = "0x6002DAF")]
			[Address(RVA = "0x401165C", Offset = "0x400D65C", VA = "0x401165C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000527")]
		public LoopGridView LoopGridViewEmojiScrollView
		{
			[Token(Token = "0x6002DB0")]
			[Address(RVA = "0x400FBA8", Offset = "0x400BBA8", VA = "0x400FBA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000528")]
		public RectTransform RectTransformReplace
		{
			[Token(Token = "0x6002DB1")]
			[Address(RVA = "0x400F90C", Offset = "0x400B90C", VA = "0x400F90C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000529")]
		public SkeletonGraphic SkeletonGraphicReplaceSpine
		{
			[Token(Token = "0x6002DB2")]
			[Address(RVA = "0x4011588", Offset = "0x400D588", VA = "0x4011588")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002DB3")]
		[Address(RVA = "0x4011724", Offset = "0x400D724", VA = "0x4011724")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002DB4")]
		[Address(RVA = "0x40117C0", Offset = "0x400D7C0", VA = "0x40117C0", Slot = "12")]
		protected virtual void OnScrollRectEmojiScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6002DB5")]
		[Address(RVA = "0x400E4A0", Offset = "0x400A4A0", VA = "0x400E4A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002DB6")]
		[Address(RVA = "0x4010AF0", Offset = "0x400CAF0", VA = "0x4010AF0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__195))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002DB7")]
		[Address(RVA = "0x400EB10", Offset = "0x400AB10", VA = "0x400EB10", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002DB8")]
		[Address(RVA = "0x4010AE4", Offset = "0x400CAE4", VA = "0x4010AE4")]
		public ExpressionViewComponents()
		{
		}
	}
}
