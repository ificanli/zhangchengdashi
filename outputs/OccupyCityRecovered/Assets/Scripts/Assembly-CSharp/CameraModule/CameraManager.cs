using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cinemachine;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace CameraModule
{
	[Token(Token = "0x200062C")]
	public class CameraManager : ManagerBase<CameraManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200062D")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4003297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x60020B2")]
			[Address(RVA = "0x3F12568", Offset = "0x3F0E568", VA = "0x3F12568", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60020B3")]
			[Address(RVA = "0x3F1261C", Offset = "0x3F0E61C", VA = "0x3F1261C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Camera _mainCamera;

		[Token(Token = "0x4003294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Camera _uiCamera;

		[Token(Token = "0x4003295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CinemachineBrain _cinemachineBrain;

		[Token(Token = "0x4003296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<CinemachineVirtualCamera> _virtualCameras;

		[Token(Token = "0x170001C5")]
		public Camera MainCamera
		{
			[Token(Token = "0x60020A6")]
			[Address(RVA = "0x3F11DF0", Offset = "0x3F0DDF0", VA = "0x3F11DF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C6")]
		public Camera UICamera
		{
			[Token(Token = "0x60020A7")]
			[Address(RVA = "0x3F0E8CC", Offset = "0x3F0A8CC", VA = "0x3F0E8CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C7")]
		public CinemachineBrain CinemachineBrain
		{
			[Token(Token = "0x60020A8")]
			[Address(RVA = "0x3F11E68", Offset = "0x3F0DE68", VA = "0x3F11E68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60020A9")]
		[Address(RVA = "0x3F11F08", Offset = "0x3F0DF08", VA = "0x3F11F08")]
		public void SwitchToCamera(GameObject cameraGo, float blendTime = 0.5f)
		{
		}

		[Token(Token = "0x60020AA")]
		[Address(RVA = "0x3F1213C", Offset = "0x3F0E13C", VA = "0x3F1213C")]
		public void Clear()
		{
		}

		[Token(Token = "0x60020AB")]
		[Address(RVA = "0x3F121AC", Offset = "0x3F0E1AC", VA = "0x3F121AC", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__12))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60020AC")]
		[Address(RVA = "0x3F1222C", Offset = "0x3F0E22C", VA = "0x3F1222C")]
		public void CameraAdaptation()
		{
		}

		[Token(Token = "0x60020AD")]
		[Address(RVA = "0x3F12240", Offset = "0x3F0E240", VA = "0x3F12240")]
		private void CameraAdaptation(Camera targetCamera)
		{
		}

		[Token(Token = "0x60020AE")]
		[Address(RVA = "0x3F12318", Offset = "0x3F0E318", VA = "0x3F12318")]
		public float GetUIScaleRatio()
		{
			return default;
		}

		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x3F123C4", Offset = "0x3F0E3C4", VA = "0x3F123C4")]
		public float GetCameraYPosition()
		{
			return default;
		}

		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x3F12450", Offset = "0x3F0E450", VA = "0x3F12450")]
		public float GetBattleCameraOrthoSize()
		{
			return default;
		}

		[Token(Token = "0x60020B1")]
		[Address(RVA = "0x3F124D8", Offset = "0x3F0E4D8", VA = "0x3F124D8")]
		public CameraManager()
		{
		}
	}
}
