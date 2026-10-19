using Il2CppDummyDll;
using UnityEngine;

namespace PolygonArsenal
{
	[Token(Token = "0x2000CAC")]
	public class PolygonProjectileScript : MonoBehaviour
	{
		[Token(Token = "0x4005AF3")]
		[FieldOffset(Offset = "0x20")]
		public GameObject impactParticle;

		[Token(Token = "0x4005AF4")]
		[FieldOffset(Offset = "0x28")]
		public GameObject projectileParticle;

		[Token(Token = "0x4005AF5")]
		[FieldOffset(Offset = "0x30")]
		public GameObject muzzleParticle;

		[Token(Token = "0x4005AF6")]
		[FieldOffset(Offset = "0x38")]
		public GameObject[] trailParticles;

		[Token(Token = "0x4005AF7")]
		[FieldOffset(Offset = "0x40")]
		[Header("Adjust if not using Sphere Collider")]
		public float colliderRadius;

		[Token(Token = "0x4005AF8")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float collideOffset;

		[Token(Token = "0x4005AF9")]
		[FieldOffset(Offset = "0x48")]
		private Rigidbody rb;

		[Token(Token = "0x4005AFA")]
		[FieldOffset(Offset = "0x50")]
		private Transform myTransform;

		[Token(Token = "0x4005AFB")]
		[FieldOffset(Offset = "0x58")]
		private SphereCollider sphereCollider;

		[Token(Token = "0x4005AFC")]
		[FieldOffset(Offset = "0x60")]
		private float destroyTimer;

		[Token(Token = "0x4005AFD")]
		[FieldOffset(Offset = "0x64")]
		private bool destroyed;

		[Token(Token = "0x6004F74")]
		[Address(RVA = "0x42B67E4", Offset = "0x42B27E4", VA = "0x42B67E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6004F75")]
		[Address(RVA = "0x42B6A0C", Offset = "0x42B2A0C", VA = "0x42B6A0C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6004F76")]
		[Address(RVA = "0x42B6F88", Offset = "0x42B2F88", VA = "0x42B6F88")]
		private void DestroyMissile()
		{
		}

		[Token(Token = "0x6004F77")]
		[Address(RVA = "0x42B71FC", Offset = "0x42B31FC", VA = "0x42B71FC")]
		private void RotateTowardsDirection()
		{
		}

		[Token(Token = "0x6004F78")]
		[Address(RVA = "0x42B7604", Offset = "0x42B3604", VA = "0x42B7604")]
		public PolygonProjectileScript()
		{
		}
	}
}
