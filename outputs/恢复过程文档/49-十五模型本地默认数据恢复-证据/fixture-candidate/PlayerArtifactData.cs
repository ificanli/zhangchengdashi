using System;
using System.Collections.Generic;
using System.Numerics;
using Newtonsoft.Json;

namespace DataModule
{
	public class PlayerArtifactData : ServerBaseData
	{
		[Serializable]
		public class ArtifactGroupState
		{
			[JsonProperty("l")]
			public List<UserPropData> userPropDataList;
			[JsonProperty("e")]
			public string userEquipPropID;
			public ArtifactGroupState()
			{
			}
		}
		private const string RefundAPropInfoResourcesPath = "GlobalPropInfoATest";
		[JsonProperty("updl")]
		public List<UserPropData> userPropDataList;
		[JsonProperty("uepid")]
		public string userEquipPropID;
		[JsonProperty("ag")]
		private ArtifactGroupState groupA;
		[JsonProperty("bg")]
		private ArtifactGroupState groupB;
		[JsonProperty("hmob")]
		public bool hadMigratedOldToB;
		[JsonProperty("hrob")]
		public bool hadRefundedOnAToB;
		[JsonProperty("lsro")]
		public int limitedSummonSystemRotateOrderId;
		[JsonProperty("lspo")]
		public int limitedSummonPlayerSelectOrderId;
		[JsonProperty("lsad")]
		public long limitedSummonRotateAnchorDayTicks;
		[JsonProperty("lspc")]
		public int limitedSummonPityCount;
		private List<UserPropData> _legacyUserPropDataListAIngest;
		private List<UserPropData> _legacyUserPropDataListBIngest;
		private string _legacyUserEquipPropIDAIngest;
		private string _legacyUserEquipPropIDBIngest;
		private bool _legacyHadMigratedOldToBIngest;
		private bool _legacyHadRefundedOnAToBIngest;
		public override void InitFromDefaults()
		{
    base.InitFromDefaults();
    userEquipPropID = "3001";
}
		public PlayerArtifactData()
		{
    limitedSummonSystemRotateOrderId = 1;
    limitedSummonPlayerSelectOrderId = -1;
}
	}
}
