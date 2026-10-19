using CommonGameModule.Debugger.UGUI.GMWindow;
using CommonGameModule.Debugger.UGUI.SettingWindow;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200008D")]
	public class SettingWindowUGUI : IDebuggerWindowUGUI
	{
		[Token(Token = "0x400024C")]
		private const float MIN_SCALE = 0.25f;

		[Token(Token = "0x400024D")]
		private const float MAX_SCALE = 1.5f;

		[Token(Token = "0x400024E")]
		private const float DEFAULT_SCALE = 0.5f;

		[Token(Token = "0x400024F")]
		private const string KEY_SCALE = "Setting_UIScale";

		[Token(Token = "0x4000250")]
		private const string KEY_CLICK_THROUGH = "Setting_ClickThrough";

		[Token(Token = "0x4000251")]
		private const string KEY_MILTI_TOUCH_ENABLE = "Setting_MultiTouchEnabled";

		[Token(Token = "0x4000252")]
		private const string SCALE_TEXT = "UIScale：{0}";

		[Token(Token = "0x4000253")]
		private const int MIN_PADDING = 2;

		[Token(Token = "0x4000254")]
		private const int MAX_PADDING = 200;

		[Token(Token = "0x4000255")]
		private const string KEY_PADDING = "Setting_UIPadding";

		[Token(Token = "0x4000256")]
		private const int MIN_MINI_GM_FONT_SIZE = 5;

		[Token(Token = "0x4000257")]
		private const int MAX_MINI_GM_FONT_SIZE = 15;

		[Token(Token = "0x4000258")]
		private const int DEFAULT_MINI_GM_FONT_SIZE = 10;

		[Token(Token = "0x4000259")]
		private const string KEY_MINI_GM_FONT_SIZE = "Setting_MiniGMFontSize";

		[Token(Token = "0x400025A")]
		private const string MINI_GM_TEXT_FORMAT = "MiniGMFontSzie:Example（{0}）";

		[Token(Token = "0x400025B")]
		private const string SHOW_GM_COLUMN_TEXT = "Portrait Show GM Column：{0}";

		[Token(Token = "0x400025C")]
		private const int MIN_SHOW_GM_COLUMN = 1;

		[Token(Token = "0x400025D")]
		private const int MAX_SHOW_GM_COLUMN = 5;

		[Token(Token = "0x400025E")]
		private const int DEFAULT_SHOW_GM_COLUMN = 1;

		[Token(Token = "0x400025F")]
		private const string KEY_SHOW_GM_COLUMN = "Setting_ShowGMColumn";

		[Token(Token = "0x4000260")]
		private const string KEY_MAX_CACHE_LOG_SIZE = "Setting_MaxCacheLogSize";

		[Token(Token = "0x4000261")]
		private const int MIN_MAX_CACHE_LOG_SIZE = 20;

		[Token(Token = "0x4000262")]
		private const int MAX_MAX_CACHE_LOG_SIZE = 50;

		[Token(Token = "0x4000263")]
		private const int DEFAULT_MAX_CACHE_LOG_SIZE = 20;

		[Token(Token = "0x4000264")]
		private const string MAX_CACHE_LOG_SIZE_TEXT_FORMAT = "MaxCacheLogMemorySize:{0}）";

		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x10")]
		[UIPath(UIPathType.UGUI, "Scroll View/Viewport/Content")]
		private Transform _itemRoot;

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x18")]
		private SettingItemFactory _factory;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x20")]
		private bool _isInit;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x24")]
		private int _miniGMFontSize;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x28")]
		private int[] _paddings;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x30")]
		private GMWindowToggleDefault _multiTouchToggle;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x38")]
		private GMWindowSlider _uiScaleSlider;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x40")]
		private GMWindowSlider[] _paddingSliders;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x48")]
		private GMWindowSlider _miniGMFontSizeSlider;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x50")]
		private Text _miniGMFontSizeText;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x58")]
		private GMWindowSlider _maxCacheLogSizeSlider;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x60")]
		private readonly Transform _root;

		[Token(Token = "0x17000086")]
		public RectTransform Root
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x4690214", Offset = "0x468C214", VA = "0x4690214", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public bool SupportClickThrough
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x4690274", Offset = "0x468C274", VA = "0x4690274", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000088")]
		public float UIScale
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x467DE00", Offset = "0x4679E00", VA = "0x467DE00")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x467DE20", Offset = "0x4679E20", VA = "0x467DE20")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public int MiniGMFontSize
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x469027C", Offset = "0x468C27C", VA = "0x469027C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x4690284", Offset = "0x468C284", VA = "0x4690284")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public Transform transform
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x46902E0", Offset = "0x468C2E0", VA = "0x46902E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		public GameObject gameObject
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x46902E8", Offset = "0x468C2E8", VA = "0x46902E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x4690304", Offset = "0x468C304", VA = "0x4690304")]
		public SettingWindowUGUI(Transform root)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x469037C", Offset = "0x468C37C", VA = "0x469037C", Slot = "6")]
		public void Initialize(params object[] args)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x469064C", Offset = "0x468C64C", VA = "0x469064C", Slot = "7")]
		public void OnDebuggerSystemReopen()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x4690650", Offset = "0x468C650", VA = "0x4690650", Slot = "9")]
		public void OnEnter()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x4690FE4", Offset = "0x468CFE4", VA = "0x4690FE4", Slot = "10")]
		public void OnLeave()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x469132C", Offset = "0x468D32C", VA = "0x469132C", Slot = "11")]
		public void OnUpdate(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x4691478", Offset = "0x468D478", VA = "0x4691478", Slot = "12")]
		public void RefreshSize(Vector2 size, bool portrait)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x469147C", Offset = "0x468D47C", VA = "0x469147C", Slot = "8")]
		public void Shutdown()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x4691480", Offset = "0x468D480", VA = "0x4691480")]
		public void SaveUIScaleSetting()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x4690FE8", Offset = "0x468CFE8", VA = "0x4690FE8")]
		private void SaveSetting()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x4691544", Offset = "0x468D544", VA = "0x4691544")]
		public static void LoadStaticSetting()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x46903E4", Offset = "0x468C3E4", VA = "0x46903E4")]
		private void LoadSetting()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x4691694", Offset = "0x468D694", VA = "0x4691694")]
		private void OnScaleValueChange(float value)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x46916DC", Offset = "0x468D6DC", VA = "0x46916DC")]
		private void OnResetScaleBtnClick(string _)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x4691740", Offset = "0x468D740", VA = "0x4691740")]
		private void OnClickThroughChange(bool isOn)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x4691768", Offset = "0x468D768", VA = "0x4691768")]
		private void OnMultiTouchEnableChange(bool isOn)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x4691774", Offset = "0x468D774", VA = "0x4691774")]
		private void OnPaddingValueChange(int index, float value)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x4691804", Offset = "0x468D804", VA = "0x4691804")]
		private void OnResetPaddingBtnClick(string _)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x4691888", Offset = "0x468D888", VA = "0x4691888")]
		private void OnMiniGMFontSizeChange(float value)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x469198C", Offset = "0x468D98C", VA = "0x469198C")]
		private void OnExitDebugerSystemClick(string _)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x46919B0", Offset = "0x468D9B0", VA = "0x46919B0")]
		private void OnShowGMColumnChange(float value)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x4691A5C", Offset = "0x468DA5C", VA = "0x4691A5C")]
		private void OnRegistRuntimeInspectorWindowClick(string _)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x4691A60", Offset = "0x468DA60", VA = "0x4691A60")]
		private void OnMaxCacheLogSizeChange(float value)
		{
		}
	}
}
