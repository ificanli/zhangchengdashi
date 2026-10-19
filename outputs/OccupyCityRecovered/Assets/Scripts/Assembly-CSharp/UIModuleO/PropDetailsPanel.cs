using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UIModuleO
{
	[Token(Token = "0x2000A9A")]
	public class PropDetailsPanel : PropDetailsPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A9C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4004E41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004E42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004E43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropDetailsPanel _003C_003E4__this;

			[Token(Token = "0x4004E44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4004E45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004006")]
			[Address(RVA = "0x41A1AE8", Offset = "0x419DAE8", VA = "0x41A1AE8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004007")]
			[Address(RVA = "0x41A1F84", Offset = "0x419DF84", VA = "0x41A1F84", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004E2E")]
		private const float AnimDuration = 0.2f;

		[Token(Token = "0x4004E2F")]
		private const float EdgePadding = 20f;

		[Token(Token = "0x4004E30")]
		private const float OffsetDistance = 8f;

		[Token(Token = "0x4004E31")]
		private const float ArrowPadding = 8f;

		[Token(Token = "0x4004E32")]
		private const float ArrowOffsetY = 4.5f;

		[Token(Token = "0x4004E33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector2 AnchorTop;

		[Token(Token = "0x4004E34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Vector2 AnchorBottom;

		[Token(Token = "0x4004E35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Tweener _bubbleTweener;

		[Token(Token = "0x4004E36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _arrowRect;

		[Token(Token = "0x4004E37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _canvasRect;

		[Token(Token = "0x4004E38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _canvasSortingOrder;

		[Token(Token = "0x4004E39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool _isAnimating;

		[Token(Token = "0x4004E3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		private bool _isShowing;

		[Token(Token = "0x4004E3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly List<RaycastResult> SharedRaycastResults;

		[Token(Token = "0x4004E3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly Vector3[] SharedCorners;

		[Token(Token = "0x4004E3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private PointerEventData _pointerEventData;

		[Token(Token = "0x6003FF2")]
		[Address(RVA = "0x419FBF0", Offset = "0x419BBF0", VA = "0x419FBF0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__16))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003FF3")]
		[Address(RVA = "0x419FC8C", Offset = "0x419BC8C", VA = "0x419FC8C")]
		private void CacheReferences()
		{
		}

		[Token(Token = "0x6003FF4")]
		[Address(RVA = "0x419FF24", Offset = "0x419BF24", VA = "0x419FF24")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6003FF5")]
		[Address(RVA = "0x419FF4C", Offset = "0x419BF4C", VA = "0x419FF4C", Slot = "12")]
		protected override void OnButtonExtendTouchBackClicked()
		{
		}

		[Token(Token = "0x6003FF6")]
		[Address(RVA = "0x41A005C", Offset = "0x419C05C", VA = "0x41A005C")]
		private static Vector2 GetClickPosition()
		{
			return default;
		}

		[Token(Token = "0x6003FF7")]
		[Address(RVA = "0x41A00C8", Offset = "0x419C0C8", VA = "0x41A00C8")]
		private bool TryGetClickableUIAtPosition(Vector2 screenPosition, out GameObject clickableObject)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PropDetailsPanel.TryGetClickableUIAtPosition RVA=0x41A00C8 Token=0x6003FF7");
}

		[Token(Token = "0x6003FF8")]
		[Address(RVA = "0x41A0440", Offset = "0x419C440", VA = "0x41A0440")]
		private int FindNextLayerSortingOrder()
		{
			return default;
		}

		[Token(Token = "0x6003FF9")]
		[Address(RVA = "0x41A06B0", Offset = "0x419C6B0", VA = "0x41A06B0")]
		private bool TryFindClickableInLayer(int targetSortingOrder, out GameObject clickableObject)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PropDetailsPanel.TryFindClickableInLayer RVA=0x41A06B0 Token=0x6003FF9");
}

		[Token(Token = "0x6003FFA")]
		[Address(RVA = "0x41A02A8", Offset = "0x419C2A8", VA = "0x41A02A8")]
		private void HideBubble(Vector2 clickPosition, GameObject passThroughTarget)
		{
		}

		[Token(Token = "0x6003FFB")]
		[Address(RVA = "0x41A0A4C", Offset = "0x419CA4C", VA = "0x41A0A4C")]
		private void ExecutePassThroughClick(GameObject target, Vector2 screenPosition)
		{
		}

		[Token(Token = "0x6003FFC")]
		[Address(RVA = "0x41A0BE0", Offset = "0x419CBE0", VA = "0x41A0BE0")]
		private void PlayShowAnimation(bool skipAnimation)
		{
		}

		[Token(Token = "0x6003FFD")]
		[Address(RVA = "0x41A0DD0", Offset = "0x419CDD0", VA = "0x41A0DD0")]
		public void ShowPropDetails(RectTransform target, string propName, string hint)
		{
		}

		[Token(Token = "0x6003FFE")]
		[Address(RVA = "0x41A1180", Offset = "0x419D180", VA = "0x41A1180")]
		private void CalculateAndSetBubblePosition(RectTransform target)
		{
		}

		[Token(Token = "0x6003FFF")]
		[Address(RVA = "0x41A1624", Offset = "0x419D624", VA = "0x41A1624")]
		private void UpdateArrowPosition(Camera cam, Vector3 targetPosition, bool placedBelow)
		{
		}

		[Token(Token = "0x6004000")]
		[Address(RVA = "0x41A1894", Offset = "0x419D894", VA = "0x41A1894")]
		public PropDetailsPanel()
		{
		}
	}
}
