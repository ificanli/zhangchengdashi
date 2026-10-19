using Il2CppDummyDll;

[Token(Token = "0x200002E")]
public interface IExtendServices
{
	[Token(Token = "0x60001E0")]
	string GetGFVersion();

	[Token(Token = "0x60001E1")]
	string GetUACBuildID();

	[Token(Token = "0x60001E2")]
	bool GetIsDeepObf();
}
