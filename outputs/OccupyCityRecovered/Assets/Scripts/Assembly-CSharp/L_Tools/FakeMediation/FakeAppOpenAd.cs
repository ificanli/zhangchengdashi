using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace L_Tools.FakeMediation
{
	[Token(Token = "0x2000FC6")]
	internal class FakeAppOpenAd : FakeClosableAd
	{
		[Token(Token = "0x4006BBD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button closeButton;

		[Token(Token = "0x6005E62")]
		[Address(RVA = "0x43FC070", Offset = "0x43F8070", VA = "0x43FC070")]
		protected new void Awake()
		{
		}

		[Token(Token = "0x6005E63")]
		[Address(RVA = "0x43FC14C", Offset = "0x43F814C", VA = "0x43FC14C")]
		public FakeAppOpenAd()
		{
		}
	}
}
