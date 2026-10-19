using System;
using Il2CppDummyDll;

namespace GameFramework.Procedure
{
	[Token(Token = "0x2000450")]
	public interface IProcedureManager
	{
		[Token(Token = "0x1700119F")]
		ProcedureBase CurrentProcedure
		{
			[Token(Token = "0x6006A19")]
			get;
		}

		[Token(Token = "0x170011A0")]
		float CurrentProcedureTime
		{
			[Token(Token = "0x6006A1A")]
			get;
		}

		[Token(Token = "0x6006A1B")]
		void StartProcedure<T>() where T : ProcedureBase;

		[Token(Token = "0x6006A1C")]
		void StartProcedure(Type procedureType);

		[Token(Token = "0x6006A1D")]
		bool HasProcedure<T>() where T : ProcedureBase;

		[Token(Token = "0x6006A1E")]
		bool HasProcedure(Type procedureType);

		[Token(Token = "0x6006A1F")]
		ProcedureBase GetProcedure<T>() where T : ProcedureBase;

		[Token(Token = "0x6006A20")]
		ProcedureBase GetProcedure(Type procedureType);
	}
}
