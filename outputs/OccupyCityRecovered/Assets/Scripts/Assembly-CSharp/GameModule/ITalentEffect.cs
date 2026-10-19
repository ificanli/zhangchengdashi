using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000246")]
	public interface ITalentEffect
	{
		[Token(Token = "0x60009D0")]
		void OnEventTrigger(GameEventType eventType, GameEventArgs args);
	}
}
