using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x200000C")]
	public class NavMeshDemoSceneController : MonoBehaviour
	{
		[Token(Token = "0x200000D")]
		private enum AnimationState
		{
			[Token(Token = "0x4000064")]
			Idle = 0,
			[Token(Token = "0x4000065")]
			Locomotion = 1
		}

		[Token(Token = "0x200000E")]
		private class DemoAgent
		{
			[Token(Token = "0x4000066")]
			[FieldOffset(Offset = "0x10")]
			public GPUICrowdPrefab gpuiCrowdInstance;

			[Token(Token = "0x4000067")]
			[FieldOffset(Offset = "0x18")]
			public AnimationState currentState;

			[Token(Token = "0x4000068")]
			[FieldOffset(Offset = "0x20")]
			public NavMeshAgent ai;

			[Token(Token = "0x600002E")]
			[Address(RVA = "0x73C185C", Offset = "0x73BD85C", VA = "0x73C185C")]
			public DemoAgent()
			{
			}
		}

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public GameObject indicator;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public GPUICrowdPrefab prefab;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x30")]
		public Transform SpawnLoacation;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x38")]
		public int instanceCount;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x3C")]
		public int avoidanceRange;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x40")]
		public bool isGPUIManagerActive;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x48")]
		[Header("Animations")]
		public AnimationClip idle;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x50")]
		public AnimationClip walk;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x58")]
		public AnimationClip run;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x60")]
		private Ray _ray;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x78")]
		private RaycastHit _hit;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0xA4")]
		private NavMeshHit _navMeshHit;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0xC8")]
		private Vector3 _currentTarget;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0xD4")]
		private Vector3 _previousTarget;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0xE0")]
		private bool _isTargetChanged;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0xE8")]
		private GameObject _indicatorSphere;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0xF0")]
		private GameObject _instancesParent;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0xF8")]
		private bool _resetAnimations;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x100")]
		private List<DemoAgent> _demoAgents;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x108")]
		private AnimationState _currentState;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x10C")]
		private Vector4 _blendWeights;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x73C0DEC", Offset = "0x73BCDEC", VA = "0x73C0DEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x73C13B8", Offset = "0x73BD3B8", VA = "0x73C13B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x73C1018", Offset = "0x73BD018", VA = "0x73C1018")]
		public void AddAgents(int count)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x73C1314", Offset = "0x73BD314", VA = "0x73C1314")]
		private Vector3 GetRandomNavMeshPositionNearLocation(Vector3 origin, float range)
		{
			return default;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x73C1864", Offset = "0x73BD864", VA = "0x73C1864")]
		public void ResetAnimations()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x73C1870", Offset = "0x73BD870", VA = "0x73C1870")]
		private AnimationState DetermineAgentState(float agentSpeed)
		{
			return default;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x73C16D0", Offset = "0x73BD6D0", VA = "0x73C16D0")]
		private void HandleAnimationState(DemoAgent agent, float agentSpeed)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x73C18D0", Offset = "0x73BD8D0", VA = "0x73C18D0")]
		public NavMeshDemoSceneController()
		{
		}
	}
}
