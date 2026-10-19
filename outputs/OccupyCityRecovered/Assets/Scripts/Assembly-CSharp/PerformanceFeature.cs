using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20000A7")]
public class PerformanceFeature
{
	[Token(Token = "0x4000360")]
	[FieldOffset(Offset = "0x10")]
	public PerformanceFeatureType featureType;

	[Token(Token = "0x4000361")]
	[FieldOffset(Offset = "0x14")]
	[Tooltip("当 FPS 低于此值时关闭该功能。设为 0 则跟随全局 targetFPS 阈值")]
	public int fpsThreshold;

	[Token(Token = "0x4000362")]
	[FieldOffset(Offset = "0x18")]
	public bool enabled;

	[NonSerialized]
	[Token(Token = "0x4000363")]
	[FieldOffset(Offset = "0x19")]
	public bool isCurrentlyDisabled;

	[Token(Token = "0x4000364")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<PerformanceFeatureType, string> DisplayNames;

	[Token(Token = "0x1700002E")]
	public string DisplayName
	{
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x3D2EA98", Offset = "0x3D2AA98", VA = "0x3D2EA98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x3D2F138", Offset = "0x3D2B138", VA = "0x3D2F138")]
	public static string GetDisplayName(PerformanceFeatureType type)
	{
		return null;
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x3D2D4F8", Offset = "0x3D294F8", VA = "0x3D2D4F8")]
	public PerformanceFeature()
	{
	}
}
