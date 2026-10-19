using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000223")]
	public class FootballGoalkeeperController : MonoBehaviour
	{
		[Token(Token = "0x4001D82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _coordinateSpace;

		[Token(Token = "0x4001D83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FootballGoalAreaSettings _area;

		[Token(Token = "0x4001D84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SkeletonAnimation _skeletonAnimation;

		[Token(Token = "0x4001D85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SkeletonAnimation _shadowSkeletonAnimation;

		[Token(Token = "0x4001D86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationReferenceAsset _idleAnim;

		[Token(Token = "0x4001D87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationReferenceAsset _jump1Anim;

		[Token(Token = "0x4001D88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AnimationReferenceAsset _jump2Anim;

		[Token(Token = "0x4001D89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationReferenceAsset _jump3Anim;

		[Token(Token = "0x4001D8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AnimationReferenceAsset _jump4Anim;

		[Token(Token = "0x4001D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _keeperZ;

		[Token(Token = "0x4001D8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _resetMoveDuration;

		[Token(Token = "0x4001D8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _diveLandY;

		[Token(Token = "0x4001D8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Tooltip("影子贴地世界坐标 Y；0 则在 Awake 时取 shadow 初始高度")]
		private float _shadowGroundWorldY;

		[Token(Token = "0x4001D8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Header("Dive trajectory")]
		[SerializeField]
		private float _minPeakClearance;

		[Token(Token = "0x4001D90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[Tooltip("相对落地高度 landY 的最大抬升量（世界单位）。0 = 不抬升")]
		private float _maxPeakHeight;

		[Token(Token = "0x4001D91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("腾空阶段时间：起跳到上升终点所占时长比例")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _ascentPeakRatio;

		[Token(Token = "0x4001D92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Tooltip("水平到达进度：0=仍在起点，1=到达目标水平位置；未达则落地时保持该位置")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _ascentReachX;

		[Token(Token = "0x4001D93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("上升终点 Y 进度：0=仍在起点高度，1=到达腾空顶点")]
		private float _ascentReachY;

		[Token(Token = "0x4001D94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _facingFlipThreshold;

		[Token(Token = "0x4001D95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0.75f, 1f)]
		[SerializeField]
		[Tooltip("腾空轨迹进度达到该比例时触发落地烟尘（1=轨迹结束触地）")]
		private float _landDustTriggerRatio;

		[Token(Token = "0x4001D96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 _idlePosition;

		[Token(Token = "0x4001D97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Tween _moveTween;

		[Token(Token = "0x4001D98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FootballGoalZone _lastZone;

		[Token(Token = "0x4001D99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int _diveToken;

		[Token(Token = "0x4001D9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float _defaultScaleX;

		[Token(Token = "0x4001D9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly Dictionary<Bone, float> _boneSetupY;

		[Token(Token = "0x4001D9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float _activeMaxSkeletonRise;

		[Token(Token = "0x4001D9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool _limitSkeletonRise;

		[Token(Token = "0x4001D9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[CompilerGenerated]
		private Action<Vector3> m_Landed;

		[Token(Token = "0x170000B0")]
		public FootballGoalZone LastZone
		{
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x428AA80", Offset = "0x4286A80", VA = "0x428AA80")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<Vector3> Landed
		{
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x428AA88", Offset = "0x4286A88", VA = "0x428AA88")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x428AB38", Offset = "0x4286B38", VA = "0x428AB38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x428ABE8", Offset = "0x4286BE8", VA = "0x428ABE8")]
		public float GetDiveSequenceDurationSeconds()
		{
			return default;
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x428ACE0", Offset = "0x4286CE0", VA = "0x428ACE0")]
		public float GetSaveApplyDelaySeconds()
		{
			return default;
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x428AD2C", Offset = "0x4286D2C", VA = "0x428AD2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x428B1F0", Offset = "0x42871F0", VA = "0x428B1F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x428B550", Offset = "0x4287550", VA = "0x428B550")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x428B620", Offset = "0x4287620", VA = "0x428B620")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x428B6C8", Offset = "0x42876C8", VA = "0x428B6C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x428A808", Offset = "0x4286808", VA = "0x428A808")]
		public void Dive(FootballGoalZone zone, [Optional] Vector3? preciseAimWorld)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x428BBF4", Offset = "0x4287BF4", VA = "0x428BBF4")]
		public void ResetKeeper(bool instant)
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x428B8CC", Offset = "0x42878CC", VA = "0x428B8CC")]
		private float ComputePeakY(float landY, float reachY)
		{
			return default;
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x428B0EC", Offset = "0x42870EC", VA = "0x428B0EC")]
		private void CacheSkeletonRootSetup()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x428B6E8", Offset = "0x42876E8", VA = "0x428B6E8")]
		private void SetSkeletonRiseLimit(bool enabled)
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x428BD3C", Offset = "0x4287D3C", VA = "0x428BD3C")]
		private void OnSkeletonUpdateLocal(ISkeletonAnimation animated)
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x428BEE8", Offset = "0x4287EE8", VA = "0x428BEE8")]
		private void PlayDiveAirPhase(Vector3 startPos, Vector3 horizontalTarget, float peakY, float landY, int diveToken, Action onComplete, [Optional] Action<float> onTrajectoryProgress)
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x428C3A0", Offset = "0x42883A0", VA = "0x428C3A0")]
		private void ApplyAirTrajectoryPosition(float t, Vector3 startPos, Vector3 horizontalTarget, float landY, float peakT, float ascentReachX, float ascentPeakY)
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x428C51C", Offset = "0x428851C", VA = "0x428C51C")]
		private static float SampleArcY(float t, float startY, float peakY, float landY, float peakT)
		{
			return default;
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x428C4C4", Offset = "0x42884C4", VA = "0x428C4C4")]
		private static float SampleHorizRatio(float t, float peakT, float ascentReachX)
		{
			return default;
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x428B8F4", Offset = "0x42878F4", VA = "0x428B8F4")]
		private void PlayDivePhase(AnimationReferenceAsset anim, Vector3 moveTarget, int diveToken, Action onPhaseComplete, bool moveTransform = true, Ease moveEase = Ease.Linear)
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x428B2BC", Offset = "0x42872BC", VA = "0x428B2BC")]
		private void RestoreIdlePose()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x428C73C", Offset = "0x428873C", VA = "0x428C73C")]
		private void HoldLandingPose()
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x428B878", Offset = "0x4287878", VA = "0x428B878")]
		private void ApplyFacing(Vector3 startPos, Vector3 targetPos)
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x428C7F0", Offset = "0x42887F0", VA = "0x428C7F0")]
		private float ResolveFacingScaleX(Vector3 startPos, Vector3 targetPos)
		{
			return default;
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x428C820", Offset = "0x4288820", VA = "0x428C820")]
		private static void ApplySkeletonScaleX(SkeletonAnimation skeletonAnimation, float scaleX)
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x428C28C", Offset = "0x428828C", VA = "0x428C28C")]
		private TrackEntry SetKeeperAnimation(int trackIndex, AnimationReferenceAsset animRef, bool loop)
		{
			return null;
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x428C864", Offset = "0x4288864", VA = "0x428C864")]
		private void SyncShadowAnimation(int trackIndex, AnimationReferenceAsset animRef, bool loop, TrackEntry keeperEntry)
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x428C670", Offset = "0x4288670", VA = "0x428C670")]
		private static string GetAnimationName(AnimationReferenceAsset animRef)
		{
			return null;
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x428B624", Offset = "0x4287624", VA = "0x428B624")]
		private void SyncShadowGroundHeight()
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x428C758", Offset = "0x4288758", VA = "0x428C758")]
		private static void HoldSkeletonPose(SkeletonAnimation skeletonAnimation)
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x428AC40", Offset = "0x4286C40", VA = "0x428AC40")]
		private static float GetAnimDuration(AnimationReferenceAsset animRef)
		{
			return default;
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x428C96C", Offset = "0x428896C", VA = "0x428C96C")]
		private static float GetTrackDuration(TrackEntry entry)
		{
			return default;
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x428C59C", Offset = "0x428859C", VA = "0x428C59C")]
		private float GetEffectiveDuration(TrackEntry entry)
		{
			return default;
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x428C990", Offset = "0x4288990", VA = "0x428C990")]
		public FootballGoalkeeperController()
		{
		}
	}
}
