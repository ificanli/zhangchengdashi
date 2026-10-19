using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000136")]
	public class TextureBlenderMaterialPropertyCacheHelper
	{
		[Token(Token = "0x2000137")]
		private struct MaterialPropertyPair
		{
			[Token(Token = "0x40004AE")]
			[FieldOffset(Offset = "0x0")]
			public Material material;

			[Token(Token = "0x40004AF")]
			[FieldOffset(Offset = "0x8")]
			public string property;

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x74BA1B4", Offset = "0x74B61B4", VA = "0x74BA1B4")]
			public MaterialPropertyPair(Material m, string prop)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TextureBlenderMaterialPropertyCacheHelper.MaterialPropertyPair..ctor RVA=0x74BA1B4 Token=0x60006AB");
}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x74BA43C", Offset = "0x74B643C", VA = "0x74BA43C", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default;
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x74BA4E0", Offset = "0x74B64E0", VA = "0x74BA4E0", Slot = "2")]
			public override int GetHashCode()
			{
				return default;
			}
		}

		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<MaterialPropertyPair, object> nonTexturePropertyValuesForSourceMaterials;

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x74B9EFC", Offset = "0x74B5EFC", VA = "0x74B9EFC")]
		private bool AllNonTexturePropertyValuesAreEqual(string prop)
		{
			return default;
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x74BA144", Offset = "0x74B6144", VA = "0x74BA144")]
		public void CacheMaterialProperty(Material m, string property, object value)
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x74BA1BC", Offset = "0x74B61BC", VA = "0x74BA1BC")]
		public object GetValueIfAllSourceAreTheSameOrDefault(string property, object defaultValue)
		{
			return null;
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x74BA3C0", Offset = "0x74B63C0", VA = "0x74BA3C0")]
		public TextureBlenderMaterialPropertyCacheHelper()
		{
		}
	}
}
