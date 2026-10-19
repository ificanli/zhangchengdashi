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
	[Token(Token = "0x20008AB")]
	public class SwitchFundBtnComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008AC")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__66 : IAsyncStateMachine
		{
			[Token(Token = "0x4004189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400418A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400418B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SwitchFundBtnComponents _003C_003E4__this;

			[Token(Token = "0x400418C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003111")]
			[Address(RVA = "0x40574F0", Offset = "0x40534F0", VA = "0x40574F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003112")]
			[Address(RVA = "0x4057768", Offset = "0x4053768", VA = "0x4057768", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageSwitchFundBtn;

		[Token(Token = "0x4004185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendSwitchFundBtn;

		[Token(Token = "0x4004186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BadgeButton _badgeButtonSwitchFundBtn;

		[Token(Token = "0x4004187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageIcon;

		[Token(Token = "0x4004188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIText;

		[Token(Token = "0x1700061A")]
		public Image ImageSwitchFundBtn
		{
			[Token(Token = "0x6003105")]
			[Address(RVA = "0x40569A4", Offset = "0x40529A4", VA = "0x40569A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700061B")]
		public ButtonExtend ButtonExtendSwitchFundBtn
		{
			[Token(Token = "0x6003106")]
			[Address(RVA = "0x40572EC", Offset = "0x40532EC", VA = "0x40572EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700061C")]
		public BadgeButton BadgeButtonSwitchFundBtn
		{
			[Token(Token = "0x6003107")]
			[Address(RVA = "0x405723C", Offset = "0x405323C", VA = "0x405723C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700061D")]
		public Image ImageIcon
		{
			[Token(Token = "0x6003108")]
			[Address(RVA = "0x4056CEC", Offset = "0x4052CEC", VA = "0x4056CEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700061E")]
		public TextMeshProUGUI TextMeshProUGUIText
		{
			[Token(Token = "0x6003109")]
			[Address(RVA = "0x4057174", Offset = "0x4053174", VA = "0x4057174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600310A")]
		[Address(RVA = "0x4057390", Offset = "0x4053390", VA = "0x4057390")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600310B")]
		[Address(RVA = "0x40565F8", Offset = "0x40525F8", VA = "0x40565F8", Slot = "12")]
		protected virtual void OnButtonExtendSwitchFundBtnClicked()
		{
		}

		[Token(Token = "0x600310C")]
		[Address(RVA = "0x4057418", Offset = "0x4053418", VA = "0x4057418", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600310D")]
		[Address(RVA = "0x4056678", Offset = "0x4052678", VA = "0x4056678", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__66))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600310E")]
		[Address(RVA = "0x4057434", Offset = "0x4053434", VA = "0x4057434", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600310F")]
		[Address(RVA = "0x405666C", Offset = "0x405266C", VA = "0x405666C")]
		public SwitchFundBtnComponents()
		{
		}
	}
}
