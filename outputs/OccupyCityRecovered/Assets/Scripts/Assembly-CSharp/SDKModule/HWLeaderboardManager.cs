using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;

namespace SDKModule
{
	[Token(Token = "0x200017F")]
	public class HWLeaderboardManager : ManagerBase<HWLeaderboardManager>
	{
		[Token(Token = "0x2000180")]
		public class LeaderboardDisplayData
		{
			[Token(Token = "0x4001A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4001A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string headShotId;

			[Token(Token = "0x4001A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<UserHeroCardData> playerCardData;

			[Token(Token = "0x600061E")]
			[Address(RVA = "0x3F767B4", Offset = "0x3F727B4", VA = "0x3F767B4")]
			public LeaderboardDisplayData()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000182")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4001A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HWLeaderboardManager _003C_003E4__this;

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x3F76998", Offset = "0x3F72998", VA = "0x3F76998", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x3F76CD0", Offset = "0x3F72CD0", VA = "0x3F76CD0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001A6C")]
		private const string LeaderboardAroundUser = "LeaderboardAroundUser";

		[Token(Token = "0x4001A6D")]
		private const string LeaderboardTop = "LeaderboardTop";

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x3F76508", Offset = "0x3F72508", VA = "0x3F76508", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__3))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x3F7658C", Offset = "0x3F7258C", VA = "0x3F7658C")]
		public void SetLeaderboardScore(int score, string leaderboardId, [Optional] Action onSuccess, [Optional] Action onFail)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x3F765C4", Offset = "0x3F725C4", VA = "0x3F765C4")]
		public void UpdatePlayerProfile(string displayName, [Optional] Action onSuccess, [Optional] Action onFail)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x3F76648", Offset = "0x3F72648", VA = "0x3F76648")]
		public LeaderboardDisplayData GetLeaderboardDisplayData(string displayName)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x3F767BC", Offset = "0x3F727BC", VA = "0x3F767BC")]
		private bool IsSeasonLeaderboard(string leaderboardId)
		{
			return default;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x3F768E4", Offset = "0x3F728E4", VA = "0x3F768E4")]
		public HWLeaderboardManager()
		{
		}
	}
}
