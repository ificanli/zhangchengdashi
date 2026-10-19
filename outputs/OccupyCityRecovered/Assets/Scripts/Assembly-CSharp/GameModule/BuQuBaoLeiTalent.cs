using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003AD")]
	public class BuQuBaoLeiTalent : TalentBase
	{
		[Token(Token = "0x60010A8")]
		[Address(RVA = "0x3DA2720", Offset = "0x3D9E720", VA = "0x3DA2720")]
		public BuQuBaoLeiTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010A9")]
		[Address(RVA = "0x3DA2728", Offset = "0x3D9E728", VA = "0x3DA2728", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}

		[Token(Token = "0x60010AA")]
		[Address(RVA = "0x3DA28AC", Offset = "0x3D9E8AC", VA = "0x3DA28AC", Slot = "7")]
		public override void Clear()
		{
		}
	}
}
