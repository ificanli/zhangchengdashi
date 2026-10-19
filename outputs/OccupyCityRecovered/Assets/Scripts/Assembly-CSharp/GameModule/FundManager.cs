using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000499")]
	public class FundManager : ManagerBase<FundManager>
	{
		[Token(Token = "0x200049A")]
		public enum FundType
		{
			[Token(Token = "0x4002B7E")]
			AbilityFund = 0,
			[Token(Token = "0x4002B7F")]
			SummonFund = 1,
			[Token(Token = "0x4002B80")]
			CardFund = 2,
			[Token(Token = "0x4002B81")]
			MainCityPass = 3,
			[Token(Token = "0x4002B82")]
			SeasonPass = 4
		}

		[Token(Token = "0x200049B")]
		public class FundLevelData
		{
			[Token(Token = "0x4002B86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dictionary<string, List<HWRewardItem>> allReward;

			[Token(Token = "0x1700014B")]
			public string rewardStr
			{
				[Token(Token = "0x6001702")]
				[Address(RVA = "0x3E53CC8", Offset = "0x3E4FCC8", VA = "0x3E53CC8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001703")]
				[Address(RVA = "0x3E53CD0", Offset = "0x3E4FCD0", VA = "0x3E53CD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700014C")]
			public int Level
			{
				[Token(Token = "0x6001704")]
				[Address(RVA = "0x3E53CD8", Offset = "0x3E4FCD8", VA = "0x3E53CD8")]
				[CompilerGenerated]
				get;
				[Token(Token = "0x6001705")]
				[Address(RVA = "0x3E53CE0", Offset = "0x3E4FCE0", VA = "0x3E53CE0")]
				[CompilerGenerated]
				set;
			}

			[Token(Token = "0x1700014D")]
			public int Need
			{
				[Token(Token = "0x6001706")]
				[Address(RVA = "0x3E53CE8", Offset = "0x3E4FCE8", VA = "0x3E53CE8")]
				[CompilerGenerated]
				get;
				[Token(Token = "0x6001707")]
				[Address(RVA = "0x3E53CF0", Offset = "0x3E4FCF0", VA = "0x3E53CF0")]
				[CompilerGenerated]
				set;
			}

			[Token(Token = "0x6001708")]
			[Address(RVA = "0x3E52990", Offset = "0x3E4E990", VA = "0x3E52990")]
			public FundLevelData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200049C")]
		public class HWRewardItem
		{
			[Token(Token = "0x4002B87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string assetId;

			[Token(Token = "0x4002B88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BigInteger value;

			[Token(Token = "0x4002B89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RewardConfigSingle rewardConfigSingle;

			[Token(Token = "0x6001709")]
			[Address(RVA = "0x3E52B08", Offset = "0x3E4EB08", VA = "0x3E52B08")]
			public HWRewardItem()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200049F")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4002B8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002B8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002B8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FundManager _003C_003E4__this;

			[Token(Token = "0x600170F")]
			[Address(RVA = "0x3E53EAC", Offset = "0x3E4FEAC", VA = "0x3E53EAC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001710")]
			[Address(RVA = "0x3E543A0", Offset = "0x3E503A0", VA = "0x3E543A0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002B78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<FundType, Dictionary<int, FundLevelData>> _levelDataDict;

		[Token(Token = "0x4002B79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FundType currentShowFundType;

		[Token(Token = "0x4002B7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FundController fundController;

		[Token(Token = "0x4002B7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool hadInit;

		[Token(Token = "0x4002B7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<FundType, int> addActivityCache;

		[Token(Token = "0x1700014A")]
		public FundType CurrentShowFundType
		{
			[Token(Token = "0x60016DF")]
			[Address(RVA = "0x3E4FA04", Offset = "0x3E4BA04", VA = "0x3E4FA04")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60016E0")]
		[Address(RVA = "0x3E4FA0C", Offset = "0x3E4BA0C", VA = "0x3E4FA0C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__7))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60016E1")]
		[Address(RVA = "0x3E4FA90", Offset = "0x3E4BA90", VA = "0x3E4FA90")]
		public void UpdateAllRedDot()
		{
		}

		[Token(Token = "0x60016E2")]
		[Address(RVA = "0x3E4FDCC", Offset = "0x3E4BDCC", VA = "0x3E4FDCC")]
		public void UpdateRedDot(FundType fundType)
		{
		}

		[Token(Token = "0x60016E3")]
		[Address(RVA = "0x3E50274", Offset = "0x3E4C274", VA = "0x3E50274")]
		public bool GetIsCanClaim(FundType fundType)
		{
			return default;
		}

		[Token(Token = "0x60016E4")]
		[Address(RVA = "0x3E5028C", Offset = "0x3E4C28C", VA = "0x3E5028C")]
		public int GetCanClaimCount(FundType fundType)
		{
			return default;
		}

		[Token(Token = "0x60016E5")]
		[Address(RVA = "0x3E50698", Offset = "0x3E4C698", VA = "0x3E50698")]
		public bool IsFundFullyCompleted(FundType fundType)
		{
			return default;
		}

		[Token(Token = "0x60016E6")]
		[Address(RVA = "0x3E50A30", Offset = "0x3E4CA30", VA = "0x3E50A30")]
		public bool ShouldShowFundObtainGuideWay(FundType fundType)
		{
			return default;
		}

		[Token(Token = "0x60016E7")]
		[Address(RVA = "0x3E50A70", Offset = "0x3E4CA70", VA = "0x3E50A70")]
		private bool IsFundEntryAvailable(FundType fundType)
		{
			return default;
		}

		[Token(Token = "0x60016E8")]
		[Address(RVA = "0x3E50BD0", Offset = "0x3E4CBD0", VA = "0x3E50BD0")]
		public void ClaimFundRewards(FundType fundType, string iapID, int level, [Optional] Transform transform)
		{
		}

		[Token(Token = "0x60016E9")]
		[Address(RVA = "0x3E51184", Offset = "0x3E4D184", VA = "0x3E51184")]
		private void GetReward(List<HWRewardItem> allReward, [Optional] Transform trans)
		{
		}

		[Token(Token = "0x60016EA")]
		[Address(RVA = "0x3E51994", Offset = "0x3E4D994", VA = "0x3E51994")]
		private void GetReward(string allReward)
		{
		}

		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x3E51998", Offset = "0x3E4D998", VA = "0x3E51998")]
		public void AddActivity(FundType fundType, int value)
		{
		}

		[Token(Token = "0x60016EC")]
		[Address(RVA = "0x3E51E18", Offset = "0x3E4DE18", VA = "0x3E51E18")]
		public int GetActivity(FundType fundType)
		{
			return default;
		}

		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x3E50900", Offset = "0x3E4C900", VA = "0x3E50900")]
		public FundData GetFundData(FundType fundType)
		{
			return null;
		}

		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x3E51E44", Offset = "0x3E4DE44", VA = "0x3E51E44")]
		public int GetActivityToNextLevel(FundType fundType)
		{
			return default;
		}

		[Token(Token = "0x60016EF")]
		[Address(RVA = "0x3E51EE8", Offset = "0x3E4DEE8", VA = "0x3E51EE8")]
		public int GetCurrentLevelActivity(FundType fundType)
		{
			return default;
		}

		[Token(Token = "0x60016F0")]
		[Address(RVA = "0x3E51ECC", Offset = "0x3E4DECC", VA = "0x3E51ECC")]
		public int GetFundLevel(FundType fundType)
		{
			return default;
		}

		[Token(Token = "0x60016F1")]
		[Address(RVA = "0x3E5192C", Offset = "0x3E4D92C", VA = "0x3E5192C")]
		public void SaveInfo()
		{
		}

		[Token(Token = "0x60016F2")]
		[Address(RVA = "0x3E51850", Offset = "0x3E4D850", VA = "0x3E51850")]
		public void UpdatePanel()
		{
		}

		[Token(Token = "0x60016F3")]
		[Address(RVA = "0x3E51F50", Offset = "0x3E4DF50", VA = "0x3E51F50")]
		public void UpdatePanelType(FundType fundType)
		{
		}

		[Token(Token = "0x60016F4")]
		[Address(RVA = "0x3E5224C", Offset = "0x3E4E24C", VA = "0x3E5224C")]
		private void Update()
		{
		}

		[Token(Token = "0x60016F5")]
		[Address(RVA = "0x3E52250", Offset = "0x3E4E250", VA = "0x3E52250")]
		public void Initialize(FundType fundType, List<GlobalFundInfo> fundInfos)
		{
		}

		[Token(Token = "0x60016F6")]
		[Address(RVA = "0x3E52A0C", Offset = "0x3E4EA0C", VA = "0x3E52A0C")]
		public FundIAPInfo GetFundIAPInfo(FundType fundType)
		{
			return null;
		}

		[Token(Token = "0x60016F7")]
		[Address(RVA = "0x3E525F8", Offset = "0x3E4E5F8", VA = "0x3E525F8")]
		public List<HWRewardItem> GetHwRewardItems(string rewardsStr)
		{
			return null;
		}

		[Token(Token = "0x60016F8")]
		[Address(RVA = "0x3E52B10", Offset = "0x3E4EB10", VA = "0x3E52B10")]
		public void ShowPassPanel151([Optional] FundType? defaultFundType, [Optional] string placement)
		{
		}

		[Token(Token = "0x60016F9")]
		[Address(RVA = "0x3E533D4", Offset = "0x3E4F3D4", VA = "0x3E533D4")]
		public void ShowSeasonPassPanel([Optional] string placement)
		{
		}

		[Token(Token = "0x60016FA")]
		[Address(RVA = "0x3E52F88", Offset = "0x3E4EF88", VA = "0x3E52F88")]
		private void ShowPassPanel(List<FundType> fundTypes, FundType defaultFundType, [Optional] string placement)
		{
		}

		[Token(Token = "0x60016FB")]
		[Address(RVA = "0x3E510E4", Offset = "0x3E4D0E4", VA = "0x3E510E4")]
		public FundLevelData GetLevelData(FundType fundType, int level)
		{
			return null;
		}

		[Token(Token = "0x60016FC")]
		[Address(RVA = "0x3E5098C", Offset = "0x3E4C98C", VA = "0x3E5098C")]
		public FundLevelData GetMaxLevelData(FundType fundType)
		{
			return null;
		}

		[Token(Token = "0x60016FD")]
		[Address(RVA = "0x3E509B8", Offset = "0x3E4C9B8", VA = "0x3E509B8")]
		public int GetMaxLevel(FundType fundType)
		{
			return default;
		}

		[Token(Token = "0x60016FE")]
		[Address(RVA = "0x3E53700", Offset = "0x3E4F700", VA = "0x3E53700")]
		public FundManager()
		{
		}
	}
}
