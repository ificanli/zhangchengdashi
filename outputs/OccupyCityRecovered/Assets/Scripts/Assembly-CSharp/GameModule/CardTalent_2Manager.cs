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
		    try
		    {
		        CardTalent_2Manager self = _003C_003E4__this;
		        if (self.NewAbility2IsBTest())
		        {
		            PlayerCardData cardData = DbtSaveDataManager_PlayerCardData.I.Data;
		            Dictionary<string, List<Talent2Data>> saved = cardData.UserHeroCardTalent2Data;
		            List<UserHeroCardData> heroes = cardData.userHeroCardDataList;
		            if (saved == null || saved.Count < heroes.Count)
		            {
		                if (saved == null)
		                {
		                    cardData.UserHeroCardTalent2Data = new Dictionary<string, List<Talent2Data>>();
		                    saved = DbtSaveDataManager_PlayerCardData.I.Data.UserHeroCardTalent2Data;
		                }
		                Dictionary<string, GlobalCardTalent2Info> bases = DataManager.Instance.GlobalInfo.globalCardTalent2BaseInfoDic;
		                foreach (UserHeroCardData hero in heroes)
		                {
		                    if (hero.id != "1001" && !saved.ContainsKey(hero.id) && bases.TryGetValue(hero.id, out GlobalCardTalent2Info info))
		                    {
		                        string[] have = info.cardHaveTalent.Split(';');
		                        List<Talent2Data> list = new List<Talent2Data>();
		                        for (int i = 0; i < have.Length; i++)
		                        {
		                            Talent2Data node = new Talent2Data();
		                            node.id = have[i];
		                            node.level = 1;
		                            node.talentIndex = 0;
		                            node.baseId = have[i];
		                            list.Add(node);
		                        }
		                        string[] epic = info.cardEpicTalent.Split(';');
		                        int goldStart = 1;
		                        for (int i = 0; i < epic.Length; i++)
		                        {
		                            Talent2Data node = new Talent2Data();
		                            node.id = epic[i];
		                            node.level = 0;
		                            node.talentIndex = i + 1;
		                            node.baseId = epic[i];
		                            list.Add(node);
		                            goldStart = i + 2;
		                        }
		                        string[] gold = info.cardGoldTalent.Split(';');
		                        for (int i = 0; i < gold.Length; i++)
		                        {
		                            Talent2Data node = new Talent2Data();
		                            node.id = gold[i];
		                            node.baseId = gold[i];
		                            RareLevel rare = HeroCardManager.Instance.GetCardRare(hero.id);
		                            if ((uint)rare <= 2u) node.level = 0;
		                            else if (rare == RareLevel.SSSR) node.level = 1;
		                            node.talentIndex = goldStart + i;
		                            list.Add(node);
		                        }
		                        saved.Add(hero.id, list);
		                    }
		                }
		                DbtSaveDataManager_PlayerCardData.I.Save();
		            }
		            if (!DbtSaveDataManager_PlayerCardData.I.Data.hadHandlePlayerAbilityStone)
		            {
		                List<UserHeroCardData> data = DbtSaveDataManager_PlayerCardData.I.Data.userHeroCardDataList;
		                Dictionary<string, GlobalUpgradeTalentPriceInfo> prices = DataManager.Instance.GlobalInfo.upgradeTalentPriceDic;
		                int threshold = prices.TryGetValue("1", out GlobalUpgradeTalentPriceInfo first) ? StringTool.ToInt(first.unlockLevel) : 10;
		                bool recorded = false;
		                foreach (UserHeroCardData hero in data)
		                {
		                    if (hero.id != "1001")
		                    {
		                        if (!(recorded | (hero.level < threshold)))
		                        {
		                            DbtSaveDataManager_PlayerShopData.I.Data.canPushRuneStonePack = true;
		                            DbtSaveDataManager_PlayerShopData.I.Save();
		                            recorded = true;
		                        }
		                        if (hero.level >= 2)
		                        {
		                            switch (hero.GetRareLevel())
		                            {
		                                case RareLevel.R: UserResourcesManager.Instance.AddResourceCount("20018", unchecked(hero.level - 1), false, (CurrencyTransactionSceneType)53, false, (CurrencyType)1); break;
		                                case RareLevel.SR: UserResourcesManager.Instance.AddResourceCount("20018", unchecked(2 * hero.level - 2), false, (CurrencyTransactionSceneType)53, false, (CurrencyType)1); break;
		                                case RareLevel.SSR: UserResourcesManager.Instance.AddResourceCount("20018", unchecked(3 * hero.level - 3), false, (CurrencyTransactionSceneType)53, false, (CurrencyType)1); break;
		                                case RareLevel.SSSR: UserResourcesManager.Instance.AddResourceCount("20018", unchecked(4 * hero.level - 4), false, (CurrencyTransactionSceneType)53, false, (CurrencyType)1); break;
		                            }
		                        }
		                    }
		                }
		                List<UserTileData> tiles = DbtSaveDataManager_PlayerMainCityData.I.Data.tileDatas;
		                for (int i = 0; i < tiles.Count; i++)
		                {
		                    if (tiles[i] != null && tiles[i].tileTypeID == "20001" && tiles[i].enemyConfig != null)
		                    {
		                        if (tiles[i].enemyConfig.cardTalentUnLockDic2 == null) tiles[i].enemyConfig.cardTalentUnLockDic2 = new Dictionary<string, List<int>>();
		                        Dictionary<string, GlobalCardTalent2Info> bases = DataManager.Instance.GlobalInfo.globalCardTalent2BaseInfoDic;
		                        Dictionary<string, GlobalUpgradeTalentPriceInfo> costs = DataManager.Instance.GlobalInfo.upgradeTalentPriceDic;
		                        EnemyBattleDataCofig enemy = tiles[i].enemyConfig;
		                        for (int j = 0; j < enemy.battleCardIDList.Count; j++)
		                        {
		                            if (enemy.battleCardIDList[j] != "1001")
		                            {
		                                List<int> unlocked = new List<int>();
		                                GlobalCardTalent2Info info = bases[enemy.battleCardIDList[j]];
		                                string[] have = info.cardHaveTalent.Split(';');
		                                for (int k = 0; k < have.Length; k++) unlocked.Add(StringTool.ToInt(have[k]));
		                                string[] epic = info.cardEpicTalent.Split(';');
		                                for (int k = 0; k < epic.Length; k++)
		                                {
		                                    GlobalUpgradeTalentPriceInfo cost = costs[(k + 1).ToString()];
		                                    if (enemy.cardLevelDic[enemy.battleCardIDList[j]] >= StringTool.ToInt(cost.unlockLevel)) unlocked.Add(StringTool.ToInt(epic[k]));
		                                }
		                                string[] gold = info.cardGoldTalent.Split(';');
		                                for (int k = 0; k < gold.Length; k++)
		                                {
		                                    GlobalUpgradeTalentPriceInfo cost = costs["3"];
		                                    if (HeroCardManager.Instance.GetCardIsSSSR(enemy.battleCardIDList[j]) || enemy.cardLevelDic[enemy.battleCardIDList[j]] >= StringTool.ToInt(cost.unlockLevel)) unlocked.Add(StringTool.ToInt(gold[k]));
		                                }
		                                tiles[i].enemyConfig.cardTalentUnLockDic2.Add(enemy.battleCardIDList[j], unlocked);
		                            }
		                        }
		                    }
		                }
		                DbtSaveDataManager_PlayerMainCityData.I.Save();
		                DbtSaveDataManager_PlayerCardData.I.Data.hadHandlePlayerAbilityStone = true;
		                DbtSaveDataManager_PlayerCardData.I.Save();
		            }
		            EventModule.EventManager.Instance.StartListening("CardUpgrade", self.CardUpgrade);
		            EventModule.EventManager.Instance.StartListening("BuyRuneStonePack", self.BuyRuneStonePack);
		        }
		    }
		    catch (Exception ex)
		    {
		        _003C_003E1__state = -2;
		        _003C_003Et__builder.SetException(ex);
		        return;
		    }
		    _003C_003E1__state = -2;
		    _003C_003Et__builder.SetResult();
		}

			[Token(Token = "0x600125C")]
			[Address(RVA = "0x3DCE2C4", Offset = "0x3DCA2C4", VA = "0x3DCE2C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{ _003C_003Et__builder.SetStateMachine(stateMachine); }
		}

		[Token(Token = "0x4002793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<string, Func<string, TalentBase>> talentCreators = new Dictionary<string, Func<string, TalentBase>>()
    {
        { "10001", id => new PoHuaiZheTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "10002", id => new PoHuaiZheTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "10011", id => new LieShouTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "10012", id => new LieShouTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "10021", id => new JianGuTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "10022", id => new JianGuTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "10031", id => new KongZhongYouShiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "10032", id => new KongZhongYouShiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "10041", id => new WangLingLieShouTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "10042", id => new WangLingLieShouTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "10051", id => new KongJuZhiYuanTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "10052", id => new KongJuZhiYuanTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "10061", id => new JiXieKeXingTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "10062", id => new JiXieKeXingTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "10071", id => new YeShouShaShouTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "10072", id => new YeShouShaShouTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20001", id => new QiangGongTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20002", id => new QiangGongTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20003", id => new QiangGongTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20011", id => new ShanBiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20012", id => new ShanBiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20013", id => new ShanBiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20021", id => new BaoJiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20022", id => new BaoJiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20023", id => new BaoJiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20031", id => new XiXueTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20032", id => new XiXueTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20033", id => new XiXueTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20041", id => new JianJiaTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20042", id => new JianJiaTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20043", id => new JianJiaTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20051", id => new XuePoTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20052", id => new XuePoTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20053", id => new XuePoTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20061", id => new JiXingTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20062", id => new JiXingTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20063", id => new JiXingTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20071", id => new ChengFangTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20072", id => new ChengFangTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20073", id => new ChengFangTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20081", id => new TiaoWangTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20082", id => new TiaoWangTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "20083", id => new TiaoWangTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300011", id => new ShenShengBiHuTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300012", id => new ShenShengBiHuTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300013", id => new ShenShengBiHuTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300021", id => new JingJiFanJiaTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300022", id => new JingJiFanJiaTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300023", id => new JingJiFanJiaTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300031", id => new XiShengQiYueTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300032", id => new XiShengQiYueTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300033", id => new XiShengQiYueTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300041", id => new BuQuBaoLeiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300042", id => new BuQuBaoLeiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300043", id => new BuQuBaoLeiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300111", id => new LianZhuJianJiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300112", id => new LianZhuJianJiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300113", id => new LianZhuJianJiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300121", id => new YingYanSuoDingTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300122", id => new YingYanSuoDingTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300123", id => new YingYanSuoDingTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300131", id => new YuanJuSheJiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300132", id => new YuanJuSheJiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300133", id => new YuanJuSheJiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300141", id => new SiWangJuJiaoTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300142", id => new SiWangJuJiaoTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300143", id => new SiWangJuJiaoTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300211", id => new ShengMingWaJieTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300212", id => new ShengMingWaJieTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300213", id => new ShengMingWaJieTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300221", id => new LieShaChongCiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300222", id => new LieShaChongCiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300223", id => new LieShaChongCiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300231", id => new RuoDianDongXiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300232", id => new RuoDianDongXiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300233", id => new RuoDianDongXiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300241", id => new AnYingFuJiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300242", id => new AnYingFuJiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300243", id => new AnYingFuJiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300311", id => new HanRenCiGuTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300312", id => new HanRenCiGuTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300313", id => new HanRenCiGuTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300321", id => new YingWuZheHaoZhaoTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300322", id => new YingWuZheHaoZhaoTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300323", id => new YingWuZheHaoZhaoTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300411", id => new FuSuJieJieTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300412", id => new FuSuJieJieTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300413", id => new FuSuJieJieTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300421", id => new ShengLiaoTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300422", id => new ShengLiaoTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300423", id => new ShengLiaoTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300511", id => new ZhenDangBoRenTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300512", id => new ZhenDangBoRenTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300513", id => new ZhenDangBoRenTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300521", id => new ShenJingChongJiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300522", id => new ShenJingChongJiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300523", id => new ShenJingChongJiTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300531", id => new YuXueFenZhanTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300532", id => new YuXueFenZhanTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300533", id => new YuXueFenZhanTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300541", id => new ZhanDouKuangReTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300542", id => new ZhanDouKuangReTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300543", id => new ZhanDouKuangReTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300641", id => new HouPaiShuChuTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300642", id => new HouPaiShuChuTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300643", id => new HouPaiShuChuTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300611", id => new HouQinZhiYuanTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300612", id => new HouQinZhiYuanTalent(id, GetTalentType(id), GetTalentValue(id)) },
        { "300613", id => new HouQinZhiYuanTalent(id, GetTalentType(id), GetTalentValue(id)) }
    };

		[Token(Token = "0x60011DA")]
		[Address(RVA = "0x3DC3084", Offset = "0x3DBF084", VA = "0x3DC3084", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__0))]
		public override UniTask Init()
		{
		    _003CInit_003Ed__0 stateMachine = default;
		    stateMachine._003C_003Et__builder = AsyncUniTaskMethodBuilder.Create();
		    stateMachine._003C_003E4__this = this;
		    stateMachine._003C_003E1__state = -1;
		    stateMachine._003C_003Et__builder.Start(ref stateMachine);
		    return stateMachine._003C_003Et__builder.Task;
		}

		[Token(Token = "0x60011DB")]
		[Address(RVA = "0x3DC3108", Offset = "0x3DBF108", VA = "0x3DC3108")]
		public List<string> GetBattleCardAbility(bool isEnemy, string cardId)
		{
            List<string> result = new List<string>();
            if (isEnemy)
            {
                if (AIBehaviourManager.Instance.cardAllHaveTalent.TryGetValue(cardId, out List<int> talents))
                    for (int i = 0; i < talents.Count; i++) result.Add(talents[i].ToString());
            }
            else if (DbtSaveDataManager_PlayerCardData.I.Data.UserHeroCardTalent2Data.TryGetValue(cardId, out List<Talent2Data> talents))
            {
                for (int i = 0; i < talents.Count; i++)
                    if (talents[i].IsUnLock()) result.Add(talents[i].id);
            }
            return result;
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
		    if (DbtSaveDataManager_PlayerShopData.I.Data.canPushRuneStonePack) return;
		    UserHeroCardData data = o as UserHeroCardData;
		    if (!DataManager.Instance.GlobalInfo.upgradeTalentPriceDic.TryGetValue("1", out GlobalUpgradeTalentPriceInfo info)) return;
		    if (data.level < StringTool.ToInt(info.unlockLevel)) return;
		    DbtSaveDataManager_PlayerShopData.I.Data.canPushRuneStonePack = true;
		    DbtSaveDataManager_PlayerShopData.I.Save();
		    EventModule.EventManager.Instance.TriggerEvent("RefreshRuneStonePack");
		}

		[Token(Token = "0x60011DE")]
		[Address(RVA = "0x3DC3874", Offset = "0x3DBF874", VA = "0x3DC3874")]
		private void BuyRuneStonePack(object o)
		{
		    string key = o.ToString();
		    Dictionary<string, bool> state = DbtSaveDataManager_PlayerShopData.I.Data.playerRuneStoneBuyState;
		    if (state.ContainsKey(key)) state[key] = true;
		    DbtSaveDataManager_PlayerShopData.I.Save();
		    EventModule.EventManager.Instance.TriggerEvent("RefreshRuneStonePack");
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
		{ return SDKModule.ABTestManager.Instance.NewAbilitySystemAbIsOn; }

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
            if (talentCreators.TryGetValue(id, out Func<string, TalentBase> creator)) return creator(id);
            throw new ArgumentException("\u65e0\u6548\u5929\u8d4bID: " + id);
        }

		[Token(Token = "0x60011E7")]
		[Address(RVA = "0x3DC4624", Offset = "0x3DC0624", VA = "0x3DC4624")]
		private static GameEventType GetTalentType(string id)
		{
            return Enum.Parse<GameEventType>(DataManager.Instance.GlobalInfo.cardTalent2InfoDic[id].triggerTiming);
        }

		[Token(Token = "0x60011E8")]
		[Address(RVA = "0x3DC46F0", Offset = "0x3DC06F0", VA = "0x3DC46F0")]
		private static float GetTalentValue(string id)
		{
            return StringTool.ToFloat(DataManager.Instance.GlobalInfo.cardTalent2InfoDic[id].value);
        }

		[Token(Token = "0x60011E9")]
		[Address(RVA = "0x3DC477C", Offset = "0x3DC077C", VA = "0x3DC477C")]
		public CardTalent_2Manager()
		{
		}
	}
}
