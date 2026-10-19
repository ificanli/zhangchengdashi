using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000537")]
	public class MysteryAdventureRollResult
	{
		[Token(Token = "0x4002EBE")]
		[FieldOffset(Offset = "0x10")]
		public bool Success;

		[Token(Token = "0x4002EBF")]
		[FieldOffset(Offset = "0x18")]
		public string ErrorMessage;

		[Token(Token = "0x4002EC0")]
		[FieldOffset(Offset = "0x20")]
		public int DiceValue;

		[Token(Token = "0x4002EC1")]
		[FieldOffset(Offset = "0x24")]
		public int FromCellId;

		[Token(Token = "0x4002EC2")]
		[FieldOffset(Offset = "0x28")]
		public int ToCellId;

		[Token(Token = "0x4002EC3")]
		[FieldOffset(Offset = "0x30")]
		public List<int> PathCellIds;

		[Token(Token = "0x4002EC4")]
		[FieldOffset(Offset = "0x38")]
		public List<MysteryAdventureMoveSegment> MoveSegments;

		[Token(Token = "0x4002EC5")]
		[FieldOffset(Offset = "0x40")]
		public List<string> ForceMoveHints;

		[Token(Token = "0x4002EC6")]
		[FieldOffset(Offset = "0x48")]
		public List<string> RewardStrings;

		[Token(Token = "0x4002EC7")]
		[FieldOffset(Offset = "0x50")]
		public int LapRewardCount;

		[Token(Token = "0x4002EC8")]
		[FieldOffset(Offset = "0x54")]
		public int RollRewardMultiplier;

		[Token(Token = "0x4002EC9")]
		[FieldOffset(Offset = "0x58")]
		public int DiceCountAfter;

		[Token(Token = "0x4002ECA")]
		[FieldOffset(Offset = "0x60")]
		public string LapRewardConfigRaw;

		[Token(Token = "0x4002ECB")]
		[FieldOffset(Offset = "0x68")]
		public string StopRewardConfigRaw;

		[Token(Token = "0x4002ECC")]
		[FieldOffset(Offset = "0x70")]
		public int FinalStopBuildId;

		[Token(Token = "0x4002ECD")]
		[FieldOffset(Offset = "0x78")]
		public string RewardConfigRaw;

		[Token(Token = "0x4002ECE")]
		[FieldOffset(Offset = "0x80")]
		public bool HasPendingInteraction;

		[Token(Token = "0x4002ECF")]
		[FieldOffset(Offset = "0x88")]
		public string PendingInteractionMessage;

		[Token(Token = "0x4002ED0")]
		[FieldOffset(Offset = "0x90")]
		public bool BoardCellReported;

		[Token(Token = "0x6001B17")]
		[Address(RVA = "0x3EA8F1C", Offset = "0x3EA4F1C", VA = "0x3EA8F1C")]
		public MysteryAdventureRollResult()
		{
		}
	}
}
