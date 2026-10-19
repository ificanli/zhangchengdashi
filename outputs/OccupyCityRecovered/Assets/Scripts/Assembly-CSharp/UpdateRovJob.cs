using Beebyte.Obfuscator;
using Il2CppDummyDll;
using RVO2;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

[Token(Token = "0x200002A")]
[BurstCompile]
[Skip]
public struct UpdateRovJob : IJobParallelFor
{
	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe UnsafeList<Agent>* agents_;

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x3D039BC", Offset = "0x3CFF9BC", VA = "0x3D039BC", Slot = "4")]
	public void Execute(int index)
	{
	}
}
