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
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ComponentRef.value.get RVA= Token=0x60012F7");
}
		}

		[Token(Token = "0x60012F6")]
		public unsafe ComponentRef(byte* ptr)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ComponentRef..ctor RVA= Token=0x60012F6");
}
	}
}
