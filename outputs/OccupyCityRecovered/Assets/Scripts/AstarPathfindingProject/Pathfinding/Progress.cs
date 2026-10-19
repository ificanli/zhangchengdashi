using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x200002C")]
	public readonly struct Progress
	{
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x0")]
		public readonly float progress;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x4")]
		internal readonly ScanningStage stage;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x8")]
		internal readonly int graphIndex;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0xC")]
		internal readonly int graphCount;

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x445D664", Offset = "0x4459664", VA = "0x445D664")]
		public Progress(float progress, ScanningStage stage, int graphIndex = 0, int graphCount = 0)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Progress..ctor RVA=0x445D664 Token=0x6000257");
}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x445D674", Offset = "0x4459674", VA = "0x445D674")]
		public Progress MapTo(float min, float max)
		{
			return default;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x445D6AC", Offset = "0x44596AC", VA = "0x445D6AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
