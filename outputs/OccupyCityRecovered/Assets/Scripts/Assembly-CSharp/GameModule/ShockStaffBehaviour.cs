using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002E5")]
	public class ShockStaffBehaviour : MonoBehaviour
	{
		[Token(Token = "0x20002E6")]
		[CompilerGenerated]
		private sealed class _003CResizeRoutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4002294")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4002295")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4002296")]
			[FieldOffset(Offset = "0x20")]
			public ShockStaffBehaviour _003C_003E4__this;

			[Token(Token = "0x4002297")]
			[FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x4002298")]
			[FieldOffset(Offset = "0x2C")]
			public float targetRadius;

			[Token(Token = "0x4002299")]
			[FieldOffset(Offset = "0x30")]
			private float _003CinitialRadius_003E5__2;

			[Token(Token = "0x400229A")]
			[FieldOffset(Offset = "0x34")]
			private float _003Celapsed_003E5__3;

			[Token(Token = "0x170000DC")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CF9")]
				[Address(RVA = "0x3D4F7FC", Offset = "0x3D4B7FC", VA = "0x3D4F7FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000DD")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CFB")]
				[Address(RVA = "0x3D4F83C", Offset = "0x3D4B83C", VA = "0x3D4F83C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000CF6")]
			[Address(RVA = "0x3D4F270", Offset = "0x3D4B270", VA = "0x3D4F270")]
			[DebuggerHidden]
			public _003CResizeRoutine_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000CF7")]
			[Address(RVA = "0x3D4F5D4", Offset = "0x3D4B5D4", VA = "0x3D4F5D4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CF8")]
			[Address(RVA = "0x3D4F5D8", Offset = "0x3D4B5D8", VA = "0x3D4F5D8", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000CF9")]
			[Address(RVA = "0x3D4F7FC", Offset = "0x3D4B7FC", VA = "0x3D4F7FC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000CFA")]
			[Address(RVA = "0x3D4F804", Offset = "0x3D4B804", VA = "0x3D4F804", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000CFB")]
			[Address(RVA = "0x3D4F83C", Offset = "0x3D4B83C", VA = "0x3D4F83C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400228F")]
		[FieldOffset(Offset = "0x20")]
		private SphereCollider sc;

		[Token(Token = "0x4002290")]
		[FieldOffset(Offset = "0x28")]
		private int damage;

		[Token(Token = "0x4002291")]
		[FieldOffset(Offset = "0x2C")]
		private bool isEnemy;

		[Token(Token = "0x4002292")]
		[FieldOffset(Offset = "0x30")]
		private float shockDis;

		[Token(Token = "0x4002293")]
		[FieldOffset(Offset = "0x38")]
		private List<RoleBehaviour> allTriggerRole;

		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0x3D4F0D4", Offset = "0x3D4B0D4", VA = "0x3D4F0D4")]
		public void Init(int num, bool isEnemy, float shockDis)
		{
		}

		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0x3D4F1FC", Offset = "0x3D4B1FC", VA = "0x3D4F1FC")]
		[IteratorStateMachine(typeof(_003CResizeRoutine_003Ed__6))]
		private IEnumerator ResizeRoutine(float targetRadius, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x3D4F298", Offset = "0x3D4B298", VA = "0x3D4F298")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0x3D4F558", Offset = "0x3D4B558", VA = "0x3D4F558")]
		public ShockStaffBehaviour()
		{
		}
	}
}
