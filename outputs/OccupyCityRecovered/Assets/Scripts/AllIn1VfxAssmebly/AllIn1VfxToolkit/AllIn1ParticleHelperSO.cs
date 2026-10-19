using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit
{
	[Token(Token = "0x200000F")]
	[CreateAssetMenu(fileName = "All1VfxParticleHelperTemplate", menuName = "AllIn1Vfx/ParticleHelperTemplate")]
	public class AllIn1ParticleHelperSO : ScriptableObject
	{
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x18")]
		public bool matchDurationToLifetime;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x19")]
		public bool randomRotation;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x1C")]
		public float minLifetime;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x20")]
		public float maxLifetime;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x24")]
		public float minSpeed;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x28")]
		public float maxSpeed;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x2C")]
		public float minSize;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x30")]
		public float maxSize;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x38")]
		public ParticleSystem.MinMaxGradient startColor;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x70")]
		public bool isBurst;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x74")]
		public int minNumberOfParticles;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x78")]
		public int maxNumberOfParticles;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x7C")]
		public AllIn1ParticleHelperComponent.EmissionShapes currEmissionShape;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x80")]
		public AllIn1ParticleHelperComponent.LifetimeSettings colorLifetime;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x84")]
		public AllIn1ParticleHelperComponent.LifetimeSettings sizeLifetime;

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x3CEC440", Offset = "0x3CE8440", VA = "0x3CEC440")]
		public AllIn1ParticleHelperSO()
		{
		}
	}
}
