using Il2CppDummyDll;
using UnityEngine;

namespace ToolModule.UI
{
	[Token(Token = "0x20001C2")]
	[ExecuteAlways]
	public class GridLayoutMiddleCenter : MonoBehaviour
	{
		[Token(Token = "0x4001B3B")]
		[FieldOffset(Offset = "0x20")]
		[Header("行列设置")]
		public int itemsPerRow;

		[Token(Token = "0x4001B3C")]
		[FieldOffset(Offset = "0x24")]
		public float horizontalSpacing;

		[Token(Token = "0x4001B3D")]
		[FieldOffset(Offset = "0x28")]
		public float verticalSpacing;

		[Token(Token = "0x4001B3E")]
		[FieldOffset(Offset = "0x2C")]
		public float topPadding;

		[Token(Token = "0x4001B3F")]
		[FieldOffset(Offset = "0x30")]
		[Header("排列方向")]
		public bool topToBottom;

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x407EFFC", Offset = "0x407AFFC", VA = "0x407EFFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x407F000", Offset = "0x407B000", VA = "0x407F000")]
		public void Arrange()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x407F2D4", Offset = "0x407B2D4", VA = "0x407F2D4")]
		public GridLayoutMiddleCenter()
		{
		}
	}
}
