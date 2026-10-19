using System.Collections.Generic;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E27")]
	public class CardTalentNodeData
	{
		[Token(Token = "0x40062AF")]
		[FieldOffset(Offset = "0x10")]
		public int TalentID;

		[Token(Token = "0x40062B0")]
		[FieldOffset(Offset = "0x14")]
		public bool IsUnlocked;

		[Token(Token = "0x40062B1")]
		[FieldOffset(Offset = "0x18")]
		public List<int> PrerequisiteIDs;

		[Token(Token = "0x40062B2")]
		[FieldOffset(Offset = "0x20")]
		public List<int> NextNodeIDs;

		[Token(Token = "0x6005726")]
		[Address(RVA = "0x434D144", Offset = "0x4349144", VA = "0x434D144")]
		public CardTalentNodeData()
		{
		}

		[Token(Token = "0x6005727")]
		[Address(RVA = "0x434D14C", Offset = "0x434914C", VA = "0x434D14C")]
		public CardTalentNodeData(bool inUnLock, string cardNodeCofig)
		{
		}

		[Token(Token = "0x6005728")]
		[Address(RVA = "0x434D4F8", Offset = "0x43494F8", VA = "0x434D4F8")]
		public CardTalentNodeData(bool inUnLock, int talentId)
		{
		}

		[Token(Token = "0x6005729")]
		[Address(RVA = "0x434D52C", Offset = "0x434952C", VA = "0x434D52C")]
		public void UnlockNode()
		{
		}

		[Token(Token = "0x600572A")]
		[Address(RVA = "0x434D538", Offset = "0x4349538", VA = "0x434D538")]
		public void LockNode()
		{
		}
	}
}
