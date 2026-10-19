using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x2000015")]
	public class OptionalRendererRandomizer : MonoBehaviour
	{
		[Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class _003CRandomizeCoroutine_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000A0")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000A1")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000A2")]
			[FieldOffset(Offset = "0x20")]
			public OptionalRendererRandomizer _003C_003E4__this;

			[Token(Token = "0x17000003")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000057")]
				[Address(RVA = "0x73C54D8", Offset = "0x73C14D8", VA = "0x73C54D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000004")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000059")]
				[Address(RVA = "0x73C5518", Offset = "0x73C1518", VA = "0x73C5518", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000054")]
			[Address(RVA = "0x73C503C", Offset = "0x73C103C", VA = "0x73C503C")]
			[DebuggerHidden]
			public _003CRandomizeCoroutine_003Ed__3(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000055")]
			[Address(RVA = "0x73C540C", Offset = "0x73C140C", VA = "0x73C540C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000056")]
			[Address(RVA = "0x73C5410", Offset = "0x73C1410", VA = "0x73C5410", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x73C54D8", Offset = "0x73C14D8", VA = "0x73C54D8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000058")]
			[Address(RVA = "0x73C54E0", Offset = "0x73C14E0", VA = "0x73C54E0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000059")]
			[Address(RVA = "0x73C5518", Offset = "0x73C1518", VA = "0x73C5518", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x20")]
		public GPUICrowdManager gpuiCrowdManager;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x28")]
		public GPUICrowdPrototype crowdPrototype;

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x73C4FBC", Offset = "0x73C0FBC", VA = "0x73C4FBC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x73C4FDC", Offset = "0x73C0FDC", VA = "0x73C4FDC")]
		[IteratorStateMachine(typeof(_003CRandomizeCoroutine_003Ed__3))]
		public IEnumerator RandomizeCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x73C5064", Offset = "0x73C1064", VA = "0x73C5064")]
		public void RandomizeOptionalRenderers()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x73C5404", Offset = "0x73C1404", VA = "0x73C5404")]
		public OptionalRendererRandomizer()
		{
		}
	}
}
