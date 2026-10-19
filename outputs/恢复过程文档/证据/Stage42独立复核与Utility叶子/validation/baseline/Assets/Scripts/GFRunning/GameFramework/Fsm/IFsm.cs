using System;
using Il2CppDummyDll;

namespace GameFramework.Fsm
{
	[Token(Token = "0x2000495")]
	public interface IFsm<T> where T : class
	{
		[Token(Token = "0x170011E8")]
		string Name
		{
			[Token(Token = "0x6006CF4")]
			get;
		}

		[Token(Token = "0x170011E9")]
		string FullName
		{
			[Token(Token = "0x6006CF5")]
			get;
		}

		[Token(Token = "0x170011EA")]
		T Owner
		{
			[Token(Token = "0x6006CF6")]
			get;
		}

		[Token(Token = "0x170011EB")]
		int FsmStateCount
		{
			[Token(Token = "0x6006CF7")]
			get;
		}

		[Token(Token = "0x170011EC")]
		bool IsRunning
		{
			[Token(Token = "0x6006CF8")]
			get;
		}

		[Token(Token = "0x170011ED")]
		bool IsDestroyed
		{
			[Token(Token = "0x6006CF9")]
			get;
		}

		[Token(Token = "0x170011EE")]
		FsmState<T> CurrentState
		{
			[Token(Token = "0x6006CFA")]
			get;
		}

		[Token(Token = "0x170011EF")]
		float CurrentStateTime
		{
			[Token(Token = "0x6006CFB")]
			get;
		}

		[Token(Token = "0x6006CFC")]
		void Start<TState>(params object[] _00BC_00AE_007DW_00A3_0090) where TState : FsmState<T>;

		[Token(Token = "0x6006CFD")]
		void Start(Type k_005BY_00A0_0099p, params object[] _00BC_00AE_007DW_00A3_0090);

		[Token(Token = "0x6006CFE")]
		bool HasState<TState>() where TState : FsmState<T>;

		[Token(Token = "0x6006CFF")]
		bool HasState(Type k_005BY_00A0_0099p);

		[Token(Token = "0x6006D00")]
		TState GetState<TState>() where TState : FsmState<T>;

		[Token(Token = "0x6006D01")]
		FsmState<T> GetState(Type k_005BY_00A0_0099p);

		[Token(Token = "0x6006D02")]
		void FireEvent(object _00B2w_00B7_00A7h_00B9, int U_0085a_00B7_008CÁ);

		[Token(Token = "0x6006D03")]
		void FireEvent(object _00B2w_00B7_00A7h_00B9, int U_0085a_00B7_008CÁ, object _00B4sT_00ABV_007E);

		[Token(Token = "0x6006D04")]
		bool HasData(string _00AE_008C_009AiPJ);

		[Token(Token = "0x6006D05")]
		Variable GetData(string _00AE_008C_009AiPJ);

		[Token(Token = "0x6006D06")]
		TData GetData<TData>(string _00AE_008C_009AiPJ) where TData : Variable;

		[Token(Token = "0x6006D07")]
		void SetData<TData>(string _00AE_008C_009AiPJ, TData _009F_0080_005B_009F_0086_0089) where TData : Variable;

		[Token(Token = "0x6006D08")]
		bool RemoveData(string _00AE_008C_009AiPJ);
	}
}
