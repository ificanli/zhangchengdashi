using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000AAF")]
	public class PropLotteryItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AB0")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__77 : IAsyncStateMachine
		{
			[Token(Token = "0x4004EAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004EAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004EAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropLotteryItemComponents _003C_003E4__this;

			[Token(Token = "0x4004EAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004086")]
			[Address(RVA = "0x41AA2B8", Offset = "0x41A62B8", VA = "0x41AA2B8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004087")]
			[Address(RVA = "0x41AA530", Offset = "0x41A6530", VA = "0x41AA530", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004EA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformEffectRoot;

		[Token(Token = "0x4004EA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgBg;

		[Token(Token = "0x4004EA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformImgIcon;

		[Token(Token = "0x4004EA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgIcon;

		[Token(Token = "0x4004EA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIItemCount;

		[Token(Token = "0x17000A14")]
		public RectTransform RectTransformEffectRoot
		{
			[Token(Token = "0x600407B")]
			[Address(RVA = "0x41AA088", Offset = "0x41A6088", VA = "0x41AA088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A15")]
		public Image ImageImgBg
		{
			[Token(Token = "0x600407C")]
			[Address(RVA = "0x41A9EF8", Offset = "0x41A5EF8", VA = "0x41A9EF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A16")]
		public RectTransform RectTransformImgIcon
		{
			[Token(Token = "0x600407D")]
			[Address(RVA = "0x41A9FC0", Offset = "0x41A5FC0", VA = "0x41A9FC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A17")]
		public Image ImageImgIcon
		{
			[Token(Token = "0x600407E")]
			[Address(RVA = "0x41A8A3C", Offset = "0x41A4A3C", VA = "0x41A8A3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A18")]
		public TextMeshProUGUI TextMeshProUGUIItemCount
		{
			[Token(Token = "0x600407F")]
			[Address(RVA = "0x41A8780", Offset = "0x41A4780", VA = "0x41A8780")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004080")]
		[Address(RVA = "0x41AA15C", Offset = "0x41A615C", VA = "0x41AA15C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004081")]
		[Address(RVA = "0x41AA160", Offset = "0x41A6160", VA = "0x41AA160", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004082")]
		[Address(RVA = "0x41AA168", Offset = "0x41A6168", VA = "0x41AA168", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__77))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004083")]
		[Address(RVA = "0x41AA1FC", Offset = "0x41A61FC", VA = "0x41AA1FC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004084")]
		[Address(RVA = "0x41A8DF0", Offset = "0x41A4DF0", VA = "0x41A8DF0")]
		public PropLotteryItemComponents()
		{
		}
	}
}
