using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000782")]
	public class BtnShowPropComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000783")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__69 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnShowPropComponents _003C_003E4__this;

			[Token(Token = "0x4003A7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002941")]
			[Address(RVA = "0x3FC0918", Offset = "0x3FBC918", VA = "0x3FC0918", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002942")]
			[Address(RVA = "0x3FC0B90", Offset = "0x3FBCB90", VA = "0x3FC0B90", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnShowProp;

		[Token(Token = "0x4003A78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgPropIcon;

		[Token(Token = "0x4003A79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgFrontBg;

		[Token(Token = "0x4003A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtBtnShowProp;

		[Token(Token = "0x170003E1")]
		public ButtonExtend ButtonExtendBtnShowProp
		{
			[Token(Token = "0x6002936")]
			[Address(RVA = "0x3FC0730", Offset = "0x3FBC730", VA = "0x3FC0730")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003E2")]
		public Image ImageImgPropIcon
		{
			[Token(Token = "0x6002937")]
			[Address(RVA = "0x3FC065C", Offset = "0x3FBC65C", VA = "0x3FC065C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003E3")]
		public Image ImageImgFrontBg
		{
			[Token(Token = "0x6002938")]
			[Address(RVA = "0x3FC01D8", Offset = "0x3FBC1D8", VA = "0x3FC01D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003E4")]
		public TextMeshProUGUI TextMeshProUGUITxtBtnShowProp
		{
			[Token(Token = "0x6002939")]
			[Address(RVA = "0x3FC0110", Offset = "0x3FBC110", VA = "0x3FC0110")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600293A")]
		[Address(RVA = "0x3FC07D4", Offset = "0x3FBC7D4", VA = "0x3FC07D4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600293B")]
		[Address(RVA = "0x3FBFB34", Offset = "0x3FBBB34", VA = "0x3FBFB34", Slot = "12")]
		protected virtual void OnButtonExtendBtnShowPropClicked()
		{
		}

		[Token(Token = "0x600293C")]
		[Address(RVA = "0x3FBF8F8", Offset = "0x3FBB8F8", VA = "0x3FBF8F8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600293D")]
		[Address(RVA = "0x3FBFC54", Offset = "0x3FBBC54", VA = "0x3FBFC54", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__69))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600293E")]
		[Address(RVA = "0x3FC085C", Offset = "0x3FBC85C", VA = "0x3FC085C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600293F")]
		[Address(RVA = "0x3FBFC48", Offset = "0x3FBBC48", VA = "0x3FBFC48")]
		public BtnShowPropComponents()
		{
		}
	}
}
