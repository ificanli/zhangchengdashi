using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E94")]
	public class GlobalFeatureUnlockInfo : GlobalInfoBase
	{
		[Token(Token = "0x400659D")]
		[FieldOffset(Offset = "0x18")]
		public FeatureUnlockType type;

		[Token(Token = "0x400659E")]
		[FieldOffset(Offset = "0x20")]
		public string unlockId;

		[Token(Token = "0x400659F")]
		[FieldOffset(Offset = "0x28")]
		public string args;

		[Token(Token = "0x40065A0")]
		[FieldOffset(Offset = "0x30")]
		public string tutorialStartId;

		[Token(Token = "0x40065A1")]
		[FieldOffset(Offset = "0x38")]
		public string imgPath;

		[Token(Token = "0x40065A2")]
		[FieldOffset(Offset = "0x40")]
		public string badgeName;

		[Token(Token = "0x40065A3")]
		[FieldOffset(Offset = "0x48")]
		public string simultaneouslyUnlockedFeature;

		[Token(Token = "0x40065A4")]
		[FieldOffset(Offset = "0x50")]
		public string RequireUnlocked;

		[Token(Token = "0x60058C1")]
		[Address(RVA = "0x43655FC", Offset = "0x43615FC", VA = "0x43655FC")]
		public GlobalFeatureUnlockInfo()
		{
		}
	}
}
