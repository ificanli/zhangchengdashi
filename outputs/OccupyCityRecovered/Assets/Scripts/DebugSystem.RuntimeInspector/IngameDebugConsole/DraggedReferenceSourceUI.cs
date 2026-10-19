using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IngameDebugConsole
{
	[Token(Token = "0x200004B")]
	public class DraggedReferenceSourceUI : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler
	{
		[Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class _003CCreateReferenceItemCoroutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001B7")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40001B8")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40001B9")]
			[FieldOffset(Offset = "0x20")]
			public PointerEventData eventData;

			[Token(Token = "0x40001BA")]
			[FieldOffset(Offset = "0x28")]
			public DraggedReferenceSourceUI _003C_003E4__this;

			[Token(Token = "0x40001BB")]
			[FieldOffset(Offset = "0x30")]
			private Vector2 _003CpressPosition_003E5__2;

			[Token(Token = "0x40001BC")]
			[FieldOffset(Offset = "0x38")]
			private float _003CdragThreshold_003E5__3;

			[Token(Token = "0x17000087")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002B5")]
				[Address(RVA = "0x466EE80", Offset = "0x466AE80", VA = "0x466EE80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000088")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002B7")]
				[Address(RVA = "0x466EEC0", Offset = "0x466AEC0", VA = "0x466EEC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x466EC6C", Offset = "0x466AC6C", VA = "0x466EC6C")]
			[DebuggerHidden]
			public _003CCreateReferenceItemCoroutine_003Ed__10(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x466ECA8", Offset = "0x466ACA8", VA = "0x466ECA8", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x466ECAC", Offset = "0x466ACAC", VA = "0x466ECAC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x466EE80", Offset = "0x466AE80", VA = "0x466EE80", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x466EE88", Offset = "0x466AE88", VA = "0x466EE88", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x466EEC0", Offset = "0x466AEC0", VA = "0x466EEC0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEngine.Object[] m_references;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UISkin draggedReferenceSkin;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float holdTime;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x38")]
		private IEnumerator pointerHeldCoroutine;

		[Token(Token = "0x17000086")]
		public UnityEngine.Object[] References
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x466EAFC", Offset = "0x466AAFC", VA = "0x466EAFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x466EB04", Offset = "0x466AB04", VA = "0x466EB04")]
			set
			{
			}
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x466EB0C", Offset = "0x466AB0C", VA = "0x466EB0C", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x466EC24", Offset = "0x466AC24", VA = "0x466EC24", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x466EC48", Offset = "0x466AC48", VA = "0x466EC48", Slot = "6")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x466EBB8", Offset = "0x466ABB8", VA = "0x466EBB8")]
		[IteratorStateMachine(typeof(_003CCreateReferenceItemCoroutine_003Ed__10))]
		private IEnumerator CreateReferenceItemCoroutine(PointerEventData eventData)
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x466EC94", Offset = "0x466AC94", VA = "0x466EC94")]
		public DraggedReferenceSourceUI()
		{
		}
	}
}
