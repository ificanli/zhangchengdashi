using Il2CppDummyDll;

namespace L_Tools.FakeMediation
{
	[Token(Token = "0x2000FC3")]
	public interface IFakeAdsManager
	{
		[Token(Token = "0x6005E55")]
		void Initialize();

		[Token(Token = "0x6005E56")]
		bool IsEnabled();

		[Token(Token = "0x6005E57")]
		void SetEnabled(bool isEnabled);
	}
}
