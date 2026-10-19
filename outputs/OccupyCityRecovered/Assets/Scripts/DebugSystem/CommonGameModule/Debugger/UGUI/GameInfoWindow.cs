using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000064")]
	public class GameInfoWindow : IDebuggerWindowUGUI, IDebuggerWindowSkinSlot
	{
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x10")]
		[UIPath(UIPathType.UGUI, "BaseInfo/Scroll View/Viewport/Content")]
		private RectTransform m_BaseInfoContent;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x18")]
		[UIPath(UIPathType.UGUI, "OnlineParams/Scroll View/Viewport/Content")]
		private RectTransform m_OnlineParamsContent;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x20")]
		[UIPath(UIPathType.UGUI, "BaseInfo/Scroll View/Viewport/Content/BaseInfoTextFirst")]
		private Text m_BaseInfoKey;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x28")]
		[UIPath(UIPathType.UGUI, "BaseInfo/Scroll View/Viewport/Content/BaseInfoTextSecond")]
		private Text m_BaseInfoValue;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x30")]
		[UIPath(UIPathType.UGUI, "OnlineParams/Scroll View/Viewport/Content/OnlineParamsTextFirst")]
		private Text m_OnlineParamsKey;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x38")]
		[UIPath(UIPathType.UGUI, "OnlineParams/Scroll View/Viewport/Content/OnlineParamsTextSecond")]
		private Text m_OnlineParamsValue;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x40")]
		[UIPath(UIPathType.UGUI, "BaseInfo/TextTitle/ButtonCopyDevicesID")]
		private Button m_CopyDeviceIdBtn;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x48")]
		[UIPath(UIPathType.UGUI, "BaseInfo/TextTitle/ButtonSendUACID")]
		private Button m_SendUACIdBtn;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x50")]
		private GridLayoutGroup m_GridLayoutGroup;

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x58")]
		private bool m_InitOnLineParams;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x5C")]
		private float m_Space;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x60")]
		private StringBuilder m_Key;

		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x68")]
		private StringBuilder m_Value;

		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x70")]
		private string m_DeviceId;

		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x78")]
		private readonly Transform _root;

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x80")]
		private List<string> _onlineParamsValues;

		[Token(Token = "0x17000059")]
		public RectTransform Root
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x4681DF4", Offset = "0x467DDF4", VA = "0x4681DF4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public bool SupportClickThrough
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x4681E54", Offset = "0x467DE54", VA = "0x4681E54", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005B")]
		public Transform transform
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x4681E5C", Offset = "0x467DE5C", VA = "0x4681E5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public GameObject gameObject
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x4681E64", Offset = "0x467DE64", VA = "0x4681E64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x4681E80", Offset = "0x467DE80", VA = "0x4681E80")]
		public GameInfoWindow(Transform transform)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x4681F00", Offset = "0x467DF00", VA = "0x4681F00", Slot = "6")]
		public void Initialize(params object[] args)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x4682128", Offset = "0x467E128", VA = "0x4682128")]
		private void InitGameInfo()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x4683194", Offset = "0x467F194", VA = "0x4683194")]
		private void InitOnlineParams()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x4683DFC", Offset = "0x467FDFC", VA = "0x4683DFC")]
		private void RelolveAllOnlineParams(string all_params)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x4682A38", Offset = "0x467EA38", VA = "0x4682A38")]
		private void AddKeyValue(string key, string value)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x468405C", Offset = "0x468005C", VA = "0x468405C", Slot = "7")]
		public void OnDebuggerSystemReopen()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x4684060", Offset = "0x4680060", VA = "0x4684060", Slot = "8")]
		public void Shutdown()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x4684064", Offset = "0x4680064", VA = "0x4684064", Slot = "9")]
		public void OnEnter()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x4684068", Offset = "0x4680068", VA = "0x4684068", Slot = "10")]
		public void OnLeave()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x468406C", Offset = "0x468006C", VA = "0x468406C", Slot = "11")]
		public void OnUpdate(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x4684070", Offset = "0x4680070", VA = "0x4684070", Slot = "12")]
		public void RefreshSize(Vector2 size, bool portrait)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x4682B34", Offset = "0x467EB34", VA = "0x4682B34")]
		private string GetDeviceRegion()
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x46840A8", Offset = "0x46800A8", VA = "0x46840A8")]
		private void SetAppDebugStatic(object[] param)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x46840AC", Offset = "0x46800AC", VA = "0x46840AC", Slot = "13")]
		public void ApplySkin(DebuggerSystemSkinUGUI skin)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x4683058", Offset = "0x467F058", VA = "0x4683058")]
		private void RefreshTextPos(Text key, Text value, RectTransform content)
		{
		}
	}
}
