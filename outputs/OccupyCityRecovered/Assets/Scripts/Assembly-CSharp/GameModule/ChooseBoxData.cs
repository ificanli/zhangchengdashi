using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000488")]
	public class ChooseBoxData
	{
		[Token(Token = "0x4002B19")]
		[FieldOffset(Offset = "0x10")]
		public RewardConfigSingle RewardConfigSingle;

		[Token(Token = "0x4002B1A")]
		[FieldOffset(Offset = "0x18")]
		public UserBoxData BoxData;

		[Token(Token = "0x4002B1B")]
		[FieldOffset(Offset = "0x20")]
		public int BoxCount;

		[Token(Token = "0x6001637")]
		[Address(RVA = "0x3E28508", Offset = "0x3E24508", VA = "0x3E28508")]
		public ChooseBoxData()
		{
		}
	}
}
