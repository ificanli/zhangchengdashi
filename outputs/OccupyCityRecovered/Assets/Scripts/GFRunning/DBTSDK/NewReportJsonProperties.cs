using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001CD")]
	public interface NewReportJsonProperties
	{
		[Token(Token = "0x170000F9")]
		string game_name
		{
			[Token(Token = "0x6001799")]
			get;
			[Token(Token = "0x600179A")]
			set;
		}

		[Token(Token = "0x600179B")]
		void ClearProperties();

		[Token(Token = "0x600179C")]
		string GetEventKey();

		[Token(Token = "0x600179D")]
		string ToJson();
	}
}
