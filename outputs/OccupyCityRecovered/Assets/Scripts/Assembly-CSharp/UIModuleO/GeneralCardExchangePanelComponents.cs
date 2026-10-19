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
	[Token(Token = "0x20008D5")]
	public class GeneralCardExchangePanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008D6")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__300 : IAsyncStateMachine
		{
			[Token(Token = "0x40042F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40042F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40042F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GeneralCardExchangePanelComponents _003C_003E4__this;

			[Token(Token = "0x40042F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60032CB")]
			[Address(RVA = "0x4075FE8", Offset = "0x4071FE8", VA = "0x4075FE8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60032CC")]
			[Address(RVA = "0x4076260", Offset = "0x4072260", VA = "0x4076260", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40042E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBackground;

		[Token(Token = "0x40042E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformContents;

		[Token(Token = "0x40042E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendClose;

		[Token(Token = "0x40042E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITitle;

		[Token(Token = "0x40042E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageCardIcon;

		[Token(Token = "0x40042EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUICardNumber;

		[Token(Token = "0x40042EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ImgIAPCardItem _imgIAPCardItemImgIAPCardItem;

		[Token(Token = "0x40042EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendImgBg;

		[Token(Token = "0x40042ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUIHint;

		[Token(Token = "0x40042EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendAffirmBtn;

		[Token(Token = "0x40042EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUIAffirmText;

		[Token(Token = "0x40042F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageAffirmIcon;

		[Token(Token = "0x170006A5")]
		public Button ButtonBackground
		{
			[Token(Token = "0x60032B5")]
			[Address(RVA = "0x4075AF8", Offset = "0x4071AF8", VA = "0x4075AF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006A6")]
		public RectTransform RectTransformContents
		{
			[Token(Token = "0x60032B6")]
			[Address(RVA = "0x4073FE4", Offset = "0x406FFE4", VA = "0x4073FE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006A7")]
		public ButtonExtend ButtonExtendClose
		{
			[Token(Token = "0x60032B7")]
			[Address(RVA = "0x4075BC0", Offset = "0x4071BC0", VA = "0x4075BC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006A8")]
		public TextMeshProUGUI TextMeshProUGUITitle
		{
			[Token(Token = "0x60032B8")]
			[Address(RVA = "0x4074FB0", Offset = "0x4070FB0", VA = "0x4074FB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006A9")]
		public Image ImageCardIcon
		{
			[Token(Token = "0x60032B9")]
			[Address(RVA = "0x4075704", Offset = "0x4071704", VA = "0x4075704")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006AA")]
		public TextMeshProUGUI TextMeshProUGUICardNumber
		{
			[Token(Token = "0x60032BA")]
			[Address(RVA = "0x4075A24", Offset = "0x4071A24", VA = "0x4075A24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006AB")]
		public ImgIAPCardItem ImgIAPCardItemImgIAPCardItem
		{
			[Token(Token = "0x60032BB")]
			[Address(RVA = "0x407563C", Offset = "0x407163C", VA = "0x407563C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006AC")]
		public ButtonExtend ButtonExtendImgBg
		{
			[Token(Token = "0x60032BC")]
			[Address(RVA = "0x4075C88", Offset = "0x4071C88", VA = "0x4075C88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006AD")]
		public TextMeshProUGUI TextMeshProUGUIHint
		{
			[Token(Token = "0x60032BD")]
			[Address(RVA = "0x4075894", Offset = "0x4071894", VA = "0x4075894")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006AE")]
		public ButtonExtend ButtonExtendAffirmBtn
		{
			[Token(Token = "0x60032BE")]
			[Address(RVA = "0x4075D50", Offset = "0x4071D50", VA = "0x4075D50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006AF")]
		public TextMeshProUGUI TextMeshProUGUIAffirmText
		{
			[Token(Token = "0x60032BF")]
			[Address(RVA = "0x407595C", Offset = "0x407195C", VA = "0x407595C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B0")]
		public Image ImageAffirmIcon
		{
			[Token(Token = "0x60032C0")]
			[Address(RVA = "0x40757CC", Offset = "0x40717CC", VA = "0x40757CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60032C1")]
		[Address(RVA = "0x4075E18", Offset = "0x4071E18", VA = "0x4075E18")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60032C2")]
		[Address(RVA = "0x40741F0", Offset = "0x40701F0", VA = "0x40741F0", Slot = "12")]
		protected virtual void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x60032C3")]
		[Address(RVA = "0x407427C", Offset = "0x407027C", VA = "0x407427C", Slot = "13")]
		protected virtual void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x60032C4")]
		[Address(RVA = "0x4075F74", Offset = "0x4071F74", VA = "0x4075F74", Slot = "14")]
		protected virtual void OnButtonExtendImgBgClicked()
		{
		}

		[Token(Token = "0x60032C5")]
		[Address(RVA = "0x40744EC", Offset = "0x40704EC", VA = "0x40744EC", Slot = "15")]
		protected virtual void OnButtonExtendAffirmBtnClicked()
		{
		}

		[Token(Token = "0x60032C6")]
		[Address(RVA = "0x4073FC8", Offset = "0x406FFC8", VA = "0x4073FC8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60032C7")]
		[Address(RVA = "0x4074454", Offset = "0x4070454", VA = "0x4074454", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__300))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60032C8")]
		[Address(RVA = "0x407438C", Offset = "0x407038C", VA = "0x407438C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60032C9")]
		[Address(RVA = "0x4074448", Offset = "0x4070448", VA = "0x4074448")]
		public GeneralCardExchangePanelComponents()
		{
		}
	}
}
