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
	[Token(Token = "0x2000867")]
	public class DownCardUIComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000868")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__47 : IAsyncStateMachine
		{
			[Token(Token = "0x4003FA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003FA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003FA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DownCardUIComponents _003C_003E4__this;

			[Token(Token = "0x4003FAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002F3B")]
			[Address(RVA = "0x402CD78", Offset = "0x4028D78", VA = "0x402CD78", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002F3C")]
			[Address(RVA = "0x402CFF0", Offset = "0x4028FF0", VA = "0x402CFF0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003FA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformDownCardUI;

		[Token(Token = "0x4003FA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageDownCardUI;

		[Token(Token = "0x4003FA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformImgIcon;

		[Token(Token = "0x4003FA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgIcon;

		[Token(Token = "0x4003FA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtDes;

		[Token(Token = "0x1700058C")]
		public RectTransform RectTransformDownCardUI
		{
			[Token(Token = "0x6002F30")]
			[Address(RVA = "0x402C6CC", Offset = "0x40286CC", VA = "0x402C6CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700058D")]
		public Image ImageDownCardUI
		{
			[Token(Token = "0x6002F31")]
			[Address(RVA = "0x402C900", Offset = "0x4028900", VA = "0x402C900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700058E")]
		public RectTransform RectTransformImgIcon
		{
			[Token(Token = "0x6002F32")]
			[Address(RVA = "0x402C9A4", Offset = "0x40289A4", VA = "0x402C9A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700058F")]
		public Image ImageImgIcon
		{
			[Token(Token = "0x6002F33")]
			[Address(RVA = "0x402C838", Offset = "0x4028838", VA = "0x402C838")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000590")]
		public TextMeshProUGUI TextMeshProUGUITxtDes
		{
			[Token(Token = "0x6002F34")]
			[Address(RVA = "0x402C770", Offset = "0x4028770", VA = "0x402C770")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002F35")]
		[Address(RVA = "0x402CC24", Offset = "0x4028C24", VA = "0x402CC24")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002F36")]
		[Address(RVA = "0x402B410", Offset = "0x4027410", VA = "0x402B410", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002F37")]
		[Address(RVA = "0x402CC28", Offset = "0x4028C28", VA = "0x402CC28", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__47))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002F38")]
		[Address(RVA = "0x402CCBC", Offset = "0x4028CBC", VA = "0x402CCBC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002F39")]
		[Address(RVA = "0x402B56C", Offset = "0x402756C", VA = "0x402B56C")]
		public DownCardUIComponents()
		{
		}
	}
}
