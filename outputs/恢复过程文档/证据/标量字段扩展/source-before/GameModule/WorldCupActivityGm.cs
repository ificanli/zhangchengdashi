using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000605")]
	public class WorldCupActivityGm
	{
		[Token(Token = "0x4003229")]
		private const int GmTestFootballMinCount = 99;

		[Token(Token = "0x400322A")]
		[FieldOffset(Offset = "0x10")]
		private readonly WorldCupActivityState _state;

		[Token(Token = "0x400322B")]
		[FieldOffset(Offset = "0x18")]
		private readonly WorldCupDailySideService _daily;

		[Token(Token = "0x400322C")]
		[FieldOffset(Offset = "0x20")]
		private readonly Action _refreshRuntime;

		[Token(Token = "0x400322D")]
		[FieldOffset(Offset = "0x28")]
		private readonly Action _refreshAll;

		[Token(Token = "0x400322E")]
		[FieldOffset(Offset = "0x30")]
		private readonly Action<int> _addFootball;

		[Token(Token = "0x400322F")]
		[FieldOffset(Offset = "0x38")]
		private readonly Action<int> _addActivityScore;

		[Token(Token = "0x170001B5")]
		public int GmFixedGoalResult
		{
			[Token(Token = "0x6002013")]
			[Address(RVA = "0x3F0D480", Offset = "0x3F09480", VA = "0x3F0D480")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6002014")]
			[Address(RVA = "0x3F0D488", Offset = "0x3F09488", VA = "0x3F0D488")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170001B6")]
		public bool IsTestMode
		{
			[Token(Token = "0x6002015")]
			[Address(RVA = "0x3F06188", Offset = "0x3F02188", VA = "0x3F06188")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001B7")]
		public bool IsForceOpenActivity
		{
			[Token(Token = "0x6002016")]
			[Address(RVA = "0x3F0635C", Offset = "0x3F0235C", VA = "0x3F0635C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6002017")]
		[Address(RVA = "0x3F05970", Offset = "0x3F01970", VA = "0x3F05970")]
		public WorldCupActivityGm(WorldCupActivityState state, WorldCupDailySideService daily, Action refreshRuntime, Action refreshAll, Action<int> addFootball, Action<int> addActivityScore)
		{
		}

		[Token(Token = "0x6002018")]
		[Address(RVA = "0x3F08414", Offset = "0x3F04414", VA = "0x3F08414")]
		public void SetForceOpenActivity(bool enabled)
		{
		}

		[Token(Token = "0x6002019")]
		[Address(RVA = "0x3F0D614", Offset = "0x3F09614", VA = "0x3F0D614")]
		private void SetTestMode(bool enabled)
		{
		}

		[Token(Token = "0x600201A")]
		[Address(RVA = "0x3F0D6B0", Offset = "0x3F096B0", VA = "0x3F0D6B0")]
		public void EnsureTestContext(bool enableTestMode = true)
		{
		}

		[Token(Token = "0x600201B")]
		[Address(RVA = "0x3F0D6F0", Offset = "0x3F096F0", VA = "0x3F0D6F0")]
		public void SetFixedGoalResult(int value)
		{
		}

		[Token(Token = "0x600201C")]
		[Address(RVA = "0x3F0D708", Offset = "0x3F09708", VA = "0x3F0D708")]
		public void ClearFixedGoalResult()
		{
		}

		[Token(Token = "0x600201D")]
		[Address(RVA = "0x3F0D714", Offset = "0x3F09714", VA = "0x3F0D714")]
		public bool TryResolveFixedGoal(out bool isGoal)
		{
			return default;
		}

		[Token(Token = "0x600201E")]
		[Address(RVA = "0x3F0D738", Offset = "0x3F09738", VA = "0x3F0D738")]
		public void FillFootball(int count = -1)
		{
		}

		[Token(Token = "0x600201F")]
		[Address(RVA = "0x3F0D7BC", Offset = "0x3F097BC", VA = "0x3F0D7BC")]
		public void AddFootball(int amount = 10)
		{
		}

		[Token(Token = "0x6002020")]
		[Address(RVA = "0x3F0D804", Offset = "0x3F09804", VA = "0x3F0D804")]
		public void AddActivityScore(int amount = 100)
		{
		}

		[Token(Token = "0x6002021")]
		[Address(RVA = "0x3F0D84C", Offset = "0x3F0984C", VA = "0x3F0D84C")]
		public void ResetActivity()
		{
		}

		[Token(Token = "0x6002022")]
		[Address(RVA = "0x3F0D9A4", Offset = "0x3F099A4", VA = "0x3F0D9A4")]
		public void ClearSave()
		{
		}

		[Token(Token = "0x6002023")]
		[Address(RVA = "0x3F0DA0C", Offset = "0x3F09A0C", VA = "0x3F0DA0C")]
		public void ResetDailyGift()
		{
		}

		[Token(Token = "0x6002024")]
		[Address(RVA = "0x3F0DA7C", Offset = "0x3F09A7C", VA = "0x3F0DA7C")]
		public void ResetDailyTasks()
		{
		}

		[Token(Token = "0x6002025")]
		[Address(RVA = "0x3F0DA94", Offset = "0x3F09A94", VA = "0x3F0DA94")]
		public void CompleteDailyTask(int configId)
		{
		}

		[Token(Token = "0x6002026")]
		[Address(RVA = "0x3F0DAB4", Offset = "0x3F09AB4", VA = "0x3F0DAB4")]
		public void AddDailyTaskProgress(int taskType, int delta, int normalParam = 0)
		{
		}

		[Token(Token = "0x6002027")]
		[Address(RVA = "0x3F0DAD4", Offset = "0x3F09AD4", VA = "0x3F0DAD4")]
		public void CompleteAllDailyTasks()
		{
		}

		[Token(Token = "0x6002028")]
		[Address(RVA = "0x3F0D490", Offset = "0x3F09490", VA = "0x3F0D490")]
		private void ApplyGmForceOpenActivityState()
		{
		}

		[Token(Token = "0x6002029")]
		[Address(RVA = "0x3F0D664", Offset = "0x3F09664", VA = "0x3F0D664")]
		private void ApplyGmTestModeState()
		{
		}
	}
}
