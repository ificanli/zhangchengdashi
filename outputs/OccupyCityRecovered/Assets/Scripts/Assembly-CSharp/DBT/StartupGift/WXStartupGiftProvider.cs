using System;
using Il2CppDummyDll;

namespace DBT.StartupGift
{
	[Token(Token = "0x2000F71")]
	public class WXStartupGiftProvider : DBTStartupGiftProviderBase
	{
		[Token(Token = "0x4006A8B")]
		public const string ProviderKey = "WX";

		[Token(Token = "0x17000F8B")]
		public override string ProviderId
		{
			[Token(Token = "0x6005CA6")]
			[Address(RVA = "0x43B218C", Offset = "0x43AE18C", VA = "0x43B218C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F8C")]
		public override string DisplayName
		{
			[Token(Token = "0x6005CA7")]
			[Address(RVA = "0x43B21CC", Offset = "0x43AE1CC", VA = "0x43B21CC", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F8D")]
		public override bool IsAvailable
		{
			[Token(Token = "0x6005CA8")]
			[Address(RVA = "0x43B220C", Offset = "0x43AE20C", VA = "0x43B220C", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005CA9")]
		[Address(RVA = "0x43B2214", Offset = "0x43AE214", VA = "0x43B2214", Slot = "8")]
		protected override void ReceiveGift(Action<string> callback)
		{
		}

		[Token(Token = "0x6005CAA")]
		[Address(RVA = "0x43B22A4", Offset = "0x43AE2A4", VA = "0x43B22A4", Slot = "10")]
		protected override void OnReceiveSuccess(string rewardStr)
		{
		}

		[Token(Token = "0x6005CAB")]
		[Address(RVA = "0x43B22A8", Offset = "0x43AE2A8", VA = "0x43B22A8")]
		public WXStartupGiftProvider()
		{
		}
	}
}
