using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000050")]
	[RequireComponent(typeof(CanvasRenderer))]
	public class NonDrawingGraphic : Graphic
	{
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x466F288", Offset = "0x466B288", VA = "0x466F288", Slot = "29")]
		public override void SetMaterialDirty()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x466F28C", Offset = "0x466B28C", VA = "0x466F28C", Slot = "28")]
		public override void SetVerticesDirty()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x466F290", Offset = "0x466B290", VA = "0x466F290", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x466F2A8", Offset = "0x466B2A8", VA = "0x466F2A8")]
		public NonDrawingGraphic()
		{
		}
	}
}
