using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI.GMWindow
{
	[Token(Token = "0x2000095")]
	public class GMWindowToggleDefault : IGMWindowItem
	{
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x28")]
		protected Toggle m_Toggle;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x30")]
		protected Text m_Text;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x38")]
		protected Action<bool> m_Callback;

		[Token(Token = "0x17000094")]
		public GameObject gameObject
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x4692E0C", Offset = "0x468EE0C", VA = "0x4692E0C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public bool IsDirty
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x4692E28", Offset = "0x468EE28", VA = "0x4692E28", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x4692E30", Offset = "0x468EE30", VA = "0x4692E30", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public string Name
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x4692E3C", Offset = "0x468EE3C", VA = "0x4692E3C", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x4692E44", Offset = "0x468EE44", VA = "0x4692E44", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public string[] Tags
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x4692E4C", Offset = "0x468EE4C", VA = "0x4692E4C", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x4692E54", Offset = "0x468EE54", VA = "0x4692E54", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public bool IsOn
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x4692E5C", Offset = "0x468EE5C", VA = "0x4692E5C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x4692A90", Offset = "0x468EA90", VA = "0x4692A90")]
		public GMWindowToggleDefault(string text, bool isOn, Action<bool> callback, GameObject toggleObj)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x4692EAC", Offset = "0x468EEAC", VA = "0x4692EAC", Slot = "12")]
		public bool EqualsCallback(object callback)
		{
			return default;
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x4692E78", Offset = "0x468EE78", VA = "0x4692E78", Slot = "11")]
		public void RefreshView()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x4692ECC", Offset = "0x468EECC", VA = "0x4692ECC")]
		private void OnValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x469301C", Offset = "0x468F01C", VA = "0x469301C", Slot = "13")]
		public void SetFontSize(int size)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x4693038", Offset = "0x468F038", VA = "0x4693038")]
		public void SetIsOn(bool isOn)
		{
		}
	}
}
