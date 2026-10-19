using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace WG.CollectKit
{
	[Token(Token = "0x2000006")]
	public class SingleCollection3D : SingleCollection
	{
		[Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class _003CExplosionCompleteCoroutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000018")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000019")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400001A")]
			[FieldOffset(Offset = "0x20")]
			public SingleCollection3D _003C_003E4__this;

			[Token(Token = "0x1700000C")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000030")]
				[Address(RVA = "0x854D7FC", Offset = "0x85497FC", VA = "0x854D7FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700000D")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000032")]
				[Address(RVA = "0x854D83C", Offset = "0x854983C", VA = "0x854D83C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600002D")]
			[Address(RVA = "0x854D6B4", Offset = "0x85496B4", VA = "0x854D6B4")]
			[DebuggerHidden]
			public _003CExplosionCompleteCoroutine_003Ed__8(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0x854D750", Offset = "0x8549750", VA = "0x854D750", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600002F")]
			[Address(RVA = "0x854D754", Offset = "0x8549754", VA = "0x854D754", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000030")]
			[Address(RVA = "0x854D7FC", Offset = "0x85497FC", VA = "0x854D7FC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000031")]
			[Address(RVA = "0x854D804", Offset = "0x8549804", VA = "0x854D804", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000032")]
			[Address(RVA = "0x854D83C", Offset = "0x854983C", VA = "0x854D83C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x60")]
		public Transform render;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x68")]
		private bool _isExplosionCompleted;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x69")]
		private bool _isCanInActive;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x70")]
		public GameObject explosion;

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x854D414", Offset = "0x8549414", VA = "0x854D414", Slot = "4")]
		public override void Active()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x854D508", Offset = "0x8549508", VA = "0x854D508", Slot = "8")]
		public override void AddProgress()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x854D5E0", Offset = "0x85495E0", VA = "0x854D5E0", Slot = "6")]
		public override void HideRender()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x854D6A8", Offset = "0x85496A8", VA = "0x854D6A8")]
		public void ExplosionComplete()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x854D648", Offset = "0x8549648", VA = "0x854D648")]
		[IteratorStateMachine(typeof(_003CExplosionCompleteCoroutine_003Ed__8))]
		private IEnumerator ExplosionCompleteCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x854D6DC", Offset = "0x85496DC", VA = "0x854D6DC", Slot = "7")]
		public override void InActive()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x854D6E8", Offset = "0x85496E8", VA = "0x854D6E8")]
		private void Update()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x854D738", Offset = "0x8549738", VA = "0x854D738")]
		public SingleCollection3D()
		{
		}
	}
}
