using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UIModuleO.UIAnim;

namespace UIModuleO
{
	[Token(Token = "0x2000AB7")]
	public class ProptemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AB8")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__111 : IAsyncStateMachine
		{
			[Token(Token = "0x4004EDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004EDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004EDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ProptemComponents _003C_003E4__this;

			[Token(Token = "0x4004EE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60040C1")]
			[Address(RVA = "0x41AE974", Offset = "0x41AA974", VA = "0x41AE974", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60040C2")]
			[Address(RVA = "0x41AEBEC", Offset = "0x41AABEC", VA = "0x41AEBEC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004EDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendProptem;

		[Token(Token = "0x17000A2A")]
		public ButtonExtend ButtonExtendProptem
		{
			[Token(Token = "0x60040B9")]
			[Address(RVA = "0x41AE668", Offset = "0x41AA668", VA = "0x41AE668")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60040BA")]
		[Address(RVA = "0x41AE70C", Offset = "0x41AA70C", VA = "0x41AE70C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60040BB")]
		[Address(RVA = "0x41AE794", Offset = "0x41AA794", VA = "0x41AE794", Slot = "12")]
		protected virtual void OnButtonExtendProptemClicked()
		{
		}

		[Token(Token = "0x60040BC")]
		[Address(RVA = "0x41AE800", Offset = "0x41AA800", VA = "0x41AE800", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60040BD")]
		[Address(RVA = "0x41AE81C", Offset = "0x41AA81C", VA = "0x41AE81C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__111))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60040BE")]
		[Address(RVA = "0x41AE8B0", Offset = "0x41AA8B0", VA = "0x41AE8B0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60040BF")]
		[Address(RVA = "0x41AE964", Offset = "0x41AA964", VA = "0x41AE964")]
		public ProptemComponents()
		{
		}
	}
}
