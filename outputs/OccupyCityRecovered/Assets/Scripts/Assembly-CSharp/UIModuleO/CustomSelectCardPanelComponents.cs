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
	[Token(Token = "0x2000853")]
	public class CustomSelectCardPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000854")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__84 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CustomSelectCardPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003F4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002EDC")]
			[Address(RVA = "0x40270F8", Offset = "0x40230F8", VA = "0x40270F8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002EDD")]
			[Address(RVA = "0x4027370", Offset = "0x4023370", VA = "0x4027370", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003F43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x4003F44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformRoot;

		[Token(Token = "0x4003F45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftName;

		[Token(Token = "0x4003F46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformRewardRoot;

		[Token(Token = "0x17000575")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x6002ED1")]
			[Address(RVA = "0x4026FA0", Offset = "0x4022FA0", VA = "0x4026FA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000576")]
		public RectTransform RectTransformRoot
		{
			[Token(Token = "0x6002ED2")]
			[Address(RVA = "0x40256AC", Offset = "0x40216AC", VA = "0x40256AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000577")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftName
		{
			[Token(Token = "0x6002ED3")]
			[Address(RVA = "0x4026E04", Offset = "0x4022E04", VA = "0x4026E04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000578")]
		public RectTransform RectTransformRewardRoot
		{
			[Token(Token = "0x6002ED4")]
			[Address(RVA = "0x4026ECC", Offset = "0x4022ECC", VA = "0x4026ECC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002ED5")]
		[Address(RVA = "0x4027068", Offset = "0x4023068", VA = "0x4027068")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002ED6")]
		[Address(RVA = "0x4025534", Offset = "0x4021534", VA = "0x4025534", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6002ED7")]
		[Address(RVA = "0x4025814", Offset = "0x4021814", VA = "0x4025814", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002ED8")]
		[Address(RVA = "0x4025834", Offset = "0x4021834", VA = "0x4025834", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__84))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002ED9")]
		[Address(RVA = "0x40259CC", Offset = "0x40219CC", VA = "0x40259CC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002EDA")]
		[Address(RVA = "0x40257F0", Offset = "0x40217F0", VA = "0x40257F0")]
		public CustomSelectCardPanelComponents()
		{
		}
	}
}
