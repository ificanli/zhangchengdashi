using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x200055F")]
	public class RankManager : ManagerBase<RankManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000561")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4002F72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002F73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002F74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RankManager _003C_003E4__this;

			[Token(Token = "0x6001BAF")]
			[Address(RVA = "0x3EBFE08", Offset = "0x3EBBE08", VA = "0x3EBFE08", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001BB0")]
			[Address(RVA = "0x3EC0194", Offset = "0x3EBC194", VA = "0x3EC0194", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x3EBF018", Offset = "0x3EBB018", VA = "0x3EBF018", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__0))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001BA3")]
		[Address(RVA = "0x3EBF09C", Offset = "0x3EBB09C", VA = "0x3EBF09C")]
		private void ShowRankPanel(object o)
		{
		}

		[Token(Token = "0x6001BA4")]
		[Address(RVA = "0x3EBF2EC", Offset = "0x3EBB2EC", VA = "0x3EBF2EC")]
		private void HideRankPanel(object o)
		{
		}

		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0x3EBF2F0", Offset = "0x3EBB2F0", VA = "0x3EBF2F0")]
		public void ChangeHeadShot(string id)
		{
		}

		[Token(Token = "0x6001BA6")]
		[Address(RVA = "0x3EBF434", Offset = "0x3EBB434", VA = "0x3EBF434")]
		public void UpdateRankInfo()
		{
		}

		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x3EBFA10", Offset = "0x3EBBA10", VA = "0x3EBFA10")]
		public void UpdatePlayerRankInfo()
		{
		}

		[Token(Token = "0x6001BA8")]
		[Address(RVA = "0x3EBDE80", Offset = "0x3EB9E80", VA = "0x3EBDE80")]
		public int GetPlayerRankIndex()
		{
			return default;
		}

		[Token(Token = "0x6001BA9")]
		[Address(RVA = "0x3EBFC38", Offset = "0x3EBBC38", VA = "0x3EBFC38")]
		public RankItemData RandomEnemyInfo()
		{
			return null;
		}

		[Token(Token = "0x6001BAA")]
		[Address(RVA = "0x3EBF8E0", Offset = "0x3EBB8E0", VA = "0x3EBF8E0")]
		public void RankInfoSort()
		{
		}

		[Token(Token = "0x6001BAB")]
		[Address(RVA = "0x3EBFD30", Offset = "0x3EBBD30", VA = "0x3EBFD30")]
		public RankManager()
		{
		}
	}
}
