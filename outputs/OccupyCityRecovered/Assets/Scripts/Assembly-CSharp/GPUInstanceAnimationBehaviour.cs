using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GPUInstancer.CrowdAnimations;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

[Token(Token = "0x20000AA")]
public class GPUInstanceAnimationBehaviour : MonoBehaviour, IAnimation
{
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class AnimationInfo
	{
		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationName name;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationClip clip;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speed;

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x3E2F7E4", Offset = "0x3E2B7E4", VA = "0x3E2F7E4")]
		public AnimationInfo()
		{
		}
	}

	[Token(Token = "0x20000AC")]
	public enum AnimationName
	{
		[Token(Token = "0x400038E")]
		Idle = 0,
		[Token(Token = "0x400038F")]
		Run = 1,
		[Token(Token = "0x4000390")]
		Dead = 2,
		[Token(Token = "0x4000391")]
		Attack = 3,
		[Token(Token = "0x4000392")]
		Revival = 4,
		[Token(Token = "0x4000393")]
		Skill = 5
	}

	[Token(Token = "0x4000376")]
	private const string Speed = "Speed";

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Animator animator;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationClip idle;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationClip run;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("die")]
	public AnimationClip dead;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationClip attack;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AnimationClip revival;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationClip skill;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float idleSpeed;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float runSpeed;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float deadSpeed;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float attackSpeed;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float revivalSpeed;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float skillSpeed;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private AnimationName currentAnimationName;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GPUICrowdPrefab _gpuiCrowdPrefab;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	public List<AnimationInfo> animationInfoList;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Dictionary<AnimationName, AnimationInfo> animationInfoDic;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _lastGpuFallbackFrame;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private string _lastGpuFallbackReason;

	[Token(Token = "0x1700002F")]
float IAnimation.attackSpeed
	{
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x3D2FD9C", Offset = "0x3D2BD9C", VA = "0x3D2FD9C", Slot = "9")]
		get
		{
			return IAnimation_002Eget_attackSpeed();
		}
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x3D2F5EC", Offset = "0x3D2B5EC", VA = "0x3D2F5EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x3D2F8C4", Offset = "0x3D2B8C4", VA = "0x3D2F8C4")]
	private void SyncAnimationInfoListWithSerializedFields()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x3D2FC10", Offset = "0x3D2BC10", VA = "0x3D2FC10")]
	private bool IsSupportedAnimationName(AnimationName name)
	{
		return default;
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x3D2FA20", Offset = "0x3D2BA20", VA = "0x3D2FA20")]
	private void UpsertAnimationInfo(AnimationName name, AnimationClip clip, float speed)
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x3D2FC1C", Offset = "0x3D2BC1C", VA = "0x3D2FC1C", Slot = "4")]
	public void ChangeAnimatorSpeed(AnimationName animationName, float speed)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x3D2FD1C", Offset = "0x3D2BD1C", VA = "0x3D2FD1C", Slot = "5")]
	public float GetAnimatorSpeed(AnimationName animationName)
	{
		return default;
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x3D2FD9C", Offset = "0x3D2BD9C", VA = "0x3D2FD9C", Slot = "9")]
	private float IAnimation_002Eget_attackSpeed()
	{
		return default;
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x3D2FDA4", Offset = "0x3D2BDA4", VA = "0x3D2FDA4", Slot = "7")]
	public bool GetCurrentAnimationIs(AnimationName animationName)
	{
		return default;
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x3D2FDB4", Offset = "0x3D2BDB4", VA = "0x3D2FDB4", Slot = "6")]
	public AnimationName GetCurrentAnimationName()
	{
		return default;
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x3D2FDBC", Offset = "0x3D2BDBC", VA = "0x3D2FDBC")]
	public AnimationName GetCurrentAnimationNameSafe()
	{
		return default;
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x3D2FDC4", Offset = "0x3D2BDC4", VA = "0x3D2FDC4", Slot = "8")]
	public float GetAnimationLength(AnimationName animationName)
	{
		return default;
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x3D2FEA8", Offset = "0x3D2BEA8", VA = "0x3D2FEA8", Slot = "10")]
	public void ResetState()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x3D2FEB4", Offset = "0x3D2BEB4", VA = "0x3D2FEB4")]
	private string BuildAnimationLogContext(AnimationName animationName, AnimationInfo animationInfo)
	{
		return null;
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x3D30494", Offset = "0x3D2C494", VA = "0x3D30494")]
	private void LogDetailedAnimationError(string category, string message, AnimationName animationName, AnimationInfo animationInfo, [Optional] UnityEngine.Object contextOverride)
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x3D30680", Offset = "0x3D2C680", VA = "0x3D30680")]
	private void LogGpuFallback(string reason, AnimationName animationName, AnimationInfo animationInfo)
	{
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x3D307A8", Offset = "0x3D2C7A8", VA = "0x3D307A8")]
	private bool CanUseGpuCrowdAnimation(AnimationName animationName, AnimationInfo animationInfo, out string reason)
	{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GPUInstanceAnimationBehaviour.CanUseGpuCrowdAnimation RVA=0x3D307A8 Token=0x600037F");
}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x3D30B3C", Offset = "0x3D2CB3C", VA = "0x3D30B3C")]
	private void PlayAnimatorFallback(AnimationName animationName, AnimationInfo animationInfo, string reason)
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x3D30D8C", Offset = "0x3D2CD8C", VA = "0x3D30D8C", Slot = "11")]
	public void SetAnimation(AnimationName animationName)
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x3D311EC", Offset = "0x3D2D1EC", VA = "0x3D311EC")]
	public GPUInstanceAnimationBehaviour()
	{
	}
}
