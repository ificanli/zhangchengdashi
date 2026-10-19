using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200003D")]
	public interface MB2_EditorMethodsInterface
	{
		[Token(Token = "0x60000FC")]
		void Clear();

		[Token(Token = "0x60000FD")]
		void RestoreReadFlagsAndFormats(ProgressUpdateDelegate progressInfo);

		[Token(Token = "0x60000FE")]
		void SetReadWriteFlag(Texture2D tx, bool isReadable, bool addToList);

		[Token(Token = "0x60000FF")]
		void ConvertTextureFormat_DefaultPlatform(Texture2D tx, TextureFormat targetFormat, bool isNormalMap);

		[Token(Token = "0x6000100")]
		void ConvertTextureFormat_PlatformOverride(Texture2D tx, TextureFormat targetFormat, MB_TextureCompressionQuality compressionQuality, bool isNormalMap);

		[Token(Token = "0x6000101")]
		void SaveTextureArrayToAssetDatabase(Texture2DArray atlas, TextureFormat foramt, string texPropertyName, int atlasNum, Material resMat);

		[Token(Token = "0x6000102")]
		void SaveAtlasToAssetDatabase(Texture2D atlas, ShaderTextureProperty texPropertyName, int atlasNum, bool doAnySrcMatsHaveProperty, Material resMat);

		[Token(Token = "0x6000103")]
		bool IsNormalMap(Texture2D tx);

		[Token(Token = "0x6000104")]
		string GetPlatformString();

		[Token(Token = "0x6000105")]
		void SetTextureSize(Texture2D tx, int size);

		[Token(Token = "0x6000106")]
		bool IsCompressed(Texture2D tx);

		[Token(Token = "0x6000107")]
		void CheckBuildSettings(long estimatedAtlasSize);

		[Token(Token = "0x6000108")]
		bool CheckPrefabTypes(MB_ObjsToCombineTypes prefabType, List<GameObject> gos);

		[Token(Token = "0x6000109")]
		bool ValidateSkinnedMeshes(List<GameObject> mom);

		[Token(Token = "0x600010A")]
		void CommitChangesToAssets();

		[Token(Token = "0x600010B")]
		void OnPreTextureBake();

		[Token(Token = "0x600010C")]
		void OnPostTextureBake();

		[Token(Token = "0x600010D")]
		void Destroy(Object o);

		[Token(Token = "0x600010E")]
		void DestroyAsset(Object o);

		[Token(Token = "0x600010F")]
		bool IsAnAsset(Object o);

		[Token(Token = "0x6000110")]
		Texture2D CreateTemporaryAssetCopyForTextureArray(ShaderTextureProperty prop, Texture2D sliceTex, int w, int h, TextureFormat format, MB2_LogLevel logLevel);

		[Token(Token = "0x6000111")]
		bool TextureImporterFormatExistsForTextureFormat(TextureFormat texFormat);

		[Token(Token = "0x6000112")]
		bool ConvertTexture2DArray(Texture2DArray inArray, Texture2DArray outArray, TextureFormat outFormat);

		[Token(Token = "0x6000113")]
		void GetMaterialPrimaryKeysIfAddressables(MB2_TextureBakeResults textureBakeResults);
	}
}
