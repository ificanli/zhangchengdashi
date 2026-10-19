using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework.TimeScaleModule
{
	[Token(Token = "0x2000445")]
	public struct TimeScaleProperties
	{
		[Token(Token = "0x4001DF3")]
		[FieldOffset(Offset = "0x0")]
		public float TimeScale;

		[Token(Token = "0x4001DF4")]
		[FieldOffset(Offset = "0x4")]
		public float Duration;

		[Token(Token = "0x4001DF5")]
		[FieldOffset(Offset = "0x8")]
		public bool TimeScaleLerp;

		[Token(Token = "0x4001DF6")]
		[FieldOffset(Offset = "0xC")]
		public float LerpSpeed;

		[Token(Token = "0x4001DF7")]
		[FieldOffset(Offset = "0x10")]
		public bool Infinite;

		[Token(Token = "0x4001DF8")]
		[FieldOffset(Offset = "0x14")]
		public MMTimeScaleLerpModes TimeScaleLerpMode;

		[Token(Token = "0x4001DF9")]
		[FieldOffset(Offset = "0x18")]
		public AnimationCurve TimeScaleLerpCurve;

		[Token(Token = "0x4001DFA")]
		[FieldOffset(Offset = "0x20")]
		public float TimeScaleLerpDuration;

		[Token(Token = "0x4001DFB")]
		[FieldOffset(Offset = "0x24")]
		public bool TimeScaleLerpOnReset;

		[Token(Token = "0x4001DFC")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve TimeScaleLerpCurveOnReset;

		[Token(Token = "0x4001DFD")]
		[FieldOffset(Offset = "0x30")]
		public float TimeScaleLerpDurationOnReset;

		[Token(Token = "0x600692E")]
		[Address(RVA = "0x727379C", Offset = "0x726F79C", VA = "0x727379C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
