using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000042")]
	public class GPUInstancerRenderer
	{
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x18")]
		public List<Material> materials;

		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x20")]
		public Matrix4x4 transformOffset;

		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x60")]
		public int argsBufferOffset;

		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x68")]
		public MaterialPropertyBlock mpb;

		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x70")]
		public MaterialPropertyBlock shadowMPB;

		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x78")]
		public int layer;

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x7C")]
		public bool castShadows;

		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x7D")]
		public bool receiveShadows;

		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x80")]
		public Renderer rendererRef;

		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x88")]
		public string rendererRefName;

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x73DC324", Offset = "0x73D8324", VA = "0x73DC324")]
		public GPUInstancerRenderer()
		{
		}
	}
}
