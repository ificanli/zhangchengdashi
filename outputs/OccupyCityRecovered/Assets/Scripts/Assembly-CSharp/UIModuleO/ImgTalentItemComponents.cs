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
	[Token(Token = "0x20007CD")]
	public class ImgTalentItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007CE")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__90 : IAsyncStateMachine
		{
			[Token(Token = "0x4003C56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003C57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003C58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ImgTalentItemComponents _003C_003E4__this;

			[Token(Token = "0x4003C59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002B49")]
			[Address(RVA = "0x3FEA9A8", Offset = "0x3FE69A8", VA = "0x3FEA9A8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002B4A")]
			[Address(RVA = "0x3FEAC20", Offset = "0x3FE6C20", VA = "0x3FEAC20", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003C50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendImgTalentItem;

		[Token(Token = "0x4003C51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgTalentIcon;

		[Token(Token = "0x4003C52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgBlack;

		[Token(Token = "0x4003C53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtTalentName;

		[Token(Token = "0x4003C54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageImgLock;

		[Token(Token = "0x4003C55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageRedDot_UI;

		[Token(Token = "0x17000482")]
		public ButtonExtend ButtonExtendImgTalentItem
		{
			[Token(Token = "0x6002B3C")]
			[Address(RVA = "0x3FEA72C", Offset = "0x3FE672C", VA = "0x3FEA72C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000483")]
		public Image ImageImgTalentIcon
		{
			[Token(Token = "0x6002B3D")]
			[Address(RVA = "0x3FEA658", Offset = "0x3FE6658", VA = "0x3FEA658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000484")]
		public Image ImageImgBlack
		{
			[Token(Token = "0x6002B3E")]
			[Address(RVA = "0x3FEA4C8", Offset = "0x3FE64C8", VA = "0x3FEA4C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000485")]
		public TextMeshProUGUI TextMeshProUGUITxtTalentName
		{
			[Token(Token = "0x6002B3F")]
			[Address(RVA = "0x3FE9838", Offset = "0x3FE5838", VA = "0x3FE9838")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000486")]
		public Image ImageImgLock
		{
			[Token(Token = "0x6002B40")]
			[Address(RVA = "0x3FEA400", Offset = "0x3FE6400", VA = "0x3FEA400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000487")]
		public Image ImageRedDot_UI
		{
			[Token(Token = "0x6002B41")]
			[Address(RVA = "0x3FEA590", Offset = "0x3FE6590", VA = "0x3FEA590")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B42")]
		[Address(RVA = "0x3FEA7D0", Offset = "0x3FE67D0", VA = "0x3FEA7D0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002B43")]
		[Address(RVA = "0x3FE9A64", Offset = "0x3FE5A64", VA = "0x3FE9A64", Slot = "12")]
		protected virtual void OnButtonExtendImgTalentItemClicked()
		{
		}

		[Token(Token = "0x6002B44")]
		[Address(RVA = "0x3FE9488", Offset = "0x3FE5488", VA = "0x3FE9488", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002B45")]
		[Address(RVA = "0x3FEA858", Offset = "0x3FE6858", VA = "0x3FEA858", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__90))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002B46")]
		[Address(RVA = "0x3FEA8EC", Offset = "0x3FE68EC", VA = "0x3FEA8EC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002B47")]
		[Address(RVA = "0x3FE9C00", Offset = "0x3FE5C00", VA = "0x3FE9C00")]
		public ImgTalentItemComponents()
		{
		}
	}
}
