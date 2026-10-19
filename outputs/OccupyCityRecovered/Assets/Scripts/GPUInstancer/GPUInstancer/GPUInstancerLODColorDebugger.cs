using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000069")]
	public class GPUInstancerLODColorDebugger : MonoBehaviour
	{
		[Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class _003CColorLODs_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000404")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000405")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000406")]
			[FieldOffset(Offset = "0x20")]
			public GPUInstancerLODColorDebugger _003C_003E4__this;

			[Token(Token = "0x17000024")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002B1")]
				[Address(RVA = "0x73FFDE8", Offset = "0x73FBDE8", VA = "0x73FFDE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000025")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002B3")]
				[Address(RVA = "0x73FFE28", Offset = "0x73FBE28", VA = "0x73FFE28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x73FF184", Offset = "0x73FB184", VA = "0x73FF184")]
			[DebuggerHidden]
			public _003CColorLODs_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x73FFD88", Offset = "0x73FBD88", VA = "0x73FFD88", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x73FFD8C", Offset = "0x73FBD8C", VA = "0x73FFD8C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x73FFDE8", Offset = "0x73FBDE8", VA = "0x73FFDE8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x73FFDF0", Offset = "0x73FBDF0", VA = "0x73FFDF0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x73FFE28", Offset = "0x73FBE28", VA = "0x73FFE28", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x20")]
		public GPUInstancerManager gPUIManager;

		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x28")]
		public List<Color> lODColors;

		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Material, Color> _previousColors;

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x73FE754", Offset = "0x73FA754", VA = "0x73FE754")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x73FE83C", Offset = "0x73FA83C", VA = "0x73FE83C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x73FF0E0", Offset = "0x73FB0E0", VA = "0x73FF0E0")]
		private void Reset()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x73FE7DC", Offset = "0x73FA7DC", VA = "0x73FE7DC")]
		[IteratorStateMachine(typeof(_003CColorLODs_003Ed__6))]
		private IEnumerator ColorLODs()
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x73FF1AC", Offset = "0x73FB1AC", VA = "0x73FF1AC")]
		public void ChangeLODColors()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x73FE8B4", Offset = "0x73FA8B4", VA = "0x73FE8B4")]
		private void ResetColors()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x73FFBB0", Offset = "0x73FBBB0", VA = "0x73FFBB0")]
		public GPUInstancerLODColorDebugger()
		{
		}
	}
}
