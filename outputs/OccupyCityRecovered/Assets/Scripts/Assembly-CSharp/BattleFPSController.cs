using CommonGameModule.Debugger;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000A6")]
public class BattleFPSController : MonoBehaviour
{
	[Token(Token = "0x4000353")]
	[FieldOffset(Offset = "0x0")]
	private static BattleFPSController _instance;

	[Token(Token = "0x4000354")]
	private const string AutoConfigIDKey = "AutoFpsControlLevel";

	[Token(Token = "0x4000355")]
	private const string AutoFpsControlKey = "AutoFpsControl";

	[Token(Token = "0x4000356")]
	[FieldOffset(Offset = "0x20")]
	private int _autoConfigIDCache;

	[Token(Token = "0x4000357")]
	[FieldOffset(Offset = "0x24")]
	private bool _autoConfigIDCached;

	[Token(Token = "0x4000358")]
	[FieldOffset(Offset = "0x28")]
	private int _isEnableCache;

	[Token(Token = "0x4000359")]
	[FieldOffset(Offset = "0x30")]
	[Tooltip("拖入 BattleFPSConfig 资产")]
	public BattleFPSConfig[] configs;

	[Token(Token = "0x400035A")]
	[FieldOffset(Offset = "0x38")]
	[Tooltip("是否启用自动帧率控制")]
	public bool isActive;

	[Token(Token = "0x400035B")]
	[FieldOffset(Offset = "0x40")]
	private FpsCounter _fpsCounter;

	[Token(Token = "0x400035C")]
	[FieldOffset(Offset = "0x48")]
	private float _degradeTimer;

	[Token(Token = "0x400035D")]
	[FieldOffset(Offset = "0x4C")]
	private float _recoverTimer;

	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x50")]
	private int _currentDegradeIndex;

	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x54")]
	private int _consecutiveLowFpsCount;

	[Token(Token = "0x17000028")]
	public static BattleFPSController Instance
	{
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x3D2D5A8", Offset = "0x3D295A8", VA = "0x3D2D5A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000029")]
	public int AutoConfigID
	{
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x3D2D5F0", Offset = "0x3D295F0", VA = "0x3D2D5F0")]
		get
		{
			return default;
		}
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x3D2D6C0", Offset = "0x3D296C0", VA = "0x3D2D6C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	private BattleFPSConfig config
	{
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x3D2D760", Offset = "0x3D29760", VA = "0x3D2D760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002B")]
	public BattleFPSConfig Config
	{
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x3D2D7C8", Offset = "0x3D297C8", VA = "0x3D2D7C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002C")]
	public int CurrentDegradeCount
	{
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x3D2D7CC", Offset = "0x3D297CC", VA = "0x3D2D7CC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700002D")]
	public bool IsEnable
	{
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x3D2D93C", Offset = "0x3D2993C", VA = "0x3D2D93C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x3D2DA04", Offset = "0x3D29A04", VA = "0x3D2DA04")]
		set
		{
		}
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x3D2D7D8", Offset = "0x3D297D8", VA = "0x3D2D7D8")]
	private int IsFirstTip()
	{
		return default;
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x3D2D844", Offset = "0x3D29844", VA = "0x3D2D844")]
	private void SetFirstTipShown()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x3D2D8B0", Offset = "0x3D298B0", VA = "0x3D2D8B0")]
	private void ShowFirstTipIfNeeded()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x3D2DA88", Offset = "0x3D29A88", VA = "0x3D2DA88")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x3D2DBBC", Offset = "0x3D29BBC", VA = "0x3D2DBBC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x3D2DC54", Offset = "0x3D29C54", VA = "0x3D2DC54")]
	public void StartMonitoring()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x3D2DF90", Offset = "0x3D29F90", VA = "0x3D2DF90")]
	public void StopMonitoring()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x3D2E2C8", Offset = "0x3D2A2C8", VA = "0x3D2E2C8")]
	private void Update()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x3D2E510", Offset = "0x3D2A510", VA = "0x3D2E510")]
	private void TryDegradeNext(float currentFps)
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x3D2E740", Offset = "0x3D2A740", VA = "0x3D2E740")]
	private void TryRecoverLast()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x3D2E8C8", Offset = "0x3D2A8C8", VA = "0x3D2E8C8")]
	private void ApplyDegrade(PerformanceFeature feature)
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x3D2EAF0", Offset = "0x3D2AAF0", VA = "0x3D2EAF0")]
	private void ApplyRecover(PerformanceFeature feature)
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x3D2EC80", Offset = "0x3D2AC80", VA = "0x3D2EC80")]
	private void SetRenderScale(float scale)
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x3D2EDF4", Offset = "0x3D2ADF4", VA = "0x3D2EDF4")]
	private void RecoverRenderScale()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x3D2F0DC", Offset = "0x3D2B0DC", VA = "0x3D2F0DC")]
	private static bool IsRenderScaleType(PerformanceFeatureType type)
	{
		return default;
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x3D2F0EC", Offset = "0x3D2B0EC", VA = "0x3D2F0EC")]
	private static float GetRenderScaleValue(PerformanceFeatureType type)
	{
		return default;
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x3D2E06C", Offset = "0x3D2A06C", VA = "0x3D2E06C")]
	private void RestoreAll()
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x3D2F110", Offset = "0x3D2B110", VA = "0x3D2F110")]
	public void ManualToggleFeature(PerformanceFeature feature, bool disable)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x3D2F11C", Offset = "0x3D2B11C", VA = "0x3D2F11C")]
	public BattleFPSController()
	{
	}
}
