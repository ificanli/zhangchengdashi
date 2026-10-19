using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000693")]
	public class TabButtonGroup : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000694")]
		public class TabButton
		{
			[Token(Token = "0x400350C")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("点击事件按钮组件")]
			[Header("═══════ 组件引用 ═══════")]
			[Space(5f)]
			public SubMetaSwitchBtn switchBtn;

			[Token(Token = "0x400350D")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("背景Image组件")]
			public Image bgImage;

			[Token(Token = "0x400350E")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("图标Image组件")]
			public Image iconImage;

			[Token(Token = "0x400350F")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("选中时显示的图标")]
			[Space(5f)]
			public Sprite activeIcon;

			[Token(Token = "0x4003510")]
			[FieldOffset(Offset = "0x30")]
			[Tooltip("未选中时显示的图标")]
			public Sprite inactiveIcon;

			[Token(Token = "0x60022DA")]
			[Address(RVA = "0x3F3EF8C", Offset = "0x3F3AF8C", VA = "0x3F3EF8C")]
			public TabButton()
			{
			}
		}

		[Token(Token = "0x4003506")]
		[FieldOffset(Offset = "0x20")]
		[Header("══════════ 通用背景资源 ══════════")]
		[Tooltip("所有按钮选中时的通用背景")]
		[SerializeField]
		private Sprite _activeBgSprite;

		[Token(Token = "0x4003507")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("所有按钮未选中时的通用背景")]
		[SerializeField]
		private Sprite _inactiveBgSprite;

		[Token(Token = "0x4003508")]
		[FieldOffset(Offset = "0x30")]
		[Space(10f)]
		[Header("══════════ Tab按钮配置 ══════════")]
		[SerializeField]
		private List<TabButton> _tabButtons;

		[Token(Token = "0x4003509")]
		[FieldOffset(Offset = "0x38")]
		[Space(10f)]
		[Header("══════════ 设置 ══════════")]
		[Tooltip("默认选中的Tab索引（从0开始）")]
		[SerializeField]
		private int _defaultIndex;

		[Token(Token = "0x400350A")]
		[FieldOffset(Offset = "0x3C")]
		private int _currentIndex;

		[Token(Token = "0x400350B")]
		[FieldOffset(Offset = "0x40")]
		[CompilerGenerated]
		private Action<int> m_OnTabChanged;

		[Token(Token = "0x170001EA")]
		public int CurrentIndex
		{
			[Token(Token = "0x60022D0")]
			[Address(RVA = "0x3F3E95C", Offset = "0x3F3A95C", VA = "0x3F3E95C")]
			get
			{
				return _currentIndex;
			}
		}

		[Token(Token = "0x14000008")]
		public event Action<int> OnTabChanged
		{
			[Token(Token = "0x60022D1")]
			[Address(RVA = "0x3F3E964", Offset = "0x3F3A964", VA = "0x3F3E964")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60022D2")]
			[Address(RVA = "0x3F3EA14", Offset = "0x3F3AA14", VA = "0x3F3EA14")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60022D3")]
		[Address(RVA = "0x3F3EAC4", Offset = "0x3F3AAC4", VA = "0x3F3EAC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60022D4")]
		[Address(RVA = "0x3F3EC44", Offset = "0x3F3AC44", VA = "0x3F3EC44")]
		private void Start()
		{
		}

		[Token(Token = "0x60022D5")]
		[Address(RVA = "0x3F3EAC8", Offset = "0x3F3AAC8", VA = "0x3F3EAC8")]
		private void RegisterButtonEvents()
		{
		}

		[Token(Token = "0x60022D6")]
		[Address(RVA = "0x3F3ED20", Offset = "0x3F3AD20", VA = "0x3F3ED20")]
		public void SelectTab(int index)
		{
		}

		[Token(Token = "0x60022D7")]
		[Address(RVA = "0x3F3ECAC", Offset = "0x3F3ACAC", VA = "0x3F3ECAC")]
		public void RefreshWithoutNotify(int index)
		{
		}

		[Token(Token = "0x60022D8")]
		[Address(RVA = "0x3F3EDB4", Offset = "0x3F3ADB4", VA = "0x3F3EDB4")]
		private void UpdateButtonStates()
		{
		}

		[Token(Token = "0x60022D9")]
		[Address(RVA = "0x3F3EF08", Offset = "0x3F3AF08", VA = "0x3F3EF08")]
		public TabButtonGroup()
		{
		}
	}
}
