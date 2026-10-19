using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace DBT.StartupGift
{
	[Token(Token = "0x2000F77")]
	public static class StartupGiftProviderRegistry
	{
		[Token(Token = "0x2000F78")]
		private class ProviderEntry
		{
			[Token(Token = "0x4006A93")]
			[FieldOffset(Offset = "0x10")]
			public string ProviderId;

			[Token(Token = "0x4006A94")]
			[FieldOffset(Offset = "0x18")]
			public Func<object> Factory;

			[Token(Token = "0x6005CC4")]
			[Address(RVA = "0x43B2F98", Offset = "0x43AEF98", VA = "0x43B2F98")]
			public ProviderEntry()
			{
			}
		}

		[Token(Token = "0x4006A92")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<ProviderEntry> ProviderEntries;

		[Token(Token = "0x6005CC1")]
		[Address(RVA = "0x43B2DB0", Offset = "0x43AEDB0", VA = "0x43B2DB0")]
		public static void Register(string providerId, Func<object> factory)
		{
		}

		[Token(Token = "0x6005CC2")]
		[Address(RVA = "0x43B25EC", Offset = "0x43AE5EC", VA = "0x43B25EC")]
		public static StartupGiftProviderBase CreateAvailableProvider()
		{
			return null;
		}
	}
}
