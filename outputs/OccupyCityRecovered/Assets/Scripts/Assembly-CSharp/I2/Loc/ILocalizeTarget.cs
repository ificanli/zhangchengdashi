using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000D96")]
	public abstract class ILocalizeTarget : ScriptableObject
	{
		[Token(Token = "0x600543E")]
		public abstract bool IsValid(Localize cmp);

		[Token(Token = "0x600543F")]
		[Address(RVA = "0x4325F64", Offset = "0x4321F64", VA = "0x4325F64", Slot = "5")]
		public virtual void ReleaseTarget()
		{
		}

		[Token(Token = "0x6005440")]
		public abstract void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm);

		[Token(Token = "0x6005441")]
		public abstract void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation);

		[Token(Token = "0x6005442")]
		public abstract bool CanUseSecondaryTerm();

		[Token(Token = "0x6005443")]
		public abstract bool AllowMainTermToBeRTL();

		[Token(Token = "0x6005444")]
		public abstract bool AllowSecondTermToBeRTL();

		[Token(Token = "0x6005445")]
		public abstract eTermType GetPrimaryTermType(Localize cmp);

		[Token(Token = "0x6005446")]
		public abstract eTermType GetSecondaryTermType(Localize cmp);

		[Token(Token = "0x6005447")]
		[Address(RVA = "0x4325F68", Offset = "0x4321F68", VA = "0x4325F68")]
		protected ILocalizeTarget()
		{
		}
	}
}
