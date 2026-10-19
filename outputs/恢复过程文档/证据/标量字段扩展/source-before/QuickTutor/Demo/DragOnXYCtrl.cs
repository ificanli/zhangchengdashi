using Il2CppDummyDll;
using UnityEngine;

namespace QuickTutor.Demo
{
	[Token(Token = "0x2000C9F")]
	public class DragOnXYCtrl
	{
		[Token(Token = "0x4005A9A")]
		[FieldOffset(Offset = "0x10")]
		private readonly Camera _camera;

		[Token(Token = "0x4005A9B")]
		[FieldOffset(Offset = "0x18")]
		private readonly Transform _targetTrans;

		[Token(Token = "0x4005A9C")]
		[FieldOffset(Offset = "0x20")]
		private readonly float _distance;

		[Token(Token = "0x4005A9D")]
		[FieldOffset(Offset = "0x24")]
		private float _minX;

		[Token(Token = "0x4005A9E")]
		[FieldOffset(Offset = "0x28")]
		private float _maxX;

		[Token(Token = "0x4005A9F")]
		[FieldOffset(Offset = "0x2C")]
		private float _minY;

		[Token(Token = "0x4005AA0")]
		[FieldOffset(Offset = "0x30")]
		private float _maxY;

		[Token(Token = "0x4005AA1")]
		[FieldOffset(Offset = "0x34")]
		private bool _isDragging;

		[Token(Token = "0x4005AA2")]
		[FieldOffset(Offset = "0x35")]
		private bool _isLimit;

		[Token(Token = "0x4005AA3")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _diff;

		[Token(Token = "0x4005AA4")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 _velocity;

		[Token(Token = "0x4005AA5")]
		[FieldOffset(Offset = "0x50")]
		private Vector4 _size;

		[Token(Token = "0x17000E1F")]
		public bool IsLimit
		{
			[Token(Token = "0x6004F2C")]
			[Address(RVA = "0x42B33F0", Offset = "0x42AF3F0", VA = "0x42B33F0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004F2D")]
		[Address(RVA = "0x42B33F8", Offset = "0x42AF3F8", VA = "0x42B33F8")]
		public DragOnXYCtrl(Transform transform, Camera camera)
		{
		}

		[Token(Token = "0x6004F2E")]
		[Address(RVA = "0x42B3490", Offset = "0x42AF490", VA = "0x42B3490")]
		public void OpenLimit(Vector4 size)
		{
		}

		[Token(Token = "0x6004F2F")]
		[Address(RVA = "0x42B34A4", Offset = "0x42AF4A4", VA = "0x42B34A4")]
		private void CalculateBoundary()
		{
		}

		[Token(Token = "0x6004F30")]
		[Address(RVA = "0x42B3548", Offset = "0x42AF548", VA = "0x42B3548")]
		public void OnMouseInput(bool isDown)
		{
		}

		[Token(Token = "0x6004F31")]
		[Address(RVA = "0x42B3558", Offset = "0x42AF558", VA = "0x42B3558")]
		private void OnMouseDrag()
		{
		}

		[Token(Token = "0x6004F32")]
		[Address(RVA = "0x42B36E4", Offset = "0x42AF6E4", VA = "0x42B36E4")]
		private void OnMouseUp()
		{
		}

		[Token(Token = "0x6004F33")]
		[Address(RVA = "0x42B36EC", Offset = "0x42AF6EC", VA = "0x42B36EC")]
		public void ResetLimit()
		{
		}
	}
}
