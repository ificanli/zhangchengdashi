using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001EE")]
	public sealed class FpsCounter
	{
		[Token(Token = "0x40006C2")]
		[FieldOffset(Offset = "0x10")]
		private float m_UpdateInterval;

		[Token(Token = "0x40006C3")]
		[FieldOffset(Offset = "0x14")]
		private float m_CurrentFps;

		[Token(Token = "0x40006C4")]
		[FieldOffset(Offset = "0x18")]
		private int m_Frames;

		[Token(Token = "0x40006C5")]
		[FieldOffset(Offset = "0x1C")]
		private float m_Accumulator;

		[Token(Token = "0x40006C6")]
		[FieldOffset(Offset = "0x20")]
		private float m_TimeLeft;

		[Token(Token = "0x17000107")]
		public float UpdateInterval
		{
			[Token(Token = "0x60019CC")]
			[Address(RVA = "0x70B8218", Offset = "0x70B4218", VA = "0x70B8218")]
			get
			{
				return default;
			}
			[Token(Token = "0x60019CD")]
			[Address(RVA = "0x70B8220", Offset = "0x70B4220", VA = "0x70B8220")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public float CurrentFps
		{
			[Token(Token = "0x60019CE")]
			[Address(RVA = "0x70B8320", Offset = "0x70B4320", VA = "0x70B8320")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60019CB")]
		[Address(RVA = "0x70A8698", Offset = "0x70A4698", VA = "0x70A8698")]
		public FpsCounter(float updateInterval)
		{
		}

		[Token(Token = "0x60019CF")]
		[Address(RVA = "0x70B0A10", Offset = "0x70ACA10", VA = "0x70B0A10")]
		public void Update(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x60019D0")]
		[Address(RVA = "0x70B820C", Offset = "0x70B420C", VA = "0x70B820C")]
		private void Reset()
		{
		}
	}
}
