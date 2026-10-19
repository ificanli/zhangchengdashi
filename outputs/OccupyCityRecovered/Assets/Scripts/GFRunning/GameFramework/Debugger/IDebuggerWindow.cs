using Il2CppDummyDll;

namespace GameFramework.Debugger
{
	[Token(Token = "0x20004AD")]
	public interface IDebuggerWindow
	{
		[Token(Token = "0x6007025")]
		void Initialize(params object[] _00BC_00AE_007DW_00A3_0090);

		[Token(Token = "0x6007026")]
		void Shutdown();

		[Token(Token = "0x6007027")]
		void OnEnter();

		[Token(Token = "0x6007028")]
		void OnLeave();

		[Token(Token = "0x6007029")]
		void OnUpdate(float _008EJ_0092_009BUc, float rfjÀ_0098L);

		[Token(Token = "0x600702A")]
		void OnDraw();
	}
}
