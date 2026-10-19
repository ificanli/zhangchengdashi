using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000C1C")]
	public class WeeklyClashPanel_SettlementStatus : WeeklyClashPanel_SettlementStatusComponents
	{
		[Token(Token = "0x2000C1D")]
		public enum PlayerSettlementStatus
		{
			[Token(Token = "0x4005760")]
			Null = 0,
			[Token(Token = "0x4005761")]
			NotQualified = 1,
			[Token(Token = "0x4005762")]
			NotInSettlementPeriod = 2,
			[Token(Token = "0x4005763")]
			CanClaim = 3,
			[Token(Token = "0x4005764")]
			AlreadyClaimed = 4,
			[Token(Token = "0x4005765")]
			Expired = 5
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C1F")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4005768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400576A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashPanel_SettlementStatus _003C_003E4__this;

			[Token(Token = "0x400576B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004B07")]
			[Address(RVA = "0x42641F0", Offset = "0x42601F0", VA = "0x42641F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004B08")]
			[Address(RVA = "0x42645AC", Offset = "0x42605AC", VA = "0x42645AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool getDataing;

		[Token(Token = "0x4005757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool isSeason;

		[Token(Token = "0x4005758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int playerRank;

		[Token(Token = "0x4005759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private SeasonManager.SeasonStatus currentSeasonStatus;

		[Token(Token = "0x400575A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool updateHintText;

		[Token(Token = "0x400575B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool getLeaderboardTopOver;

		[Token(Token = "0x400575C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAE")]
		private bool getPlayerLeaderboardOver;

		[Token(Token = "0x400575D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public List<SeasonRankData> rankData;

		[Token(Token = "0x400575E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float updateInterTime;

		[Token(Token = "0x6004AF9")]
		[Address(RVA = "0x4262650", Offset = "0x425E650", VA = "0x4262650", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__9))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004AFA")]
		[Address(RVA = "0x42626E4", Offset = "0x425E6E4", VA = "0x42626E4")]
		private void GetAllLeaderboardDataOver()
		{
		}

		[Token(Token = "0x6004AFB")]
		[Address(RVA = "0x42626FC", Offset = "0x425E6FC", VA = "0x42626FC")]
		private void UpdateRankInfoUI()
		{
		}

		[Token(Token = "0x6004AFC")]
		[Address(RVA = "0x4262D14", Offset = "0x425ED14", VA = "0x4262D14")]
		private void UpdatePlayerInfoUI(int rankingTemp)
		{
		}

		[Token(Token = "0x6004AFD")]
		[Address(RVA = "0x42634C0", Offset = "0x425F4C0", VA = "0x42634C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6004AFE")]
		[Address(RVA = "0x4263100", Offset = "0x425F100", VA = "0x4263100")]
		private void UpdateClaimBtn(PlayerSettlementStatus state)
		{
		}

		[Token(Token = "0x6004AFF")]
		[Address(RVA = "0x4263870", Offset = "0x425F870", VA = "0x4263870", Slot = "13")]
		protected override void OnButtonExtendHintBtnClicked()
		{
		}

		[Token(Token = "0x6004B00")]
		[Address(RVA = "0x4263C10", Offset = "0x425FC10", VA = "0x4263C10", Slot = "14")]
		protected override void OnButtonExtendClaimBtnClicked()
		{
		}

		[Token(Token = "0x6004B01")]
		[Address(RVA = "0x4263CF4", Offset = "0x425FCF4", VA = "0x4263CF4")]
		public WeeklyClashPanel_SettlementStatus()
		{
		}
	}
}
