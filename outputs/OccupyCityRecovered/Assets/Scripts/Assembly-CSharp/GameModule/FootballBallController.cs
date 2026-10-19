using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200021E")]
	[RequireComponent(typeof(Rigidbody))]
	public class FootballBallController : MonoBehaviour
	{
		[Token(Token = "0x4001D45")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _shootForce;

		[Token(Token = "0x4001D46")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _upwardForce;

		[Token(Token = "0x4001D47")]
		[FieldOffset(Offset = "0x28")]
		[Header("扑出")]
		[SerializeField]
		private float _saveLateralSpeed;

		[Token(Token = "0x4001D48")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _saveBackwardSpeed;

		[Token(Token = "0x4001D49")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _saveBounceSpeed;

		[Token(Token = "0x4001D4A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _saveDrag;

		[Token(Token = "0x4001D4B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _saveAngularDrag;

		[Token(Token = "0x4001D4C")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Range(0f, 1f)]
		[Header("落网")]
		private float _netHorizontalSpeedScale;

		[Token(Token = "0x4001D4D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _netDropSpeed;

		[Token(Token = "0x4001D4E")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _netDrag;

		[Token(Token = "0x4001D4F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _netAngularDrag;

		[Token(Token = "0x4001D50")]
		[FieldOffset(Offset = "0x50")]
		private Rigidbody _rigidbody;

		[Token(Token = "0x4001D51")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 _spawnPosition;

		[Token(Token = "0x4001D52")]
		[FieldOffset(Offset = "0x64")]
		private Quaternion _spawnRotation;

		[Token(Token = "0x4001D53")]
		[FieldOffset(Offset = "0x74")]
		private float _defaultDrag;

		[Token(Token = "0x4001D54")]
		[FieldOffset(Offset = "0x78")]
		private float _defaultAngularDrag;

		[Token(Token = "0x4001D55")]
		[FieldOffset(Offset = "0x7C")]
		private bool _netCaught;

		[Token(Token = "0x4001D56")]
		[FieldOffset(Offset = "0x7D")]
		private bool _saveBlocked;

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x4197074", Offset = "0x4193074", VA = "0x4197074")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x4197140", Offset = "0x4193140", VA = "0x4197140")]
		public void Shoot(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x41973D4", Offset = "0x41933D4", VA = "0x41973D4")]
		public void ApplySaveDeflect(FootballGoalAreaSettings area, FootballGoalZone zone)
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x4197530", Offset = "0x4193530", VA = "0x4197530")]
		private Vector3 ResolveSaveLateralDirection(FootballGoalAreaSettings area, FootballGoalZone zone)
		{
			return default;
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x41976C0", Offset = "0x41936C0", VA = "0x41976C0")]
		public void ApplyNetCatch()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x41977D0", Offset = "0x41937D0", VA = "0x41977D0")]
		public void ResetBall()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x41970F0", Offset = "0x41930F0", VA = "0x41970F0")]
		private void CacheSpawnTransform()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x41978D0", Offset = "0x41938D0", VA = "0x41978D0")]
		public FootballBallController()
		{
		}
	}
}
