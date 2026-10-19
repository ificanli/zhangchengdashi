using System.Collections.Generic;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E28")]
	public class CardTalentTreeData
	{
		[Token(Token = "0x40062B3")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, CardTalentNodeData> NodeTree;

		[Token(Token = "0x600572B")]
		[Address(RVA = "0x434D540", Offset = "0x4349540", VA = "0x434D540")]
		public CardTalentTreeData()
		{
		}
	}
}
