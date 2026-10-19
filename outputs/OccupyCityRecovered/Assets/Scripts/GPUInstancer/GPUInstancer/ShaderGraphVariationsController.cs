using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000019")]
	public class ShaderGraphVariationsController : MonoBehaviour
	{
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x20")]
		public GPUInstancerPrefab prefab;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x28")]
		public GPUInstancerPrefabManager prefabManager;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x30")]
		public int instances;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x38")]
		private string bufferName;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x40")]
		private List<GPUInstancerPrefab> goList;

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x73B40E0", Offset = "0x73B00E0", VA = "0x73B40E0")]
		private void Start()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x73B44A8", Offset = "0x73B04A8", VA = "0x73B44A8")]
		public ShaderGraphVariationsController()
		{
		}
	}
}
