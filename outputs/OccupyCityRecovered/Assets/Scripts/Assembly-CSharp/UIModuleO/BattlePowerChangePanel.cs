using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x20006F9")]
	public class BattlePowerChangePanel : BattlePowerChangePanelComponents
	{
		[Token(Token = "0x20006FA")]
		private enum PlayPhase
		{
			[Token(Token = "0x4003799")]
			Idle = 0,
			[Token(Token = "0x400379A")]
			Showing = 1,
			[Token(Token = "0x400379B")]
			AddSub = 2,
			[Token(Token = "0x400379C")]
			WaitBeforeNumber = 3,
			[Token(Token = "0x400379D")]
			ScrollingNumber = 4,
			[Token(Token = "0x400379E")]
			WaitBeforeHide = 5,
			[Token(Token = "0x400379F")]
			Hiding = 6
		}

		[Token(Token = "0x20006FC")]
		[CompilerGenerated]
		private sealed class _003CPlayAnimatorStateCoroutine_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40037A2")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40037A3")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40037A4")]
			[FieldOffset(Offset = "0x20")]
			public BattlePowerChangePanel _003C_003E4__this;

			[Token(Token = "0x40037A5")]
			[FieldOffset(Offset = "0x28")]
			public string stateName;

			[Token(Token = "0x40037A6")]
			[FieldOffset(Offset = "0x30")]
			public float completeNormalizedTime;

			[Token(Token = "0x40037A7")]
			[FieldOffset(Offset = "0x34")]
			public int sequenceVersion;

			[Token(Token = "0x40037A8")]
			[FieldOffset(Offset = "0x38")]
			private Animator _003Canimator_003E5__2;

			[Token(Token = "0x40037A9")]
			[FieldOffset(Offset = "0x40")]
			private int _003CstateHash_003E5__3;

			[Token(Token = "0x170002D4")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60025E1")]
				[Address(RVA = "0x3F8B6EC", Offset = "0x3F876EC", VA = "0x3F8B6EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170002D5")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60025E3")]
				[Address(RVA = "0x3F8B72C", Offset = "0x3F8772C", VA = "0x3F8B72C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60025DE")]
			[Address(RVA = "0x3F8B434", Offset = "0x3F87434", VA = "0x3F8B434")]
			[DebuggerHidden]
			public _003CPlayAnimatorStateCoroutine_003Ed__38(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60025DF")]
			[Address(RVA = "0x3F8B5A4", Offset = "0x3F875A4", VA = "0x3F8B5A4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60025E0")]
			[Address(RVA = "0x3F8B5A8", Offset = "0x3F875A8", VA = "0x3F8B5A8", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60025E1")]
			[Address(RVA = "0x3F8B6EC", Offset = "0x3F876EC", VA = "0x3F8B6EC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60025E2")]
			[Address(RVA = "0x3F8B6F4", Offset = "0x3F876F4", VA = "0x3F8B6F4", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60025E3")]
			[Address(RVA = "0x3F8B72C", Offset = "0x3F8772C", VA = "0x3F8B72C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20006FD")]
		[CompilerGenerated]
		private sealed class _003CRunChangeBodyCoroutine_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40037AA")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40037AB")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40037AC")]
			[FieldOffset(Offset = "0x20")]
			public BattlePowerChangePanel _003C_003E4__this;

			[Token(Token = "0x40037AD")]
			[FieldOffset(Offset = "0x28")]
			public int sequenceVersion;

			[Token(Token = "0x170002D6")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60025E7")]
				[Address(RVA = "0x3F8B95C", Offset = "0x3F8795C", VA = "0x3F8B95C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170002D7")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60025E9")]
				[Address(RVA = "0x3F8B99C", Offset = "0x3F8799C", VA = "0x3F8B99C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60025E4")]
			[Address(RVA = "0x3F8AF0C", Offset = "0x3F86F0C", VA = "0x3F8AF0C")]
			[DebuggerHidden]
			public _003CRunChangeBodyCoroutine_003Ed__29(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60025E5")]
			[Address(RVA = "0x3F8B734", Offset = "0x3F87734", VA = "0x3F8B734", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60025E6")]
			[Address(RVA = "0x3F8B738", Offset = "0x3F87738", VA = "0x3F8B738", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60025E7")]
			[Address(RVA = "0x3F8B95C", Offset = "0x3F8795C", VA = "0x3F8B95C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60025E8")]
			[Address(RVA = "0x3F8B964", Offset = "0x3F87964", VA = "0x3F8B964", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60025E9")]
			[Address(RVA = "0x3F8B99C", Offset = "0x3F8799C", VA = "0x3F8B99C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20006FE")]
		[CompilerGenerated]
		private sealed class _003CRunFullSequenceCoroutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40037AE")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40037AF")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40037B0")]
			[FieldOffset(Offset = "0x20")]
			public BattlePowerChangePanel _003C_003E4__this;

			[Token(Token = "0x40037B1")]
			[FieldOffset(Offset = "0x28")]
			public int sequenceVersion;

			[Token(Token = "0x170002D8")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60025ED")]
				[Address(RVA = "0x3F8BAD0", Offset = "0x3F87AD0", VA = "0x3F8BAD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170002D9")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60025EF")]
				[Address(RVA = "0x3F8BB10", Offset = "0x3F87B10", VA = "0x3F8BB10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60025EA")]
			[Address(RVA = "0x3F8AEE4", Offset = "0x3F86EE4", VA = "0x3F8AEE4")]
			[DebuggerHidden]
			public _003CRunFullSequenceCoroutine_003Ed__28(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60025EB")]
			[Address(RVA = "0x3F8B9A4", Offset = "0x3F879A4", VA = "0x3F8B9A4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60025EC")]
			[Address(RVA = "0x3F8B9A8", Offset = "0x3F879A8", VA = "0x3F8B9A8", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60025ED")]
			[Address(RVA = "0x3F8BAD0", Offset = "0x3F87AD0", VA = "0x3F8BAD0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60025EE")]
			[Address(RVA = "0x3F8BAD8", Offset = "0x3F87AD8", VA = "0x3F8BAD8", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60025EF")]
			[Address(RVA = "0x3F8BB10", Offset = "0x3F87B10", VA = "0x3F8BB10", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20006FF")]
		[CompilerGenerated]
		private sealed class _003CScrollPowerToTargetCoroutine_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40037B2")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40037B3")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40037B4")]
			[FieldOffset(Offset = "0x20")]
			public BattlePowerChangePanel _003C_003E4__this;

			[Token(Token = "0x40037B5")]
			[FieldOffset(Offset = "0x28")]
			public int sequenceVersion;

			[Token(Token = "0x170002DA")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60025F3")]
				[Address(RVA = "0x3F8BD50", Offset = "0x3F87D50", VA = "0x3F8BD50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170002DB")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60025F5")]
				[Address(RVA = "0x3F8BD90", Offset = "0x3F87D90", VA = "0x3F8BD90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60025F0")]
			[Address(RVA = "0x3F8B388", Offset = "0x3F87388", VA = "0x3F8B388")]
			[DebuggerHidden]
			public _003CScrollPowerToTargetCoroutine_003Ed__36(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60025F1")]
			[Address(RVA = "0x3F8BB18", Offset = "0x3F87B18", VA = "0x3F8BB18", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60025F2")]
			[Address(RVA = "0x3F8BB1C", Offset = "0x3F87B1C", VA = "0x3F8BB1C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60025F3")]
			[Address(RVA = "0x3F8BD50", Offset = "0x3F87D50", VA = "0x3F8BD50", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60025F4")]
			[Address(RVA = "0x3F8BD58", Offset = "0x3F87D58", VA = "0x3F8BD58", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60025F5")]
			[Address(RVA = "0x3F8BD90", Offset = "0x3F87D90", VA = "0x3F8BD90", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000700")]
		[CompilerGenerated]
		private sealed class _003CWaitSecondsCoroutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40037B6")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40037B7")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40037B8")]
			[FieldOffset(Offset = "0x20")]
			public BattlePowerChangePanel _003C_003E4__this;

			[Token(Token = "0x40037B9")]
			[FieldOffset(Offset = "0x28")]
			public int sequenceVersion;

			[Token(Token = "0x40037BA")]
			[FieldOffset(Offset = "0x2C")]
			public float seconds;

			[Token(Token = "0x40037BB")]
			[FieldOffset(Offset = "0x30")]
			private float _003Celapsed_003E5__2;

			[Token(Token = "0x170002DC")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60025F9")]
				[Address(RVA = "0x3F8BE30", Offset = "0x3F87E30", VA = "0x3F8BE30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170002DD")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60025FB")]
				[Address(RVA = "0x3F8BE70", Offset = "0x3F87E70", VA = "0x3F8BE70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60025F6")]
			[Address(RVA = "0x3F8AFB4", Offset = "0x3F86FB4", VA = "0x3F8AFB4")]
			[DebuggerHidden]
			public _003CWaitSecondsCoroutine_003Ed__30(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60025F7")]
			[Address(RVA = "0x3F8BD98", Offset = "0x3F87D98", VA = "0x3F8BD98", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60025F8")]
			[Address(RVA = "0x3F8BD9C", Offset = "0x3F87D9C", VA = "0x3F8BD9C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60025F9")]
			[Address(RVA = "0x3F8BE30", Offset = "0x3F87E30", VA = "0x3F8BE30", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60025FA")]
			[Address(RVA = "0x3F8BE38", Offset = "0x3F87E38", VA = "0x3F8BE38", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60025FB")]
			[Address(RVA = "0x3F8BE70", Offset = "0x3F87E70", VA = "0x3F8BE70", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4003786")]
		private const string AnimShow = "Show";

		[Token(Token = "0x4003787")]
		private const string AnimAdd = "Add";

		[Token(Token = "0x4003788")]
		private const string AnimSub = "Sub";

		[Token(Token = "0x4003789")]
		private const string AnimHide = "Hide";

		[Token(Token = "0x400378A")]
		private const float AddSubScrollStartNormalizedTime = 0.6f;

		[Token(Token = "0x400378B")]
		private const float WaitBeforeHideSeconds = 0.4f;

		[Token(Token = "0x400378C")]
		private const float NumberScrollDurationSeconds = 0.5f;

		[Token(Token = "0x400378D")]
		[FieldOffset(Offset = "0x70")]
		private bool _isVisible;

		[Token(Token = "0x400378E")]
		[FieldOffset(Offset = "0x71")]
		private bool _playShowOnEntry;

		[Token(Token = "0x400378F")]
		[FieldOffset(Offset = "0x74")]
		private PlayPhase _phase;

		[Token(Token = "0x4003790")]
		[FieldOffset(Offset = "0x78")]
		private int _sequenceVersion;

		[Token(Token = "0x4003791")]
		[FieldOffset(Offset = "0x80")]
		private Coroutine _sequenceCoroutine;

		[Token(Token = "0x4003792")]
		[FieldOffset(Offset = "0x88")]
		private Tween _powerTween;

		[Token(Token = "0x4003793")]
		[FieldOffset(Offset = "0x90")]
		private bool _scrollSegmentDone;

		[Token(Token = "0x4003794")]
		[FieldOffset(Offset = "0x94")]
		private int _displayPower;

		[Token(Token = "0x4003795")]
		[FieldOffset(Offset = "0x98")]
		private int _scrollTargetPower;

		[Token(Token = "0x4003796")]
		[FieldOffset(Offset = "0x9C")]
		private PlayerBattlePowerChangeInfo _activeInfo;

		[Token(Token = "0x4003797")]
		[FieldOffset(Offset = "0xAC")]
		private PlayerBattlePowerChangeInfo _latestInfo;

		[Token(Token = "0x60025C3")]
		[Address(RVA = "0x3F8A488", Offset = "0x3F86488", VA = "0x3F8A488", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60025C4")]
		[Address(RVA = "0x3F8A748", Offset = "0x3F86748", VA = "0x3F8A748")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60025C5")]
		[Address(RVA = "0x3F8A978", Offset = "0x3F86978", VA = "0x3F8A978")]
		private void PlayerBattlePowerChanged(object o)
		{
		}

		[Token(Token = "0x60025C6")]
		[Address(RVA = "0x3F8AA24", Offset = "0x3F86A24", VA = "0x3F8AA24")]
		private void HandleBattlePowerChange(PlayerBattlePowerChangeInfo info)
		{
		}

		[Token(Token = "0x60025C7")]
		[Address(RVA = "0x3F8AB98", Offset = "0x3F86B98", VA = "0x3F8AB98")]
		private void StartFullSequence(PlayerBattlePowerChangeInfo info)
		{
		}

		[Token(Token = "0x60025C8")]
		[Address(RVA = "0x3F8AAC0", Offset = "0x3F86AC0", VA = "0x3F8AAC0")]
		private void RestartFromAddSub(PlayerBattlePowerChangeInfo info)
		{
		}

		[Token(Token = "0x60025C9")]
		[Address(RVA = "0x3F8ABD4", Offset = "0x3F86BD4", VA = "0x3F8ABD4")]
		private int BeginSequence()
		{
			return default;
		}

		[Token(Token = "0x60025CA")]
		[Address(RVA = "0x3F8AB84", Offset = "0x3F86B84", VA = "0x3F8AB84")]
		private void RestartFromShow(PlayerBattlePowerChangeInfo info)
		{
		}

		[Token(Token = "0x60025CB")]
		[Address(RVA = "0x3F8AB04", Offset = "0x3F86B04", VA = "0x3F8AB04")]
		private void MergeDuringScroll(PlayerBattlePowerChangeInfo info)
		{
		}

		[Token(Token = "0x60025CC")]
		[Address(RVA = "0x3F8ABEC", Offset = "0x3F86BEC", VA = "0x3F8ABEC")]
		[IteratorStateMachine(typeof(_003CRunFullSequenceCoroutine_003Ed__28))]
		private IEnumerator RunFullSequenceCoroutine(int sequenceVersion)
		{
			return null;
		}

		[Token(Token = "0x60025CD")]
		[Address(RVA = "0x3F8AC5C", Offset = "0x3F86C5C", VA = "0x3F8AC5C")]
		[IteratorStateMachine(typeof(_003CRunChangeBodyCoroutine_003Ed__29))]
		private IEnumerator RunChangeBodyCoroutine(int sequenceVersion)
		{
			return null;
		}

		[Token(Token = "0x60025CE")]
		[Address(RVA = "0x3F8AF34", Offset = "0x3F86F34", VA = "0x3F8AF34")]
		[IteratorStateMachine(typeof(_003CWaitSecondsCoroutine_003Ed__30))]
		private IEnumerator WaitSecondsCoroutine(float seconds, int sequenceVersion)
		{
			return null;
		}

		[Token(Token = "0x60025CF")]
		[Address(RVA = "0x3F8AFDC", Offset = "0x3F86FDC", VA = "0x3F8AFDC")]
		private bool IsCurrentSequence(int sequenceVersion)
		{
			return default;
		}

		[Token(Token = "0x60025D0")]
		[Address(RVA = "0x3F8AA74", Offset = "0x3F86A74", VA = "0x3F8AA74")]
		private void ApplyPowerDisplay(PlayerBattlePowerChangeInfo info)
		{
		}

		[Token(Token = "0x60025D1")]
		[Address(RVA = "0x3F8B0B4", Offset = "0x3F870B4", VA = "0x3F8B0B4")]
		private void ApplyPowerAndDeltaTexts(PlayerBattlePowerChangeInfo info)
		{
		}

		[Token(Token = "0x60025D2")]
		[Address(RVA = "0x3F8ACCC", Offset = "0x3F86CCC", VA = "0x3F8ACCC")]
		private void ApplyDeltaTexts(PlayerBattlePowerChangeInfo info)
		{
		}

		[Token(Token = "0x60025D3")]
		[Address(RVA = "0x3F8AE1C", Offset = "0x3F86E1C", VA = "0x3F8AE1C")]
		private void PlayAddSubAnimation(bool isIncrease)
		{
		}

		[Token(Token = "0x60025D4")]
		[Address(RVA = "0x3F8B318", Offset = "0x3F87318", VA = "0x3F8B318")]
		[IteratorStateMachine(typeof(_003CScrollPowerToTargetCoroutine_003Ed__36))]
		private IEnumerator ScrollPowerToTargetCoroutine(int sequenceVersion)
		{
			return null;
		}

		[Token(Token = "0x60025D5")]
		[Address(RVA = "0x3F8AEA8", Offset = "0x3F86EA8", VA = "0x3F8AEA8")]
		private void RestartPowerScrollTween()
		{
		}

		[Token(Token = "0x60025D6")]
		[Address(RVA = "0x3F8B3B0", Offset = "0x3F873B0", VA = "0x3F8B3B0")]
		[IteratorStateMachine(typeof(_003CPlayAnimatorStateCoroutine_003Ed__38))]
		private IEnumerator PlayAnimatorStateCoroutine(string stateName, int sequenceVersion, float completeNormalizedTime = 1f)
		{
			return null;
		}

		[Token(Token = "0x60025D7")]
		[Address(RVA = "0x3F8A8BC", Offset = "0x3F868BC", VA = "0x3F8A8BC")]
		private void SetVisibleState(bool visible)
		{
		}

		[Token(Token = "0x60025D8")]
		[Address(RVA = "0x3F8A840", Offset = "0x3F86840", VA = "0x3F8A840")]
		private void CancelSequence()
		{
		}

		[Token(Token = "0x60025D9")]
		[Address(RVA = "0x3F8A894", Offset = "0x3F86894", VA = "0x3F8A894")]
		private void KillPowerTween()
		{
		}

		[Token(Token = "0x60025DA")]
		[Address(RVA = "0x3F8B45C", Offset = "0x3F8745C", VA = "0x3F8B45C")]
		public BattlePowerChangePanel()
		{
		}
	}
}
