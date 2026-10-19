using System.Collections.Generic;
using BrainFailProductions.PolyFewRuntime;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew
{
	[Token(Token = "0x2000CBF")]
	[ExecuteInEditMode]
	public class ObjectMaterialLinks : MonoBehaviour
	{
		[Token(Token = "0x4005B7A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<CombiningInformation.MaterialEntity> linkedEntities;

		[Token(Token = "0x4005B7B")]
		[FieldOffset(Offset = "0x28")]
		public List<PolyfewRuntime.MaterialProperties> materialsProperties;

		[Token(Token = "0x4005B7C")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D linkedAttrImg;

		[Token(Token = "0x17000E25")]
		public List<CombiningInformation.MaterialEntity> linkedMaterialEntities
		{
			[Token(Token = "0x6004FD8")]
			[Address(RVA = "0x42BC1C8", Offset = "0x42B81C8", VA = "0x42BC1C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FD9")]
			[Address(RVA = "0x42BC1D0", Offset = "0x42B81D0", VA = "0x42BC1D0")]
			set
			{
			}
		}

		[Token(Token = "0x6004FDA")]
		[Address(RVA = "0x42BC4EC", Offset = "0x42B84EC", VA = "0x42BC4EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6004FDB")]
		[Address(RVA = "0x42BC7CC", Offset = "0x42B87CC", VA = "0x42BC7CC")]
		public ObjectMaterialLinks()
		{
		}
	}
}
