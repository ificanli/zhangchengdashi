using System;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200000D")]
public class MB_TextureArrayFormat
{
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x10")]
	public string propertyName;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x18")]
	public TextureFormat format;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x1C")]
	[Tooltip("The ammount of time Unity takes exploring different compression options to find the compressed version of a texture that most closely matches the original art.This is only used For iOS (and some Android formats)")]
	public MB_TextureCompressionQuality compressionQuality;

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x743C0F4", Offset = "0x74380F4", VA = "0x743C0F4")]
	public MB_TextureArrayFormat()
	{
	}
}
