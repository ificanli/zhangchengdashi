using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20003C9")]
	public class CameraMoveBehaviour : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003CB")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__30 : IAsyncStateMachine
		{
			[Token(Token = "0x4002694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CameraMoveBehaviour _003C_003E4__this;

			[Token(Token = "0x4002697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600111F")]
			[Address(RVA = "0x3DAB4EC", Offset = "0x3DA74EC", VA = "0x3DAB4EC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001120")]
			[Address(RVA = "0x3DAC04C", Offset = "0x3DA804C", VA = "0x3DAC04C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003CC")]
		[CompilerGenerated]
		private struct _003CDoPullInAni_003Ed__37 : IAsyncStateMachine
		{
			[Token(Token = "0x4002698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400269A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CameraMoveBehaviour _003C_003E4__this;

			[Token(Token = "0x400269B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool useAwait;

			[Token(Token = "0x400269C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001121")]
			[Address(RVA = "0x3DAC058", Offset = "0x3DA8058", VA = "0x3DAC058", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001122")]
			[Address(RVA = "0x3DAC528", Offset = "0x3DA8528", VA = "0x3DAC528", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20003CD")]
		[CompilerGenerated]
		private sealed class _003CFollowWithSpecificRules_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400269D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400269E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400269F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CameraMoveBehaviour _003C_003E4__this;

			[Token(Token = "0x40026A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform target;

			[Token(Token = "0x40026A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float smoothTime;

			[Token(Token = "0x40026A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delayAmount;

			[Token(Token = "0x40026A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float _003CvelocityX_003E5__2;

			[Token(Token = "0x40026A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float _003CvelocityZ_003E5__3;

			[Token(Token = "0x40026A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float _003CdelayedX_003E5__4;

			[Token(Token = "0x40026A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float _003CdelayedZ_003E5__5;

			[Token(Token = "0x40026A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float _003CfixedY_003E5__6;

			[Token(Token = "0x170000FC")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6001126")]
				[Address(RVA = "0x3DAC7D4", Offset = "0x3DA87D4", VA = "0x3DAC7D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000FD")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6001128")]
				[Address(RVA = "0x3DAC814", Offset = "0x3DA8814", VA = "0x3DAC814", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001123")]
			[Address(RVA = "0x3DAAE70", Offset = "0x3DA6E70", VA = "0x3DAAE70")]
			[DebuggerHidden]
			public _003CFollowWithSpecificRules_003Ed__52(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6001124")]
			[Address(RVA = "0x3DAC534", Offset = "0x3DA8534", VA = "0x3DAC534", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6001125")]
			[Address(RVA = "0x3DAC538", Offset = "0x3DA8538", VA = "0x3DAC538", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001126")]
			[Address(RVA = "0x3DAC7D4", Offset = "0x3DA87D4", VA = "0x3DAC7D4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001127")]
			[Address(RVA = "0x3DAC7DC", Offset = "0x3DA87DC", VA = "0x3DAC7DC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6001128")]
			[Address(RVA = "0x3DAC814", Offset = "0x3DA8814", VA = "0x3DAC814", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4002670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float mapMaxX;

		[Token(Token = "0x4002671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float mapMinX;

		[Token(Token = "0x4002672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float mapMaxZ;

		[Token(Token = "0x4002673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float mapMinZ;

		[Token(Token = "0x4002674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float moveSpeed;

		[Token(Token = "0x4002675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 _lastTouchPosition;

		[Token(Token = "0x4002676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _isDragging;

		[Token(Token = "0x4002677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool externalDragLock;

		[Token(Token = "0x4002678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 _bornPos;

		[Token(Token = "0x4002679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _bornSize;

		[Token(Token = "0x400267A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Quaternion _bornRotateQuaternion;

		[Token(Token = "0x400267B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 _mouseMoveBegin;

		[Token(Token = "0x400267C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GenealogyInteractCtrl _genealogyInteractCtrl;

		[Token(Token = "0x400267D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GenealogyTransCtrl _genealogyTransCtrl;

		[Token(Token = "0x400267E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool skillSteerIngNoMove;

		[Token(Token = "0x400267F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool aniIngCameraCanMove;

		[Token(Token = "0x4002680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Camera mainCamera;

		[Token(Token = "0x4002681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool upgradeTowerIsShow;

		[Token(Token = "0x4002682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool _isUpgradeMainTowerPanelDoAniIng;

		[Token(Token = "0x4002683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool cameraShaking;

		[Token(Token = "0x4002684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float _lastCameraSize;

		[Token(Token = "0x4002685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _originalMapMaxX;

		[Token(Token = "0x4002686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _originalMapMinX;

		[Token(Token = "0x4002687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _originalMapMaxZ;

		[Token(Token = "0x4002688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float _originalMapMinZ;

		[Token(Token = "0x4002689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool _hasOriginalBounds;

		[Token(Token = "0x400268A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string _restoreBoundsEventId;

		[Token(Token = "0x400268B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool _hasAppliedTrainingBounds;

		[Token(Token = "0x400268C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		private bool _hasRestoredBounds;

		[Token(Token = "0x400268D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		private bool isZoomIng;

		[Token(Token = "0x60010FD")]
		[Address(RVA = "0x3DA92D8", Offset = "0x3DA52D8", VA = "0x3DA92D8")]
		public void SetCameraCanMove(bool canMove)
		{
		}

		[Token(Token = "0x60010FE")]
		[Address(RVA = "0x3DA92E4", Offset = "0x3DA52E4", VA = "0x3DA92E4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__30))]
		private UniTask Awake()
		{
			return default;
		}

		[Token(Token = "0x60010FF")]
		[Address(RVA = "0x3DA9370", Offset = "0x3DA5370", VA = "0x3DA9370")]
		private void OnUpgradeMainTowerPanelChangeActive(object o)
		{
		}

		[Token(Token = "0x6001100")]
		[Address(RVA = "0x3DA93E8", Offset = "0x3DA53E8", VA = "0x3DA93E8")]
		private void SkillSteerIngBanCameraMove(object o)
		{
		}

		[Token(Token = "0x6001101")]
		[Address(RVA = "0x3DA93F4", Offset = "0x3DA53F4", VA = "0x3DA93F4")]
		private void SkillSteerEndCameraCanMove(object o)
		{
		}

		[Token(Token = "0x6001102")]
		[Address(RVA = "0x3DA93FC", Offset = "0x3DA53FC", VA = "0x3DA93FC")]
		public void DoAnimation(int orthoEndSize, int rotateEndNum)
		{
		}

		[Token(Token = "0x6001103")]
		[Address(RVA = "0x3DA96F4", Offset = "0x3DA56F4", VA = "0x3DA96F4")]
		public void SetCameraBeginPos(int orthoEndSize, int rotateEndNum)
		{
		}

		[Token(Token = "0x6001104")]
		[Address(RVA = "0x3DA976C", Offset = "0x3DA576C", VA = "0x3DA976C")]
		private void EnemyMainTowerDestroyCameraShake(object o)
		{
		}

		[Token(Token = "0x6001105")]
		[Address(RVA = "0x3DA98AC", Offset = "0x3DA58AC", VA = "0x3DA98AC")]
		[AsyncStateMachine(typeof(_003CDoPullInAni_003Ed__37))]
		public void DoPullInAni(bool useAwait = true)
		{
		}

		[Token(Token = "0x6001106")]
		[Address(RVA = "0x3DA9950", Offset = "0x3DA5950", VA = "0x3DA9950")]
		public void SetMap(float maxX, float minX, float maxZ, float minZ)
		{
		}

		[Token(Token = "0x6001107")]
		[Address(RVA = "0x3DA9988", Offset = "0x3DA5988", VA = "0x3DA9988")]
		private void ApplyTrainingCameraBoundsIfNeeded()
		{
		}

		[Token(Token = "0x6001108")]
		[Address(RVA = "0x3DA9DB4", Offset = "0x3DA5DB4", VA = "0x3DA9DB4")]
		private void RestoreOriginalCameraBounds(object o)
		{
		}

		[Token(Token = "0x6001109")]
		[Address(RVA = "0x3DAA10C", Offset = "0x3DA610C", VA = "0x3DAA10C")]
		private Vector3 ScreenToWorldPoint(Vector3 screenPos)
		{
			return default;
		}

		[Token(Token = "0x600110A")]
		[Address(RVA = "0x3DAA128", Offset = "0x3DA6128", VA = "0x3DAA128")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600110B")]
		[Address(RVA = "0x3DAA700", Offset = "0x3DA6700", VA = "0x3DAA700")]
		public void SetExternalDragLock(bool isLocked)
		{
		}

		[Token(Token = "0x600110C")]
		[Address(RVA = "0x3DAA714", Offset = "0x3DA6714", VA = "0x3DAA714")]
		public void CameraResert(object o)
		{
		}

		[Token(Token = "0x600110D")]
		[Address(RVA = "0x3DAA93C", Offset = "0x3DA693C", VA = "0x3DAA93C")]
		public void CameraPosResert()
		{
		}

		[Token(Token = "0x600110E")]
		[Address(RVA = "0x3DAA9C0", Offset = "0x3DA69C0", VA = "0x3DAA9C0")]
		private void PosToEnemy(object o)
		{
		}

		[Token(Token = "0x600110F")]
		[Address(RVA = "0x3DAAB44", Offset = "0x3DA6B44", VA = "0x3DAAB44")]
		private void PosToPlayer(object o)
		{
		}

		[Token(Token = "0x6001110")]
		[Address(RVA = "0x3DAAD1C", Offset = "0x3DA6D1C", VA = "0x3DAAD1C")]
		private void UpgradeMainTowerPanelBeginDoAni(object o)
		{
		}

		[Token(Token = "0x6001111")]
		[Address(RVA = "0x3DAAD28", Offset = "0x3DA6D28", VA = "0x3DAAD28")]
		private void UpgradeMainTowerPanelDoAniEnd(object o)
		{
		}

		[Token(Token = "0x6001112")]
		[Address(RVA = "0x3DAAD30", Offset = "0x3DA6D30", VA = "0x3DAAD30")]
		public void SetFollowTarget(Transform targetToFollow, float smoothTime = 0.05f, float delayAmount = 0.05f)
		{
		}

		[Token(Token = "0x6001113")]
		[Address(RVA = "0x3DAADF0", Offset = "0x3DA6DF0", VA = "0x3DAADF0")]
		[IteratorStateMachine(typeof(_003CFollowWithSpecificRules_003Ed__52))]
		private IEnumerator FollowWithSpecificRules(Transform target, float smoothTime, float delayAmount)
		{
			return null;
		}

		[Token(Token = "0x6001114")]
		[Address(RVA = "0x3DAAE98", Offset = "0x3DA6E98", VA = "0x3DAAE98")]
		public void MoveByEdgeDirection(Vector2 edgeDir, float speedMultiplier = 1f)
		{
		}

		[Token(Token = "0x6001115")]
		[Address(RVA = "0x3DAB094", Offset = "0x3DA7094", VA = "0x3DAB094")]
		public CameraMoveBehaviour()
		{
		}
	}
}
