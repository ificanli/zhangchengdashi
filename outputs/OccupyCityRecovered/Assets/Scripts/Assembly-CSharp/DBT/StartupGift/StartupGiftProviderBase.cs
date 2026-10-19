using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace DBT.StartupGift
{
	[Token(Token = "0x2000F75")]
	public abstract class StartupGiftProviderBase
	{
		[Token(Token = "0x17000F8E")]
		public abstract string ProviderId
		{
			[Token(Token = "0x6005CB6")]
			get;
		}

		[Token(Token = "0x17000F8F")]
		public abstract string DisplayName
		{
			[Token(Token = "0x6005CB7")]
			get;
		}

		[Token(Token = "0x17000F90")]
		public abstract bool IsAvailable
		{
			[Token(Token = "0x6005CB8")]
			get;
		}

		[Token(Token = "0x6005CB9")]
		[Address(RVA = "0x43B28E0", Offset = "0x43AE8E0", VA = "0x43B28E0")]
		public void CheckAndGrant([Optional] Action<string> callback)
		{
		}

		[Token(Token = "0x6005CBA")]
		[Address(RVA = "0x43B2BC4", Offset = "0x43AEBC4", VA = "0x43B2BC4", Slot = "7")]
		protected virtual bool CanRequest()
		{
			return default;
		}

		[Token(Token = "0x6005CBB")]
		protected abstract void ReceiveGift(Action<string> callback);

		[Token(Token = "0x6005CBC")]
		[Address(RVA = "0x43B2BCC", Offset = "0x43AEBCC", VA = "0x43B2BCC", Slot = "9")]
		protected virtual void GrantReward(string rewardStr)
		{
		}

		[Token(Token = "0x6005CBD")]
		[Address(RVA = "0x43B2070", Offset = "0x43AE070", VA = "0x43B2070", Slot = "10")]
		protected virtual void OnReceiveSuccess(string rewardStr)
		{
		}

		[Token(Token = "0x6005CBE")]
		[Address(RVA = "0x43B1FD0", Offset = "0x43ADFD0", VA = "0x43B1FD0")]
		protected StartupGiftProviderBase()
		{
		}
	}
}
