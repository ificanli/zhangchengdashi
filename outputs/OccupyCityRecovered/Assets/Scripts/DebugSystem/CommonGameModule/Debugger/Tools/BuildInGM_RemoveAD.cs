using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools
{
	[Token(Token = "0x2000019")]
	public class BuildInGM_RemoveAD : IBuildInGM
	{
		[Token(Token = "0x4000050")]
		private const string GM_NAME_ADS = "debug remove Ads";

		[Token(Token = "0x4000051")]
		private const string GM_NAME_VIDEO = "debug jump video";

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x0")]
		private static bool IsRemoveAd;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x1")]
		private static bool IsJumpVideo;

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x4637110", Offset = "0x4633110", VA = "0x4637110", Slot = "4")]
		public void RegisterGM()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x4637330", Offset = "0x4633330", VA = "0x4637330")]
		private static void RemoveAd(bool isOn)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x46375D8", Offset = "0x46335D8", VA = "0x46375D8")]
		private static void JumpVideo(bool isOn)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x46370F8", Offset = "0x46330F8", VA = "0x46370F8")]
		public BuildInGM_RemoveAD()
		{
		}
	}
}
