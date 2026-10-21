using GameModule;
using Il2CppDummyDll;
using UnityEngine;

namespace DataModule
{
	[Token(Token = "0x2000E7D")]
	public class TrainingHexConfig
	{
		[Token(Token = "0x4006506")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x4006507")]
		[FieldOffset(Offset = "0x1C")]
		public HexType hexType;

		[Token(Token = "0x4006508")]
		[FieldOffset(Offset = "0x20")]
		public Quality quality;

		[Token(Token = "0x4006509")]
		[FieldOffset(Offset = "0x28")]
		public string fixedCardId;

		[Token(Token = "0x400650A")]
		[FieldOffset(Offset = "0x30")]
		public string endTriggerEventId;

		[Token(Token = "0x60058A3")]
		[Address(RVA = "0x43647E0", Offset = "0x43607E0", VA = "0x43647E0")]
		public TrainingHexConfig(Vector3 pos, HexType type, Quality qual, string cardId, string endTriggerEventId)
		{
            position = pos;
            hexType = type;
            quality = qual;
            fixedCardId = cardId;
            this.endTriggerEventId = endTriggerEventId;
		}
	}
}
