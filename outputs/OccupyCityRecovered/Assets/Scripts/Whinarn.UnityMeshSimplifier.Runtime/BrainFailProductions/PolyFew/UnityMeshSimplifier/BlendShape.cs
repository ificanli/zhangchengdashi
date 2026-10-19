using System;
using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Serializable]
	[Token(Token = "0x2000006")]
	public struct BlendShape
	{
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x0")]
		public string ShapeName;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x8")]
		public BlendShapeFrame[] Frames;

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x854F0B0", Offset = "0x854B0B0", VA = "0x854F0B0")]
		public BlendShape(string shapeName, BlendShapeFrame[] frames)
		{
			// Recovered from ARM64 RVA 0x854F0B0 (two reference stores).
			ShapeName = shapeName;
			Frames = frames;
		}
	}
}
