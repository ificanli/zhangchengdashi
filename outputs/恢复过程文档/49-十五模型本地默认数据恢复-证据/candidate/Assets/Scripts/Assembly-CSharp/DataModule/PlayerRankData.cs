using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000ECE")]
	public class PlayerRankData : ServerBaseData
	{
		[Token(Token = "0x40066C2")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("ri")]
		public List<RankItemData> rankInfo;

		[Token(Token = "0x60059A6")]
		[Address(RVA = "0x4373218", Offset = "0x436F218", VA = "0x4373218", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x60059A7")]
		[Address(RVA = "0x43737BC", Offset = "0x436F7BC", VA = "0x43737BC")]
		public PlayerRankData()
		{
    rankInfo = new global::System.Collections.Generic.List<DataModule.RankItemData>();
}
	}
}
