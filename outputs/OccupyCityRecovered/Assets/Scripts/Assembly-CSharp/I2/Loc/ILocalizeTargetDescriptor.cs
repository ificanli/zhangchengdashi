using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000D98")]
	public abstract class ILocalizeTargetDescriptor
	{
		[Token(Token = "0x400602B")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400602C")]
		[FieldOffset(Offset = "0x18")]
		public int Priority;

		[Token(Token = "0x600544B")]
		public abstract bool CanLocalize(Localize cmp);

		[Token(Token = "0x600544C")]
		public abstract ILocalizeTarget CreateTarget(Localize cmp);

		[Token(Token = "0x600544D")]
		public abstract Type GetTargetType();

		[Token(Token = "0x600544E")]
		[Address(RVA = "0x4325F70", Offset = "0x4321F70", VA = "0x4325F70")]
		protected ILocalizeTargetDescriptor()
		{
		}
	}
}
