using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace AllIn1VfxToolkit.DemoAssets.TexturesDemo.Scripts
{
	[Token(Token = "0x2000006")]
	public class AllIn1VfxTextureDemoManager : MonoBehaviour
	{
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int startingCollectionIndex;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int startingPageIndex;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x28")]
		[Space]
		[Header("Demo Textures")]
		[SerializeField]
		private All1VfxDemoTextureCollection[] textureCollections;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x30")]
		[Header("Demo Controller Input")]
		[SerializeField]
		[Space]
		private KeyCode nextPageKey;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private KeyCode nextPageKeyAlt;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private KeyCode previousPageKey;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private KeyCode previousPageKeyAlt;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private KeyCode nextCollectionKey;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private KeyCode nextCollectionKeyAlt;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private KeyCode previousCollectionKey;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private KeyCode previousCollectionKeyAlt;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x50")]
		[Space]
		[Header("References")]
		[SerializeField]
		private RawImage[] images;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text collectionText;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text pageText;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AllIn1DemoScaleTween expositorTween;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AllIn1DemoScaleTween nextPageButtTween;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AllIn1DemoScaleTween prevPageButtTween;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AllIn1DemoScaleTween nextCollectionButtTween;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AllIn1DemoScaleTween prevCollectionButtTween;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x90")]
		private int currTextureCollectionIndex;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x94")]
		private int currTextureIndex;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x98")]
		private int numberOfImagesPerPage;

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x3CF2694", Offset = "0x3CEE694", VA = "0x3CF2694")]
		private void Start()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x3CF2974", Offset = "0x3CEE974", VA = "0x3CF2974")]
		private void Update()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x3CF2A38", Offset = "0x3CEEA38", VA = "0x3CF2A38")]
		public void ChangeTextureIndex(int pagesAmount)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x3CF2B14", Offset = "0x3CEEB14", VA = "0x3CF2B14")]
		public void ChangeCollectionIndex(int collectionChangeAmount)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x3CF26C8", Offset = "0x3CEE6C8", VA = "0x3CF26C8")]
		private void RefreshCollectionAndPageText()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x3CF2850", Offset = "0x3CEE850", VA = "0x3CF2850")]
		private void AssignCurrentImages()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x3CF2C18", Offset = "0x3CEEC18", VA = "0x3CF2C18")]
		public AllIn1VfxTextureDemoManager()
		{
		}
	}
}
