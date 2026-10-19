using Beebyte.Obfuscator;
using Il2CppDummyDll;
using RVO2;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

[Token(Token = "0x200002B")]
[BurstCompile]
[Skip]
public struct UpdateTreeJob : IJob
{
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe KdTree* kdTree;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x8")]
	public int length;

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x3D03A40", Offset = "0x3CFFA40", VA = "0x3D03A40", Slot = "4")]
	public void Execute()
	{
	}
}
