using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200022D")]
	public class FootballSightController : MonoBehaviour
	{
		[Token(Token = "0x4001DCF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _movementSpace;

		[Token(Token = "0x4001DD0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FootballGoalAreaSettings _area;

		[Token(Token = "0x4001DD1")]
		[FieldOffset(Offset = "0x30")]
		[Header("开局随机范围")]
		[SerializeField]
		private float _moveSpeedMin;

		[Token(Token = "0x4001DD2")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _moveSpeedMax;

		[Token(Token = "0x4001DD3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _speedJitterMin;

		[Token(Token = "0x4001DD4")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _speedJitterMax;

		[Token(Token = "0x4001DD5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _noiseAmountOptionA;

		[Token(Token = "0x4001DD6")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _noiseAmountOptionB;

		[Token(Token = "0x4001DD7")]
		private const float _noiseSpeed = 1f;

		[Token(Token = "0x4001DD8")]
		[FieldOffset(Offset = "0x48")]
		private float _moveSpeed;

		[Token(Token = "0x4001DD9")]
		[FieldOffset(Offset = "0x4C")]
		private float _speedJitter;

		[Token(Token = "0x4001DDA")]
		[FieldOffset(Offset = "0x50")]
		private float _noiseAmount;

		[Token(Token = "0x4001DDB")]
		[FieldOffset(Offset = "0x54")]
		private float _phase;

		[Token(Token = "0x4001DDC")]
		[FieldOffset(Offset = "0x58")]
		private float _noiseSeedX;

		[Token(Token = "0x4001DDD")]
		[FieldOffset(Offset = "0x5C")]
		private float _noiseSeedY;

		[Token(Token = "0x4001DDE")]
		[FieldOffset(Offset = "0x60")]
		private float _speedMultiplier;

		[Token(Token = "0x4001DDF")]
		[FieldOffset(Offset = "0x64")]
		private bool _isMoving;

		[Token(Token = "0x170000B2")]
		public Vector3 CurrentPosition
		{
			[Token(Token = "0x6000933")]
			[Address(RVA = "0x428A668", Offset = "0x4286668", VA = "0x428A668")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B3")]
		public FootballGoalAreaSettings Area
		{
			[Token(Token = "0x6000934")]
			[Address(RVA = "0x428DDA0", Offset = "0x4289DA0", VA = "0x428DDA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x428DDA8", Offset = "0x4289DA8", VA = "0x428DDA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x428DEE4", Offset = "0x4289EE4", VA = "0x428DEE4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x428A7D4", Offset = "0x42867D4", VA = "0x428A7D4")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x428E1F8", Offset = "0x428A1F8", VA = "0x428E1F8")]
		public void Resume()
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x428DE34", Offset = "0x4289E34", VA = "0x428DE34")]
		public void ResampleRandomness()
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x428E190", Offset = "0x428A190", VA = "0x428E190")]
		private void UpdateSpeedJitter()
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x428E214", Offset = "0x428A214", VA = "0x428E214")]
		public FootballSightController()
		{
		}
	}
}
