using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E4A")]
	public class EnemyDifficultLevelInfos : GlobalInfoBase
	{
		[Token(Token = "0x400637A")]
		[FieldOffset(Offset = "0x18")]
		public string mainCityLevel;

		[Token(Token = "0x400637B")]
		[FieldOffset(Offset = "0x20")]
		public string cardLevel;

		[Token(Token = "0x400637C")]
		[FieldOffset(Offset = "0x28")]
		public string trophyCount;

		[Token(Token = "0x400637D")]
		[FieldOffset(Offset = "0x30")]
		public string enemyArtifactCofig;

		[Token(Token = "0x400637E")]
		[FieldOffset(Offset = "0x38")]
		public string enemyCardTalentCofig;

		[Token(Token = "0x400637F")]
		[FieldOffset(Offset = "0x40")]
		public string enemyCardConfig;

		[Token(Token = "0x4006380")]
		[FieldOffset(Offset = "0x48")]
		public string moveInterval;

		[Token(Token = "0x4006381")]
		[FieldOffset(Offset = "0x50")]
		public string newMainCityLevel;

		[Token(Token = "0x4006382")]
		[FieldOffset(Offset = "0x58")]
		public string newMainCityCoinRange;

		[Token(Token = "0x4006383")]
		[FieldOffset(Offset = "0x60")]
		public string enemyTalent2LevelWeight;

		[Token(Token = "0x60057BF")]
		[Address(RVA = "0x4357C70", Offset = "0x4353C70", VA = "0x4357C70")]
		public EnemyDifficultLevelInfos()
		{
		}
	}
}
