using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	[Token(Token = "0x2000CDD")]
	public class MaterialData
	{
		[Token(Token = "0x4005C01")]
		[FieldOffset(Offset = "0x10")]
		public string materialName;

		[Token(Token = "0x4005C02")]
		[FieldOffset(Offset = "0x18")]
		public Color ambientColor;

		[Token(Token = "0x4005C03")]
		[FieldOffset(Offset = "0x28")]
		public Color diffuseColor;

		[Token(Token = "0x4005C04")]
		[FieldOffset(Offset = "0x38")]
		public Color specularColor;

		[Token(Token = "0x4005C05")]
		[FieldOffset(Offset = "0x48")]
		public Color emissiveColor;

		[Token(Token = "0x4005C06")]
		[FieldOffset(Offset = "0x58")]
		public float shininess;

		[Token(Token = "0x4005C07")]
		[FieldOffset(Offset = "0x5C")]
		public float overallAlpha;

		[Token(Token = "0x4005C08")]
		[FieldOffset(Offset = "0x60")]
		public int illumType;

		[Token(Token = "0x4005C09")]
		[FieldOffset(Offset = "0x64")]
		public bool hasReflectionTex;

		[Token(Token = "0x4005C0A")]
		[FieldOffset(Offset = "0x68")]
		public string diffuseTexPath;

		[Token(Token = "0x4005C0B")]
		[FieldOffset(Offset = "0x70")]
		public Texture2D diffuseTex;

		[Token(Token = "0x4005C0C")]
		[FieldOffset(Offset = "0x78")]
		public string bumpTexPath;

		[Token(Token = "0x4005C0D")]
		[FieldOffset(Offset = "0x80")]
		public Texture2D bumpTex;

		[Token(Token = "0x4005C0E")]
		[FieldOffset(Offset = "0x88")]
		public string specularTexPath;

		[Token(Token = "0x4005C0F")]
		[FieldOffset(Offset = "0x90")]
		public Texture2D specularTex;

		[Token(Token = "0x4005C10")]
		[FieldOffset(Offset = "0x98")]
		public string opacityTexPath;

		[Token(Token = "0x4005C11")]
		[FieldOffset(Offset = "0xA0")]
		public Texture2D opacityTex;

		[Token(Token = "0x600505B")]
		[Address(RVA = "0x42C4C68", Offset = "0x42C0C68", VA = "0x42C4C68")]
		public MaterialData()
		{
		}
	}
}
