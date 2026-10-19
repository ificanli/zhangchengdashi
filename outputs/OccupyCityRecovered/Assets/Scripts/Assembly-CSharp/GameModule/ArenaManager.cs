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
	[Token(Token = "0x200046A")]
	public class ArenaManager : ManagerBase<ArenaManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000473")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4002AF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002AF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x60015CE")]
			[Address(RVA = "0x3E2081C", Offset = "0x3E1C81C", VA = "0x3E2081C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60015CF")]
			[Address(RVA = "0x3E20C90", Offset = "0x3E1CC90", VA = "0x3E20C90", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x17000145")]
		public int MaxDanNumber
		{
			[Token(Token = "0x60015A5")]
			[Address(RVA = "0x3E1F678", Offset = "0x3E1B678", VA = "0x3E1F678")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000146")]
		public int ArenaCount
		{
			[Token(Token = "0x60015A6")]
			[Address(RVA = "0x3E1F700", Offset = "0x3E1B700", VA = "0x3E1F700")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000147")]
		public int PlayerNowDanNumber
		{
			[Token(Token = "0x60015A7")]
			[Address(RVA = "0x3E1F708", Offset = "0x3E1B708", VA = "0x3E1F708")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x3E1F770", Offset = "0x3E1B770", VA = "0x3E1F770", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__6))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60015A9")]
		[Address(RVA = "0x3E1F7F0", Offset = "0x3E1B7F0", VA = "0x3E1F7F0")]
		public void UnLockArena(string arenaId)
		{
		}

		[Token(Token = "0x60015AA")]
		[Address(RVA = "0x3E1F9EC", Offset = "0x3E1B9EC", VA = "0x3E1F9EC")]
		public int GetUnLockArenaCount()
		{
			return default;
		}

		[Token(Token = "0x60015AB")]
		[Address(RVA = "0x3E1FACC", Offset = "0x3E1BACC", VA = "0x3E1FACC")]
		public GlobalArenaInfo GetNowArenaInfo()
		{
			return null;
		}

		[Token(Token = "0x60015AC")]
		[Address(RVA = "0x3E1FB50", Offset = "0x3E1BB50", VA = "0x3E1FB50")]
		public UserArenaData GetNowArenaData()
		{
			return null;
		}

		[Token(Token = "0x60015AD")]
		[Address(RVA = "0x3E1BECC", Offset = "0x3E17ECC", VA = "0x3E1BECC")]
		public void ChangeArenaTrophy(string idd, int num, bool isCheat = false)
		{
		}

		[Token(Token = "0x60015AE")]
		[Address(RVA = "0x3E1FBE8", Offset = "0x3E1BBE8", VA = "0x3E1FBE8")]
		public bool GetArenaTrophyIsCollectAll(string id)
		{
			return default;
		}

		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x3E1FC8C", Offset = "0x3E1BC8C", VA = "0x3E1FC8C")]
		public bool IsFirstEntryArena(string arenaId)
		{
			return default;
		}

		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x3E1FDB8", Offset = "0x3E1BDB8", VA = "0x3E1FDB8")]
		public bool HasFoughtInArena(string arenaId)
		{
			return default;
		}

		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x3E1FED8", Offset = "0x3E1BED8", VA = "0x3E1FED8")]
		public string GetEnemyContentBalanceArenaId()
		{
			return null;
		}

		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x3E1FFE8", Offset = "0x3E1BFE8", VA = "0x3E1FFE8")]
		public int GetMaxWinReward()
		{
			return default;
		}

		[Token(Token = "0x60015B3")]
		[Address(RVA = "0x3E2003C", Offset = "0x3E1C03C", VA = "0x3E2003C")]
		public bool GetArenaIsGetCompleteReward(string id)
		{
			return default;
		}

		[Token(Token = "0x60015B4")]
		[Address(RVA = "0x3E1BC38", Offset = "0x3E17C38", VA = "0x3E1BC38")]
		public bool GetArenaIsCollectAllTrophy(string id)
		{
			return default;
		}

		[Token(Token = "0x60015B5")]
		[Address(RVA = "0x3E1BDBC", Offset = "0x3E17DBC", VA = "0x3E1BDBC")]
		public int GetArenaTrophyNumber(string id)
		{
			return default;
		}

		[Token(Token = "0x60015B6")]
		[Address(RVA = "0x3E20164", Offset = "0x3E1C164", VA = "0x3E20164")]
		public bool GetArenaIsUnLock(string id)
		{
			return default;
		}

		[Token(Token = "0x60015B7")]
		[Address(RVA = "0x3E2027C", Offset = "0x3E1C27C", VA = "0x3E2027C")]
		public GlobalArenaInfo GetNowPlayArenaInfo()
		{
			return null;
		}

		[Token(Token = "0x60015B8")]
		[Address(RVA = "0x3E202FC", Offset = "0x3E1C2FC", VA = "0x3E202FC")]
		public int GetNoBetBetAmount(string arenaId)
		{
			return default;
		}

		[Token(Token = "0x60015B9")]
		[Address(RVA = "0x3E203B8", Offset = "0x3E1C3B8", VA = "0x3E203B8")]
		public int GetNoBetVictoryGold(string arenaId)
		{
			return default;
		}

		[Token(Token = "0x60015BA")]
		[Address(RVA = "0x3E204D4", Offset = "0x3E1C4D4", VA = "0x3E204D4")]
		public string GetDailyNoBetGoldString(string arenaId)
		{
			return null;
		}

		[Token(Token = "0x60015BB")]
		[Address(RVA = "0x3E1BBAC", Offset = "0x3E17BAC", VA = "0x3E1BBAC")]
		public void ApplyNoBetVictoryGold(int amount)
		{
		}

		[Token(Token = "0x60015BC")]
		[Address(RVA = "0x3E20628", Offset = "0x3E1C628", VA = "0x3E20628")]
		public void RecordWonTrophyCount(int count, bool isCheat = false)
		{
		}

		[Token(Token = "0x60015BD")]
		[Address(RVA = "0x3E206B4", Offset = "0x3E1C6B4", VA = "0x3E206B4")]
		public ArenaManager()
		{
		}
	}
}
