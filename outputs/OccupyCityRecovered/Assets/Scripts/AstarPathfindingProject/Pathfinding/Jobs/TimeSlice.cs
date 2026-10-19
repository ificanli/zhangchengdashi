using Il2CppDummyDll;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x2000193")]
	public struct TimeSlice
	{
		[Token(Token = "0x40007C6")]
		[FieldOffset(Offset = "0x0")]
		public long endTick;

		[Token(Token = "0x40007C7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TimeSlice Infinite;

		[Token(Token = "0x170001F7")]
		public bool isInfinite
		{
			[Token(Token = "0x6000BDE")]
			[Address(RVA = "0x45831E0", Offset = "0x457F1E0", VA = "0x45831E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001F8")]
		public bool expired
		{
			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0x45831F4", Offset = "0x457F1F4", VA = "0x45831F4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x45809AC", Offset = "0x457C9AC", VA = "0x45809AC")]
		public static TimeSlice MillisFromNow(float millis)
		{
			return default;
		}
	}
}
