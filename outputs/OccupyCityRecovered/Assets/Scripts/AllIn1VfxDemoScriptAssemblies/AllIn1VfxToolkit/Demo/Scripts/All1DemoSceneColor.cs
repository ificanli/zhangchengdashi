using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x2000007")]
	[RequireComponent(typeof(Dropdown))]
	public class All1DemoSceneColor : MonoBehaviour
	{
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color[] sceneColors;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Camera targetCamera;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float cameraColorMult;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MeshRenderer floorMeshRenderer;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float floorColorMult;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float fogColorMult;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x48")]
		private Dropdown sceneColorDropdown;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x50")]
		private Material floorMaterial;

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x3CEF13C", Offset = "0x3CEB13C", VA = "0x3CEF13C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x3CEF1AC", Offset = "0x3CEB1AC", VA = "0x3CEF1AC")]
		public void DropdownValueChanged()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x3CEF1C8", Offset = "0x3CEB1C8", VA = "0x3CEF1C8")]
		private void SetSceneColor(int nIndex)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x3CEF2B0", Offset = "0x3CEB2B0", VA = "0x3CEF2B0")]
		public All1DemoSceneColor()
		{
		}
	}
}
