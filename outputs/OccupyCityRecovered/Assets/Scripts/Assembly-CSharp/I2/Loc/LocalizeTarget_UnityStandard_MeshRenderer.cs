using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000DA0")]
	public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer>
	{
		[Token(Token = "0x6005484")]
		[Address(RVA = "0x43279A4", Offset = "0x43239A4", VA = "0x43279A4")]
		static LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}

		[Token(Token = "0x6005485")]
		[Address(RVA = "0x43279A8", Offset = "0x43239A8", VA = "0x43279A8")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6005486")]
		[Address(RVA = "0x4327A60", Offset = "0x4323A60", VA = "0x4327A60", Slot = "11")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005487")]
		[Address(RVA = "0x4327A68", Offset = "0x4323A68", VA = "0x4327A68", Slot = "12")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005488")]
		[Address(RVA = "0x4327A70", Offset = "0x4323A70", VA = "0x4327A70", Slot = "8")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x6005489")]
		[Address(RVA = "0x4327A78", Offset = "0x4323A78", VA = "0x4327A78", Slot = "9")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x600548A")]
		[Address(RVA = "0x4327A80", Offset = "0x4323A80", VA = "0x4327A80", Slot = "10")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x600548B")]
		[Address(RVA = "0x4327A88", Offset = "0x4323A88", VA = "0x4327A88", Slot = "6")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizeTarget_UnityStandard_MeshRenderer.GetFinalTerms RVA=0x4327A88 Token=0x600548B");
}

		[Token(Token = "0x600548C")]
		[Address(RVA = "0x4327C64", Offset = "0x4323C64", VA = "0x4327C64", Slot = "7")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x600548D")]
		[Address(RVA = "0x4327E30", Offset = "0x4323E30", VA = "0x4327E30")]
		public LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}
	}
}
