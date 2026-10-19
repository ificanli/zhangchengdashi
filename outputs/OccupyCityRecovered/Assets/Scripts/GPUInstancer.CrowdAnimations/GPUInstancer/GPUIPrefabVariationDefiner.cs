using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000008")]
	public class GPUIPrefabVariationDefiner : MonoBehaviour
	{
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x20")]
		public GPUInstancerPrefabManager prefabManager;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x28")]
		public GPUInstancerPrefabPrototype prototype;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x30")]
		public readonly string textureBufferName;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x38")]
		public readonly string texturePropertyName;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x73BEB34", Offset = "0x73BAB34", VA = "0x73BEB34")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x73BEBC8", Offset = "0x73BABC8", VA = "0x73BEBC8")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x73BEC50", Offset = "0x73BAC50", VA = "0x73BEC50")]
		public GPUIPrefabVariationDefiner()
		{
		}
	}
}
