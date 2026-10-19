using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommonGameModule.Debugger.UGUI.GMWindow;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000066")]
	public class GMWindowSlider : IGMWindowItem
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject _rootObj;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Text _text;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Slider _slider;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _description;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _isFormat;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Action<float> _callback;

		[Token(Token = "0x1700005D")]
		public GameObject gameObject
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x4684338", Offset = "0x4680338", VA = "0x4684338", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public bool IsDirty
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x4684340", Offset = "0x4680340", VA = "0x4684340", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x4684348", Offset = "0x4680348", VA = "0x4684348", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public string Name
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x4684354", Offset = "0x4680354", VA = "0x4684354", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x468435C", Offset = "0x468035C", VA = "0x468435C", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public string[] Tags
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x4684364", Offset = "0x4680364", VA = "0x4684364", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x468436C", Offset = "0x468036C", VA = "0x468436C", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public float Value
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x4684374", Offset = "0x4680374", VA = "0x4684374")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x4684398", Offset = "0x4680398", VA = "0x4684398")]
		public GMWindowSlider(string description, float defaultValue, Action<float> callback, GameObject rootObj, [Optional][DefaultParameterValue(false)] bool wholeNumbers, [Optional] Vector2 range)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x4684754", Offset = "0x4680754", VA = "0x4684754")]
		private void OnValueChanged(float value)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x4684780", Offset = "0x4680780", VA = "0x4684780", Slot = "12")]
		public bool EqualsCallback(object callback)
		{
			return default;
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x468469C", Offset = "0x468069C", VA = "0x468469C", Slot = "11")]
		public void RefreshView()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x4684798", Offset = "0x4680798", VA = "0x4684798", Slot = "13")]
		public void SetFontSize(int size)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x46847B4", Offset = "0x46807B4", VA = "0x46847B4")]
		public void SetValue(float value)
		{
		}
	}
}
