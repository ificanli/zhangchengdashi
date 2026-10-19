using System;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000B78")]
	public class SpecialSummonCustomPropItem : MonoBehaviour
	{
		[Token(Token = "0x400539C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private NewArtifactItem newArtifactItem;

		[Token(Token = "0x400539D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject curSelected;

		[Token(Token = "0x400539E")]
		[FieldOffset(Offset = "0x30")]
		private int _orderId;

		[Token(Token = "0x400539F")]
		[FieldOffset(Offset = "0x38")]
		private string _propId;

		[Token(Token = "0x40053A0")]
		[FieldOffset(Offset = "0x40")]
		private UserPropData _userPropData;

		[Token(Token = "0x40053A1")]
		[FieldOffset(Offset = "0x48")]
		private Action<int> _onSelect;

		[Token(Token = "0x600463D")]
		[Address(RVA = "0x4212DDC", Offset = "0x420EDDC", VA = "0x4212DDC")]
		public void Setup(int orderId, string propId, Action<int> onSelect)
		{
		}

		[Token(Token = "0x600463E")]
		[Address(RVA = "0x4212F90", Offset = "0x420EF90", VA = "0x4212F90")]
		public void RefreshView(int displayOrderId, int pendingOrderId, bool playSwitchAnim)
		{
		}

		[Token(Token = "0x600463F")]
		[Address(RVA = "0x4212E00", Offset = "0x420EE00", VA = "0x4212E00")]
		private void RefreshPropData()
		{
		}

		[Token(Token = "0x6004640")]
		[Address(RVA = "0x4212E70", Offset = "0x420EE70", VA = "0x4212E70")]
		private void BindSelectClick()
		{
		}

		[Token(Token = "0x6004641")]
		[Address(RVA = "0x421309C", Offset = "0x420F09C", VA = "0x421309C")]
		private void OnSelectClicked()
		{
		}

		[Token(Token = "0x6004642")]
		[Address(RVA = "0x42130BC", Offset = "0x420F0BC", VA = "0x42130BC")]
		public SpecialSummonCustomPropItem()
		{
		}
	}
}
