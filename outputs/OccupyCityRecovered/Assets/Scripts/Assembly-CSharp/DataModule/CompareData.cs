using Il2CppDummyDll;
using L_Tools;

namespace DataModule
{
	[Token(Token = "0x2000E21")]
	public class CompareData
	{
		[Token(Token = "0x4006288")]
		[FieldOffset(Offset = "0x10")]
		public bool isLocal;

		[Token(Token = "0x4006289")]
		[FieldOffset(Offset = "0x18")]
		public PlayerResourceData playerResourceData;

		[Token(Token = "0x400628A")]
		[FieldOffset(Offset = "0x20")]
		public PlayerCardData playerCardData;

		[Token(Token = "0x400628B")]
		[FieldOffset(Offset = "0x28")]
		public PlayerArenaData playerArenaData;

		[Token(Token = "0x400628C")]
		[FieldOffset(Offset = "0x30")]
		public PlayerMainCityData playerMainCityData;

		[Token(Token = "0x400628D")]
		[FieldOffset(Offset = "0x38")]
		public PlayerShopData playerShopData;

		[Token(Token = "0x400628E")]
		[FieldOffset(Offset = "0x40")]
		public PlayerTimeData playerTimeData;

		[Token(Token = "0x400628F")]
		[FieldOffset(Offset = "0x48")]
		public PlayerArtifactData PlayerArtifactData;

		[Token(Token = "0x4006290")]
		[FieldOffset(Offset = "0x50")]
		public PlayerPrefs2RunTime PlayerPrefsData;

		[Token(Token = "0x6005704")]
		[Address(RVA = "0x43496A8", Offset = "0x43456A8", VA = "0x43496A8")]
		public CompareData()
		{
		}
	}
}
