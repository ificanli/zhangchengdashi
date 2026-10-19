using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x200071E")]
	public class BoxPanel : BoxPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200071F")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x400386E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400386F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BoxPanel _003C_003E4__this;

			[Token(Token = "0x4003871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4003872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60026CF")]
			[Address(RVA = "0x3F99204", Offset = "0x3F95204", VA = "0x3F99204", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60026D0")]
			[Address(RVA = "0x3F9973C", Offset = "0x3F9573C", VA = "0x3F9973C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60026C9")]
		[Address(RVA = "0x3F98F70", Offset = "0x3F94F70", VA = "0x3F98F70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60026CA")]
		[Address(RVA = "0x3F98FA8", Offset = "0x3F94FA8", VA = "0x3F98FA8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__1))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60026CB")]
		[Address(RVA = "0x3F99044", Offset = "0x3F95044", VA = "0x3F99044", Slot = "13")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x60026CC")]
		[Address(RVA = "0x3F990D0", Offset = "0x3F950D0", VA = "0x3F990D0", Slot = "12")]
		protected override void OnButtonExtendBgClicked()
		{
		}

		[Token(Token = "0x60026CD")]
		[Address(RVA = "0x3F9915C", Offset = "0x3F9515C", VA = "0x3F9915C")]
		public BoxPanel()
		{
		}
	}
}
