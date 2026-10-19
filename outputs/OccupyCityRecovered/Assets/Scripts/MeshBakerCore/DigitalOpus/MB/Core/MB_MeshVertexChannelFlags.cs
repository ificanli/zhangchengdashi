using System;
using Il2CppDummyDll;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200003C")]
	[Flags]
	public enum MB_MeshVertexChannelFlags
	{
		[Token(Token = "0x40000FB")]
		none = 0,
		[Token(Token = "0x40000FC")]
		vertex = 1,
		[Token(Token = "0x40000FD")]
		normal = 2,
		[Token(Token = "0x40000FE")]
		tangent = 4,
		[Token(Token = "0x40000FF")]
		colors = 8,
		[Token(Token = "0x4000100")]
		uv0 = 0x10,
		[Token(Token = "0x4000101")]
		nuvsSliceIdx = 0x20,
		[Token(Token = "0x4000102")]
		uv2 = 0x40,
		[Token(Token = "0x4000103")]
		uv3 = 0x80,
		[Token(Token = "0x4000104")]
		uv4 = 0x100,
		[Token(Token = "0x4000105")]
		uv5 = 0x200,
		[Token(Token = "0x4000106")]
		uv6 = 0x400,
		[Token(Token = "0x4000107")]
		uv7 = 0x800,
		[Token(Token = "0x4000108")]
		uv8 = 0x1000,
		[Token(Token = "0x4000109")]
		blendWeight = 0x2000,
		[Token(Token = "0x400010A")]
		blendIndices = 0x4000
	}
}
