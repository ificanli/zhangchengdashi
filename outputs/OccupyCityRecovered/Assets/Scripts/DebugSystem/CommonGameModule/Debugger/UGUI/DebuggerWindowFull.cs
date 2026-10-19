using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200005C")]
	public class DebuggerWindowFull : IDebuggerWindowSkinSlot
	{
		[Token(Token = "0x200005D")]
		private enum ClickThroughStage
		{
			[Token(Token = "0x40001A4")]
			Nonsupport = 0,
			[Token(Token = "0x40001A5")]
			DisableClickThrough = 1,
			[Token(Token = "0x40001A6")]
			EnableClickThrough = 2
		}

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x10")]
		[UIPath(UIPathType.UGUI, "ChildCanvas")]
		private RectTransform m_ChildCanvas;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x18")]
		[UIPath(UIPathType.UGUI, "BottomBtns/ClickThroughButton")]
		private Button m_ClickThroughBtn;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x20")]
		private GraphicRaycaster m_Raycaster;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x28")]
		[UIPath(UIPathType.UGUI, "BottomBtns/ExitButton")]
		private Button m_ExitBtn;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x30")]
		private DebuggerWindowNavigationBar _navigationBar;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, IDebuggerWindowUGUI> m_DictWindow;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x40")]
		private WindowPathNode m_RootNode;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x48")]
		private VerticalLayoutGroup m_Layout;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x50")]
		private IDebuggerWindowUGUI m_SelectedWindow;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x58")]
		private List<string> m_SelectWindowPaths;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x60")]
		private bool m_Active;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x61")]
		private bool m_NavigationBarDirty;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x64")]
		private Vector2 m_LastRefreshSize;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x6C")]
		private float m_LastBangsPixel;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x70")]
		private int[] m_Padding;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x78")]
		private DebuggerWindowFullMono _mono;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x80")]
		private Text m_ClickThroughText;

		[Token(Token = "0x1700004F")]
		public static DebuggerWindowFull I
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x467CF4C", Offset = "0x4678F4C", VA = "0x467CF4C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x467CF94", Offset = "0x4678F94", VA = "0x467CF94")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public IDebuggerWindowUGUI SelectedWindow
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x467CFE0", Offset = "0x4678FE0", VA = "0x467CFE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public int[] Padding
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x467CFE8", Offset = "0x4678FE8", VA = "0x467CFE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		private GameObject gameObject
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x467D6D8", Offset = "0x46796D8", VA = "0x467D6D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x467D6F4", Offset = "0x46796F4", VA = "0x467D6F4")]
		public DebuggerWindowFull(DebuggerWindowFullMono mono)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x467D780", Offset = "0x4679780", VA = "0x467D780")]
		public void Init()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x467DBB8", Offset = "0x4679BB8", VA = "0x467DBB8")]
		public void OnUpdate(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x467DD5C", Offset = "0x4679D5C", VA = "0x467DD5C")]
		private void UpdateScale(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x467DD60", Offset = "0x4679D60", VA = "0x467DD60")]
		private void OnScale(float delta)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x467DEA4", Offset = "0x4679EA4", VA = "0x467DEA4")]
		public void SetWindowActive(bool active)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x467D018", Offset = "0x4679018", VA = "0x467D018")]
		public void RefreshSize()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x467E820", Offset = "0x467A820", VA = "0x467E820")]
		public void RegisterDebuggerWindow(string path, IDebuggerWindowUGUI window, params object[] args)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x467EFA0", Offset = "0x467AFA0", VA = "0x467EFA0")]
		public bool UnregisterDebuggerWindow(string path)
		{
			return default;
		}

		[Token(Token = "0x60001D5")]
		public T GetWindow<T>() where T : IDebuggerWindowUGUI
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DebuggerWindowFull.GetWindow RVA= Token=0x60001D5");
}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x467F36C", Offset = "0x467B36C", VA = "0x467F36C")]
		public IDebuggerWindowUGUI GetWindow(string path)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x467E240", Offset = "0x467A240", VA = "0x467E240")]
		public void SelectWindow(string path)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x467E7E8", Offset = "0x467A7E8", VA = "0x467E7E8")]
		private void RefreshNavigationBar(bool reset = false)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x467F9FC", Offset = "0x467B9FC", VA = "0x467F9FC")]
		public void OnReopen()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x467FBD0", Offset = "0x467BBD0", VA = "0x467FBD0")]
		public void OnShutDown()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x467FF64", Offset = "0x467BF64", VA = "0x467FF64")]
		private void OnExitBtnClick()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x467FF88", Offset = "0x467BF88", VA = "0x467FF88")]
		private void OnClickThroughBtnClick()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x467F4DC", Offset = "0x467B4DC", VA = "0x467F4DC")]
		private void SetClickThroughStage(ClickThroughStage stage)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x467FFBC", Offset = "0x467BFBC", VA = "0x467FFBC", Slot = "4")]
		public void ApplySkin(DebuggerSystemSkinUGUI skin)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x4680548", Offset = "0x467C548", VA = "0x4680548")]
		public static void ClearStaticMember()
		{
		}
	}
}
