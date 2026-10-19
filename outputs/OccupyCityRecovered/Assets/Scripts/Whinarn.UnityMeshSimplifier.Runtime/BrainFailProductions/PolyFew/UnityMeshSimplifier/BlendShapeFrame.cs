using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Serializable]
	[Token(Token = "0x2000007")]
	public struct BlendShapeFrame
	{
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		public string shapeName;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x8")]
		public float frameWeight;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		public Vector3[] deltaVertices;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x18")]
		public Vector3[] deltaNormals;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x20")]
		public Vector3[] deltaTangents;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x28")]
		public int vertexOffset;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x854F0B8", Offset = "0x854B0B8", VA = "0x854F0B8")]
		public BlendShapeFrame(float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents)
		{
			// RVA 0x854F0B8: the metadata literal is String.Empty; offset defaults to -1.
			shapeName = string.Empty;
			this.frameWeight = frameWeight;
			this.deltaVertices = deltaVertices;
			this.deltaNormals = deltaNormals;
			this.deltaTangents = deltaTangents;
			vertexOffset = -1;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x854F13C", Offset = "0x854B13C", VA = "0x854F13C")]
		public BlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents, int vertexOffset)
		{
			// Recovered from ARM64 RVA 0x854F13C.
			this.shapeName = shapeName;
			this.frameWeight = frameWeight;
			this.deltaVertices = deltaVertices;
			this.deltaNormals = deltaNormals;
			this.deltaTangents = deltaTangents;
			this.vertexOffset = vertexOffset;
		}
	}
}
