using Il2CppDummyDll;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001E2")]
	public struct LinkedVoxelSpan
	{
		[Token(Token = "0x40008E3")]
		[FieldOffset(Offset = "0x0")]
		public uint bottom;

		[Token(Token = "0x40008E4")]
		[FieldOffset(Offset = "0x4")]
		public uint top;

		[Token(Token = "0x40008E5")]
		[FieldOffset(Offset = "0x8")]
		public int next;

		[Token(Token = "0x40008E6")]
		[FieldOffset(Offset = "0xC")]
		public int area;

		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x45A4EC0", Offset = "0x45A0EC0", VA = "0x45A4EC0")]
		public LinkedVoxelSpan(uint bottom, uint top, int area)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LinkedVoxelSpan..ctor RVA=0x45A4EC0 Token=0x6000D3F");
}

		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x45A465C", Offset = "0x45A065C", VA = "0x45A465C")]
		public LinkedVoxelSpan(uint bottom, uint top, int area, int next)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LinkedVoxelSpan..ctor RVA=0x45A465C Token=0x6000D40");
}
	}
}
