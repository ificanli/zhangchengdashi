using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x2000031")]
	public class GPUICrowdAnimatorRandomizer : MonoBehaviour
	{
		[Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class _003CRandomizeCrowdAnimators_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400016C")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400016D")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400016E")]
			[FieldOffset(Offset = "0x20")]
			public GPUICrowdAnimatorRandomizer _003C_003E4__this;

			[Token(Token = "0x17000007")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000D9")]
				[Address(RVA = "0x73D2488", Offset = "0x73CE488", VA = "0x73D2488", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000008")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000DB")]
				[Address(RVA = "0x73D24C8", Offset = "0x73CE4C8", VA = "0x73D24C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x73D1D6C", Offset = "0x73CDD6C", VA = "0x73D1D6C")]
			[DebuggerHidden]
			public _003CRandomizeCrowdAnimators_003Ed__7(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x73D23BC", Offset = "0x73CE3BC", VA = "0x73D23BC", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x73D23C0", Offset = "0x73CE3C0", VA = "0x73D23C0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x73D2488", Offset = "0x73CE488", VA = "0x73D2488", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x73D2490", Offset = "0x73CE490", VA = "0x73D2490", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x73D24C8", Offset = "0x73CE4C8", VA = "0x73D24C8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x20")]
		public GPUICrowdManager crowdManager;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Optional parameter to randomize only the given prototypes")]
		public List<GPUICrowdPrototype> crowdPrototypeFilter;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x30")]
		public bool randomizeClips;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x31")]
		public bool randomizeFrame;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x32")]
		public bool resetAnimations;

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x73D1BFC", Offset = "0x73CDBFC", VA = "0x73D1BFC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x73D1CE4", Offset = "0x73CDCE4", VA = "0x73D1CE4")]
		private void Reset()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x73D1C84", Offset = "0x73CDC84", VA = "0x73D1C84")]
		[IteratorStateMachine(typeof(_003CRandomizeCrowdAnimators_003Ed__7))]
		private IEnumerator RandomizeCrowdAnimators()
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x73D1D94", Offset = "0x73CDD94", VA = "0x73D1D94")]
		public void RandomizeAnimations()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x73D23B4", Offset = "0x73CE3B4", VA = "0x73D23B4")]
		public GPUICrowdAnimatorRandomizer()
		{
		}
	}
}
