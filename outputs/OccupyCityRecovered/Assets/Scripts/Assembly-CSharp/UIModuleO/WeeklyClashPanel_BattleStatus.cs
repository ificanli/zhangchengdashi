using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000C0D")]
	public class WeeklyClashPanel_BattleStatus : WeeklyClashPanel_BattleStatusComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C0E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x400572B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400572C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400572D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashPanel_BattleStatus _003C_003E4__this;

			[Token(Token = "0x400572E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004AB8")]
			[Address(RVA = "0x425F8E4", Offset = "0x425B8E4", VA = "0x425F8E4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004AB9")]
			[Address(RVA = "0x425FF40", Offset = "0x425BF40", VA = "0x425FF40", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C0F")]
		[CompilerGenerated]
		private struct _003CUpdatePlayerLeaderboardData_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x400572F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x6004ABA")]
			[Address(RVA = "0x425FF4C", Offset = "0x425BF4C", VA = "0x425FF4C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004ABB")]
			[Address(RVA = "0x4260170", Offset = "0x425C170", VA = "0x4260170", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool hadInitLoopView;

		[Token(Token = "0x4005723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string preName;

		[Token(Token = "0x4005724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string spaceUpName;

		[Token(Token = "0x4005725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string spaceDownName;

		[Token(Token = "0x4005726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int itemCount;

		[Token(Token = "0x4005727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool getDataing;

		[Token(Token = "0x4005728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int playerRank;

		[Token(Token = "0x4005729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool getLeaderboardTopOver;

		[Token(Token = "0x400572A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool getPlayerLeaderboardOver;

		[Token(Token = "0x6004AB0")]
		[Address(RVA = "0x425F054", Offset = "0x425B054", VA = "0x425F054", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__9))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004AB1")]
		[Address(RVA = "0x425F0E8", Offset = "0x425B0E8", VA = "0x425F0E8")]
		[AsyncStateMachine(typeof(_003CUpdatePlayerLeaderboardData_003Ed__10))]
		private UniTask UpdatePlayerLeaderboardData(string leaderboardId)
		{
			return default;
		}

		[Token(Token = "0x6004AB2")]
		[Address(RVA = "0x425F168", Offset = "0x425B168", VA = "0x425F168")]
		private void GetAllLeaderboardDataOver()
		{
		}

		[Token(Token = "0x6004AB3")]
		[Address(RVA = "0x425F264", Offset = "0x425B264", VA = "0x425F264")]
		private void UpdateRemainingBattleText()
		{
		}

		[Token(Token = "0x6004AB4")]
		[Address(RVA = "0x425F5B4", Offset = "0x425B5B4", VA = "0x425F5B4", Slot = "13")]
		protected override void OnButtonExtendPVPBtnClicked()
		{
		}

		[Token(Token = "0x6004AB5")]
		[Address(RVA = "0x425F6D8", Offset = "0x425B6D8", VA = "0x425F6D8")]
		public WeeklyClashPanel_BattleStatus()
		{
		}
	}
}
