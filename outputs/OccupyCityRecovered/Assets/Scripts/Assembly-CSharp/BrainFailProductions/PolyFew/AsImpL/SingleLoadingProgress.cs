using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew.AsImpL
{
	[Token(Token = "0x2000D06")]
	public class SingleLoadingProgress
	{
		[Token(Token = "0x4005D33")]
		[FieldOffset(Offset = "0x10")]
		public string fileName;

		[Token(Token = "0x4005D34")]
		[FieldOffset(Offset = "0x18")]
		public string message;

		[Token(Token = "0x4005D35")]
		[FieldOffset(Offset = "0x20")]
		public float percentage;

		[Token(Token = "0x4005D36")]
		[FieldOffset(Offset = "0x24")]
		public int numObjects;

		[Token(Token = "0x4005D37")]
		[FieldOffset(Offset = "0x28")]
		public int numSubObjects;

		[Token(Token = "0x4005D38")]
		[FieldOffset(Offset = "0x2C")]
		public bool error;

		[Token(Token = "0x600511C")]
		[Address(RVA = "0x42D872C", Offset = "0x42D472C", VA = "0x42D872C")]
		public SingleLoadingProgress()
		{
		}
	}
}
