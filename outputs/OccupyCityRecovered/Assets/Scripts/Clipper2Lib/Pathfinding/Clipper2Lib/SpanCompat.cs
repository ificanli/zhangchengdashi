using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000039")]
	internal readonly struct SpanCompat<T> where T : unmanaged
	{
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x0")]
		internal unsafe readonly T* ptr;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x0")]
		internal readonly uint length;

		[Token(Token = "0x17000019")]
		public int Length
		{
			[Token(Token = "0x60001E2")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001A")]
		public unsafe ref T this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60001E4")]
			get
			{
				return ref *(T*)null;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60001E3")]
		public unsafe SpanCompat(void* ptr, int length)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SpanCompat..ctor RVA= Token=0x60001E3");
}
	}
}
