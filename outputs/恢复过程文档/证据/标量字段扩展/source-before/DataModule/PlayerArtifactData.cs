using System;
using System.Collections.Generic;
using System.Numerics;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EBD")]
	public class PlayerArtifactData : ServerBaseData
	{
		[Serializable]
		[Token(Token = "0x2000EBE")]
		public class ArtifactGroupState
		{
			[Token(Token = "0x400665A")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty("l")]
			public List<UserPropData> userPropDataList;

			[Token(Token = "0x400665B")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty("e")]
			public string userEquipPropID;

			[Token(Token = "0x6005978")]
			[Address(RVA = "0x436CF88", Offset = "0x4368F88", VA = "0x436CF88")]
			public ArtifactGroupState()
			{
			}
		}

		[Token(Token = "0x4006649")]
		private const string RefundAPropInfoResourcesPath = "GlobalPropInfoATest";

		[Token(Token = "0x400664A")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("updl")]
		public List<UserPropData> userPropDataList;

		[Token(Token = "0x400664B")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("uepid")]
		public string userEquipPropID;

		[Token(Token = "0x400664C")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("ag")]
		private ArtifactGroupState groupA;

		[Token(Token = "0x400664D")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("bg")]
		private ArtifactGroupState groupB;

		[Token(Token = "0x400664E")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("hmob")]
		public bool hadMigratedOldToB;

		[Token(Token = "0x400664F")]
		[FieldOffset(Offset = "0x31")]
		[JsonProperty("hrob")]
		public bool hadRefundedOnAToB;

		[Token(Token = "0x4006650")]
		[FieldOffset(Offset = "0x34")]
		[JsonProperty("lsro")]
		public int limitedSummonSystemRotateOrderId;

		[Token(Token = "0x4006651")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("lspo")]
		public int limitedSummonPlayerSelectOrderId;

		[Token(Token = "0x4006652")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("lsad")]
		public long limitedSummonRotateAnchorDayTicks;

		[Token(Token = "0x4006653")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("lspc")]
		public int limitedSummonPityCount;

		[Token(Token = "0x4006654")]
		[FieldOffset(Offset = "0x50")]
		private List<UserPropData> _legacyUserPropDataListAIngest;

		[Token(Token = "0x4006655")]
		[FieldOffset(Offset = "0x58")]
		private List<UserPropData> _legacyUserPropDataListBIngest;

		[Token(Token = "0x4006656")]
		[FieldOffset(Offset = "0x60")]
		private string _legacyUserEquipPropIDAIngest;

		[Token(Token = "0x4006657")]
		[FieldOffset(Offset = "0x68")]
		private string _legacyUserEquipPropIDBIngest;

		[Token(Token = "0x4006658")]
		[FieldOffset(Offset = "0x70")]
		private bool _legacyHadMigratedOldToBIngest;

		[Token(Token = "0x4006659")]
		[FieldOffset(Offset = "0x71")]
		private bool _legacyHadRefundedOnAToBIngest;

		[Token(Token = "0x17000F32")]
		[JsonProperty("updla")]
		private List<UserPropData> LegacyUserPropDataListAIngest
		{
			[Token(Token = "0x600595A")]
			[Address(RVA = "0x436C088", Offset = "0x4368088", VA = "0x436C088")]
			set
			{
			}
		}

		[Token(Token = "0x17000F33")]
		[JsonProperty("updlb")]
		private List<UserPropData> LegacyUserPropDataListBIngest
		{
			[Token(Token = "0x600595B")]
			[Address(RVA = "0x436C090", Offset = "0x4368090", VA = "0x436C090")]
			set
			{
			}
		}

		[Token(Token = "0x17000F34")]
		[JsonProperty("uepida")]
		private string LegacyUserEquipPropIDAIngest
		{
			[Token(Token = "0x600595C")]
			[Address(RVA = "0x436C098", Offset = "0x4368098", VA = "0x436C098")]
			set
			{
			}
		}

		[Token(Token = "0x17000F35")]
		[JsonProperty("uepidb")]
		private string LegacyUserEquipPropIDBIngest
		{
			[Token(Token = "0x600595D")]
			[Address(RVA = "0x436C0A0", Offset = "0x43680A0", VA = "0x436C0A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000F36")]
		[JsonProperty("abmig")]
		private bool LegacyHadMigratedOldToBIngest
		{
			[Token(Token = "0x600595E")]
			[Address(RVA = "0x436C0A8", Offset = "0x43680A8", VA = "0x436C0A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000F37")]
		[JsonProperty("abrefund")]
		private bool LegacyHadRefundedOnAToBIngest
		{
			[Token(Token = "0x600595F")]
			[Address(RVA = "0x436C0B4", Offset = "0x43680B4", VA = "0x436C0B4")]
			set
			{
			}
		}

		[Token(Token = "0x6005960")]
		[Address(RVA = "0x436C0C0", Offset = "0x43680C0", VA = "0x436C0C0", Slot = "5")]
		public override void InitFromDefaults()
		{
		}

		[Token(Token = "0x6005961")]
		[Address(RVA = "0x436C114", Offset = "0x4368114", VA = "0x436C114", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005962")]
		[Address(RVA = "0x436CC84", Offset = "0x4368C84", VA = "0x436CC84")]
		private static void TryInitLimitedSummonRotationOnArtifactsUnlock()
		{
		}

		[Token(Token = "0x6005963")]
		[Address(RVA = "0x436C2C8", Offset = "0x43682C8", VA = "0x436C2C8")]
		private void MergeLegacyKeysToGroupsIfNeeded()
		{
		}

		[Token(Token = "0x6005964")]
		[Address(RVA = "0x436CEEC", Offset = "0x4368EEC", VA = "0x436CEEC")]
		public void PrepareForSaveCurrentGroup()
		{
		}

		[Token(Token = "0x6005965")]
		[Address(RVA = "0x436CF6C", Offset = "0x4368F6C", VA = "0x436CF6C")]
		public void SyncActiveToGroupMergeFromCurrentAb()
		{
		}

		[Token(Token = "0x6005966")]
		[Address(RVA = "0x436C410", Offset = "0x4368410", VA = "0x436C410")]
		private bool IsBGroup()
		{
			return default;
		}

		[Token(Token = "0x6005967")]
		[Address(RVA = "0x436CF54", Offset = "0x4368F54", VA = "0x436CF54")]
		private ArtifactGroupState GetGroupState(bool isB)
		{
			return null;
		}

		[Token(Token = "0x6005968")]
		[Address(RVA = "0x436C184", Offset = "0x4368184", VA = "0x436C184")]
		private void EnsureGroupsNotNull()
		{
		}

		[Token(Token = "0x6005969")]
		[Address(RVA = "0x436C4AC", Offset = "0x43684AC", VA = "0x436C4AC")]
		private void AbsorbLegacyActiveCacheToAIfNeeded()
		{
		}

		[Token(Token = "0x600596A")]
		[Address(RVA = "0x436C564", Offset = "0x4368564", VA = "0x436C564")]
		private void TryMigrateAToBOnFirstEnter(bool isB)
		{
		}

		[Token(Token = "0x600596B")]
		[Address(RVA = "0x436C66C", Offset = "0x436866C", VA = "0x436C66C")]
		private void LoadActiveFromGroup(bool isB)
		{
		}

		[Token(Token = "0x600596C")]
		[Address(RVA = "0x436C8E8", Offset = "0x43688E8", VA = "0x436C8E8")]
		private void FillMissingByCurrentConfig()
		{
		}

		[Token(Token = "0x600596D")]
		[Address(RVA = "0x436CF90", Offset = "0x4368F90", VA = "0x436CF90")]
		private static List<UserPropData> ConvertToBGroup(List<UserPropData> source)
		{
			return null;
		}

		[Token(Token = "0x600596E")]
		[Address(RVA = "0x436D098", Offset = "0x4369098", VA = "0x436D098")]
		private static void RefundMaterialsOnFirstAToB(List<UserPropData> aGroupSource, List<UserPropData> bGroupList)
		{
		}

		[Token(Token = "0x600596F")]
		[Address(RVA = "0x436D62C", Offset = "0x436962C", VA = "0x436D62C")]
		private static Dictionary<string, GlobalPropInfo> GetRefundPropInfoDic()
		{
			return null;
		}

		[Token(Token = "0x6005970")]
		[Address(RVA = "0x436D6F0", Offset = "0x43696F0", VA = "0x436D6F0")]
		private static int EvaluateFormulaToPositiveInt(string formula, string levelArg)
		{
			return default;
		}

		[Token(Token = "0x6005971")]
		[Address(RVA = "0x436D994", Offset = "0x4369994", VA = "0x436D994")]
		private static void AddCrystalRefundToPlayerData(BigInteger crystalCount)
		{
		}

		[Token(Token = "0x6005972")]
		[Address(RVA = "0x436CBE0", Offset = "0x4368BE0", VA = "0x436CBE0")]
		public void SyncActiveToGroupMerge(bool isB)
		{
		}

		[Token(Token = "0x6005973")]
		[Address(RVA = "0x436E1DC", Offset = "0x436A1DC", VA = "0x436E1DC")]
		private static void MergeUpdate(List<UserPropData> targetGroup, List<UserPropData> active, Dictionary<string, GlobalPropInfo> allowedIds)
		{
		}

		[Token(Token = "0x6005974")]
		[Address(RVA = "0x436E4A0", Offset = "0x436A4A0", VA = "0x436E4A0")]
		private static void CopyFields(UserPropData target, UserPropData src)
		{
		}

		[Token(Token = "0x6005975")]
		[Address(RVA = "0x436CD7C", Offset = "0x4368D7C", VA = "0x436CD7C")]
		private static List<UserPropData> DeepCopyList(List<UserPropData> src)
		{
			return null;
		}

		[Token(Token = "0x6005976")]
		[Address(RVA = "0x436E550", Offset = "0x436A550", VA = "0x436E550")]
		private static UserPropData DeepCopyProp(UserPropData p)
		{
			return null;
		}

		[Token(Token = "0x6005977")]
		[Address(RVA = "0x436E640", Offset = "0x436A640", VA = "0x436E640")]
		public PlayerArtifactData()
		{
		}
	}
}
