using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000D9D")]
	public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource>
	{
		[Token(Token = "0x600546D")]
		[Address(RVA = "0x43272E0", Offset = "0x43232E0", VA = "0x43272E0")]
		static LocalizeTarget_UnityStandard_AudioSource()
		{
		}

		[Token(Token = "0x600546E")]
		[Address(RVA = "0x43272E4", Offset = "0x43232E4", VA = "0x43272E4")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x600546F")]
		[Address(RVA = "0x432739C", Offset = "0x432339C", VA = "0x432739C", Slot = "11")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005470")]
		[Address(RVA = "0x43273A4", Offset = "0x43233A4", VA = "0x43273A4", Slot = "12")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005471")]
		[Address(RVA = "0x43273AC", Offset = "0x43233AC", VA = "0x43273AC", Slot = "8")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x6005472")]
		[Address(RVA = "0x43273B4", Offset = "0x43233B4", VA = "0x43273B4", Slot = "9")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x6005473")]
		[Address(RVA = "0x43273BC", Offset = "0x43233BC", VA = "0x43273BC", Slot = "10")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x6005474")]
		[Address(RVA = "0x43273C4", Offset = "0x43233C4", VA = "0x43273C4", Slot = "6")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizeTarget_UnityStandard_AudioSource.GetFinalTerms RVA=0x43273C4 Token=0x6005474");
}

		[Token(Token = "0x6005475")]
		[Address(RVA = "0x432748C", Offset = "0x432348C", VA = "0x432748C", Slot = "7")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6005476")]
		[Address(RVA = "0x4327620", Offset = "0x4323620", VA = "0x4327620")]
		public LocalizeTarget_UnityStandard_AudioSource()
		{
		}
	}
}
