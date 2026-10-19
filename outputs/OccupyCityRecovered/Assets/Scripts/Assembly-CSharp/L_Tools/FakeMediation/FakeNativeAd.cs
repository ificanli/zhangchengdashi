using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace L_Tools.FakeMediation
{
	[Token(Token = "0x2000FCF")]
	internal class FakeNativeAd : FakeAd
	{
		[Token(Token = "0x4006BE8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _image;

		[Token(Token = "0x4006BE9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _squarreImage;

		[Token(Token = "0x4006BEA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Sprite _rectangleImage;

		[Token(Token = "0x4006BEB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _transform;

		[Token(Token = "0x6005ECD")]
		[Address(RVA = "0x43FC8D4", Offset = "0x43F88D4", VA = "0x43FC8D4")]
		public void Setup(string layoutName, float x, float y, float width, float height)
		{
		}

		[Token(Token = "0x6005ECE")]
		[Address(RVA = "0x43FECF0", Offset = "0x43FACF0", VA = "0x43FECF0")]
		public FakeNativeAd()
		{
		}
	}
}
