using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000D9A")]
	public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G> where T : Object where G : LocalizeTarget<T>
	{
		[Token(Token = "0x6005452")]
		public override bool CanLocalize(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005453")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x6005454")]
		public LocalizeTargetDesc_Type()
		{
		}
	}
}
