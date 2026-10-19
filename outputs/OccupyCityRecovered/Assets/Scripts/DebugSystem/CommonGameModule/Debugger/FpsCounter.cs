using Il2CppDummyDll;

namespace CommonGameModule.Debugger
{
	[Token(Token = "0x2000013")]
	public sealed class FpsCounter
	{
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x10")]
		private float m_UpdateInterval;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x14")]
		private float m_CurrentFps;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x18")]
		private int m_Frames;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x1C")]
		private float m_Accumulator;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x20")]
		private float m_TimeLeft;

		[Token(Token = "0x17000013")]
		public float UpdateInterval
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x463617C", Offset = "0x463217C", VA = "0x463617C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x4636184", Offset = "0x4632184", VA = "0x4636184")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public float CurrentFps
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x4636284", Offset = "0x4632284", VA = "0x4636284")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x4631D5C", Offset = "0x462DD5C", VA = "0x4631D5C")]
		public FpsCounter(float updateInterval)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x463226C", Offset = "0x462E26C", VA = "0x463226C")]
		public void Update(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x4636170", Offset = "0x4632170", VA = "0x4636170")]
		private void Reset()
		{
		}
	}
}
