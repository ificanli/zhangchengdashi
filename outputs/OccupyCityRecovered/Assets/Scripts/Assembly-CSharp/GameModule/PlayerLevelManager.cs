using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x2000555")]
	public class PlayerLevelManager : ManagerBase<PlayerLevelManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000556")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4002F52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002F53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002F54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PlayerLevelManager _003C_003E4__this;

			[Token(Token = "0x6001B89")]
			[Address(RVA = "0x3EBD7A4", Offset = "0x3EB97A4", VA = "0x3EBD7A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001B8A")]
			[Address(RVA = "0x3EBD97C", Offset = "0x3EB997C", VA = "0x3EBD97C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x3EBD4C4", Offset = "0x3EB94C4", VA = "0x3EBD4C4", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__0))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x3EBD548", Offset = "0x3EB9548", VA = "0x3EBD548")]
		public void InitExpConfigData()
		{
		}

		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x3EBD614", Offset = "0x3EB9614", VA = "0x3EBD614")]
		public void UpdateExpConfigData()
		{
		}

		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x3EBD75C", Offset = "0x3EB975C", VA = "0x3EBD75C")]
		public PlayerLevelManager()
		{
		}
	}
}
