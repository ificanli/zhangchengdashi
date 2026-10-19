using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x2000452")]
	public class PlayerCustomizationManager : ManagerBase<PlayerCustomizationManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000454")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x60014ED")]
			[Address(RVA = "0x3E0CEC0", Offset = "0x3E08EC0", VA = "0x3E0CEC0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60014EE")]
			[Address(RVA = "0x3E0CF74", Offset = "0x3E08F74", VA = "0x3E0CF74", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60014E4")]
		[Address(RVA = "0x3E0C8E0", Offset = "0x3E088E0", VA = "0x3E0C8E0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__0))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60014E5")]
		[Address(RVA = "0x3E0C960", Offset = "0x3E08960", VA = "0x3E0C960")]
		public void ChangeAiSendEmoji(bool isSend)
		{
		}

		[Token(Token = "0x60014E6")]
		[Address(RVA = "0x3E0C9E8", Offset = "0x3E089E8", VA = "0x3E0C9E8")]
		public void ChangeName(string str)
		{
		}

		[Token(Token = "0x60014E7")]
		[Address(RVA = "0x3E0CD4C", Offset = "0x3E08D4C", VA = "0x3E0CD4C")]
		public void ChangeHeadShot(string id)
		{
		}

		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x3E0CE0C", Offset = "0x3E08E0C", VA = "0x3E0CE0C")]
		public PlayerCustomizationManager()
		{
		}
	}
}
