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

namespace GameModule
{
	[Token(Token = "0x20003E7")]
	public class CardTalent_2Manager : ManagerBase<CardTalent_2Manager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003EA")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4002803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CardTalent_2Manager _003C_003E4__this;

			[Token(Token = "0x600125B")]
			[Address(RVA = "0x3DCC898", Offset = "0x3DC8898", VA = "0x3DCC898", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600125C")]
			[Address(RVA = "0x3DCE2C4", Offset = "0x3DCA2C4", VA = "0x3DCE2C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<string, Func<string, TalentBase>> talentCreators;

		[Token(Token = "0x60011DA")]
		[Address(RVA = "0x3DC3084", Offset = "0x3DBF084", VA = "0x3DC3084", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__0))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60011DB")]
		[Address(RVA = "0x3DC3108", Offset = "0x3DBF108", VA = "0x3DC3108")]
		public List<string> GetBattleCardAbility(bool isEnemy, string cardId)
		{
			return null;
		}

		[Token(Token = "0x60011DC")]
		[Address(RVA = "0x3DC33F8", Offset = "0x3DBF3F8", VA = "0x3DC33F8")]
		public void UpgradeCardTalent(string cardId, string talentId)
		{
		}

		[Token(Token = "0x60011DD")]
		[Address(RVA = "0x3DC369C", Offset = "0x3DBF69C", VA = "0x3DC369C")]
		private void CardUpgrade(object o)
		{
		}

		[Token(Token = "0x60011DE")]
		[Address(RVA = "0x3DC3874", Offset = "0x3DBF874", VA = "0x3DC3874")]
		private void BuyRuneStonePack(object o)
		{
		}

		[Token(Token = "0x60011DF")]
		[Address(RVA = "0x3DC39B8", Offset = "0x3DBF9B8", VA = "0x3DC39B8")]
		public (bool, string) PlayerCanPushStonePack()
		{
			return default;
		}

		[Token(Token = "0x60011E0")]
		[Address(RVA = "0x3DC3BEC", Offset = "0x3DBFBEC", VA = "0x3DC3BEC")]
		public bool NewAbility2IsBTest()
		{
			return default;
		}

		[Token(Token = "0x60011E1")]
		[Address(RVA = "0x3DC3C60", Offset = "0x3DBFC60", VA = "0x3DC3C60")]
		public bool GetPlayerCardCanUnlockTalent(Talent2Data talent2Data, UserHeroCardData data)
		{
			return default;
		}

		[Token(Token = "0x60011E2")]
		[Address(RVA = "0x3DC3D44", Offset = "0x3DBFD44", VA = "0x3DC3D44")]
		public bool GetTalentCanUpgrade(Talent2Data talent2Data, UserHeroCardData data)
		{
			return default;
		}

		[Token(Token = "0x60011E3")]
		[Address(RVA = "0x3DC3EF0", Offset = "0x3DBFEF0", VA = "0x3DC3EF0")]
		public bool GetPlayerCardCanUpgradeTalent(string cardId)
		{
			return default;
		}

		[Token(Token = "0x60011E4")]
		[Address(RVA = "0x3DC4188", Offset = "0x3DC0188", VA = "0x3DC4188")]
		public Dictionary<string, List<int>> GetPlayerCardDeckTreeUnLock(List<UserHeroCardData> datas)
		{
			return null;
		}

		[Token(Token = "0x60011E5")]
		[Address(RVA = "0x3DC4458", Offset = "0x3DC0458", VA = "0x3DC4458")]
		public RareLevel GetTalenRareLevel(int talentId)
		{
			return default;
		}

		[Token(Token = "0x60011E6")]
		[Address(RVA = "0x3DC4544", Offset = "0x3DC0544", VA = "0x3DC4544")]
		public TalentBase CreateTalent(string id)
		{
			return null;
		}

		[Token(Token = "0x60011E7")]
		[Address(RVA = "0x3DC4624", Offset = "0x3DC0624", VA = "0x3DC4624")]
		private static GameEventType GetTalentType(string id)
		{
			return default;
		}

		[Token(Token = "0x60011E8")]
		[Address(RVA = "0x3DC46F0", Offset = "0x3DC06F0", VA = "0x3DC46F0")]
		private static float GetTalentValue(string id)
		{
			return default;
		}

		[Token(Token = "0x60011E9")]
		[Address(RVA = "0x3DC477C", Offset = "0x3DC077C", VA = "0x3DC477C")]
		public CardTalent_2Manager()
		{
		}
	}
}
