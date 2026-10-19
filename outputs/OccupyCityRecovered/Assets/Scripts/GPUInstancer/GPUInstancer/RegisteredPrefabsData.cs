using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GPUInstancer
{
	[Serializable]
	[Token(Token = "0x2000072")]
	public class RegisteredPrefabsData
	{
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x10")]
		public GPUInstancerPrefabPrototype prefabPrototype;

		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x18")]
		public List<GPUInstancerPrefab> registeredPrefabs;

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x7409014", Offset = "0x7405014", VA = "0x7409014")]
		public RegisteredPrefabsData(GPUInstancerPrefabPrototype prefabPrototype)
		{
		}
	}
}
