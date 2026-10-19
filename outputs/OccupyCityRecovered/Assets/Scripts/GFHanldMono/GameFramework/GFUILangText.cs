using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace GameFramework
{
	[Token(Token = "0x2000012")]
	public class GFUILangText : MonoBehaviour, IUILang
	{
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string key;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x28")]
		private Text textTarget;

		[Token(Token = "0x1700000D")]
		public string Key
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x7069748", Offset = "0x7065748", VA = "0x7069748", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x7069750", Offset = "0x7065750", VA = "0x7069750", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public string Value
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x7069908", Offset = "0x7065908", VA = "0x7069908", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x7069844", Offset = "0x7065844", VA = "0x7069844", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x70699B4", Offset = "0x70659B4", VA = "0x70699B4", Slot = "8")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x7069A1C", Offset = "0x7065A1C", VA = "0x7069A1C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x7069ACC", Offset = "0x7065ACC", VA = "0x7069ACC")]
		public GFUILangText()
		{
		}
	}
}
