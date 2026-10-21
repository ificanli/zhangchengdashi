using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200058D")]
	public class RewardConfig
	{
        [Token(Token = "0x4003037")]
        [Il2CppDummyDll.FieldOffset(Offset = "0x18")]
        [CompilerGenerated]
        private List<RewardConfigSingle> _003CRewardAssetList_003Ek__BackingField;

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
            return _003CRewardAssetList_003Ek__BackingField;
        }
			[Token(Token = "0x6001CC5")]
			[Address(RVA = "0x3ED49BC", Offset = "0x3ED09BC", VA = "0x3ED49BC")]
			[CompilerGenerated]
			private set
			{
            _003CRewardAssetList_003Ek__BackingField = value;
        }
		}

		[Token(Token = "0x6001CC6")]
		[Address(RVA = "0x3ED49C4", Offset = "0x3ED09C4", VA = "0x3ED49C4")]
		public RewardConfig(CurrencyTransactionSceneType currencyTransactionSceneType)
		{
            RewardAssetList = new List<RewardConfigSingle>();
            this.currencyTransactionSceneType = currencyTransactionSceneType;
        }

		[Token(Token = "0x6001CC7")]
		[Address(RVA = "0x3ED4A4C", Offset = "0x3ED0A4C", VA = "0x3ED4A4C")]
		public int GetRewardAssetNum(string assetId)
		{
            if (RewardAssetList == null || RewardAssetList.Count == 0) return 0;
            if (RewardAssetList.Find(item => item.Info.Id == assetId) == null) return 0;
            return ToolModule.StringTool.ToInt(RewardAssetList.Find(item => item.Info.Id == assetId).Num);
        }

		[Token(Token = "0x6001CC8")]
		[Address(RVA = "0x3ED366C", Offset = "0x3ECF66C", VA = "0x3ED366C")]
		public RewardConfig(string reward, CurrencyTransactionSceneType currencyTransactionSceneType)
		{
            string[] entries = reward.Split(';');
            var parsed = new List<RewardConfigSingle>();
            foreach (string entry in entries)
            {
                if (!ToolModule.StringTool.IsNullOrEmpty(entry))
                {
                    string[] parts = entry.Split(':');
                    string infoId = parts[0];
                    List<string> args = ToolModule.StringTool.ToList(parts[1], ',');
                    parsed.Add(new RewardConfigSingle(infoId, args));
                }
            }
            RewardAssetList = parsed;
            this.currencyTransactionSceneType = currencyTransactionSceneType;
        }

		[Token(Token = "0x6001CC9")]
		[Address(RVA = "0x3ED4CAC", Offset = "0x3ED0CAC", VA = "0x3ED4CAC")]
		public RewardConfig(List<RewardConfigSingle> rewardAssetList, CurrencyTransactionSceneType currencyTransactionSceneType)
		{
            RewardAssetList = rewardAssetList;
            this.currencyTransactionSceneType = currencyTransactionSceneType;
        }

		[Token(Token = "0x6001CCA")]
		[Address(RVA = "0x3ED4CDC", Offset = "0x3ED0CDC", VA = "0x3ED4CDC")]
		public void AddAssetDataList(List<RewardConfigSingle> assetList)
		{
            if (RewardAssetList == null || RewardAssetList.Count == 0)
            {
                if (RewardAssetList == null) RewardAssetList = new List<RewardConfigSingle>();
                RewardAssetList.AddRange(assetList);
            }
            else
            {
                foreach (RewardConfigSingle item in assetList) AddReward(item);
            }
        }

		[Token(Token = "0x6001CCB")]
		[Address(RVA = "0x3ED5028", Offset = "0x3ED1028", VA = "0x3ED5028")]
		public void AddResources(string assetId, string num)
		{
            RewardConfigSingle existing = RewardAssetList.Find(item => item.Info.Id == assetId);
            if (existing == null || !existing.TryAddNum(num)) RewardAssetList.Add(new RewardConfigSingle(assetId, num, null));
        }

		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x3ED4EC0", Offset = "0x3ED0EC0", VA = "0x3ED4EC0")]
		public void AddReward(RewardConfigSingle newReward)
		{
            RewardConfigSingle existing = RewardAssetList.Find(item => item.Info == newReward.Info);
            if (existing == null || !existing.TryAddNum(newReward.Num)) RewardAssetList.Add(newReward);
        }

		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x3ED5308", Offset = "0x3ED1308", VA = "0x3ED5308")]
		public void AddResources(string assetId, BigInteger num)
		{
            AddResources(assetId, num.ToString());
        }

		[Token(Token = "0x6001CCE")]
		[Address(RVA = "0x3ED3C40", Offset = "0x3ECFC40", VA = "0x3ED3C40")]
		public void ApplyReward(bool isFirst = true)
		{
            foreach (RewardConfigSingle item in RewardAssetList) item.ApplyReward(isFirst, currencyTransactionSceneType);
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
