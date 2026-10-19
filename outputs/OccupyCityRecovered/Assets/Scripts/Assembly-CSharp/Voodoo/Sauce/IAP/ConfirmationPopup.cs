using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.IAP
{
	[Token(Token = "0x2000F7B")]
	public class ConfirmationPopup : MonoBehaviour
	{
		[Token(Token = "0x4006A96")]
		private const string PREFAB_NAME = "ConfirmationPopupCanvas";

		[Token(Token = "0x4006A97")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI title;

		[Token(Token = "0x4006A98")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI message;

		[Token(Token = "0x4006A99")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button cancelButton;

		[Token(Token = "0x4006A9A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button confirmButton;

		[Token(Token = "0x4006A9B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button altButton;

		[Token(Token = "0x6005CCA")]
		[Address(RVA = "0x43B32C4", Offset = "0x43AF2C4", VA = "0x43B32C4")]
		public static void Show(ConfirmationPopupConfig config)
		{
		}

		[Token(Token = "0x6005CCB")]
		[Address(RVA = "0x43B355C", Offset = "0x43AF55C", VA = "0x43B355C")]
		public ConfirmationPopup()
		{
		}
	}
}
