using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;

namespace StrConstants
{
	[Token(Token = "0x20000F2")]
	public static class BubbleTextConstants
	{
		[Token(Token = "0x20000F3")]
		public readonly struct BubbleTextInfo
		{
			[Token(Token = "0x40008A1")]
			[FieldOffset(Offset = "0x0")]
			public readonly string Id;

			[Token(Token = "0x40008A2")]
			[FieldOffset(Offset = "0x8")]
			public readonly string Text;

			[Token(Token = "0x600052A")]
			[Address(RVA = "0x3F71278", Offset = "0x3F6D278", VA = "0x3F71278")]
			public BubbleTextInfo(string id, string text)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BubbleTextConstants.BubbleTextInfo..ctor RVA=0x3F71278 Token=0x600052A");
}
		}

		[Token(Token = "0x40008A0")]
		public const int EquippedBubbleCount = 4;

		[Token(Token = "0x1700004A")]
		public static List<BubbleTextInfo> AllBubbles
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x3F70A4C", Offset = "0x3F6CA4C", VA = "0x3F70A4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x3F70A50", Offset = "0x3F6CA50", VA = "0x3F70A50")]
		private static List<BubbleTextInfo> GetAllBubbles()
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x3F70D7C", Offset = "0x3F6CD7C", VA = "0x3F70D7C")]
		public static List<string> GetAllBubbleIds()
		{
			return null;
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x3F70E9C", Offset = "0x3F6CE9C", VA = "0x3F70E9C")]
		public static List<string> GetDefaultUseBubbleIds()
		{
			return null;
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x3F70FDC", Offset = "0x3F6CFDC", VA = "0x3F70FDC")]
		public static BubbleTextInfo? GetBubbleInfo(string bubbleId)
		{
			return null;
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x3F710F0", Offset = "0x3F6D0F0", VA = "0x3F710F0")]
		public static string GetText(string bubbleId)
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x3F71178", Offset = "0x3F6D178", VA = "0x3F71178")]
		public static string GetEquippedText(PlayerBubbleData bubbleData, int index)
		{
			return null;
		}
	}
}
