using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
	[Token(Token = "0x2000DA6")]
	public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image>
	{
		[Token(Token = "0x60054BA")]
		[Address(RVA = "0x4328EAC", Offset = "0x4324EAC", VA = "0x4328EAC")]
		static LocalizeTarget_UnityUI_Image()
		{
		}

		[Token(Token = "0x60054BB")]
		[Address(RVA = "0x4328EB0", Offset = "0x4324EB0", VA = "0x4328EB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60054BC")]
		[Address(RVA = "0x4328F68", Offset = "0x4324F68", VA = "0x4328F68", Slot = "8")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x60054BD")]
		[Address(RVA = "0x4328F70", Offset = "0x4324F70", VA = "0x4328F70", Slot = "9")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60054BE")]
		[Address(RVA = "0x4328F78", Offset = "0x4324F78", VA = "0x4328F78", Slot = "10")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60054BF")]
		[Address(RVA = "0x4328F80", Offset = "0x4324F80", VA = "0x4328F80", Slot = "11")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60054C0")]
		[Address(RVA = "0x4329000", Offset = "0x4325000", VA = "0x4329000", Slot = "12")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60054C1")]
		[Address(RVA = "0x4329008", Offset = "0x4325008", VA = "0x4329008", Slot = "6")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizeTarget_UnityUI_Image.GetFinalTerms RVA=0x4329008 Token=0x60054C1");
}

		[Token(Token = "0x60054C2")]
		[Address(RVA = "0x4329184", Offset = "0x4325184", VA = "0x4329184", Slot = "7")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60054C3")]
		[Address(RVA = "0x4329274", Offset = "0x4325274", VA = "0x4329274")]
		public LocalizeTarget_UnityUI_Image()
		{
		}
	}
}
