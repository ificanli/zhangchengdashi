using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Serializable]
	[Token(Token = "0x2000013")]
	public struct SimplificationOptions
	{
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SimplificationOptions Default;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x0")]
		[Tooltip("If the border edges should be preserved.")]
		public bool PreserveBorderEdges;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x1")]
		[Tooltip("If the UV seam edges should be preserved.")]
		public bool PreserveUVSeamEdges;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x2")]
		[Tooltip("If the UV foldover edges should be preserved.")]
		public bool PreserveUVFoldoverEdges;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x3")]
		[Tooltip("If a feature for smarter vertex linking should be enabled, reducing artifacts at the cost of slower simplification.")]
		public bool EnableSmartLink;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x8")]
		[Tooltip("The maximum distance between two vertices in order to link them.")]
		public double VertexLinkDistance;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("The maximum squared distance between two vertices in order to link them.")]
		public int MaxIterationCount;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("The agressiveness of the mesh simplification. Higher number equals higher quality, but more expensive to run.")]
		public double Agressiveness;
	}
}
