using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x2000557")]
	public class ClimbRankManager : ManagerBase<ClimbRankManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000558")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4002F59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002F5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x6001B91")]
			[Address(RVA = "0x3EBE060", Offset = "0x3EBA060", VA = "0x3EBE060", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001B92")]
			[Address(RVA = "0x3EBE114", Offset = "0x3EBA114", VA = "0x3EBE114", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002F55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _oldDanNum;

		[Token(Token = "0x4002F56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _oldRankIndex;

		[Token(Token = "0x4002F57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _newRankIndex;

		[Token(Token = "0x4002F58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _newDanNum;

		[Token(Token = "0x6001B8B")]
		[Address(RVA = "0x3EBD988", Offset = "0x3EB9988", VA = "0x3EBD988", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__4))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x3EBDA08", Offset = "0x3EB9A08", VA = "0x3EBDA08")]
		public void ShowClimbPanel()
		{
		}

		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x3EBDDE8", Offset = "0x3EB9DE8", VA = "0x3EBDDE8")]
		private void RefreshRecordNowInfo()
		{
		}

		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x3EBDF50", Offset = "0x3EB9F50", VA = "0x3EBDF50")]
		public void RefreshRecordOldDanNum()
		{
		}

		[Token(Token = "0x6001B8F")]
		[Address(RVA = "0x3EBDFC0", Offset = "0x3EB9FC0", VA = "0x3EBDFC0")]
		public void RefreshRecordOldRankIndex()
		{
		}

		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x3EBE018", Offset = "0x3EBA018", VA = "0x3EBE018")]
		public ClimbRankManager()
		{
		}
	}
}
