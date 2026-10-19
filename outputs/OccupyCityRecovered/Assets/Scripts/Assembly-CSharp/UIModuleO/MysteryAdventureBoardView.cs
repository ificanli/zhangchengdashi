using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20009BA")]
	public class MysteryAdventureBoardView
	{
		[Token(Token = "0x20009BB")]
		private sealed class CellView
		{
			[Token(Token = "0x170008DF")]
			public RectTransform CellRect
			{
				[Token(Token = "0x60039EF")]
				[Address(RVA = "0x410AD04", Offset = "0x4106D04", VA = "0x410AD04")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170008E0")]
			public Image Frame
			{
				[Token(Token = "0x60039F0")]
				[Address(RVA = "0x410AD0C", Offset = "0x4106D0C", VA = "0x410AD0C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170008E1")]
			public Image Icon
			{
				[Token(Token = "0x60039F1")]
				[Address(RVA = "0x410AD14", Offset = "0x4106D14", VA = "0x410AD14")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170008E2")]
			public TextMeshProUGUI Label
			{
				[Token(Token = "0x60039F2")]
				[Address(RVA = "0x410AD1C", Offset = "0x4106D1C", VA = "0x410AD1C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60039EE")]
			[Address(RVA = "0x410A4CC", Offset = "0x41064CC", VA = "0x410A4CC")]
			public CellView(RectTransform cellRect, Image frame, Image icon, TextMeshProUGUI label)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009BC")]
		[CompilerGenerated]
		private struct _003CMoveTokenToCellAsync_003Ed__23 : IAsyncStateMachine
		{
			[Token(Token = "0x4004893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureBoardView _003C_003E4__this;

			[Token(Token = "0x4004896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int cellId;

			[Token(Token = "0x4004897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float speedMultiplier;

			[Token(Token = "0x4004898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60039F3")]
			[Address(RVA = "0x410AD24", Offset = "0x4106D24", VA = "0x410AD24", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60039F4")]
			[Address(RVA = "0x410B28C", Offset = "0x410728C", VA = "0x410B28C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009BD")]
		[CompilerGenerated]
		private struct _003CPlayMoveAnimationAsync_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4004899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400489A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400489B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureBoardView _003C_003E4__this;

			[Token(Token = "0x400489C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int fromCellId;

			[Token(Token = "0x400489D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IReadOnlyList<int> pathCellIds;

			[Token(Token = "0x400489E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float speedMultiplier;

			[Token(Token = "0x400489F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float _003Cspeed_003E5__2;

			[Token(Token = "0x40048A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x40048A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int _003CcellId_003E5__4;

			[Token(Token = "0x40048A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60039F5")]
			[Address(RVA = "0x410B298", Offset = "0x4107298", VA = "0x410B298", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60039F6")]
			[Address(RVA = "0x410BA94", Offset = "0x4107A94", VA = "0x410BA94", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009BE")]
		[CompilerGenerated]
		private struct _003CPlayTokenJumpAsync_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x40048A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40048A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40048A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureBoardView _003C_003E4__this;

			[Token(Token = "0x40048A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float speedMultiplier;

			[Token(Token = "0x40048A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 targetWorldPos;

			[Token(Token = "0x40048A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float jumpPower;

			[Token(Token = "0x40048A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private RectTransform _003Ctoken_003E5__2;

			[Token(Token = "0x40048AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 _003CbaseScale_003E5__3;

			[Token(Token = "0x40048AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60039F7")]
			[Address(RVA = "0x410BAA0", Offset = "0x4107AA0", VA = "0x410BAA0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60039F8")]
			[Address(RVA = "0x410C150", Offset = "0x4108150", VA = "0x410C150", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly MysteryAdventurePanelView _view;

		[Token(Token = "0x4004885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Sprite _playerIconFront;

		[Token(Token = "0x4004886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Sprite _playerIconBack;

		[Token(Token = "0x4004887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<int, CellView> _cellViews;

		[Token(Token = "0x4004888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _isAnimating;

		[Token(Token = "0x4004889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool _playerFaceFront;

		[Token(Token = "0x400488A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Action _onLapProgressReachedStart;

		[Token(Token = "0x400488B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _tokenBaseScaleCaptured;

		[Token(Token = "0x400488C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 _tokenBaseScale;

		[Token(Token = "0x400488D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _iconBaseScaleCaptured;

		[Token(Token = "0x400488E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _iconBaseScale;

		[Token(Token = "0x170008DD")]
		public bool IsAnimating
		{
			[Token(Token = "0x60039D9")]
			[Address(RVA = "0x4109BB4", Offset = "0x4105BB4", VA = "0x4109BB4")]
			get
			{
				return _isAnimating;
			}
		}

		[Token(Token = "0x170008DE")]
		private MysteryAdventureBoardMoveSettings MoveSettings
		{
			[Token(Token = "0x60039DA")]
			[Address(RVA = "0x4109BBC", Offset = "0x4105BBC", VA = "0x4109BBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60039DB")]
		[Address(RVA = "0x4109BD8", Offset = "0x4105BD8", VA = "0x4109BD8")]
		public MysteryAdventureBoardView(MysteryAdventurePanelView view, MysteryAdventureUiAssets assets, [Optional] Action onLapProgressReachedStart)
		{
		}

		[Token(Token = "0x60039DC")]
		[Address(RVA = "0x4109DCC", Offset = "0x4105DCC", VA = "0x4109DCC")]
		public void RefreshBoard(int currentCellId, int lapExp, bool refreshLapProgress = true)
		{
		}

		[Token(Token = "0x60039DD")]
		[Address(RVA = "0x410A1C8", Offset = "0x41061C8", VA = "0x410A1C8")]
		public void StopAnimation()
		{
		}

		[Token(Token = "0x60039DE")]
		[Address(RVA = "0x410A268", Offset = "0x4106268", VA = "0x410A268")]
		[AsyncStateMachine(typeof(_003CPlayMoveAnimationAsync_003Ed__18))]
		public UniTask PlayMoveAnimationAsync(int fromCellId, IReadOnlyList<int> pathCellIds, float speedMultiplier = 1f)
		{
			return default;
		}

		[Token(Token = "0x60039DF")]
		[Address(RVA = "0x410A320", Offset = "0x4106320", VA = "0x410A320")]
		public void RebindCells()
		{
		}

		[Token(Token = "0x60039E0")]
		[Address(RVA = "0x4109D24", Offset = "0x4105D24", VA = "0x4109D24")]
		private void BindCellsFromView(MysteryAdventurePanelView view)
		{
		}

		[Token(Token = "0x60039E1")]
		[Address(RVA = "0x410A328", Offset = "0x4106328", VA = "0x410A328")]
		private void RegisterCellViews(MysteryAdventureBoardCellView[] cells)
		{
		}

		[Token(Token = "0x60039E2")]
		[Address(RVA = "0x410A1BC", Offset = "0x41061BC", VA = "0x410A1BC")]
		private void UpdateCenterPanel(int lapExp)
		{
		}

		[Token(Token = "0x60039E3")]
		[Address(RVA = "0x410A50C", Offset = "0x410650C", VA = "0x410A50C")]
		[AsyncStateMachine(typeof(_003CMoveTokenToCellAsync_003Ed__23))]
		private UniTask MoveTokenToCellAsync(int cellId, float speedMultiplier)
		{
			return default;
		}

		[Token(Token = "0x60039E4")]
		[Address(RVA = "0x410A5BC", Offset = "0x41065BC", VA = "0x410A5BC")]
		[AsyncStateMachine(typeof(_003CPlayTokenJumpAsync_003Ed__24))]
		private UniTask PlayTokenJumpAsync(Vector3 targetWorldPos, float jumpPower, float speedMultiplier)
		{
			return default;
		}

		[Token(Token = "0x60039E5")]
		[Address(RVA = "0x410A688", Offset = "0x4106688", VA = "0x410A688")]
		private Vector3 GetTokenBaseScale()
		{
			return default;
		}

		[Token(Token = "0x60039E6")]
		[Address(RVA = "0x4109F7C", Offset = "0x4105F7C", VA = "0x4109F7C")]
		private void ResetTokenScale()
		{
		}

		[Token(Token = "0x60039E7")]
		[Address(RVA = "0x4109E24", Offset = "0x4105E24", VA = "0x4109E24")]
		private void PlaceTokenAtCell(int cellId, bool animate)
		{
		}

		[Token(Token = "0x60039E8")]
		[Address(RVA = "0x410A784", Offset = "0x4106784", VA = "0x410A784")]
		private bool TryGetCellWorldPosition(int cellId, out Vector3 worldPosition)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventureBoardView.TryGetCellWorldPosition RVA=0x410A784 Token=0x60039E8");
}

		[Token(Token = "0x60039E9")]
		[Address(RVA = "0x410A930", Offset = "0x4106930", VA = "0x410A930")]
		public bool TryGetFlyStartWorldPosition(int cellId, out Vector3 worldPosition)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventureBoardView.TryGetFlyStartWorldPosition RVA=0x410A930 Token=0x60039E9");
}

		[Token(Token = "0x60039EA")]
		[Address(RVA = "0x410AA34", Offset = "0x4106A34", VA = "0x410AA34")]
		private void UpdatePlayerFacing(int fromCellId, int toCellId)
		{
		}

		[Token(Token = "0x60039EB")]
		[Address(RVA = "0x410A01C", Offset = "0x410601C", VA = "0x410A01C")]
		private void ApplyPlayerIcon(bool faceFront)
		{
		}

		[Token(Token = "0x60039EC")]
		[Address(RVA = "0x410AB04", Offset = "0x4106B04", VA = "0x410AB04")]
		private Vector3 GetIconBaseScale()
		{
			return default;
		}

		[Token(Token = "0x60039ED")]
		[Address(RVA = "0x410AC90", Offset = "0x4106C90", VA = "0x410AC90")]
		private static void PlayPieceLandSfx()
		{
		}
	}
}
