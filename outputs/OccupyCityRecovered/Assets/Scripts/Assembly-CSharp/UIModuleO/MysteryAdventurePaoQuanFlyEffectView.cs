using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000A25")]
	public class MysteryAdventurePaoQuanFlyEffectView : MonoBehaviour
	{
		[Token(Token = "0x2000A26")]
		private readonly struct GlowPathTemplate
		{
			[Token(Token = "0x4004B6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly float InsertTime;

			[Token(Token = "0x4004B6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public readonly float Duration;

			[Token(Token = "0x4004B6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly Vector2 Control1;

			[Token(Token = "0x4004B70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly Vector2 Control2;

			[Token(Token = "0x4004B71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly bool ActivateOnInsert;

			[Token(Token = "0x6003CB3")]
			[Address(RVA = "0x414B110", Offset = "0x4147110", VA = "0x414B110")]
			public GlowPathTemplate(float insertTime, float duration, Vector2 control1, Vector2 control2, bool activateOnInsert)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventurePaoQuanFlyEffectView.GlowPathTemplate..ctor RVA=0x414B110 Token=0x6003CB3");
}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A29")]
		[CompilerGenerated]
		private struct _003CPlayAsync_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4004B79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004B7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004B7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePaoQuanFlyEffectView _003C_003E4__this;

			[Token(Token = "0x4004B7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RectTransform overlayParent;

			[Token(Token = "0x4004B7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 startWorldPos;

			[Token(Token = "0x4004B7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 endWorldPos;

			[Token(Token = "0x4004B7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003CB9")]
			[Address(RVA = "0x414B320", Offset = "0x4147320", VA = "0x414B320", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003CBA")]
			[Address(RVA = "0x414B818", Offset = "0x4147818", VA = "0x414B818", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A2A")]
		[CompilerGenerated]
		private struct _003CPlayInternalAsync_003Ed__23 : IAsyncStateMachine
		{
			[Token(Token = "0x4004B80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004B81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004B82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePaoQuanFlyEffectView _003C_003E4__this;

			[Token(Token = "0x4004B83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector2 endLocal;

			[Token(Token = "0x4004B84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector2 startLocal;

			[Token(Token = "0x4004B85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RectTransform overlayParent;

			[Token(Token = "0x4004B86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003Ctoken_003E5__2;

			[Token(Token = "0x4004B87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6003CBB")]
			[Address(RVA = "0x414B824", Offset = "0x4147824", VA = "0x414B824", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003CBC")]
			[Address(RVA = "0x414BD1C", Offset = "0x4147D1C", VA = "0x414BD1C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A2B")]
		[CompilerGenerated]
		private struct _003CPlayPreviewAsync_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4004B88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004B89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004B8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePaoQuanFlyEffectView _003C_003E4__this;

			[Token(Token = "0x4004B8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003CBD")]
			[Address(RVA = "0x414BD28", Offset = "0x4147D28", VA = "0x414BD28", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003CBE")]
			[Address(RVA = "0x414C20C", Offset = "0x414820C", VA = "0x414C20C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004B5D")]
		private const float TotalDuration = 1.5f;

		[Token(Token = "0x4004B5E")]
		private const float RefPeakX = 150f;

		[Token(Token = "0x4004B5F")]
		private const float RefPeakY = 400f;

		[Token(Token = "0x4004B60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly GlowPathTemplate Glow2Template;

		[Token(Token = "0x4004B61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly GlowPathTemplate Glow3Template;

		[Token(Token = "0x4004B62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly GlowPathTemplate Glow1Template;

		[Token(Token = "0x4004B63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("飞行弧线")]
		[Tooltip("飞行途中路径中间偏移：X=左右展开幅度（150=原 Animation），Y=中间额外抬升（相对 flyDelta.y）")]
		private Vector2 _midPathOffset;

		[Token(Token = "0x4004B64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform _flyRoot;

		[Token(Token = "0x4004B65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RectTransform _donghuaRoot;

		[Token(Token = "0x4004B66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform _glow1Rect;

		[Token(Token = "0x4004B67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _glow2Rect;

		[Token(Token = "0x4004B68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _glow3Rect;

		[Token(Token = "0x4004B69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Animation _legacyAnimation;

		[Token(Token = "0x4004B6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _restoreParent;

		[Token(Token = "0x4004B6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _restoreSiblingIndex;

		[Token(Token = "0x4004B6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _playToken;

		[Token(Token = "0x6003C95")]
		[Address(RVA = "0x41498A4", Offset = "0x41458A4", VA = "0x41498A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6003C96")]
		[Address(RVA = "0x4147C94", Offset = "0x4143C94", VA = "0x4147C94")]
		[AsyncStateMachine(typeof(_003CPlayAsync_003Ed__18))]
		public UniTask PlayAsync(Vector3 startWorldPos, Vector3 endWorldPos, RectTransform overlayParent)
		{
			return default;
		}

		[Token(Token = "0x6003C97")]
		[Address(RVA = "0x4149C18", Offset = "0x4145C18", VA = "0x4149C18")]
		[ContextMenu("播放预览动画")]
		public void PlayPreview()
		{
		}

		[Token(Token = "0x6003C98")]
		[Address(RVA = "0x4149C2C", Offset = "0x4145C2C", VA = "0x4149C2C")]
		[AsyncStateMachine(typeof(_003CPlayPreviewAsync_003Ed__20))]
		public UniTask PlayPreviewAsync()
		{
			return default;
		}

		[Token(Token = "0x6003C99")]
		[Address(RVA = "0x4146FD8", Offset = "0x4142FD8", VA = "0x4146FD8")]
		public void Stop()
		{
		}

		[Token(Token = "0x6003C9A")]
		[Address(RVA = "0x4149DF8", Offset = "0x4145DF8", VA = "0x4149DF8")]
		private bool TryResolveGameplayFlyContext(out Vector3 startWorld, out Vector3 endWorld, out RectTransform overlay)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventurePaoQuanFlyEffectView.TryResolveGameplayFlyContext RVA=0x4149DF8 Token=0x6003C9A");
}

		[Token(Token = "0x6003C9B")]
		[Address(RVA = "0x4149F80", Offset = "0x4145F80", VA = "0x4149F80")]
		[AsyncStateMachine(typeof(_003CPlayInternalAsync_003Ed__23))]
		private UniTask PlayInternalAsync(RectTransform overlayParent, Vector2 startLocal, Vector2 endLocal)
		{
			return default;
		}

		[Token(Token = "0x6003C9C")]
		[Address(RVA = "0x41498BC", Offset = "0x41458BC", VA = "0x41498BC")]
		private void EnsureReferences()
		{
		}

		[Token(Token = "0x6003C9D")]
		[Address(RVA = "0x414A048", Offset = "0x4146048", VA = "0x414A048")]
		private static RectTransform FindGlowRect(Transform root, string name)
		{
			return null;
		}

		[Token(Token = "0x6003C9E")]
		[Address(RVA = "0x4149B80", Offset = "0x4145B80", VA = "0x4149B80")]
		private void DisableLegacyAnimation()
		{
		}

		[Token(Token = "0x6003C9F")]
		[Address(RVA = "0x414A100", Offset = "0x4146100", VA = "0x414A100")]
		private static bool TryResolveOverlayLocalPoints(RectTransform overlay, Vector3 startWorld, Vector3 endWorld, out Vector2 startLocal, out Vector2 endLocal)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventurePaoQuanFlyEffectView.TryResolveOverlayLocalPoints RVA=0x414A100 Token=0x6003C9F");
}

		[Token(Token = "0x6003CA0")]
		[Address(RVA = "0x414A338", Offset = "0x4146338", VA = "0x414A338")]
		private void PrepareFlyTransformLocal(RectTransform overlayParent, Vector2 startLocal)
		{
		}

		[Token(Token = "0x6003CA1")]
		[Address(RVA = "0x4149D30", Offset = "0x4145D30", VA = "0x4149D30")]
		private void RestoreTransform()
		{
		}

		[Token(Token = "0x6003CA2")]
		[Address(RVA = "0x414A44C", Offset = "0x414644C", VA = "0x414A44C")]
		private void ResetChildGlowTransforms()
		{
		}

		[Token(Token = "0x6003CA3")]
		[Address(RVA = "0x414A4B4", Offset = "0x41464B4", VA = "0x414A4B4")]
		private static void ResetGlowRect(RectTransform rect)
		{
		}

		[Token(Token = "0x6003CA4")]
		[Address(RVA = "0x414A578", Offset = "0x4146578", VA = "0x414A578")]
		private void SetupInitialChildGlowStates()
		{
		}

		[Token(Token = "0x6003CA5")]
		[Address(RVA = "0x414A68C", Offset = "0x414668C", VA = "0x414A68C")]
		private void AppendChildGlowBezierTweens(Sequence sequence, Vector2 flyDelta)
		{
		}

		[Token(Token = "0x6003CA6")]
		[Address(RVA = "0x414AA2C", Offset = "0x4146A2C", VA = "0x414AA2C")]
		private void InsertGlowBezier(Sequence sequence, RectTransform rect, GlowPathTemplate template, Vector2 flyDelta)
		{
		}

		[Token(Token = "0x6003CA7")]
		[Address(RVA = "0x414AC1C", Offset = "0x4146C1C", VA = "0x414AC1C")]
		private Vector2 MapPathOffset(Vector2 original, Vector2 flyDelta)
		{
			return default;
		}

		[Token(Token = "0x6003CA8")]
		[Address(RVA = "0x414AE98", Offset = "0x4146E98", VA = "0x414AE98")]
		private static Vector2 EvaluateCubicBezier(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, float t)
		{
			return default;
		}

		[Token(Token = "0x6003CA9")]
		[Address(RVA = "0x414AC5C", Offset = "0x4146C5C", VA = "0x414AC5C")]
		private static Tween CreateCubicBezierTween(RectTransform rect, float duration, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			return null;
		}

		[Token(Token = "0x6003CAA")]
		[Address(RVA = "0x414AF0C", Offset = "0x4146F0C", VA = "0x414AF0C")]
		private void HideAllChildGlows()
		{
		}

		[Token(Token = "0x6003CAB")]
		[Address(RVA = "0x414A5EC", Offset = "0x41465EC", VA = "0x414A5EC")]
		private static void SetGlowActive(RectTransform glow, bool active)
		{
		}

		[Token(Token = "0x6003CAC")]
		[Address(RVA = "0x4149CB8", Offset = "0x4145CB8", VA = "0x4149CB8")]
		private void KillAllFlyTweens()
		{
		}

		[Token(Token = "0x6003CAD")]
		[Address(RVA = "0x414AF80", Offset = "0x4146F80", VA = "0x414AF80")]
		private void RestartAllParticles()
		{
		}

		[Token(Token = "0x6003CAE")]
		[Address(RVA = "0x414B034", Offset = "0x4147034", VA = "0x414B034")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6003CAF")]
		[Address(RVA = "0x414B044", Offset = "0x4147044", VA = "0x414B044")]
		public MysteryAdventurePaoQuanFlyEffectView()
		{
		}
	}
}
