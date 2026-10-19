using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200067A")]
	public class WorldCupRulesPanelView : ScaleTweenPanelViewBase
	{
		[Token(Token = "0x4003472")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _titleText;

		[Token(Token = "0x4003473")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _contentText;

		[Token(Token = "0x4003474")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _closeButton;

		[Token(Token = "0x4003475")]
		[FieldOffset(Offset = "0x40")]
		private Action _onClose;

		[Token(Token = "0x6002239")]
		[Address(RVA = "0x3F2ECAC", Offset = "0x3F2ACAC", VA = "0x3F2ECAC")]
		public void Initialize(Action onClose)
		{
		}

		[Token(Token = "0x600223A")]
		[Address(RVA = "0x3F326D4", Offset = "0x3F2E6D4", VA = "0x3F326D4")]
		public void RefreshContent()
		{
		}

		[Token(Token = "0x600223B")]
		[Address(RVA = "0x3F32770", Offset = "0x3F2E770", VA = "0x3F32770", Slot = "9")]
		protected override UniTask OnBeforeShowAsync()
		{
			return default;
		}

		[Token(Token = "0x600223C")]
		[Address(RVA = "0x3F325E4", Offset = "0x3F2E5E4", VA = "0x3F325E4")]
		private void BindCloseButton()
		{
		}

		[Token(Token = "0x600223D")]
		[Address(RVA = "0x3F327D4", Offset = "0x3F2E7D4", VA = "0x3F327D4")]
		public WorldCupRulesPanelView()
		{
		}
	}
}
