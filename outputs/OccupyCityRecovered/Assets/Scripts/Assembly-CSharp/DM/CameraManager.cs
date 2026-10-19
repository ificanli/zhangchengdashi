using Il2CppDummyDll;
using UnityEngine;

namespace DM
{
	[Token(Token = "0x2000D49")]
	public class CameraManager : MonoBehaviour
	{
		[Token(Token = "0x4005ED6")]
		[FieldOffset(Offset = "0x20")]
		public float followSpeed;

		[Token(Token = "0x4005ED7")]
		[FieldOffset(Offset = "0x24")]
		public float mouseSpeed;

		[Token(Token = "0x4005ED8")]
		[FieldOffset(Offset = "0x28")]
		public float controllerSpeed;

		[Token(Token = "0x4005ED9")]
		[FieldOffset(Offset = "0x30")]
		public Transform target;

		[Token(Token = "0x4005EDA")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public Transform pivot;

		[Token(Token = "0x4005EDB")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public Transform camTrans;

		[Token(Token = "0x4005EDC")]
		[FieldOffset(Offset = "0x48")]
		private float turnSmoothing;

		[Token(Token = "0x4005EDD")]
		[FieldOffset(Offset = "0x4C")]
		public float minAngle;

		[Token(Token = "0x4005EDE")]
		[FieldOffset(Offset = "0x50")]
		public float maxAngle;

		[Token(Token = "0x4005EDF")]
		[FieldOffset(Offset = "0x54")]
		private float smoothX;

		[Token(Token = "0x4005EE0")]
		[FieldOffset(Offset = "0x58")]
		private float smoothY;

		[Token(Token = "0x4005EE1")]
		[FieldOffset(Offset = "0x5C")]
		private float smoothXVelocity;

		[Token(Token = "0x4005EE2")]
		[FieldOffset(Offset = "0x60")]
		private float smoothYVelocity;

		[Token(Token = "0x4005EE3")]
		[FieldOffset(Offset = "0x64")]
		public float lookAngle;

		[Token(Token = "0x4005EE4")]
		[FieldOffset(Offset = "0x68")]
		public float tiltAngle;

		[Token(Token = "0x4005EE5")]
		[FieldOffset(Offset = "0x0")]
		public static CameraManager singleton;

		[Token(Token = "0x6005245")]
		[Address(RVA = "0x42FEF34", Offset = "0x42FAF34", VA = "0x42FEF34")]
		public void Init(Transform t)
		{
		}

		[Token(Token = "0x6005246")]
		[Address(RVA = "0x42FEF74", Offset = "0x42FAF74", VA = "0x42FEF74")]
		public void FixedTick(float d)
		{
		}

		[Token(Token = "0x6005247")]
		[Address(RVA = "0x42FF0A0", Offset = "0x42FB0A0", VA = "0x42FF0A0")]
		private void FollowTarget(float d)
		{
		}

		[Token(Token = "0x6005248")]
		[Address(RVA = "0x42FF168", Offset = "0x42FB168", VA = "0x42FF168")]
		private void HandleRotations(float d, float v, float h, float targetSpeed)
		{
		}

		[Token(Token = "0x6005249")]
		[Address(RVA = "0x42FF2D0", Offset = "0x42FB2D0", VA = "0x42FF2D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600524A")]
		[Address(RVA = "0x42FF31C", Offset = "0x42FB31C", VA = "0x42FF31C")]
		public CameraManager()
		{
		}
	}
}
