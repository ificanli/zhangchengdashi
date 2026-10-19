using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x2000627")]
	public class SubGameBuffYouAreCrying : SubGameBuffBase
	{
		[Token(Token = "0x4003279")]
		private const float HpReduceRatio = 0.1f;

		[Token(Token = "0x400327A")]
		public const int AiEmojiIntervalSeconds = 8;

		[Token(Token = "0x400327B")]
		public const int AiEmojiSendChance = 80;

		[Token(Token = "0x400327C")]
		public const float AiEmojiCooldownSeconds = 6f;

		[Token(Token = "0x400327D")]
		public const int AiEmojiReactionChance = 80;

		[Token(Token = "0x400327E")]
		public const float AiEmojiPlayerReplyDelaySeconds = 1.5f;

		[Token(Token = "0x600209A")]
		[Address(RVA = "0x3F116B8", Offset = "0x3F0D6B8", VA = "0x3F116B8")]
		public SubGameBuffYouAreCrying() : base(1007)
		{
		}

		[Token(Token = "0x600209B")]
		[Address(RVA = "0x3F116C4", Offset = "0x3F0D6C4", VA = "0x3F116C4", Slot = "17")]
		public override void OnEmojiSent(bool senderIsEnemy)
		{
		}
	}
}
