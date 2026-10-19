using Il2CppDummyDll;

namespace GameFramework.Fsm
{
	[Token(Token = "0x2000496")]
	public interface IFsmManager
	{
		[Token(Token = "0x170011F0")]
		int Count
		{
			[Token(Token = "0x6006D09")]
			get;
		}

		[Token(Token = "0x6006D0A")]
		bool HasFsm<T>() where T : class;

		[Token(Token = "0x6006D0B")]
		bool HasFsm<T>(string _00AE_008C_009AiPJ) where T : class;

		[Token(Token = "0x6006D0C")]
		IFsm<T> GetFsm<T>() where T : class;

		[Token(Token = "0x6006D0D")]
		IFsm<T> GetFsm<T>(string _00AE_008C_009AiPJ) where T : class;

		[Token(Token = "0x6006D0E")]
		FsmBase[] GetAllFsms();

		[Token(Token = "0x6006D0F")]
		IFsm<T> CreateFsm<T>(T Z_009Aj_009Bqd, params FsmState<T>[] e_00BD_007CyA_00A9) where T : class;

		[Token(Token = "0x6006D10")]
		IFsm<T> CreateFsm<T>(string _00AE_008C_009AiPJ, T Z_009Aj_009Bqd, params FsmState<T>[] e_00BD_007CyA_00A9) where T : class;

		[Token(Token = "0x6006D11")]
		bool DestroyFsm<T>() where T : class;

		[Token(Token = "0x6006D12")]
		bool DestroyFsm<T>(string _00AE_008C_009AiPJ) where T : class;

		[Token(Token = "0x6006D13")]
		bool DestroyFsm<T>(IFsm<T> _00A2µ_00A6q_0086c) where T : class;
	}
}
