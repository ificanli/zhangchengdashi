using Il2CppDummyDll;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000052")]
	public interface INumberHandler
	{
		[Token(Token = "0x1700008F")]
		float MinValue
		{
			[Token(Token = "0x60002D1")]
			get;
		}

		[Token(Token = "0x17000090")]
		float MaxValue
		{
			[Token(Token = "0x60002D2")]
			get;
		}

		[Token(Token = "0x60002D3")]
		bool TryParse(string input, out object value);

		[Token(Token = "0x60002D4")]
		bool ValuesAreEqual(object value1, object value2);

		[Token(Token = "0x60002D5")]
		object ConvertFromFloat(float value);

		[Token(Token = "0x60002D6")]
		float ConvertToFloat(object value);

		[Token(Token = "0x60002D7")]
		string ToString(object value);
	}
}
