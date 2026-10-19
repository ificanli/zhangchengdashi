using System;
using Il2CppDummyDll;
using Unity.Jobs;

namespace Pathfinding.Sync
{
	[Token(Token = "0x200023B")]
	public struct Promise<T> : IProgress, IDisposable where T : IProgress, IDisposable
	{
		[Token(Token = "0x4000AA7")]
		[FieldOffset(Offset = "0x0")]
		public JobHandle handle;

		[Token(Token = "0x4000AA8")]
		[FieldOffset(Offset = "0x0")]
		private T result;

		[Token(Token = "0x17000229")]
		public bool IsCompleted
		{
			[Token(Token = "0x6000E37")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700022A")]
		public float Progress
		{
			[Token(Token = "0x6000E38")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000E36")]
		public Promise(JobHandle handle, T result)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Promise..ctor RVA= Token=0x6000E36");
}

		[Token(Token = "0x6000E39")]
		public T GetValue()
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Promise.GetValue RVA= Token=0x6000E39");
}

		[Token(Token = "0x6000E3A")]
		public T Complete()
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Promise.Complete RVA= Token=0x6000E3A");
}

		[Token(Token = "0x6000E3B")]
		public void Dispose()
		{
		}
	}
}
