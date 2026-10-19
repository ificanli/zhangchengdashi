using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20004DC")]
	public class TileEdgeBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4002C8E")]
		[FieldOffset(Offset = "0x20")]
		public GameObject redEdge;

		[Token(Token = "0x4002C8F")]
		[FieldOffset(Offset = "0x28")]
		public GameObject blueEdge;

		[Token(Token = "0x4002C90")]
		[FieldOffset(Offset = "0x30")]
		private string currentCamp;

		[Token(Token = "0x6001879")]
		[Address(RVA = "0x3E79FA0", Offset = "0x3E75FA0", VA = "0x3E79FA0")]
		public void ChangeColor(string tileCamp)
		{
		}

		[Token(Token = "0x600187A")]
		[Address(RVA = "0x3E7A080", Offset = "0x3E76080", VA = "0x3E7A080")]
		public TileEdgeBehaviour()
		{
		}
	}
}
