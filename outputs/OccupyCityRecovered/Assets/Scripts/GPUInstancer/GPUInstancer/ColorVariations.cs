using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200000E")]
	public class ColorVariations : MonoBehaviour
	{
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x20")]
		public GPUInstancerPrefab prefab;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x28")]
		public GPUInstancerPrefabManager prefabManager;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x30")]
		public int instances;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x38")]
		public string bufferName;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x40")]
		private List<GPUInstancerPrefab> goList;

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x73B0668", Offset = "0x73AC668", VA = "0x73B0668")]
		private void Start()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x73B09D4", Offset = "0x73AC9D4", VA = "0x73B09D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x73B0A8C", Offset = "0x73ACA8C", VA = "0x73B0A8C")]
		public ColorVariations()
		{
		}
	}
}
