using System;
using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x200013D")]
	public interface ILogger
	{
		[Token(Token = "0x60011EA")]
		void Log(string aDÂ_005B_0091_0086);

		[Token(Token = "0x60011EB")]
		void Warning(string aDÂ_005B_0091_0086);

		[Token(Token = "0x60011EC")]
		void Error(string aDÂ_005B_0091_0086);

		[Token(Token = "0x60011ED")]
		void Exception(Exception pb_0084Z_00A3_0082);
	}
}
