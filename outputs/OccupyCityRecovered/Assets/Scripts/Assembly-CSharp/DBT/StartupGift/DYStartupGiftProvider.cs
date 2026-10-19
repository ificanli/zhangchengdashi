using System;
using Il2CppDummyDll;

namespace DBT.StartupGift
{
	[Token(Token = "0x2000F70")]
	public class DYStartupGiftProvider : DBTStartupGiftProviderBase
	{
		[Token(Token = "0x4006A89")]
		[FieldOffset(Offset = "0x10")]
		private string _launchGameCdkey;

		[Token(Token = "0x4006A8A")]
		public const string ProviderKey = "DY";

		[Token(Token = "0x17000F88")]
		public override string ProviderId
		{
			[Token(Token = "0x6005C9F")]
			[Address(RVA = "0x43B1FE0", Offset = "0x43ADFE0", VA = "0x43B1FE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F89")]
		public override string DisplayName
		{
			[Token(Token = "0x6005CA0")]
			[Address(RVA = "0x43B2020", Offset = "0x43AE020", VA = "0x43B2020", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F8A")]
		public override bool IsAvailable
		{
			[Token(Token = "0x6005CA1")]
			[Address(RVA = "0x43B2060", Offset = "0x43AE060", VA = "0x43B2060", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005CA2")]
		[Address(RVA = "0x43B2068", Offset = "0x43AE068", VA = "0x43B2068", Slot = "8")]
		protected override void ReceiveGift(Action<string> callback)
		{
		}

		[Token(Token = "0x6005CA3")]
		[Address(RVA = "0x43B206C", Offset = "0x43AE06C", VA = "0x43B206C", Slot = "10")]
		protected override void OnReceiveSuccess(string rewardStr)
		{
		}

		[Token(Token = "0x6005CA4")]
		[Address(RVA = "0x43B2138", Offset = "0x43AE138", VA = "0x43B2138")]
		private void TryGetLaunchCdk()
		{
		}

		[Token(Token = "0x6005CA5")]
		[Address(RVA = "0x43B213C", Offset = "0x43AE13C", VA = "0x43B213C")]
		public DYStartupGiftProvider()
		{
		}
	}
}
