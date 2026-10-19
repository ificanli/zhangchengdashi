using Il2CppDummyDll;
using UnityEngine;

namespace L_Tools.FakeMediation
{
	[Token(Token = "0x2000FCE")]
	internal class FakeMrecAd : FakeAd
	{
		[Token(Token = "0x4006BE7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _transform;

		[Token(Token = "0x6005ECB")]
		[Address(RVA = "0x43FCA48", Offset = "0x43F8A48", VA = "0x43FCA48")]
		public void Setup(float x, float y)
		{
		}

		[Token(Token = "0x6005ECC")]
		[Address(RVA = "0x43FECE8", Offset = "0x43FACE8", VA = "0x43FECE8")]
		public FakeMrecAd()
		{
		}
	}
}
