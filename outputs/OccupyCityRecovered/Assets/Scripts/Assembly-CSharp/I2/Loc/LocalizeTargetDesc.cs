using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000D99")]
	public abstract class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor where T : ILocalizeTarget
	{
		[Token(Token = "0x600544F")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x6005450")]
		public override Type GetTargetType()
		{
			return null;
		}

		[Token(Token = "0x6005451")]
		protected LocalizeTargetDesc()
		{
		}
	}
}
