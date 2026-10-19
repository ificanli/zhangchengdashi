using System.Collections.Concurrent;
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
	[Token(Token = "0x2000279")]
	public class DynamicTargetFinder : MonoBehaviour
	{
		[Token(Token = "0x200027A")]
		private class RoleCacheData
		{
			[Token(Token = "0x4001FB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 lastPosition;

			[Token(Token = "0x4001FB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float lastDistance;

			[Token(Token = "0x4001FB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector2Int gridCell;

			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0x440F4E0", Offset = "0x440B4E0", VA = "0x440F4E0")]
			public RoleCacheData()
			{
			}
		}

		[Token(Token = "0x200027C")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			[Token(Token = "0x4001FBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<RoleBehaviour> candidates;

			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x44101CC", Offset = "0x440C1CC", VA = "0x44101CC")]
			public _003C_003Ec__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0x44101D4", Offset = "0x440C1D4", VA = "0x44101D4")]
			internal bool _003CGetClosestDynamicTargets_003Eb__0(KeyValuePair<RoleBehaviour, RoleCacheData> kv)
			{
				return default;
			}
		}

		[Token(Token = "0x200027D")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass20_0
		{
			[Token(Token = "0x4001FBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RoleBehaviour target;

			[Token(Token = "0x4001FBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float finalDistance;

			[Token(Token = "0x4001FC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DynamicTargetFinder _003C_003E4__this;

			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x4410238", Offset = "0x440C238", VA = "0x4410238")]
			public _003C_003Ec__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0x4410240", Offset = "0x440C240", VA = "0x4410240")]
			internal RoleCacheData _003CCalculateHexDistance_003Eb__0(RoleBehaviour _)
			{
				return null;
			}

			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x44102FC", Offset = "0x440C2FC", VA = "0x44102FC")]
			internal RoleCacheData _003CCalculateHexDistance_003Eb__1(RoleBehaviour _, RoleCacheData oldData)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200027F")]
		[CompilerGenerated]
		private struct _003CCalculateHexDistance_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4001FC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001FC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001FC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RoleBehaviour target;

			[Token(Token = "0x4001FC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DynamicTargetFinder _003C_003E4__this;

			[Token(Token = "0x4001FC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RoleBehaviour requester;

			[Token(Token = "0x4001FC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

			[Token(Token = "0x4001FCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<(GameObject nearestObj, int distance, List<HexManager.HexCoord> path)>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x441038C", Offset = "0x440C38C", VA = "0x441038C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x4410A78", Offset = "0x440CA78", VA = "0x4410A78", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000280")]
		[CompilerGenerated]
		private struct _003CGetClosestDynamicTargets_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4001FCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001FCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<List<RoleBehaviour>> _003C_003Et__builder;

			[Token(Token = "0x4001FCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DynamicTargetFinder _003C_003E4__this;

			[Token(Token = "0x4001FCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float range;

			[Token(Token = "0x4001FCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool isEnemy;

			[Token(Token = "0x4001FD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RoleBehaviour requester;

			[Token(Token = "0x4001FD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass18_0 _003C_003E8__1;

			[Token(Token = "0x4001FD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int roleNum;

			[Token(Token = "0x4001FD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0x4410A84", Offset = "0x440CA84", VA = "0x4410A84", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0x4411214", Offset = "0x440D214", VA = "0x4411214", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000281")]
		[CompilerGenerated]
		private struct _003CUpdateHexDistances_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4001FD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001FD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001FD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<RoleBehaviour> candidates;

			[Token(Token = "0x4001FD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RoleBehaviour requester;

			[Token(Token = "0x4001FD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DynamicTargetFinder _003C_003E4__this;

			[Token(Token = "0x4001FD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<(GameObject nearestObj, int distance, List<HexManager.HexCoord> path)[]>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x441126C", Offset = "0x440D26C", VA = "0x441126C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x4411960", Offset = "0x440D960", VA = "0x4411960", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001FAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float gridCellSize;

		[Token(Token = "0x4001FAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float cacheUpdateInterval;

		[Token(Token = "0x4001FAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float positionUpdateThreshold;

		[Token(Token = "0x4001FB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxStraightDistance;

		[Token(Token = "0x4001FB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly ConcurrentDictionary<RoleBehaviour, RoleCacheData> _roleCache;

		[Token(Token = "0x4001FB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly ConcurrentDictionary<Vector2Int, ConcurrentBag<RoleBehaviour>> _spatialGrid;

		[Token(Token = "0x4001FB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _lastFullUpdateTime;

		[Token(Token = "0x4001FB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private HashSet<RoleBehaviour> _lastFrameRoles;

		[Token(Token = "0x170000C8")]
		public List<RoleBehaviour> CurrentPlayerRoles
		{
			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x440E61C", Offset = "0x440A61C", VA = "0x440E61C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		public List<RoleBehaviour> CurrentEnemyRoles
		{
			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0x440E66C", Offset = "0x440A66C", VA = "0x440E66C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x440E6BC", Offset = "0x440A6BC", VA = "0x440E6BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x440E6D4", Offset = "0x440A6D4", VA = "0x440E6D4")]
		private void SyncRoleChanges()
		{
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x440F054", Offset = "0x440B054", VA = "0x440F054")]
		private void RegisterRole(RoleBehaviour role)
		{
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x440F240", Offset = "0x440B240", VA = "0x440F240")]
		private void UnregisterRole(RoleBehaviour role)
		{
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x440ECB8", Offset = "0x440ACB8", VA = "0x440ECB8")]
		private void UpdateMovingRoles()
		{
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x440F4E8", Offset = "0x440B4E8", VA = "0x440F4E8")]
		private void UpdateRolePosition(RoleBehaviour role, RoleCacheData cacheData, Vector3 newPos)
		{
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x440F7C8", Offset = "0x440B7C8", VA = "0x440F7C8")]
		[AsyncStateMachine(typeof(_003CGetClosestDynamicTargets_003Ed__18))]
		public UniTask<List<RoleBehaviour>> GetClosestDynamicTargets(RoleBehaviour requester, bool isEnemy, float range, int roleNum)
		{
			return default;
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x440F8D8", Offset = "0x440B8D8", VA = "0x440F8D8")]
		[AsyncStateMachine(typeof(_003CUpdateHexDistances_003Ed__19))]
		private UniTask UpdateHexDistances(RoleBehaviour requester, List<RoleBehaviour> candidates, bool forceRefresh)
		{
			return default;
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x440F97C", Offset = "0x440B97C", VA = "0x440F97C")]
		[AsyncStateMachine(typeof(_003CCalculateHexDistance_003Ed__20))]
		private UniTask CalculateHexDistance(RoleBehaviour requester, RoleBehaviour target)
		{
			return default;
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x440F3F8", Offset = "0x440B3F8", VA = "0x440F3F8")]
		private Vector2Int GetGridCell(Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x440FA20", Offset = "0x440BA20", VA = "0x440FA20")]
		private List<RoleBehaviour> GetCandidatesInRange(Vector3 center, float radius, bool isEnemy)
		{
			return null;
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x440FD34", Offset = "0x440BD34", VA = "0x440FD34")]
		private List<Vector2Int> GetNearbyGridCells(Vector3 center, float radius)
		{
			return null;
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x440FF00", Offset = "0x440BF00", VA = "0x440FF00")]
		public DynamicTargetFinder()
		{
		}
	}
}
