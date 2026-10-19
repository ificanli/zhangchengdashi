using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace SDKModule.Cheat
{
	[Token(Token = "0x2000187")]
	public class ArcherHexTest : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000189")]
		[CompilerGenerated]
		private struct _003CInitializeArcherData_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4001A99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001A9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001A9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArcherHexTest _003C_003E4__this;

			[Token(Token = "0x4001A9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x3F7927C", Offset = "0x3F7527C", VA = "0x3F7927C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x3F79C00", Offset = "0x3F75C00", VA = "0x3F79C00", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200018A")]
		[CompilerGenerated]
		private struct _003COnGameStart_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4001A9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001A9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001A9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArcherHexTest _003C_003E4__this;

			[Token(Token = "0x4001AA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x3F79C0C", Offset = "0x3F75C0C", VA = "0x3F79C0C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x3F7A610", Offset = "0x3F76610", VA = "0x3F7A610", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200018B")]
		[CompilerGenerated]
		private struct _003CSpawnArchersNearMainTower_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4001AA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001AA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001AA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArcherHexTest _003C_003E4__this;

			[Token(Token = "0x4001AA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool isEnemy;

			[Token(Token = "0x4001AA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Vector3 _003CmainTowerPos_003E5__2;

			[Token(Token = "0x4001AA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GameObject _003CrolePrefab_003E5__3;

			[Token(Token = "0x4001AA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003Ci_003E5__4;

			[Token(Token = "0x4001AA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x3F7A61C", Offset = "0x3F7661C", VA = "0x3F7A61C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x3F7B284", Offset = "0x3F77284", VA = "0x3F7B284", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200018C")]
		[CompilerGenerated]
		private struct _003CStartSpawningArchers_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4001AA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001AAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001AAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ArcherHexTest _003C_003E4__this;

			[Token(Token = "0x4001AAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private CancellationToken _003CcancellationToken_003E5__2;

			[Token(Token = "0x4001AAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x3F7B290", Offset = "0x3F77290", VA = "0x3F7B290", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x3F7B9E8", Offset = "0x3F779E8", VA = "0x3F7B9E8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int archersPerSecond;

		[Token(Token = "0x4001A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _hasStarted;

		[Token(Token = "0x4001A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject _playerRolePrefab;

		[Token(Token = "0x4001A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject _enemyRolePrefab;

		[Token(Token = "0x4001A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GlobalRoleInfo _archerRoleInfo;

		[Token(Token = "0x4001A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _archerCardId;

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x3F786D8", Offset = "0x3F746D8", VA = "0x3F786D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x3F787A0", Offset = "0x3F747A0", VA = "0x3F787A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x3F788C0", Offset = "0x3F748C0", VA = "0x3F788C0")]
		[AsyncStateMachine(typeof(_003COnGameStart_003Ed__8))]
		private void OnGameStart(object o)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x3F7894C", Offset = "0x3F7494C", VA = "0x3F7894C")]
		[AsyncStateMachine(typeof(_003CInitializeArcherData_003Ed__9))]
		private UniTask InitializeArcherData()
		{
			return default;
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x3F789DC", Offset = "0x3F749DC", VA = "0x3F789DC")]
		[AsyncStateMachine(typeof(_003CStartSpawningArchers_003Ed__10))]
		private UniTaskVoid StartSpawningArchers()
		{
			return default;
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x3F78A54", Offset = "0x3F74A54", VA = "0x3F78A54")]
		[AsyncStateMachine(typeof(_003CSpawnArchersNearMainTower_003Ed__11))]
		private UniTask SpawnArchersNearMainTower(bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x3F78AF8", Offset = "0x3F74AF8", VA = "0x3F78AF8")]
		private Vector3 GetMainTowerPosition(bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x3F78DA0", Offset = "0x3F74DA0", VA = "0x3F78DA0")]
		private void DisableHexOpening()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x3F79180", Offset = "0x3F75180", VA = "0x3F79180")]
		public ArcherHexTest()
		{
		}
	}
}
