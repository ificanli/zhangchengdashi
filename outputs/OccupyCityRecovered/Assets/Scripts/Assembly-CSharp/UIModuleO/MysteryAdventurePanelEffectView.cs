using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000A1D")]
	public class MysteryAdventurePanelEffectView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A1E")]
		[CompilerGenerated]
		private struct _003CHideBoardCellEffectAfterDelayAsync_003Ed__25 : IAsyncStateMachine
		{
			[Token(Token = "0x4004B06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004B07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004B08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventurePanelEffectView _003C_003E4__this;

			[Token(Token = "0x4004B09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int token;

			[Token(Token = "0x4004B0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject effect;

			[Token(Token = "0x4004B0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003C46")]
			[Address(RVA = "0x41471FC", Offset = "0x41431FC", VA = "0x41471FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C47")]
			[Address(RVA = "0x41475AC", Offset = "0x41435AC", VA = "0x41475AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A1F")]
		[CompilerGenerated]
		private struct _003CHideLapEffectAfterDelayAsync_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x4004B0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004B0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004B0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventurePanelEffectView _003C_003E4__this;

			[Token(Token = "0x4004B0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanelEffectType effectType;

			[Token(Token = "0x4004B10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int token;

			[Token(Token = "0x4004B11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003C48")]
			[Address(RVA = "0x41475B8", Offset = "0x41435B8", VA = "0x41475B8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C49")]
			[Address(RVA = "0x4147954", Offset = "0x4143954", VA = "0x4147954", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A20")]
		[CompilerGenerated]
		private struct _003CPlayLapEnergyFlyAsync_003Ed__39 : IAsyncStateMachine
		{
			[Token(Token = "0x4004B12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004B13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004B14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventurePaoQuanFlyEffectView flyEffect;

			[Token(Token = "0x4004B15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 startWorldPos;

			[Token(Token = "0x4004B16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 endWorldPos;

			[Token(Token = "0x4004B17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RectTransform overlay;

			[Token(Token = "0x4004B18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int token;

			[Token(Token = "0x4004B19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public MysteryAdventurePanelEffectView _003C_003E4__this;

			[Token(Token = "0x4004B1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003C4A")]
			[Address(RVA = "0x4147960", Offset = "0x4143960", VA = "0x4147960", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C4B")]
			[Address(RVA = "0x4147D6C", Offset = "0x4143D6C", VA = "0x4147D6C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A21")]
		[CompilerGenerated]
		private struct _003CPlayLapLevelUpgradeEffectAndWaitAsync_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x4004B1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004B1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004B1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanelEffectView _003C_003E4__this;

			[Token(Token = "0x4004B1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x4004B1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int _003Ctoken_003E5__2;

			[Token(Token = "0x4004B20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003C4C")]
			[Address(RVA = "0x4147D78", Offset = "0x4143D78", VA = "0x4147D78", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C4D")]
			[Address(RVA = "0x4148254", Offset = "0x4144254", VA = "0x4148254", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A22")]
		[CompilerGenerated]
		private struct _003CPlayLapProgressGlowEffectAndWaitAsync_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4004B21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004B22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004B23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanelEffectView _003C_003E4__this;

			[Token(Token = "0x4004B24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x4004B25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int _003Ctoken_003E5__2;

			[Token(Token = "0x4004B26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003C4E")]
			[Address(RVA = "0x4148260", Offset = "0x4144260", VA = "0x4148260", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C4F")]
			[Address(RVA = "0x414873C", Offset = "0x414473C", VA = "0x414873C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A23")]
		[CompilerGenerated]
		private struct _003CPlayLapProgressIncreaseEffectAndWaitAsync_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4004B27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004B28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004B29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventurePanelEffectView _003C_003E4__this;

			[Token(Token = "0x4004B2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x4004B2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int _003Ctoken_003E5__2;

			[Token(Token = "0x4004B2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003C50")]
			[Address(RVA = "0x4148748", Offset = "0x4144748", VA = "0x4148748", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003C51")]
			[Address(RVA = "0x41490C4", Offset = "0x41450C4", VA = "0x41490C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004AFD")]
		private const float LapUpgradeEffectDuration = 0.5f;

		[Token(Token = "0x4004AFE")]
		private const float BoardCellEffectDuration = 3f;

		[Token(Token = "0x4004AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MysteryAdventurePanelEffectPrefabs _prefabs;

		[Token(Token = "0x4004B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MysteryAdventurePanelView _view;

		[Token(Token = "0x4004B01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MysteryAdventureBoardView _boardView;

		[Token(Token = "0x4004B02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _lapProgressEffectToken;

		[Token(Token = "0x4004B03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _lapUpgradeEffectToken;

		[Token(Token = "0x4004B04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _boardCellEffectToken;

		[Token(Token = "0x4004B05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly Dictionary<int, GameObject> _glowByCellId;

		[Token(Token = "0x6003C26")]
		[Address(RVA = "0x4145DE0", Offset = "0x4141DE0", VA = "0x4145DE0")]
		public void Initialize(MysteryAdventurePanelView view, [Optional] MysteryAdventureBoardView boardView)
		{
		}

		[Token(Token = "0x6003C27")]
		[Address(RVA = "0x4146108", Offset = "0x4142108", VA = "0x4146108")]
		public void HideBoardCellEffects()
		{
		}

		[Token(Token = "0x6003C28")]
		[Address(RVA = "0x4146218", Offset = "0x4142218", VA = "0x4146218")]
		public void RefreshBoardCellEffects(int landingCellId)
		{
		}

		[Token(Token = "0x6003C29")]
		[Address(RVA = "0x41463DC", Offset = "0x41423DC", VA = "0x41463DC")]
		public void SetBoardView(MysteryAdventureBoardView boardView)
		{
		}

		[Token(Token = "0x6003C2A")]
		[Address(RVA = "0x41463E4", Offset = "0x41423E4", VA = "0x41463E4")]
		public void HideLapUiEffects()
		{
		}

		[Token(Token = "0x6003C2B")]
		[Address(RVA = "0x41465E4", Offset = "0x41425E4", VA = "0x41465E4")]
		public bool TryGetLapEnergyFlyPlayContext(out Vector3 startWorldPos, out Vector3 endWorldPos, out RectTransform overlay)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventurePanelEffectView.TryGetLapEnergyFlyPlayContext RVA=0x41465E4 Token=0x6003C2B");
}

		[Token(Token = "0x6003C2C")]
		[Address(RVA = "0x4146818", Offset = "0x4142818", VA = "0x4146818")]
		public void PlayLapProgressIncreaseEffect()
		{
		}

		[Token(Token = "0x6003C2D")]
		[Address(RVA = "0x4146B50", Offset = "0x4142B50", VA = "0x4146B50")]
		public void PlayLapLevelUpgradeEffect()
		{
		}

		[Token(Token = "0x6003C2E")]
		[Address(RVA = "0x4142400", Offset = "0x413E400", VA = "0x4142400")]
		[AsyncStateMachine(typeof(_003CPlayLapLevelUpgradeEffectAndWaitAsync_003Ed__17))]
		public UniTask PlayLapLevelUpgradeEffectAndWaitAsync([Optional] CancellationToken cancellationToken)
		{
			return default;
		}

		[Token(Token = "0x6003C2F")]
		[Address(RVA = "0x4142368", Offset = "0x413E368", VA = "0x4142368")]
		[AsyncStateMachine(typeof(_003CPlayLapProgressIncreaseEffectAndWaitAsync_003Ed__18))]
		public UniTask PlayLapProgressIncreaseEffectAndWaitAsync([Optional] CancellationToken cancellationToken)
		{
			return default;
		}

		[Token(Token = "0x6003C30")]
		[Address(RVA = "0x4146B5C", Offset = "0x4142B5C", VA = "0x4146B5C")]
		[AsyncStateMachine(typeof(_003CPlayLapProgressGlowEffectAndWaitAsync_003Ed__19))]
		private UniTask PlayLapProgressGlowEffectAndWaitAsync([Optional] CancellationToken cancellationToken)
		{
			return default;
		}

		[Token(Token = "0x6003C31")]
		[Address(RVA = "0x4146BF4", Offset = "0x4142BF4", VA = "0x4146BF4")]
		public void SetAutoRollRingActive(bool active)
		{
		}

		[Token(Token = "0x6003C32")]
		[Address(RVA = "0x4146C04", Offset = "0x4142C04", VA = "0x4146C04")]
		public void OnPanelHide()
		{
		}

		[Token(Token = "0x6003C33")]
		[Address(RVA = "0x4146C08", Offset = "0x4142C08", VA = "0x4146C08")]
		public void ClearAll()
		{
		}

		[Token(Token = "0x6003C34")]
		[Address(RVA = "0x4146984", Offset = "0x4142984", VA = "0x4146984")]
		private void PlayTimedLapEffect(MysteryAdventurePanelEffectType effectType, ref int tokenField)
		{
		}

		[Token(Token = "0x6003C35")]
		[Address(RVA = "0x4146D74", Offset = "0x4142D74", VA = "0x4146D74")]
		[AsyncStateMachine(typeof(_003CHideLapEffectAfterDelayAsync_003Ed__24))]
		private UniTaskVoid HideLapEffectAfterDelayAsync(MysteryAdventurePanelEffectType effectType, int token)
		{
			return default;
		}

		[Token(Token = "0x6003C36")]
		[Address(RVA = "0x4146348", Offset = "0x4142348", VA = "0x4146348")]
		[AsyncStateMachine(typeof(_003CHideBoardCellEffectAfterDelayAsync_003Ed__25))]
		private UniTaskVoid HideBoardCellEffectAfterDelayAsync(GameObject effect, int token)
		{
			return default;
		}

		[Token(Token = "0x6003C37")]
		[Address(RVA = "0x414611C", Offset = "0x414211C", VA = "0x414611C")]
		private void SetBoardEffectsActive(bool active)
		{
		}

		[Token(Token = "0x6003C38")]
		[Address(RVA = "0x4145DFC", Offset = "0x4141DFC", VA = "0x4145DFC")]
		private void RebuildCellGlowMap()
		{
		}

		[Token(Token = "0x6003C39")]
		[Address(RVA = "0x4146E00", Offset = "0x4142E00", VA = "0x4146E00")]
		private static int ResolveBindingCellId(MysteryAdventureRuinsGlowBinding binding, Dictionary<int, int> buildIdUsage)
		{
			return default;
		}

		[Token(Token = "0x6003C3A")]
		[Address(RVA = "0x4146C40", Offset = "0x4142C40", VA = "0x4146C40")]
		private void SetAllEffectsActive(bool active)
		{
		}

		[Token(Token = "0x6003C3B")]
		[Address(RVA = "0x41464E4", Offset = "0x41424E4", VA = "0x41464E4")]
		private void SetEffectActive(MysteryAdventurePanelEffectType effectType, bool active, bool restartParticles = true)
		{
		}

		[Token(Token = "0x6003C3C")]
		[Address(RVA = "0x4146CD8", Offset = "0x4142CD8", VA = "0x4146CD8")]
		private static void ActivateEffect(GameObject effect)
		{
		}

		[Token(Token = "0x6003C3D")]
		[Address(RVA = "0x41462D4", Offset = "0x41422D4", VA = "0x41462D4")]
		private void ActivateEffectAtCell(GameObject effect)
		{
		}

		[Token(Token = "0x6003C3E")]
		[Address(RVA = "0x4146F20", Offset = "0x4142F20", VA = "0x4146F20")]
		private static void RestartParticles(GameObject effectRoot)
		{
		}

		[Token(Token = "0x6003C3F")]
		[Address(RVA = "0x4146C9C", Offset = "0x4142C9C", VA = "0x4146C9C")]
		private GameObject GetEffect(MysteryAdventurePanelEffectType effectType)
		{
			return null;
		}

		[Token(Token = "0x6003C40")]
		[Address(RVA = "0x414602C", Offset = "0x414202C", VA = "0x414602C")]
		private MysteryAdventurePaoQuanFlyEffectView EnsureLapEnergyFlyEffect()
		{
			return null;
		}

		[Token(Token = "0x6003C41")]
		[Address(RVA = "0x414642C", Offset = "0x414242C", VA = "0x414642C")]
		private void StopLapEnergyFlyEffect()
		{
		}

		[Token(Token = "0x6003C42")]
		[Address(RVA = "0x41466C0", Offset = "0x41426C0", VA = "0x41466C0")]
		private bool TryResolveLapEnergyFlyPositions(out Vector3 startWorldPos, out Vector3 endWorldPos)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventurePanelEffectView.TryResolveLapEnergyFlyPositions RVA=0x41466C0 Token=0x6003C42");
}

		[Token(Token = "0x6003C43")]
		[Address(RVA = "0x414701C", Offset = "0x414301C", VA = "0x414701C")]
		private Vector3? ResolveLapProgressBarCenterWorldPos()
		{
			return null;
		}

		[Token(Token = "0x6003C44")]
		[Address(RVA = "0x4146A6C", Offset = "0x4142A6C", VA = "0x4146A6C")]
		[AsyncStateMachine(typeof(_003CPlayLapEnergyFlyAsync_003Ed__39))]
		private UniTaskVoid PlayLapEnergyFlyAsync(MysteryAdventurePaoQuanFlyEffectView flyEffect, Vector3 startWorldPos, Vector3 endWorldPos, RectTransform overlay, int token)
		{
			return default;
		}

		[Token(Token = "0x6003C45")]
		[Address(RVA = "0x4147180", Offset = "0x4143180", VA = "0x4147180")]
		public MysteryAdventurePanelEffectView()
		{
		}
	}
}
