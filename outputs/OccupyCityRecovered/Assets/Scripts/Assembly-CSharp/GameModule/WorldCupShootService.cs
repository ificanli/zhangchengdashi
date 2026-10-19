using Il2CppDummyDll;
using UIModuleO;

namespace GameModule
{
	[Token(Token = "0x200060E")]
	public class WorldCupShootService
	{
		[Token(Token = "0x4003251")]
		[FieldOffset(Offset = "0x10")]
		private readonly WorldCupActivityState _state;

		[Token(Token = "0x4003252")]
		[FieldOffset(Offset = "0x18")]
		private readonly WorldCupActivityGm _gm;

		[Token(Token = "0x6002053")]
		[Address(RVA = "0x3F059CC", Offset = "0x3F019CC", VA = "0x3F059CC")]
		public WorldCupShootService(WorldCupActivityState state, WorldCupActivityGm gm)
		{
		}

		[Token(Token = "0x6002054")]
		[Address(RVA = "0x3F0F724", Offset = "0x3F0B724", VA = "0x3F0F724")]
		public bool TryResolveShoot(int multiplier, FootballShootResult shootResult, out WorldCupShootResultPayload payload, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupShootService.TryResolveShoot RVA=0x3F0F724 Token=0x6002054");
}

		[Token(Token = "0x6002055")]
		[Address(RVA = "0x3F0F934", Offset = "0x3F0B934", VA = "0x3F0F934")]
		public void RefundFootball(int count)
		{
		}
	}
}
