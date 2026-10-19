using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BadgeGraph;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20004BC")]
	public class HeroCardManager : ManagerBase<HeroCardManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004C3")]
		[CompilerGenerated]
		private struct _003CGetCardReward_003Ed__37 : IAsyncStateMachine
		{
			[Token(Token = "0x4002BEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002BF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002BF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<UserHeroCardData> cardList;

			[Token(Token = "0x4002BF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public HeroCardManager _003C_003E4__this;

			[Token(Token = "0x60017E3")]
			[Address(RVA = "0x3E657F0", Offset = "0x3E617F0", VA = "0x3E657F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60017E4")]
			[Address(RVA = "0x3E65D90", Offset = "0x3E61D90", VA = "0x3E65D90", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004C4")]
		[CompilerGenerated]
		private struct _003CGetGeneralCardIcon_003Ed__48 : IAsyncStateMachine
		{
			[Token(Token = "0x4002BF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002BF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4002BF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UserHeroCardData data;

			[Token(Token = "0x4002BF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60017E5")]
			[Address(RVA = "0x3E65D9C", Offset = "0x3E61D9C", VA = "0x3E65D9C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60017E6")]
			[Address(RVA = "0x3E6623C", Offset = "0x3E6223C", VA = "0x3E6623C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004C5")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4002BF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002BF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002BF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HeroCardManager _003C_003E4__this;

			[Token(Token = "0x60017E7")]
			[Address(RVA = "0x3E66294", Offset = "0x3E62294", VA = "0x3E66294", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60017E8")]
			[Address(RVA = "0x3E66840", Offset = "0x3E62840", VA = "0x3E66840", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004C6")]
		[CompilerGenerated]
		private struct _003CUpdateCardBG_003Ed__27 : IAsyncStateMachine
		{
			[Token(Token = "0x4002BFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002BFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4002BFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RareLevel rare;

			[Token(Token = "0x4002BFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60017E9")]
			[Address(RVA = "0x3E6684C", Offset = "0x3E6284C", VA = "0x3E6684C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60017EA")]
			[Address(RVA = "0x3E671EC", Offset = "0x3E631EC", VA = "0x3E671EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004C7")]
		[CompilerGenerated]
		private struct _003CUpdateCardImgIcon_003Ed__25 : IAsyncStateMachine
		{
			[Token(Token = "0x4002BFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002BFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4002C00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UserHeroCardData data;

			[Token(Token = "0x4002C01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60017EB")]
			[Address(RVA = "0x3E67244", Offset = "0x3E63244", VA = "0x3E67244", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60017EC")]
			[Address(RVA = "0x3E67E38", Offset = "0x3E63E38", VA = "0x3E67E38", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004C8")]
		[CompilerGenerated]
		private struct _003CUpdateCardType_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x4002C02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002C03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4002C04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string type;

			[Token(Token = "0x4002C05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60017ED")]
			[Address(RVA = "0x3E67E90", Offset = "0x3E63E90", VA = "0x3E67E90", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60017EE")]
			[Address(RVA = "0x3E68674", Offset = "0x3E64674", VA = "0x3E68674", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002BE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, UserHeroCardData> _heroCardDatas;

		[Token(Token = "0x4002BE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _redDotSystemInitialized;

		[Token(Token = "0x4002BE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool _abilityStoneResourceListenerRegistered;

		[Token(Token = "0x4002BE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action<string> _onAbilityStoneResourceChangedForRedDot;

		[Token(Token = "0x4002BE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ThrottleTrigger redDotThrottleTrigger;

		[Token(Token = "0x60017A2")]
		[Address(RVA = "0x3E5F850", Offset = "0x3E5B850", VA = "0x3E5F850", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__5))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60017A3")]
		[Address(RVA = "0x3E5F8E0", Offset = "0x3E5B8E0", VA = "0x3E5F8E0")]
		private void OnHeroCardDataChangedForRedDot(object obj)
		{
		}

		[Token(Token = "0x60017A4")]
		[Address(RVA = "0x3E5F8E8", Offset = "0x3E5B8E8", VA = "0x3E5F8E8")]
		private void RegisterAbilityStoneResourceChangeForRedDot()
		{
		}

		[Token(Token = "0x60017A5")]
		[Address(RVA = "0x3E5F9BC", Offset = "0x3E5B9BC", VA = "0x3E5F9BC")]
		private void OnAbilityStoneResourceChangedForRedDot(string count)
		{
		}

		[Token(Token = "0x60017A6")]
		[Address(RVA = "0x3E48684", Offset = "0x3E44684", VA = "0x3E48684")]
		public void RequestRefreshRedDot(bool immediate = false)
		{
		}

		[Token(Token = "0x60017A7")]
		[Address(RVA = "0x3E5F9C4", Offset = "0x3E5B9C4", VA = "0x3E5F9C4")]
		private void CheckRedDot()
		{
		}

		[Token(Token = "0x60017A8")]
		[Address(RVA = "0x3E5FF24", Offset = "0x3E5BF24", VA = "0x3E5FF24")]
		private void HideHeroPanel(object obj)
		{
		}

		[Token(Token = "0x60017A9")]
		[Address(RVA = "0x3E5FF28", Offset = "0x3E5BF28", VA = "0x3E5FF28")]
		private void ShowHeroPanel(object obj)
		{
		}

		[Token(Token = "0x60017AA")]
		[Address(RVA = "0x3E60090", Offset = "0x3E5C090", VA = "0x3E60090")]
		public void GetCard(string cardId, int cardCount, CurrencyTransactionSceneType type)
		{
		}

		[Token(Token = "0x60017AB")]
		[Address(RVA = "0x3E6018C", Offset = "0x3E5C18C", VA = "0x3E6018C")]
		private List<int> GenerateRandomIntegers(int a, int b)
		{
			return null;
		}

		[Token(Token = "0x60017AC")]
		[Address(RVA = "0x3E60270", Offset = "0x3E5C270", VA = "0x3E60270")]
		private bool GenerateRandomIntegersRecursive(List<int> numbers, int remainingSum, int count, System.Random random)
		{
			return default;
		}

		[Token(Token = "0x60017AD")]
		[Address(RVA = "0x3E603E0", Offset = "0x3E5C3E0", VA = "0x3E603E0")]
		public void ChangeEquipHeroCard(int nowCardDeckIndex)
		{
		}

		[Token(Token = "0x60017AE")]
		[Address(RVA = "0x3E60600", Offset = "0x3E5C600", VA = "0x3E60600")]
		public List<UserHeroCardData> GetUserCardDataList(int cardDeckIndex)
		{
			return null;
		}

		[Token(Token = "0x60017AF")]
		[Address(RVA = "0x3E60850", Offset = "0x3E5C850", VA = "0x3E60850")]
		public bool PlayerHaveTenLevelCard()
		{
			return default;
		}

		[Token(Token = "0x60017B0")]
		[Address(RVA = "0x3E60A08", Offset = "0x3E5CA08", VA = "0x3E60A08")]
		public bool PlayerCardIsExceedTenLevel(string id)
		{
			return default;
		}

		[Token(Token = "0x60017B1")]
		[Address(RVA = "0x3E60BB0", Offset = "0x3E5CBB0", VA = "0x3E60BB0")]
		public Dictionary<int, int> GetHeroCardDataFetterCount(List<UserHeroCardData> cardDatas)
		{
			return null;
		}

		[Token(Token = "0x60017B2")]
		[Address(RVA = "0x3E60C08", Offset = "0x3E5CC08", VA = "0x3E60C08")]
		public int GetHeroCardDataFetterLevel(bool isFetter, int num)
		{
			return default;
		}

		[Token(Token = "0x60017B3")]
		[Address(RVA = "0x3E60C50", Offset = "0x3E5CC50", VA = "0x3E60C50")]
		public CardFetterAttackTrpe GetCardFetterAndAtkType(string cardId)
		{
			return default;
		}

		[Token(Token = "0x60017B4")]
		[Address(RVA = "0x3E60F2C", Offset = "0x3E5CF2C", VA = "0x3E60F2C")]
		public UserHeroCardData GetCardData(string id)
		{
			return null;
		}

		[Token(Token = "0x60017B5")]
		[Address(RVA = "0x3E610CC", Offset = "0x3E5D0CC", VA = "0x3E610CC")]
		public void GetCard(List<UserHeroCardData> heroCardDataList)
		{
		}

		[Token(Token = "0x60017B6")]
		[Address(RVA = "0x3E6116C", Offset = "0x3E5D16C", VA = "0x3E6116C")]
		[AsyncStateMachine(typeof(_003CUpdateCardImgIcon_003Ed__25))]
		public UniTask<Sprite> UpdateCardImgIcon(UserHeroCardData data)
		{
			return default;
		}

		[Token(Token = "0x60017B7")]
		[Address(RVA = "0x3E6124C", Offset = "0x3E5D24C", VA = "0x3E6124C")]
		public bool GetCardIsSSSR(string cardId)
		{
			return default;
		}

		[Token(Token = "0x60017B8")]
		[Address(RVA = "0x3E612F0", Offset = "0x3E5D2F0", VA = "0x3E612F0")]
		[AsyncStateMachine(typeof(_003CUpdateCardBG_003Ed__27))]
		public UniTask<Sprite> UpdateCardBG(RareLevel rare)
		{
			return default;
		}

		[Token(Token = "0x60017B9")]
		[Address(RVA = "0x3E613D0", Offset = "0x3E5D3D0", VA = "0x3E613D0")]
		[AsyncStateMachine(typeof(_003CUpdateCardType_003Ed__28))]
		public UniTask<Sprite> UpdateCardType(string type)
		{
			return default;
		}

		[Token(Token = "0x60017BA")]
		[Address(RVA = "0x3E614B0", Offset = "0x3E5D4B0", VA = "0x3E614B0")]
		public int GetPlayerTotalPower()
		{
			return default;
		}

		[Token(Token = "0x60017BB")]
		[Address(RVA = "0x3E61500", Offset = "0x3E5D500", VA = "0x3E61500")]
		public int GetCardDeckCP(List<UserHeroCardData> cardDatas, Dictionary<string, List<int>> allCardUnLockTalentId, [Optional] string getSingleCardCP)
		{
			return default;
		}

		[Token(Token = "0x60017BC")]
		[Address(RVA = "0x3E61570", Offset = "0x3E5D570", VA = "0x3E61570")]
		public void EquipCardChangeInfo(int id, int id2)
		{
		}

		[Token(Token = "0x60017BD")]
		[Address(RVA = "0x3E616F0", Offset = "0x3E5D6F0", VA = "0x3E616F0")]
		public void EquipCardChangeInfo(UserHeroCardData _toEquipData, UserHeroCardData _data)
		{
		}

		[Token(Token = "0x60017BE")]
		[Address(RVA = "0x3E61994", Offset = "0x3E5D994", VA = "0x3E61994")]
		public void RecordUserHexData(UserOutsiderHexData data)
		{
		}

		[Token(Token = "0x60017BF")]
		[Address(RVA = "0x3E61A6C", Offset = "0x3E5DA6C", VA = "0x3E61A6C")]
		public bool GetNewCardData()
		{
			return default;
		}

		[Token(Token = "0x60017C0")]
		[Address(RVA = "0x3E620E8", Offset = "0x3E5E0E8", VA = "0x3E620E8")]
		public void RemoveStayNewCard(string cardID)
		{
		}

		[Token(Token = "0x60017C1")]
		[Address(RVA = "0x3E617F4", Offset = "0x3E5D7F4", VA = "0x3E617F4")]
		public void EquipChangePos(UserHeroCardData data, UserHeroCardData toEquipData)
		{
		}

		[Token(Token = "0x60017C2")]
		[Address(RVA = "0x3E610D0", Offset = "0x3E5D0D0", VA = "0x3E610D0")]
		[AsyncStateMachine(typeof(_003CGetCardReward_003Ed__37))]
		public void GetCardReward(List<UserHeroCardData> cardList)
		{
		}

		[Token(Token = "0x60017C3")]
		[Address(RVA = "0x3E621A0", Offset = "0x3E5E1A0", VA = "0x3E621A0")]
		public UserHeroCardData HasCard(string id)
		{
			return null;
		}

		[Token(Token = "0x60017C4")]
		[Address(RVA = "0x3E62330", Offset = "0x3E5E330", VA = "0x3E62330")]
		public UserHeroCardData GetCardInfo(string id)
		{
			return null;
		}

		[Token(Token = "0x60017C5")]
		[Address(RVA = "0x3E624C0", Offset = "0x3E5E4C0", VA = "0x3E624C0")]
		public bool HasAllCard()
		{
			return default;
		}

		[Token(Token = "0x60017C6")]
		[Address(RVA = "0x3E625A8", Offset = "0x3E5E5A8", VA = "0x3E625A8")]
		public bool UnlockNewCard()
		{
			return default;
		}

		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x3E629C4", Offset = "0x3E5E9C4", VA = "0x3E629C4")]
		public RareLevel GetCardRare(string cardId)
		{
			return default;
		}

		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x3E62A90", Offset = "0x3E5EA90", VA = "0x3E62A90")]
		public void UserCardRandomGetFive()
		{
		}

		[Token(Token = "0x60017C9")]
		[Address(RVA = "0x3E62BB4", Offset = "0x3E5EBB4", VA = "0x3E62BB4")]
		private void InitUserCardDeckData()
		{
		}

		[Token(Token = "0x60017CA")]
		[Address(RVA = "0x3E63100", Offset = "0x3E5F100", VA = "0x3E63100")]
		public List<UserHeroCardData> GetRandomCardByRareLevel(string rareLevel, int count, bool randomFromOwnedCards, List<string> exculdCard, bool isNewCard = false)
		{
			return null;
		}

		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x3E63670", Offset = "0x3E5F670", VA = "0x3E63670")]
		public static List<string> BuildRandomRewardExcludedCardIds([Optional] IEnumerable<string> extraExcludedCardIds)
		{
			return null;
		}

		[Token(Token = "0x60017CC")]
		[Address(RVA = "0x3E63C30", Offset = "0x3E5FC30", VA = "0x3E63C30")]
		private void InitHeroCardData()
		{
		}

		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x3E64F58", Offset = "0x3E60F58", VA = "0x3E64F58")]
		[AsyncStateMachine(typeof(_003CGetGeneralCardIcon_003Ed__48))]
		public UniTask<Sprite> GetGeneralCardIcon(UserHeroCardData data)
		{
			return default;
		}

		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x3E65038", Offset = "0x3E61038", VA = "0x3E65038")]
		public int GetGeneralCardCount(UserHeroCardData data)
		{
			return default;
		}

		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x3E65170", Offset = "0x3E61170", VA = "0x3E65170")]
		public int GetCardUpgradeConsumption(UserHeroCardData data)
		{
			return default;
		}

		[Token(Token = "0x60017D0")]
		[Address(RVA = "0x3E650A0", Offset = "0x3E610A0", VA = "0x3E650A0")]
		public string GetGeneralCardResourcesId(UserHeroCardData data)
		{
			return null;
		}

		[Token(Token = "0x60017D1")]
		[Address(RVA = "0x3E65284", Offset = "0x3E61284", VA = "0x3E65284")]
		public int GetAllCardCount()
		{
			return default;
		}

		[Token(Token = "0x60017D2")]
		[Address(RVA = "0x3E65308", Offset = "0x3E61308", VA = "0x3E65308")]
		public int GetAllUnlockCardCount()
		{
			return default;
		}

		[Token(Token = "0x60017D3")]
		[Address(RVA = "0x3E654A8", Offset = "0x3E614A8", VA = "0x3E654A8")]
		public HeroCardManager()
		{
		}
	}
}
