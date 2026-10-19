using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000005")]
public class VibratorManager : MonoBehaviour
{
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x0")]
	private static Action<bool> _onSwitch;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x8")]
	private static bool _vibratorEnable;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x9")]
	private static bool _isGotEnableState;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0xC")]
	private static float _lastTriggerTime;

	[Token(Token = "0x17000001")]
	private static bool VibratorEnable
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x854C6F4", Offset = "0x85486F4", VA = "0x854C6F4")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x854C790", Offset = "0x8548790", VA = "0x854C790")]
		set
		{
		}
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x854C83C", Offset = "0x854883C", VA = "0x854C83C")]
	public static void Trigger(HapticTypes level)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x854C9EC", Offset = "0x85489EC", VA = "0x854C9EC")]
	public static void PlayTransientHaptic(float intensity, float sharpness)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x854C9F0", Offset = "0x85489F0", VA = "0x854C9F0")]
	public static void StartContinuousVibration(float intensity, float sharpness, float duration)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x854C9F4", Offset = "0x85489F4", VA = "0x854C9F4")]
	public static void StopContinuousVibration()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x854C938", Offset = "0x8548938", VA = "0x854C938")]
	public static void UpdateTrigger(HapticTypes level = HapticTypes.Selection, float interval = 0.05f)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x854C9F8", Offset = "0x85489F8", VA = "0x854C9F8")]
	private static bool IsTapticEngine()
	{
		return default;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x854CBF4", Offset = "0x8548BF4", VA = "0x854CBF4")]
	public static bool IsiPadOriPod()
	{
		return default;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x854C680", Offset = "0x8548680", VA = "0x854C680")]
	public static void Switch()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x854C574", Offset = "0x8548574", VA = "0x854C574")]
	public static void BindEvent(Action<bool> actionEvent)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x854CC7C", Offset = "0x8548C7C", VA = "0x854CC7C")]
	public VibratorManager()
	{
	}
}
