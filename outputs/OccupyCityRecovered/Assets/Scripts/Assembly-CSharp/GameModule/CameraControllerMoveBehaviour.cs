using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20003C8")]
	public class CameraControllerMoveBehaviour : MonoBehaviour
	{
		[Token(Token = "0x400265C")]
		[FieldOffset(Offset = "0x20")]
		public float mapMaxX;

		[Token(Token = "0x400265D")]
		[FieldOffset(Offset = "0x24")]
		public float mapMinX;

		[Token(Token = "0x400265E")]
		[FieldOffset(Offset = "0x28")]
		public float mapMaxZ;

		[Token(Token = "0x400265F")]
		[FieldOffset(Offset = "0x2C")]
		public float mapMinZ;

		[Token(Token = "0x4002660")]
		[FieldOffset(Offset = "0x30")]
		public float moveSpeed;

		[Token(Token = "0x4002661")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 _lastTouchPosition;

		[Token(Token = "0x4002662")]
		[FieldOffset(Offset = "0x40")]
		private bool _isDragging;

		[Token(Token = "0x4002663")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 _bornPos;

		[Token(Token = "0x4002664")]
		[FieldOffset(Offset = "0x50")]
		private float _bornSize;

		[Token(Token = "0x4002665")]
		[FieldOffset(Offset = "0x54")]
		private Quaternion _bornRotateQuaternion;

		[Token(Token = "0x4002666")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 _mouseMoveBegin;

		[Token(Token = "0x4002667")]
		[FieldOffset(Offset = "0x70")]
		private GenealogyInteractCtrl _genealogyInteractCtrl;

		[Token(Token = "0x4002668")]
		[FieldOffset(Offset = "0x78")]
		private CinemachineVirtualCamera _cinemachineVirtualCamera;

		[Token(Token = "0x4002669")]
		[FieldOffset(Offset = "0x80")]
		private bool skillSteerIngNoMove;

		[Token(Token = "0x400266A")]
		[FieldOffset(Offset = "0x81")]
		private bool aniIngCameraCanMove;

		[Token(Token = "0x400266B")]
		[FieldOffset(Offset = "0x82")]
		private bool upgradeTowerIsShow;

		[Token(Token = "0x400266C")]
		[FieldOffset(Offset = "0x83")]
		private bool _isUpgradeMainTowerPanelDoAniIng;

		[Token(Token = "0x400266D")]
		[FieldOffset(Offset = "0x84")]
		private bool cameraShaking;

		[Token(Token = "0x400266E")]
		[FieldOffset(Offset = "0x88")]
		private float _lastCameraSize;

		[Token(Token = "0x400266F")]
		[FieldOffset(Offset = "0x8C")]
		private bool isZoomIng;

		[Token(Token = "0x60010ED")]
		[Address(RVA = "0x3DA825C", Offset = "0x3DA425C", VA = "0x3DA825C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60010EE")]
		[Address(RVA = "0x3DA85C8", Offset = "0x3DA45C8", VA = "0x3DA85C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60010EF")]
		[Address(RVA = "0x3DA8790", Offset = "0x3DA4790", VA = "0x3DA8790")]
		public void OnScaleValueChange(object obj)
		{
		}

		[Token(Token = "0x60010F0")]
		[Address(RVA = "0x3DA85CC", Offset = "0x3DA45CC", VA = "0x3DA85CC")]
		private void ConstrainCameraPosition()
		{
		}

		[Token(Token = "0x60010F1")]
		[Address(RVA = "0x3DA8844", Offset = "0x3DA4844", VA = "0x3DA8844")]
		private void OnUpgradeMainTowerPanelChangeActive(object o)
		{
		}

		[Token(Token = "0x60010F2")]
		[Address(RVA = "0x3DA88BC", Offset = "0x3DA48BC", VA = "0x3DA88BC")]
		private Vector3 ScreenToWorldPoint(Vector3 screenPos)
		{
			return default;
		}

		[Token(Token = "0x60010F3")]
		[Address(RVA = "0x3DA8940", Offset = "0x3DA4940", VA = "0x3DA8940")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60010F4")]
		[Address(RVA = "0x3DA8E68", Offset = "0x3DA4E68", VA = "0x3DA8E68")]
		private void UpgradeMainTowerPanelBeginDoAni(object o)
		{
		}

		[Token(Token = "0x60010F5")]
		[Address(RVA = "0x3DA8E74", Offset = "0x3DA4E74", VA = "0x3DA8E74")]
		private void UpgradeMainTowerPanelDoAniEnd(object o)
		{
		}

		[Token(Token = "0x60010F6")]
		[Address(RVA = "0x3DA8E7C", Offset = "0x3DA4E7C", VA = "0x3DA8E7C")]
		public Vector3 GetCameraPosition()
		{
			return default;
		}

		[Token(Token = "0x60010F7")]
		[Address(RVA = "0x3DA8E9C", Offset = "0x3DA4E9C", VA = "0x3DA8E9C")]
		public float GetCameraSize()
		{
			return default;
		}

		[Token(Token = "0x60010F8")]
		[Address(RVA = "0x3DA8F18", Offset = "0x3DA4F18", VA = "0x3DA8F18")]
		public void SetCameraPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60010F9")]
		[Address(RVA = "0x3DA8F60", Offset = "0x3DA4F60", VA = "0x3DA8F60")]
		public void SetCameraSize(float size)
		{
		}

		[Token(Token = "0x60010FA")]
		[Address(RVA = "0x3DA8FF8", Offset = "0x3DA4FF8", VA = "0x3DA8FF8")]
		public void MoveByEdgeDirection(Vector2 edgeDir, float speedMultiplier = 1f)
		{
		}

		[Token(Token = "0x60010FB")]
		[Address(RVA = "0x3DA91F4", Offset = "0x3DA51F4", VA = "0x3DA91F4")]
		public CameraControllerMoveBehaviour()
		{
		}
	}
}
