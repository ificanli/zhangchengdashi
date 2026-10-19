using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x200000D")]
	public class AllIn1DemoProjectile : MonoBehaviour
	{
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float inaccurateAmount;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x28")]
		private GameObject currentImpactPrefab;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x30")]
		private Transform currentHierarchyParent;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x38")]
		private bool doImpactSpawn;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x39")]
		private bool doShake;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x3C")]
		private float shakeAmountOnImpact;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x40")]
		private float impactScaleSize;

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x3CEF650", Offset = "0x3CEB650", VA = "0x3CEF650")]
		public void Initialize(Transform hierarchyParent, Vector3 projectileDir, float speed, GameObject impactPrefab, float impactScaleSize)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x3CEF7B4", Offset = "0x3CEB7B4", VA = "0x3CEF7B4")]
		public void AddScreenShakeOnImpact(float projectileImpactShakeAmount)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x3CEF73C", Offset = "0x3CEB73C", VA = "0x3CEF73C")]
		private void ApplyPrecisionOffsetToProjectileDir(ref Vector3 projectileDir)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x3CEF7C4", Offset = "0x3CEB7C4", VA = "0x3CEF7C4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x3CEF98C", Offset = "0x3CEB98C", VA = "0x3CEF98C")]
		public AllIn1DemoProjectile()
		{
		}
	}
}
