using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x2000093")]
	public struct PathfindingTag
	{
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x0")]
		public uint value;

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x450C86C", Offset = "0x450886C", VA = "0x450C86C")]
		public PathfindingTag(uint value)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathfindingTag..ctor RVA=0x450C86C Token=0x60004DE");
}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x450C874", Offset = "0x4508874", VA = "0x450C874")]
		public static implicit operator uint(PathfindingTag tag)
		{
			return default;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x450C878", Offset = "0x4508878", VA = "0x450C878")]
		public static implicit operator PathfindingTag(uint tag)
		{
			return default;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x450C880", Offset = "0x4508880", VA = "0x450C880")]
		public static PathfindingTag FromName(string tagName)
		{
			return default;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x450CA28", Offset = "0x4508A28", VA = "0x450CA28")]
		public int ToMask()
		{
			return default;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x450CA38", Offset = "0x4508A38", VA = "0x450CA38", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
