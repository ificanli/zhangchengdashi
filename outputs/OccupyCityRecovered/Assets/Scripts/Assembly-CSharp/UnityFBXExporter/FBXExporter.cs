using Il2CppDummyDll;
using UnityEngine;

namespace UnityFBXExporter
{
	[Token(Token = "0x2000D45")]
	public class FBXExporter
	{
		[Token(Token = "0x17000E5F")]
		public static string VersionInformation
		{
			[Token(Token = "0x6005232")]
			[Address(RVA = "0x42FB05C", Offset = "0x42F705C", VA = "0x42FB05C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005231")]
		[Address(RVA = "0x42F8C78", Offset = "0x42F4C78", VA = "0x42F8C78")]
		public static bool ExportGameObjToFBX(GameObject gameObj, string newPath, bool copyMaterials = false, bool copyTextures = false)
		{
			return default;
		}

		[Token(Token = "0x6005233")]
		[Address(RVA = "0x42FB09C", Offset = "0x42F709C", VA = "0x42FB09C")]
		public static long GetRandomFBXId()
		{
			return default;
		}

		[Token(Token = "0x6005234")]
		[Address(RVA = "0x42F8DBC", Offset = "0x42F4DBC", VA = "0x42F8DBC")]
		public static string MeshToString(GameObject gameObj, string newPath, bool copyMaterials = false, bool copyTextures = false)
		{
			return null;
		}

		[Token(Token = "0x6005235")]
		[Address(RVA = "0x42F8DB8", Offset = "0x42F4DB8", VA = "0x42F8DB8")]
		public static void CopyComplexMaterialsToPath(GameObject gameObj, string path, bool copyTextures, string texturesFolder = "/Textures", string materialsFolder = "/Materials")
		{
		}

		[Token(Token = "0x6005236")]
		[Address(RVA = "0x42FE5F4", Offset = "0x42FA5F4", VA = "0x42FE5F4")]
		public static bool CopyAndRenameAsset(Object obj, string newName, string newFolderPath)
		{
			return default;
		}

		[Token(Token = "0x6005237")]
		[Address(RVA = "0x42FE5FC", Offset = "0x42FA5FC", VA = "0x42FE5FC")]
		private static string GetFileName(string path)
		{
			return null;
		}

		[Token(Token = "0x6005238")]
		[Address(RVA = "0x42FE640", Offset = "0x42FA640", VA = "0x42FE640")]
		private static Material CopyTexturesAndAssignCopiesToMaterial(Material material, string newPath)
		{
			return null;
		}

		[Token(Token = "0x6005239")]
		[Address(RVA = "0x42FE984", Offset = "0x42FA984", VA = "0x42FE984")]
		private static void GetTextureUpdateMaterialWithPath(Material material, string textureShaderName, string newPath)
		{
		}

		[Token(Token = "0x600523A")]
		[Address(RVA = "0x42FEA7C", Offset = "0x42FAA7C", VA = "0x42FEA7C")]
		public static Object CopyAndRenameAssetReturnObject(Object obj, string newName, string newFolderPath)
		{
			return null;
		}

		[Token(Token = "0x600523B")]
		[Address(RVA = "0x42FEA84", Offset = "0x42FAA84", VA = "0x42FEA84")]
		public FBXExporter()
		{
		}
	}
}
