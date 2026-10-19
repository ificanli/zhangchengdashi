using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityAsyncAwaitUtil
{
	[Token(Token = "0x20002D5")]
	public static class SyncContextUtil
	{
		[Token(Token = "0x40017B9")]
		[FieldOffset(Offset = "0x0")]
		private static int TvªµGQ;

		[Token(Token = "0x40017BA")]
		[FieldOffset(Offset = "0x8")]
		private static SynchronizationContext A_0082RÂlm;

		[Token(Token = "0x17001097")]
		public static int UnityThreadId
		{
			[Token(Token = "0x6005158")]
			[Address(RVA = "0x711F380", Offset = "0x711B380", VA = "0x711F380")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6005159")]
			[Address(RVA = "0x711F3C8", Offset = "0x711B3C8", VA = "0x711F3C8")]
			private set
			{
				_0091_009CBXmr(value);
			}
		}

		[Token(Token = "0x17001098")]
		public static SynchronizationContext UnitySynchronizationContext
		{
			[Token(Token = "0x600515A")]
			[Address(RVA = "0x711F414", Offset = "0x711B414", VA = "0x711F414")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600515B")]
			[Address(RVA = "0x711F45C", Offset = "0x711B45C", VA = "0x711F45C")]
			private set
			{
				_007Fqr_0094_007CZ(value);
			}
		}

		[Token(Token = "0x6005157")]
		[Address(RVA = "0x711F2E4", Offset = "0x711B2E4", VA = "0x711F2E4")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Install()
		{
		}

		[Token(Token = "0x6005159")]
		[Address(RVA = "0x711F3C8", Offset = "0x711B3C8", VA = "0x711F3C8")]
		private static void _0091_009CBXmr(int _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x600515B")]
		[Address(RVA = "0x711F45C", Offset = "0x711B45C", VA = "0x711F45C")]
		private static void _007Fqr_0094_007CZ(SynchronizationContext _00A3_0092T_007E_00ABc)
		{
		}
	}
}
