using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	[Token(Token = "0x20002DF")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/animationlinktraverser.html")]
	public class AnimationLinkTraverser : VersionedMonoBehaviour
	{
		[Token(Token = "0x20002E0")]
		[CompilerGenerated]
		private sealed class _003CTraverseOffMeshLink_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000D4E")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000D4F")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000D50")]
			[FieldOffset(Offset = "0x20")]
			public RichSpecial rs;

			[Token(Token = "0x4000D51")]
			[FieldOffset(Offset = "0x28")]
			public AnimationLinkTraverser _003C_003E4__this;

			[Token(Token = "0x4000D52")]
			[FieldOffset(Offset = "0x30")]
			private AnimationLink _003Clink_003E5__2;

			[Token(Token = "0x170002CA")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600121F")]
				[Address(RVA = "0x44A86D0", Offset = "0x44A46D0", VA = "0x44A86D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170002CB")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6001221")]
				[Address(RVA = "0x44A8710", Offset = "0x44A4710", VA = "0x44A8710", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600121C")]
			[Address(RVA = "0x44A8078", Offset = "0x44A4078", VA = "0x44A8078")]
			[DebuggerHidden]
			public _003CTraverseOffMeshLink_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600121D")]
			[Address(RVA = "0x44A80A8", Offset = "0x44A40A8", VA = "0x44A80A8", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600121E")]
			[Address(RVA = "0x44A80AC", Offset = "0x44A40AC", VA = "0x44A80AC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600121F")]
			[Address(RVA = "0x44A86D0", Offset = "0x44A46D0", VA = "0x44A86D0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001220")]
			[Address(RVA = "0x44A86D8", Offset = "0x44A46D8", VA = "0x44A86D8", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6001221")]
			[Address(RVA = "0x44A8710", Offset = "0x44A4710", VA = "0x44A8710", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000D4C")]
		[FieldOffset(Offset = "0x28")]
		public Animation anim;

		[Token(Token = "0x4000D4D")]
		[FieldOffset(Offset = "0x30")]
		private RichAI ai;

		[Token(Token = "0x6001218")]
		[Address(RVA = "0x44A7DE0", Offset = "0x44A3DE0", VA = "0x44A7DE0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6001219")]
		[Address(RVA = "0x44A7F08", Offset = "0x44A3F08", VA = "0x44A7F08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600121A")]
		[Address(RVA = "0x44A800C", Offset = "0x44A400C", VA = "0x44A800C", Slot = "15")]
		[IteratorStateMachine(typeof(_003CTraverseOffMeshLink_003Ed__4))]
		protected virtual IEnumerator TraverseOffMeshLink(RichSpecial rs)
		{
			return null;
		}

		[Token(Token = "0x600121B")]
		[Address(RVA = "0x44A80A0", Offset = "0x44A40A0", VA = "0x44A80A0")]
		public AnimationLinkTraverser()
		{
		}
	}
}
