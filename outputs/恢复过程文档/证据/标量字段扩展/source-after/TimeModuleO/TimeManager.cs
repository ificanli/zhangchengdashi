using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace TimeModuleO
{
	[Token(Token = "0x20000DA")]
	public class TimeManager : ManagerBase<TimeManager>
	{
		[Token(Token = "0x20000DB")]
		public enum TimeSource
		{
			[Token(Token = "0x40004F4")]
			NetworkTime = 0,
			[Token(Token = "0x40004F5")]
			LocalTime = 1
		}

		[Token(Token = "0x20000DC")]
		public class Timer
		{
			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int hours;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int minutes;

			[Token(Token = "0x1700003C")]
			public string Key
			{
				[Token(Token = "0x60004E4")]
				[Address(RVA = "0x3F6C8A0", Offset = "0x3F688A0", VA = "0x3F6C8A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60004E5")]
				[Address(RVA = "0x3F6C8A8", Offset = "0x3F688A8", VA = "0x3F6C8A8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700003D")]
			public DateTime StartTime
			{
				[Token(Token = "0x60004E6")]
				[Address(RVA = "0x3F6C8B0", Offset = "0x3F688B0", VA = "0x3F6C8B0")]
				[CompilerGenerated]
				get
				{
					return default;
				}
				[Token(Token = "0x60004E7")]
				[Address(RVA = "0x3F6C8B8", Offset = "0x3F688B8", VA = "0x3F6C8B8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700003E")]
			public DateTime TargetEndTime
			{
				[Token(Token = "0x60004E8")]
				[Address(RVA = "0x3F6C8C0", Offset = "0x3F688C0", VA = "0x3F6C8C0")]
				[CompilerGenerated]
				get
				{
					return default;
				}
				[Token(Token = "0x60004E9")]
				[Address(RVA = "0x3F6C8C8", Offset = "0x3F688C8", VA = "0x3F6C8C8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700003F")]
			public bool useStandardNetTime
			{
				[Token(Token = "0x60004EA")]
				[Address(RVA = "0x3F6C8D0", Offset = "0x3F688D0", VA = "0x3F6C8D0")]
				[CompilerGenerated]
				get;
				[Token(Token = "0x60004EB")]
				[Address(RVA = "0x3F6C8D8", Offset = "0x3F688D8", VA = "0x3F6C8D8")]
				[CompilerGenerated]
				private set;
			}

			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x3F6C8E4", Offset = "0x3F688E4", VA = "0x3F6C8E4")]
			public Timer(string key, TimeSpan duration, bool isCountdown, bool useStandardNetTime)
			{
			}

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x3F6CA58", Offset = "0x3F68A58", VA = "0x3F6CA58")]
			public void SetTargetEndTime(DateTime targetEndTime)
			{
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x3F6CA60", Offset = "0x3F68A60", VA = "0x3F6CA60")]
			public Timer(TimeInfo timeInfo)
			{
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x3F6C934", Offset = "0x3F68934", VA = "0x3F6C934")]
			public void Restart(TimeSpan duration, bool isCountdown)
			{
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x3F6CAAC", Offset = "0x3F68AAC", VA = "0x3F6CAAC")]
			public void ChangeTime(TimeSpan duration, bool isAdd = false)
			{
			}

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x3F6CB3C", Offset = "0x3F68B3C", VA = "0x3F6CB3C")]
			public void ChangeUseStandNetTime(bool useStandardNetTime)
			{
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x3F6CBBC", Offset = "0x3F68BBC", VA = "0x3F6CBBC")]
			public TimeSpan GetElapsedTime()
			{
				return default;
			}

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x3F6CC54", Offset = "0x3F68C54", VA = "0x3F6CC54")]
			public TimeSpan GetRemainingTime()
			{
				return default;
			}

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x3F6CCEC", Offset = "0x3F68CEC", VA = "0x3F6CCEC")]
			public string GetFormattedElapsedTime(int unit = 5)
			{
				return null;
			}

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x3F6E100", Offset = "0x3F6A100", VA = "0x3F6E100")]
			public string GetFormattedRemainingTime(int unit = 5)
			{
				return null;
			}

			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x3F6E1B0", Offset = "0x3F6A1B0", VA = "0x3F6E1B0")]
			public int GetFormattedRemainingMinuteTime()
			{
				return default;
			}

			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x3F6E2C4", Offset = "0x3F6A2C4", VA = "0x3F6E2C4")]
			public bool IsCompleted()
			{
				return default;
			}
		}

		[Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private sealed class _003CCheckTimerEndEventCoroutine_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TimeManager _003C_003E4__this;

			[Token(Token = "0x17000040")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004FE")]
				[Address(RVA = "0x3F6E4F0", Offset = "0x3F6A4F0", VA = "0x3F6E4F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000041")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000500")]
				[Address(RVA = "0x3F6E530", Offset = "0x3F6A530", VA = "0x3F6E530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x3F6E414", Offset = "0x3F6A414", VA = "0x3F6E414")]
			[DebuggerHidden]
			public _003CCheckTimerEndEventCoroutine_003Ed__46(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x3F6E43C", Offset = "0x3F6A43C", VA = "0x3F6E43C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x3F6E440", Offset = "0x3F6A440", VA = "0x3F6E440", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x3F6E4F0", Offset = "0x3F6A4F0", VA = "0x3F6E4F0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x3F6E4F8", Offset = "0x3F6A4F8", VA = "0x3F6E4F8", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000500")]
			[Address(RVA = "0x3F6E530", Offset = "0x3F6A530", VA = "0x3F6E530", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private sealed class _003CCheckTimerToZeroCoroutine_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TimeManager _003C_003E4__this;

			[Token(Token = "0x17000042")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000504")]
				[Address(RVA = "0x3F6E614", Offset = "0x3F6A614", VA = "0x3F6E614", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000043")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000506")]
				[Address(RVA = "0x3F6E654", Offset = "0x3F6A654", VA = "0x3F6E654", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000501")]
			[Address(RVA = "0x3F6E538", Offset = "0x3F6A538", VA = "0x3F6E538")]
			[DebuggerHidden]
			public _003CCheckTimerToZeroCoroutine_003Ed__45(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000502")]
			[Address(RVA = "0x3F6E560", Offset = "0x3F6A560", VA = "0x3F6E560", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0x3F6E564", Offset = "0x3F6A564", VA = "0x3F6E564", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000504")]
			[Address(RVA = "0x3F6E614", Offset = "0x3F6A614", VA = "0x3F6E614", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000505")]
			[Address(RVA = "0x3F6E61C", Offset = "0x3F6A61C", VA = "0x3F6E61C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000506")]
			[Address(RVA = "0x3F6E654", Offset = "0x3F6A654", VA = "0x3F6E654", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private sealed class _003CCheckWeekPassedCoroutine_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TimeManager _003C_003E4__this;

			[Token(Token = "0x17000044")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600050A")]
				[Address(RVA = "0x3F6E738", Offset = "0x3F6A738", VA = "0x3F6E738", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000045")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600050C")]
				[Address(RVA = "0x3F6E778", Offset = "0x3F6A778", VA = "0x3F6E778", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0x3F6E65C", Offset = "0x3F6A65C", VA = "0x3F6E65C")]
			[DebuggerHidden]
			public _003CCheckWeekPassedCoroutine_003Ed__47(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000508")]
			[Address(RVA = "0x3F6E684", Offset = "0x3F6A684", VA = "0x3F6E684", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0x3F6E688", Offset = "0x3F6A688", VA = "0x3F6E688", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600050A")]
			[Address(RVA = "0x3F6E738", Offset = "0x3F6A738", VA = "0x3F6E738", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0x3F6E740", Offset = "0x3F6A740", VA = "0x3F6E740", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600050C")]
			[Address(RVA = "0x3F6E778", Offset = "0x3F6A778", VA = "0x3F6E778", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private struct _003CHandleTimeToWeekCutDown_003Ed__36 : IAsyncStateMachine
		{
			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TimeManager _003C_003E4__this;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600050D")]
			[Address(RVA = "0x3F6E780", Offset = "0x3F6A780", VA = "0x3F6E780", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600050E")]
			[Address(RVA = "0x3F6EA30", Offset = "0x3F6AA30", VA = "0x3F6EA30", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__29 : IAsyncStateMachine
		{
			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TimeManager _003C_003E4__this;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003CcheckCount_003E5__2;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int _003CchecksPerLog_003E5__3;

			[Token(Token = "0x600050F")]
			[Address(RVA = "0x3F6EA3C", Offset = "0x3F6AA3C", VA = "0x3F6EA3C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000510")]
			[Address(RVA = "0x3F6F444", Offset = "0x3F6B444", VA = "0x3F6F444", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private struct _003CInitializeTimeSource_003Ed__31 : IAsyncStateMachine
		{
			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TimeManager _003C_003E4__this;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000511")]
			[Address(RVA = "0x3F6F450", Offset = "0x3F6B450", VA = "0x3F6F450", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000512")]
			[Address(RVA = "0x3F6FABC", Offset = "0x3F6BABC", VA = "0x3F6FABC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class _003CLoadTimers_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TimeManager _003C_003E4__this;

			[Token(Token = "0x17000046")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000516")]
				[Address(RVA = "0x3F70044", Offset = "0x3F6C044", VA = "0x3F70044", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000047")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000518")]
				[Address(RVA = "0x3F70084", Offset = "0x3F6C084", VA = "0x3F70084", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000513")]
			[Address(RVA = "0x3F6FAC8", Offset = "0x3F6BAC8", VA = "0x3F6FAC8")]
			[DebuggerHidden]
			public _003CLoadTimers_003Ed__68(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000514")]
			[Address(RVA = "0x3F6FAF0", Offset = "0x3F6BAF0", VA = "0x3F6FAF0", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000515")]
			[Address(RVA = "0x3F6FAF4", Offset = "0x3F6BAF4", VA = "0x3F6FAF4", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000516")]
			[Address(RVA = "0x3F70044", Offset = "0x3F6C044", VA = "0x3F70044", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000517")]
			[Address(RVA = "0x3F7004C", Offset = "0x3F6C04C", VA = "0x3F7004C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000518")]
			[Address(RVA = "0x3F70084", Offset = "0x3F6C084", VA = "0x3F70084", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private struct _003COnApplicationStateChange_003Ed__52 : IAsyncStateMachine
		{
			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool hasFocus;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TimeManager _003C_003E4__this;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float _003Cstaytime_003E5__2;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<UIFramework.UIPanel>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000519")]
			[Address(RVA = "0x3F7008C", Offset = "0x3F6C08C", VA = "0x3F7008C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600051A")]
			[Address(RVA = "0x3F70830", Offset = "0x3F6C830", VA = "0x3F70830", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000E6")]
		[CompilerGenerated]
		private sealed class _003CSyncServerTimeCoroutine_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TimeManager _003C_003E4__this;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float _003CrequestTimer_003E5__2;

			[Token(Token = "0x17000048")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600051E")]
				[Address(RVA = "0x3F709F4", Offset = "0x3F6C9F4", VA = "0x3F709F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000049")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000520")]
				[Address(RVA = "0x3F70A34", Offset = "0x3F6CA34", VA = "0x3F70A34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600051B")]
			[Address(RVA = "0x3F7083C", Offset = "0x3F6C83C", VA = "0x3F7083C")]
			[DebuggerHidden]
			public _003CSyncServerTimeCoroutine_003Ed__38(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600051C")]
			[Address(RVA = "0x3F70864", Offset = "0x3F6C864", VA = "0x3F70864", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600051D")]
			[Address(RVA = "0x3F70868", Offset = "0x3F6C868", VA = "0x3F70868", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600051E")]
			[Address(RVA = "0x3F709F4", Offset = "0x3F6C9F4", VA = "0x3F709F4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600051F")]
			[Address(RVA = "0x3F709FC", Offset = "0x3F6C9FC", VA = "0x3F709FC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000520")]
			[Address(RVA = "0x3F70A34", Offset = "0x3F6CA34", VA = "0x3F70A34", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TimeSource _currentTimeSource;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _isFetchingNetworkTime;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, Timer> _timers;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action _onTimeReachZero;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action _onStandardNetworkTimeReachZero;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action _onTimeReachMondayZero;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action _onWeekPassed;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _offsetHours;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Timer toZeroTimer;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Timer toZeroStandardNetworkTime;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Timer toWeekTimer;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool initComplete;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Dictionary<string, Action> _cutdownTimerEvents;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Dictionary<string, Timer> _cutdownTimers;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<string> _toRemoveTimerKeys;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _getTimeCoroutine;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Coroutine _checkTimerToZeroCoroutine;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Coroutine _checkTimerEndEventCoroutine;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Coroutine _checkWeekPassedCoroutine;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool FirstCheckNewWeekFinish;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private DateTime lastFocusLossTime;

		[Token(Token = "0x1700003A")]
		public bool IsNetworkConnected
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x3E44B04", Offset = "0x3E40B04", VA = "0x3E44B04")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x3E44B0C", Offset = "0x3E40B0C", VA = "0x3E44B0C")]
			[CompilerGenerated]
			private set;
		}

		[Token(Token = "0x1700003B")]
		public int OffsetHours
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x3E44B18", Offset = "0x3E40B18", VA = "0x3E44B18")]
			get
			{
				return _offsetHours;
			}
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x3E44B20", Offset = "0x3E40B20", VA = "0x3E44B20")]
		public void AddOffsetHours(int hours)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x3E4509C", Offset = "0x3E4109C", VA = "0x3E4509C")]
		public void ClearOffsetHours()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x3E451B4", Offset = "0x3E411B4", VA = "0x3E451B4", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__29))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x3E45250", Offset = "0x3E41250", VA = "0x3E45250")]
		private void OnMiniGameOnShow(object[] args)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x3E45368", Offset = "0x3E41368", VA = "0x3E45368")]
		[AsyncStateMachine(typeof(_003CInitializeTimeSource_003Ed__31))]
		private UniTask InitializeTimeSource()
		{
			return default;
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x3E45400", Offset = "0x3E41400", VA = "0x3E45400")]
		private DateTime GetStartOfWeekForTimeManager(DateTime dt)
		{
			return default;
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x3E452C4", Offset = "0x3E412C4", VA = "0x3E452C4")]
		public void SaveLastExitTime()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x3E454BC", Offset = "0x3E414BC", VA = "0x3E454BC")]
		public void RegisterOnWeekPassed(Action action)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x3E4553C", Offset = "0x3E4153C", VA = "0x3E4553C")]
		public void UnRegisterOnWeekPassed(Action action)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x3E455BC", Offset = "0x3E415BC", VA = "0x3E455BC")]
		[AsyncStateMachine(typeof(_003CHandleTimeToWeekCutDown_003Ed__36))]
		private void HandleTimeToWeekCutDown()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x3E4564C", Offset = "0x3E4164C", VA = "0x3E4564C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x3E45650", Offset = "0x3E41650", VA = "0x3E45650")]
		[IteratorStateMachine(typeof(_003CSyncServerTimeCoroutine_003Ed__38))]
		private IEnumerator SyncServerTimeCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x3E456B8", Offset = "0x3E416B8", VA = "0x3E456B8")]
		private void InitToZeroTimer()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x3E44C50", Offset = "0x3E40C50", VA = "0x3E44C50")]
		private void CheckTimerToZero()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x3E45908", Offset = "0x3E41908", VA = "0x3E45908")]
		private void InitToWeekTimer()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x3E45984", Offset = "0x3E41984", VA = "0x3E45984")]
		private void CheckTimerToWeek()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x3E45ABC", Offset = "0x3E41ABC", VA = "0x3E45ABC")]
		private void CheckWeekPassed()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x3E45C00", Offset = "0x3E41C00", VA = "0x3E45C00")]
		private void CheckTimerEndEvent()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x3E45F48", Offset = "0x3E41F48", VA = "0x3E45F48")]
		[IteratorStateMachine(typeof(_003CCheckTimerToZeroCoroutine_003Ed__45))]
		private IEnumerator CheckTimerToZeroCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x3E45FB0", Offset = "0x3E41FB0", VA = "0x3E45FB0")]
		[IteratorStateMachine(typeof(_003CCheckTimerEndEventCoroutine_003Ed__46))]
		private IEnumerator CheckTimerEndEventCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x3E46018", Offset = "0x3E42018", VA = "0x3E46018")]
		[IteratorStateMachine(typeof(_003CCheckWeekPassedCoroutine_003Ed__47))]
		private IEnumerator CheckWeekPassedCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x3E46080", Offset = "0x3E42080", VA = "0x3E46080")]
		private void SyncServerTime()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x3E460C8", Offset = "0x3E420C8", VA = "0x3E460C8")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x3E46190", Offset = "0x3E42190", VA = "0x3E46190")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x3E460E0", Offset = "0x3E420E0", VA = "0x3E460E0")]
		[AsyncStateMachine(typeof(_003COnApplicationStateChange_003Ed__52))]
		private UniTask OnApplicationStateChange(bool hasFocus)
		{
			return default;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x3E46194", Offset = "0x3E42194", VA = "0x3E46194")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x3E454B0", Offset = "0x3E414B0", VA = "0x3E454B0")]
		public DateTime GetNetworkTime(bool useStandardNetworkTime = false)
		{
			return default;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x3E33908", Offset = "0x3E2F908", VA = "0x3E33908")]
		public DateTime GetLocalNetworkTime()
		{
			return default;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x3E46278", Offset = "0x3E42278", VA = "0x3E46278")]
		public DateTime GetStandardNetworkTime()
		{
			return default;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x3E46340", Offset = "0x3E42340", VA = "0x3E46340")]
		public void ShowAllCutDowmLog()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x3E32D10", Offset = "0x3E2ED10", VA = "0x3E32D10")]
		public Timer CreateTimer(string key, TimeSpan duration, bool isCountdown, bool useStandardNetTime = false)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x3E32E1C", Offset = "0x3E2EE1C", VA = "0x3E32E1C")]
		public void RegisterOnCutdownTimerEnd(string timerKey, Action action)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x3E3304C", Offset = "0x3E2F04C", VA = "0x3E3304C")]
		public void RemoveTimerEvent(string timerKey)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x3E467D8", Offset = "0x3E427D8", VA = "0x3E467D8")]
		public void RemoveTimerEvent(string timerKey, Action action)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x3E46904", Offset = "0x3E42904", VA = "0x3E46904")]
		public void RegisterOnTimeToZero(Action action)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x3E46984", Offset = "0x3E42984", VA = "0x3E46984")]
		public void RegisterOnStandardNetworkTimeToZero(Action action)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x3E46A04", Offset = "0x3E42A04", VA = "0x3E46A04")]
		public void UnRegisterOnTimeToZero(Action action)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x3E46A84", Offset = "0x3E42A84", VA = "0x3E46A84")]
		public void UnRegisterOnStandardNetworkTimeToZero(Action action)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x3E46B04", Offset = "0x3E42B04", VA = "0x3E46B04")]
		public void RegisterOnTimeToMondayZero(Action action)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x3E32A30", Offset = "0x3E2EA30", VA = "0x3E32A30")]
		public Timer GetTimer(string key)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x3E46B84", Offset = "0x3E42B84", VA = "0x3E46B84")]
		[IteratorStateMachine(typeof(_003CLoadTimers_003Ed__68))]
		private IEnumerator LoadTimers()
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x3E46BEC", Offset = "0x3E42BEC", VA = "0x3E46BEC")]
		public void RemoveTimer(string key)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x3E32C78", Offset = "0x3E2EC78", VA = "0x3E32C78")]
		public TimeSpan GetTimeSpanToZero()
		{
			return default;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x3E4577C", Offset = "0x3E4177C", VA = "0x3E4577C")]
		public TimeSpan GetTimeSpanToZeroStandardNetworkTime()
		{
			return default;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x3E45814", Offset = "0x3E41814", VA = "0x3E45814")]
		public TimeSpan GetTimeSpanToWeek()
		{
			return default;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x3E46D80", Offset = "0x3E42D80", VA = "0x3E46D80")]
		public TimeSpan GetTimeSpanToDayZero(int dayCount)
		{
			return default;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x3E4659C", Offset = "0x3E4259C", VA = "0x3E4659C")]
		public void InitAddTimeInfo(Timer timer)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x3E44F20", Offset = "0x3E40F20", VA = "0x3E44F20")]
		public static void ChangeTimeInfoEndTime(string key, DateTime endTime)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x3E32AD8", Offset = "0x3E2EAD8", VA = "0x3E32AD8")]
		public void RemoveTimeInfo(string timerKey)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x3E46E8C", Offset = "0x3E42E8C", VA = "0x3E46E8C")]
		public TimeManager()
		{
		}
	}
}
