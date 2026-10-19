using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x2000484")]
	public class BackpackManager : ManagerBase<BackpackManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000487")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4002B17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002B18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x6001635")]
			[Address(RVA = "0x3E28448", Offset = "0x3E24448", VA = "0x3E28448", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001636")]
			[Address(RVA = "0x3E284FC", Offset = "0x3E244FC", VA = "0x3E284FC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600162A")]
		[Address(RVA = "0x3E270C0", Offset = "0x3E230C0", VA = "0x3E270C0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__0))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x600162B")]
		[Address(RVA = "0x3E27140", Offset = "0x3E23140", VA = "0x3E27140")]
		public List<BackpackData> GetAllBackpackDatas()
		{
			return null;
		}

		[Token(Token = "0x600162C")]
		[Address(RVA = "0x3E27320", Offset = "0x3E23320", VA = "0x3E27320")]
		public List<BackpackData> GetUniversalCardData()
		{
			return null;
		}

		[Token(Token = "0x600162D")]
		[Address(RVA = "0x3E27B58", Offset = "0x3E23B58", VA = "0x3E27B58")]
		public List<BackpackData> GetChestBoxData()
		{
			return null;
		}

		[Token(Token = "0x600162E")]
		[Address(RVA = "0x3E281E0", Offset = "0x3E241E0", VA = "0x3E281E0")]
		public BackpackManager()
		{
		}
	}
}
