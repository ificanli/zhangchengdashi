using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000D9C")]
	public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TextMeshProUGUI>
	{
		[Token(Token = "0x4006031")]
		[FieldOffset(Offset = "0x20")]
		public TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x4006032")]
		[FieldOffset(Offset = "0x24")]
		public TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x4006033")]
		[FieldOffset(Offset = "0x28")]
		public bool mAlignmentWasRTL;

		[Token(Token = "0x4006034")]
		[FieldOffset(Offset = "0x29")]
		public bool mInitializeAlignment;

		[Token(Token = "0x4006035")]
		private const string None = "<none>";

		[Token(Token = "0x6005463")]
		[Address(RVA = "0x4326BA8", Offset = "0x4322BA8", VA = "0x4326BA8")]
		static LocalizeTarget_TextMeshPro_UGUI()
		{
		}

		[Token(Token = "0x6005464")]
		[Address(RVA = "0x4326BAC", Offset = "0x4322BAC", VA = "0x4326BAC")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6005465")]
		[Address(RVA = "0x4326C64", Offset = "0x4322C64", VA = "0x4326C64", Slot = "11")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005466")]
		[Address(RVA = "0x4326C6C", Offset = "0x4322C6C", VA = "0x4326C6C", Slot = "12")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005467")]
		[Address(RVA = "0x4326C74", Offset = "0x4322C74", VA = "0x4326C74", Slot = "8")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x6005468")]
		[Address(RVA = "0x4326C7C", Offset = "0x4322C7C", VA = "0x4326C7C", Slot = "9")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x6005469")]
		[Address(RVA = "0x4326C84", Offset = "0x4322C84", VA = "0x4326C84", Slot = "10")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x600546A")]
		[Address(RVA = "0x4326C8C", Offset = "0x4322C8C", VA = "0x4326C8C", Slot = "6")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizeTarget_TextMeshPro_UGUI.GetFinalTerms RVA=0x4326C8C Token=0x600546A");
}

		[Token(Token = "0x600546B")]
		[Address(RVA = "0x4326D98", Offset = "0x4322D98", VA = "0x4326D98", Slot = "7")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x600546C")]
		[Address(RVA = "0x4327284", Offset = "0x4323284", VA = "0x4327284")]
		public LocalizeTarget_TextMeshPro_UGUI()
		{
		}
	}
}
