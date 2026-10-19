using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace GameFramework
{
	[Token(Token = "0x2000013")]
	[HelpURL("https://ewe8txd9jt.feishu.cn/wiki/O4m1wFGgXiZqihkepJzcuJYOnBb")]
	[RequireComponent(typeof(Button))]
	[AddComponentMenu("GF/IAP Button")]
	public class IAPButton : MonoBehaviour
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int PublicAudioId;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_GameKey;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_IsActive;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int m_AudioId;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text m_PriceText;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string m_DefaultPrice;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button m_Button;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string m_productId;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string m_title;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string m_des;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string m_price;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string m_currency;

		[Token(Token = "0x1700000F")]
		public string Title
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x7069AD4", Offset = "0x7065AD4", VA = "0x7069AD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public string Des
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x7069ADC", Offset = "0x7065ADC", VA = "0x7069ADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public string Price
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x7069AE4", Offset = "0x7065AE4", VA = "0x7069AE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public string Currency
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x7069AEC", Offset = "0x7065AEC", VA = "0x7069AEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x7069AF4", Offset = "0x7065AF4", VA = "0x7069AF4")]
		private void Start()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x7069E2C", Offset = "0x7065E2C", VA = "0x7069E2C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x7069ECC", Offset = "0x7065ECC", VA = "0x7069ECC")]
		public void ResetIapBtnData(string gameKey, [Optional] Text priceText, int audioId = 0, string defaultPrice = "")
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x7069C84", Offset = "0x7065C84", VA = "0x7069C84")]
		private void AddClickListener()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x706A0F4", Offset = "0x70660F4", VA = "0x706A0F4")]
		private void OnClickBtn()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x7069B84", Offset = "0x7065B84", VA = "0x7069B84")]
		private void GetProductInfo()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x706A208", Offset = "0x7066208", VA = "0x706A208")]
		public IAPButton()
		{
		}
	}
}
