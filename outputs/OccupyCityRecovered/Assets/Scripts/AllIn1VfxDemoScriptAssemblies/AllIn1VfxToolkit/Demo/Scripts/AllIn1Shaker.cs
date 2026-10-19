using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x2000012")]
	public class AllIn1Shaker : MonoBehaviour
	{
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 maximumTranslationShake;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 maximumAngularShake;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float shakeFrequency;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float shakeSmoothingExponent;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float shakeRecoverPerSecond;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x0")]
		public static AllIn1Shaker i;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x44")]
		private float currentShakeAmount;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x48")]
		private float seed;

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x3CF0464", Offset = "0x3CEC464", VA = "0x3CF0464")]
		private void Awake()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x3CF056C", Offset = "0x3CEC56C", VA = "0x3CF056C")]
		private void Update()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x3CF05D4", Offset = "0x3CEC5D4", VA = "0x3CF05D4")]
		private float SmoothShakeToApply()
		{
			return default;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x3CF06F0", Offset = "0x3CEC6F0", VA = "0x3CF06F0")]
		private void ShakeRotation(float shake)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x3CF05E0", Offset = "0x3CEC5E0", VA = "0x3CF05E0")]
		private void ShakePosition(float shake)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x3CF0824", Offset = "0x3CEC824", VA = "0x3CF0824")]
		public void DoCameraShake(float shakeAmount)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x3CF082C", Offset = "0x3CEC82C", VA = "0x3CF082C")]
		public AllIn1Shaker()
		{
		}
	}
}
