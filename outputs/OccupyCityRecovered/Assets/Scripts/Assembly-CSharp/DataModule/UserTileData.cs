using System.Collections.Generic;
using GameModule;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace DataModule
{
	[Token(Token = "0x2000EE9")]
	public class UserTileData : UserDataBase
	{
		[Token(Token = "0x400677B")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("tk")]
		public string tileKey;

		[Token(Token = "0x400677C")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("tti")]
		public string tileTypeID;

		[Token(Token = "0x400677D")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("et")]
		public string enemyType;

		[Token(Token = "0x400677E")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("en")]
		public string enemyNumber;

		[Token(Token = "0x400677F")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("ecs")]
		public List<string> enemyCards;

		[Token(Token = "0x4006780")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("cci")]
		public string customCardId;

		[Token(Token = "0x4006781")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("ec")]
		public EnemyBattleDataCofig enemyConfig;

		[Token(Token = "0x4006782")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty("bmi")]
		public string buildModelId;

		[Token(Token = "0x4006783")]
		[FieldOffset(Offset = "0x58")]
		[JsonProperty("emi")]
		public string enemyModelId;

		[Token(Token = "0x4006784")]
		[FieldOffset(Offset = "0x60")]
		[JsonProperty("flom")]
		public int firstLakeOrMountain;

		[Token(Token = "0x4006785")]
		[FieldOffset(Offset = "0x64")]
		[JsonProperty("ts")]
		public E_MainCityTileState tileState;

		[Token(Token = "0x4006786")]
		[FieldOffset(Offset = "0x68")]
		[JsonProperty("p")]
		public int price;

		[Token(Token = "0x4006787")]
		[FieldOffset(Offset = "0x70")]
		[JsonIgnore]
		public string talentId;

		[Token(Token = "0x60059FE")]
		[Address(RVA = "0x4378538", Offset = "0x4374538", VA = "0x4378538")]
		public UserTileData()
		{
		}

		[Token(Token = "0x60059FF")]
		[Address(RVA = "0x4378540", Offset = "0x4374540", VA = "0x4378540")]
		public UserTileData(GlobalMapInfo globalMapInfo, bool isMapEditor = false)
		{
		}

		[Token(Token = "0x6005A00")]
		[Address(RVA = "0x43786F0", Offset = "0x43746F0", VA = "0x43786F0")]
		public Vector3 GetPosition()
		{
			return default;
		}

		[Token(Token = "0x6005A01")]
		[Address(RVA = "0x43787BC", Offset = "0x43747BC", VA = "0x43787BC")]
		public string SetKey(Vector3 ori)
		{
			return null;
		}

		[Token(Token = "0x6005A02")]
		[Address(RVA = "0x4372E78", Offset = "0x436EE78", VA = "0x4372E78")]
		public void TileUnLock()
		{
		}

		[Token(Token = "0x6005A03")]
		[Address(RVA = "0x437867C", Offset = "0x437467C", VA = "0x437867C")]
		public void UpdatePrice()
		{
		}

		[Token(Token = "0x6005A04")]
		[Address(RVA = "0x4378B14", Offset = "0x4374B14", VA = "0x4378B14")]
		public static int CalcUnlockPrice(int n)
		{
			return default;
		}

		[Token(Token = "0x6005A05")]
		[Address(RVA = "0x4372870", Offset = "0x436E870", VA = "0x4372870")]
		public bool IsFirstLakeOrMountain()
		{
			return default;
		}
	}
}
