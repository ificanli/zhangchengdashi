using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace PolygonArsenal
{
	[Token(Token = "0x2000CA9")]
	public class PolygonLoopScript : MonoBehaviour
	{
		[Token(Token = "0x2000CAA")]
		[CompilerGenerated]
		private sealed class _003CEffectLoop_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005AE2")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005AE3")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005AE4")]
			[FieldOffset(Offset = "0x20")]
			public PolygonLoopScript _003C_003E4__this;

			[Token(Token = "0x4005AE5")]
			[FieldOffset(Offset = "0x28")]
			private GameObject _003CeffectPlayer_003E5__2;

			[Token(Token = "0x17000E23")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6004F6D")]
				[Address(RVA = "0x42B62E4", Offset = "0x42B22E4", VA = "0x42B62E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E24")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6004F6F")]
				[Address(RVA = "0x42B6324", Offset = "0x42B2324", VA = "0x42B6324", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004F6A")]
			[Address(RVA = "0x42B614C", Offset = "0x42B214C", VA = "0x42B614C")]
			[DebuggerHidden]
			public _003CEffectLoop_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004F6B")]
			[Address(RVA = "0x42B6184", Offset = "0x42B2184", VA = "0x42B6184", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6004F6C")]
			[Address(RVA = "0x42B6188", Offset = "0x42B2188", VA = "0x42B6188", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004F6D")]
			[Address(RVA = "0x42B62E4", Offset = "0x42B22E4", VA = "0x42B62E4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004F6E")]
			[Address(RVA = "0x42B62EC", Offset = "0x42B22EC", VA = "0x42B62EC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6004F6F")]
			[Address(RVA = "0x42B6324", Offset = "0x42B2324", VA = "0x42B6324", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005AE0")]
		[FieldOffset(Offset = "0x20")]
		public GameObject chosenEffect;

		[Token(Token = "0x4005AE1")]
		[FieldOffset(Offset = "0x28")]
		public float loopTimeLimit;

		[Token(Token = "0x6004F66")]
		[Address(RVA = "0x42B609C", Offset = "0x42B209C", VA = "0x42B609C")]
		private void Start()
		{
		}

		[Token(Token = "0x6004F67")]
		[Address(RVA = "0x42B60A0", Offset = "0x42B20A0", VA = "0x42B60A0")]
		public void PlayEffect()
		{
		}

		[Token(Token = "0x6004F68")]
		[Address(RVA = "0x42B60EC", Offset = "0x42B20EC", VA = "0x42B60EC")]
		[IteratorStateMachine(typeof(_003CEffectLoop_003Ed__4))]
		private IEnumerator EffectLoop()
		{
			return null;
		}

		[Token(Token = "0x6004F69")]
		[Address(RVA = "0x42B6174", Offset = "0x42B2174", VA = "0x42B6174")]
		public PolygonLoopScript()
		{
		}
	}
}
