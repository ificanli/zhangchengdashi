using Il2CppDummyDll;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x200002D")]
	public class GPUICrowdSettings : GPUInstancerSettingsExtension
	{
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x1C")]
		public bool bakeUpdatePerFrame;

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x73CEFAC", Offset = "0x73CAFAC", VA = "0x73CEFAC", Slot = "4")]
		public override string GetExtensionCode()
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x73CA72C", Offset = "0x73C672C", VA = "0x73CA72C")]
		public static GPUICrowdSettings GetDefaultGPUICrowdSettings()
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x73CF004", Offset = "0x73CB004", VA = "0x73CF004")]
		public GPUICrowdSettings()
		{
		}
	}
}
