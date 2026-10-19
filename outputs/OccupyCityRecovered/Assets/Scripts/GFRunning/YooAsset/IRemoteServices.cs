using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x2000132")]
	public interface IRemoteServices
	{
		[Token(Token = "0x60010FE")]
		string GetRemoteMainURL(string _0084H_007Fp_0060i, string j_0081xY_0088_0088);

		[Token(Token = "0x60010FF")]
		string GetRemoteFallbackURL(string _0084H_007Fp_0060i, string j_0081xY_0088_0088);

		[Token(Token = "0x6001100")]
		string GetVersionUrl(string _0084H_007Fp_0060i);
	}
}
