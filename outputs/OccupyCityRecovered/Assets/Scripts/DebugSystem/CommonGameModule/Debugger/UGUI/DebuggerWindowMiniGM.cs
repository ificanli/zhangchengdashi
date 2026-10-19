using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200005A")]
	public class DebuggerWindowMiniGM
	{
		[Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class _003CIE_RefreshSize_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400018D")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400018E")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400018F")]
			[FieldOffset(Offset = "0x20")]
			public DebuggerWindowMiniGM _003C_003E4__this;

			[Token(Token = "0x4000190")]
			[FieldOffset(Offset = "0x28")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x1700004D")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001C4")]
				[Address(RVA = "0x467CF04", Offset = "0x4678F04", VA = "0x467CF04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700004E")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001C6")]
				[Address(RVA = "0x467CF44", Offset = "0x4678F44", VA = "0x467CF44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x467CD8C", Offset = "0x4678D8C", VA = "0x467CD8C")]
			[DebuggerHidden]
			public _003CIE_RefreshSize_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x467CE24", Offset = "0x4678E24", VA = "0x467CE24", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x467CE28", Offset = "0x4678E28", VA = "0x467CE28", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x467CF04", Offset = "0x4678F04", VA = "0x467CF04", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x467CF0C", Offset = "0x4678F0C", VA = "0x467CF0C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x467CF44", Offset = "0x4678F44", VA = "0x467CF44", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x10")]
		[UIPath(UIPathType.UGUI, "Bg/MiniGMToggle")]
		private Toggle m_ToggleOpenMiniGM;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x18")]
		[UIPath(UIPathType.UGUI, "Bg/MiniGMRoot")]
		private RectTransform m_Root;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x20")]
		private GMWindowUGUI _gmWindow;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x28")]
		private DebuggerWindowIconMono _mono;

		[Token(Token = "0x1700004B")]
		private GMWindowUGUI GMWindow
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x467BFA0", Offset = "0x4677FA0", VA = "0x467BFA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private GameObject gameObject
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x467C06C", Offset = "0x467806C", VA = "0x467C06C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x467C088", Offset = "0x4678088", VA = "0x467C088")]
		public DebuggerWindowMiniGM(DebuggerWindowIconMono mono)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x467C114", Offset = "0x4678114", VA = "0x467C114")]
		public void InitGMWindow(GMWindowUGUI gmWindowUGUI)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x467C1C0", Offset = "0x46781C0", VA = "0x467C1C0")]
		private void OnToggleOpenMiniGM(bool isOn)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x467C7DC", Offset = "0x46787DC", VA = "0x467C7DC")]
		[IteratorStateMachine(typeof(_003CIE_RefreshSize_003Ed__11))]
		private IEnumerator IE_RefreshSize()
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x467CDB4", Offset = "0x4678DB4", VA = "0x467CDB4")]
		public void SetIsMiniGM(bool isMiniGM)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x467CDD4", Offset = "0x4678DD4", VA = "0x467CDD4")]
		public void OnSetActive(bool active)
		{
		}
	}
}
