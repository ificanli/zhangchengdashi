using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002CC")]
	public class GodSlayerSpearBehaviour : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002CE")]
		[CompilerGenerated]
		private struct _003CCallBack_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x400222A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400222B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400222C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GodSlayerSpearBehaviour _003C_003E4__this;

			[Token(Token = "0x400222D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000CB1")]
			[Address(RVA = "0x3D46398", Offset = "0x3D42398", VA = "0x3D46398", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000CB2")]
			[Address(RVA = "0x3D46604", Offset = "0x3D42604", VA = "0x3D46604", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20002CF")]
		[CompilerGenerated]
		private sealed class _003CFindTarget_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400222E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400222F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4002230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GodSlayerSpearBehaviour _003C_003E4__this;

			[Token(Token = "0x170000DA")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CB6")]
				[Address(RVA = "0x3D467A8", Offset = "0x3D427A8", VA = "0x3D467A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000DB")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CB8")]
				[Address(RVA = "0x3D467E8", Offset = "0x3D427E8", VA = "0x3D467E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000CB3")]
			[Address(RVA = "0x3D460C8", Offset = "0x3D420C8", VA = "0x3D460C8")]
			[DebuggerHidden]
			public _003CFindTarget_003Ed__20(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000CB4")]
			[Address(RVA = "0x3D46610", Offset = "0x3D42610", VA = "0x3D46610", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CB5")]
			[Address(RVA = "0x3D46614", Offset = "0x3D42614", VA = "0x3D46614", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0x3D467A8", Offset = "0x3D427A8", VA = "0x3D467A8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x3D467B0", Offset = "0x3D427B0", VA = "0x3D467B0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000CB8")]
			[Address(RVA = "0x3D467E8", Offset = "0x3D427E8", VA = "0x3D467E8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002D0")]
		[CompilerGenerated]
		private struct _003CStartDotDamageAroundAsync_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x4002231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GodSlayerSpearBehaviour _003C_003E4__this;

			[Token(Token = "0x4002234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 centerPos;

			[Token(Token = "0x4002235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool _003CtargetIsEnemy_003E5__2;

			[Token(Token = "0x4002236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float _003CendTime_003E5__3;

			[Token(Token = "0x4002237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000CB9")]
			[Address(RVA = "0x3D467F0", Offset = "0x3D427F0", VA = "0x3D467F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000CBA")]
			[Address(RVA = "0x3D46DEC", Offset = "0x3D42DEC", VA = "0x3D46DEC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int damage;

		[Token(Token = "0x400221A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 tarPos;

		[Token(Token = "0x400221B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RoleBehaviour target;

		[Token(Token = "0x400221C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool canMove;

		[Token(Token = "0x400221D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool isEnemy;

		[Token(Token = "0x400221E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool noTarget;

		[Token(Token = "0x400221F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		private bool _bGroupExecuteEnabled;

		[Token(Token = "0x4002220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _bGroupDotDamagePerSecond;

		[Token(Token = "0x4002221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _bGroupDotDurationSeconds;

		[Token(Token = "0x4002222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _bGroupDotRadius;

		[Token(Token = "0x4002223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _bGroupDotStarted;

		[Token(Token = "0x4002224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly List<RoleBehaviour> _dotRoleSnapshot;

		[Token(Token = "0x4002225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<RoleBehaviour> findRoleList;

		[Token(Token = "0x4002226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool noGoldCard;

		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x3D45480", Offset = "0x3D41480", VA = "0x3D45480")]
		public void InitBGroupExecuteAndDot(int damagePerSecond, float durationSeconds, RoleBehaviour target, bool isEnemy)
		{
		}

		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x3D454A8", Offset = "0x3D414A8", VA = "0x3D454A8")]
		public void Init(int damage, RoleBehaviour target, bool isEnemy)
		{
		}

		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x3D45818", Offset = "0x3D41818", VA = "0x3D45818")]
		private void Update()
		{
		}

		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x3D45F20", Offset = "0x3D41F20", VA = "0x3D45F20")]
		[AsyncStateMachine(typeof(_003CStartDotDamageAroundAsync_003Ed__17))]
		private UniTaskVoid StartDotDamageAroundAsync(Vector3 centerPos)
		{
			return default;
		}

		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x3D45DD4", Offset = "0x3D41DD4", VA = "0x3D45DD4")]
		private void Find()
		{
		}

		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x3D4604C", Offset = "0x3D4204C", VA = "0x3D4604C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x3D457B8", Offset = "0x3D417B8", VA = "0x3D457B8")]
		[IteratorStateMachine(typeof(_003CFindTarget_003Ed__20))]
		private IEnumerator FindTarget()
		{
			return null;
		}

		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x3D45FBC", Offset = "0x3D41FBC", VA = "0x3D45FBC")]
		[AsyncStateMachine(typeof(_003CCallBack_003Ed__21))]
		private void CallBack()
		{
		}

		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x3D460F0", Offset = "0x3D420F0", VA = "0x3D460F0")]
		private void GameEnd(object o)
		{
		}

		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x3D461FC", Offset = "0x3D421FC", VA = "0x3D461FC")]
		public GodSlayerSpearBehaviour()
		{
		}
	}
}
