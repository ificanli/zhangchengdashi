using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200006E")]
	public class GPUInstancerPrefabListRuntimeHandler : MonoBehaviour
	{
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x20")]
		public GPUInstancerPrefabManager prefabManager;

		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x28")]
		private IEnumerable<GPUInstancerPrefab> _gpuiPrefabs;

		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x30")]
		private bool _isIntancesAdded;

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x74006E8", Offset = "0x73FC6E8", VA = "0x74006E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x74008FC", Offset = "0x73FC8FC", VA = "0x74008FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x74009B8", Offset = "0x73FC9B8", VA = "0x74009B8")]
		public void SetManager(GPUInstancerPrefabManager prefabManager)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x7400A08", Offset = "0x73FCA08", VA = "0x7400A08")]
		public GPUInstancerPrefabListRuntimeHandler()
		{
		}
	}
}
