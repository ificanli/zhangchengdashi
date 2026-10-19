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

namespace UIModuleO
{
	[Token(Token = "0x200069F")]
	public class AdRemovalPassPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006A0")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__332 : IAsyncStateMachine
		{
			[Token(Token = "0x4003541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AdRemovalPassPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600231A")]
			[Address(RVA = "0x3F41A28", Offset = "0x3F3DA28", VA = "0x3F41A28", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600231B")]
			[Address(RVA = "0x3F41CA0", Offset = "0x3F3DCA0", VA = "0x3F41CA0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x4003539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformImgBg;

		[Token(Token = "0x400353A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtWoodNum;

		[Token(Token = "0x400353B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x400353C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtGemNum;

		[Token(Token = "0x400353D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftPackName;

		[Token(Token = "0x400353E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private HWIAPButton _hWIAPButtonBtnBuy;

		[Token(Token = "0x400353F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendBtnBuy;

		[Token(Token = "0x4003540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x170001F2")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x6002308")]
			[Address(RVA = "0x3F415D8", Offset = "0x3F3D5D8", VA = "0x3F415D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F3")]
		public RectTransform RectTransformImgBg
		{
			[Token(Token = "0x6002309")]
			[Address(RVA = "0x3F40818", Offset = "0x3F3C818", VA = "0x3F40818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F4")]
		public TextMeshProUGUI TextMeshProUGUITxtWoodNum
		{
			[Token(Token = "0x600230A")]
			[Address(RVA = "0x3F41374", Offset = "0x3F3D374", VA = "0x3F41374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F5")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x600230B")]
			[Address(RVA = "0x3F411E4", Offset = "0x3F3D1E4", VA = "0x3F411E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F6")]
		public TextMeshProUGUI TextMeshProUGUITxtGemNum
		{
			[Token(Token = "0x600230C")]
			[Address(RVA = "0x3F412AC", Offset = "0x3F3D2AC", VA = "0x3F412AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F7")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftPackName
		{
			[Token(Token = "0x600230D")]
			[Address(RVA = "0x3F4143C", Offset = "0x3F3D43C", VA = "0x3F4143C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F8")]
		public HWIAPButton HWIAPButtonBtnBuy
		{
			[Token(Token = "0x600230E")]
			[Address(RVA = "0x3F41504", Offset = "0x3F3D504", VA = "0x3F41504")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F9")]
		public ButtonExtend ButtonExtendBtnBuy
		{
			[Token(Token = "0x600230F")]
			[Address(RVA = "0x3F416A0", Offset = "0x3F3D6A0", VA = "0x3F416A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FA")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6002310")]
			[Address(RVA = "0x3F41768", Offset = "0x3F3D768", VA = "0x3F41768")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002311")]
		[Address(RVA = "0x3F41830", Offset = "0x3F3D830", VA = "0x3F41830")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002312")]
		[Address(RVA = "0x3F41948", Offset = "0x3F3D948", VA = "0x3F41948", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6002313")]
		[Address(RVA = "0x3F419B4", Offset = "0x3F3D9B4", VA = "0x3F419B4", Slot = "13")]
		protected virtual void OnButtonExtendBtnBuyClicked()
		{
		}

		[Token(Token = "0x6002314")]
		[Address(RVA = "0x3F40AA4", Offset = "0x3F3CAA4", VA = "0x3F40AA4", Slot = "14")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6002315")]
		[Address(RVA = "0x3F407FC", Offset = "0x3F3C7FC", VA = "0x3F407FC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002316")]
		[Address(RVA = "0x3F40BB4", Offset = "0x3F3CBB4", VA = "0x3F40BB4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__332))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002317")]
		[Address(RVA = "0x3F409D0", Offset = "0x3F3C9D0", VA = "0x3F409D0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002318")]
		[Address(RVA = "0x3F40B18", Offset = "0x3F3CB18", VA = "0x3F40B18")]
		public AdRemovalPassPanelComponents()
		{
		}
	}
}
