using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x20000D6")]
	public class HostPlayModeParameters : InitializeParameters
	{
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x38")]
		public IBuildinQueryServices BuildinQueryServices;

		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x40")]
		public IDeliveryQueryServices DeliveryQueryServices;

		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x48")]
		public IRemoteServices RemoteServices;

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x731CAD4", Offset = "0x7318AD4", VA = "0x731CAD4")]
		public HostPlayModeParameters()
		{
		}
	}
}
