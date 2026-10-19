using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x200005A")]
	[BurstCompile]
	internal struct StreamSplitter : IJob
	{
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<UnsafeAppendBuffer> inputBuffers;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x10")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeAppendBuffer* staticBuffer;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x18")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeAppendBuffer* dynamicBuffer;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x20")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeAppendBuffer* persistentBuffer;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int PushCommands;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x4")]
		internal static readonly int PopCommands;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int MetaCommands;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0xC")]
		internal static readonly int DynamicCommands;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly int StaticCommands;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly int[] CommandSizes;

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x46F069C", Offset = "0x46EC69C", VA = "0x46F069C")]
		static StreamSplitter()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x46F0910", Offset = "0x46EC910", VA = "0x46F0910", Slot = "4")]
		public void Execute()
		{
		}
	}
}
