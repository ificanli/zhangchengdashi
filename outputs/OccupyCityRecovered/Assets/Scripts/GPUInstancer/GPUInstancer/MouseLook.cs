using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200001E")]
	public class MouseLook
	{
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x73B5938", Offset = "0x73B1938", VA = "0x73B5938")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x73B6054", Offset = "0x73B2054", VA = "0x73B6054")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x73B65A0", Offset = "0x73B25A0", VA = "0x73B65A0")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x73B6044", Offset = "0x73B2044", VA = "0x73B6044")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x73B65D4", Offset = "0x73B25D4", VA = "0x73B65D4")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x73B653C", Offset = "0x73B253C", VA = "0x73B653C")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x73B5904", Offset = "0x73B1904", VA = "0x73B5904")]
		public MouseLook()
		{
		}
	}
}
