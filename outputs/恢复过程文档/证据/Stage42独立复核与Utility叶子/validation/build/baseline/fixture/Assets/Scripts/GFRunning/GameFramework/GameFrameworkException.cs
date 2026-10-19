using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace GameFramework
{
	[Serializable]
	[Token(Token = "0x2000333")]
	public class GameFrameworkException : Exception
	{
		[Token(Token = "0x60055EF")]
		[Address(RVA = "0x715BF5C", Offset = "0x7157F5C", VA = "0x715BF5C")]
		protected GameFrameworkException(SerializationInfo _00BF_00B2KfsF, StreamingContext _0094_0060_0081s_009A_00AE)
		{
		}

		[Token(Token = "0x60055F0")]
		[Address(RVA = "0x715BFDC", Offset = "0x7157FDC", VA = "0x715BFDC")]
		public GameFrameworkException(string aDÂ_005B_0091_0086)
		{
		}

		[Token(Token = "0x60055F1")]
		[Address(RVA = "0x715C044", Offset = "0x7158044", VA = "0x715C044")]
		public GameFrameworkException(string aDÂ_005B_0091_0086, Exception fA_009Ak_00B8_00B3)
		{
		}

		[Token(Token = "0x60055F2")]
		[Address(RVA = "0x715C0B4", Offset = "0x71580B4", VA = "0x715C0B4")]
		public GameFrameworkException()
		{
		}
	}
}
