using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GPUInstancer
{
	[Token(Token = "0x2000014")]
	public class SpaceshipMobileJoystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Vector3 inputDirection;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x30")]
		private Image joystickBase;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x38")]
		private Image joystick;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x40")]
		private Vector2 dragPosition;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x73B2928", Offset = "0x73AE928", VA = "0x73B2928")]
		private void Start()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x73B29E8", Offset = "0x73AE9E8", VA = "0x73B29E8", Slot = "7")]
		public virtual void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x73B2CB4", Offset = "0x73AECB4", VA = "0x73B2CB4", Slot = "8")]
		public virtual void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x73B2CC0", Offset = "0x73AECC0", VA = "0x73B2CC0", Slot = "9")]
		public virtual void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x73B2D64", Offset = "0x73AED64", VA = "0x73B2D64")]
		public SpaceshipMobileJoystick()
		{
		}
	}
}
