using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
	[Token(Token = "0x2000DA7")]
	public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<RawImage>
	{
		[Token(Token = "0x60054C4")]
		[Address(RVA = "0x43292BC", Offset = "0x43252BC", VA = "0x43292BC")]
		static LocalizeTarget_UnityUI_RawImage()
		{
		}

		[Token(Token = "0x60054C5")]
		[Address(RVA = "0x43292C0", Offset = "0x43252C0", VA = "0x43292C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60054C6")]
		[Address(RVA = "0x4329378", Offset = "0x4325378", VA = "0x4329378", Slot = "11")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60054C7")]
		[Address(RVA = "0x4329380", Offset = "0x4325380", VA = "0x4329380", Slot = "12")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60054C8")]
		[Address(RVA = "0x4329388", Offset = "0x4325388", VA = "0x4329388", Slot = "8")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x60054C9")]
		[Address(RVA = "0x4329390", Offset = "0x4325390", VA = "0x4329390", Slot = "9")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60054CA")]
		[Address(RVA = "0x4329398", Offset = "0x4325398", VA = "0x4329398", Slot = "10")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60054CB")]
		[Address(RVA = "0x43293A0", Offset = "0x43253A0", VA = "0x43293A0", Slot = "6")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizeTarget_UnityUI_RawImage.GetFinalTerms RVA=0x43293A0 Token=0x60054CB");
}

		[Token(Token = "0x60054CC")]
		[Address(RVA = "0x432947C", Offset = "0x432547C", VA = "0x432947C", Slot = "7")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60054CD")]
		[Address(RVA = "0x432956C", Offset = "0x432556C", VA = "0x432956C")]
		public LocalizeTarget_UnityUI_RawImage()
		{
		}
	}
}
