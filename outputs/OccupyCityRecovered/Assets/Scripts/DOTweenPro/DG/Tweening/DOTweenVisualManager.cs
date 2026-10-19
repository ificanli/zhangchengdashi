using DG.Tweening.Core;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening
{
	[Token(Token = "0x2000002")]
	[AddComponentMenu("")]
	public class DOTweenVisualManager : MonoBehaviour
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x20")]
		public VisualManagerPreset preset;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x24")]
		public OnEnableBehaviour onEnableBehaviour;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x28")]
		public OnDisableBehaviour onDisableBehaviour;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x2C")]
		private bool _requiresRestartFromSpawnPoint;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x30")]
		private ABSAnimationComponent _animComponent;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x46AC174", Offset = "0x46A8174", VA = "0x46AC174")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x46AC1C4", Offset = "0x46A81C4", VA = "0x46AC1C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x46AC25C", Offset = "0x46A825C", VA = "0x46AC25C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x46AC34C", Offset = "0x46A834C", VA = "0x46AC34C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x46AC554", Offset = "0x46A8554", VA = "0x46AC554")]
		public DOTweenVisualManager()
		{
		}
	}
}
