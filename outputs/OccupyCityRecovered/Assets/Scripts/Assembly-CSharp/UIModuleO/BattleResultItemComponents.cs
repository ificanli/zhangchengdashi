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
	[Token(Token = "0x2000706")]
	public class BattleResultItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000707")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__114 : IAsyncStateMachine
		{
			[Token(Token = "0x40037DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40037DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40037DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleResultItemComponents _003C_003E4__this;

			[Token(Token = "0x40037DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002624")]
			[Address(RVA = "0x3F8D8BC", Offset = "0x3F898BC", VA = "0x3F8D8BC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002625")]
			[Address(RVA = "0x3F8DB34", Offset = "0x3F89B34", VA = "0x3F8DB34", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40037D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformBattleResultItem;

		[Token(Token = "0x40037D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendBattleResultItem;

		[Token(Token = "0x40037D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtDes;

		[Token(Token = "0x40037D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtAddNum;

		[Token(Token = "0x40037D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformImgIcon;

		[Token(Token = "0x40037D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageImgIcon;

		[Token(Token = "0x40037D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageImgProgressBg;

		[Token(Token = "0x40037D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageImgProgress;

		[Token(Token = "0x40037D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtProgressNum;

		[Token(Token = "0x170002E4")]
		public RectTransform RectTransformBattleResultItem
		{
			[Token(Token = "0x6002614")]
			[Address(RVA = "0x3F8C468", Offset = "0x3F88468", VA = "0x3F8C468")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E5")]
		public ButtonExtend ButtonExtendBattleResultItem
		{
			[Token(Token = "0x6002615")]
			[Address(RVA = "0x3F8D6B8", Offset = "0x3F896B8", VA = "0x3F8D6B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E6")]
		public TextMeshProUGUI TextMeshProUGUITxtDes
		{
			[Token(Token = "0x6002616")]
			[Address(RVA = "0x3F8D2C4", Offset = "0x3F892C4", VA = "0x3F8D2C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E7")]
		public TextMeshProUGUI TextMeshProUGUITxtAddNum
		{
			[Token(Token = "0x6002617")]
			[Address(RVA = "0x3F8D38C", Offset = "0x3F8938C", VA = "0x3F8D38C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E8")]
		public RectTransform RectTransformImgIcon
		{
			[Token(Token = "0x6002618")]
			[Address(RVA = "0x3F8D134", Offset = "0x3F89134", VA = "0x3F8D134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E9")]
		public Image ImageImgIcon
		{
			[Token(Token = "0x6002619")]
			[Address(RVA = "0x3F8D5E4", Offset = "0x3F895E4", VA = "0x3F8D5E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002EA")]
		public Image ImageImgProgressBg
		{
			[Token(Token = "0x600261A")]
			[Address(RVA = "0x3F8D1FC", Offset = "0x3F891FC", VA = "0x3F8D1FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002EB")]
		public Image ImageImgProgress
		{
			[Token(Token = "0x600261B")]
			[Address(RVA = "0x3F8D454", Offset = "0x3F89454", VA = "0x3F8D454")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002EC")]
		public TextMeshProUGUI TextMeshProUGUITxtProgressNum
		{
			[Token(Token = "0x600261C")]
			[Address(RVA = "0x3F8D51C", Offset = "0x3F8951C", VA = "0x3F8D51C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600261D")]
		[Address(RVA = "0x3F8D75C", Offset = "0x3F8975C", VA = "0x3F8D75C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600261E")]
		[Address(RVA = "0x3F8C3FC", Offset = "0x3F883FC", VA = "0x3F8C3FC", Slot = "12")]
		protected virtual void OnButtonExtendBattleResultItemClicked()
		{
		}

		[Token(Token = "0x600261F")]
		[Address(RVA = "0x3F8D7E4", Offset = "0x3F897E4", VA = "0x3F8D7E4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002620")]
		[Address(RVA = "0x3F8C520", Offset = "0x3F88520", VA = "0x3F8C520", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__114))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002621")]
		[Address(RVA = "0x3F8D800", Offset = "0x3F89800", VA = "0x3F8D800", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002622")]
		[Address(RVA = "0x3F8C514", Offset = "0x3F88514", VA = "0x3F8C514")]
		public BattleResultItemComponents()
		{
		}
	}
}
