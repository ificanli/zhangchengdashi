using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace BrainFailProductions.PolyFew.AsImpL
{
	[Token(Token = "0x2000D0E")]
	[RequireComponent(typeof(ObjectImporter))]
	public class ObjectImporterUI : MonoBehaviour
	{
		[Token(Token = "0x4005D6F")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Text for activity messages")]
		public Text progressText;

		[Token(Token = "0x4005D70")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Slider for the overall progress")]
		public Slider progressSlider;

		[Token(Token = "0x4005D71")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Panel with the Image Type set to Filled")]
		public Image progressImage;

		[Token(Token = "0x4005D72")]
		[FieldOffset(Offset = "0x38")]
		private ObjectImporter objImporter;

		[Token(Token = "0x600513D")]
		[Address(RVA = "0x42DA938", Offset = "0x42D6938", VA = "0x42DA938")]
		private void Awake()
		{
		}

		[Token(Token = "0x600513E")]
		[Address(RVA = "0x42DAA90", Offset = "0x42D6A90", VA = "0x42DAA90")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600513F")]
		[Address(RVA = "0x42DAB60", Offset = "0x42D6B60", VA = "0x42DAB60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005140")]
		[Address(RVA = "0x42DAC30", Offset = "0x42D6C30", VA = "0x42DAC30")]
		private void Update()
		{
		}

		[Token(Token = "0x6005141")]
		[Address(RVA = "0x42DB378", Offset = "0x42D7378", VA = "0x42DB378")]
		private void OnImportStart()
		{
		}

		[Token(Token = "0x6005142")]
		[Address(RVA = "0x42DB210", Offset = "0x42D7210", VA = "0x42DB210")]
		private void OnImportComplete()
		{
		}

		[Token(Token = "0x6005143")]
		[Address(RVA = "0x42DB4DC", Offset = "0x42D74DC", VA = "0x42DB4DC")]
		public ObjectImporterUI()
		{
		}
	}
}
