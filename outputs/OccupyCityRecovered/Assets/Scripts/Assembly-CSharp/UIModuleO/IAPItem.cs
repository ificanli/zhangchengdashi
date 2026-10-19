using Il2CppDummyDll;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x200091D")]
	public class IAPItem : IAPItemComponents
	{
		[Token(Token = "0x4004475")]
		[FieldOffset(Offset = "0x60")]
		private PurchaseConfig _config;

		[Token(Token = "0x60034B3")]
		[Address(RVA = "0x40ABD60", Offset = "0x40A7D60", VA = "0x40ABD60")]
		public void Init(PurchaseConfig config)
		{
		}

		[Token(Token = "0x60034B4")]
		[Address(RVA = "0x40AC088", Offset = "0x40A8088", VA = "0x40AC088", Slot = "12")]
		protected override void OnButtonExtendGetBtnClicked()
		{
		}

		[Token(Token = "0x60034B5")]
		[Address(RVA = "0x40AC444", Offset = "0x40A8444", VA = "0x40AC444")]
		public IAPItem()
		{
		}
	}
}
