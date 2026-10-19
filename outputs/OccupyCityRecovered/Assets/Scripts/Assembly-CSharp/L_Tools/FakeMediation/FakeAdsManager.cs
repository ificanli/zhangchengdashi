using Il2CppDummyDll;

namespace L_Tools.FakeMediation
{
	[Token(Token = "0x2000FC5")]
	public class FakeAdsManager : IFakeAdsManager
	{
		[Token(Token = "0x4006BBA")]
		private const string ENABLE_FAKE_ADS_KEY = "Voodoo_FakeAdsEnabled";

		[Token(Token = "0x4006BBB")]
		private const string TAG = "FakeAds";

		[Token(Token = "0x4006BBC")]
		[FieldOffset(Offset = "0x10")]
		private bool _isEnabled;

		[Token(Token = "0x6005E5D")]
		[Address(RVA = "0x43FBF4C", Offset = "0x43F7F4C", VA = "0x43FBF4C", Slot = "5")]
		public bool IsEnabled()
		{
			return default;
		}

		[Token(Token = "0x6005E5E")]
		[Address(RVA = "0x43FBF54", Offset = "0x43F7F54", VA = "0x43FBF54", Slot = "6")]
		public void SetEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6005E5F")]
		[Address(RVA = "0x43FBF60", Offset = "0x43F7F60", VA = "0x43FBF60", Slot = "4")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6005E60")]
		[Address(RVA = "0x43FC00C", Offset = "0x43F800C", VA = "0x43FC00C")]
		private void UpdateEnabledValue(bool isEnabled)
		{
		}

		[Token(Token = "0x6005E61")]
		[Address(RVA = "0x43FC068", Offset = "0x43F8068", VA = "0x43FC068")]
		public FakeAdsManager()
		{
		}
	}
}
