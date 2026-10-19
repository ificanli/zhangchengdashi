using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000EB")]
	public class MeshBakerMaterialTexture
	{
		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x10")]
		private Texture2D _t;

		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x18")]
		public float texelDensity;

		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x0")]
		internal static bool readyToBuildAtlases;

		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x20")]
		private DRect encapsulatingSamplingRect;

		[Token(Token = "0x170000AD")]
		public Texture2D t
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x7494248", Offset = "0x7490248", VA = "0x7494248")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public DRect matTilingRect
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x7494250", Offset = "0x7490250", VA = "0x7494250")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x749425C", Offset = "0x749025C", VA = "0x749425C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public int isImportedAsNormalMap
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x7494268", Offset = "0x7490268", VA = "0x7494268")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x7494270", Offset = "0x7490270", VA = "0x7494270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public bool isNull
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x74944F4", Offset = "0x74904F4", VA = "0x74944F4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B1")]
		public int width
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x7494554", Offset = "0x7490554", VA = "0x7494554")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B2")]
		public int height
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x74945E0", Offset = "0x74905E0", VA = "0x74945E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x7494278", Offset = "0x7490278", VA = "0x7494278")]
		public MeshBakerMaterialTexture(Texture tx, Vector2 matTilingOffset, Vector2 matTilingScale, float texelDens, int isImportedAsNormalMap)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x749441C", Offset = "0x749041C", VA = "0x749441C")]
		public DRect GetEncapsulatingSamplingRect()
		{
			return default;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x7494428", Offset = "0x7490428", VA = "0x7494428")]
		public void SetEncapsulatingSamplingRect(MB_TexSet ts, DRect r)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x7494434", Offset = "0x7490434", VA = "0x7494434")]
		public Texture2D GetTexture2D()
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x749466C", Offset = "0x749066C", VA = "0x749466C")]
		public string GetTexName()
		{
			return null;
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x7494708", Offset = "0x7490708", VA = "0x7494708")]
		public bool AreTexturesEqual(MeshBakerMaterialTexture b)
		{
			return default;
		}
	}
}
