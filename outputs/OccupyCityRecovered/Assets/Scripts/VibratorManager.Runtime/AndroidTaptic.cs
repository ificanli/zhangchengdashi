using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000003")]
public class AndroidTaptic
{
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x0")]
	public static long LightDuration;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x8")]
	public static long MediumDuration;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x10")]
	public static long HeavyDuration;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x18")]
	public static int LightAmplitude;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x1C")]
	public static int MediumAmplitude;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x20")]
	public static int HeavyAmplitude;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x24")]
	private static int _sdkVersion;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x28")]
	private static long[] _successPattern;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x30")]
	private static int[] _successPatternAmplitude;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x38")]
	private static long[] _warningPattern;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x40")]
	private static int[] _warningPatternAmplitude;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x48")]
	private static long[] _failurePattern;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x50")]
	private static int[] _failurePatternAmplitude;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x58")]
	private static AndroidJavaClass UnityPlayer;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x60")]
	private static AndroidJavaObject CurrentActivity;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x68")]
	private static AndroidJavaObject AndroidVibrator;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x70")]
	private static AndroidJavaClass VibrationEffectClass;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x78")]
	private static AndroidJavaObject VibrationEffect;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x80")]
	private static int DefaultAmplitude;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x854B028", Offset = "0x8547028", VA = "0x854B028")]
	private void Vib()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x854B030", Offset = "0x8547030", VA = "0x854B030")]
	public static void Vibrate()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x854B1C4", Offset = "0x85471C4", VA = "0x854B1C4")]
	public static void Haptic(HapticTypes type)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x854B088", Offset = "0x8547088", VA = "0x854B088")]
	public static void AndroidVibrate(long milliseconds)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x854B440", Offset = "0x8547440", VA = "0x854B440")]
	public static void AndroidVibrate(long milliseconds, int amplitude)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x854BC1C", Offset = "0x8547C1C", VA = "0x854BC1C")]
	public static void AndroidVibrate(long[] pattern, int repeat)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x854B70C", Offset = "0x854770C", VA = "0x854B70C")]
	public static void AndroidVibrate(long[] pattern, int[] amplitudes, int repeat)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x854BF40", Offset = "0x8547F40", VA = "0x854BF40")]
	public static void AndroidCancelVibrations()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x854BB64", Offset = "0x8547B64", VA = "0x854BB64")]
	private static void VibrationEffectClassInitialization()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x854BA64", Offset = "0x8547A64", VA = "0x854BA64")]
	public static int AndroidSDKVersion()
	{
		return default;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x854C024", Offset = "0x8548024", VA = "0x854C024")]
	public AndroidTaptic()
	{
	}
}
