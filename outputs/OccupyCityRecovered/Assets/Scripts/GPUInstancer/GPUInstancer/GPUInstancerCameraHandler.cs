using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200005C")]
	[RequireComponent(typeof(Camera))]
	public class GPUInstancerCameraHandler : MonoBehaviour
	{
		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x20")]
		private Camera _camera;

		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x28")]
		private bool _isCameraSet;

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x73F139C", Offset = "0x73ED39C", VA = "0x73F139C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x73F1428", Offset = "0x73ED428", VA = "0x73F1428")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x73F1430", Offset = "0x73ED430", VA = "0x73F1430")]
		private void Update()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x73F1498", Offset = "0x73ED498", VA = "0x73F1498")]
		public GPUInstancerCameraHandler()
		{
		}
	}
}
