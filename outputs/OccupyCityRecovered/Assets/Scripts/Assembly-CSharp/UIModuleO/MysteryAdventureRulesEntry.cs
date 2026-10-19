using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000A45")]
	public readonly struct MysteryAdventureRulesEntry
	{
		[Token(Token = "0x4004C14")]
		[FieldOffset(Offset = "0x0")]
		public readonly string Title;

		[Token(Token = "0x4004C15")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Description;

		[Token(Token = "0x4004C16")]
		[FieldOffset(Offset = "0x10")]
		public readonly int BuildId;

		[Token(Token = "0x4004C17")]
		[FieldOffset(Offset = "0x14")]
		public readonly int BuildIndex;

		[Token(Token = "0x4004C18")]
		[FieldOffset(Offset = "0x18")]
		public readonly int RuleIndex;

		[Token(Token = "0x17000948")]
		public bool HasContent
		{
			[Token(Token = "0x6003D67")]
			[Address(RVA = "0x415C9A4", Offset = "0x41589A4", VA = "0x415C9A4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6003D66")]
		[Address(RVA = "0x415C994", Offset = "0x4158994", VA = "0x415C994")]
		public MysteryAdventureRulesEntry(string title, string description, int buildId = 0, int buildIndex = 0, int ruleIndex = 0)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventureRulesEntry..ctor RVA=0x415C994 Token=0x6003D66");
}
	}
}
