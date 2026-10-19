using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000DA4")]
	public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<TextMesh>
	{
		[Token(Token = "0x4006036")]
		[FieldOffset(Offset = "0x20")]
		private TextAlignment mAlignment_RTL;

		[Token(Token = "0x4006037")]
		[FieldOffset(Offset = "0x24")]
		private TextAlignment mAlignment_LTR;

		[Token(Token = "0x4006038")]
		[FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x4006039")]
		[FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x60054A6")]
		[Address(RVA = "0x43286B8", Offset = "0x43246B8", VA = "0x43286B8")]
		static LocalizeTarget_UnityStandard_TextMesh()
		{
		}

		[Token(Token = "0x60054A7")]
		[Address(RVA = "0x43286BC", Offset = "0x43246BC", VA = "0x43286BC")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60054A8")]
		[Address(RVA = "0x4328774", Offset = "0x4324774", VA = "0x4328774", Slot = "11")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60054A9")]
		[Address(RVA = "0x432877C", Offset = "0x432477C", VA = "0x432877C", Slot = "12")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60054AA")]
		[Address(RVA = "0x4328784", Offset = "0x4324784", VA = "0x4328784", Slot = "8")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x60054AB")]
		[Address(RVA = "0x432878C", Offset = "0x432478C", VA = "0x432878C", Slot = "9")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60054AC")]
		[Address(RVA = "0x4328794", Offset = "0x4324794", VA = "0x4328794", Slot = "10")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60054AD")]
		[Address(RVA = "0x432879C", Offset = "0x432479C", VA = "0x432879C", Slot = "6")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizeTarget_UnityStandard_TextMesh.GetFinalTerms RVA=0x432879C Token=0x60054AD");
}

		[Token(Token = "0x60054AE")]
		[Address(RVA = "0x43288B8", Offset = "0x43248B8", VA = "0x43288B8", Slot = "7")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60054AF")]
		[Address(RVA = "0x4328B60", Offset = "0x4324B60", VA = "0x4328B60")]
		public LocalizeTarget_UnityStandard_TextMesh()
		{
		}
	}
}
