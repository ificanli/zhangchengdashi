using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200005F")]
	public class DebuggerWindowIcon : IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x10")]
		[UIPath(UIPathType.UGUI, "Bg/Button")]
		private DebuggerWindowIconBtnMono m_Btn;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x18")]
		[UIPath(UIPathType.UGUI, "Bg/TextTitle")]
		private Text m_Title;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x20")]
		[UIPath(UIPathType.UGUI, "Bg/TextAppBuildTestApkVer")]
		private Text m_AppBuildTestApkVer;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x28")]
		[UIPath(UIPathType.UGUI, "Bg/Button/Text")]
		private Text m_Content;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x30")]
		private Vector3? _firstMousePos;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _firstSelfPos;

		[Token(Token = "0x40001AE")]
		private const string KEY_ICON_POS_X = "DebuggerWindomIconPos_X";

		[Token(Token = "0x40001AF")]
		private const string KEY_ICON_POS_Y = "DebuggerWindomIconPos_Y";

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x4C")]
		private Vector2 _lastRefreshSize;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x58")]
		private RectTransform _parentRectTransform;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x60")]
		private DebuggerWindowMiniGM m_MiniGM;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x68")]
		private DebuggerWindowIconMono _mono;

		[Token(Token = "0x17000054")]
		public DebuggerWindowMiniGM MiniGM
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x4680698", Offset = "0x467C698", VA = "0x4680698")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private Transform transform
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x4680700", Offset = "0x467C700", VA = "0x4680700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private GameObject gameObject
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x468071C", Offset = "0x467C71C", VA = "0x468071C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x4680738", Offset = "0x467C738", VA = "0x4680738")]
		public DebuggerWindowIcon(DebuggerWindowIconMono mono)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x46807C4", Offset = "0x467C7C4", VA = "0x46807C4")]
		internal void OnAwake()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x4680844", Offset = "0x467C844", VA = "0x4680844")]
		public void SetActive(bool active)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x4680898", Offset = "0x467C898", VA = "0x4680898")]
		public void Init(string title, string apkVer, GMWindowUGUI gMWindowUGUI)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x4680AB8", Offset = "0x467CAB8", VA = "0x4680AB8")]
		private void OnClick()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x4680B3C", Offset = "0x467CB3C", VA = "0x4680B3C")]
		public void Refresh(string content, Color color)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x4680BAC", Offset = "0x467CBAC", VA = "0x4680BAC")]
		internal void OnLateUpdate()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x4680CDC", Offset = "0x467CCDC", VA = "0x4680CDC")]
		private void ClampPosInScreen()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x4680DB0", Offset = "0x467CDB0", VA = "0x4680DB0", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x4680E40", Offset = "0x467CE40", VA = "0x4680E40", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x4680E48", Offset = "0x467CE48", VA = "0x4680E48")]
		private void SavePos()
		{
		}
	}
}
