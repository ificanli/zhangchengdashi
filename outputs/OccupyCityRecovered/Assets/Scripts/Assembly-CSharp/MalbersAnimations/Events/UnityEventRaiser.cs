using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace MalbersAnimations.Events
{
	[Token(Token = "0x2000D55")]
	public class UnityEventRaiser : UnityUtils
	{
		[Token(Token = "0x2000D56")]
		[CompilerGenerated]
		private sealed class _003CEventCoroutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005F29")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005F2A")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005F2B")]
			[FieldOffset(Offset = "0x20")]
			public UnityEventRaiser _003C_003E4__this;

			[Token(Token = "0x17000E61")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005288")]
				[Address(RVA = "0x4301ABC", Offset = "0x42FDABC", VA = "0x4301ABC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E62")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600528A")]
				[Address(RVA = "0x4301AFC", Offset = "0x42FDAFC", VA = "0x4301AFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005285")]
			[Address(RVA = "0x43018F8", Offset = "0x42FD8F8", VA = "0x43018F8")]
			[DebuggerHidden]
			public _003CEventCoroutine_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005286")]
			[Address(RVA = "0x4301984", Offset = "0x42FD984", VA = "0x4301984", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005287")]
			[Address(RVA = "0x4301988", Offset = "0x42FD988", VA = "0x4301988", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005288")]
			[Address(RVA = "0x4301ABC", Offset = "0x42FDABC", VA = "0x4301ABC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005289")]
			[Address(RVA = "0x4301AC4", Offset = "0x42FDAC4", VA = "0x4301AC4", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600528A")]
			[Address(RVA = "0x4301AFC", Offset = "0x42FDAFC", VA = "0x4301AFC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005F21")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Delayed time for invoking the Events, or the Repeated time  when Repeat is enable")]
		public float Delayed;

		[Token(Token = "0x4005F22")]
		[FieldOffset(Offset = "0x24")]
		public float RepeatTime;

		[Token(Token = "0x4005F23")]
		[FieldOffset(Offset = "0x28")]
		public bool Repeat;

		[Token(Token = "0x4005F24")]
		[FieldOffset(Offset = "0x30")]
		public string desc;

		[Token(Token = "0x4005F25")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("OnEnableEvent")]
		public UnityEvent onEnable;

		[Token(Token = "0x4005F26")]
		[FieldOffset(Offset = "0x40")]
		public string Description;

		[Token(Token = "0x4005F27")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public bool editDescription;

		[Token(Token = "0x4005F28")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine eventCoroutine;

		[Token(Token = "0x600527F")]
		[Address(RVA = "0x430182C", Offset = "0x42FD82C", VA = "0x430182C")]
		[ContextMenu("Edit Description")]
		internal void EditDescription()
		{
		}

		[Token(Token = "0x6005280")]
		[Address(RVA = "0x430183C", Offset = "0x42FD83C", VA = "0x430183C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6005281")]
		[Address(RVA = "0x43018DC", Offset = "0x42FD8DC", VA = "0x43018DC")]
		[ContextMenu("Invoke on Editor")]
		private void StartEvent()
		{
		}

		[Token(Token = "0x6005282")]
		[Address(RVA = "0x430187C", Offset = "0x42FD87C", VA = "0x430187C")]
		[IteratorStateMachine(typeof(_003CEventCoroutine_003Ed__11))]
		private IEnumerator EventCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6005283")]
		[Address(RVA = "0x4301920", Offset = "0x42FD920", VA = "0x4301920")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005284")]
		[Address(RVA = "0x4301934", Offset = "0x42FD934", VA = "0x4301934")]
		public UnityEventRaiser()
		{
		}
	}
}
