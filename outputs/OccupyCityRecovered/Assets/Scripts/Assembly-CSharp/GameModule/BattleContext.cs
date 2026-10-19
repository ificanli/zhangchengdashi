using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace GameModule
{
	[Token(Token = "0x2000442")]
	public class BattleContext
	{
		[Token(Token = "0x4002A0D")]
		[FieldOffset(Offset = "0x10")]
		public bool showFoundEnemyPageOne;

		[Token(Token = "0x4002A0E")]
		[FieldOffset(Offset = "0x18")]
		public EnemyBattleDataCofig enemyDataCofig;

		[Token(Token = "0x4002A0F")]
		[FieldOffset(Offset = "0x20")]
		public Func<bool, RewardConfig> rewardConfigCallBack;

		[Token(Token = "0x4002A10")]
		[FieldOffset(Offset = "0x28")]
		public RewardConfig rewardConfig;

		[Token(Token = "0x4002A11")]
		[FieldOffset(Offset = "0x30")]
		public UnityAction<bool> gameEndCallBack;

		[Token(Token = "0x4002A12")]
		[FieldOffset(Offset = "0x38")]
		public UnityAction<bool> gameEndApplyRewardCallBack;

		[Token(Token = "0x4002A13")]
		[FieldOffset(Offset = "0x40")]
		public GameType GameType;

		[Token(Token = "0x4002A14")]
		[FieldOffset(Offset = "0x48")]
		public List<int> selectedSubGameBuffIds;

		[Token(Token = "0x4002A15")]
		[FieldOffset(Offset = "0x50")]
		public bool returnToSubGameChaosTrailsPanel;

		[Token(Token = "0x4002A16")]
		[FieldOffset(Offset = "0x51")]
		private bool isHadCalc;

		[Token(Token = "0x60014A2")]
		[Address(RVA = "0x3E04E24", Offset = "0x3E00E24", VA = "0x3E04E24")]
		public BattleContext()
		{
		}

		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x3E04EAC", Offset = "0x3E00EAC", VA = "0x3E04EAC")]
		public BattleContext(bool showFoundEnemyPageOne, EnemyBattleDataCofig enemyDataCofig, Func<bool, RewardConfig> rewardConfigCallBack, UnityAction<bool> gameEndCallBack, UnityAction<bool> gameEndApplyRewardCallBack)
		{
		}

		[Token(Token = "0x60014A4")]
		[Address(RVA = "0x3E04F60", Offset = "0x3E00F60", VA = "0x3E04F60")]
		public RewardConfig GetRewardConfig()
		{
			return null;
		}

		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x3E04FD8", Offset = "0x3E00FD8", VA = "0x3E04FD8")]
		public void SetReward(bool isWin)
		{
		}

		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x3E05018", Offset = "0x3E01018", VA = "0x3E05018")]
		public void SetGameType(GameType gameType)
		{
		}

		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x3E05020", Offset = "0x3E01020", VA = "0x3E05020")]
		public void SetSubGameBuffs(List<int> buffIds)
		{
		}
	}
}
