using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000DA3")]
	public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<SpriteRenderer>
	{
		[Token(Token = "0x600549C")]
		[Address(RVA = "0x43283C4", Offset = "0x43243C4", VA = "0x43283C4")]
		static LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}

		[Token(Token = "0x600549D")]
		[Address(RVA = "0x43283C8", Offset = "0x43243C8", VA = "0x43283C8")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x600549E")]
		[Address(RVA = "0x4328480", Offset = "0x4324480", VA = "0x4328480", Slot = "11")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x600549F")]
		[Address(RVA = "0x4328488", Offset = "0x4324488", VA = "0x4328488", Slot = "12")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60054A0")]
		[Address(RVA = "0x4328490", Offset = "0x4324490", VA = "0x4328490", Slot = "8")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x60054A1")]
		[Address(RVA = "0x4328498", Offset = "0x4324498", VA = "0x4328498", Slot = "9")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60054A2")]
		[Address(RVA = "0x43284A0", Offset = "0x43244A0", VA = "0x43284A0", Slot = "10")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60054A3")]
		[Address(RVA = "0x43284A8", Offset = "0x43244A8", VA = "0x43284A8", Slot = "6")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizeTarget_UnityStandard_SpriteRenderer.GetFinalTerms RVA=0x43284A8 Token=0x60054A3");
}

		[Token(Token = "0x60054A4")]
		[Address(RVA = "0x4328574", Offset = "0x4324574", VA = "0x4328574", Slot = "7")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60054A5")]
		[Address(RVA = "0x4328670", Offset = "0x4324670", VA = "0x4328670")]
		public LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}
	}
}
