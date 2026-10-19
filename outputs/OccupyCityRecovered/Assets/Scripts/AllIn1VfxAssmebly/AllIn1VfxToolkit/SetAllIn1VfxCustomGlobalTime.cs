using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit
{
	[Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	public class SetAllIn1VfxCustomGlobalTime : MonoBehaviour
	{
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x20")]
		private int globalTime;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x24")]
		private Vector4 timeVector;

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x3CEEB38", Offset = "0x3CEAB38", VA = "0x3CEEB38")]
		private void Start()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x3CEEB88", Offset = "0x3CEAB88", VA = "0x3CEEB88")]
		private void Update()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x3CEEBF0", Offset = "0x3CEABF0", VA = "0x3CEEBF0")]
		public SetAllIn1VfxCustomGlobalTime()
		{
		}
	}
}
