using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace L_Tools.FakeMediation
{
	[Token(Token = "0x2000FD0")]
	internal class FakeRewardedVideoAd : FakeClosableAd
	{
		[Token(Token = "0x4006BEC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[FormerlySerializedAs("_closeWithRewardButton")]
		private Button closeWithRewardButton;

		[Token(Token = "0x4006BED")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[FormerlySerializedAs("_closeWithoutRewardButton")]
		private Button closeWithoutRewardButton;

		[Token(Token = "0x4006BEE")]
		[FieldOffset(Offset = "0x50")]
		public Action onCloseWithReward;

		[Token(Token = "0x4006BEF")]
		[FieldOffset(Offset = "0x58")]
		public Action onCloseWithoutReward;

		[Token(Token = "0x6005ECF")]
		[Address(RVA = "0x43FECF8", Offset = "0x43FACF8", VA = "0x43FECF8")]
		protected new void Awake()
		{
		}

		[Token(Token = "0x6005ED0")]
		[Address(RVA = "0x43FEE5C", Offset = "0x43FAE5C", VA = "0x43FEE5C")]
		public FakeRewardedVideoAd()
		{
		}
	}
}
