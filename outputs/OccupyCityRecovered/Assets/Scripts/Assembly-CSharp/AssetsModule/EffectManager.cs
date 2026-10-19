using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace AssetsModule
{
	[Token(Token = "0x2000639")]
	public class EffectManager : ManagerBase<EffectManager>
	{
		[Token(Token = "0x200063A")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			[Token(Token = "0x40032D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string endEffectAssetPath;

			[Token(Token = "0x40032D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public EffectManager _003C_003E4__this;

			[Token(Token = "0x40032D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RectTransform uiTarget;

			[Token(Token = "0x40032D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action onArrived;

			[Token(Token = "0x40032D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject effectGo;

			[Token(Token = "0x60020E4")]
			[Address(RVA = "0x3F1545C", Offset = "0x3F1145C", VA = "0x3F1545C")]
			public _003C_003Ec__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60020E5")]
			[Address(RVA = "0x3F15464", Offset = "0x3F11464", VA = "0x3F15464")]
			internal void _003CShowEffectFlyToUI_003Eb__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200063B")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x40032D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40032DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40032DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public EffectManager _003C_003E4__this;

			[Token(Token = "0x60020E6")]
			[Address(RVA = "0x3F15520", Offset = "0x3F11520", VA = "0x3F15520", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60020E7")]
			[Address(RVA = "0x3F15748", Offset = "0x3F11748", VA = "0x3F15748", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200063C")]
		[CompilerGenerated]
		private struct _003CPrewarmBattleEffectAsync_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x40032DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40032DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40032DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string assetPath;

			[Token(Token = "0x40032DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectManager _003C_003E4__this;

			[Token(Token = "0x40032E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<string, int, double> onItemPrewarmed;

			[Token(Token = "0x40032E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003Ccount_003E5__2;

			[Token(Token = "0x40032E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private long _003CstartTicks_003E5__3;

			[Token(Token = "0x40032E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60020E8")]
			[Address(RVA = "0x3F15754", Offset = "0x3F11754", VA = "0x3F15754", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60020E9")]
			[Address(RVA = "0x3F15C0C", Offset = "0x3F11C0C", VA = "0x3F15C0C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200063D")]
		[CompilerGenerated]
		private struct _003CPrewarmBattleEffectsAsync_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x40032E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40032E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40032E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IEnumerable<string> assetPaths;

			[Token(Token = "0x40032E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectManager _003C_003E4__this;

			[Token(Token = "0x40032E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<string, int, double> onItemPrewarmed;

			[Token(Token = "0x40032E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60020EA")]
			[Address(RVA = "0x3F15C18", Offset = "0x3F11C18", VA = "0x3F15C18", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60020EB")]
			[Address(RVA = "0x3F16264", Offset = "0x3F12264", VA = "0x3F16264", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200063E")]
		[CompilerGenerated]
		private struct _003CPrewarmEffectAsync_003Ed__22 : IAsyncStateMachine
		{
			[Token(Token = "0x40032EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40032EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40032EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string assetPath;

			[Token(Token = "0x40032ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int initialSize;

			[Token(Token = "0x40032EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public EffectManager _003C_003E4__this;

			[Token(Token = "0x40032EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60020EC")]
			[Address(RVA = "0x3F16270", Offset = "0x3F12270", VA = "0x3F16270", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60020ED")]
			[Address(RVA = "0x3F16800", Offset = "0x3F12800", VA = "0x3F16800", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200063F")]
		[CompilerGenerated]
		private struct _003CShowEffect_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40032F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40032F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40032F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string assetPath;

			[Token(Token = "0x40032F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public EffectManager _003C_003E4__this;

			[Token(Token = "0x40032F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float delayRecycleTime;

			[Token(Token = "0x40032F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 position;

			[Token(Token = "0x40032F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 scale;

			[Token(Token = "0x40032F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60020EE")]
			[Address(RVA = "0x3F1680C", Offset = "0x3F1280C", VA = "0x3F1680C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60020EF")]
			[Address(RVA = "0x3F16F50", Offset = "0x3F12F50", VA = "0x3F16F50", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000640")]
		[CompilerGenerated]
		private struct _003CShowEffectFlyToUI_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x40032F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40032F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40032FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string endEffectAssetPath;

			[Token(Token = "0x40032FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public EffectManager _003C_003E4__this;

			[Token(Token = "0x40032FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public RectTransform uiTarget;

			[Token(Token = "0x40032FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action onArrived;

			[Token(Token = "0x40032FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public RectTransform uiCanvasRoot;

			[Token(Token = "0x40032FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string uiEffectPrefabPath;

			[Token(Token = "0x4003300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

			[Token(Token = "0x4003301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 worldStartPos;

			[Token(Token = "0x4003302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public float duration;

			[Token(Token = "0x4003303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60020F0")]
			[Address(RVA = "0x3F16F5C", Offset = "0x3F12F5C", VA = "0x3F16F5C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60020F1")]
			[Address(RVA = "0x3F176E4", Offset = "0x3F136E4", VA = "0x3F176E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000641")]
		[CompilerGenerated]
		private struct _003CShowLoopEffect_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4003304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform trans;

			[Token(Token = "0x4003307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string assetPath;

			[Token(Token = "0x4003308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public EffectManager _003C_003E4__this;

			[Token(Token = "0x4003309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float delayRecycleTime;

			[Token(Token = "0x400330A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public LoopEffectRuntimeOverride runtimeOverride;

			[Token(Token = "0x400330B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 scale;

			[Token(Token = "0x400330C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60020F2")]
			[Address(RVA = "0x3F176F0", Offset = "0x3F136F0", VA = "0x3F176F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60020F3")]
			[Address(RVA = "0x3F17F7C", Offset = "0x3F13F7C", VA = "0x3F17F7C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000642")]
		[CompilerGenerated]
		private struct _003CShowLoopEffect_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x400330D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400330E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400330F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform trans;

			[Token(Token = "0x4003310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string assetPath;

			[Token(Token = "0x4003311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public EffectManager _003C_003E4__this;

			[Token(Token = "0x4003312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public LoopEffectRuntimeOverride runtimeOverride;

			[Token(Token = "0x4003313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 scale;

			[Token(Token = "0x4003314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Func<bool> endCondition;

			[Token(Token = "0x4003315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60020F4")]
			[Address(RVA = "0x3F17F88", Offset = "0x3F13F88", VA = "0x3F17F88", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60020F5")]
			[Address(RVA = "0x3F18810", Offset = "0x3F14810", VA = "0x3F18810", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000643")]
		[CompilerGenerated]
		private struct _003CWaitLoopEffectEnd_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4003316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Func<bool> endCondition;

			[Token(Token = "0x4003319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject effectGo;

			[Token(Token = "0x400331A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60020F6")]
			[Address(RVA = "0x3F1881C", Offset = "0x3F1481C", VA = "0x3F1881C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60020F7")]
			[Address(RVA = "0x3F18B7C", Offset = "0x3F14B7C", VA = "0x3F18B7C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40032CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly HashSet<string> BattleHitEffects;

		[Token(Token = "0x40032CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly HashSet<string> BattleDeathEffects;

		[Token(Token = "0x40032CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly HashSet<string> BattleSpawnEffects;

		[Token(Token = "0x40032CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly HashSet<string> BattleSkillEffects;

		[Token(Token = "0x40032CF")]
		private const int BattleHitEffectPrewarmCount = 8;

		[Token(Token = "0x40032D0")]
		private const int BattleDeathEffectPrewarmCount = 4;

		[Token(Token = "0x40032D1")]
		private const int BattleSpawnEffectPrewarmCount = 4;

		[Token(Token = "0x40032D2")]
		private const int BattleSkillEffectPrewarmCount = 2;

		[Token(Token = "0x40032D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<string, GameObject> effectPrefabDict;

		[Token(Token = "0x60020D4")]
		[Address(RVA = "0x3F1415C", Offset = "0x3F1015C", VA = "0x3F1415C")]
		private static bool ShouldBlockBattleEffect(string assetPath)
		{
			return default;
		}

		[Token(Token = "0x60020D5")]
		[Address(RVA = "0x3F14358", Offset = "0x3F10358", VA = "0x3F14358")]
		public static Vector2 WorldPositionToCanvasLocal(Vector3 worldPos, RectTransform canvasRectTransform)
		{
			return default;
		}

		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x3F14360", Offset = "0x3F10360", VA = "0x3F14360")]
		[AsyncStateMachine(typeof(_003CShowEffect_003Ed__11))]
		public void ShowEffect(string assetPath, Vector3 position, [Optional] Vector3 scale, float delayRecycleTime = 1f)
		{
		}

		[Token(Token = "0x60020D7")]
		[Address(RVA = "0x3F1444C", Offset = "0x3F1044C", VA = "0x3F1444C")]
		[AsyncStateMachine(typeof(_003CShowLoopEffect_003Ed__12))]
		public void ShowLoopEffect(string assetPath, Transform trans, float delayRecycleTime, [Optional] Vector3 scale, [Optional] LoopEffectRuntimeOverride runtimeOverride)
		{
		}

		[Token(Token = "0x60020D8")]
		[Address(RVA = "0x3F14534", Offset = "0x3F10534", VA = "0x3F14534")]
		[AsyncStateMachine(typeof(_003CShowLoopEffect_003Ed__13))]
		public void ShowLoopEffect(string assetPath, Transform trans, Func<bool> endCondition, [Optional] Vector3 scale, [Optional] LoopEffectRuntimeOverride runtimeOverride)
		{
		}

		[Token(Token = "0x60020D9")]
		[Address(RVA = "0x3F14618", Offset = "0x3F10618", VA = "0x3F14618")]
		private void ApplyLoopEffectRuntimeOverride(GameObject effectGo, LoopEffectRuntimeOverride runtimeOverride)
		{
		}

		[Token(Token = "0x60020DA")]
		[Address(RVA = "0x3F1491C", Offset = "0x3F1091C", VA = "0x3F1491C")]
		[AsyncStateMachine(typeof(_003CWaitLoopEffectEnd_003Ed__15))]
		private UniTaskVoid WaitLoopEffectEnd(GameObject effectGo, Func<bool> endCondition)
		{
			return default;
		}

		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x3F149A0", Offset = "0x3F109A0", VA = "0x3F149A0")]
		[AsyncStateMachine(typeof(_003CShowEffectFlyToUI_003Ed__16))]
		public void ShowEffectFlyToUI(string uiEffectPrefabPath, Vector3 worldStartPos, RectTransform uiCanvasRoot, RectTransform uiTarget, [Optional][DefaultParameterValue(0.6f)] float duration, [Optional] string endEffectAssetPath, [Optional] Action onArrived)
		{
		}

		[Token(Token = "0x60020DC")]
		[Address(RVA = "0x3F14A8C", Offset = "0x3F10A8C", VA = "0x3F14A8C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__17))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x3F14B10", Offset = "0x3F10B10", VA = "0x3F14B10")]
		[AsyncStateMachine(typeof(_003CPrewarmBattleEffectsAsync_003Ed__18))]
		public UniTask PrewarmBattleEffectsAsync(IEnumerable<string> assetPaths, [Optional] Action<string, int, double> onItemPrewarmed)
		{
			return default;
		}

		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x3F14BB0", Offset = "0x3F10BB0", VA = "0x3F14BB0")]
		[AsyncStateMachine(typeof(_003CPrewarmBattleEffectAsync_003Ed__19))]
		private UniTask PrewarmBattleEffectAsync(string assetPath, Action<string, int, double> onItemPrewarmed)
		{
			return default;
		}

		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x3F14C54", Offset = "0x3F10C54", VA = "0x3F14C54")]
		private static int GetBattleEffectPrewarmCount(string assetPath)
		{
			return default;
		}

		[Token(Token = "0x60020E0")]
		[Address(RVA = "0x3F14D7C", Offset = "0x3F10D7C", VA = "0x3F14D7C")]
		private static double GetElapsedMilliseconds(long startTicks)
		{
			return default;
		}

		[Token(Token = "0x60020E1")]
		[Address(RVA = "0x3F14DFC", Offset = "0x3F10DFC", VA = "0x3F14DFC")]
		[AsyncStateMachine(typeof(_003CPrewarmEffectAsync_003Ed__22))]
		public UniTask PrewarmEffectAsync(string assetPath, int initialSize)
		{
			return default;
		}

		[Token(Token = "0x60020E2")]
		[Address(RVA = "0x3F14EA4", Offset = "0x3F10EA4", VA = "0x3F14EA4")]
		public EffectManager()
		{
		}
	}
}
