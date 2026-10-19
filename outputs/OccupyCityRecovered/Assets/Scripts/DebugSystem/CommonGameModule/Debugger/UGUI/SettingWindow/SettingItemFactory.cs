using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommonGameModule.Debugger.UGUI.GMWindow;
using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.UGUI.SettingWindow
{
	[Token(Token = "0x2000093")]
	public class SettingItemFactory
	{
		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[UIPath(UIPathType.Resources, "GMWindowItem/GMBtnPrefab")]
		private GameObject _btnPrefab;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[UIPath(UIPathType.Resources, "GMWindowItem/SliderOneLine")]
		private GameObject _sliderOneLinePrefab;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[UIPath(UIPathType.Resources, "GMWindowItem/SliderTwoLine")]
		private GameObject _sliderTwoLinePrefab;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[UIPath(UIPathType.Resources, "GMWindowItem/GMTogglePrefab")]
		private GameObject _togglePrefab;

		[Token(Token = "0x1700008F")]
		public List<IGMWindowItem> Items
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x4692390", Offset = "0x468E390", VA = "0x4692390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x4692398", Offset = "0x468E398", VA = "0x4692398")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x46923A0", Offset = "0x468E3A0", VA = "0x46923A0")]
		public SettingItemFactory(Transform root)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x469245C", Offset = "0x468E45C", VA = "0x469245C")]
		private GameObject CreateItem(SettingItemStyle style, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x46925E4", Offset = "0x468E5E4", VA = "0x46925E4")]
		public GMWindowBtnDefault CreateBtnItem(Transform parent, string text, Action<string> callback)
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x4692818", Offset = "0x468E818", VA = "0x4692818")]
		public GMWindowSlider CreateSliderItem(SettingItemStyle style, Transform parent, string description, float defaultValue, Action<float> callback, [Optional][DefaultParameterValue(false)] bool wholeNumbers, [Optional] Vector2 range)
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x469296C", Offset = "0x468E96C", VA = "0x469296C")]
		public GMWindowToggleDefault CreateToggleItem(Transform parent, string text, bool isOn, Action<bool> callback)
		{
			return null;
		}
	}
}
