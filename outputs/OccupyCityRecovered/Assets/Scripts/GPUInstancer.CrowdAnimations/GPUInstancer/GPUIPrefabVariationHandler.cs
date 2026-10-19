using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000009")]
	[ExecuteInEditMode]
	public class GPUIPrefabVariationHandler : MonoBehaviour
	{
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x20")]
		public GPUIPrefabVariationDefiner variationDefiner;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Vector4 textureUV;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x73BECC0", Offset = "0x73BACC0", VA = "0x73BECC0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x73BEE70", Offset = "0x73BAE70", VA = "0x73BEE70")]
		public GPUIPrefabVariationHandler()
		{
		}
	}
}
