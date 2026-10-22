using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.ECS
{
	[Token(Token = "0x200030E")]
	public ref struct ComponentRef<T> where T : struct
	{
		[Token(Token = "0x4000DDC")]
		[FieldOffset(Offset = "0x0")]
		private unsafe byte* ptr;

		[Token(Token = "0x17000318")]
		public unsafe ref T value
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60012F7")]
			get
			{ return ref Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AsRef<T>(ptr); }
		}

		[Token(Token = "0x60012F6")]
		public unsafe ComponentRef(byte* ptr)
		{ this.ptr = ptr; }
	}
}
