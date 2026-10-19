using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000063")]
	public class GPUInstancerDrawCallColorDebugger : MonoBehaviour
	{
		[Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class _003CColorLODs_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003D9")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40003DA")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40003DB")]
			[FieldOffset(Offset = "0x20")]
			public GPUInstancerDrawCallColorDebugger _003C_003E4__this;

			[Token(Token = "0x17000022")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600028A")]
				[Address(RVA = "0x73FB98C", Offset = "0x73F798C", VA = "0x73FB98C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000023")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600028C")]
				[Address(RVA = "0x73FB9CC", Offset = "0x73F79CC", VA = "0x73FB9CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000287")]
			[Address(RVA = "0x73FA1EC", Offset = "0x73F61EC", VA = "0x73FA1EC")]
			[DebuggerHidden]
			public _003CColorLODs_003Ed__8(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x73FB92C", Offset = "0x73F792C", VA = "0x73FB92C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x73FB930", Offset = "0x73F7930", VA = "0x73FB930", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x73FB98C", Offset = "0x73F798C", VA = "0x73FB98C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x73FB994", Offset = "0x73F7994", VA = "0x73FB994", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600028C")]
			[Address(RVA = "0x73FB9CC", Offset = "0x73F79CC", VA = "0x73FB9CC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x20")]
		public GPUInstancerManager gPUIManager;

		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x28")]
		public List<Color> drawCallColors;

		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x30")]
		public bool removeMainTextureWhenColored;

		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<Material, Color> _previousColors;

		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<Material, Texture> _previousTextures;

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x73F8FC4", Offset = "0x73F4FC4", VA = "0x73F8FC4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x73F90AC", Offset = "0x73F50AC", VA = "0x73F90AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x73FA148", Offset = "0x73F6148", VA = "0x73FA148")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x73F904C", Offset = "0x73F504C", VA = "0x73F904C")]
		[IteratorStateMachine(typeof(_003CColorLODs_003Ed__8))]
		private IEnumerator ColorLODs()
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x73FA214", Offset = "0x73F6214", VA = "0x73FA214")]
		public void ChangeDrawCallColors()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x73F9124", Offset = "0x73F5124", VA = "0x73F9124")]
		private void ResetColors()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x73FB684", Offset = "0x73F7684", VA = "0x73FB684")]
		public GPUInstancerDrawCallColorDebugger()
		{
		}
	}
}
