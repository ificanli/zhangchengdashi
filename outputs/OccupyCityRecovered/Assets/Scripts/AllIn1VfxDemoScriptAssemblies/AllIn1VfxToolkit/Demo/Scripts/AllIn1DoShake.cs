using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x200000F")]
	public class AllIn1DoShake : MonoBehaviour
	{
		[Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class _003CDoShakeCoroutine_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000047")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000048")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x20")]
			public AllIn1DoShake _003C_003E4__this;

			[Token(Token = "0x17000001")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000032")]
				[Address(RVA = "0x3CEFD9C", Offset = "0x3CEBD9C", VA = "0x3CEFD9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000002")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000034")]
				[Address(RVA = "0x3CEFDDC", Offset = "0x3CEBDDC", VA = "0x3CEFDDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600002F")]
			[Address(RVA = "0x3CEFCB0", Offset = "0x3CEBCB0", VA = "0x3CEFCB0")]
			[DebuggerHidden]
			public _003CDoShakeCoroutine_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000030")]
			[Address(RVA = "0x3CEFCEC", Offset = "0x3CEBCEC", VA = "0x3CEFCEC", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000031")]
			[Address(RVA = "0x3CEFCF0", Offset = "0x3CEBCF0", VA = "0x3CEFCF0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000032")]
			[Address(RVA = "0x3CEFD9C", Offset = "0x3CEBD9C", VA = "0x3CEFD9C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000033")]
			[Address(RVA = "0x3CEFDA4", Offset = "0x3CEBDA4", VA = "0x3CEFDA4", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0x3CEFDDC", Offset = "0x3CEBDDC", VA = "0x3CEFDDC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float shakeAmount;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool doShakeOnStart;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float shakeOnStartDelay;

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x3CEFAF4", Offset = "0x3CEBAF4", VA = "0x3CEFAF4")]
		private void Start()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x3CEFC50", Offset = "0x3CEBC50", VA = "0x3CEFC50")]
		[IteratorStateMachine(typeof(_003CDoShakeCoroutine_003Ed__4))]
		private IEnumerator DoShakeCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x3CEFB58", Offset = "0x3CEBB58", VA = "0x3CEFB58")]
		public void DoShake()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x3CEFCD8", Offset = "0x3CEBCD8", VA = "0x3CEFCD8")]
		public AllIn1DoShake()
		{
		}
	}
}
