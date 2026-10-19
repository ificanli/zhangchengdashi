using System.Text;
using CommonGameModule.Debugger.UGUI.ConsoleWindow;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000055")]
	public class ConsoleWindowUGUI : IDebuggerWindowUGUI, IDebuggerWindowSkinSlot
	{
		[Token(Token = "0x2000056")]
		public enum _LogType
		{
			[Token(Token = "0x4000174")]
			Error = 0,
			[Token(Token = "0x4000175")]
			Assert = 1,
			[Token(Token = "0x4000176")]
			Warning = 2,
			[Token(Token = "0x4000177")]
			Log = 3,
			[Token(Token = "0x4000178")]
			Exception = 4,
			[Token(Token = "0x4000179")]
			CustomError = 5
		}

		[Token(Token = "0x2000057")]
		public class Sample
		{
			[Token(Token = "0x400017A")]
			[FieldOffset(Offset = "0x10")]
			public float time;

			[Token(Token = "0x400017B")]
			[FieldOffset(Offset = "0x14")]
			public byte loadedScene;

			[Token(Token = "0x400017C")]
			[FieldOffset(Offset = "0x18")]
			public float memory;

			[Token(Token = "0x400017D")]
			[FieldOffset(Offset = "0x1C")]
			public float fps;

			[Token(Token = "0x400017E")]
			[FieldOffset(Offset = "0x20")]
			public string fpsText;

			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x467BB30", Offset = "0x4677B30", VA = "0x467BB30")]
			public static float MemSize()
			{
				return default;
			}

			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x467BB38", Offset = "0x4677B38", VA = "0x467BB38")]
			public string GetSceneName()
			{
				return null;
			}

			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x467BBCC", Offset = "0x4677BCC", VA = "0x467BBCC")]
			public Sample()
			{
			}
		}

		[Token(Token = "0x2000058")]
		public class Log
		{
			[Token(Token = "0x400017F")]
			[FieldOffset(Offset = "0x10")]
			public int count;

			[Token(Token = "0x4000180")]
			[FieldOffset(Offset = "0x14")]
			public _LogType logType;

			[Token(Token = "0x4000181")]
			[FieldOffset(Offset = "0x18")]
			public string condition;

			[Token(Token = "0x4000182")]
			[FieldOffset(Offset = "0x20")]
			public string stacktrace;

			[Token(Token = "0x4000183")]
			[FieldOffset(Offset = "0x28")]
			public string conditionWithOutClogTime;

			[Token(Token = "0x4000184")]
			[FieldOffset(Offset = "0x30")]
			public int sampleId;

			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x467BBD4", Offset = "0x4677BD4", VA = "0x467BBD4")]
			public Log CreateCopy()
			{
				return null;
			}

			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x467BC54", Offset = "0x4677C54", VA = "0x467BC54")]
			public float GetMemoryUsage()
			{
				return default;
			}

			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x467BC9C", Offset = "0x4677C9C", VA = "0x467BC9C")]
			public Log()
			{
			}
		}

		[Token(Token = "0x2000059")]
		public class LogItemViewSetting
		{
			[Token(Token = "0x4000185")]
			[FieldOffset(Offset = "0x10")]
			private readonly ConsoleWindowUGUI m_WindowUgui;

			[Token(Token = "0x4000186")]
			[FieldOffset(Offset = "0x18")]
			private readonly ConsoleLogHandler m_logHandler;

			[Token(Token = "0x4000187")]
			[FieldOffset(Offset = "0x20")]
			public ConsoleWindowSkin consoleWindowSkin;

			[Token(Token = "0x4000188")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Sample _DefaultSample;

			[Token(Token = "0x1700003F")]
			public Color logType
			{
				[Token(Token = "0x60001A8")]
				[Address(RVA = "0x467BCAC", Offset = "0x4677CAC", VA = "0x467BCAC")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000040")]
			public Color warningType
			{
				[Token(Token = "0x60001A9")]
				[Address(RVA = "0x467BCCC", Offset = "0x4677CCC", VA = "0x467BCCC")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000041")]
			public Color errorType
			{
				[Token(Token = "0x60001AA")]
				[Address(RVA = "0x467BCEC", Offset = "0x4677CEC", VA = "0x467BCEC")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000042")]
			public Color bgNoraml
			{
				[Token(Token = "0x60001AB")]
				[Address(RVA = "0x467BD0C", Offset = "0x4677D0C", VA = "0x467BD0C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000043")]
			public Color bgOther
			{
				[Token(Token = "0x60001AC")]
				[Address(RVA = "0x467BD2C", Offset = "0x4677D2C", VA = "0x467BD2C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000044")]
			public Color bgSelect
			{
				[Token(Token = "0x60001AD")]
				[Address(RVA = "0x467BD4C", Offset = "0x4677D4C", VA = "0x467BD4C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000045")]
			public bool collapse
			{
				[Token(Token = "0x60001AE")]
				[Address(RVA = "0x467BD6C", Offset = "0x4677D6C", VA = "0x467BD6C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000046")]
			public bool showClogTime
			{
				[Token(Token = "0x60001AF")]
				[Address(RVA = "0x467BD88", Offset = "0x4677D88", VA = "0x467BD88")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000047")]
			public bool showTime
			{
				[Token(Token = "0x60001B0")]
				[Address(RVA = "0x467BDA4", Offset = "0x4677DA4", VA = "0x467BDA4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000048")]
			public bool showScene
			{
				[Token(Token = "0x60001B1")]
				[Address(RVA = "0x467BDC0", Offset = "0x4677DC0", VA = "0x467BDC0")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000049")]
			public bool showFps
			{
				[Token(Token = "0x60001B2")]
				[Address(RVA = "0x467BDDC", Offset = "0x4677DDC", VA = "0x467BDDC")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700004A")]
			public Log SelectLog
			{
				[Token(Token = "0x60001B3")]
				[Address(RVA = "0x467BDF8", Offset = "0x4677DF8", VA = "0x467BDF8")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001B4")]
				[Address(RVA = "0x467BE14", Offset = "0x4677E14", VA = "0x467BE14")]
				set
				{
				}
			}

			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x467BE30", Offset = "0x4677E30", VA = "0x467BE30")]
			public LogItemViewSetting(ConsoleWindowUGUI windowUgui, ConsoleLogHandler logHandler)
			{
			}

			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x467BE5C", Offset = "0x4677E5C", VA = "0x467BE5C")]
			public Sample GetSampleByID(int id)
			{
				return null;
			}

			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x467BF14", Offset = "0x4677F14", VA = "0x467BF14")]
			public void AddLogMemUsage(string logCondition)
			{
			}
		}

		[Token(Token = "0x4000144")]
		public const int MAX_LOG_CONDITION_LENGTH = 5000;

		[Token(Token = "0x4000145")]
		public const int MAX_LOG_STACKTRACE_LENGTH = 8000;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x10")]
		[UIPath(UIPathType.UGUI, "LogScrollView")]
		private ScrollRect m_LogScroll;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x18")]
		[UIPath(UIPathType.UGUI, "DetailedInfo/DetailedScrollView")]
		private ScrollRect m_DetailedInfoScroll;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x20")]
		[UIPath(UIPathType.Resources, "DebuggerSystemItem/ConsoleItemPrefab")]
		private GameObject m_LogItemPrefab;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x28")]
		[UIPath(UIPathType.UGUI, "DetailedInfo")]
		private RectTransform m_DetailedInfoTf;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x30")]
		[UIPath(UIPathType.UGUI, "ToolsBar")]
		private RectTransform m_ToolsBar;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x38")]
		[UIPath(UIPathType.UGUI, "SecondToolsBar")]
		private RectTransform m_SecondToolsBar;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x40")]
		[Header("按顺序,清空,合并,切场景清空,显示游戏时间,显示场景,显示帧率")]
		private Button[] m_SettingBtns;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x48")]
		[Header("按顺序,ClogTime,log,warning,自定义error,error")]
		private Button[] m_LogLvBtns;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x50")]
		[UIPath(UIPathType.UGUI, "SearchRoot/InputField")]
		private InputField m_InputField;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x58")]
		[UIPath(UIPathType.UGUI, "SearchRoot/ButtonSearchPrevious")]
		private Button _searchPreviousBtn;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x60")]
		[UIPath(UIPathType.UGUI, "SearchRoot/ButtonSearchNext")]
		private Button _searchNextBtn;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x68")]
		[UIPath(UIPathType.UGUI, "SearchRoot/ButtonSearchState")]
		private Button _searchStateBtn;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x70")]
		[UIPath(UIPathType.UGUI, "DetailedInfo/DetailedScrollView/Viewport/Content")]
		private Text m_DetailedText;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x78")]
		[UIPath(UIPathType.UGUI, "DetailedInfo/ButtonUploadAll")]
		private Button m_UploadAllBtn;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x80")]
		[UIPath(UIPathType.UGUI, "DetailedInfo/ButtonUploadLog")]
		private Button m_UploadLogBtn;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x88")]
		[UIPath(UIPathType.UGUI, "DetailedInfo/ButtonCopyLog")]
		private Button m_CopyLogBtn;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x90")]
		private VerticalLayoutGroup m_LayoutGroup;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x98")]
		private LayoutElement m_LogLayoutElement;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0xA0")]
		private DynamicScrollView<ConsoleItemUGUI, Log, LogItemViewSetting> m_DynamicScrollView;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_IsOneRow;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0xB0")]
		private LogItemViewSetting m_LogItemViewSetting;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0xB8")]
		private ToggleBtn collapseToggle;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0xC0")]
		private ToggleBtn clearOnNewSceneLoadedToggle;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0xC8")]
		private ToggleBtn showTimeToggle;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0xD0")]
		private ToggleBtn showSceneToggle;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0xD8")]
		private ToggleBtn showFpsToggle;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0xE0")]
		private ToggleBtn showClogTimeToggle;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0xE8")]
		private ToggleBtn showLogToggle;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0xF0")]
		private ToggleBtn showWarningToggle;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0xF8")]
		private ToggleBtn showErrorToggle;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x100")]
		private ToggleBtn showCustomErrorToggle;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x108")]
		private readonly StringBuilder _stringBuilder;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x110")]
		private int frames;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x114")]
		private bool firstTime;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x118")]
		private float lastUpdate;

		[Token(Token = "0x4000169")]
		private const int requiredFrames = 10;

		[Token(Token = "0x400016A")]
		private const float updateInterval = 0.25f;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x11C")]
		private readonly Vector2 ItemSize;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x124")]
		private readonly Vector2 ItemSizeExtendInfo;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x12C")]
		private float _firstDetailedInfoHeight;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x130")]
		private ConsoleSearchCtrl _consoleSearchCtrl;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x138")]
		private float _uploadActiveTime;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x0")]
		private static ConsoleLogHandler m_LogHandler;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x8")]
		private static bool m_ClearFlag;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x140")]
		private readonly Transform _root;

		[Token(Token = "0x17000039")]
		public static bool HasLogsError
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x4632468", Offset = "0x462E468", VA = "0x4632468")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003A")]
		public RectTransform Root
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x4647D94", Offset = "0x4643D94", VA = "0x4647D94", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public bool SupportClickThrough
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x4647DF4", Offset = "0x4643DF4", VA = "0x4647DF4", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003C")]
		public static ConsoleLogHandler LogHandler
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x4647DFC", Offset = "0x4643DFC", VA = "0x4647DFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public Transform transform
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x4647E90", Offset = "0x4643E90", VA = "0x4647E90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public GameObject gameObject
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x4647E98", Offset = "0x4643E98", VA = "0x4647E98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x4630754", Offset = "0x462C754", VA = "0x4630754")]
		public static void InitStaticMember()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x4631B08", Offset = "0x462DB08", VA = "0x4631B08")]
		public static void StopCaptureLog()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x4647E44", Offset = "0x4643E44", VA = "0x4647E44")]
		private static void OnLogHandlerClear()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x46327DC", Offset = "0x462E7DC", VA = "0x46327DC")]
		public ConsoleWindowUGUI(Transform root)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x4647EB4", Offset = "0x4643EB4", VA = "0x4647EB4", Slot = "6")]
		public void Initialize(params object[] args)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x4648CBC", Offset = "0x4644CBC", VA = "0x4648CBC", Slot = "7")]
		public void OnDebuggerSystemReopen()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x4648CC0", Offset = "0x4644CC0", VA = "0x4648CC0", Slot = "8")]
		public void Shutdown()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x4648D90", Offset = "0x4644D90", VA = "0x4648D90", Slot = "9")]
		public void OnEnter()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x4648DEC", Offset = "0x4644DEC", VA = "0x4648DEC", Slot = "10")]
		public void OnLeave()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x4648E3C", Offset = "0x4644E3C", VA = "0x4648E3C", Slot = "11")]
		public void OnUpdate(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x46493A4", Offset = "0x46453A4", VA = "0x46493A4", Slot = "12")]
		public void RefreshSize(Vector2 size, bool portrait)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x4648B8C", Offset = "0x4644B8C", VA = "0x4648B8C")]
		public void RefreshCurrentLog()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x4649930", Offset = "0x4645930", VA = "0x4649930")]
		public void MoveToSelectLog()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x46499C0", Offset = "0x46459C0", VA = "0x46499C0")]
		private void OnSceneLoaded(Scene newScene, LoadSceneMode loadSceneMode)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x4649B28", Offset = "0x4645B28", VA = "0x4649B28")]
		private static void CaptureLogThread(string condition, string stacktrace, LogType type)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x4649C0C", Offset = "0x4645C0C", VA = "0x4649C0C")]
		private static string GetConditionTag(string condition)
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x4649D1C", Offset = "0x4645D1C", VA = "0x4649D1C")]
		private static string HandleConditionRichText(string condition, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x4649A74", Offset = "0x4645A74", VA = "0x4649A74")]
		private void OnClearBtnClick()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x464A01C", Offset = "0x464601C", VA = "0x464A01C")]
		private void OnCollapseChange(bool value)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x464A088", Offset = "0x4646088", VA = "0x464A088")]
		private void OnClearOnNewSceneLoadedChange(bool value)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x464A0E4", Offset = "0x46460E4", VA = "0x464A0E4")]
		private void OnShowTimeChange(bool value)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x464A150", Offset = "0x4646150", VA = "0x464A150")]
		private void OnShowSceneChange(bool value)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x464A1BC", Offset = "0x46461BC", VA = "0x464A1BC")]
		private void OnShowFPSChange(bool value)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x464A228", Offset = "0x4646228", VA = "0x464A228")]
		private void OnShowCLogTimeChange(bool value)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x464A294", Offset = "0x4646294", VA = "0x464A294")]
		private void OnShowLogChange(bool value)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x464A300", Offset = "0x4646300", VA = "0x464A300")]
		private void OnShowWarningChange(bool value)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x464A36C", Offset = "0x464636C", VA = "0x464A36C")]
		private void OnShowErrorChange(bool value)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x464A3D8", Offset = "0x46463D8", VA = "0x464A3D8")]
		private void OnShowCustomErrorChange(bool value)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x464A444", Offset = "0x4646444", VA = "0x464A444")]
		public void OnSelectLogChange(Log log)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x464A700", Offset = "0x4646700", VA = "0x464A700")]
		private bool CheckCanUpload()
		{
			return default;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x464A74C", Offset = "0x464674C", VA = "0x464A74C")]
		private void OnUploadAllClick()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x464A8B4", Offset = "0x46468B4", VA = "0x464A8B4")]
		private void OnUploadLogClick()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x464AA88", Offset = "0x4646A88", VA = "0x464AA88")]
		private void OnCopyLogClick()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x464AC2C", Offset = "0x4646C2C", VA = "0x464AC2C", Slot = "13")]
		public void ApplySkin(DebuggerSystemSkinUGUI skin)
		{
		}
	}
}
