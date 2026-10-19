using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x2000048")]
	[ExecuteAlways]
	[AddComponentMenu("")]
	public class DrawingManager : MonoBehaviour
	{
		[Token(Token = "0x2000049")]
		private struct GizmoDrawerGroup
		{
			[Token(Token = "0x4000123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Type type;

			[Token(Token = "0x4000124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ProfilerMarker profilerMarker;

			[Token(Token = "0x4000125")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<IDrawGizmos> drawers;

			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool enabled;
		}

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DrawingData gizmos;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<GizmoDrawerGroup> gizmoDrawers;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<Type, int> gizmoDrawerIndices;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool ignoreAllDrawing;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DrawingManager _instance;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool framePassed;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int lastFrameCount;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float lastFrameTime;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int lastFilterFrame;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool actuallyEnabled;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RedrawScope previousFrameRedrawScope;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool allowRenderToRenderTextures;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public static bool drawToAllCameras;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static float lineWidthMultiplier;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CommandBuffer commandBuffer;

		[NonSerialized]
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DetectedRenderPipeline detectedRenderPipeline;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private HashSet<ScriptableRenderer> scriptableRenderersWithPass;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AlineURPRenderPassFeature renderPassFeature;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly ProfilerMarker MarkerALINE;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly ProfilerMarker MarkerCommandBuffer;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly ProfilerMarker MarkerFrameTick;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly ProfilerMarker MarkerFilterDestroyedObjects;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal static readonly ProfilerMarker MarkerRefreshSelectionCache;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly ProfilerMarker MarkerGizmosAllowed;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly ProfilerMarker MarkerDrawGizmos;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly ProfilerMarker MarkerSubmitGizmos;

		[Token(Token = "0x4000122")]
		private const float NO_DRAWING_TIMEOUT_SECS = 10f;

		[Token(Token = "0x1700001D")]
		public static DrawingManager instance
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x46E74B4", Offset = "0x46E34B4", VA = "0x46E74B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x46E7578", Offset = "0x46E3578", VA = "0x46E7578")]
		public static void Init()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x46E77A8", Offset = "0x46E37A8", VA = "0x46E77A8")]
		private void RefreshRenderPipelineMode()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x46E7900", Offset = "0x46E3900", VA = "0x46E7900")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x46E7CF4", Offset = "0x46E3CF4", VA = "0x46E7CF4")]
		private void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x46E7CF8", Offset = "0x46E3CF8", VA = "0x46E7CF8")]
		private void BeginFrameRendering(ScriptableRenderContext context, Camera[] cameras)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x46E7CFC", Offset = "0x46E3CFC", VA = "0x46E7CFC")]
		private void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x46E7E08", Offset = "0x46E3E08", VA = "0x46E7E08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x46E80EC", Offset = "0x46E40EC", VA = "0x46E80EC")]
		private void OnEditorUpdate()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x46E82BC", Offset = "0x46E42BC", VA = "0x46E82BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x46E80F8", Offset = "0x46E40F8", VA = "0x46E80F8")]
		private void CleanupIfNoCameraRendered()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x46E87A0", Offset = "0x46E47A0", VA = "0x46E87A0")]
		internal void ExecuteCustomRenderPass(ScriptableRenderContext context, Camera camera)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x46E8950", Offset = "0x46E4950", VA = "0x46E8950")]
		internal void ExecuteCustomRenderGraphPass(DrawingData.CommandBufferWrapper cmd, Camera camera)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x46E8964", Offset = "0x46E4964", VA = "0x46E8964")]
		private void EndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x46E8974", Offset = "0x46E4974", VA = "0x46E8974")]
		private void PostRender(Camera camera)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x46E82CC", Offset = "0x46E42CC", VA = "0x46E82CC")]
		private void CheckFrameTicking()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x46E883C", Offset = "0x46E483C", VA = "0x46E883C")]
		internal void SubmitFrame(Camera camera, DrawingData.CommandBufferWrapper cmd, bool usingRenderPipeline)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x46E8B3C", Offset = "0x46E4B3C", VA = "0x46E8B3C")]
		private bool ShouldDrawGizmos(UnityEngine.Object obj)
		{
			return default;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x46E84BC", Offset = "0x46E44BC", VA = "0x46E84BC")]
		private static void RemoveDestroyedGizmoDrawers()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x46E8B44", Offset = "0x46E4B44", VA = "0x46E8B44")]
		public static bool ShouldDrawGizmos(Type type)
		{
			return default;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x46E89FC", Offset = "0x46E49FC", VA = "0x46E89FC")]
		private void Submit(Camera camera, DrawingData.CommandBufferWrapper cmd, bool usingRenderPipeline, bool allowCameraDefault)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x46E9044", Offset = "0x46E5044", VA = "0x46E9044")]
		public static void Register(IDrawGizmos item)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x46E90B8", Offset = "0x46E50B8", VA = "0x46E90B8")]
		public static void Register(IDrawGizmos item, Type overrideType)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x46E8C08", Offset = "0x46E4C08", VA = "0x46E8C08")]
		private static int GetGizmoDrawerIndex(Type tp)
		{
			return default;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x46E9204", Offset = "0x46E5204", VA = "0x46E9204")]
		public static CommandBuilder GetBuilder(bool renderInGame = false)
		{
			return default;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x46E9298", Offset = "0x46E5298", VA = "0x46E9298")]
		public static CommandBuilder GetBuilder(RedrawScope redrawScope, bool renderInGame = false)
		{
			return default;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x46E9344", Offset = "0x46E5344", VA = "0x46E9344")]
		public static CommandBuilder GetBuilder(DrawingData.Hasher hasher, [Optional] RedrawScope redrawScope, bool renderInGame = false)
		{
			return default;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x46E93FC", Offset = "0x46E53FC", VA = "0x46E93FC")]
		public static bool TryDrawHasher(DrawingData.Hasher hasher, [Optional] RedrawScope redrawScope)
		{
			return default;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x46E9480", Offset = "0x46E5480", VA = "0x46E9480")]
		public static RedrawScope GetRedrawScope([Optional] GameObject associatedGameObject)
		{
			return default;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x46E9538", Offset = "0x46E5538", VA = "0x46E9538")]
		public DrawingManager()
		{
		}
	}
}
