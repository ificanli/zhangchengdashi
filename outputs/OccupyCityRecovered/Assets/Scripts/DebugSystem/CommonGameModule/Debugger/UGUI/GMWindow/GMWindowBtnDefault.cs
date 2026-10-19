using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI.GMWindow
{
	[Token(Token = "0x2000094")]
	public class GMWindowBtnDefault : IGMWindowItem
	{
		[Token(Token = "0x400028A")]
		private const float CLICK_INTERVAL = 0.1f;

		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x28")]
		protected Button m_Btn;

		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x30")]
		protected Text m_Text;

		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x38")]
		protected Action<string> m_Callback;

		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x40")]
		private float m_LastClickTime;

		[Token(Token = "0x17000090")]
		public GameObject gameObject
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x4692BE4", Offset = "0x468EBE4", VA = "0x4692BE4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
		public bool IsDirty
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x4692C00", Offset = "0x468EC00", VA = "0x4692C00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x4692C08", Offset = "0x468EC08", VA = "0x4692C08", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public string Name
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x4692C14", Offset = "0x468EC14", VA = "0x4692C14", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x4692C1C", Offset = "0x468EC1C", VA = "0x4692C1C", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public string[] Tags
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x4692C24", Offset = "0x468EC24", VA = "0x4692C24", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x4692C2C", Offset = "0x468EC2C", VA = "0x4692C2C", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x46926F8", Offset = "0x468E6F8", VA = "0x46926F8")]
		public GMWindowBtnDefault(string text, Action<string> callback, GameObject btnObj)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x4692C34", Offset = "0x468EC34", VA = "0x4692C34", Slot = "11")]
		public void RefreshView()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x4692C68", Offset = "0x468EC68", VA = "0x4692C68", Slot = "12")]
		public bool EqualsCallback(object callback)
		{
			return default;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x4692C88", Offset = "0x468EC88", VA = "0x4692C88")]
		private void OnClick()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x4692DF0", Offset = "0x468EDF0", VA = "0x4692DF0", Slot = "13")]
		public void SetFontSize(int size)
		{
		}
	}
}
