using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E50")]
	public class GlobalArtifactAIReleaseInfo : GlobalInfoBase
	{
		[Token(Token = "0x40063B7")]
		[FieldOffset(Offset = "0x18")]
		public string artifactType;

		[Token(Token = "0x40063B8")]
		[FieldOffset(Offset = "0x20")]
		public float baseThreshold;

		[Token(Token = "0x40063B9")]
		[FieldOffset(Offset = "0x24")]
		public int distanceParam;

		[Token(Token = "0x40063BA")]
		[FieldOffset(Offset = "0x28")]
		public float ratioParam;

		[Token(Token = "0x40063BB")]
		[FieldOffset(Offset = "0x2C")]
		public float hpParam;

		[Token(Token = "0x40063BC")]
		[FieldOffset(Offset = "0x30")]
		public int radiusParam;

		[Token(Token = "0x40063BD")]
		[FieldOffset(Offset = "0x38")]
		public string specialParam;

		[Token(Token = "0x60057C7")]
		[Address(RVA = "0x4357F5C", Offset = "0x4353F5C", VA = "0x4357F5C")]
		public GlobalArtifactAIReleaseInfo()
		{
		}
	}
}
