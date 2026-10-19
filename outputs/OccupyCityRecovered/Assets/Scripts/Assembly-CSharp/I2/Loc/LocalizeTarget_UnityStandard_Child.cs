using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000D9F")]
	public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x6005479")]
		[Address(RVA = "0x43276E4", Offset = "0x43236E4", VA = "0x43276E4")]
		static LocalizeTarget_UnityStandard_Child()
		{
		}

		[Token(Token = "0x600547A")]
		[Address(RVA = "0x43276E8", Offset = "0x43236E8", VA = "0x43276E8")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x600547B")]
		[Address(RVA = "0x4327788", Offset = "0x4323788", VA = "0x4327788", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x600547C")]
		[Address(RVA = "0x43277BC", Offset = "0x43237BC", VA = "0x43277BC", Slot = "11")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x600547D")]
		[Address(RVA = "0x43277C4", Offset = "0x43237C4", VA = "0x43277C4", Slot = "12")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x600547E")]
		[Address(RVA = "0x43277CC", Offset = "0x43237CC", VA = "0x43277CC", Slot = "8")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x600547F")]
		[Address(RVA = "0x43277D4", Offset = "0x43237D4", VA = "0x43277D4", Slot = "9")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x6005480")]
		[Address(RVA = "0x43277DC", Offset = "0x43237DC", VA = "0x43277DC", Slot = "10")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x6005481")]
		[Address(RVA = "0x43277E4", Offset = "0x43237E4", VA = "0x43277E4", Slot = "6")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizeTarget_UnityStandard_Child.GetFinalTerms RVA=0x43277E4 Token=0x6005481");
}

		[Token(Token = "0x6005482")]
		[Address(RVA = "0x432781C", Offset = "0x432381C", VA = "0x432781C", Slot = "7")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6005483")]
		[Address(RVA = "0x432795C", Offset = "0x432395C", VA = "0x432795C")]
		public LocalizeTarget_UnityStandard_Child()
		{
		}
	}
}
