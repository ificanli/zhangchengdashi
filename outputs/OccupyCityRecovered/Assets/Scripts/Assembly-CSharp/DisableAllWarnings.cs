using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000BE")]
public class DisableAllWarnings
{
	[Token(Token = "0x40003F5")]
	[FieldOffset(Offset = "0x0")]
	private static bool initialized;

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x3E39938", Offset = "0x3E35938", VA = "0x3E39938")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void InitSubsystem()
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x3E39B34", Offset = "0x3E35B34", VA = "0x3E39B34")]
	private static void TrySuppressTransformWarnings()
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x3E39E04", Offset = "0x3E35E04", VA = "0x3E39E04")]
	private static void OnLogReceived(string condition, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x3E39E08", Offset = "0x3E35E08", VA = "0x3E39E08")]
	public DisableAllWarnings()
	{
	}
}
