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
	[Token(Token = "0x2000B21")]
	public class BtnBuyDiamondItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B22")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__108 : IAsyncStateMachine
		{
			[Token(Token = "0x400514D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400514E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400514F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnBuyDiamondItemComponents _003C_003E4__this;

			[Token(Token = "0x4005150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60043B3")]
			[Address(RVA = "0x41E0C84", Offset = "0x41DCC84", VA = "0x41E0C84", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60043B4")]
			[Address(RVA = "0x41E0EFC", Offset = "0x41DCEFC", VA = "0x41E0EFC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnBuyDiamondItem;

		[Token(Token = "0x4005147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformImgDiamondIcon;

		[Token(Token = "0x4005148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgDiamondIcon;

		[Token(Token = "0x4005149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtName;

		[Token(Token = "0x400514A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtPriceNum;

		[Token(Token = "0x400514B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtDiamondNum;

		[Token(Token = "0x400514C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageDoubleGem;

		[Token(Token = "0x17000B08")]
		public ButtonExtend ButtonExtendBtnBuyDiamondItem
		{
			[Token(Token = "0x60043A5")]
			[Address(RVA = "0x41E09EC", Offset = "0x41DC9EC", VA = "0x41E09EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B09")]
		public RectTransform RectTransformImgDiamondIcon
		{
			[Token(Token = "0x60043A6")]
			[Address(RVA = "0x41E0850", Offset = "0x41DC850", VA = "0x41E0850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B0A")]
		public Image ImageImgDiamondIcon
		{
			[Token(Token = "0x60043A7")]
			[Address(RVA = "0x41E0918", Offset = "0x41DC918", VA = "0x41E0918")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B0B")]
		public TextMeshProUGUI TextMeshProUGUITxtName
		{
			[Token(Token = "0x60043A8")]
			[Address(RVA = "0x41E0788", Offset = "0x41DC788", VA = "0x41E0788")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B0C")]
		public TextMeshProUGUI TextMeshProUGUITxtPriceNum
		{
			[Token(Token = "0x60043A9")]
			[Address(RVA = "0x41E06C0", Offset = "0x41DC6C0", VA = "0x41E06C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B0D")]
		public TextMeshProUGUI TextMeshProUGUITxtDiamondNum
		{
			[Token(Token = "0x60043AA")]
			[Address(RVA = "0x41E05F8", Offset = "0x41DC5F8", VA = "0x41E05F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B0E")]
		public Image ImageDoubleGem
		{
			[Token(Token = "0x60043AB")]
			[Address(RVA = "0x41DF9DC", Offset = "0x41DB9DC", VA = "0x41DF9DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60043AC")]
		[Address(RVA = "0x41E0A90", Offset = "0x41DCA90", VA = "0x41E0A90")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60043AD")]
		[Address(RVA = "0x41DF85C", Offset = "0x41DB85C", VA = "0x41DF85C", Slot = "12")]
		protected virtual void OnButtonExtendBtnBuyDiamondItemClicked()
		{
		}

		[Token(Token = "0x60043AE")]
		[Address(RVA = "0x41E0B18", Offset = "0x41DCB18", VA = "0x41E0B18", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60043AF")]
		[Address(RVA = "0x41E0B34", Offset = "0x41DCB34", VA = "0x41E0B34", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__108))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60043B0")]
		[Address(RVA = "0x41E0BC8", Offset = "0x41DCBC8", VA = "0x41E0BC8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60043B1")]
		[Address(RVA = "0x41DFD04", Offset = "0x41DBD04", VA = "0x41DFD04")]
		public BtnBuyDiamondItemComponents()
		{
		}
	}
}
