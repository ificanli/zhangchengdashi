using Il2CppDummyDll;
using UnityEngine;

namespace QuickTutor.Demo
{
	[Token(Token = "0x2000CA2")]
	public class TutorialDemoDrag : MonoBehaviour
	{
		[Token(Token = "0x4005AB0")]
		[FieldOffset(Offset = "0x20")]
		private DragOnXZCtrl _dragOnXZ;

		[Token(Token = "0x4005AB1")]
		[FieldOffset(Offset = "0x28")]
		public bool isTarget;

		[Token(Token = "0x6004F3E")]
		[Address(RVA = "0x42B3C64", Offset = "0x42AFC64", VA = "0x42B3C64")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004F3F")]
		[Address(RVA = "0x42B3CE8", Offset = "0x42AFCE8", VA = "0x42B3CE8")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x6004F40")]
		[Address(RVA = "0x42B3D08", Offset = "0x42AFD08", VA = "0x42B3D08")]
		private void OnMouseDrag()
		{
		}

		[Token(Token = "0x6004F41")]
		[Address(RVA = "0x42B3D20", Offset = "0x42AFD20", VA = "0x42B3D20")]
		private void OnMouseUp()
		{
		}

		[Token(Token = "0x6004F42")]
		[Address(RVA = "0x42B3D3C", Offset = "0x42AFD3C", VA = "0x42B3D3C")]
		private void OnTriggerEnter(Collider col)
		{
		}

		[Token(Token = "0x6004F43")]
		[Address(RVA = "0x42B3D00", Offset = "0x42AFD00", VA = "0x42B3D00")]
		public static bool IsOverGameObject()
		{
			return default;
		}

		[Token(Token = "0x6004F44")]
		[Address(RVA = "0x42B3DF8", Offset = "0x42AFDF8", VA = "0x42B3DF8")]
		public TutorialDemoDrag()
		{
		}
	}
}
