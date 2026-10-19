using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000654")]
	public class WorldCupActivityMainUiSlideAnimator : MonoBehaviour
	{
		[Token(Token = "0x2000655")]
		private enum SlideDirection
		{
			[Token(Token = "0x4003387")]
			Up = 0,
			[Token(Token = "0x4003388")]
			Left = 1,
			[Token(Token = "0x4003389")]
			Right = 2
		}

		[Token(Token = "0x2000656")]
		private struct SlideEntry
		{
			[Token(Token = "0x400338A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RectTransform Target;

			[Token(Token = "0x400338B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public SlideDirection Direction;
		}

		[Token(Token = "0x2000657")]
		[CompilerGenerated]
		private sealed class _003CBuildSlideEntries_003Ed__18 : IEnumerable<SlideEntry>, IEnumerable, IEnumerator<SlideEntry>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400338C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400338D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private SlideEntry _003C_003E2__current;

			[Token(Token = "0x400338E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x400338F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public WorldCupActivityMainUiSlideAnimator _003C_003E4__this;

			[Token(Token = "0x170001D3")]
SlideEntry System.Collections.Generic.IEnumerator<UIModuleO.WorldCupActivityMainUiSlideAnimator.SlideEntry>.Current
			{
				[Token(Token = "0x600215D")]
				[Address(RVA = "0x3F243C8", Offset = "0x3F203C8", VA = "0x3F243C8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CUIModuleO_002EWorldCupActivityMainUiSlideAnimator_002ESlideEntry_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001D4")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600215F")]
				[Address(RVA = "0x3F2440C", Offset = "0x3F2040C", VA = "0x3F2440C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600215A")]
			[Address(RVA = "0x3F23D90", Offset = "0x3F1FD90", VA = "0x3F23D90")]
			[DebuggerHidden]
			public _003CBuildSlideEntries_003Ed__18(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600215B")]
			[Address(RVA = "0x3F24104", Offset = "0x3F20104", VA = "0x3F24104", Slot = "7")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600215C")]
			[Address(RVA = "0x3F24108", Offset = "0x3F20108", VA = "0x3F24108", Slot = "8")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600215D")]
			[Address(RVA = "0x3F243C8", Offset = "0x3F203C8", VA = "0x3F243C8", Slot = "6")]
			[DebuggerHidden]
			private SlideEntry System_002ECollections_002EGeneric_002EIEnumerator_003CUIModuleO_002EWorldCupActivityMainUiSlideAnimator_002ESlideEntry_003E_002Eget_Current()
			{
				return default;
			}

			[Token(Token = "0x600215E")]
			[Address(RVA = "0x3F243D4", Offset = "0x3F203D4", VA = "0x3F243D4", Slot = "10")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600215F")]
			[Address(RVA = "0x3F2440C", Offset = "0x3F2040C", VA = "0x3F2440C", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6002160")]
			[Address(RVA = "0x3F24468", Offset = "0x3F20468", VA = "0x3F24468", Slot = "4")]
			[DebuggerHidden]
IEnumerator<SlideEntry> System.Collections.Generic.IEnumerable<UIModuleO.WorldCupActivityMainUiSlideAnimator.SlideEntry>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6002161")]
			[Address(RVA = "0x3F24504", Offset = "0x3F20504", VA = "0x3F24504", Slot = "5")]
			[DebuggerHidden]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000658")]
		[CompilerGenerated]
		private struct _003CPlayEnterAsync_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4003390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupActivityMainUiSlideAnimator _003C_003E4__this;

			[Token(Token = "0x4003393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002162")]
			[Address(RVA = "0x3F24508", Offset = "0x3F20508", VA = "0x3F24508", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002163")]
			[Address(RVA = "0x3F249C4", Offset = "0x3F209C4", VA = "0x3F249C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000659")]
		[CompilerGenerated]
		private struct _003CPlayExitAsync_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4003394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupActivityMainUiSlideAnimator _003C_003E4__this;

			[Token(Token = "0x4003397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002164")]
			[Address(RVA = "0x3F249D0", Offset = "0x3F209D0", VA = "0x3F249D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002165")]
			[Address(RVA = "0x3F24E9C", Offset = "0x3F20E9C", VA = "0x3F24E9C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200065A")]
		[CompilerGenerated]
		private struct _003CPlaySlideAsync_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x4003398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400339A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupActivityMainUiSlideAnimator _003C_003E4__this;

			[Token(Token = "0x400339B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool exit;

			[Token(Token = "0x400339C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002166")]
			[Address(RVA = "0x3F24EA8", Offset = "0x3F20EA8", VA = "0x3F24EA8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002167")]
			[Address(RVA = "0x3F257C8", Offset = "0x3F217C8", VA = "0x3F257C8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WorldCupActivityPanelView _view;

		[Token(Token = "0x4003381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _duration;

		[Token(Token = "0x4003382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _extraDistance;

		[Token(Token = "0x4003383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<RectTransform, Vector2> _homePositions;

		[Token(Token = "0x4003384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isExited;

		[Token(Token = "0x4003385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _isPlaying;

		[Token(Token = "0x170001D1")]
		public bool IsPlaying
		{
			[Token(Token = "0x6002149")]
			[Address(RVA = "0x3F23048", Offset = "0x3F1F048", VA = "0x3F23048")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001D2")]
		public bool IsExited
		{
			[Token(Token = "0x600214A")]
			[Address(RVA = "0x3F23050", Offset = "0x3F1F050", VA = "0x3F23050")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600214B")]
		[Address(RVA = "0x3F23058", Offset = "0x3F1F058", VA = "0x3F23058")]
		private void Awake()
		{
		}

		[Token(Token = "0x600214C")]
		[Address(RVA = "0x3F2345C", Offset = "0x3F1F45C", VA = "0x3F2345C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600214D")]
		[Address(RVA = "0x3F2373C", Offset = "0x3F1F73C", VA = "0x3F2373C")]
		[AsyncStateMachine(typeof(_003CPlayExitAsync_003Ed__14))]
		public UniTask PlayExitAsync()
		{
			return default;
		}

		[Token(Token = "0x600214E")]
		[Address(RVA = "0x3F237C8", Offset = "0x3F1F7C8", VA = "0x3F237C8")]
		[AsyncStateMachine(typeof(_003CPlayEnterAsync_003Ed__15))]
		public UniTask PlayEnterAsync()
		{
			return default;
		}

		[Token(Token = "0x600214F")]
		[Address(RVA = "0x3F23854", Offset = "0x3F1F854", VA = "0x3F23854")]
		public void ResetToEnteredImmediate()
		{
		}

		[Token(Token = "0x6002150")]
		[Address(RVA = "0x3F23CEC", Offset = "0x3F1FCEC", VA = "0x3F23CEC")]
		[AsyncStateMachine(typeof(_003CPlaySlideAsync_003Ed__17))]
		private UniTask PlaySlideAsync(bool exit)
		{
			return default;
		}

		[Token(Token = "0x6002151")]
		[Address(RVA = "0x3F23BEC", Offset = "0x3F1FBEC", VA = "0x3F23BEC")]
		[IteratorStateMachine(typeof(_003CBuildSlideEntries_003Ed__18))]
		private IEnumerable<SlideEntry> BuildSlideEntries()
		{
			return null;
		}

		[Token(Token = "0x6002152")]
		[Address(RVA = "0x3F23DC4", Offset = "0x3F1FDC4", VA = "0x3F23DC4")]
		private Vector2 GetExitPosition(SlideEntry entry, Vector2 home)
		{
			return default;
		}

		[Token(Token = "0x6002153")]
		[Address(RVA = "0x3F230E8", Offset = "0x3F1F0E8", VA = "0x3F230E8")]
		private void CaptureHomePositions()
		{
		}

		[Token(Token = "0x6002154")]
		[Address(RVA = "0x3F23C5C", Offset = "0x3F1FC5C", VA = "0x3F23C5C")]
		private void SetSlideTargetsInteractable(bool interactable)
		{
		}

		[Token(Token = "0x6002155")]
		[Address(RVA = "0x3F23E60", Offset = "0x3F1FE60", VA = "0x3F23E60")]
		private static void SetGraphicRaycast(Graphic graphic, bool interactable)
		{
		}

		[Token(Token = "0x6002156")]
		[Address(RVA = "0x3F23EFC", Offset = "0x3F1FEFC", VA = "0x3F23EFC")]
		private static void SetButtonInteractable(Button button, bool interactable)
		{
		}

		[Token(Token = "0x6002157")]
		[Address(RVA = "0x3F23F90", Offset = "0x3F1FF90", VA = "0x3F23F90")]
		private static void SetButtonsInteractable(GameObject root, bool interactable)
		{
		}

		[Token(Token = "0x6002158")]
		[Address(RVA = "0x3F23460", Offset = "0x3F1F460", VA = "0x3F23460")]
		private void KillAllTweens()
		{
		}

		[Token(Token = "0x6002159")]
		[Address(RVA = "0x3F2407C", Offset = "0x3F2007C", VA = "0x3F2407C")]
		public WorldCupActivityMainUiSlideAnimator()
		{
		}
	}
}
