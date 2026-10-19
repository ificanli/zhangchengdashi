using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000831")]
	public class ExpressionViewLoopItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000832")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__82 : IAsyncStateMachine
		{
			[Token(Token = "0x4003E6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003E70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003E71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ExpressionViewLoopItemComponents _003C_003E4__this;

			[Token(Token = "0x4003E72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002DE3")]
			[Address(RVA = "0x4014494", Offset = "0x4010494", VA = "0x4014494", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002DE4")]
			[Address(RVA = "0x401470C", Offset = "0x401070C", VA = "0x401470C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003E69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformPitchOn;

		[Token(Token = "0x4003E6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendPitchOnButton;

		[Token(Token = "0x4003E6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageBg;

		[Token(Token = "0x4003E6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Button _buttonBg;

		[Token(Token = "0x4003E6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformSpine;

		[Token(Token = "0x4003E6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SkeletonGraphic _skeletonGraphicSpine;

		[Token(Token = "0x1700052A")]
		public RectTransform RectTransformPitchOn
		{
			[Token(Token = "0x6002DD5")]
			[Address(RVA = "0x4012228", Offset = "0x400E228", VA = "0x4012228")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700052B")]
		public ButtonExtend ButtonExtendPitchOnButton
		{
			[Token(Token = "0x6002DD6")]
			[Address(RVA = "0x40140C4", Offset = "0x40100C4", VA = "0x40140C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700052C")]
		public Image ImageBg
		{
			[Token(Token = "0x6002DD7")]
			[Address(RVA = "0x4012D78", Offset = "0x400ED78", VA = "0x4012D78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700052D")]
		public Button ButtonBg
		{
			[Token(Token = "0x6002DD8")]
			[Address(RVA = "0x401418C", Offset = "0x401018C", VA = "0x401418C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700052E")]
		public RectTransform RectTransformSpine
		{
			[Token(Token = "0x6002DD9")]
			[Address(RVA = "0x401331C", Offset = "0x400F31C", VA = "0x401331C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700052F")]
		public SkeletonGraphic SkeletonGraphicSpine
		{
			[Token(Token = "0x6002DDA")]
			[Address(RVA = "0x4012630", Offset = "0x400E630", VA = "0x4012630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002DDB")]
		[Address(RVA = "0x4014254", Offset = "0x4010254", VA = "0x4014254")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002DDC")]
		[Address(RVA = "0x4011B44", Offset = "0x400DB44", VA = "0x4011B44", Slot = "12")]
		protected virtual void OnButtonExtendPitchOnButtonClicked()
		{
		}

		[Token(Token = "0x6002DDD")]
		[Address(RVA = "0x4011DD8", Offset = "0x400DDD8", VA = "0x4011DD8", Slot = "13")]
		protected virtual void OnButtonBgClicked()
		{
		}

		[Token(Token = "0x6002DDE")]
		[Address(RVA = "0x4014328", Offset = "0x4010328", VA = "0x4014328", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002DDF")]
		[Address(RVA = "0x4014344", Offset = "0x4010344", VA = "0x4014344", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__82))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002DE0")]
		[Address(RVA = "0x40143D8", Offset = "0x40103D8", VA = "0x40143D8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002DE1")]
		[Address(RVA = "0x4012804", Offset = "0x400E804", VA = "0x4012804")]
		public ExpressionViewLoopItemComponents()
		{
		}
	}
}
