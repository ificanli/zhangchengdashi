using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000051")]
	[RequireComponent(typeof(CanvasRenderer))]
	public class NonDrawingMaskableGraphic : MaskableGraphic
	{
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x466F300", Offset = "0x466B300", VA = "0x466F300", Slot = "29")]
		public override void SetMaterialDirty()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x466F304", Offset = "0x466B304", VA = "0x466F304", Slot = "28")]
		public override void SetVerticesDirty()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x466F308", Offset = "0x466B308", VA = "0x466F308", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x466F320", Offset = "0x466B320", VA = "0x466F320")]
		public NonDrawingMaskableGraphic()
		{
		}
	}
}
