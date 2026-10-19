using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000D97")]
	public abstract class LocalizeTarget<T> : ILocalizeTarget where T : Object
	{
		[Token(Token = "0x400602A")]
		[FieldOffset(Offset = "0x0")]
		public T mTarget;

		[Token(Token = "0x6005448")]
		public override void ReleaseTarget()
		{
		}

		[Token(Token = "0x6005449")]
		public override bool IsValid(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x600544A")]
		protected LocalizeTarget()
		{
		}
	}
}
