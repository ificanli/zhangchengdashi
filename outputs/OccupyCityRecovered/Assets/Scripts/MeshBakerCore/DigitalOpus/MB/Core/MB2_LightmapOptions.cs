using Il2CppDummyDll;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000037")]
	public enum MB2_LightmapOptions
	{
		[Token(Token = "0x40000DF")]
		preserve_current_lightmapping = 0,
		[Token(Token = "0x40000E0")]
		ignore_UV2 = 1,
		[Token(Token = "0x40000E1")]
		copy_UV2_unchanged = 2,
		[Token(Token = "0x40000E2")]
		generate_new_UV2_layout = 3,
		[Token(Token = "0x40000E3")]
		copy_UV2_unchanged_to_separate_rects = 4
	}
}
