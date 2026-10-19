using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000346")]
	public class MageRoleBehaviour : TerranBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000347")]
		[CompilerGenerated]
		private struct _003CAtkCallBack_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4002433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MageRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int attackNum;

			[Token(Token = "0x4002437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000EAE")]
			[Address(RVA = "0x3D759DC", Offset = "0x3D719DC", VA = "0x3D759DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000EAF")]
			[Address(RVA = "0x3D76340", Offset = "0x3D72340", VA = "0x3D76340", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000348")]
		[CompilerGenerated]
		private sealed class _003CDelayDestroyFireObj_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4002439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400243A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400243B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MageRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x170000E8")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000EB3")]
				[Address(RVA = "0x3D763F0", Offset = "0x3D723F0", VA = "0x3D763F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000E9")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000EB5")]
				[Address(RVA = "0x3D76430", Offset = "0x3D72430", VA = "0x3D76430", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000EB0")]
			[Address(RVA = "0x3D758C4", Offset = "0x3D718C4", VA = "0x3D758C4")]
			[DebuggerHidden]
			public _003CDelayDestroyFireObj_003Ed__8(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000EB1")]
			[Address(RVA = "0x3D7634C", Offset = "0x3D7234C", VA = "0x3D7634C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000EB2")]
			[Address(RVA = "0x3D76350", Offset = "0x3D72350", VA = "0x3D76350", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000EB3")]
			[Address(RVA = "0x3D763F0", Offset = "0x3D723F0", VA = "0x3D763F0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000EB4")]
			[Address(RVA = "0x3D763F8", Offset = "0x3D723F8", VA = "0x3D763F8", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000EB5")]
			[Address(RVA = "0x3D76430", Offset = "0x3D72430", VA = "0x3D76430", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000349")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x400243C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400243D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400243E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MageRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400243F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalRoleInfo info;

			[Token(Token = "0x4002440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x4002441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int cardLevel;

			[Token(Token = "0x4002442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RareLevel rareLevel;

			[Token(Token = "0x4002443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string relativeCardID;

			[Token(Token = "0x4002444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CardFettersType fettersType;

			[Token(Token = "0x4002445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public AtkWayType atkWayType;

			[Token(Token = "0x4002446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000EB6")]
			[Address(RVA = "0x3D76438", Offset = "0x3D72438", VA = "0x3D76438", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000EB7")]
			[Address(RVA = "0x3D76750", Offset = "0x3D72750", VA = "0x3D76750", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200034A")]
		[CompilerGenerated]
		private struct _003CMageSkill_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4002447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MageRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400244A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000EB8")]
			[Address(RVA = "0x3D7675C", Offset = "0x3D7275C", VA = "0x3D7675C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000EB9")]
			[Address(RVA = "0x3D76ACC", Offset = "0x3D72ACC", VA = "0x3D76ACC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400242F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private GameObject _meteorite;

		[Token(Token = "0x4002430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private GameObject fireObj;

		[Token(Token = "0x4002431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private Coroutine _myCoroutine;

		[Token(Token = "0x4002432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private Tweener tw;

		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x3D75638", Offset = "0x3D71638", VA = "0x3D75638", Slot = "20")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__1))]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x3D7571C", Offset = "0x3D7171C", VA = "0x3D7571C", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x3D75738", Offset = "0x3D71738", VA = "0x3D75738")]
		[AsyncStateMachine(typeof(_003CMageSkill_003Ed__3))]
		private void MageSkill()
		{
		}

		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x3D757C4", Offset = "0x3D717C4", VA = "0x3D757C4", Slot = "30")]
		[AsyncStateMachine(typeof(_003CAtkCallBack_003Ed__7))]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x3D75864", Offset = "0x3D71864", VA = "0x3D75864")]
		[IteratorStateMachine(typeof(_003CDelayDestroyFireObj_003Ed__8))]
		private IEnumerator DelayDestroyFireObj()
		{
			return null;
		}

		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x3D758EC", Offset = "0x3D718EC", VA = "0x3D758EC", Slot = "39")]
		protected override void OnRecycle()
		{
		}

		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x3D7591C", Offset = "0x3D7191C", VA = "0x3D7591C")]
		private void Kill()
		{
		}

		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x3D759C0", Offset = "0x3D719C0", VA = "0x3D759C0")]
		public MageRoleBehaviour()
		{
		}
	}
}
