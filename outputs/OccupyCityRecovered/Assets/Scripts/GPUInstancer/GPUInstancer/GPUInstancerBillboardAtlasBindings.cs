using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200002F")]
	public class GPUInstancerBillboardAtlasBindings : ScriptableObject
	{
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x18")]
		public List<BillboardAtlasBinding> billboardAtlasBindings;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x73D83B4", Offset = "0x73D43B4", VA = "0x73D83B4")]
		public BillboardAtlasBinding GetBillboardAtlasBinding(GameObject prefab, int atlasResolution, int frameCount)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x73D8574", Offset = "0x73D4574", VA = "0x73D8574")]
		public void ResetBillboardAtlases()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x73D8620", Offset = "0x73D4620", VA = "0x73D8620")]
		public void ClearEmptyBillboardAtlases()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x73D8624", Offset = "0x73D4624", VA = "0x73D8624")]
		public void AddBillboardAtlas(GameObject prefab, int atlasResolution, int frameCount, Texture2D albedoAtlasTexture, Texture2D normalAtlasTexture, float quadSize, float yPivotOffset)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x73D8864", Offset = "0x73D4864", VA = "0x73D8864")]
		public void RemoveBillboardAtlas(BillboardAtlasBinding billboardAtlasBinding)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x73D88BC", Offset = "0x73D48BC", VA = "0x73D88BC")]
		public bool IsBillboardAtlasExists(GameObject prefab)
		{
			return default;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x73D8A64", Offset = "0x73D4A64", VA = "0x73D8A64")]
		public bool DeleteBillboardTextures(GPUInstancerPrototype selectedPrototype, bool exitGUI = true)
		{
			return default;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x73D8A6C", Offset = "0x73D4A6C", VA = "0x73D8A6C")]
		public bool DeleteBillboardTextures(List<GPUInstancerPrototype> selectedPrototypeList, bool exitGUI = true)
		{
			return default;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x73D8A74", Offset = "0x73D4A74", VA = "0x73D8A74")]
		public GPUInstancerBillboardAtlasBindings()
		{
		}
	}
}
