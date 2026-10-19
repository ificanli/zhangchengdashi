using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000918")]
	public class HpBarUIComponents : UIPanel, IUIPanelComponents
	{
		[Token(Token = "0x4004460")]
		[FieldOffset(Offset = "0x40")]
		private Image _progressImg;

		[Token(Token = "0x4004461")]
		[FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _hpTextText;

		[Token(Token = "0x17000749")]
		protected Image ProgressImg
		{
			[Token(Token = "0x6003494")]
			[Address(RVA = "0x40AAB60", Offset = "0x40A6B60", VA = "0x40AAB60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700074A")]
		protected TextMeshProUGUI HpTextText
		{
			[Token(Token = "0x6003495")]
			[Address(RVA = "0x40AAA98", Offset = "0x40A6A98", VA = "0x40AAA98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003496")]
		[Address(RVA = "0x40AAD64", Offset = "0x40A6D64", VA = "0x40AAD64", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003497")]
		[Address(RVA = "0x40AAD5C", Offset = "0x40A6D5C", VA = "0x40AAD5C")]
		public HpBarUIComponents()
		{
		}
	}
}
