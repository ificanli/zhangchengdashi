using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000D64")]
	public class ToggleLanguage : MonoBehaviour
	{
		[Token(Token = "0x2000D65")]
		[CompilerGenerated]
		private sealed class _003CTestCoroutine_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005F3E")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005F3F")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x17000E63")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60052D0")]
				[Address(RVA = "0x4306058", Offset = "0x4302058", VA = "0x4306058", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E64")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60052D2")]
				[Address(RVA = "0x4306098", Offset = "0x4302098", VA = "0x4306098", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60052CD")]
			[Address(RVA = "0x4305F20", Offset = "0x4301F20", VA = "0x4305F20")]
			[DebuggerHidden]
			public _003CTestCoroutine_003Ed__2(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60052CE")]
			[Address(RVA = "0x4305F50", Offset = "0x4301F50", VA = "0x4305F50", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60052CF")]
			[Address(RVA = "0x4305F54", Offset = "0x4301F54", VA = "0x4305F54", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60052D0")]
			[Address(RVA = "0x4306058", Offset = "0x4302058", VA = "0x4306058", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60052D1")]
			[Address(RVA = "0x4306060", Offset = "0x4302060", VA = "0x4306060", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60052D2")]
			[Address(RVA = "0x4306098", Offset = "0x4302098", VA = "0x4306098", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005F3D")]
		[FieldOffset(Offset = "0x20")]
		private Coroutine testCoroutine;

		[Token(Token = "0x60052CA")]
		[Address(RVA = "0x4305EA0", Offset = "0x4301EA0", VA = "0x4305EA0")]
		private void Start()
		{
		}

		[Token(Token = "0x60052CB")]
		[Address(RVA = "0x4305EC8", Offset = "0x4301EC8", VA = "0x4305EC8")]
		[IteratorStateMachine(typeof(_003CTestCoroutine_003Ed__2))]
		private IEnumerator TestCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60052CC")]
		[Address(RVA = "0x4305F48", Offset = "0x4301F48", VA = "0x4305F48")]
		public ToggleLanguage()
		{
		}
	}
}
