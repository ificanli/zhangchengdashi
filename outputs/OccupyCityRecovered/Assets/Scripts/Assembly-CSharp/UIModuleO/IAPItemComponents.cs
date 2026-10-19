using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;

namespace UIModuleO
{
	[Token(Token = "0x200091E")]
	public class IAPItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200091F")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__69 : IAsyncStateMachine
		{
			[Token(Token = "0x400447A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400447B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400447C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IAPItemComponents _003C_003E4__this;

			[Token(Token = "0x400447D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60034C1")]
			[Address(RVA = "0x40AC710", Offset = "0x40A8710", VA = "0x40AC710", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60034C2")]
			[Address(RVA = "0x40AC988", Offset = "0x40A8988", VA = "0x40AC988", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI _textMeshProUGUIName;

		[Token(Token = "0x4004477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUIPrice;

		[Token(Token = "0x4004478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUIID;

		[Token(Token = "0x4004479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendGetBtn;

		[Token(Token = "0x1700074D")]
		public TextMeshProUGUI TextMeshProUGUIName
		{
			[Token(Token = "0x60034B6")]
			[Address(RVA = "0x40ABE30", Offset = "0x40A7E30", VA = "0x40ABE30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700074E")]
		public TextMeshProUGUI TextMeshProUGUIPrice
		{
			[Token(Token = "0x60034B7")]
			[Address(RVA = "0x40ABEF8", Offset = "0x40A7EF8", VA = "0x40ABEF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700074F")]
		public TextMeshProUGUI TextMeshProUGUIID
		{
			[Token(Token = "0x60034B8")]
			[Address(RVA = "0x40ABFC0", Offset = "0x40A7FC0", VA = "0x40ABFC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000750")]
		public ButtonExtend ButtonExtendGetBtn
		{
			[Token(Token = "0x60034B9")]
			[Address(RVA = "0x40AC454", Offset = "0x40A8454", VA = "0x40AC454")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60034BA")]
		[Address(RVA = "0x40AC51C", Offset = "0x40A851C", VA = "0x40AC51C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60034BB")]
		[Address(RVA = "0x40AC3D8", Offset = "0x40A83D8", VA = "0x40AC3D8", Slot = "12")]
		protected virtual void OnButtonExtendGetBtnClicked()
		{
		}

		[Token(Token = "0x60034BC")]
		[Address(RVA = "0x40AC5A4", Offset = "0x40A85A4", VA = "0x40AC5A4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60034BD")]
		[Address(RVA = "0x40AC5C0", Offset = "0x40A85C0", VA = "0x40AC5C0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__69))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60034BE")]
		[Address(RVA = "0x40AC654", Offset = "0x40A8654", VA = "0x40AC654", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60034BF")]
		[Address(RVA = "0x40AC44C", Offset = "0x40A844C", VA = "0x40AC44C")]
		public IAPItemComponents()
		{
		}
	}
}
