using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BadgeGraph;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B98")]
	public class SubMetaSwitchBtnComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B99")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__72 : IAsyncStateMachine
		{
			[Token(Token = "0x400544D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400544E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400544F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SubMetaSwitchBtnComponents _003C_003E4__this;

			[Token(Token = "0x4005450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004722")]
			[Address(RVA = "0x421F290", Offset = "0x421B290", VA = "0x421F290", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004723")]
			[Address(RVA = "0x421F508", Offset = "0x421B508", VA = "0x421F508", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendSubMetaSwitchBtn;

		[Token(Token = "0x400544A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BadgeButton _badgeButtonSubMetaSwitchBtn;

		[Token(Token = "0x400544B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUISubMetaName;

		[Token(Token = "0x400544C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageSubMetaLock;

		[Token(Token = "0x17000C01")]
		public ButtonExtend ButtonExtendSubMetaSwitchBtn
		{
			[Token(Token = "0x6004717")]
			[Address(RVA = "0x421F0A8", Offset = "0x421B0A8", VA = "0x421F0A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C02")]
		public BadgeButton BadgeButtonSubMetaSwitchBtn
		{
			[Token(Token = "0x6004718")]
			[Address(RVA = "0x421E83C", Offset = "0x421A83C", VA = "0x421E83C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C03")]
		public TextMeshProUGUI TextMeshProUGUISubMetaName
		{
			[Token(Token = "0x6004719")]
			[Address(RVA = "0x421EA44", Offset = "0x421AA44", VA = "0x421EA44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C04")]
		public Image ImageSubMetaLock
		{
			[Token(Token = "0x600471A")]
			[Address(RVA = "0x421ED5C", Offset = "0x421AD5C", VA = "0x421ED5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600471B")]
		[Address(RVA = "0x421F14C", Offset = "0x421B14C", VA = "0x421F14C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600471C")]
		[Address(RVA = "0x421ECB0", Offset = "0x421ACB0", VA = "0x421ECB0", Slot = "12")]
		protected virtual void OnButtonExtendSubMetaSwitchBtnClicked()
		{
		}

		[Token(Token = "0x600471D")]
		[Address(RVA = "0x421E820", Offset = "0x421A820", VA = "0x421E820", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600471E")]
		[Address(RVA = "0x421EE28", Offset = "0x421AE28", VA = "0x421EE28", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__72))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600471F")]
		[Address(RVA = "0x421F1D4", Offset = "0x421B1D4", VA = "0x421F1D4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004720")]
		[Address(RVA = "0x421ED24", Offset = "0x421AD24", VA = "0x421ED24")]
		public SubMetaSwitchBtnComponents()
		{
		}
	}
}
