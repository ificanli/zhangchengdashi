using Il2CppDummyDll;

namespace AnimationInstancing
{
	[Token(Token = "0x2000F55")]
	public class AnimationEvent
	{
		[Token(Token = "0x40069DC")]
		[FieldOffset(Offset = "0x10")]
		public string function;

		[Token(Token = "0x40069DD")]
		[FieldOffset(Offset = "0x18")]
		public int intParameter;

		[Token(Token = "0x40069DE")]
		[FieldOffset(Offset = "0x1C")]
		public float floatParameter;

		[Token(Token = "0x40069DF")]
		[FieldOffset(Offset = "0x20")]
		public string stringParameter;

		[Token(Token = "0x40069E0")]
		[FieldOffset(Offset = "0x28")]
		public string objectParameter;

		[Token(Token = "0x40069E1")]
		[FieldOffset(Offset = "0x30")]
		public float time;

		[Token(Token = "0x6005BCE")]
		[Address(RVA = "0x43A0DD4", Offset = "0x439CDD4", VA = "0x43A0DD4")]
		public AnimationEvent()
		{
		}
	}
}
