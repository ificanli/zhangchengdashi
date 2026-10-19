using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;
using UnityEngine.U2D;

namespace GameFramework
{
	[Token(Token = "0x2000014")]
	public class SpriteAtlasList : MonoBehaviour
	{
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		[SerializeField]
		public SpriteAtlas[] AtlasList;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x706A268", Offset = "0x7066268", VA = "0x706A268")]
		public SpriteAtlasList()
		{
		}
	}
}
