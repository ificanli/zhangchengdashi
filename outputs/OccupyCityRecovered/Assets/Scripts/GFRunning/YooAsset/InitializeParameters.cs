using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x20000D3")]
	public abstract class InitializeParameters
	{
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x10")]
		public IRuntimeSource TionServices;

		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x18")]
		public string BuildinRootDirectory;

		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x20")]
		public string SandboxRootDirectory;

		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x28")]
		public long LoadingMaxTimeSlice;

		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x30")]
		public int DownloadFailedTryAgain;

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x731CA14", Offset = "0x7318A14", VA = "0x731CA14")]
		protected InitializeParameters()
		{
		}
	}
}
