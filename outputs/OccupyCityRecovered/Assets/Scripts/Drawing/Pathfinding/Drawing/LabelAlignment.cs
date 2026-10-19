using Il2CppDummyDll;
using Unity.Mathematics;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x2000008")]
	public struct LabelAlignment
	{
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x0")]
		public float2 relativePivot;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x8")]
		public float2 pixelOffset;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LabelAlignment TopLeft;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		public static readonly LabelAlignment MiddleLeft;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x20")]
		public static readonly LabelAlignment BottomLeft;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x30")]
		public static readonly LabelAlignment BottomCenter;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x40")]
		public static readonly LabelAlignment BottomRight;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x50")]
		public static readonly LabelAlignment MiddleRight;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x60")]
		public static readonly LabelAlignment TopRight;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x70")]
		public static readonly LabelAlignment TopCenter;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x80")]
		public static readonly LabelAlignment Center;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x46C6A1C", Offset = "0x46C2A1C", VA = "0x46C6A1C")]
		public LabelAlignment withPixelOffset(float x, float y)
		{
			return default;
		}
	}
}
