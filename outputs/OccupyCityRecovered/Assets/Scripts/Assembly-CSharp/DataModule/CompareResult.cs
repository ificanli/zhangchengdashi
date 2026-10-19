using System.Collections.Generic;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E1B")]
	public class CompareResult
	{
		[Token(Token = "0x4006276")]
		[FieldOffset(Offset = "0x10")]
		public CompareAnalysis localAnalysis;

		[Token(Token = "0x4006277")]
		[FieldOffset(Offset = "0x18")]
		public CompareAnalysis serverAnalysis;

		[Token(Token = "0x4006278")]
		[FieldOffset(Offset = "0x20")]
		public List<CompareResultItem> resourcesResult;

		[Token(Token = "0x60056EF")]
		[Address(RVA = "0x4345088", Offset = "0x4341088", VA = "0x4345088")]
		public (bool, CompareResultItem) IsAllSame()
		{
			return default;
		}

		[Token(Token = "0x60056F0")]
		[Address(RVA = "0x4345420", Offset = "0x4341420", VA = "0x4345420")]
		public CompareResultType CompareCoreAssetsIsSame()
		{
			return default;
		}

		[Token(Token = "0x60056F1")]
		[Address(RVA = "0x4345CCC", Offset = "0x4341CCC", VA = "0x4345CCC")]
		public CompareResult(CompareData local, CompareData server)
		{
		}

		[Token(Token = "0x60056F2")]
		[Address(RVA = "0x4345DA4", Offset = "0x4341DA4", VA = "0x4345DA4")]
		public void Compare()
		{
		}

		[Token(Token = "0x60056F3")]
		[Address(RVA = "0x4346CAC", Offset = "0x4342CAC", VA = "0x4346CAC")]
		public CompareResultItem SetResourcesValue(int resourcesID, long localCount, long localGet, long localUse, long serverCount, long serverGet, long serverUse)
		{
			return null;
		}

		[Token(Token = "0x60056F4")]
		[Address(RVA = "0x4346F84", Offset = "0x4342F84", VA = "0x4346F84")]
		public void CompareCard()
		{
		}

		[Token(Token = "0x60056F5")]
		[Address(RVA = "0x4347C88", Offset = "0x4343C88", VA = "0x4347C88")]
		public void CompareArtifact()
		{
		}
	}
}
