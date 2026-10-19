using System.Numerics;
using Il2CppDummyDll;

namespace ToolModule
{
	[Token(Token = "0x200019B")]
	public static class FormulaTool
	{
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x3F7F918", Offset = "0x3F7B918", VA = "0x3F7F918")]
		public static BigInteger EvaluateFormula(string formula, params string[] args)
		{
			return default;
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x3F7FACC", Offset = "0x3F7BACC", VA = "0x3F7FACC")]
		public static float EvaluateFormulaFloat(string formula, params string[] args)
		{
			return default;
		}
	}
}
