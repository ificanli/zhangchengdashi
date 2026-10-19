using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommonGameModule.Debugger.UGUI;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Debugger
{
	[Token(Token = "0x200000B")]
	public class DebuggerSystemUGUI
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct _003CCheckCanShowGM_003Ed__68 : IAsyncStateMachine
		{
			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DebuggerSystemUGUI _003C_003E4__this;

			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<bool> _003C_003Eu__1;

			[Token(Token = "0x6000043")]
			[Address(RVA = "0x4633C9C", Offset = "0x462FC9C", VA = "0x4633C9C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0x4633ECC", Offset = "0x462FECC", VA = "0x4633ECC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DebuggerSystemUGUI _instance;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _created;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[CompilerGenerated]
		private static Action m_OnFirstShowFullWindow;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _initialized;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool _initializedWindow;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		private bool _isFirstShowFullWindow;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[UIPath(UIPathType.UGUI, "DebuggerSystemUGUICanvas")]
		private CanvasScaler _canvasScaler;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector2 _firstCanvasSize;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _curCanvasScale;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[UIPath(UIPathType.UGUI, "DebuggerSystemUGUICanvas/DebuggerWindowIcon")]
		private DebuggerWindowIconMono _windowIconMono;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[UIPath(UIPathType.UGUI, "DebuggerSystemUGUICanvas/DebuggerWindowFull")]
		private DebuggerWindowFullMono _windowFullMono;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[UIPath(UIPathType.Resources, "DebuggerSystemSkinUGUI_Default")]
		private DebuggerSystemSkinUGUI _defaultSkin;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DebuggerSystemSkinUGUI _curSkin;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DebuggerSystemSkinUGUI _waitInitSkin;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[UIPath(UIPathType.Resources, "DebuggerSystemWindows/GMWindow")]
		private GameObject _gMWindowPrefab;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[UIPath(UIPathType.Resources, "DebuggerSystemWindows/ConsoleWindow")]
		private GameObject _consoleWindowPrefab;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[UIPath(UIPathType.Resources, "DebuggerSystemWindows/GameInfoWindow")]
		private GameObject _gameInfoWindowPrefab;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[UIPath(UIPathType.Resources, "DebuggerSystemWindows/InformationWindow")]
		private GameObject _informationWindowPrefab;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[UIPath(UIPathType.Resources, "DebuggerSystemWindows/SettingPanel")]
		private GameObject _settingsWindowPrefab;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[UIPath(UIPathType.Resources, "DebuggerSystemWindows/LangWindow")]
		private GameObject _langWindowPrefab;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ConsoleWindowUGUI _consoleWindow;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GMWindowUGUI _gMWindow;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private SettingWindowUGUI _settingWindow;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _hasRegisterWindow;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FpsCounter _fpsCounter;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _showFullWindow;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string _appBuildTestApkVer;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly DebuggerSystemStartMono _mono;

		[Token(Token = "0x17000004")]
		public static DebuggerSystemUGUI I
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x462F644", Offset = "0x462B644", VA = "0x462F644")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x46308D8", Offset = "0x462C8D8", VA = "0x46308D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		private DebuggerWindowFull _windowFull
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x4630A9C", Offset = "0x462CA9C", VA = "0x4630A9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public bool HasShowFullWindow
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x4630AB8", Offset = "0x462CAB8", VA = "0x4630AB8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000007")]
		public bool ActiveWindow
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x462F940", Offset = "0x462B940", VA = "0x462F940")]
			get
			{
				return default;
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x462F9F8", Offset = "0x462B9F8", VA = "0x462F9F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool ShowFullWindow
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x4630AC8", Offset = "0x462CAC8", VA = "0x4630AC8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x4630AD0", Offset = "0x462CAD0", VA = "0x4630AD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public bool ClickThrough
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x46312C8", Offset = "0x462D2C8", VA = "0x46312C8")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x46312D0", Offset = "0x462D2D0", VA = "0x46312D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float UIScale
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x46312DC", Offset = "0x462D2DC", VA = "0x46312DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x46312E4", Offset = "0x462D2E4", VA = "0x46312E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public float IconScale
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x46313E8", Offset = "0x462D3E8", VA = "0x46313E8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x4631410", Offset = "0x462D410", VA = "0x4631410")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public DebuggerSystemSkinUGUI Skin
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x4631498", Offset = "0x462D498", VA = "0x4631498")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x4631220", Offset = "0x462D220", VA = "0x4631220")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public GameObject gameObject
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x462F8A0", Offset = "0x462B8A0", VA = "0x462F8A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		public IDebuggerWindowUGUI SelectedWindow
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x4633B54", Offset = "0x462FB54", VA = "0x4633B54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		internal int MiniGMFontSize
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x4633BDC", Offset = "0x462FBDC", VA = "0x4633BDC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000003")]
		public static event Action OnFirstShowFullWindow
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x4630924", Offset = "0x462C924", VA = "0x4630924")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x46309E0", Offset = "0x462C9E0", VA = "0x46309E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x46302A8", Offset = "0x462C2A8", VA = "0x46302A8")]
		internal DebuggerSystemUGUI(DebuggerSystemStartMono mono)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x463035C", Offset = "0x462C35C", VA = "0x463035C")]
		internal void OnAwake()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x4630590", Offset = "0x462C590", VA = "0x4630590")]
		internal void OnStart()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x46317B0", Offset = "0x462D7B0", VA = "0x46317B0")]
		private void Initialize()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x4631C9C", Offset = "0x462DC9C", VA = "0x4631C9C")]
		private void InitializedSetting()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x4631BDC", Offset = "0x462DBDC", VA = "0x4631BDC")]
		private void InitializedWindow()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x46306DC", Offset = "0x462C6DC", VA = "0x46306DC")]
		internal void OnUpdate()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x46322BC", Offset = "0x462E2BC", VA = "0x46322BC")]
		private void UpdateFullWindow()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x4632334", Offset = "0x462E334", VA = "0x4632334")]
		private void UpdateWindowIcon()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x46324D4", Offset = "0x462E4D4", VA = "0x46324D4")]
		private void AppChangeTestMode(params object[] Args)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x4632614", Offset = "0x462E614", VA = "0x4632614")]
		[AsyncStateMachine(typeof(_003CCheckCanShowGM_003Ed__68))]
		private void CheckCanShowGM()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x4631E68", Offset = "0x462DE68", VA = "0x4631E68")]
		private void SetActive(bool active)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x46326A4", Offset = "0x462E6A4", VA = "0x46326A4")]
		private static void OnExitGame(params object[] obj)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x462FF88", Offset = "0x462BF88", VA = "0x462FF88")]
		public static void DestroySelf()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x463273C", Offset = "0x462E73C", VA = "0x463273C")]
		private static void ClearStaticMember()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x4630D08", Offset = "0x462CD08", VA = "0x4630D08")]
		internal void RegistInitWindow()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x4632894", Offset = "0x462E894", VA = "0x4632894")]
		private void RegistInformationWindow()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x4633B7C", Offset = "0x462FB7C", VA = "0x4633B7C")]
		public void SelectDebuggerWindow(string path)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x4632794", Offset = "0x462E794", VA = "0x4632794")]
		public void RegisterDebuggerWindow(string path, IDebuggerWindowUGUI window, params object[] args)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x4633BAC", Offset = "0x462FBAC", VA = "0x4633BAC")]
		public bool UnregisterDebuggerWindow(string path)
		{
			return default;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x46313B8", Offset = "0x462D3B8", VA = "0x46313B8")]
		public IDebuggerWindowUGUI GetDebuggerWindow(string path)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x463117C", Offset = "0x462D17C", VA = "0x463117C")]
		private bool CheckIsObf()
		{
			return default;
		}
	}
}
