using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EC9")]
	public class PlayerCustomizationData : ServerBaseData
	{
		[Token(Token = "0x40066A5")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("bgm")]
		public bool isAudioBgmEnable;

		[Token(Token = "0x40066A6")]
		[FieldOffset(Offset = "0x11")]
		[JsonProperty("sfx")]
		public bool isAudioSfxEnable;

		[Token(Token = "0x40066A7")]
		[FieldOffset(Offset = "0x12")]
		[JsonProperty("emoji")]
		public bool oepnAiSendEmoji;

		[Token(Token = "0x40066A8")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("pn")]
		public string playerName;

		[Token(Token = "0x40066A9")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("hsid")]
		public string HeadShotID;

		[Token(Token = "0x40066AA")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("uld")]
		public UserLableData userLableData;

		[Token(Token = "0x40066AB")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("psd")]
		public PlayerSkinData playerSkinData;

		[Token(Token = "0x40066AC")]
		[FieldOffset(Offset = "0x38")]
		public PlayerExpressionData playerExpressionData;

		[Token(Token = "0x40066AD")]
		[FieldOffset(Offset = "0x40")]
		public PlayerBubbleData playerBubbleData;

		[Token(Token = "0x6005996")]
		[Address(RVA = "0x4371C98", Offset = "0x436DC98", VA = "0x4371C98", Slot = "5")]
		public override void InitFromDefaults()
		{
		}

		[Token(Token = "0x6005997")]
		[Address(RVA = "0x4371DEC", Offset = "0x436DDEC", VA = "0x4371DEC", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005998")]
		[Address(RVA = "0x4372300", Offset = "0x436E300", VA = "0x4372300")]
		public PlayerCustomizationData()
		{
		}
	}
}
