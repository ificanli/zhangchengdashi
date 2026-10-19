using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000076")]
	[ExecuteInEditMode]
	public class GPUInstancerTerrainProxy : MonoBehaviour
	{
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x20")]
		public GPUInstancerDetailManager detailManager;

		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x28")]
		public GPUInstancerTreeManager treeManager;

		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x30")]
		public bool beingDestroyed;

		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x34")]
		public int terrainSelectedToolIndex;

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x7409CAC", Offset = "0x7405CAC", VA = "0x7409CAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x7409CB8", Offset = "0x7405CB8", VA = "0x7409CB8")]
		public GPUInstancerTerrainProxy()
		{
		}
	}
}
