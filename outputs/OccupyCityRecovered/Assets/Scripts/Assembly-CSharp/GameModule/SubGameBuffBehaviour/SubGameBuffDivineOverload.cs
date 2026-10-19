using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x2000617")]
	public class SubGameBuffDivineOverload : SubGameBuffBase
	{
		[Token(Token = "0x4003261")]
		private const float EffectScale = 2f;

		[Token(Token = "0x6002078")]
		[Address(RVA = "0x3F10824", Offset = "0x3F0C824", VA = "0x3F10824")]
		public SubGameBuffDivineOverload() : base(1020)
		{
		}

		[Token(Token = "0x6002079")]
		[Address(RVA = "0x3F10830", Offset = "0x3F0C830", VA = "0x3F10830", Slot = "16")]
		public override float GetPropEffectScale()
		{
			return default;
		}
	}
}
