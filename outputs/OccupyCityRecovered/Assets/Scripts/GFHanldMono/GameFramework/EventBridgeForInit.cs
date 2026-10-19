using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x2000010")]
	public static class EventBridgeForInit
	{
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x0")]
		[CompilerGenerated]
		private static Action m_OnInitializeRequested;

		[Token(Token = "0x14000001")]
		public static event Action OnInitializeRequested
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x7068954", Offset = "0x7064954", VA = "0x7068954")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x7068A0C", Offset = "0x7064A0C", VA = "0x7068A0C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x70688E0", Offset = "0x70648E0", VA = "0x70688E0")]
		public static void DisPatch()
		{
		}
	}
}
