using GameFramework.Base;
using Il2CppDummyDll;

[Token(Token = "0x20004BF")]
internal interface _008D_0084v_0097zh<T> where T : _009DzfAZs
{
	[Token(Token = "0x1700122C")]
	float FreeWaitTimes
	{
		[Token(Token = "0x60071BA")]
		get;
		[Token(Token = "0x60071BB")]
		set;
	}

	[Token(Token = "0x1700122D")]
	T Task
	{
		[Token(Token = "0x60071BC")]
		get;
	}

	[Token(Token = "0x60071BD")]
	void Initialize();

	[Token(Token = "0x60071BE")]
	StartTaskStatus Start(T Z_00B6_0093D_0098q);

	[Token(Token = "0x60071BF")]
	void Update(float _008EJ_0092_009BUc, float rfjÀ_0098L);

	[Token(Token = "0x60071C0")]
	void Reset();

	[Token(Token = "0x60071C1")]
	void Shutdown();
}
