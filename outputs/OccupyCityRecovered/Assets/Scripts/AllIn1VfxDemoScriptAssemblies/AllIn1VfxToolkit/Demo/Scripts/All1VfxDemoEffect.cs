using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x2000008")]
	[CreateAssetMenu(fileName = "All1VfxDemoEffect", menuName = "AllIn1Vfx/DemoEffect")]
	public class All1VfxDemoEffect : ScriptableObject
	{
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x18")]
		[Header("Can be replayed?")]
		public bool onlyOneAtATime;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x19")]
		public bool canBePlayedAgain;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x1C")]
		public float randomSpreadRadius;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		public float cooldown;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x24")]
		[Header("Chooses between Static Effect and Shoot Projectile")]
		[Space]
		public bool isShootProjectile;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x28")]
		[Header("Static Effect Property")]
		[Space]
		public GameObject effectPrefab;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x30")]
		public bool spawnTouchingFloor;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x34")]
		[Header("Shoot Projectile Properties")]
		[Space]
		public float projectileSpeed;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x38")]
		public GameObject projectilePrefab;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x40")]
		public GameObject muzzleFlashPrefab;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x48")]
		public GameObject impactPrefab;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x50")]
		[Header("Camera Shake")]
		[Space]
		public bool doCameraShake;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x54")]
		public float mainEffectShakeAmount;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x58")]
		[Header("Only if Shoot Projectile")]
		public float projectileImpactShakeAmount;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x5C")]
		[Space]
		[Header("Other Properties")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x68")]
		public float scaleMultiplier;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x3CEF2C8", Offset = "0x3CEB2C8", VA = "0x3CEF2C8")]
		public All1VfxDemoEffect()
		{
		}
	}
}
