using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A37")]
	public class MysteryAdventureRuinsPanelView : MonoBehaviour
	{
		[Token(Token = "0x4004BC7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _headerText;

		[Token(Token = "0x4004BC8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _cardImage;

		[Token(Token = "0x4004BC9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _descriptionRoot;

		[Token(Token = "0x4004BCA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _descriptionText;

		[Token(Token = "0x4004BCB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _rewardPreviewRoot;

		[Token(Token = "0x4004BCC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _rewardPreviewIcon;

		[Token(Token = "0x4004BCD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI _rewardPreviewText;

		[Token(Token = "0x4004BCE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _optionsRoot;

		[Token(Token = "0x4004BCF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _optionButtonTemplate;

		[Token(Token = "0x4004BD0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _panelBg;

		[Token(Token = "0x4004BD1")]
		[FieldOffset(Offset = "0x70")]
		private readonly List<Button> _optionButtons;

		[Token(Token = "0x1700092F")]
		public TextMeshProUGUI HeaderText
		{
			[Token(Token = "0x6003CFA")]
			[Address(RVA = "0x4155150", Offset = "0x4151150", VA = "0x4155150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000930")]
		public Image CardImage
		{
			[Token(Token = "0x6003CFB")]
			[Address(RVA = "0x4155158", Offset = "0x4151158", VA = "0x4155158")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000931")]
		public GameObject DescriptionRoot
		{
			[Token(Token = "0x6003CFC")]
			[Address(RVA = "0x4155160", Offset = "0x4151160", VA = "0x4155160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000932")]
		public TextMeshProUGUI DescriptionText
		{
			[Token(Token = "0x6003CFD")]
			[Address(RVA = "0x4155168", Offset = "0x4151168", VA = "0x4155168")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000933")]
		public GameObject RewardPreviewRoot
		{
			[Token(Token = "0x6003CFE")]
			[Address(RVA = "0x4155170", Offset = "0x4151170", VA = "0x4155170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000934")]
		public Image RewardPreviewIcon
		{
			[Token(Token = "0x6003CFF")]
			[Address(RVA = "0x4155178", Offset = "0x4151178", VA = "0x4155178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000935")]
		public TextMeshProUGUI RewardPreviewText
		{
			[Token(Token = "0x6003D00")]
			[Address(RVA = "0x4155180", Offset = "0x4151180", VA = "0x4155180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000936")]
		public RectTransform OptionsRoot
		{
			[Token(Token = "0x6003D01")]
			[Address(RVA = "0x4155188", Offset = "0x4151188", VA = "0x4155188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000937")]
		public Button OptionButtonTemplate
		{
			[Token(Token = "0x6003D02")]
			[Address(RVA = "0x4155190", Offset = "0x4151190", VA = "0x4155190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003D03")]
		[Address(RVA = "0x4155198", Offset = "0x4151198", VA = "0x4155198")]
		public void ApplyShowAnimationSpeed(float speedMultiplier)
		{
		}

		[Token(Token = "0x6003D04")]
		[Address(RVA = "0x41551C0", Offset = "0x41511C0", VA = "0x41551C0")]
		public void ResolveReferences()
		{
		}

		[Token(Token = "0x6003D05")]
		[Address(RVA = "0x4155804", Offset = "0x4151804", VA = "0x4155804")]
		public void ClearOptionButtons()
		{
		}

		[Token(Token = "0x6003D06")]
		[Address(RVA = "0x4155954", Offset = "0x4151954", VA = "0x4155954")]
		public void BuildOptionButtons(IReadOnlyList<string> optionTexts, Action<int> onOptionClicked)
		{
		}

		[Token(Token = "0x6003D07")]
		[Address(RVA = "0x4155DD0", Offset = "0x4151DD0", VA = "0x4155DD0")]
		public void BindHeaderTextRef(TextMeshProUGUI text)
		{
		}

		[Token(Token = "0x6003D08")]
		[Address(RVA = "0x4155DD8", Offset = "0x4151DD8", VA = "0x4155DD8")]
		public void BindCardImageRef(Image image)
		{
		}

		[Token(Token = "0x6003D09")]
		[Address(RVA = "0x4155DE0", Offset = "0x4151DE0", VA = "0x4155DE0")]
		public void BindDescriptionRootRef(GameObject root)
		{
		}

		[Token(Token = "0x6003D0A")]
		[Address(RVA = "0x4155DE8", Offset = "0x4151DE8", VA = "0x4155DE8")]
		public void BindDescriptionTextRef(TextMeshProUGUI text)
		{
		}

		[Token(Token = "0x6003D0B")]
		[Address(RVA = "0x4155DF0", Offset = "0x4151DF0", VA = "0x4155DF0")]
		public void BindRewardPreviewRootRef(GameObject root)
		{
		}

		[Token(Token = "0x6003D0C")]
		[Address(RVA = "0x4155DF8", Offset = "0x4151DF8", VA = "0x4155DF8")]
		public void BindRewardPreviewIconRef(Image image)
		{
		}

		[Token(Token = "0x6003D0D")]
		[Address(RVA = "0x4155E00", Offset = "0x4151E00", VA = "0x4155E00")]
		public void BindRewardPreviewTextRef(TextMeshProUGUI text)
		{
		}

		[Token(Token = "0x6003D0E")]
		[Address(RVA = "0x4155E08", Offset = "0x4151E08", VA = "0x4155E08")]
		public void BindOptionsRootRef(RectTransform root)
		{
		}

		[Token(Token = "0x6003D0F")]
		[Address(RVA = "0x4155E10", Offset = "0x4151E10", VA = "0x4155E10")]
		public void BindOptionButtonTemplateRef(Button button)
		{
		}

		[Token(Token = "0x6003D10")]
		[Address(RVA = "0x4155E18", Offset = "0x4151E18", VA = "0x4155E18")]
		public void BindPanelBgRef(RectTransform panelBg)
		{
		}

		[Token(Token = "0x6003D11")]
		[Address(RVA = "0x4155E20", Offset = "0x4151E20", VA = "0x4155E20")]
		public void ApplyDescriptionLayout(bool hasRewardPreview)
		{
		}

		[Token(Token = "0x6003D12")]
		[Address(RVA = "0x4155ECC", Offset = "0x4151ECC", VA = "0x4155ECC")]
		public MysteryAdventureRuinsPanelView()
		{
		}
	}
}
