using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x2000082")]
	public enum EBundleLoadMethod
	{
		[Token(Token = "0x4000192")]
		Normal = 0,
		[Token(Token = "0x4000193")]
		LoadFromFileOffset = 1,
		[Token(Token = "0x4000194")]
		LoadFromMemoryHigh = 2,
		[Token(Token = "0x4000195")]
		LoadFromStream = 3,
		[Token(Token = "0x4000196")]
		LoadFromMemoryLow = 4
	}
}
