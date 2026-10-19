using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Serializable]
	[Token(Token = "0x20009B9")]
	public class MysteryAdventureBoardMoveSettings
	{
		[Token(Token = "0x4004874")]
		public const float FastAnimationSpeed = 3.5f;

		[Token(Token = "0x4004875")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("每格移动总时长（秒）")]
		public float moveStepDuration;

		[Token(Token = "0x4004876")]
		[FieldOffset(Offset = "0x14")]
		[Tooltip("跳跃高度下限（世界坐标）")]
		public float minJumpPower;

		[Token(Token = "0x4004877")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("跳跃高度上限（世界坐标）")]
		public float maxJumpPower;

		[Token(Token = "0x4004878")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("跳跃高度 = 格距 × 该系数，再 Clamp 到 min/max")]
		public float jumpPowerScale;

		[Token(Token = "0x4004879")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("DOJump 跳跃次数，1 为单次弧线")]
		public int jumpCount;

		[Token(Token = "0x400487A")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("跳跃缓动曲线")]
		public Ease jumpEase;

		[Token(Token = "0x400487B")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("起跳时是否压缩棋子 scale")]
		[Header("起跳压缩")]
		public bool enableSquash;

		[Token(Token = "0x400487C")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("起跳时 scale.y 乘数（<1 为压扁）")]
		public float squashScaleY;

		[Token(Token = "0x400487D")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("起跳时 scale.x 乘数（略 >1 可补偿体积）")]
		public float squashScaleX;

		[Token(Token = "0x400487E")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("起跳压缩时长（秒）")]
		public float squashInDuration;

		[Token(Token = "0x400487F")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("起跳压缩缓动")]
		public Ease squashInEase;

		[Token(Token = "0x4004880")]
		[FieldOffset(Offset = "0x3C")]
		[Header("落地回弹")]
		[Tooltip("落地后 scale 回弹时长（秒）")]
		public float landRecoverDuration;

		[Token(Token = "0x4004881")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("落地回弹缓动（OutBack 有弹簧感）")]
		public Ease landRecoverEase;

		[Token(Token = "0x4004882")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("落地回弹 overshoot，越大弹簧越明显")]
		public float landRecoverOvershoot;

		[Token(Token = "0x4004883")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("勾选后反转朝向（素材默认朝向不一致时可调）")]
		[Header("棋子朝向")]
		public bool swapFacingSprites;

		[Token(Token = "0x60039D4")]
		[Address(RVA = "0x4109A68", Offset = "0x4105A68", VA = "0x4109A68")]
		public static MysteryAdventureBoardMoveSettings CreateDefault()
		{
			return null;
		}

		[Token(Token = "0x60039D5")]
		[Address(RVA = "0x4109B74", Offset = "0x4105B74", VA = "0x4109B74")]
		public float GetJumpPower(float stepDistance)
		{
			return default;
		}

		[Token(Token = "0x60039D6")]
		[Address(RVA = "0x4109B94", Offset = "0x4105B94", VA = "0x4109B94")]
		public int GetJumpCount()
		{
			return default;
		}

		[Token(Token = "0x60039D7")]
		[Address(RVA = "0x4109BA4", Offset = "0x4105BA4", VA = "0x4109BA4")]
		public Vector3 GetSquashScale(Vector3 baseScale)
		{
			return default;
		}

		[Token(Token = "0x60039D8")]
		[Address(RVA = "0x4109B14", Offset = "0x4105B14", VA = "0x4109B14")]
		public MysteryAdventureBoardMoveSettings()
		{
		}
	}
}
