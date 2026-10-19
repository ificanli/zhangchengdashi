using Il2CppDummyDll;
using UnityEngine;

namespace YYBTool
{
	[Token(Token = "0x2000652")]
	public class TowardsTheCamera : MonoBehaviour
	{
		[Token(Token = "0x400337E")]
		[FieldOffset(Offset = "0x20")]
		private Camera _camera;

		[Token(Token = "0x400337F")]
		[FieldOffset(Offset = "0x28")]
		public bool reversal;

		[Token(Token = "0x6002141")]
		[Address(RVA = "0x3F22808", Offset = "0x3F1E808", VA = "0x3F22808")]
		private void Start()
		{
		}

		[Token(Token = "0x6002142")]
		[Address(RVA = "0x3F22824", Offset = "0x3F1E824", VA = "0x3F22824")]
		private void Update()
		{
		}

		[Token(Token = "0x6002143")]
		[Address(RVA = "0x3F22944", Offset = "0x3F1E944", VA = "0x3F22944")]
		public TowardsTheCamera()
		{
		}
	}
}
