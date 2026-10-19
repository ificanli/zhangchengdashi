using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x20000D7")]
	public class WebPlayModeParameters : InitializeParameters
	{
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x38")]
		public IBuildinQueryServices BuildinQueryServices;

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x40")]
		public IRemoteServices RemoteServices;

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x731CAD8", Offset = "0x7318AD8", VA = "0x731CAD8")]
		public WebPlayModeParameters()
		{
		}
	}
}
