using Il2CppDummyDll;

namespace IngameDebugConsole
{
	[Token(Token = "0x200006F")]
	public interface ITooltipContent
	{
		[Token(Token = "0x170000BC")]
		bool IsActive
		{
			[Token(Token = "0x60003C3")]
			get;
		}

		[Token(Token = "0x170000BD")]
		string TooltipText
		{
			[Token(Token = "0x60003C4")]
			get;
		}
	}
}
