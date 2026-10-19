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
	[Token(Token = "0x200075C")]
	public class BtnChooseBlessItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200075D")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__81 : IAsyncStateMachine
		{
			[Token(Token = "0x40039B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40039B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40039B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnChooseBlessItemComponents _003C_003E4__this;

			[Token(Token = "0x40039B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600284E")]
			[Address(RVA = "0x3FB0AE0", Offset = "0x3FACAE0", VA = "0x3FB0AE0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600284F")]
			[Address(RVA = "0x3FB0D58", Offset = "0x3FACD58", VA = "0x3FB0D58", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40039AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageBtnChooseBlessItem;

		[Token(Token = "0x40039AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendBtnChooseBlessItem;

		[Token(Token = "0x40039AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgIcon;

		[Token(Token = "0x40039AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtTitle;

		[Token(Token = "0x40039B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtDes;

		[Token(Token = "0x40039B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtPrice;

		[Token(Token = "0x1700039A")]
		public Image ImageBtnChooseBlessItem
		{
			[Token(Token = "0x6002841")]
			[Address(RVA = "0x3FB082C", Offset = "0x3FAC82C", VA = "0x3FB082C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700039B")]
		public ButtonExtend ButtonExtendBtnChooseBlessItem
		{
			[Token(Token = "0x6002842")]
			[Address(RVA = "0x3FB08DC", Offset = "0x3FAC8DC", VA = "0x3FB08DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700039C")]
		public Image ImageImgIcon
		{
			[Token(Token = "0x6002843")]
			[Address(RVA = "0x3FB0764", Offset = "0x3FAC764", VA = "0x3FB0764")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700039D")]
		public TextMeshProUGUI TextMeshProUGUITxtTitle
		{
			[Token(Token = "0x6002844")]
			[Address(RVA = "0x3FB050C", Offset = "0x3FAC50C", VA = "0x3FB050C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700039E")]
		public TextMeshProUGUI TextMeshProUGUITxtDes
		{
			[Token(Token = "0x6002845")]
			[Address(RVA = "0x3FB05D4", Offset = "0x3FAC5D4", VA = "0x3FB05D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700039F")]
		public TextMeshProUGUI TextMeshProUGUITxtPrice
		{
			[Token(Token = "0x6002846")]
			[Address(RVA = "0x3FB069C", Offset = "0x3FAC69C", VA = "0x3FB069C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002847")]
		[Address(RVA = "0x3FB0980", Offset = "0x3FAC980", VA = "0x3FB0980")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002848")]
		[Address(RVA = "0x3FAFBE8", Offset = "0x3FABBE8", VA = "0x3FAFBE8", Slot = "12")]
		protected virtual void OnButtonExtendBtnChooseBlessItemClicked()
		{
		}

		[Token(Token = "0x6002849")]
		[Address(RVA = "0x3FB0A08", Offset = "0x3FACA08", VA = "0x3FB0A08", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600284A")]
		[Address(RVA = "0x3FAFC68", Offset = "0x3FABC68", VA = "0x3FAFC68", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__81))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600284B")]
		[Address(RVA = "0x3FB0A24", Offset = "0x3FACA24", VA = "0x3FB0A24", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600284C")]
		[Address(RVA = "0x3FAFC5C", Offset = "0x3FABC5C", VA = "0x3FAFC5C")]
		public BtnChooseBlessItemComponents()
		{
		}
	}
}
