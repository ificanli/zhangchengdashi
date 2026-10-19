using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

namespace DataModule
{
	[Token(Token = "0x2000E9A")]
	public class MapCreateDataManager : ManagerBase<MapCreateDataManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E9B")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x40065C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40065C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40065C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MapCreateDataManager _003C_003E4__this;

			[Token(Token = "0x40065C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60058D6")]
			[Address(RVA = "0x4365F84", Offset = "0x4361F84", VA = "0x4365F84", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60058D7")]
			[Address(RVA = "0x4366378", Offset = "0x4362378", VA = "0x4366378", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E9C")]
		[CompilerGenerated]
		private struct _003CLoadData_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40065C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40065C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40065C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MapCreateDataManager _003C_003E4__this;

			[Token(Token = "0x40065CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60058D8")]
			[Address(RVA = "0x4366384", Offset = "0x4362384", VA = "0x4366384", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60058D9")]
			[Address(RVA = "0x436665C", Offset = "0x436265C", VA = "0x436665C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40065C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isInit;

		[Token(Token = "0x17000F29")]
		public bool LoadDataCompleted
		{
			[Token(Token = "0x60058CF")]
			[Address(RVA = "0x4365E04", Offset = "0x4361E04", VA = "0x4365E04")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x60058D0")]
			[Address(RVA = "0x4365E0C", Offset = "0x4361E0C", VA = "0x4365E0C")]
			[CompilerGenerated]
			private set;
		}

		[Token(Token = "0x17000F2A")]
		public GlobalInfo GlobalInfo
		{
			[Token(Token = "0x60058D1")]
			[Address(RVA = "0x4365E18", Offset = "0x4361E18", VA = "0x4365E18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60058D2")]
			[Address(RVA = "0x4365E20", Offset = "0x4361E20", VA = "0x4365E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60058D3")]
		[Address(RVA = "0x4365E28", Offset = "0x4361E28", VA = "0x4365E28", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__9))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60058D4")]
		[Address(RVA = "0x4365EB4", Offset = "0x4361EB4", VA = "0x4365EB4")]
		[AsyncStateMachine(typeof(_003CLoadData_003Ed__10))]
		private UniTask LoadData()
		{
			return default;
		}

		[Token(Token = "0x60058D5")]
		[Address(RVA = "0x4365F3C", Offset = "0x4361F3C", VA = "0x4365F3C")]
		public MapCreateDataManager()
		{
		}
	}
}
