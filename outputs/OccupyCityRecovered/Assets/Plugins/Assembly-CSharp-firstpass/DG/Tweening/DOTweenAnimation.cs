using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening
{
	[Token(Token = "0x2000004")]
	[AddComponentMenu("DOTween/DOTween Animation")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x2000005")]
		public enum AnimationType
		{
			[Token(Token = "0x4000030")]
			None = 0,
			[Token(Token = "0x4000031")]
			Move = 1,
			[Token(Token = "0x4000032")]
			LocalMove = 2,
			[Token(Token = "0x4000033")]
			Rotate = 3,
			[Token(Token = "0x4000034")]
			LocalRotate = 4,
			[Token(Token = "0x4000035")]
			Scale = 5,
			[Token(Token = "0x4000036")]
			Color = 6,
			[Token(Token = "0x4000037")]
			Fade = 7,
			[Token(Token = "0x4000038")]
			Text = 8,
			[Token(Token = "0x4000039")]
			PunchPosition = 9,
			[Token(Token = "0x400003A")]
			PunchRotation = 10,
			[Token(Token = "0x400003B")]
			PunchScale = 11,
			[Token(Token = "0x400003C")]
			ShakePosition = 12,
			[Token(Token = "0x400003D")]
			ShakeRotation = 13,
			[Token(Token = "0x400003E")]
			ShakeScale = 14,
			[Token(Token = "0x400003F")]
			CameraAspect = 15,
			[Token(Token = "0x4000040")]
			CameraBackgroundColor = 16,
			[Token(Token = "0x4000041")]
			CameraFieldOfView = 17,
			[Token(Token = "0x4000042")]
			CameraOrthoSize = 18,
			[Token(Token = "0x4000043")]
			CameraPixelRect = 19,
			[Token(Token = "0x4000044")]
			CameraRect = 20,
			[Token(Token = "0x4000045")]
			UIWidthHeight = 21
		}

		[Token(Token = "0x2000006")]
		public enum TargetType
		{
			[Token(Token = "0x4000047")]
			Unset = 0,
			[Token(Token = "0x4000048")]
			Camera = 1,
			[Token(Token = "0x4000049")]
			CanvasGroup = 2,
			[Token(Token = "0x400004A")]
			Image = 3,
			[Token(Token = "0x400004B")]
			Light = 4,
			[Token(Token = "0x400004C")]
			RectTransform = 5,
			[Token(Token = "0x400004D")]
			Renderer = 6,
			[Token(Token = "0x400004E")]
			SpriteRenderer = 7,
			[Token(Token = "0x400004F")]
			Rigidbody = 8,
			[Token(Token = "0x4000050")]
			Rigidbody2D = 9,
			[Token(Token = "0x4000051")]
			Text = 10,
			[Token(Token = "0x4000052")]
			Transform = 11,
			[Token(Token = "0x4000053")]
			tk2dBaseSprite = 12,
			[Token(Token = "0x4000054")]
			tk2dTextMesh = 13,
			[Token(Token = "0x4000055")]
			TextMeshPro = 14,
			[Token(Token = "0x4000056")]
			TextMeshProUGUI = 15
		}

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		[CompilerGenerated]
		private static Action<DOTweenAnimation> m_OnReset;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x70")]
		public bool targetIsSelf;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x78")]
		public GameObject targetGO;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x80")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x84")]
		public float delay;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x88")]
		public float duration;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x8C")]
		public Ease easeType;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x90")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x98")]
		public LoopType loopType;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x9C")]
		public int loops;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0xA0")]
		public string id;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0xA8")]
		public bool isRelative;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0xA9")]
		public bool isFrom;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0xAA")]
		public bool isIndependentUpdate;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0xAB")]
		public bool autoKill;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0xAC")]
		public bool autoGenerate;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0xAD")]
		public bool isActive;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0xAE")]
		public bool isValid;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0xB0")]
		public Component target;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0xB8")]
		public AnimationType animationType;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0xBC")]
		public TargetType targetType;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0xC0")]
		public TargetType forcedTargetType;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0xC4")]
		public bool autoPlay;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0xC5")]
		public bool useTargetAsV3;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0xC8")]
		public float endValueFloat;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0xCC")]
		public Vector3 endValueV3;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0xD8")]
		public Vector2 endValueV2;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0xE0")]
		public Color endValueColor;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0xF0")]
		public string endValueString;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0xF8")]
		public Rect endValueRect;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x108")]
		public Transform endValueTransform;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x110")]
		public bool optionalBool0;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x111")]
		public bool optionalBool1;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x114")]
		public float optionalFloat0;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x118")]
		public int optionalInt0;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x11C")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x120")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x124")]
		public ShakeRandomnessMode optionalShakeRandomnessMode;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x128")]
		public string optionalString;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x130")]
		private bool _tweenAutoGenerationCalled;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x134")]
		private int _playCount;

		[Token(Token = "0x14000001")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x3CF851C", Offset = "0x3CF451C", VA = "0x3CF851C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x3CF85E8", Offset = "0x3CF45E8", VA = "0x3CF85E8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x3CF86B4", Offset = "0x3CF46B4", VA = "0x3CF86B4")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x3CF8720", Offset = "0x3CF4720", VA = "0x3CF8720")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3CF9D34", Offset = "0x3CF5D34", VA = "0x3CF9D34")]
		private void Start()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3CF9D74", Offset = "0x3CF5D74", VA = "0x3CF9D74")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x3CF9D78", Offset = "0x3CF5D78", VA = "0x3CF9D78")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x3CF9DA8", Offset = "0x3CF5DA8", VA = "0x3CF9DA8")]
		public void RewindThenRecreateTween()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x3CF9DE0", Offset = "0x3CF5DE0", VA = "0x3CF9DE0")]
		public void RewindThenRecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x3CF9E18", Offset = "0x3CF5E18", VA = "0x3CF9E18")]
		public void RecreateTween()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x3CF9E24", Offset = "0x3CF5E24", VA = "0x3CF9E24")]
		public void RecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x3CF876C", Offset = "0x3CF476C", VA = "0x3CF876C")]
		public void CreateTween(bool regenerateIfExists = false, bool andPlay = true)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x3CFA078", Offset = "0x3CF6078", VA = "0x3CFA078")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x3CFA1C8", Offset = "0x3CF61C8", VA = "0x3CFA1C8")]
		public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x3CFA298", Offset = "0x3CF6298", VA = "0x3CFA298", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x3CFA318", Offset = "0x3CF6318", VA = "0x3CFA318", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x3CFA398", Offset = "0x3CF6398", VA = "0x3CFA398", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x3CFA418", Offset = "0x3CF6418", VA = "0x3CFA418", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x3CFA498", Offset = "0x3CF6498", VA = "0x3CFA498", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x3CFA518", Offset = "0x3CF6518", VA = "0x3CFA518", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3CFA5F4", Offset = "0x3CF65F4", VA = "0x3CFA5F4", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3CFA604", Offset = "0x3CF6604", VA = "0x3CFA604", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x3CFA930", Offset = "0x3CF6930", VA = "0x3CFA930", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x3CFA9B4", Offset = "0x3CF69B4", VA = "0x3CFA9B4", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x3CFAA40", Offset = "0x3CF6A40", VA = "0x3CFAA40")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x3CFAAC8", Offset = "0x3CF6AC8", VA = "0x3CFAAC8")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3CFAB20", Offset = "0x3CF6B20", VA = "0x3CFAB20")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3CFAB78", Offset = "0x3CF6B78", VA = "0x3CFAB78")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x3CFAC00", Offset = "0x3CF6C00", VA = "0x3CFAC00")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x3CFAC58", Offset = "0x3CF6C58", VA = "0x3CFAC58")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x3CFACE0", Offset = "0x3CF6CE0", VA = "0x3CFACE0")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x3CFAD38", Offset = "0x3CF6D38", VA = "0x3CFAD38")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x3CFAE74", Offset = "0x3CF6E74", VA = "0x3CFAE74")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x3CFAF08", Offset = "0x3CF6F08", VA = "0x3CFAF08")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x3CFAF78", Offset = "0x3CF6F78", VA = "0x3CFAF78")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x3CFB010", Offset = "0x3CF7010", VA = "0x3CFB010")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x3CFB084", Offset = "0x3CF7084", VA = "0x3CFB084")]
		public void DOKillById(string id)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x3CFB110", Offset = "0x3CF7110", VA = "0x3CFB110")]
		public void DOKillAllById(string id)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x3CF9E48", Offset = "0x3CF5E48", VA = "0x3CF9E48")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x3CFB16C", Offset = "0x3CF716C", VA = "0x3CFB16C")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x3CF9E30", Offset = "0x3CF5E30", VA = "0x3CF9E30")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x3CFA058", Offset = "0x3CF6058", VA = "0x3CFA058")]
		private GameObject GetTweenTarget()
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x3CFA710", Offset = "0x3CF6710", VA = "0x3CFA710")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x3CFB1E4", Offset = "0x3CF71E4", VA = "0x3CFB1E4")]
		public DOTweenAnimation()
		{
		}
	}
}
