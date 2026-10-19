using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000B2A")]
	public class BtnMonthlyCardItem : BtnMonthlyCardItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B2B")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4005178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400517A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnMonthlyCardItem _003C_003E4__this;

			[Token(Token = "0x400517B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalShopInfo info;

			[Token(Token = "0x60043E8")]
			[Address(RVA = "0x41E3F9C", Offset = "0x41DFF9C", VA = "0x41E3F9C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60043E9")]
			[Address(RVA = "0x41E4D4C", Offset = "0x41E0D4C", VA = "0x41E4D4C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000B2C")]
		[CompilerGenerated]
		private sealed class _003CUpdateUICoroutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400517C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400517D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400517E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BtnMonthlyCardItem _003C_003E4__this;

			[Token(Token = "0x17000B1D")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60043ED")]
				[Address(RVA = "0x41E4E18", Offset = "0x41E0E18", VA = "0x41E4E18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000B1E")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60043EF")]
				[Address(RVA = "0x41E4E58", Offset = "0x41E0E58", VA = "0x41E4E58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60043EA")]
			[Address(RVA = "0x41E3AA8", Offset = "0x41DFAA8", VA = "0x41E3AA8")]
			[DebuggerHidden]
			public _003CUpdateUICoroutine_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60043EB")]
			[Address(RVA = "0x41E4D58", Offset = "0x41E0D58", VA = "0x41E4D58", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60043EC")]
			[Address(RVA = "0x41E4D5C", Offset = "0x41E0D5C", VA = "0x41E4D5C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60043ED")]
			[Address(RVA = "0x41E4E18", Offset = "0x41E0E18", VA = "0x41E4E18", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60043EE")]
			[Address(RVA = "0x41E4E20", Offset = "0x41E0E20", VA = "0x41E4E20", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60043EF")]
			[Address(RVA = "0x41E4E58", Offset = "0x41E0E58", VA = "0x41E4E58", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GlobalShopInfo _info;

		[Token(Token = "0x4005176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string productId;

		[Token(Token = "0x4005177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Coroutine updateUICoroutine;

		[Token(Token = "0x60043DE")]
		[Address(RVA = "0x41E3948", Offset = "0x41DF948", VA = "0x41E3948")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__3))]
		public void Init(GlobalShopInfo info)
		{
		}

		[Token(Token = "0x60043DF")]
		[Address(RVA = "0x41E39E4", Offset = "0x41DF9E4", VA = "0x41E39E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60043E0")]
		[Address(RVA = "0x41E3A84", Offset = "0x41DFA84", VA = "0x41E3A84")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60043E1")]
		[Address(RVA = "0x41E3A24", Offset = "0x41DFA24", VA = "0x41E3A24")]
		[IteratorStateMachine(typeof(_003CUpdateUICoroutine_003Ed__6))]
		private IEnumerator UpdateUICoroutine()
		{
			return null;
		}

		[Token(Token = "0x60043E2")]
		[Address(RVA = "0x41E3AD0", Offset = "0x41DFAD0", VA = "0x41E3AD0")]
		private void UpdateUI()
		{
		}

		[Token(Token = "0x60043E3")]
		[Address(RVA = "0x41E3D8C", Offset = "0x41DFD8C", VA = "0x41E3D8C", Slot = "12")]
		protected override void OnButtonExtendBtnMonthlyCardItemClicked()
		{
		}

		[Token(Token = "0x60043E4")]
		[Address(RVA = "0x41E3E64", Offset = "0x41DFE64", VA = "0x41E3E64")]
		private void BuyMonthPass(object o)
		{
		}

		[Token(Token = "0x60043E5")]
		[Address(RVA = "0x41E3F3C", Offset = "0x41DFF3C", VA = "0x41E3F3C")]
		public BtnMonthlyCardItem()
		{
		}
	}
}
