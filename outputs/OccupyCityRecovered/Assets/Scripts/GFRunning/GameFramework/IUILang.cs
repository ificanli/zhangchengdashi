using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x20003C0")]
	public interface IUILang
	{
		[Token(Token = "0x1700113D")]
		string Key
		{
			[Token(Token = "0x6005E9A")]
			get;
			[Token(Token = "0x6005E9B")]
			set;
		}

		[Token(Token = "0x1700113E")]
		string Value
		{
			[Token(Token = "0x6005E9C")]
			get;
			[Token(Token = "0x6005E9D")]
			set;
		}

		[Token(Token = "0x6005E9E")]
		void Refresh();
	}
}
