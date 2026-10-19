using Il2CppDummyDll;

namespace SuperScrollView
{
	[Token(Token = "0x2000C77")]
	public class StaggeredGridViewInitParam
	{
		[Token(Token = "0x4005986")]
		[FieldOffset(Offset = "0x10")]
		public float mDistanceForRecycle0;

		[Token(Token = "0x4005987")]
		[FieldOffset(Offset = "0x14")]
		public float mDistanceForNew0;

		[Token(Token = "0x4005988")]
		[FieldOffset(Offset = "0x18")]
		public float mDistanceForRecycle1;

		[Token(Token = "0x4005989")]
		[FieldOffset(Offset = "0x1C")]
		public float mDistanceForNew1;

		[Token(Token = "0x400598A")]
		[FieldOffset(Offset = "0x20")]
		public float mItemDefaultWithPaddingSize;

		[Token(Token = "0x6004DCA")]
		[Address(RVA = "0x429D3D0", Offset = "0x42993D0", VA = "0x429D3D0")]
		public static StaggeredGridViewInitParam CopyDefaultInitParam()
		{
			return null;
		}

		[Token(Token = "0x6004DCB")]
		[Address(RVA = "0x429D438", Offset = "0x4299438", VA = "0x429D438")]
		public StaggeredGridViewInitParam()
		{
		}
	}
}
