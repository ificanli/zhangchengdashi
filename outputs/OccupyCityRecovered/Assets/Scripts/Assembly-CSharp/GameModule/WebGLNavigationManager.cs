using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002B6")]
	public sealed class WebGLNavigationManager : MonoBehaviour
	{
		[Token(Token = "0x20002B7")]
		private struct HexMoveContext
		{
			[Token(Token = "0x40021B2")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 Current;

			[Token(Token = "0x40021B3")]
			[FieldOffset(Offset = "0xC")]
			public bool CurrentOnHex;

			[Token(Token = "0x40021B4")]
			[FieldOffset(Offset = "0xD")]
			public bool IsSeparationOnly;

			[Token(Token = "0x40021B5")]
			[FieldOffset(Offset = "0xE")]
			public bool OwnerIsEnemy;

			[Token(Token = "0x40021B6")]
			[FieldOffset(Offset = "0x10")]
			public HexBehaviour CurrentHex;

			[Token(Token = "0x40021B7")]
			[FieldOffset(Offset = "0x18")]
			public HexBehaviour NextHex;

			[Token(Token = "0x40021B8")]
			[FieldOffset(Offset = "0x20")]
			public HexBehaviour LastValidHex;

			[Token(Token = "0x40021B9")]
			[FieldOffset(Offset = "0x28")]
			public WebGLHexPathField PathField;
		}

		[Token(Token = "0x40021A3")]
		[FieldOffset(Offset = "0x0")]
		private static WebGLNavigationManager _active;

		[Token(Token = "0x40021A4")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<WebGLNavigationAgent> _agents;

		[Token(Token = "0x40021A5")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<RoleBehaviour, int> _agentIndexByRole;

		[Token(Token = "0x40021A6")]
		[FieldOffset(Offset = "0x30")]
		private readonly Stack<int> _freeIndices;

		[Token(Token = "0x40021A7")]
		[FieldOffset(Offset = "0x38")]
		private readonly WebGLHexPathField _pathField;

		[Token(Token = "0x40021A8")]
		[FieldOffset(Offset = "0x40")]
		private readonly WebGLLocalAvoidanceSimulator _avoidance;

		[Token(Token = "0x40021A9")]
		private const float EdgeSlideTangentScale = 0.96f;

		[Token(Token = "0x40021AA")]
		private const float EdgeSlideInwardScale = 0.18f;

		[Token(Token = "0x40021AB")]
		private const float EdgeSlideRecoveryScale = 0.45f;

		[Token(Token = "0x40021AC")]
		private const float CurrentHexHysteresisRatio = 0.12f;

		[Token(Token = "0x40021AD")]
		private const float CurrentHexHysteresisMin = 0.04f;

		[Token(Token = "0x40021AE")]
		private const float CurrentHexHysteresisMax = 0.2f;

		[Token(Token = "0x40021AF")]
		[FieldOffset(Offset = "0x48")]
		private BattleGameSceneManager _scene;

		[Token(Token = "0x40021B0")]
		[FieldOffset(Offset = "0x50")]
		private bool _listeningEvents;

		[Token(Token = "0x40021B1")]
		[FieldOffset(Offset = "0x51")]
		private bool _initialized;

		[Token(Token = "0x170000D8")]
		public static bool IsRuntimeEnabled
		{
			[Token(Token = "0x6000C39")]
			[Address(RVA = "0x3D37088", Offset = "0x3D33088", VA = "0x3D37088")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x3D37090", Offset = "0x3D33090", VA = "0x3D37090")]
		public void Initialize(BattleGameSceneManager scene)
		{
		}

		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x3D373F8", Offset = "0x3D333F8", VA = "0x3D373F8")]
		public void Shutdown()
		{
		}

		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x3D377D8", Offset = "0x3D337D8", VA = "0x3D377D8")]
		public static void TryRegisterRole(RoleBehaviour role)
		{
		}

		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x3D37AA4", Offset = "0x3D33AA4", VA = "0x3D37AA4")]
		public static void TryUnregisterRole(RoleBehaviour role)
		{
		}

		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x3D37C8C", Offset = "0x3D33C8C", VA = "0x3D37C8C")]
		public static bool TryGetCurrentStep(RoleBehaviour role, out HexBehaviour currentHex, out HexBehaviour nextHex, out Vector3 steeringPoint)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WebGLNavigationManager.TryGetCurrentStep RVA=0x3D37C8C Token=0x6000C3E");
}

		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x3D37EC8", Offset = "0x3D33EC8", VA = "0x3D37EC8")]
		public static int GetFlowCostAtPosition(bool ownerIsEnemy, Vector3 worldPos)
		{
			return default;
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x3D37FC4", Offset = "0x3D33FC4", VA = "0x3D37FC4")]
		public static bool TryGetRemainingPath(RoleBehaviour role, List<Vector3> result, int maxPoints = 32)
		{
			return default;
		}

		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x3D382F8", Offset = "0x3D342F8", VA = "0x3D382F8")]
		public void MarkPathFieldsDirty()
		{
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x3D38320", Offset = "0x3D34320", VA = "0x3D38320")]
		public void MarkPathGraphDirty()
		{
		}

		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x3D38348", Offset = "0x3D34348", VA = "0x3D38348")]
		public void MarkAllPathFieldsDirty()
		{
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x3D38368", Offset = "0x3D34368", VA = "0x3D38368")]
		public void MarkTargetPathFieldDirty(bool targetIsEnemy)
		{
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x3D38394", Offset = "0x3D34394", VA = "0x3D38394")]
		public void Tick(float deltaTime)
		{
		}

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x3D378BC", Offset = "0x3D338BC", VA = "0x3D378BC")]
		private void RegisterRole(RoleBehaviour role)
		{
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x3D37B7C", Offset = "0x3D33B7C", VA = "0x3D37B7C")]
		private void UnregisterRole(RoleBehaviour role)
		{
		}

		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x3D385E8", Offset = "0x3D345E8", VA = "0x3D385E8")]
		private void RefreshAgent(WebGLNavigationAgent agent)
		{
		}

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x3D39388", Offset = "0x3D35388", VA = "0x3D39388")]
		private static void SetupSeparationOnlyAgent(WebGLNavigationAgent agent, RoleBehaviour role)
		{
		}

		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x3D39528", Offset = "0x3D35528", VA = "0x3D39528")]
		private bool ResolveSteeringPoint(WebGLNavigationAgent agent, RoleBehaviour role, Transform target, out HexBehaviour currentHex, out HexBehaviour nextHex, out Vector3 steeringPoint, out bool currentPositionOnHex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WebGLNavigationManager.ResolveSteeringPoint RVA=0x3D39528 Token=0x6000C4A");
}

		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x3D38C20", Offset = "0x3D34C20", VA = "0x3D38C20")]
		private void ApplyAgentMovement(WebGLNavigationAgent agent, float deltaTime)
		{
		}

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x3D39D20", Offset = "0x3D35D20", VA = "0x3D39D20")]
		private static HexMoveContext CreateHexMoveContext(WebGLNavigationAgent agent, Vector3 current, WebGLHexPathField pathField)
		{
			return default;
		}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x3D39A28", Offset = "0x3D35A28", VA = "0x3D39A28")]
		private static HexBehaviour ResolveStableCurrentHex(WebGLNavigationAgent agent, HexBehaviour sampledHex, Vector3 position)
		{
			return null;
		}

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x3D380E4", Offset = "0x3D340E4", VA = "0x3D380E4")]
		private bool CollectRemainingPath(RoleBehaviour role, List<Vector3> result, int maxPoints)
		{
			return default;
		}

		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x3D39E50", Offset = "0x3D35E50", VA = "0x3D39E50")]
		private static bool TryResolveValidMove(HexMoveContext context, Vector3 next, out HexBehaviour nextPositionHex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WebGLNavigationManager.TryResolveValidMove RVA=0x3D39E50 Token=0x6000C4F");
}

		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x3D3A728", Offset = "0x3D36728", VA = "0x3D3A728")]
		private static bool CanRecoverToAdjacentHex(HexMoveContext context, HexBehaviour candidateHex)
		{
			return default;
		}

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x3D3A560", Offset = "0x3D36560", VA = "0x3D3A560")]
		private static bool IsEdgeBlockedForOwner(HexBehaviour fromHex, HexBehaviour toHex, bool ownerIsEnemy)
		{
			return default;
		}

		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x3D3A8BC", Offset = "0x3D368BC", VA = "0x3D3A8BC")]
		private static bool TryGetMoveDirectionBetweenHexes(HexBehaviour fromHex, HexBehaviour toHex, out int direction, out int opposite)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WebGLNavigationManager.TryGetMoveDirectionBetweenHexes RVA=0x3D3A8BC Token=0x6000C52");
}

		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x3D3A0DC", Offset = "0x3D360DC", VA = "0x3D3A0DC")]
		private static bool TryGetEdgeSlideMove(WebGLNavigationAgent agent, HexMoveContext context, Vector3 attempted, out Vector3 slideNext, out HexBehaviour slideHex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WebGLNavigationManager.TryGetEdgeSlideMove RVA=0x3D3A0DC Token=0x6000C53");
}

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x3D3AAB8", Offset = "0x3D36AB8", VA = "0x3D3AAB8")]
		private static bool TryEdgeSlideCandidate(HexMoveContext context, Vector3 tangent, Vector3 inward, float step, out Vector3 candidate, out HexBehaviour candidateHex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WebGLNavigationManager.TryEdgeSlideCandidate RVA=0x3D3AAB8 Token=0x6000C54");
}

		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x3D3A518", Offset = "0x3D36518", VA = "0x3D3A518")]
		private static bool IsMovingCloser(Vector3 next, Vector3 current, Vector3 target)
		{
			return default;
		}

		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x3D3718C", Offset = "0x3D3318C", VA = "0x3D3718C")]
		private void StartListeningEvents()
		{
		}

		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x3D37570", Offset = "0x3D33570", VA = "0x3D37570")]
		private void StopListeningEvents()
		{
		}

		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x3D3AB44", Offset = "0x3D36B44", VA = "0x3D3AB44")]
		private void OnNavigationTopologyChanged(object _)
		{
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x3D3AB6C", Offset = "0x3D36B6C", VA = "0x3D3AB6C")]
		private void OnNavigationFieldsChanged(object _)
		{
		}

		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x3D3AB8C", Offset = "0x3D36B8C", VA = "0x3D3AB8C")]
		private void OnNavigationWallChanged(object _)
		{
		}

		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x3D3ABB4", Offset = "0x3D36BB4", VA = "0x3D3ABB4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x3D3ABB8", Offset = "0x3D36BB8", VA = "0x3D3ABB8")]
		public WebGLNavigationManager()
		{
		}
	}
}
