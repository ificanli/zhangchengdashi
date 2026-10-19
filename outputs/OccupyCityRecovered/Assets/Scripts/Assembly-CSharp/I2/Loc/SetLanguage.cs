using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000DC4")]
	[AddComponentMenu("I2/Localization/SetLanguage Button")]
	public class SetLanguage : MonoBehaviour
	{
		[Token(Token = "0x40060C9")]
		[FieldOffset(Offset = "0x20")]
		public string _Language;

		[Token(Token = "0x6005539")]
		[Address(RVA = "0x432FE44", Offset = "0x432BE44", VA = "0x432FE44")]
		public void OnClick()
		{
		}

		[Token(Token = "0x600553A")]
		[Address(RVA = "0x432FED8", Offset = "0x432BED8", VA = "0x432FED8")]
		public void Awake()
		{
		}

		[Token(Token = "0x600553B")]
		[Address(RVA = "0x432FE48", Offset = "0x432BE48", VA = "0x432FE48")]
		public void ApplyLanguage()
		{
		}

		[Token(Token = "0x600553C")]
		[Address(RVA = "0x432FEDC", Offset = "0x432BEDC", VA = "0x432FEDC")]
		public SetLanguage()
		{
		}
	}
}
