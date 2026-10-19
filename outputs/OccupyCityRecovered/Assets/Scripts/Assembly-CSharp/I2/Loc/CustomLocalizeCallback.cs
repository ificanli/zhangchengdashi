using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace I2.Loc
{
	[Token(Token = "0x2000DAF")]
	[AddComponentMenu("I2/Localization/I2 Localize Callback")]
	public class CustomLocalizeCallback : MonoBehaviour
	{
		[Token(Token = "0x4006056")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent _OnLocalize;

		[Token(Token = "0x60054EC")]
		[Address(RVA = "0x432A548", Offset = "0x4326548", VA = "0x432A548")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60054ED")]
		[Address(RVA = "0x432A604", Offset = "0x4326604", VA = "0x432A604")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60054EE")]
		[Address(RVA = "0x432A6A0", Offset = "0x43266A0", VA = "0x432A6A0")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x60054EF")]
		[Address(RVA = "0x432A6BC", Offset = "0x43266BC", VA = "0x432A6BC")]
		public CustomLocalizeCallback()
		{
		}
	}
}
