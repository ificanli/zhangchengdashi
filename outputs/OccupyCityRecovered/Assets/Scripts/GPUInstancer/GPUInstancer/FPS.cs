using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200001F")]
	public class FPS : MonoBehaviour
	{
		[Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400012A")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400012B")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400012C")]
			[FieldOffset(Offset = "0x20")]
			public FPS _003C_003E4__this;

			[Token(Token = "0x17000012")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000B7")]
				[Address(RVA = "0x73B6844", Offset = "0x73B2844", VA = "0x73B6844", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000013")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000B9")]
				[Address(RVA = "0x73B6884", Offset = "0x73B2884", VA = "0x73B6884", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x73B66AC", Offset = "0x73B26AC", VA = "0x73B66AC")]
			[DebuggerHidden]
			public _003CStart_003Ed__1(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x73B66DC", Offset = "0x73B26DC", VA = "0x73B66DC", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x73B66E0", Offset = "0x73B26E0", VA = "0x73B66E0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x73B6844", Offset = "0x73B2844", VA = "0x73B6844", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x73B684C", Offset = "0x73B284C", VA = "0x73B684C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x73B6884", Offset = "0x73B2884", VA = "0x73B6884", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x20")]
		public float FPSCount;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x73B664C", Offset = "0x73B264C", VA = "0x73B664C")]
		[IteratorStateMachine(typeof(_003CStart_003Ed__1))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x73B66D4", Offset = "0x73B26D4", VA = "0x73B66D4")]
		public FPS()
		{
		}
	}
}
