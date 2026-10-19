using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20009B5")]
	public class MysteryAdventureBoardCellView : MonoBehaviour
	{
		[Token(Token = "0x400486A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _cellId;

		[Token(Token = "0x400486B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _frame;

		[Token(Token = "0x400486C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		[Token(Token = "0x400486D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _label;

		[Token(Token = "0x170008D8")]
		public int CellId
		{
			[Token(Token = "0x60039B6")]
			[Address(RVA = "0x410799C", Offset = "0x410399C", VA = "0x410799C")]
			get
			{
				return _cellId;
			}
		}

		[Token(Token = "0x170008D9")]
		public RectTransform CellRect
		{
			[Token(Token = "0x60039B7")]
			[Address(RVA = "0x41079A4", Offset = "0x41039A4", VA = "0x41079A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008DA")]
		public Image Frame
		{
			[Token(Token = "0x60039B8")]
			[Address(RVA = "0x4107A04", Offset = "0x4103A04", VA = "0x4107A04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008DB")]
		public Image Icon
		{
			[Token(Token = "0x60039B9")]
			[Address(RVA = "0x4107A0C", Offset = "0x4103A0C", VA = "0x4107A0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008DC")]
		public TextMeshProUGUI Label
		{
			[Token(Token = "0x60039BA")]
			[Address(RVA = "0x4107A14", Offset = "0x4103A14", VA = "0x4107A14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60039BB")]
		[Address(RVA = "0x4107A1C", Offset = "0x4103A1C", VA = "0x4107A1C")]
		public void BindReferences(int cellId, Image frame, Image icon, TextMeshProUGUI label)
		{
		}

		[Token(Token = "0x60039BC")]
		[Address(RVA = "0x4107A2C", Offset = "0x4103A2C", VA = "0x4107A2C")]
		public MysteryAdventureBoardCellView()
		{
		}
	}
}
