using Il2CppDummyDll;

namespace FishFlock
{
	[Token(Token = "0x2000DDB")]
	public enum FlockComputationMode
	{
		[Token(Token = "0x400610C")]
		CPU = 0,
		[Token(Token = "0x400610D")]
		CPU_AND_ONE_THREAD = 1,
		[Token(Token = "0x400610E")]
		GPU = 2
	}
}
