using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000DA2")]
	public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x6005490")]
		[Address(RVA = "0x4327EC8", Offset = "0x4323EC8", VA = "0x4327EC8")]
		static LocalizeTarget_UnityStandard_Prefab()
		{
		}

		[Token(Token = "0x6005491")]
		[Address(RVA = "0x4327ECC", Offset = "0x4323ECC", VA = "0x4327ECC")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6005492")]
		[Address(RVA = "0x4327F6C", Offset = "0x4323F6C", VA = "0x4327F6C", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005493")]
		[Address(RVA = "0x4327F74", Offset = "0x4323F74", VA = "0x4327F74", Slot = "11")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005494")]
		[Address(RVA = "0x4327F7C", Offset = "0x4323F7C", VA = "0x4327F7C", Slot = "12")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005495")]
		[Address(RVA = "0x4327F84", Offset = "0x4323F84", VA = "0x4327F84", Slot = "8")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x6005496")]
		[Address(RVA = "0x4327F8C", Offset = "0x4323F8C", VA = "0x4327F8C", Slot = "9")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x6005497")]
		[Address(RVA = "0x4327F94", Offset = "0x4323F94", VA = "0x4327F94", Slot = "10")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x6005498")]
		[Address(RVA = "0x4327F9C", Offset = "0x4323F9C", VA = "0x4327F9C", Slot = "6")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizeTarget_UnityStandard_Prefab.GetFinalTerms RVA=0x4327F9C Token=0x6005498");
}

		[Token(Token = "0x6005499")]
		[Address(RVA = "0x4327FD4", Offset = "0x4323FD4", VA = "0x4327FD4", Slot = "7")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x600549A")]
		[Address(RVA = "0x43281D8", Offset = "0x43241D8", VA = "0x43281D8")]
		private Transform InstantiateNewPrefab(Localize cmp, string mainTranslation)
		{
			return null;
		}

		[Token(Token = "0x600549B")]
		[Address(RVA = "0x432837C", Offset = "0x432437C", VA = "0x432837C")]
		public LocalizeTarget_UnityStandard_Prefab()
		{
		}
	}
}
