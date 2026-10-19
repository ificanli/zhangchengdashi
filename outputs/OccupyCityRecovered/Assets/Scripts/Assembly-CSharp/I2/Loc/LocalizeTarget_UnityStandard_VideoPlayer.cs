using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace I2.Loc
{
	[Token(Token = "0x2000DA5")]
	public class LocalizeTarget_UnityStandard_VideoPlayer : LocalizeTarget<VideoPlayer>
	{
		[Token(Token = "0x60054B0")]
		[Address(RVA = "0x4328BB8", Offset = "0x4324BB8", VA = "0x4328BB8")]
		static LocalizeTarget_UnityStandard_VideoPlayer()
		{
		}

		[Token(Token = "0x60054B1")]
		[Address(RVA = "0x4328BBC", Offset = "0x4324BBC", VA = "0x4328BBC")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60054B2")]
		[Address(RVA = "0x4328C74", Offset = "0x4324C74", VA = "0x4328C74", Slot = "11")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60054B3")]
		[Address(RVA = "0x4328C7C", Offset = "0x4324C7C", VA = "0x4328C7C", Slot = "12")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60054B4")]
		[Address(RVA = "0x4328C84", Offset = "0x4324C84", VA = "0x4328C84", Slot = "8")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x60054B5")]
		[Address(RVA = "0x4328C8C", Offset = "0x4324C8C", VA = "0x4328C8C", Slot = "9")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60054B6")]
		[Address(RVA = "0x4328C94", Offset = "0x4324C94", VA = "0x4328C94", Slot = "10")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60054B7")]
		[Address(RVA = "0x4328C9C", Offset = "0x4324C9C", VA = "0x4328C9C", Slot = "6")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizeTarget_UnityStandard_VideoPlayer.GetFinalTerms RVA=0x4328C9C Token=0x60054B7");
}

		[Token(Token = "0x60054B8")]
		[Address(RVA = "0x4328D68", Offset = "0x4324D68", VA = "0x4328D68", Slot = "7")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60054B9")]
		[Address(RVA = "0x4328E64", Offset = "0x4324E64", VA = "0x4328E64")]
		public LocalizeTarget_UnityStandard_VideoPlayer()
		{
		}
	}
}
