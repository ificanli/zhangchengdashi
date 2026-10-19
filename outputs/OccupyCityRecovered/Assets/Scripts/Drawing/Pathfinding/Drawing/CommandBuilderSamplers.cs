using Il2CppDummyDll;
using Unity.Profiling;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x200000A")]
	internal static class CommandBuilderSamplers
	{
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly ProfilerMarker MarkerConvert;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly ProfilerMarker MarkerSetLayout;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly ProfilerMarker MarkerUpdateVertices;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly ProfilerMarker MarkerUpdateIndices;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly ProfilerMarker MarkerSubmesh;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly ProfilerMarker MarkerUpdateBuffer;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly ProfilerMarker MarkerProcessCommands;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x38")]
		internal static readonly ProfilerMarker MarkerCreateTriangles;
	}
}
