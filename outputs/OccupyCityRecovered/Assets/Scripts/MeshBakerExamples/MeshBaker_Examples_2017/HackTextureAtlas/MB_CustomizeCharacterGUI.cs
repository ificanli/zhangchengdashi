using Il2CppDummyDll;
using UnityEngine;

namespace MeshBaker_Examples_2017.HackTextureAtlas
{
	[Token(Token = "0x2000010")]
	public class MB_CustomizeCharacterGUI : MonoBehaviour
	{
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x20")]
		public Material[] sourceMaterials;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] objectsToBeCombined;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x30")]
		[Header("Mesh Baker Config")]
		public MB3_MeshBaker targetMeshBaker;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x38")]
		private MB_TextureBakerQuickHack textureBakerQuickHack;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x40")]
		private string colorTintPropertyName;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x48")]
		private string albedoTexturePropertyName;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x50")]
		private string shaderName;

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x74C3828", Offset = "0x74BF828", VA = "0x74C3828")]
		private void Start()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x74C4A4C", Offset = "0x74C0A4C", VA = "0x74C4A4C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x74C5338", Offset = "0x74C1338", VA = "0x74C5338")]
		private void SetColorInMaterialBakeResultAndBakeMeshBaker(Material bodyPartMaterial, Color color)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x74C49BC", Offset = "0x74C09BC", VA = "0x74C49BC")]
		[ContextMenu("Bake Mesh Baker")]
		private void BakeMeshBaker()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x74C54A0", Offset = "0x74C14A0", VA = "0x74C54A0")]
		public MB_CustomizeCharacterGUI()
		{
		}
	}
}
