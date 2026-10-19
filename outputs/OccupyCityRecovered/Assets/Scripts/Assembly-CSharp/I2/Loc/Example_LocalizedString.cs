using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000D60")]
	public class Example_LocalizedString : MonoBehaviour
	{
		[Token(Token = "0x4005F37")]
		[FieldOffset(Offset = "0x20")]
		public LocalizedString _MyLocalizedString;

		[Token(Token = "0x4005F38")]
		[FieldOffset(Offset = "0x38")]
		public string _NormalString;

		[Token(Token = "0x4005F39")]
		[FieldOffset(Offset = "0x40")]
		[TermsPopup("")]
		public string _StringWithTermPopup;

		[Token(Token = "0x60052B8")]
		[Address(RVA = "0x43043E0", Offset = "0x43003E0", VA = "0x43043E0")]
		public void Start()
		{
		}

		[Token(Token = "0x60052B9")]
		[Address(RVA = "0x4304700", Offset = "0x4300700", VA = "0x4304700")]
		public Example_LocalizedString()
		{
		}
	}
}
