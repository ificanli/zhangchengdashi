using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x2000037")]
	public class GPUICrowdPrefabDebugger : MonoBehaviour
	{
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public GPUICrowdPrototype crowdPrototype;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public List<Material> testMaterials;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public float frameIndex;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x73D7320", Offset = "0x73D3320", VA = "0x73D7320")]
		public void OnFrameIndexChanged()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x73D74C0", Offset = "0x73D34C0", VA = "0x73D74C0")]
		public GPUICrowdPrefabDebugger()
		{
		}
	}
}
