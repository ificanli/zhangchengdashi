using System;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200000E")]
public class MB_TextureArrayFormatSet
{
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x18")]
	public TextureFormat defaultFormat;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x1C")]
	[Tooltip("The ammount of time Unity takes exploring different compression options to find the compressed version of a texture that most closely matches the original art.This is only used For iOS (and some Android formats)")]
	public MB_TextureCompressionQuality defaultCompressionQuality;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x20")]
	[NonReorderable]
	public MB_TextureArrayFormat[] formatOverrides;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x743C104", Offset = "0x7438104", VA = "0x743C104")]
	public bool ValidateTextureImporterFormatsExistsForTextureFormats(MB2_EditorMethodsInterface editorMethods, int idx)
	{
		return default;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x743C494", Offset = "0x7438494", VA = "0x743C494")]
	public TextureFormat GetFormatForProperty(string propName, out MB_TextureCompressionQuality compressionQuality)
	{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB_TextureArrayFormatSet.GetFormatForProperty RVA=0x743C494 Token=0x600001C");
}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x743C548", Offset = "0x7438548", VA = "0x743C548")]
	public MB_TextureArrayFormatSet()
	{
	}
}
