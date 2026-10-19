using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TimeModuleO;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x200053A")]
	public class PacksTipManager : ManagerBase<PacksTipManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200054A")]
		[CompilerGenerated]
		private struct _003CFirstPopPacks_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x4002F24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002F25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002F26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PacksTipManager _003C_003E4__this;

			[Token(Token = "0x6001B64")]
			[Address(RVA = "0x3EBA3D0", Offset = "0x3EB63D0", VA = "0x3EBA3D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001B65")]
			[Address(RVA = "0x3EBB050", Offset = "0x3EB7050", VA = "0x3EBB050", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200054B")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4002F27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002F28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002F29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PacksTipManager _003C_003E4__this;

			[Token(Token = "0x6001B66")]
			[Address(RVA = "0x3EBB05C", Offset = "0x3EB705C", VA = "0x3EBB05C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001B67")]
			[Address(RVA = "0x3EBB510", Offset = "0x3EB7510", VA = "0x3EBB510", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002EDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isNewCooling;

		[Token(Token = "0x4002EDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float jTime;

		[Token(Token = "0x4002EDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isMonthCooling;

		[Token(Token = "0x4002EDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float hTime;

		[Token(Token = "0x4002EE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isPropCooling;

		[Token(Token = "0x4002EE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float pTime;

		[Token(Token = "0x4002EE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool isArenaPackEndCooling;

		[Token(Token = "0x4002EE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float arenaPackEndCoolTime;

		[Token(Token = "0x4002EE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isWeeklyCardCooling;

		[Token(Token = "0x4002EE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float wTime;

		[Token(Token = "0x4002EE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TimeManager.Timer canPushGiftPackTimer;

		[Token(Token = "0x4002EE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TimeManager.Timer pushGiftPackCutDownTimer;

		[Token(Token = "0x4002EE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool hadInit;

		[Token(Token = "0x4002EE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<Action<int>> firstPopActionsList;

		[Token(Token = "0x4002EEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool popEdDailyReward;

		[Token(Token = "0x6001B19")]
		[Address(RVA = "0x3EB3814", Offset = "0x3EAF814", VA = "0x3EB3814", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__14))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001B1A")]
		[Address(RVA = "0x3EB3898", Offset = "0x3EAF898", VA = "0x3EB3898")]
		private void Update()
		{
		}

		[Token(Token = "0x6001B1B")]
		[Address(RVA = "0x3EB3B70", Offset = "0x3EAFB70", VA = "0x3EB3B70")]
		private void CheckPushGiftPack()
		{
		}

		[Token(Token = "0x6001B1C")]
		[Address(RVA = "0x3EB415C", Offset = "0x3EB015C", VA = "0x3EB415C")]
		private void PushPackBeginCutDown()
		{
		}

		[Token(Token = "0x6001B1D")]
		[Address(RVA = "0x3EB46C8", Offset = "0x3EB06C8", VA = "0x3EB46C8")]
		public void PushExpireResetInfo(bool isBuy)
		{
		}

		[Token(Token = "0x6001B1E")]
		[Address(RVA = "0x3EB4410", Offset = "0x3EB0410", VA = "0x3EB4410")]
		private TimeSpan GetSomeDayAfterTime(int dayCount)
		{
			return default;
		}

		[Token(Token = "0x6001B1F")]
		[Address(RVA = "0x3EB39E0", Offset = "0x3EAF9E0", VA = "0x3EB39E0")]
		private void NewJTime()
		{
		}

		[Token(Token = "0x6001B20")]
		[Address(RVA = "0x3EB3A30", Offset = "0x3EAFA30", VA = "0x3EB3A30")]
		private void MonthHTime()
		{
		}

		[Token(Token = "0x6001B21")]
		[Address(RVA = "0x3EB3A80", Offset = "0x3EAFA80", VA = "0x3EB3A80")]
		private void PropPTime()
		{
		}

		[Token(Token = "0x6001B22")]
		[Address(RVA = "0x3EB3AD0", Offset = "0x3EAFAD0", VA = "0x3EB3AD0")]
		private void ArenaPackEndCoolTime()
		{
		}

		[Token(Token = "0x6001B23")]
		[Address(RVA = "0x3EB3B20", Offset = "0x3EAFB20", VA = "0x3EB3B20")]
		private void WeeklyCardWTime()
		{
		}

		[Token(Token = "0x6001B24")]
		[Address(RVA = "0x3EB47B4", Offset = "0x3EB07B4", VA = "0x3EB47B4")]
		[AsyncStateMachine(typeof(_003CFirstPopPacks_003Ed__26))]
		public void FirstPopPacks()
		{
		}

		[Token(Token = "0x6001B25")]
		[Address(RVA = "0x3EB4840", Offset = "0x3EB0840", VA = "0x3EB4840")]
		public void AddFirstPopAction(Action<int> action)
		{
		}

		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x3EB48E4", Offset = "0x3EB08E4", VA = "0x3EB48E4")]
		public void CheckPopPacks(bool isVictory)
		{
		}

		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x3EB48E8", Offset = "0x3EB08E8", VA = "0x3EB48E8")]
		private void RegisterPanelPop()
		{
		}

		[Token(Token = "0x6001B28")]
		[Address(RVA = "0x3EB517C", Offset = "0x3EB117C", VA = "0x3EB517C")]
		private void ShowDailyResReward()
		{
		}

		[Token(Token = "0x6001B29")]
		[Address(RVA = "0x3EB5320", Offset = "0x3EB1320", VA = "0x3EB5320")]
		private void BuyMonthPass(object o)
		{
		}

		[Token(Token = "0x6001B2A")]
		[Address(RVA = "0x3EB5324", Offset = "0x3EB1324", VA = "0x3EB5324")]
		private void CloseDailyReward(object o)
		{
		}

		[Token(Token = "0x6001B2B")]
		[Address(RVA = "0x3EB5330", Offset = "0x3EB1330", VA = "0x3EB5330")]
		public PacksTipManager()
		{
		}
	}
}
