using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000049")]
	[RequireComponent(typeof(Camera))]
	public class DraggedReferenceSourceCamera : MonoBehaviour
	{
		[Token(Token = "0x200004A")]
		public delegate Object RaycastHitProcesserDelegate(RaycastHit hit);

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x20")]
		private Camera _camera;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UISkin draggedReferenceSkin;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Canvas draggedReferenceCanvas;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float holdTime;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private LayerMask interactableObjectsMask;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float raycastRange;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x44")]
		private bool pointerDown;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x48")]
		private float pointerDownTime;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x4C")]
		private Vector2 pointerDownPos;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x58")]
		private Object hitObject;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x60")]
		private DraggedReferenceItem draggedReference;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x68")]
		private PointerEventData draggingPointer;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x70")]
		private readonly List<RaycastResult> hoveredUIElements;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x78")]
		public RaycastHitProcesserDelegate ProcessRaycastHit;

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x466E0D4", Offset = "0x466A0D4", VA = "0x466E0D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x466E124", Offset = "0x466A124", VA = "0x466E124")]
		private void Update()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x466E8F0", Offset = "0x466A8F0", VA = "0x466E8F0")]
		private bool IsPointerDown()
		{
			return default;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x466E8DC", Offset = "0x466A8DC", VA = "0x466E8DC")]
		private bool IsPointerHeld()
		{
			return default;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x466E8E8", Offset = "0x466A8E8", VA = "0x466E8E8")]
		private Vector2 GetPointerPosition()
		{
			return default;
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x466E8FC", Offset = "0x466A8FC", VA = "0x466E8FC")]
		public DraggedReferenceSourceCamera()
		{
		}
	}
}
