using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x20000D4")]
	public class EditorSimulateModeParameters : InitializeParameters
	{
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x38")]
		public string SimulateManifestFilePath;

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x731CA7C", Offset = "0x7318A7C", VA = "0x731CA7C")]
		public EditorSimulateModeParameters()
		{
		}
	}
}
