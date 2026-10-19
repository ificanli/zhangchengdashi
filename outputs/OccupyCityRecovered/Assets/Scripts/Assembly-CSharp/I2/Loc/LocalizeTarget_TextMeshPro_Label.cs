using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000D9B")]
	public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TextMeshPro>
	{
		[Token(Token = "0x400602D")]
		[FieldOffset(Offset = "0x20")]
		private TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x400602E")]
		[FieldOffset(Offset = "0x24")]
		private TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x400602F")]
		[FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x4006030")]
		[FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x6005455")]
		[Address(RVA = "0x4325F78", Offset = "0x4321F78", VA = "0x4325F78")]
		static LocalizeTarget_TextMeshPro_Label()
		{
		}

		[Token(Token = "0x6005456")]
		[Address(RVA = "0x4325F7C", Offset = "0x4321F7C", VA = "0x4325F7C")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6005457")]
		[Address(RVA = "0x4326034", Offset = "0x4322034", VA = "0x4326034", Slot = "11")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005458")]
		[Address(RVA = "0x432603C", Offset = "0x432203C", VA = "0x432603C", Slot = "12")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005459")]
		[Address(RVA = "0x4326044", Offset = "0x4322044", VA = "0x4326044", Slot = "8")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x600545A")]
		[Address(RVA = "0x432604C", Offset = "0x432204C", VA = "0x432604C", Slot = "9")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x600545B")]
		[Address(RVA = "0x4326054", Offset = "0x4322054", VA = "0x4326054", Slot = "10")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x600545C")]
		[Address(RVA = "0x432605C", Offset = "0x432205C", VA = "0x432605C", Slot = "6")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizeTarget_TextMeshPro_Label.GetFinalTerms RVA=0x432605C Token=0x600545C");
}

		[Token(Token = "0x600545D")]
		[Address(RVA = "0x4326168", Offset = "0x4322168", VA = "0x4326168", Slot = "7")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x600545E")]
		[Address(RVA = "0x43266F4", Offset = "0x43226F4", VA = "0x43266F4")]
		internal static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName)
		{
			return null;
		}

		[Token(Token = "0x600545F")]
		[Address(RVA = "0x4326964", Offset = "0x4322964", VA = "0x4326964")]
		internal static void InitAlignment_TMPro(bool isRTL, TextAlignmentOptions alignment, out TextAlignmentOptions alignLTR, out TextAlignmentOptions alignRTL)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizeTarget_TextMeshPro_Label.InitAlignment_TMPro RVA=0x4326964 Token=0x600545F");
}

		[Token(Token = "0x6005460")]
		[Address(RVA = "0x4326614", Offset = "0x4322614", VA = "0x4326614")]
		internal static void SetFont(TMP_Text label, TMP_FontAsset newFont)
		{
		}

		[Token(Token = "0x6005461")]
		[Address(RVA = "0x4326864", Offset = "0x4322864", VA = "0x4326864")]
		internal static void SetMaterial(TMP_Text label, Material newMat)
		{
		}

		[Token(Token = "0x6005462")]
		[Address(RVA = "0x4326B4C", Offset = "0x4322B4C", VA = "0x4326B4C")]
		public LocalizeTarget_TextMeshPro_Label()
		{
		}
	}
}
