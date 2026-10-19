using Il2CppDummyDll;
using UnityEngine;

namespace ToonyColorsPro.Runtime
{
	[Token(Token = "0x2000004")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class TCP2_CameraDepth : MonoBehaviour
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		public bool RenderDepth;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x7D5FE94", Offset = "0x7D5BE94", VA = "0x7D5FE94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x7D5FF0C", Offset = "0x7D5BF0C", VA = "0x7D5FF0C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x7D5FE98", Offset = "0x7D5BE98", VA = "0x7D5FE98")]
		private void SetCameraDepth()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x7D5FF10", Offset = "0x7D5BF10", VA = "0x7D5FF10")]
		public TCP2_CameraDepth()
		{
		}
	}
}
