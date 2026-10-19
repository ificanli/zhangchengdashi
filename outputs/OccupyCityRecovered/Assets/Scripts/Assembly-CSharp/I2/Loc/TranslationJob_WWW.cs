using Il2CppDummyDll;
using UnityEngine.Networking;

namespace I2.Loc
{
	[Token(Token = "0x2000D71")]
	public class TranslationJob_WWW : TranslationJob
	{
		[Token(Token = "0x4005F5F")]
		[FieldOffset(Offset = "0x18")]
		public UnityWebRequest www;

		[Token(Token = "0x6005312")]
		[Address(RVA = "0x4310CD0", Offset = "0x430CCD0", VA = "0x4310CD0", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6005313")]
		[Address(RVA = "0x4310CF4", Offset = "0x430CCF4", VA = "0x4310CF4")]
		public TranslationJob_WWW()
		{
		}
	}
}
