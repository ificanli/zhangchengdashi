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
	[Token(Token = "0x20008A5")]
	public class FundRewardItem_LineComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008A6")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__194 : IAsyncStateMachine
		{
			[Token(Token = "0x400416F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FundRewardItem_LineComponents _003C_003E4__this;

			[Token(Token = "0x4004172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60030F7")]
			[Address(RVA = "0x4056284", Offset = "0x4052284", VA = "0x4056284", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60030F8")]
			[Address(RVA = "0x40564FC", Offset = "0x40524FC", VA = "0x40564FC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformTotalItems2;

		[Token(Token = "0x4004165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformTotalItems3;

		[Token(Token = "0x4004166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformNotEnoughBG;

		[Token(Token = "0x4004167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageLineUp_Gray;

		[Token(Token = "0x4004168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageLineDown_Gray;

		[Token(Token = "0x4004169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageLineUp_Color;

		[Token(Token = "0x400416A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageLineDown_Color;

		[Token(Token = "0x400416B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformLevel_Lock;

		[Token(Token = "0x400416C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformLevel_Unlock;

		[Token(Token = "0x400416D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUILevelText;

		[Token(Token = "0x400416E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformCurrentLevelLine;

		[Token(Token = "0x1700060F")]
		public RectTransform RectTransformTotalItems2
		{
			[Token(Token = "0x60030E6")]
			[Address(RVA = "0x4054650", Offset = "0x4050650", VA = "0x4054650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000610")]
		public RectTransform RectTransformTotalItems3
		{
			[Token(Token = "0x60030E7")]
			[Address(RVA = "0x4054718", Offset = "0x4050718", VA = "0x4054718")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000611")]
		public RectTransform RectTransformNotEnoughBG
		{
			[Token(Token = "0x60030E8")]
			[Address(RVA = "0x4055D08", Offset = "0x4051D08", VA = "0x4055D08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000612")]
		public Image ImageLineUp_Gray
		{
			[Token(Token = "0x60030E9")]
			[Address(RVA = "0x4055E98", Offset = "0x4051E98", VA = "0x4055E98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000613")]
		public Image ImageLineDown_Gray
		{
			[Token(Token = "0x60030EA")]
			[Address(RVA = "0x4055DD0", Offset = "0x4051DD0", VA = "0x4055DD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000614")]
		public Image ImageLineUp_Color
		{
			[Token(Token = "0x60030EB")]
			[Address(RVA = "0x4055AB0", Offset = "0x4051AB0", VA = "0x4055AB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000615")]
		public Image ImageLineDown_Color
		{
			[Token(Token = "0x60030EC")]
			[Address(RVA = "0x4055B78", Offset = "0x4051B78", VA = "0x4055B78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000616")]
		public RectTransform RectTransformLevel_Lock
		{
			[Token(Token = "0x60030ED")]
			[Address(RVA = "0x4055F60", Offset = "0x4051F60", VA = "0x4055F60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000617")]
		public RectTransform RectTransformLevel_Unlock
		{
			[Token(Token = "0x60030EE")]
			[Address(RVA = "0x4056028", Offset = "0x4052028", VA = "0x4056028")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000618")]
		public TextMeshProUGUI TextMeshProUGUILevelText
		{
			[Token(Token = "0x60030EF")]
			[Address(RVA = "0x40560F0", Offset = "0x40520F0", VA = "0x40560F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000619")]
		public RectTransform RectTransformCurrentLevelLine
		{
			[Token(Token = "0x60030F0")]
			[Address(RVA = "0x4055C40", Offset = "0x4051C40", VA = "0x4055C40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60030F1")]
		[Address(RVA = "0x40561C4", Offset = "0x40521C4", VA = "0x40561C4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60030F2")]
		[Address(RVA = "0x4054648", Offset = "0x4050648", VA = "0x4054648", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60030F3")]
		[Address(RVA = "0x4054888", Offset = "0x4050888", VA = "0x4054888", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__194))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60030F4")]
		[Address(RVA = "0x40561C8", Offset = "0x40521C8", VA = "0x40561C8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60030F5")]
		[Address(RVA = "0x405487C", Offset = "0x405087C", VA = "0x405487C")]
		public FundRewardItem_LineComponents()
		{
		}
	}
}
