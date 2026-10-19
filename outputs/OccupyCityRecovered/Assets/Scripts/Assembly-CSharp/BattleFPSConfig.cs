using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000A5")]
[CreateAssetMenu(menuName = "Battle/FPSConfig", fileName = "BattleFPSConfig")]
public class BattleFPSConfig : ScriptableObject
{
	[Token(Token = "0x400034C")]
	[FieldOffset(Offset = "0x18")]
	[Tooltip("FPS 采样间隔（秒），每隔多久检测一次是否需要降级")]
	[Header("帧率检测")]
	public float fpsCheckInterval;

	[Token(Token = "0x400034D")]
	[FieldOffset(Offset = "0x1C")]
	[Tooltip("FPS 恢复检测间隔（秒），每隔多久检测一次是否可以恢复功能")]
	public float fpsRecoveryCheckInterval;

	[Token(Token = "0x400034E")]
	[FieldOffset(Offset = "0x20")]
	[Tooltip("需要连续多少次检测低于阈值才触发降级（防止偶发卡顿误触发）")]
	public int degradeConfirmCount;

	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0x24")]
	[Header("帧率阈值")]
	[Tooltip("目标帧率，低于此值开始按优先级关闭功能")]
	public int targetFPS;

	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("恢复帧率，高于此值开始按逆序恢复功能（应大于 targetFPS，防止抖动）")]
	public int recoveryFPS;

	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0x2C")]
	[Tooltip("RenderScale 正常值（战斗结束恢复到此值）")]
	[Range(0.5f, 1f)]
	[Header("RenderScale 控制")]
	public float defaultRenderScale;

	[Token(Token = "0x4000352")]
	[FieldOffset(Offset = "0x30")]
	[Header("功能降级列表（从上到下优先级递减，排在前面的先被关闭）")]
	public List<PerformanceFeature> features;

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x3D2CE88", Offset = "0x3D28E88", VA = "0x3D2CE88")]
	public int GetEffectiveThreshold(PerformanceFeature feature)
	{
		return default;
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x3D2CEB0", Offset = "0x3D28EB0", VA = "0x3D2CEB0")]
	public void ResetToDefaults()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x3D2D508", Offset = "0x3D29508", VA = "0x3D2D508")]
	public BattleFPSConfig()
	{
	}
}
