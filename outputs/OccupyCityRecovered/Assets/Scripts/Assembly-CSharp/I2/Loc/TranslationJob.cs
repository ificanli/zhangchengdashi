using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000D6F")]
	public class TranslationJob : IDisposable
	{
		[Token(Token = "0x2000D70")]
		public enum eJobState
		{
			[Token(Token = "0x4005F5C")]
			Running = 0,
			[Token(Token = "0x4005F5D")]
			Succeeded = 1,
			[Token(Token = "0x4005F5E")]
			Failed = 2
		}

		[Token(Token = "0x4005F5A")]
		[FieldOffset(Offset = "0x10")]
		public eJobState mJobState;

		[Token(Token = "0x600530F")]
		[Address(RVA = "0x4310CBC", Offset = "0x430CCBC", VA = "0x4310CBC", Slot = "5")]
		public virtual eJobState GetState()
		{
			return default;
		}

		[Token(Token = "0x6005310")]
		[Address(RVA = "0x4310CC4", Offset = "0x430CCC4", VA = "0x4310CC4", Slot = "6")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6005311")]
		[Address(RVA = "0x4310CC8", Offset = "0x430CCC8", VA = "0x4310CC8")]
		public TranslationJob()
		{
		}
	}
}
