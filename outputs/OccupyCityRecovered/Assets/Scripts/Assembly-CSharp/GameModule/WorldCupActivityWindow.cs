using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20005F3")]
	public readonly struct WorldCupActivityWindow
	{
		[Token(Token = "0x170001B1")]
		public bool SwitchOn
		{
			[Token(Token = "0x6001FB3")]
			[Address(RVA = "0x3F0973C", Offset = "0x3F0573C", VA = "0x3F0973C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001B2")]
		public bool IsValid
		{
			[Token(Token = "0x6001FB4")]
			[Address(RVA = "0x3F09744", Offset = "0x3F05744", VA = "0x3F09744")]
			[CompilerGenerated]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001B3")]
		public DateTime OpenTime
		{
			[Token(Token = "0x6001FB5")]
			[Address(RVA = "0x3F0974C", Offset = "0x3F0574C", VA = "0x3F0974C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001B4")]
		public DateTime PlayEnd
		{
			[Token(Token = "0x6001FB6")]
			[Address(RVA = "0x3F09754", Offset = "0x3F05754", VA = "0x3F09754")]
			[CompilerGenerated]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001FB7")]
		[Address(RVA = "0x3F08F18", Offset = "0x3F04F18", VA = "0x3F08F18")]
		public bool IsPlayOpen(DateTime now)
		{
			return default;
		}

		[Token(Token = "0x6001FB8")]
		[Address(RVA = "0x3F0907C", Offset = "0x3F0507C", VA = "0x3F0907C")]
		public bool IsAnyOpen(DateTime now)
		{
			return default;
		}

		[Token(Token = "0x6001FB9")]
		[Address(RVA = "0x3F08E64", Offset = "0x3F04E64", VA = "0x3F08E64")]
		public WorldCupActivityPhase GetPhase(DateTime now)
		{
			return default;
		}

		[Token(Token = "0x6001FBA")]
		[Address(RVA = "0x3F0539C", Offset = "0x3F0139C", VA = "0x3F0539C")]
		public WorldCupActivityWindow(bool switchOn, bool isValid, DateTime openTime, DateTime playEnd)
		{
		}
	}
}
