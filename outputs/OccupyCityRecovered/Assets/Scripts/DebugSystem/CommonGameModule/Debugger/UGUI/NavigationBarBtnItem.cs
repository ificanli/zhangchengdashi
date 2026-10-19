using System;
using GameFramework;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000071")]
	public class NavigationBarBtnItem : IReference
	{
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x10")]
		private Button m_Btn;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x18")]
		private Text m_Text;

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x20")]
		private string m_FullPath;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x28")]
		private string m_Name;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x30")]
		private bool m_IsSelect;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x34")]
		private int m_MaxCount;

		[Token(Token = "0x400021E")]
		private const int SMALL_SIZE_COUNT = 6;

		[Token(Token = "0x400021F")]
		private const int FONT_SIZE_BIG = 15;

		[Token(Token = "0x4000220")]
		private const int FONT_SIZE_SMALL = 10;

		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x38")]
		private Action<string> m_ClickAction;

		[Token(Token = "0x17000077")]
		private static Color SelectColor
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x4688668", Offset = "0x4684668", VA = "0x4688668")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000078")]
		private static Color NormalColor
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x4688694", Offset = "0x4684694", VA = "0x4688694")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000079")]
		private bool IsSelect
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x46886C0", Offset = "0x46846C0", VA = "0x46886C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x46886C8", Offset = "0x46846C8", VA = "0x46886C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public string FullPath
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x4688708", Offset = "0x4684708", VA = "0x4688708")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x4688710", Offset = "0x4684710", VA = "0x4688710")]
		public void Init(string path, string name, bool isSelect, Transform parent, Button prefab, int maxCount, Action<string> clickAction)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x46889EC", Offset = "0x46849EC", VA = "0x46889EC", Slot = "4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x4688A18", Offset = "0x4684A18", VA = "0x4688A18")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x4688A40", Offset = "0x4684A40", VA = "0x4688A40")]
		public void RefreshItemSelectName(string name)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x4688AF8", Offset = "0x4684AF8", VA = "0x4688AF8")]
		public void RefreshColor()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x4688B34", Offset = "0x4684B34", VA = "0x4688B34")]
		public NavigationBarBtnItem()
		{
		}
	}
}
