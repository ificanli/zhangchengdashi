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
	[Token(Token = "0x20003E4")]
	public class CardTalentManager : ManagerBase<CardTalentManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003E6")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4002790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CardTalentManager _003C_003E4__this;

			[Token(Token = "0x60011D8")]
			[Address(RVA = "0x3DC0F8C", Offset = "0x3DBCF8C", VA = "0x3DC0F8C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60011D9")]
			[Address(RVA = "0x3DC3078", Offset = "0x3DBF078", VA = "0x3DC3078", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, CardTalentTreeData> playerAllCardTreeData;

		[Token(Token = "0x4002749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, CardTalentTreeData> enemyAllCardTreeData;

		[Token(Token = "0x400274A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, CardTalentTreeData> aTestCommonAllCardTreeData;

		[Token(Token = "0x400274B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Dictionary<string, CardTalentTreeData> enemyBornAllCardTreeData;

		[Token(Token = "0x400274C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Dictionary<string, Func<string, TalentBase>> talentCreators;

		[Token(Token = "0x6001174")]
		[Address(RVA = "0x3DB7D24", Offset = "0x3DB3D24", VA = "0x3DB7D24", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__4))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001175")]
		[Address(RVA = "0x3DB7DB4", Offset = "0x3DB3DB4", VA = "0x3DB7DB4")]
		public void RefreshTalentManagerRecord()
		{
		}

		[Token(Token = "0x6001176")]
		[Address(RVA = "0x3DB83E8", Offset = "0x3DB43E8", VA = "0x3DB83E8")]
		private void EnemyRecordCardTalentCofig(object o)
		{
		}

		[Token(Token = "0x6001177")]
		[Address(RVA = "0x3DB88A8", Offset = "0x3DB48A8", VA = "0x3DB88A8")]
		public bool GetPlayerHasAbility1Data()
		{
			return default;
		}

		[Token(Token = "0x6001178")]
		[Address(RVA = "0x3DB8B1C", Offset = "0x3DB4B1C", VA = "0x3DB8B1C")]
		public Dictionary<string, List<int>> GetPlayerCardDeckTreeUnLock(List<UserHeroCardData> datas)
		{
			return null;
		}

		[Token(Token = "0x6001179")]
		[Address(RVA = "0x3DB849C", Offset = "0x3DB449C", VA = "0x3DB849C")]
		private void RecordEnemyAllCardTalent(List<GlobalHeroCardInfo> cardInfo)
		{
		}

		[Token(Token = "0x600117A")]
		[Address(RVA = "0x3DB8D14", Offset = "0x3DB4D14", VA = "0x3DB8D14")]
		private void RefreshEnemyAllCardTreeData()
		{
		}

		[Token(Token = "0x600117B")]
		[Address(RVA = "0x3DB8D90", Offset = "0x3DB4D90", VA = "0x3DB8D90")]
		private List<int> UnlockRandomTalents(string cardId, int unlockCount)
		{
			return null;
		}

		[Token(Token = "0x600117C")]
		[Address(RVA = "0x3DB97D0", Offset = "0x3DB57D0", VA = "0x3DB97D0")]
		public List<int> GetCardAllUnLockCardTalentNode(string cardId, int unlockCount)
		{
			return null;
		}

		[Token(Token = "0x600117D")]
		[Address(RVA = "0x3DB837C", Offset = "0x3DB437C", VA = "0x3DB837C")]
		private CardTalentNodeData CreatCardTalentNodeData(bool inUnLock, string cardNodeCofig)
		{
			return null;
		}

		[Token(Token = "0x600117E")]
		[Address(RVA = "0x3DB9858", Offset = "0x3DB5858", VA = "0x3DB9858")]
		private CardTalentNodeData CreatCardTalentNodeData(bool inUnLock, int talentId)
		{
			return null;
		}

		[Token(Token = "0x600117F")]
		[Address(RVA = "0x3DB8298", Offset = "0x3DB4298", VA = "0x3DB8298")]
		public bool UserCardTalentIsUnLock(string cardId, int talentNodeId)
		{
			return default;
		}

		[Token(Token = "0x6001180")]
		[Address(RVA = "0x3DB98C4", Offset = "0x3DB58C4", VA = "0x3DB98C4")]
		public bool CheckCardTalentNodeCanUpgrade(string cardId, CardTalentNodeData node)
		{
			return default;
		}

		[Token(Token = "0x6001181")]
		[Address(RVA = "0x3DB99F4", Offset = "0x3DB59F4", VA = "0x3DB99F4")]
		public CardTalentTreeData GetCardTalentTreeData(string cardId, bool isEnemy)
		{
			return null;
		}

		[Token(Token = "0x6001182")]
		[Address(RVA = "0x3DB9B20", Offset = "0x3DB5B20", VA = "0x3DB9B20")]
		public CardTalentNodeData GetCardTalentNodeData(string cardId, string nodeId)
		{
			return null;
		}

		[Token(Token = "0x6001183")]
		[Address(RVA = "0x3DB9C20", Offset = "0x3DB5C20", VA = "0x3DB9C20")]
		public CardTalentNodeData GetPVETalentNodeData(string cardId, string nodeId, bool IsUnLock)
		{
			return null;
		}

		[Token(Token = "0x6001184")]
		[Address(RVA = "0x3DB9D88", Offset = "0x3DB5D88", VA = "0x3DB9D88")]
		public int GetPlayerCardMostHighCanUpgradeTalentLevel(string cardId)
		{
			return default;
		}

		[Token(Token = "0x6001185")]
		[Address(RVA = "0x3DB9F10", Offset = "0x3DB5F10", VA = "0x3DB9F10")]
		public RareLevel GetTalenRareLevel(int talentId)
		{
			return default;
		}

		[Token(Token = "0x6001186")]
		[Address(RVA = "0x3DB9FFC", Offset = "0x3DB5FFC", VA = "0x3DB9FFC")]
		public bool GetCardHasTalentNoUnlock(string cardID)
		{
			return default;
		}

		[Token(Token = "0x6001187")]
		[Address(RVA = "0x3DBA100", Offset = "0x3DB6100", VA = "0x3DBA100")]
		public void UnLockCardTalent(string cardId, int talentID)
		{
		}

		[Token(Token = "0x6001188")]
		[Address(RVA = "0x3DBA468", Offset = "0x3DB6468", VA = "0x3DBA468")]
		public int GetCardTalentDotNum(string cardId)
		{
			return default;
		}

		[Token(Token = "0x6001189")]
		[Address(RVA = "0x3DBA514", Offset = "0x3DB6514", VA = "0x3DBA514")]
		public void AddCardTalentDotNum(string cardId)
		{
		}

		[Token(Token = "0x600118A")]
		[Address(RVA = "0x3DBA2D8", Offset = "0x3DB62D8", VA = "0x3DBA2D8")]
		public void ReduceCardTalentDotNum(string cardId, bool addActivity)
		{
		}

		[Token(Token = "0x600118B")]
		[Address(RVA = "0x3DBA648", Offset = "0x3DB6648", VA = "0x3DBA648")]
		public void ResetCardTalentDotNum(string cardId)
		{
		}

		[Token(Token = "0x600118C")]
		[Address(RVA = "0x3DBA7A8", Offset = "0x3DB67A8", VA = "0x3DBA7A8")]
		public void ResetCardTalent(string cardId)
		{
		}

		[Token(Token = "0x600118D")]
		[Address(RVA = "0x3DBAB00", Offset = "0x3DB6B00", VA = "0x3DBAB00")]
		public int GetPlayrUnLockTalentCount(string cardId)
		{
			return default;
		}

		[Token(Token = "0x600118E")]
		[Address(RVA = "0x3DBACA4", Offset = "0x3DB6CA4", VA = "0x3DBACA4")]
		public TalentBase CreateTalent(string id)
		{
			return null;
		}

		[Token(Token = "0x600118F")]
		[Address(RVA = "0x3DBAD84", Offset = "0x3DB6D84", VA = "0x3DBAD84")]
		public void TalentTargetTempAddAttackHandle(ref float attack, float num)
		{
		}

		[Token(Token = "0x6001190")]
		[Address(RVA = "0x3DBADB8", Offset = "0x3DB6DB8", VA = "0x3DBADB8")]
		public void TalentTargetTempReduceDamageHandle(ref float damage, float num)
		{
		}

		[Token(Token = "0x6001191")]
		[Address(RVA = "0x3DBADEC", Offset = "0x3DB6DEC", VA = "0x3DBADEC")]
		private static GameEventType GetTalentType(string id)
		{
			return default;
		}

		[Token(Token = "0x6001192")]
		[Address(RVA = "0x3DBAEB8", Offset = "0x3DB6EB8", VA = "0x3DBAEB8")]
		private static float GetTalentValue(string id)
		{
			return default;
		}

		[Token(Token = "0x6001193")]
		[Address(RVA = "0x3DBAF44", Offset = "0x3DB6F44", VA = "0x3DBAF44")]
		public CardTalentManager()
		{
		}
	}
}
