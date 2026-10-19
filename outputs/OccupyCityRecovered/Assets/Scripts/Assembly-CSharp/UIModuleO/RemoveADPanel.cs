using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000AD0")]
	public class RemoveADPanel : RemoveADPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AD1")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RemoveADPanel _003C_003E4__this;

			[Token(Token = "0x4004F60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004156")]
			[Address(RVA = "0x41B8F54", Offset = "0x41B4F54", VA = "0x41B8F54", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004157")]
			[Address(RVA = "0x41B9334", Offset = "0x41B5334", VA = "0x41B9334", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6004150")]
		[Address(RVA = "0x41B8C88", Offset = "0x41B4C88", VA = "0x41B8C88", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__0))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004151")]
		[Address(RVA = "0x41B8D1C", Offset = "0x41B4D1C", VA = "0x41B8D1C")]
		private void Update()
		{
		}

		[Token(Token = "0x6004152")]
		[Address(RVA = "0x41B8E0C", Offset = "0x41B4E0C", VA = "0x41B8E0C", Slot = "12")]
		protected override void OnButtonExtendBgClicked()
		{
		}

		[Token(Token = "0x6004153")]
		[Address(RVA = "0x41B8E98", Offset = "0x41B4E98", VA = "0x41B8E98")]
		public RemoveADPanel()
		{
		}
	}
}
