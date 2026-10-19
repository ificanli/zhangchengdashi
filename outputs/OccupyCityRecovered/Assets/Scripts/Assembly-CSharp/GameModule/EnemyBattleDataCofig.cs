using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000418")]
	public class EnemyBattleDataCofig
	{
		[Token(Token = "0x40028BB")]
		[FieldOffset(Offset = "0x10")]
		public int attackLevel;

		[Token(Token = "0x40028BC")]
		[FieldOffset(Offset = "0x14")]
		public int hpLevel;

		[Token(Token = "0x40028BD")]
		[FieldOffset(Offset = "0x18")]
		public int cdLevel;

		[Token(Token = "0x40028BE")]
		[FieldOffset(Offset = "0x20")]
		public RankItemData info;

		[Token(Token = "0x40028BF")]
		[FieldOffset(Offset = "0x28")]
		public string enemyPropId;

		[Token(Token = "0x40028C0")]
		[FieldOffset(Offset = "0x30")]
		public List<EnemyPropBattleEntry> enemyPropDataList;

		[Token(Token = "0x40028C1")]
		[FieldOffset(Offset = "0x38")]
		public PropAttrSnapshot enemyPropAttrSnapshot;

		[Token(Token = "0x40028C2")]
		[FieldOffset(Offset = "0x40")]
		public List<string> battleCardIDList;

		[Token(Token = "0x40028C3")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, int> cardLevelDic;

		[Token(Token = "0x40028C4")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, int> cardTalentDic;

		[Token(Token = "0x40028C5")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, List<int>> cardTalentUnLockDic;

		[Token(Token = "0x40028C6")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, List<int>> cardTalentUnLockDic2;

		[Token(Token = "0x40028C7")]
		[FieldOffset(Offset = "0x68")]
		public int difficultLevel;

		[Token(Token = "0x40028C8")]
		[FieldOffset(Offset = "0x70")]
		public string blessId;

		[Token(Token = "0x6001363")]
		[Address(RVA = "0x3DE37FC", Offset = "0x3DDF7FC", VA = "0x3DE37FC")]
		public List<UserHeroCardData> GetCardList()
		{
			return null;
		}

		[Token(Token = "0x6001364")]
		[Address(RVA = "0x3DE3A84", Offset = "0x3DDFA84", VA = "0x3DE3A84")]
		public void SetDifficultLevel(int num)
		{
		}

		[Token(Token = "0x6001365")]
		[Address(RVA = "0x3DE3A8C", Offset = "0x3DDFA8C", VA = "0x3DE3A8C")]
		public EnemyBattleDataCofig()
		{
		}
	}
}
