using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x200012F")]
	public interface IDeliveryQueryServices
	{
		[Token(Token = "0x60010EB")]
		bool QueryDeliveryFiles(string _008Ffª_008C_007Fi, string _0084H_007Fp_0060i);

		[Token(Token = "0x60010EC")]
		DeliveryFileInfo GetDeliveryFileInfo(string _008Ffª_008C_007Fi, string _0084H_007Fp_0060i);
	}
}
