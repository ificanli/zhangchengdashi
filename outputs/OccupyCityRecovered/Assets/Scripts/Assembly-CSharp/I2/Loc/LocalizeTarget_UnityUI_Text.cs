using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
	[Token(Token = "0x2000DA8")]
	public class LocalizeTarget_UnityUI_Text : LocalizeTarget<Text>
	{
		[Token(Token = "0x400603A")]
		[FieldOffset(Offset = "0x20")]
		private TextAnchor mAlignment_RTL;

		[Token(Token = "0x400603B")]
		[FieldOffset(Offset = "0x24")]
		private TextAnchor mAlignment_LTR;

		[Token(Token = "0x400603C")]
		[FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x400603D")]
		[FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x60054CE")]
		[Address(RVA = "0x43295B4", Offset = "0x43255B4", VA = "0x43295B4")]
		static LocalizeTarget_UnityUI_Text()
		{
		}

		[Token(Token = "0x60054CF")]
		[Address(RVA = "0x43295B8", Offset = "0x43255B8", VA = "0x43295B8")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60054D0")]
		[Address(RVA = "0x4329670", Offset = "0x4325670", VA = "0x4329670", Slot = "11")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60054D1")]
		[Address(RVA = "0x4329678", Offset = "0x4325678", VA = "0x4329678", Slot = "12")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60054D2")]
		[Address(RVA = "0x4329680", Offset = "0x4325680", VA = "0x4329680", Slot = "8")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x60054D3")]
		[Address(RVA = "0x4329688", Offset = "0x4325688", VA = "0x4329688", Slot = "9")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60054D4")]
		[Address(RVA = "0x4329690", Offset = "0x4325690", VA = "0x4329690", Slot = "10")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60054D5")]
		[Address(RVA = "0x4329698", Offset = "0x4325698", VA = "0x4329698", Slot = "6")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizeTarget_UnityUI_Text.GetFinalTerms RVA=0x4329698 Token=0x60054D5");
}

		[Token(Token = "0x60054D6")]
		[Address(RVA = "0x43297B4", Offset = "0x43257B4", VA = "0x43297B4", Slot = "7")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60054D7")]
		[Address(RVA = "0x4329A5C", Offset = "0x4325A5C", VA = "0x4329A5C")]
		private void InitAlignment(bool isRTL, TextAnchor alignment, out TextAnchor alignLTR, out TextAnchor alignRTL)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizeTarget_UnityUI_Text.InitAlignment RVA=0x4329A5C Token=0x60054D7");
}

		[Token(Token = "0x60054D8")]
		[Address(RVA = "0x4329B14", Offset = "0x4325B14", VA = "0x4329B14")]
		public LocalizeTarget_UnityUI_Text()
		{
		}
	}
}
