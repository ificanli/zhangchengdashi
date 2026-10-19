using System.Collections.Generic;
using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew.AsImpL
{
	[Token(Token = "0x2000D07")]
	public class LoadingProgress
	{
		[Token(Token = "0x4005D39")]
		[FieldOffset(Offset = "0x10")]
		public List<SingleLoadingProgress> singleProgress;

		[Token(Token = "0x600511D")]
		[Address(RVA = "0x42D8734", Offset = "0x42D4734", VA = "0x42D8734")]
		public LoadingProgress()
		{
		}
	}
}
