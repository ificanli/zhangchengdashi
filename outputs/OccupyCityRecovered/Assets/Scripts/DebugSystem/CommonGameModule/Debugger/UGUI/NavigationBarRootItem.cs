using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000072")]
	public class NavigationBarRootItem
	{
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x10")]
		public readonly List<NavigationBarBtnItem> ListBtn;

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x18")]
		public readonly Transform Root;

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x4681678", Offset = "0x467D678", VA = "0x4681678")]
		public NavigationBarRootItem(Transform root)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x4681630", Offset = "0x467D630", VA = "0x4681630")]
		public void SetActive(bool active)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x46817FC", Offset = "0x467D7FC", VA = "0x46817FC")]
		public void AddBtn(string path, string name, bool isSelect, Button prefab, int maxCount, Action<string> clickAction)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x4681700", Offset = "0x467D700", VA = "0x4681700")]
		public void RecycleAllBtn()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x46811C4", Offset = "0x467D1C4", VA = "0x46811C4")]
		public void RefreshBarSelectName(string name)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x468113C", Offset = "0x467D13C", VA = "0x468113C")]
		public void RefreshColor()
		{
		}
	}
}
