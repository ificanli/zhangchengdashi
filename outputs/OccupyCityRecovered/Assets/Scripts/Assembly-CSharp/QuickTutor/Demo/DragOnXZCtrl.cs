using Il2CppDummyDll;
using UnityEngine;

namespace QuickTutor.Demo
{
	[Token(Token = "0x2000CA0")]
	public class DragOnXZCtrl
	{
		[Token(Token = "0x4005AA6")]
		[FieldOffset(Offset = "0x10")]
		private readonly Camera _camera;

		[Token(Token = "0x4005AA7")]
		[FieldOffset(Offset = "0x18")]
		private readonly Transform _targetTrans;

		[Token(Token = "0x4005AA8")]
		[FieldOffset(Offset = "0x20")]
		private float _minX;

		[Token(Token = "0x4005AA9")]
		[FieldOffset(Offset = "0x24")]
		private float _maxX;

		[Token(Token = "0x4005AAA")]
		[FieldOffset(Offset = "0x28")]
		private float _minY;

		[Token(Token = "0x4005AAB")]
		[FieldOffset(Offset = "0x2C")]
		private float _maxY;

		[Token(Token = "0x4005AAC")]
		[FieldOffset(Offset = "0x30")]
		private bool _isDragging;

		[Token(Token = "0x4005AAD")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 _diff;

		[Token(Token = "0x4005AAE")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _velocity;

		[Token(Token = "0x6004F34")]
		[Address(RVA = "0x42B36F0", Offset = "0x42AF6F0", VA = "0x42B36F0")]
		public DragOnXZCtrl(Transform transform, Camera camera)
		{
		}

		[Token(Token = "0x6004F35")]
		[Address(RVA = "0x42B375C", Offset = "0x42AF75C", VA = "0x42B375C")]
		public void OnMouseInput(bool isDown)
		{
		}

		[Token(Token = "0x6004F36")]
		[Address(RVA = "0x42B376C", Offset = "0x42AF76C", VA = "0x42B376C")]
		private void OnMouseDrag()
		{
		}

		[Token(Token = "0x6004F37")]
		[Address(RVA = "0x42B38D0", Offset = "0x42AF8D0", VA = "0x42B38D0")]
		private Vector3 ScreenToWorldPositionXZ(Vector2 screenPos, Vector3 targetPos)
		{
			return default;
		}

		[Token(Token = "0x6004F38")]
		[Address(RVA = "0x42B3964", Offset = "0x42AF964", VA = "0x42B3964")]
		private Vector3 ScreenToWorldPositionXZ(Vector2 screenPos, Vector3 targetPos, Vector3 planeNormal)
		{
			return default;
		}

		[Token(Token = "0x6004F39")]
		[Address(RVA = "0x42B3A24", Offset = "0x42AFA24", VA = "0x42B3A24")]
		private static Vector3 GetIntersectWithLineAndPlane(Vector3 point, Vector3 direct, Vector3 planeNormal, Vector3 planePoint)
		{
			return default;
		}

		[Token(Token = "0x6004F3A")]
		[Address(RVA = "0x42B38C8", Offset = "0x42AF8C8", VA = "0x42B38C8")]
		private void OnMouseUp()
		{
		}
	}
}
