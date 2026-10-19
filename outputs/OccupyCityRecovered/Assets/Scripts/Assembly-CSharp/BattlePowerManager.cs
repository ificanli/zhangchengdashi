using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using ToolModule;

[Token(Token = "0x2000057")]
public class BattlePowerManager : ManagerBase<BattlePowerManager>
{
	[Token(Token = "0x40001A1")]
	private const float CardHpCPWeight = 0.5f;

	[Token(Token = "0x40001A2")]
	private const float CardAtkCPWeight = 1f;

	[Token(Token = "0x40001A3")]
	private const float CardBuildHpCPWeight = 0.8f;

	[Token(Token = "0x40001A4")]
	private const float CardSpeedCPWeight = 0.2f;

	[Token(Token = "0x40001A5")]
	private const float RareTalenCPWeight = 0.2f;

	[Token(Token = "0x40001A6")]
	private const float EpicTalenCPWeight = 0.4f;

	[Token(Token = "0x40001A7")]
	private const float LengdaryTalenCPWeight = 0.8f;

	[Token(Token = "0x40001A8")]
	private const float ActivateEntryOne = 0.2f;

	[Token(Token = "0x40001A9")]
	private const float ActivateEntryTwo = 0.5f;

	[Token(Token = "0x40001AA")]
	private const float ActivateEntryThere = 0.3f;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _isListeningBattleDataEvents;

	[Token(Token = "0x17000013")]
	public int CurrentDeckBattlePower
	{
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x3D0D438", Offset = "0x3D09438", VA = "0x3D0D438")]
		[CompilerGenerated]
		get;
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x3D0D440", Offset = "0x3D09440", VA = "0x3D0D440")]
		[CompilerGenerated]
		private set;
	}

	[Token(Token = "0x17000014")]
	public int CurrentBattlePower
	{
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x3D0D448", Offset = "0x3D09448", VA = "0x3D0D448")]
		[CompilerGenerated]
		get;
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x3D0D450", Offset = "0x3D09450", VA = "0x3D0D450")]
		[CompilerGenerated]
		private set;
	}

	[Token(Token = "0x17000015")]
	public PlayerBattlePowerChangeInfo LastBattlePowerChange
	{
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x3D0D458", Offset = "0x3D09458", VA = "0x3D0D458")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x3D0D464", Offset = "0x3D09464", VA = "0x3D0D464")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public float AIProp_Difficulty
	{
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x3D0D46C", Offset = "0x3D0946C", VA = "0x3D0D46C")]
		[CompilerGenerated]
		get;
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x3D0D474", Offset = "0x3D09474", VA = "0x3D0D474")]
		[CompilerGenerated]
		private set;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x3D0D47C", Offset = "0x3D0947C", VA = "0x3D0D47C", Slot = "4")]
	public override UniTask Init()
	{
		return default;
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x3D0D8C8", Offset = "0x3D098C8", VA = "0x3D0D8C8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x3D0D674", Offset = "0x3D09674", VA = "0x3D0D674")]
	private void StartListeningBattleDataEvents()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x3D0D8CC", Offset = "0x3D098CC", VA = "0x3D0D8CC")]
	private void StopListeningBattleDataEvents()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x3D0DB1C", Offset = "0x3D09B1C", VA = "0x3D0DB1C")]
	private void OnBattleDataChanged(object obj)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x3D0DBCC", Offset = "0x3D09BCC", VA = "0x3D0DBCC")]
	public int GetPlayerTotalPower()
	{
		return default;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x3D0DBD4", Offset = "0x3D09BD4", VA = "0x3D0DBD4")]
	public int GetPlayerDeckBattlePower()
	{
		return default;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x3D0DBDC", Offset = "0x3D09BDC", VA = "0x3D0DBDC")]
	public static bool IsPlayerArtifactBattlePowerEnabled()
	{
		return default;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x3D0DC48", Offset = "0x3D09C48", VA = "0x3D0DC48")]
	public static bool IsEnemyArtifactBattlePowerEnabled()
	{
		return default;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x3D0DCF8", Offset = "0x3D09CF8", VA = "0x3D0DCF8")]
	public int CalculateDeckBattlePower(BattlePowerSideInput input)
	{
		return default;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x3D0E038", Offset = "0x3D0A038", VA = "0x3D0E038")]
	public int CalculateTotalBattlePower(BattlePowerSideInput input)
	{
		return default;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x3D0E748", Offset = "0x3D0A748", VA = "0x3D0E748")]
	public static BattlePowerSideInput BuildPlayerBattlePowerSideInput()
	{
		return default;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x3D0EF50", Offset = "0x3D0AF50", VA = "0x3D0EF50")]
	public int GetArtifactBattlePower(UserPropData prop)
	{
		return default;
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x3D0DB20", Offset = "0x3D09B20", VA = "0x3D0DB20")]
	public void RefreshPlayerBattlePower()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x3D0F22C", Offset = "0x3D0B22C", VA = "0x3D0F22C")]
	private void NotifyBattlePowerChanged(PlayerBattlePowerChangeInfo changeInfo)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x3D0F2E0", Offset = "0x3D0B2E0", VA = "0x3D0F2E0")]
	private static float GetPropAttrTypeBattleFactor(PropManager.PropAttrType attrType)
	{
		return default;
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x3D0E16C", Offset = "0x3D0A16C", VA = "0x3D0E16C")]
	private static float GetAttrBattlePowerRatioFromArtifacts(List<ArtifactBattleEntry> activatedArtifacts)
	{
		return default;
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x3D0F060", Offset = "0x3D0B060", VA = "0x3D0F060")]
	private static float GetSingleArtifactAttrBattlePowerMultiplier(ArtifactBattleEntry entry)
	{
		return default;
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x3D0E504", Offset = "0x3D0A504", VA = "0x3D0E504")]
	private static float GetSkillBattlePowerRatio(ArtifactBattleEntry entry)
	{
		return default;
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x3D0E640", Offset = "0x3D0A640", VA = "0x3D0E640")]
	private static float GetForgeBattlePowerRatio(ArtifactBattleEntry entry)
	{
		return default;
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x3D0E3B4", Offset = "0x3D0A3B4", VA = "0x3D0E3B4")]
	private static bool TryFindEquipArtifactEntry(string equipPropId, List<ArtifactBattleEntry> activatedArtifacts, out ArtifactBattleEntry equipEntry)
	{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BattlePowerManager.TryFindEquipArtifactEntry RVA=0x3D0E3B4 Token=0x60001A6");
}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x3D0F390", Offset = "0x3D0B390", VA = "0x3D0F390")]
	private static RareLevel ResolvePropRareLevel(string infoId)
	{
		return default;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x3D0F448", Offset = "0x3D0B448", VA = "0x3D0F448")]
	private static float GetTraitForgeBattlePowerTerm(GlobalArtifactsForgeInfo traitConfig)
	{
		return default;
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x3D0E99C", Offset = "0x3D0A99C", VA = "0x3D0E99C")]
	public static Dictionary<string, List<int>> BuildBattleCardUnLockTalentId(List<UserHeroCardData> battleCardList, Dictionary<string, UserCardTalentData> talent, Dictionary<string, List<Talent2Data>> talent2)
	{
		return null;
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x3D0DD1C", Offset = "0x3D09D1C", VA = "0x3D0DD1C")]
	public int GetCardDeckCP(List<UserHeroCardData> cardDatas, Dictionary<string, List<int>> allCardUnLockTalentId, [Optional] string getSingleCardCP)
	{
		return default;
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x3D10018", Offset = "0x3D0C018", VA = "0x3D10018")]
	public Dictionary<int, int> GetHeroCardDataFetterCount(List<UserHeroCardData> cardDatas)
	{
		return null;
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x3D0F518", Offset = "0x3D0B518", VA = "0x3D0F518")]
	private float GetCardBasePower(string cardId, int level)
	{
		return default;
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x3D1039C", Offset = "0x3D0C39C", VA = "0x3D1039C")]
	private float GetSpawnCoefficient(string rareLevel)
	{
		return default;
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x3D0FA48", Offset = "0x3D0BA48", VA = "0x3D0FA48")]
	private float GetTalentCoefficient(List<int> allUnLockTalenId, string cardId)
	{
		return default;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x3D0FE54", Offset = "0x3D0BE54", VA = "0x3D0FE54")]
	private float GetFetterProfessionWeight(List<UserHeroCardData> cardList, UserHeroCardData card)
	{
		return default;
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x3D1049C", Offset = "0x3D0C49C", VA = "0x3D1049C")]
	public BattlePowerManager()
	{
	}
}
