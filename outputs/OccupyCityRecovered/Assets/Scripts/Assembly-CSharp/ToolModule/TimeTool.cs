using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace ToolModule
{
	[Token(Token = "0x20001A5")]
	public class TimeTool
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001A6")]
		[CompilerGenerated]
		private struct _003CDelay_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4001ACB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001ACC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001ACD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int miliseconds;

			[Token(Token = "0x4001ACE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x3F82D14", Offset = "0x3F7ED14", VA = "0x3F82D14", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x3F82F04", Offset = "0x3F7EF04", VA = "0x3F82F04", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20001A7")]
		[CompilerGenerated]
		private sealed class _003CWaitForRun_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001ACF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001AD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001AD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x4001AD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action callback;

			[Token(Token = "0x17000095")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006C6")]
				[Address(RVA = "0x3F83020", Offset = "0x3F7F020", VA = "0x3F83020", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000096")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006C8")]
				[Address(RVA = "0x3F83060", Offset = "0x3F7F060", VA = "0x3F83060", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x3F82B98", Offset = "0x3F7EB98", VA = "0x3F82B98")]
			[DebuggerHidden]
			public _003CWaitForRun_003Ed__2(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x3F82F6C", Offset = "0x3F7EF6C", VA = "0x3F82F6C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x3F82F70", Offset = "0x3F7EF70", VA = "0x3F82F70", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x3F83020", Offset = "0x3F7F020", VA = "0x3F83020", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x3F83028", Offset = "0x3F7F028", VA = "0x3F83028", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x3F83060", Offset = "0x3F7F060", VA = "0x3F83060", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20001A8")]
		[CompilerGenerated]
		private sealed class _003CWaitUntilRun_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001AD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001AD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001AD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<bool> condition;

			[Token(Token = "0x4001AD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action callback;

			[Token(Token = "0x17000097")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006CC")]
				[Address(RVA = "0x3F83114", Offset = "0x3F7F114", VA = "0x3F83114", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000098")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006CE")]
				[Address(RVA = "0x3F83154", Offset = "0x3F7F154", VA = "0x3F83154", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x3F82BC0", Offset = "0x3F7EBC0", VA = "0x3F82BC0")]
			[DebuggerHidden]
			public _003CWaitUntilRun_003Ed__3(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x3F83068", Offset = "0x3F7F068", VA = "0x3F83068", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x3F8306C", Offset = "0x3F7F06C", VA = "0x3F8306C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x3F83114", Offset = "0x3F7F114", VA = "0x3F83114", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x3F8311C", Offset = "0x3F7F11C", VA = "0x3F8311C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x3F83154", Offset = "0x3F7F154", VA = "0x3F83154", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x3F82A78", Offset = "0x3F7EA78", VA = "0x3F82A78")]
		public static void WaitFor(float time, Action callback)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x3F82B1C", Offset = "0x3F7EB1C", VA = "0x3F82B1C")]
		public static void WaitUntil(Func<bool> condition, Action callback)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x3F82A88", Offset = "0x3F7EA88", VA = "0x3F82A88")]
		[IteratorStateMachine(typeof(_003CWaitForRun_003Ed__2))]
		private static IEnumerator WaitForRun(float time, Action callback)
		{
			return null;
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x3F82B2C", Offset = "0x3F7EB2C", VA = "0x3F82B2C")]
		[IteratorStateMachine(typeof(_003CWaitUntilRun_003Ed__3))]
		private static IEnumerator WaitUntilRun(Func<bool> condition, Action callback)
		{
			return null;
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x3F82AF8", Offset = "0x3F7EAF8", VA = "0x3F82AF8")]
		public static Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x3F82CE8", Offset = "0x3F7ECE8", VA = "0x3F82CE8")]
		public static void StopCoroutine(Coroutine routine)
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x3F81810", Offset = "0x3F7D810", VA = "0x3F81810")]
		[AsyncStateMachine(typeof(_003CDelay_003Ed__6))]
		public static Task Delay(int miliseconds)
		{
			return null;
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x3F82D0C", Offset = "0x3F7ED0C", VA = "0x3F82D0C")]
		public TimeTool()
		{
		}
	}
}
