using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200058D")]
	public class RewardConfig
	{
		[Token(Token = "0x4003036")]
		[FieldOffset(Offset = "0x10")]
		public CurrencyTransactionSceneType currencyTransactionSceneType;

		[Token(Token = "0x17000179")]
		public List<RewardConfigSingle> RewardAssetList
		{
			[Token(Token = "0x6001CC4")]
			[Address(RVA = "0x3ED49B4", Offset = "0x3ED09B4", VA = "0x3ED49B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CC5")]
			[Address(RVA = "0x3ED49BC", Offset = "0x3ED09BC", VA = "0x3ED49BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6001CC6")]
		[Address(RVA = "0x3ED49C4", Offset = "0x3ED09C4", VA = "0x3ED49C4")]
		public RewardConfig(CurrencyTransactionSceneType currencyTransactionSceneType)
		{
		}

		[Token(Token = "0x6001CC7")]
		[Address(RVA = "0x3ED4A4C", Offset = "0x3ED0A4C", VA = "0x3ED4A4C")]
		public int GetRewardAssetNum(string assetId)
		{
			return default;
		}

		[Token(Token = "0x6001CC8")]
		[Address(RVA = "0x3ED366C", Offset = "0x3ECF66C", VA = "0x3ED366C")]
		public RewardConfig(string reward, CurrencyTransactionSceneType currencyTransactionSceneType)
		{
		}

		[Token(Token = "0x6001CC9")]
		[Address(RVA = "0x3ED4CAC", Offset = "0x3ED0CAC", VA = "0x3ED4CAC")]
		public RewardConfig(List<RewardConfigSingle> rewardAssetList, CurrencyTransactionSceneType currencyTransactionSceneType)
		{
		}

		[Token(Token = "0x6001CCA")]
		[Address(RVA = "0x3ED4CDC", Offset = "0x3ED0CDC", VA = "0x3ED4CDC")]
		public void AddAssetDataList(List<RewardConfigSingle> assetList)
		{
		}

		[Token(Token = "0x6001CCB")]
		[Address(RVA = "0x3ED5028", Offset = "0x3ED1028", VA = "0x3ED5028")]
		public void AddResources(string assetId, string num)
		{
		}

		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x3ED4EC0", Offset = "0x3ED0EC0", VA = "0x3ED4EC0")]
		public void AddReward(RewardConfigSingle newReward)
		{
		}

		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x3ED5308", Offset = "0x3ED1308", VA = "0x3ED5308")]
		public void AddResources(string assetId, BigInteger num)
		{
		}

		[Token(Token = "0x6001CCE")]
		[Address(RVA = "0x3ED3C40", Offset = "0x3ECFC40", VA = "0x3ED3C40")]
		public void ApplyReward(bool isFirst = true)
		{
		}

		[Token(Token = "0x6001CCF")]
		[Address(RVA = "0x3ED5518", Offset = "0x3ED1518", VA = "0x3ED5518")]
		public void RemoveReward()
		{
		}

		[Token(Token = "0x6001CD0")]
		[Address(RVA = "0x3ED56C4", Offset = "0x3ED16C4", VA = "0x3ED56C4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6001CD1")]
		[Address(RVA = "0x3ED5734", Offset = "0x3ED1734", VA = "0x3ED5734")]
		public void ScaleAllNumericRewards(float ratio)
		{
		}
	}
}
