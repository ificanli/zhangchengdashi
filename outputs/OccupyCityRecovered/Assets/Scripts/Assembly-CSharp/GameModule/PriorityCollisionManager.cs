using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000272")]
	public class PriorityCollisionManager : ManagerBase<PriorityCollisionManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000273")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4001F77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001F78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001F79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PriorityCollisionManager _003C_003E4__this;

			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x438D390", Offset = "0x4389390", VA = "0x438D390", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x438D7A4", Offset = "0x43897A4", VA = "0x438D7A4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001F65")]
		private const float GRID_CELL_SIZE = 2f;

		[Token(Token = "0x4001F66")]
		private const int MAX_GRID_SIZE = 1000;

		[Token(Token = "0x4001F67")]
		private const int FRAME_GROUPS = 10;

		[Token(Token = "0x4001F68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _currentFrameGroup;

		[Token(Token = "0x4001F69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<int, List<RoleBehaviour>> _spatialGrid;

		[Token(Token = "0x4001F6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<RoleBehaviour> _allActiveRoles;

		[Token(Token = "0x4001F6B")]
		private const float SMOOTH_FACTOR = 5f;

		[Token(Token = "0x4001F6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<RoleBehaviour> _tempNeighborList;

		[Token(Token = "0x4001F6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private HashSet<(RoleBehaviour, RoleBehaviour)> _processedPairs;

		[Token(Token = "0x4001F6E")]
		private const float MIN_PUSH_DISTANCE = 0.01f;

		[Token(Token = "0x4001F6F")]
		private const float COLLISION_BUFFER = 1.1f;

		[Token(Token = "0x4001F70")]
		private const float FORWARD_CHECK_DISTANCE = 1.5f;

		[Token(Token = "0x4001F71")]
		private const float AVOIDANCE_ANGLE = 45f;

		[Token(Token = "0x4001F72")]
		private const float AVOIDANCE_DISTANCE = 1f;

		[Token(Token = "0x4001F73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<RoleBehaviour, Vector3> _avoidanceTargets;

		[Token(Token = "0x4001F74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<RoleBehaviour, float> _avoidanceTargetExpireTime;

		[Token(Token = "0x4001F75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<RoleBehaviour, Transform> _originalTargets;

		[Token(Token = "0x4001F76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<RoleBehaviour, GameObject> _tempTargetObjects;

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x438B074", Offset = "0x4387074", VA = "0x438B074")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x438B080", Offset = "0x4387080", VA = "0x438B080", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__18))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x438B104", Offset = "0x4387104", VA = "0x438B104")]
		public void Update()
		{
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x438B108", Offset = "0x4387108", VA = "0x438B108")]
		private void UpdateAvoidanceTargets()
		{
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x438B770", Offset = "0x4387770", VA = "0x438B770")]
		private void UpdateActiveRolesList()
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x438BA38", Offset = "0x4387A38", VA = "0x438BA38")]
		private void UpdateSpatialGrid()
		{
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x438BDB4", Offset = "0x4387DB4", VA = "0x438BDB4")]
		private int GetGridKey(Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x438BE94", Offset = "0x4387E94", VA = "0x438BE94")]
		private void ProcessForwardAvoidance(RoleBehaviour role)
		{
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x438C318", Offset = "0x4388318", VA = "0x438C318")]
		private Transform GetRoleTarget(RoleBehaviour role)
		{
			return null;
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x438CA50", Offset = "0x4388A50", VA = "0x438CA50")]
		private void SetTemporaryAvoidanceTarget(RoleBehaviour role, Vector3 targetPos)
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x438C43C", Offset = "0x438843C", VA = "0x438C43C")]
		private RoleBehaviour CheckForwardObstacle(RoleBehaviour role, Vector2 currentPos, Vector2 moveDirection, float checkDistance)
		{
			return null;
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x438C73C", Offset = "0x438873C", VA = "0x438C73C")]
		private Vector3 CalculateAvoidanceDirection(RoleBehaviour role, RoleBehaviour obstacle, Vector2 currentPos, Vector2 moveDirection)
		{
			return default;
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x438CFE4", Offset = "0x4388FE4", VA = "0x438CFE4")]
		private bool IsPositionSafe(RoleBehaviour role, Vector2 position)
		{
			return default;
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x438CD88", Offset = "0x4388D88", VA = "0x438CD88")]
		private void GetNeighborsInGrid(int centerKey, List<RoleBehaviour> result)
		{
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x438D220", Offset = "0x4389220", VA = "0x438D220")]
		private float GetMoveSpeed(RoleBehaviour role)
		{
			return default;
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x438CF80", Offset = "0x4388F80", VA = "0x438CF80")]
		private float GetCollisionRadius(RoleBehaviour role)
		{
			return default;
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x438D29C", Offset = "0x438929C", VA = "0x438D29C")]
		private int GetPriority(RoleBehaviour role)
		{
			return default;
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x438D300", Offset = "0x4389300", VA = "0x438D300")]
		public PriorityCollisionManager()
		{
		}
	}
}
