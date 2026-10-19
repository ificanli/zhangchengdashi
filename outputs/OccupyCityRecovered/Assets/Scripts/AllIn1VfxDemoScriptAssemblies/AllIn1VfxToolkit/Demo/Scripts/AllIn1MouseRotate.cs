using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x2000011")]
	public class AllIn1MouseRotate : MonoBehaviour
	{
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform objectToRotate;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationSpeedHorizontal;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float translateVerticalSpeed;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float translateScrollSpeed;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Header("Lock Cursor")]
		[Space]
		private bool lockCursor;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private KeyCode lockCursorKeyCode;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AllIn1DemoScaleTween hideUiButtonTween;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image lockedButtonImage;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text lockedButtonText;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color lockedButtonColor;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x68")]
		private bool cursorIsLocked;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x6C")]
		[Header("Movement Bounds")]
		[SerializeField]
		[Space]
		private float maxHeight;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float maxZoom;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float minZoom;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 currPosition;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x84")]
		private float dt;

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x3CEFDE4", Offset = "0x3CEBDE4", VA = "0x3CEFDE4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x3CEFF1C", Offset = "0x3CEBF1C", VA = "0x3CEFF1C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x3CEFF9C", Offset = "0x3CEBF9C", VA = "0x3CEFF9C")]
		private void CamRotateAroundYAxis()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x3CF0098", Offset = "0x3CEC098", VA = "0x3CF0098")]
		private void CamHeightTranslate()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x3CF0154", Offset = "0x3CEC154", VA = "0x3CF0154")]
		private void CamZoom()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x3CEFDF4", Offset = "0x3CEBDF4", VA = "0x3CEFDF4")]
		public void ToggleCursorLocked()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x3CF03DC", Offset = "0x3CEC3DC", VA = "0x3CF03DC")]
		public AllIn1MouseRotate()
		{
		}
	}
}
