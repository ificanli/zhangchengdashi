using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000077")]
	public class GPUInstancerTerrainRuntimeHandler : MonoBehaviour
	{
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Terrain terrain;

		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x0")]
		private static GPUInstancerTreeManager _treeManager;

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x7409CC8", Offset = "0x7405CC8", VA = "0x7409CC8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x7409DA0", Offset = "0x7405DA0", VA = "0x7409DA0")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x7409EA0", Offset = "0x7405EA0", VA = "0x7409EA0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x7409F60", Offset = "0x7405F60", VA = "0x7409F60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x740A04C", Offset = "0x740604C", VA = "0x740A04C")]
		public GPUInstancerTerrainRuntimeHandler()
		{
		}
	}
}
