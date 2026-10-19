using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace L_Tools.FakeMediation
{
	[Token(Token = "0x2000FC9")]
	internal class FakeInterstitialAd : FakeClosableAd
	{
		[Token(Token = "0x4006BBF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[FormerlySerializedAs("_closeButton")]
		private Button closeButton;

		[Token(Token = "0x6005E68")]
		[Address(RVA = "0x43FC1F8", Offset = "0x43F81F8", VA = "0x43FC1F8")]
		protected new void Awake()
		{
		}

		[Token(Token = "0x6005E69")]
		[Address(RVA = "0x43FC2D4", Offset = "0x43F82D4", VA = "0x43FC2D4")]
		public FakeInterstitialAd()
		{
		}
	}
}
