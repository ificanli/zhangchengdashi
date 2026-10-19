using Il2CppDummyDll;
using Unity.Mathematics;

namespace Pathfinding.Drawing.Text
{
	[Token(Token = "0x200005B")]
	internal struct SDFCharacter
	{
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x0")]
		public char codePoint;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x4")]
		private float2 uvtopleft;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0xC")]
		private float2 uvbottomright;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x14")]
		private float2 vtopleft;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x1C")]
		private float2 vbottomright;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x24")]
		public float advance;

		[Token(Token = "0x1700001F")]
		public float2 uvTopLeft
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x46F0F08", Offset = "0x46ECF08", VA = "0x46F0F08")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000020")]
		public float2 uvTopRight
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x46EB43C", Offset = "0x46E743C", VA = "0x46EB43C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000021")]
		public float2 uvBottomLeft
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x46EB450", Offset = "0x46E7450", VA = "0x46EB450")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000022")]
		public float2 uvBottomRight
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x46F0F10", Offset = "0x46ECF10", VA = "0x46F0F10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000023")]
		public float2 vertexTopLeft
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x46F0F18", Offset = "0x46ECF18", VA = "0x46F0F18")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000024")]
		public float2 vertexTopRight
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x46EB434", Offset = "0x46E7434", VA = "0x46EB434")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000025")]
		public float2 vertexBottomLeft
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x46EB444", Offset = "0x46E7444", VA = "0x46EB444")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000026")]
		public float2 vertexBottomRight
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x46F0F20", Offset = "0x46ECF20", VA = "0x46F0F20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x46F0F28", Offset = "0x46ECF28", VA = "0x46F0F28")]
		public SDFCharacter(char codePoint, int x, int y, int width, int height, int originX, int originY, int advance, int textureWidth, int textureHeight, float defaultSize)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SDFCharacter..ctor RVA=0x46F0F28 Token=0x60002B0");
}
	}
}
