using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000ACE")]
	public class RedDot_UIComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000ACF")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__53 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RedDot_UIComponents _003C_003E4__this;

			[Token(Token = "0x4004F5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600414E")]
			[Address(RVA = "0x41B8A04", Offset = "0x41B4A04", VA = "0x41B8A04", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600414F")]
			[Address(RVA = "0x41B8C7C", Offset = "0x41B4C7C", VA = "0x41B8C7C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004F56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformRedDotImage_Number;

		[Token(Token = "0x4004F57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUINumber;

		[Token(Token = "0x4004F58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformRedDotImage_ExclamationMark;

		[Token(Token = "0x17000A53")]
		public RectTransform RectTransformRedDotImage_Number
		{
			[Token(Token = "0x6004145")]
			[Address(RVA = "0x41B83EC", Offset = "0x41B43EC", VA = "0x41B83EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A54")]
		public TextMeshProUGUI TextMeshProUGUINumber
		{
			[Token(Token = "0x6004146")]
			[Address(RVA = "0x41B8500", Offset = "0x41B4500", VA = "0x41B8500")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A55")]
		public RectTransform RectTransformRedDotImage_ExclamationMark
		{
			[Token(Token = "0x6004147")]
			[Address(RVA = "0x41B8324", Offset = "0x41B4324", VA = "0x41B8324")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004148")]
		[Address(RVA = "0x41B893C", Offset = "0x41B493C", VA = "0x41B893C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004149")]
		[Address(RVA = "0x41B8940", Offset = "0x41B4940", VA = "0x41B8940", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600414A")]
		[Address(RVA = "0x41B85DC", Offset = "0x41B45DC", VA = "0x41B85DC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__53))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600414B")]
		[Address(RVA = "0x41B8948", Offset = "0x41B4948", VA = "0x41B8948", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600414C")]
		[Address(RVA = "0x41B85D0", Offset = "0x41B45D0", VA = "0x41B85D0")]
		public RedDot_UIComponents()
		{
		}
	}
}
