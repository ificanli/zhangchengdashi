using System;
using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x2000201")]
	internal class Timer
	{
		[Token(Token = "0x4000748")]
		[FieldOffset(Offset = "0x10")]
		private float m_totalTime;

		[Token(Token = "0x4000749")]
		[FieldOffset(Offset = "0x14")]
		private float m_StepTime;

		[Token(Token = "0x400074A")]
		[FieldOffset(Offset = "0x18")]
		private bool m_IsPause;

		[Token(Token = "0x400074B")]
		[FieldOffset(Offset = "0x19")]
		private bool m_IsStart;

		[Token(Token = "0x400074C")]
		[FieldOffset(Offset = "0x20")]
		private Action<int, int> TriggerTimerStep;

		[Token(Token = "0x17000113")]
		internal int TotalTime
		{
			[Token(Token = "0x60019EA")]
			[Address(RVA = "0x70B8E9C", Offset = "0x70B4E9C", VA = "0x70B8E9C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000114")]
		internal int StepTime
		{
			[Token(Token = "0x60019EB")]
			[Address(RVA = "0x70B8EBC", Offset = "0x70B4EBC", VA = "0x70B8EBC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60019EC")]
		[Address(RVA = "0x70B8EDC", Offset = "0x70B4EDC", VA = "0x70B8EDC")]
		public Timer(Action<int, int> action)
		{
		}

		[Token(Token = "0x60019ED")]
		[Address(RVA = "0x70B8F04", Offset = "0x70B4F04", VA = "0x70B8F04")]
		internal void Update()
		{
		}

		[Token(Token = "0x60019EE")]
		[Address(RVA = "0x70B8F88", Offset = "0x70B4F88", VA = "0x70B8F88")]
		internal void RunStep()
		{
		}

		[Token(Token = "0x60019EF")]
		[Address(RVA = "0x70B90B4", Offset = "0x70B50B4", VA = "0x70B90B4")]
		internal void Start()
		{
		}

		[Token(Token = "0x60019F0")]
		[Address(RVA = "0x70B90CC", Offset = "0x70B50CC", VA = "0x70B90CC")]
		internal void Stop()
		{
		}

		[Token(Token = "0x60019F1")]
		[Address(RVA = "0x70B90F0", Offset = "0x70B50F0", VA = "0x70B90F0")]
		internal void Pause()
		{
		}

		[Token(Token = "0x60019F2")]
		[Address(RVA = "0x70B9108", Offset = "0x70B5108", VA = "0x70B9108")]
		internal void Continue()
		{
		}

		[Token(Token = "0x60019F3")]
		[Address(RVA = "0x70B90C4", Offset = "0x70B50C4", VA = "0x70B90C4")]
		internal void Reset()
		{
		}
	}
}
