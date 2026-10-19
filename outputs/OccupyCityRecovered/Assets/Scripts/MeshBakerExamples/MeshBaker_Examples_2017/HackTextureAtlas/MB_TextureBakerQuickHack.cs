using Il2CppDummyDll;
using UnityEngine;

namespace MeshBaker_Examples_2017.HackTextureAtlas
{
	[Token(Token = "0x2000011")]
	public class MB_TextureBakerQuickHack : MonoBehaviour
	{
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x20")]
		[Header("Hack Atlas Generation")]
		public string colorTintPropertyName;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x28")]
		public string albedoTexturePropertyName;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x30")]
		public string shaderName;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x38")]
		public Material[] sourceMaterials;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x40")]
		[Space(20f)]
		[Header("Generated Output")]
		public MB2_TextureBakeResults materialBakeResult;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x48")]
		public Material atlasMaterial;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x50")]
		public Texture2D atlasTexture;

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x74C3A34", Offset = "0x74BFA34", VA = "0x74C3A34")]
		[ContextMenu("Generate Material Bake Result")]
		public void CreateAtlas(Material[] passedInSourceMaterials)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x74C54A8", Offset = "0x74C14A8", VA = "0x74C54A8")]
		public MB_TextureBakerQuickHack()
		{
		}
	}
}
