using Il2CppDummyDll;

namespace GPUInstancer
{
	[Token(Token = "0x2000052")]
	public class GPUInstancerTreePrototype : GPUInstancerPrototype
	{
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x88")]
		public int prototypeIndex;

		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x8C")]
		public bool isApplyRotation;

		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x8D")]
		public bool isApplyPrefabScale;

		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x8E")]
		public bool isApplyTerrainHeight;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x73E1DD8", Offset = "0x73DDDD8", VA = "0x73E1DD8")]
		public GPUInstancerTreePrototype()
		{
		}
	}
}
