using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000AD2")]
	public class RemoveADPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AD3")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__112 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RemoveADPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004F68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004164")]
			[Address(RVA = "0x41B96E8", Offset = "0x41B56E8", VA = "0x41B96E8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004165")]
			[Address(RVA = "0x41B9960", Offset = "0x41B5960", VA = "0x41B9960", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004F61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBg;

		[Token(Token = "0x4004F62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformImgBg;

		[Token(Token = "0x4004F63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private HWIAPButton _hWIAPButtonHWIAPButton;

		[Token(Token = "0x4004F64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendHWIAPButton;

		[Token(Token = "0x17000A56")]
		public ButtonExtend ButtonExtendBg
		{
			[Token(Token = "0x6004158")]
			[Address(RVA = "0x41B9340", Offset = "0x41B5340", VA = "0x41B9340")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A57")]
		public RectTransform RectTransformImgBg
		{
			[Token(Token = "0x6004159")]
			[Address(RVA = "0x41B8D44", Offset = "0x41B4D44", VA = "0x41B8D44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A58")]
		public HWIAPButton HWIAPButtonHWIAPButton
		{
			[Token(Token = "0x600415A")]
			[Address(RVA = "0x41B926C", Offset = "0x41B526C", VA = "0x41B926C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A59")]
		public ButtonExtend ButtonExtendHWIAPButton
		{
			[Token(Token = "0x600415B")]
			[Address(RVA = "0x41B9408", Offset = "0x41B5408", VA = "0x41B9408")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600415C")]
		[Address(RVA = "0x41B94D0", Offset = "0x41B54D0", VA = "0x41B94D0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600415D")]
		[Address(RVA = "0x41B8E2C", Offset = "0x41B4E2C", VA = "0x41B8E2C", Slot = "12")]
		protected virtual void OnButtonExtendBgClicked()
		{
		}

		[Token(Token = "0x600415E")]
		[Address(RVA = "0x41B95A4", Offset = "0x41B55A4", VA = "0x41B95A4", Slot = "13")]
		protected virtual void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x600415F")]
		[Address(RVA = "0x41B9610", Offset = "0x41B5610", VA = "0x41B9610", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004160")]
		[Address(RVA = "0x41B8EC0", Offset = "0x41B4EC0", VA = "0x41B8EC0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__112))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004161")]
		[Address(RVA = "0x41B962C", Offset = "0x41B562C", VA = "0x41B962C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004162")]
		[Address(RVA = "0x41B8EA0", Offset = "0x41B4EA0", VA = "0x41B8EA0")]
		public RemoveADPanelComponents()
		{
		}
	}
}
