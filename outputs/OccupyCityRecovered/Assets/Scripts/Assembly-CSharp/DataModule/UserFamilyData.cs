using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EE7")]
	public class UserFamilyData : UserDataBase
	{
		[Token(Token = "0x400676C")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("tk")]
		public string tileKey;

		[Token(Token = "0x400676D")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("cid")]
		public string configId;

		[Token(Token = "0x400676E")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("p")]
		public string population;

		[Token(Token = "0x400676F")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("f")]
		public string faction;

		[Token(Token = "0x4006770")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("ii")]
		public string iconId;

		[Token(Token = "0x4006771")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("n")]
		public string name;

		[Token(Token = "0x4006772")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("tik")]
		public string timerKey;

		[Token(Token = "0x4006773")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty("pat")]
		public string populationAddTime;

		[Token(Token = "0x4006774")]
		[FieldOffset(Offset = "0x58")]
		[JsonProperty("art")]
		public string adReduceTime;

		[Token(Token = "0x4006775")]
		[FieldOffset(Offset = "0x60")]
		[JsonProperty("lpat")]
		public string lastPopulationAddTime;

		[Token(Token = "0x60059FC")]
		[Address(RVA = "0x4378398", Offset = "0x4374398", VA = "0x4378398")]
		public UserFamilyData()
		{
		}

		[Token(Token = "0x60059FD")]
		[Address(RVA = "0x43783A0", Offset = "0x43743A0", VA = "0x43783A0")]
		public UserFamilyData(string tileKey, GlobalMainCityHouseInfo globalMainCityHouseInfo)
		{
		}
	}
}
