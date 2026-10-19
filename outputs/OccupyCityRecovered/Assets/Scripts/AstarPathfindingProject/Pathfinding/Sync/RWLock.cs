using System;
using Il2CppDummyDll;
using Unity.Jobs;

namespace Pathfinding.Sync
{
	[Token(Token = "0x200023C")]
	public class RWLock
	{
		[Token(Token = "0x200023D")]
		public readonly struct CombinedReadLockAsync
		{
			[Token(Token = "0x4000AAB")]
			[FieldOffset(Offset = "0x0")]
			private readonly RWLock lock1;

			[Token(Token = "0x4000AAC")]
			[FieldOffset(Offset = "0x8")]
			private readonly RWLock lock2;

			[Token(Token = "0x4000AAD")]
			[FieldOffset(Offset = "0x10")]
			public readonly JobHandle dependency;

			[Token(Token = "0x6000E45")]
			[Address(RVA = "0x447D9B8", Offset = "0x44799B8", VA = "0x447D9B8")]
			public CombinedReadLockAsync(ReadLockAsync lock1, ReadLockAsync lock2)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RWLock.CombinedReadLockAsync..ctor RVA=0x447D9B8 Token=0x6000E45");
}

			[Token(Token = "0x6000E46")]
			[Address(RVA = "0x447D9F0", Offset = "0x44799F0", VA = "0x447D9F0")]
			public void UnlockAfter(JobHandle handle)
			{
			}

			[Token(Token = "0x6000E47")]
			[Address(RVA = "0x447DA58", Offset = "0x4479A58", VA = "0x447DA58")]
			public void Unlock()
			{
			}
		}

		[Token(Token = "0x200023E")]
		public readonly struct ReadLockAsync
		{
			[Token(Token = "0x4000AAE")]
			[FieldOffset(Offset = "0x0")]
			internal readonly RWLock inner;

			[Token(Token = "0x4000AAF")]
			[FieldOffset(Offset = "0x8")]
			public readonly JobHandle dependency;

			[Token(Token = "0x6000E48")]
			[Address(RVA = "0x447D930", Offset = "0x4479930", VA = "0x447D930")]
			public ReadLockAsync(RWLock inner, JobHandle dependency)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RWLock.ReadLockAsync..ctor RVA=0x447D930 Token=0x6000E48");
}

			[Token(Token = "0x6000E49")]
			[Address(RVA = "0x447DA5C", Offset = "0x4479A5C", VA = "0x447DA5C")]
			public void UnlockAfter(JobHandle handle)
			{
			}
		}

		[Token(Token = "0x200023F")]
		public readonly struct WriteLockAsync
		{
			[Token(Token = "0x4000AB0")]
			[FieldOffset(Offset = "0x0")]
			private readonly RWLock inner;

			[Token(Token = "0x4000AB1")]
			[FieldOffset(Offset = "0x8")]
			public readonly JobHandle dependency;

			[Token(Token = "0x6000E4A")]
			[Address(RVA = "0x447D9A4", Offset = "0x44799A4", VA = "0x447D9A4")]
			public WriteLockAsync(RWLock inner, JobHandle dependency)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RWLock.WriteLockAsync..ctor RVA=0x447D9A4 Token=0x6000E4A");
}

			[Token(Token = "0x6000E4B")]
			[Address(RVA = "0x447DA88", Offset = "0x4479A88", VA = "0x447DA88")]
			public void UnlockAfter(JobHandle handle)
			{
			}
		}

		[Token(Token = "0x2000240")]
		public readonly struct LockSync : IDisposable
		{
			[Token(Token = "0x4000AB2")]
			[FieldOffset(Offset = "0x0")]
			private readonly RWLock inner;

			[Token(Token = "0x6000E4C")]
			[Address(RVA = "0x447DA98", Offset = "0x4479A98", VA = "0x447DA98")]
			public LockSync(RWLock inner)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RWLock.LockSync..ctor RVA=0x447DA98 Token=0x6000E4C");
}

			[Token(Token = "0x6000E4D")]
			[Address(RVA = "0x447DAA0", Offset = "0x4479AA0", VA = "0x447DAA0")]
			public void Unlock()
			{
			}

			[Token(Token = "0x6000E4E")]
			[Address(RVA = "0x447DAA4", Offset = "0x4479AA4", VA = "0x447DAA4", Slot = "4")]
void System.IDisposable.Dispose()
			{
			}
		}

		[Token(Token = "0x4000AA9")]
		[FieldOffset(Offset = "0x10")]
		private JobHandle lastWrite;

		[Token(Token = "0x4000AAA")]
		[FieldOffset(Offset = "0x20")]
		private JobHandle lastRead;

		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x447D8EC", Offset = "0x44798EC", VA = "0x447D8EC")]
		private void AddPendingSync()
		{
		}

		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0x447D8F0", Offset = "0x44798F0", VA = "0x447D8F0")]
		private void RemovePendingSync()
		{
		}

		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0x447D8F4", Offset = "0x44798F4", VA = "0x447D8F4")]
		private void AddPendingAsync()
		{
		}

		[Token(Token = "0x6000E3F")]
		[Address(RVA = "0x447D8F8", Offset = "0x44798F8", VA = "0x447D8F8")]
		private void RemovePendingAsync()
		{
		}

		[Token(Token = "0x6000E40")]
		[Address(RVA = "0x447D8FC", Offset = "0x44798FC", VA = "0x447D8FC")]
		public LockSync ReadSync()
		{
			return default;
		}

		[Token(Token = "0x6000E41")]
		[Address(RVA = "0x447D920", Offset = "0x4479920", VA = "0x447D920")]
		public ReadLockAsync Read()
		{
			return default;
		}

		[Token(Token = "0x6000E42")]
		[Address(RVA = "0x447D93C", Offset = "0x447993C", VA = "0x447D93C")]
		public LockSync WriteSync()
		{
			return default;
		}

		[Token(Token = "0x6000E43")]
		[Address(RVA = "0x447D96C", Offset = "0x447996C", VA = "0x447D96C")]
		public WriteLockAsync Write()
		{
			return default;
		}

		[Token(Token = "0x6000E44")]
		[Address(RVA = "0x447D9B0", Offset = "0x44799B0", VA = "0x447D9B0")]
		public RWLock()
		{
		}
	}
}
