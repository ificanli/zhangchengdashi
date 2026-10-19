using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x20008C0")]
	public class HexDescribesPanel : HexDescribesPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008C1")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4004252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HexDescribesPanel _003C_003E4__this;

			[Token(Token = "0x4004255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003212")]
			[Address(RVA = "0x4069E2C", Offset = "0x4065E2C", VA = "0x4069E2C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003213")]
			[Address(RVA = "0x406C598", Offset = "0x4068598", VA = "0x406C598", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private readonly int[] hexBlanceABXPos;

		[Token(Token = "0x6003209")]
		[Address(RVA = "0x40696E8", Offset = "0x40656E8", VA = "0x40696E8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600320A")]
		[Address(RVA = "0x4069720", Offset = "0x4065720", VA = "0x4069720", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600320B")]
		[Address(RVA = "0x40697B4", Offset = "0x40657B4", VA = "0x40697B4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600320C")]
		[Address(RVA = "0x4069980", Offset = "0x4065980", VA = "0x4069980", Slot = "14")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x600320D")]
		[Address(RVA = "0x4069A0C", Offset = "0x4065A0C", VA = "0x4069A0C", Slot = "13")]
		protected override void OnButtonExtendBtnCheatClicked()
		{
		}

		[Token(Token = "0x600320E")]
		[Address(RVA = "0x4069B50", Offset = "0x4065B50", VA = "0x4069B50", Slot = "12")]
		protected override void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x600320F")]
		[Address(RVA = "0x4069BDC", Offset = "0x4065BDC", VA = "0x4069BDC")]
		public HexDescribesPanel()
		{
		}
	}
}
