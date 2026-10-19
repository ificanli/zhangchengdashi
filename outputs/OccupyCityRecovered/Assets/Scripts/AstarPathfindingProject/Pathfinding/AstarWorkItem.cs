using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x2000095")]
	public struct AstarWorkItem
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action init;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Action<IWorkItemContext> initWithContext;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Func<bool, bool> update;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<IWorkItemContext, bool, bool> updateWithContext;

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x4508254", Offset = "0x4504254", VA = "0x4508254")]
		public AstarWorkItem(Func<bool, bool> update)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AstarWorkItem..ctor RVA=0x4508254 Token=0x60004EB");
}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x450CEAC", Offset = "0x4508EAC", VA = "0x450CEAC")]
		public AstarWorkItem(Func<IWorkItemContext, bool, bool> update)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AstarWorkItem..ctor RVA=0x450CEAC Token=0x60004EC");
}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x450CEB8", Offset = "0x4508EB8", VA = "0x450CEB8")]
		public AstarWorkItem(Action init, [Optional] Func<bool, bool> update)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AstarWorkItem..ctor RVA=0x450CEB8 Token=0x60004ED");
}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x450CEC4", Offset = "0x4508EC4", VA = "0x450CEC4")]
		public AstarWorkItem(Action<IWorkItemContext> init, [Optional] Func<IWorkItemContext, bool, bool> update)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AstarWorkItem..ctor RVA=0x450CEC4 Token=0x60004EE");
}
	}
}
