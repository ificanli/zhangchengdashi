using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000041")]
	public class GPUInstancerPrototypeLOD
	{
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x10")]
		public List<GPUInstancerRenderer> renderers;

		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x18")]
		public ComputeBuffer transformationMatrixAppendBuffer;

		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x20")]
		public ComputeBuffer shadowAppendBuffer;

		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x28")]
		public bool excludeBounds;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x30")]
		public RenderTexture transformationMatrixAppendTexture;

		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x38")]
		public RenderTexture shadowAppendTexture;

		[Token(Token = "0x17000016")]
		public int argsBufferOffset
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x73DE384", Offset = "0x73DA384", VA = "0x73DE384")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x73DBF30", Offset = "0x73D7F30", VA = "0x73DBF30")]
		public GPUInstancerPrototypeLOD()
		{
		}
	}
}
