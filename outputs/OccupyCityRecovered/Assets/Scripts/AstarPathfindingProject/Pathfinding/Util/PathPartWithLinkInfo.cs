using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Util
{
	[Token(Token = "0x2000293")]
	public struct PathPartWithLinkInfo
	{
		[Token(Token = "0x4000BC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int startIndex;

		[Token(Token = "0x4000BC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int endIndex;

		[Token(Token = "0x4000BCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public OffMeshLinks.OffMeshLinkTracer linkInfo;

		[Token(Token = "0x1700026C")]
		public Funnel.PartType type
		{
			[Token(Token = "0x6001054")]
			[Address(RVA = "0x4493EB4", Offset = "0x448FEB4", VA = "0x4493EB4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001053")]
		[Address(RVA = "0x4493E98", Offset = "0x448FE98", VA = "0x4493E98")]
		public PathPartWithLinkInfo(int startIndex, int endIndex, [Optional] OffMeshLinks.OffMeshLinkTracer linkInfo)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathPartWithLinkInfo..ctor RVA=0x4493E98 Token=0x6001053");
}
	}
}
