using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CommonGameModule.Debugger.UGUI.GMWindow;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000067")]
	public class GMWindowUGUI : IDebuggerWindowUGUI, IDebuggerWindowSkinSlot
	{
		[Token(Token = "0x2000068")]
		private class GMInitData
		{
			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string[] tags;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<string> btnCallback;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool defaulutIsOn;

			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<bool> toggleCallback;

			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public IGMWindowItem item;

			[Token(Token = "0x600024E")]
			[Address(RVA = "0x4685F30", Offset = "0x4681F30", VA = "0x4685F30")]
			public GMInitData()
			{
			}
		}

		[Token(Token = "0x40001E0")]
		private const int FONT_SIZE_FULL = 15;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[UIPath(UIPathType.UGUI, "InputFieldPrefab")]
		private InputField m_InputField;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[UIPath(UIPathType.UGUI, "TipText")]
		private Text m_Tip;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[UIPath(UIPathType.UGUI, "Scroll View")]
		private RectTransform m_ScrollViewTf;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[UIPath(UIPathType.UGUI, "Scroll View/Viewport/Content")]
		private RectTransform m_ContentTf;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[UIPath(UIPathType.UGUI, "NavigationBarPrefab")]
		private RectTransform m_TagNavigationBarTf;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[UIPath(UIPathType.Resources, "GMWindowItem/GMBtnPrefab")]
		private GameObject m_BtnPrefab;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[UIPath(UIPathType.Resources, "GMWindowItem/GMTogglePrefab")]
		private GameObject m_TogglePrefab;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[UIPath(UIPathType.Resources, "DebuggerSystemItem/NavigationBarBtnPrefab")]
		private Button m_TagBtnPrefab;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private VerticalLayoutGroup m_Layout;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GridLayoutGroup m_ContentLayout;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NavigationBarRootItem m_NavigationBarRootItem;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string m_CurrentSelectTag;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GMWindowUGUI _Instance;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int _ShowGMColumn;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly Transform _root;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string m_FullScreenTag;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform m_FullScreenRoot;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_IsMini;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<IGMWindowItem> _GMList;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<GMInitData> _WaitInitGMList;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static InputField _InputFieldIns;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static bool m_InitGlobalGM;

		[Token(Token = "0x17000062")]
		public RectTransform Root
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x46847E8", Offset = "0x46807E8", VA = "0x46847E8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public bool SupportClickThrough
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x4684848", Offset = "0x4680848", VA = "0x4684848", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000064")]
		public static int ShowGMColumn
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x4684850", Offset = "0x4680850", VA = "0x4684850")]
			get
			{
				return default;
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x46848A8", Offset = "0x46808A8", VA = "0x46848A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		private Transform transform
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x4684904", Offset = "0x4680904", VA = "0x4684904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		private GameObject gameObject
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x468490C", Offset = "0x468090C", VA = "0x468490C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public static string GMInputText
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x46859D4", Offset = "0x46819D4", VA = "0x46859D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x4684928", Offset = "0x4680928", VA = "0x4684928")]
		public GMWindowUGUI(Transform root)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x46849BC", Offset = "0x46809BC", VA = "0x46849BC", Slot = "6")]
		public void Initialize(params object[] args)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x4684C08", Offset = "0x4680C08", VA = "0x4684C08", Slot = "7")]
		public void OnDebuggerSystemReopen()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x4684C0C", Offset = "0x4680C0C", VA = "0x4684C0C", Slot = "8")]
		public void Shutdown()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x4684C10", Offset = "0x4680C10", VA = "0x4684C10", Slot = "9")]
		public void OnEnter()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x4684C14", Offset = "0x4680C14", VA = "0x4684C14", Slot = "10")]
		public void OnLeave()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x4684C18", Offset = "0x4680C18", VA = "0x4684C18", Slot = "11")]
		public void OnUpdate(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x467C5F0", Offset = "0x46785F0", VA = "0x467C5F0")]
		public void AddWaitMiniGM()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x4684F54", Offset = "0x4680F54", VA = "0x4684F54")]
		private void AddGM(GMInitData gmData)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x467C290", Offset = "0x4678290", VA = "0x467C290", Slot = "12")]
		public void RefreshSize(Vector2 size, bool portrait)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x467C83C", Offset = "0x467883C", VA = "0x467C83C")]
		public void SetIsMini(bool isMini, Transform miniRoot)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x468540C", Offset = "0x468140C", VA = "0x468540C")]
		private void TryAddTag(string[] tags)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x46859A0", Offset = "0x46819A0", VA = "0x46859A0")]
		private void OnTagBtnClick(string tag)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x468561C", Offset = "0x468161C", VA = "0x468561C")]
		private void RefreshGmByTag(string tag)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x4685AB4", Offset = "0x4681AB4", VA = "0x4685AB4")]
		private static bool TryRegistGM(GMInitData gMInitData)
		{
			return default;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x4685E94", Offset = "0x4681E94", VA = "0x4685E94")]
		public static void RegistGM(string name, Action<string> callback, [Optional] string[] tags)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x4685F38", Offset = "0x4681F38", VA = "0x4685F38")]
		public static void RegistGM(string name, bool defaulutIsOn, Action<bool> callback, [Optional] string[] tags)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x4685FE8", Offset = "0x4681FE8", VA = "0x4685FE8")]
		public static void RegistGM(IGMWindowItem item)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x4686148", Offset = "0x4682148", VA = "0x4686148")]
		public static void UnregistGMByName(string name)
		{
		}

		[Token(Token = "0x6000246")]
		public static void UnregistGMByCallback<T>(Action<T> callback)
		{
		}

		[Token(Token = "0x6000247")]
		public static void RenameGM<T>(string name, Action<T> callback)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x4684B80", Offset = "0x4680B80", VA = "0x4684B80")]
		private static void InitGlobalGM()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x468657C", Offset = "0x468257C", VA = "0x468657C")]
		public static void RegisterEvent()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x4686580", Offset = "0x4682580", VA = "0x4686580")]
		public static void ClearGM()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x46865D0", Offset = "0x46825D0", VA = "0x46865D0")]
		public static void ClearStaticMember()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x46868B8", Offset = "0x46828B8", VA = "0x46868B8", Slot = "13")]
		public void ApplySkin(DebuggerSystemSkinUGUI skin)
		{
		}
	}
}
