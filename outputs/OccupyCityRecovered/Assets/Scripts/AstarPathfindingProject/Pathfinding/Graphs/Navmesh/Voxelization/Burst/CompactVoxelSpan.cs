using Il2CppDummyDll;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001DF")]
	public struct CompactVoxelSpan
	{
		[Token(Token = "0x40008D1")]
		[FieldOffset(Offset = "0x0")]
		public ushort y;

		[Token(Token = "0x40008D2")]
		[FieldOffset(Offset = "0x4")]
		public uint con;

		[Token(Token = "0x40008D3")]
		[FieldOffset(Offset = "0x8")]
		public uint h;

		[Token(Token = "0x40008D4")]
		[FieldOffset(Offset = "0xC")]
		public int reg;

		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x45A42D0", Offset = "0x45A02D0", VA = "0x45A42D0")]
		public CompactVoxelSpan(ushort bottom, uint height)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CompactVoxelSpan..ctor RVA=0x45A42D0 Token=0x6000D33");
}

		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x45A42E4", Offset = "0x45A02E4", VA = "0x45A42E4")]
		public void SetConnection(int dir, uint value)
		{
		}

		[Token(Token = "0x6000D35")]
		[Address(RVA = "0x45A4310", Offset = "0x45A0310", VA = "0x45A4310")]
		public int GetConnection(int dir)
		{
			return default;
		}
	}
}
