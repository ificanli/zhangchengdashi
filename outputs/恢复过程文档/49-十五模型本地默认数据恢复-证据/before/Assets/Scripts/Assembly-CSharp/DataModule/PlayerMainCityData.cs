using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000ECB")]
	public class PlayerMainCityData : ServerBaseData
	{
		[Token(Token = "0x40066B7")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("ptl")]
		public Dictionary<string, int> playerTalentLevel;

		[Token(Token = "0x40066B8")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("hds")]
		public List<UserOutsiderHexData> HexDatas;

		[Token(Token = "0x40066B9")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("tds")]
		public List<UserTileData> tileDatas;

		[Token(Token = "0x40066BA")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("fds")]
		public List<UserFamilyData> familyDatas;

		[Token(Token = "0x40066BB")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("ultn")]
		public int unLockTileNum;

		[Token(Token = "0x40066BC")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("mcti")]
		public string mainCityTitleId;

		[Token(Token = "0x40066BD")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("itw")]
		public bool isReturnWood;

		[Token(Token = "0x40066BE")]
		[FieldOffset(Offset = "0x41")]
		[JsonProperty("iouumd")]
		public bool isOldUserUpdateMapData;

		[Token(Token = "0x40066BF")]
		[FieldOffset(Offset = "0x48")]
		[JsonIgnore]
		public Dictionary<string, int> playerTalentNew;

		[Token(Token = "0x600599B")]
		[Address(RVA = "0x437248C", Offset = "0x436E48C", VA = "0x437248C", Slot = "5")]
		public override void InitFromDefaults()
		{
		}

		[Token(Token = "0x600599C")]
		[Address(RVA = "0x437250C", Offset = "0x436E50C", VA = "0x437250C", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x600599D")]
		[Address(RVA = "0x4372D60", Offset = "0x436ED60", VA = "0x4372D60")]
		public void TileUnLock(string tileKey, bool isChinUnLock = false)
		{
		}

		[Token(Token = "0x600599E")]
		[Address(RVA = "0x4372880", Offset = "0x436E880", VA = "0x4372880")]
		public void CheckTitleUpdate(bool isInit = false)
		{
		}

		[Token(Token = "0x600599F")]
		[Address(RVA = "0x4372EE0", Offset = "0x436EEE0", VA = "0x4372EE0")]
		public void ClearTalentLv()
		{
		}

		[Token(Token = "0x60059A0")]
		[Address(RVA = "0x4373010", Offset = "0x436F010", VA = "0x4373010")]
		public PlayerMainCityData()
		{
		}
	}
}
