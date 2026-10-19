using System.Collections.Generic;
using System.Numerics;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000ECF")]
	public class PlayerResourceData : ServerBaseData
	{
		[Token(Token = "0x40066C3")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("urdl")]
		public List<UserAssetData> userResourcesDataList;

		[Token(Token = "0x40066C4")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, UserAssetData> userResourcesDataDic;

		[Token(Token = "0x60059A8")]
		[Address(RVA = "0x4373838", Offset = "0x436F838", VA = "0x4373838")]
		public void ChangeResourceCount(string id, BigInteger count)
		{
		}

		[Token(Token = "0x60059A9")]
		[Address(RVA = "0x4373A04", Offset = "0x436FA04", VA = "0x4373A04", Slot = "5")]
		public override void InitFromDefaults()
		{
		}

		[Token(Token = "0x60059AA")]
		[Address(RVA = "0x4373A84", Offset = "0x436FA84", VA = "0x4373A84", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x60059AB")]
		[Address(RVA = "0x4373F48", Offset = "0x436FF48", VA = "0x4373F48")]
		public PlayerResourceData()
		{
		}
	}
}
