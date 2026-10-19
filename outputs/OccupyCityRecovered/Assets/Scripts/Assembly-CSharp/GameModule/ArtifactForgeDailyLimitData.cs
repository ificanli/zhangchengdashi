using System;
using Il2CppDummyDll;

namespace GameModule
{
	[Serializable]
	[Token(Token = "0x20002FF")]
	internal class ArtifactForgeDailyLimitData
	{
		[Token(Token = "0x40022F8")]
		[FieldOffset(Offset = "0x10")]
		public string dateKey;

		[Token(Token = "0x40022F9")]
		[FieldOffset(Offset = "0x18")]
		public int usedTimes;

		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x3D5C2BC", Offset = "0x3D582BC", VA = "0x3D5C2BC")]
		public ArtifactForgeDailyLimitData()
		{
		}
	}
}
