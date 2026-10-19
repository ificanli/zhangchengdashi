using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Util
{
	[Token(Token = "0x2000290")]
	public struct GraphSnapshot : IGraphSnapshot, IDisposable
	{
		[Token(Token = "0x4000BBE")]
		[FieldOffset(Offset = "0x0")]
		private List<IGraphSnapshot> inner;

		[Token(Token = "0x600102B")]
		[Address(RVA = "0x44909E4", Offset = "0x448C9E4", VA = "0x44909E4")]
		internal GraphSnapshot(List<IGraphSnapshot> inner)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GraphSnapshot..ctor RVA=0x44909E4 Token=0x600102B");
}

		[Token(Token = "0x600102C")]
		[Address(RVA = "0x44909EC", Offset = "0x448C9EC", VA = "0x44909EC", Slot = "4")]
		public void Restore(IGraphUpdateContext ctx)
		{
		}

		[Token(Token = "0x600102D")]
		[Address(RVA = "0x4490AF8", Offset = "0x448CAF8", VA = "0x4490AF8", Slot = "5")]
		public void Dispose()
		{
		}
	}
}
