using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Entities;
using Unity.Mathematics;

namespace Pathfinding.ECS
{
	[Token(Token = "0x200034E")]
	public struct JobStartOffMeshLinkTransition
	{
		[Token(Token = "0x200034F")]
		[CompilerGenerated]
		private sealed class _003CDefaultOnTraverseOffMeshLink_003Ed__1 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000EA6")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000EA7")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000EA8")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4000EA9")]
			[FieldOffset(Offset = "0x28")]
			private AgentOffMeshLinkTraversalContext ctx;

			[Token(Token = "0x4000EAA")]
			[FieldOffset(Offset = "0x30")]
			public AgentOffMeshLinkTraversalContext _003C_003E3__ctx;

			[Token(Token = "0x4000EAB")]
			[FieldOffset(Offset = "0x38")]
			private OffMeshLinks.OffMeshLinkTracer _003ClinkInfo_003E5__2;

			[Token(Token = "0x4000EAC")]
			[FieldOffset(Offset = "0x60")]
			private quaternion _003Crot_003E5__3;

			[Token(Token = "0x1700031B")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600150A")]
				[Address(RVA = "0x44C8420", Offset = "0x44C4420", VA = "0x44C8420", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700031C")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600150C")]
				[Address(RVA = "0x44C8460", Offset = "0x44C4460", VA = "0x44C8460", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001507")]
			[Address(RVA = "0x44C81A4", Offset = "0x44C41A4", VA = "0x44C81A4")]
			[DebuggerHidden]
			public _003CDefaultOnTraverseOffMeshLink_003Ed__1(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6001508")]
			[Address(RVA = "0x44C81D8", Offset = "0x44C41D8", VA = "0x44C81D8", Slot = "7")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6001509")]
			[Address(RVA = "0x44C81DC", Offset = "0x44C41DC", VA = "0x44C81DC", Slot = "8")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600150A")]
			[Address(RVA = "0x44C8420", Offset = "0x44C4420", VA = "0x44C8420", Slot = "6")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600150B")]
			[Address(RVA = "0x44C8428", Offset = "0x44C4428", VA = "0x44C8428", Slot = "10")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600150C")]
			[Address(RVA = "0x44C8460", Offset = "0x44C4460", VA = "0x44C8460", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600150D")]
			[Address(RVA = "0x44C8468", Offset = "0x44C4468", VA = "0x44C8468", Slot = "4")]
			[DebuggerHidden]
IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600150E")]
			[Address(RVA = "0x44C8504", Offset = "0x44C4504", VA = "0x44C8504", Slot = "5")]
			[DebuggerHidden]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000EA5")]
		[FieldOffset(Offset = "0x0")]
		public EntityCommandBuffer commandBuffer;

		[Token(Token = "0x6001506")]
		[Address(RVA = "0x44C1AFC", Offset = "0x44BDAFC", VA = "0x44C1AFC")]
		[IteratorStateMachine(typeof(_003CDefaultOnTraverseOffMeshLink_003Ed__1))]
		public static IEnumerable<object> DefaultOnTraverseOffMeshLink(AgentOffMeshLinkTraversalContext ctx)
		{
			return null;
		}
	}
}
