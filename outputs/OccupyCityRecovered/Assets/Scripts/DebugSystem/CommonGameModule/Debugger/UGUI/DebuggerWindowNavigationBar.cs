using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000062")]
	public class DebuggerWindowNavigationBar : IDebuggerWindowSkinSlot
	{
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x10")]
		private WindowPathNode m_RootNode;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x18")]
		[UIPath(UIPathType.Resources, "DebuggerSystemItem/NavigationBarPrefab")]
		private GameObject m_NavigationBarPrefab;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x20")]
		[UIPath(UIPathType.Resources, "DebuggerSystemItem/NavigationBarBtnPrefab")]
		private Button m_NavigationBarBtnPrefab;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x28")]
		private List<NavigationBarRootItem> m_NavigationBarList;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x30")]
		private List<string> m_CurPaths;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x38")]
		private DebuggerWindowFullMono _mono;

		[Token(Token = "0x17000058")]
		private GameObject gameObject
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x4681120", Offset = "0x467D120", VA = "0x4681120")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x467DA68", Offset = "0x4679A68", VA = "0x467DA68")]
		public DebuggerWindowNavigationBar(DebuggerWindowFullMono mono)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x4680478", Offset = "0x467C478", VA = "0x4680478", Slot = "4")]
		public void ApplySkin(DebuggerSystemSkinUGUI skin)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x467DAF4", Offset = "0x4679AF4", VA = "0x467DAF4")]
		public void Init(WindowPathNode rootNode)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x467F710", Offset = "0x467B710", VA = "0x467F710")]
		public void RefreshUI(List<string> selectWindowPaths, bool reset = false)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x468125C", Offset = "0x467D25C", VA = "0x468125C")]
		private void CreateNavigationBar(WindowPathNode node, string nodeFullPath, string selectNodeName, int index)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x468194C", Offset = "0x467D94C", VA = "0x468194C")]
		private static void OnNavigationBarBtnClick(string path)
		{
		}
	}
}
