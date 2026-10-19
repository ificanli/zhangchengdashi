using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x2000014")]
	public class AllIn1VfxAutoDestroy : MonoBehaviour
	{
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float destroyTime;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x3CF0DCC", Offset = "0x3CECDCC", VA = "0x3CF0DCC")]
		private void Start()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x3CF0E48", Offset = "0x3CECE48", VA = "0x3CF0E48")]
		public AllIn1VfxAutoDestroy()
		{
		}
	}
}
