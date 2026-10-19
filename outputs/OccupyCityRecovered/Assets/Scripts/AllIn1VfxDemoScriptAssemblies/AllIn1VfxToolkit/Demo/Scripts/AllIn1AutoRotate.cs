using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x200000A")]
	public class AllIn1AutoRotate : MonoBehaviour
	{
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float rotationSpeed;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 rotationAxis;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x3CEF300", Offset = "0x3CEB300", VA = "0x3CEF300")]
		private void Update()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x3CEF360", Offset = "0x3CEB360", VA = "0x3CEF360")]
		public AllIn1AutoRotate()
		{
		}
	}
}
