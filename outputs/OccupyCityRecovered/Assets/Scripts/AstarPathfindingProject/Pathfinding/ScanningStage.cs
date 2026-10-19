using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x200002B")]
	public enum ScanningStage
	{
		[Token(Token = "0x4000155")]
		PreProcessingGraphs = 0,
		[Token(Token = "0x4000156")]
		PreProcessingGraph = 1,
		[Token(Token = "0x4000157")]
		ScanningGraph = 2,
		[Token(Token = "0x4000158")]
		PostProcessingGraph = 3,
		[Token(Token = "0x4000159")]
		FinishingScans = 4
	}
}
