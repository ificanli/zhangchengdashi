using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000245")]
	public enum GameEventType
	{
		[Token(Token = "0x4001E46")]
		OnAttack = 0,
		[Token(Token = "0x4001E47")]
		OnHurt = 1,
		[Token(Token = "0x4001E48")]
		OnKill = 2,
		[Token(Token = "0x4001E49")]
		OnMove = 3,
		[Token(Token = "0x4001E4A")]
		OnHealthChange = 4,
		[Token(Token = "0x4001E4B")]
		OnInit = 5,
		[Token(Token = "0x4001E4C")]
		OnTime = 6,
		[Token(Token = "0x4001E4D")]
		OnDead = 7,
		[Token(Token = "0x4001E4E")]
		OnUpdate = 8
	}
}
