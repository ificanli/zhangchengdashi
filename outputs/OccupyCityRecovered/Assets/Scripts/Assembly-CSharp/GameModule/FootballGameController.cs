using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200021F")]
	public class FootballGameController : MonoBehaviour
	{
		[Token(Token = "0x2000220")]
		private enum GameState
		{
			[Token(Token = "0x4001D6B")]
			Ready = 0,
			[Token(Token = "0x4001D6C")]
			Flying = 1,
			[Token(Token = "0x4001D6D")]
			Result = 2
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000221")]
		[CompilerGenerated]
		private struct _003CResolveRoundAsync_003Ed__30 : IAsyncStateMachine
		{
			[Token(Token = "0x4001D6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001D6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x4001D70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x4001D71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int roundId;

			[Token(Token = "0x4001D72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public FootballGameController _003C_003E4__this;

			[Token(Token = "0x4001D73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isGoalByChance;

			[Token(Token = "0x4001D74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 targetPos;

			[Token(Token = "0x4001D75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float _003CelapsedMs_003E5__2;

			[Token(Token = "0x4001D76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool _003CsaveResolved_003E5__3;

			[Token(Token = "0x4001D77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float _003CsaveResolvedElapsedMs_003E5__4;

			[Token(Token = "0x4001D78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x428961C", Offset = "0x428561C", VA = "0x428961C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x4289B70", Offset = "0x4285B70", VA = "0x4289B70", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000222")]
		[CompilerGenerated]
		private struct _003CShootOnceAsync_003Ed__27 : IAsyncStateMachine
		{
			[Token(Token = "0x4001D79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001D7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<FootballShootResult> _003C_003Et__builder;

			[Token(Token = "0x4001D7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FootballGameController _003C_003E4__this;

			[Token(Token = "0x4001D7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x4001D7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003CroundId_003E5__2;

			[Token(Token = "0x4001D7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private FootballGoalZone _003CshotZone_003E5__3;

			[Token(Token = "0x4001D7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private FootballShootResult _003Cresult_003E5__4;

			[Token(Token = "0x4001D80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4001D81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x4289BC8", Offset = "0x4285BC8", VA = "0x4289BC8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x428AA28", Offset = "0x4286A28", VA = "0x428AA28", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001D57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FootballSightController _sight;

		[Token(Token = "0x4001D58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FootballBallController _ball;

		[Token(Token = "0x4001D59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FootballGoalkeeperController _goalkeeper;

		[Token(Token = "0x4001D5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FootballShootVfxController _vfx;

		[Token(Token = "0x4001D5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FootballGoalTrigger _goalTrigger;

		[Token(Token = "0x4001D5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FootballSaveTrigger _saveTrigger;

		[Token(Token = "0x4001D5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _coordinateSpace;

		[Token(Token = "0x4001D5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private FootballGoalAreaSettings _area;

		[Token(Token = "0x4001D5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _goalChance;

		[Token(Token = "0x4001D60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _saveSettleMs;

		[Token(Token = "0x4001D61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int _resetDelayMs;

		[Token(Token = "0x4001D62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _resolveTimeoutMs;

		[Token(Token = "0x4001D63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameState _state;

		[Token(Token = "0x4001D64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int _roundId;

		[Token(Token = "0x4001D65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool _goalTriggered;

		[Token(Token = "0x4001D66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		private bool _saveTriggered;

		[Token(Token = "0x4001D67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		private bool _isGoalByChanceRound;

		[Token(Token = "0x4001D68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private FootballGoalZone _currentShotZone;

		[Token(Token = "0x4001D69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 _currentTargetPos;

		[Token(Token = "0x170000AF")]
		public bool IsReady
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x4197900", Offset = "0x4193900", VA = "0x4197900")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x4197910", Offset = "0x4193910", VA = "0x4197910")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x4197DE4", Offset = "0x4193DE4", VA = "0x4197DE4")]
		private void DisableDuplicateStageComponents()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x41980D0", Offset = "0x41940D0", VA = "0x41980D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x4198108", Offset = "0x4194108", VA = "0x4198108")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x41980EC", Offset = "0x41940EC", VA = "0x41980EC")]
		public void ApplyGoalChanceFromConfig()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x41982D8", Offset = "0x41942D8", VA = "0x41982D8")]
		[AsyncStateMachine(typeof(_003CShootOnceAsync_003Ed__27))]
		public UniTask<FootballShootResult> ShootOnceAsync([Optional] CancellationToken cancellationToken)
		{
			return default;
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x41983C0", Offset = "0x41943C0", VA = "0x41983C0")]
		private void OnGoalTriggered()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x41983CC", Offset = "0x41943CC", VA = "0x41983CC")]
		private void OnSaveTriggered()
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x4198434", Offset = "0x4194434", VA = "0x4198434")]
		[AsyncStateMachine(typeof(_003CResolveRoundAsync_003Ed__30))]
		private UniTask<bool> ResolveRoundAsync(int roundId, bool isGoalByChance, FootballGoalZone shotZone, Vector3 targetPos, CancellationToken cancellationToken)
		{
			return default;
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x419854C", Offset = "0x419454C", VA = "0x419854C")]
		private void OnKeeperLanded(Vector3 worldPosition)
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x4198560", Offset = "0x4194560", VA = "0x4198560")]
		private void ResetRound()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x41985D4", Offset = "0x41945D4", VA = "0x41985D4")]
		public FootballGameController()
		{
		}
	}
}
