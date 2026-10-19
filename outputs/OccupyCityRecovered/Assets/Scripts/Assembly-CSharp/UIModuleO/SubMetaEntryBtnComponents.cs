using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B92")]
	public class SubMetaEntryBtnComponents : UIPanel, IUIPanelComponents
	{
		[Token(Token = "0x4005439")]
		[FieldOffset(Offset = "0x40")]
		private Image _subMetaEntryBtnImg;

		[Token(Token = "0x400543A")]
		[FieldOffset(Offset = "0x48")]
		protected Button SubMetaEntryBtnBtn;

		[Token(Token = "0x400543B")]
		[FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textText;

		[Token(Token = "0x17000BFF")]
		protected Image SubMetaEntryBtnImg
		{
			[Token(Token = "0x6004700")]
			[Address(RVA = "0x421DD9C", Offset = "0x4219D9C", VA = "0x421DD9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C00")]
		protected TextMeshProUGUI TextText
		{
			[Token(Token = "0x6004701")]
			[Address(RVA = "0x421DCD4", Offset = "0x4219CD4", VA = "0x421DCD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004702")]
		[Address(RVA = "0x421DE4C", Offset = "0x4219E4C", VA = "0x421DE4C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004703")]
		[Address(RVA = "0x421D8D4", Offset = "0x42198D4", VA = "0x421D8D4")]
		public SubMetaEntryBtnComponents()
		{
		}
	}
}
