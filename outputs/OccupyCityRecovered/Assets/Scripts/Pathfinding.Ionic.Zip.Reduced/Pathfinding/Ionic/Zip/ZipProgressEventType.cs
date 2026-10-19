using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000008")]
	public enum ZipProgressEventType
	{
		[Token(Token = "0x4000006")]
		Adding_Started = 0,
		[Token(Token = "0x4000007")]
		Adding_AfterAddEntry = 1,
		[Token(Token = "0x4000008")]
		Adding_Completed = 2,
		[Token(Token = "0x4000009")]
		Reading_Started = 3,
		[Token(Token = "0x400000A")]
		Reading_BeforeReadEntry = 4,
		[Token(Token = "0x400000B")]
		Reading_AfterReadEntry = 5,
		[Token(Token = "0x400000C")]
		Reading_Completed = 6,
		[Token(Token = "0x400000D")]
		Reading_ArchiveBytesRead = 7,
		[Token(Token = "0x400000E")]
		Saving_Started = 8,
		[Token(Token = "0x400000F")]
		Saving_BeforeWriteEntry = 9,
		[Token(Token = "0x4000010")]
		Saving_AfterWriteEntry = 10,
		[Token(Token = "0x4000011")]
		Saving_Completed = 11,
		[Token(Token = "0x4000012")]
		Saving_AfterSaveTempArchive = 12,
		[Token(Token = "0x4000013")]
		Saving_BeforeRenameTempArchive = 13,
		[Token(Token = "0x4000014")]
		Saving_AfterRenameTempArchive = 14,
		[Token(Token = "0x4000015")]
		Saving_AfterCompileSelfExtractor = 15,
		[Token(Token = "0x4000016")]
		Saving_EntryBytesRead = 16,
		[Token(Token = "0x4000017")]
		Extracting_BeforeExtractEntry = 17,
		[Token(Token = "0x4000018")]
		Extracting_AfterExtractEntry = 18,
		[Token(Token = "0x4000019")]
		Extracting_ExtractEntryWouldOverwrite = 19,
		[Token(Token = "0x400001A")]
		Extracting_EntryBytesWritten = 20,
		[Token(Token = "0x400001B")]
		Extracting_BeforeExtractAll = 21,
		[Token(Token = "0x400001C")]
		Extracting_AfterExtractAll = 22,
		[Token(Token = "0x400001D")]
		Error_Saving = 23
	}
}
