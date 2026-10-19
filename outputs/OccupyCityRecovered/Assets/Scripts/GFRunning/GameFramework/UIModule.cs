using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using GameFramework.Resources;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace GameFramework
{
	[Token(Token = "0x20003C6")]
	public class UIModule : GameFrameModule
	{
		[Token(Token = "0x20003CB")]
		[CompilerGenerated]
		private sealed class _003CUIAnim_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001C77")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001C78")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001C79")]
			[FieldOffset(Offset = "0x20")]
			public float customerTime;

			[Token(Token = "0x4001C7A")]
			[FieldOffset(Offset = "0x24")]
			public EUIAnim anim;

			[Token(Token = "0x4001C7B")]
			[FieldOffset(Offset = "0x28")]
			public GameObject target;

			[Token(Token = "0x17001164")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005F70")]
				[Address(RVA = "0x71D9720", Offset = "0x71D5720", VA = "0x71D9720", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17001165")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005F72")]
				[Address(RVA = "0x71D9760", Offset = "0x71D5760", VA = "0x71D9760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005F6D")]
			[Address(RVA = "0x71D8D34", Offset = "0x71D4D34", VA = "0x71D8D34")]
			[DebuggerHidden]
			public _003CUIAnim_003Ed__48(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005F6E")]
			[Address(RVA = "0x71D9574", Offset = "0x71D5574", VA = "0x71D9574", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005F6F")]
			[Address(RVA = "0x71D9578", Offset = "0x71D5578", VA = "0x71D9578", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005F70")]
			[Address(RVA = "0x71D9720", Offset = "0x71D5720", VA = "0x71D9720", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005F71")]
			[Address(RVA = "0x71D9728", Offset = "0x71D5728", VA = "0x71D9728", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005F72")]
			[Address(RVA = "0x71D9760", Offset = "0x71D5760", VA = "0x71D9760", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20003CC")]
		[CompilerGenerated]
		private sealed class _003Cwait2Fram_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001C7C")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001C7D")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001C7E")]
			[FieldOffset(Offset = "0x20")]
			public Action action;

			[Token(Token = "0x17001166")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005F76")]
				[Address(RVA = "0x71D97DC", Offset = "0x71D57DC", VA = "0x71D97DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return _003C_003E2__current;
				}
			}

			[Token(Token = "0x17001167")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005F78")]
				[Address(RVA = "0x71D981C", Offset = "0x71D581C", VA = "0x71D981C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return _003C_003E2__current;
				}
			}

			[Token(Token = "0x6005F73")]
			[Address(RVA = "0x71D8034", Offset = "0x71D4034", VA = "0x71D8034")]
			[DebuggerHidden]
			public _003Cwait2Fram_003Ed__19(int _003C_003E1__state)
			{
				this._003C_003E1__state = _003C_003E1__state;
			}

			[Token(Token = "0x6005F74")]
			[Address(RVA = "0x71D9768", Offset = "0x71D5768", VA = "0x71D9768", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005F75")]
			[Address(RVA = "0x71D976C", Offset = "0x71D576C", VA = "0x71D976C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				if (_003C_003E1__state == 0)
				{
				    _003C_003E2__current = null;
				    _003C_003E1__state = 1;
				    return true;
				}
				if (_003C_003E1__state == 1)
				{
				    _003C_003E2__current = null;
				    _003C_003E1__state = 2;
				    return true;
				}
				if (_003C_003E1__state == 2)
				{
				    _003C_003E1__state = -1;
				    action?.Invoke();
				}
				return false;
			}

			[Token(Token = "0x6005F76")]
			[Address(RVA = "0x71D97DC", Offset = "0x71D57DC", VA = "0x71D97DC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005F77")]
			[Address(RVA = "0x71D97E4", Offset = "0x71D57E4", VA = "0x71D97E4", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
				throw new NotSupportedException();
			}

			[Token(Token = "0x6005F78")]
			[Address(RVA = "0x71D981C", Offset = "0x71D581C", VA = "0x71D981C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4001C5A")]
		[FieldOffset(Offset = "0x0")]
		public static float UIScaleInTime;

		[Token(Token = "0x4001C5B")]
		[FieldOffset(Offset = "0x4")]
		public static float UIFadeOutTime;

		[Token(Token = "0x4001C5C")]
		[FieldOffset(Offset = "0x8")]
		public static float UIScaleOutTime;

		[Token(Token = "0x4001C5D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject canvas;

		[Token(Token = "0x4001C5E")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform UIRoot;

		[Token(Token = "0x4001C5F")]
		[FieldOffset(Offset = "0x30")]
		public Camera UICamera;

		[Token(Token = "0x4001C60")]
		[FieldOffset(Offset = "0x38")]
		public bool UIWindowCanvasSortingOrderBy300;

		[Token(Token = "0x4001C61")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, Transform> _uiNodeList = new Dictionary<string, Transform>();

		[Token(Token = "0x4001C62")]
		[FieldOffset(Offset = "0x48")]
		private WaitForEndOfFrame wait = new WaitForEndOfFrame();

		[Token(Token = "0x4001C63")]
		[FieldOffset(Offset = "0x50")]
		private WaitForSeconds waitAnim5 = new WaitForSeconds(0.5f);

		[Token(Token = "0x4001C64")]
		[FieldOffset(Offset = "0x58")]
		private WaitForSeconds waitAnim3 = new WaitForSeconds(0.3f);

		[Token(Token = "0x4001C65")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, BaseUI> _uiList = new Dictionary<string, BaseUI>();

		[Token(Token = "0x4001C66")]
		[FieldOffset(Offset = "0x10")]
		internal static List<BaseUI> openUIStack;

		[Token(Token = "0x4001C67")]
		[FieldOffset(Offset = "0x68")]
		private Canvas m_canvas;

		[Token(Token = "0x4001C68")]
		[FieldOffset(Offset = "0x70")]
		private GameObject m_loading;

		[Token(Token = "0x4001C69")]
		[FieldOffset(Offset = "0x78")]
		private Assembly assembly;

		[Token(Token = "0x1700115F")]
		internal override int Priority
		{
			[Token(Token = "0x6005F47")]
			[Address(RVA = "0x71D7550", Offset = "0x71D3550", VA = "0x71D7550", Slot = "4")]
			get
			{
					return 40;
				}
		}

		[Token(Token = "0x17001160")]
		public Dictionary<string, BaseUI> UIList
		{
			[Token(Token = "0x6005F52")]
			[Address(RVA = "0x71D822C", Offset = "0x71D422C", VA = "0x71D822C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001161")]
		public Canvas Canvas
		{
			[Token(Token = "0x6005F53")]
			[Address(RVA = "0x71D8234", Offset = "0x71D4234", VA = "0x71D8234")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001162")]
		public GameObject Loading
		{
			[Token(Token = "0x6005F54")]
			[Address(RVA = "0x71D82D0", Offset = "0x71D42D0", VA = "0x71D82D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001163")]
		public static List<BaseUI> OpenUIStack
		{
			[Token(Token = "0x6005F55")]
			[Address(RVA = "0x71D8388", Offset = "0x71D4388", VA = "0x71D8388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005F48")]
		[Address(RVA = "0x71D7558", Offset = "0x71D3558", VA = "0x71D7558", Slot = "5")]
		internal override void Initialize(params object[] arg)
		{
			if (x_0080_008D_00B1f_0086)
			{
			    Àª_00A6_00A3_00BDE?.Invoke();
			    return;
			}
			CLog.ReleaseLog("开始加载UIModule");
			canvas = GameObject.FindGameObjectWithTag("GFUICanvas");
			if (canvas == null)
			    UnityEngine.Debug.LogError("UIcanvas未找到");
			GameObject cameraObject = canvas != null ? canvas.transform.Find("UICamera").gameObject : null;
			if (cameraObject == null)
			    UnityEngine.Debug.LogError("UI相机未找到");
			UICamera = cameraObject?.GetComponent<Camera>();
			UnityEngine.Object.DontDestroyOnLoad(canvas);
			if (AppSetting.UseNewRes)
			    NewResLoadHelper.LoadPrefabOri("UI/UIRoot", LoadUIRootOver<AssetOperationHandle>, Array.Empty<object>());
			else
			{
			    GameFrameEntry.GetModule<ResourcesModule>().LoadPrefab("UI/UIRoot", LoadUIRootOver<ResourcesInfo>, null);
			    GameFrameEntry.GetModule<ResourcesModule>().Update(0f, 0f);
			}
		}

		[Token(Token = "0x6005F49")]
		private void LoadUIRootOver<T>(T resources) where T : IResCallBackInfo
		{
			UIRoot = resources.Instantiate("UIRoot", true).GetComponent<RectTransform>();
			UIRoot.transform.SetParent(canvas.transform);
			UIRoot.localScale = Vector3.one;
			UIRoot.anchorMin = Vector2.zero;
			UIRoot.anchorMax = Vector2.one;
			UIRoot.offsetMin = Vector2.zero;
			UIRoot.offsetMax = Vector2.zero;
			if (AppSetting.IsPortrait && canvas.GetComponent<UnityEngine.UI.CanvasScaler>().matchWidthOrHeight == 1f && AppSetting.isHeightCtrWidthFixedWidth)
			{
			    float width = canvas.GetComponent<RectTransform>().sizeDelta.x;
			    if (width > 720f)
			    {
			        float margin = (width - 720f) * 0.5f;
			        UIRoot.offsetMax = new Vector2(-margin, 0f);
			        UIRoot.offsetMin = new Vector2(margin, 0f);
			    }
			}
			x_0080_008D_00B1f_0086 = true;
			Àª_00A6_00A3_00BDE?.Invoke();
		}

		[Token(Token = "0x6005F4A")]
		[Address(RVA = "0x71D7A38", Offset = "0x71D3A38", VA = "0x71D7A38", Slot = "6")]
		internal override void Start()
		{
		}

		[Token(Token = "0x6005F4B")]
		[Address(RVA = "0x71D7A3C", Offset = "0x71D3A3C", VA = "0x71D7A3C", Slot = "7")]
		internal override void Update(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005F4C")]
		[Address(RVA = "0x71D7A40", Offset = "0x71D3A40", VA = "0x71D7A40", Slot = "9")]
		internal override void Shutdown()
		{
		}

		[Token(Token = "0x6005F4D")]
		[Address(RVA = "0x71D7C04", Offset = "0x71D3C04", VA = "0x71D7C04")]
		public void RefreshLang()
		{
		}

		[Token(Token = "0x6005F4E")]
		[Address(RVA = "0x71D7D14", Offset = "0x71D3D14", VA = "0x71D7D14")]
		public AssetOperationHandle LoadUI(string uiPath, string uiNode, Action<GameObject, AssetOperationHandle> LoadComplete)
		{
			return null;
		}

		[Token(Token = "0x6005F4F")]
		[Address(RVA = "0x71D7E7C", Offset = "0x71D3E7C", VA = "0x71D7E7C")]
		public void LoadUI(string uiPath, string uiNode, Action<GameObject, ResourcesInfo> LoadComplete)
		{
		}

		[Token(Token = "0x6005F50")]
		[Address(RVA = "0x71D7FD4", Offset = "0x71D3FD4", VA = "0x71D7FD4")]
		[IteratorStateMachine(typeof(_003Cwait2Fram_003Ed__19))]
		private IEnumerator wait2Fram(Action action)
		{
			return new _003Cwait2Fram_003Ed__19(0) { action = action };
		}

		[Token(Token = "0x6005F51")]
		[Address(RVA = "0x71D805C", Offset = "0x71D405C", VA = "0x71D805C")]
		public Transform _GetUINode(string node)
		{
			Transform result;
			if (!_uiNodeList.TryGetValue(node, out result))
			{
			    result = UIRoot.transform.Find(node);
			    if (result == null)
			    {
			        CLog.Error("\u672a\u627e\u5230UI\u8282\u70b9:" + node);
			        result = canvas.transform;
			    }
			    _uiNodeList.Add(node, result);
			}
			return result;
		}

		[Token(Token = "0x6005F56")]
		public T Show<T>(params object[] args) where T : BaseUI, new()
		{
			return null;
		}

		[Token(Token = "0x6005F57")]
		[Address(RVA = "0x71D83E0", Offset = "0x71D43E0", VA = "0x71D83E0")]
		public BaseUI Open(string namespaceName, string uiName, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6005F58")]
		public void Close<T>() where T : BaseUI
		{
		}

		[Token(Token = "0x6005F59")]
		public void CloseAllExclude<T>() where T : BaseUI
		{
		}

		[Token(Token = "0x6005F5A")]
		[Address(RVA = "0x71D86B4", Offset = "0x71D46B4", VA = "0x71D86B4")]
		public void CloseAll()
		{
		}

		[Token(Token = "0x6005F5B")]
		[Address(RVA = "0x71D881C", Offset = "0x71D481C", VA = "0x71D881C")]
		public void CloseAllNow()
		{
		}

		[Token(Token = "0x6005F5C")]
		[Address(RVA = "0x71D8984", Offset = "0x71D4984", VA = "0x71D8984")]
		public void CloseForName(string name)
		{
		}

		[Token(Token = "0x6005F5D")]
		public void Refresh<T>() where T : BaseUI
		{
		}

		[Token(Token = "0x6005F5E")]
		public void SetActive<T>(bool isActive) where T : BaseUI
		{
		}

		[Token(Token = "0x6005F5F")]
		public T GetUI<T>() where T : BaseUI
		{
			return null;
		}

		[Token(Token = "0x6005F60")]
		[Address(RVA = "0x71D8A54", Offset = "0x71D4A54", VA = "0x71D8A54")]
		public BaseUI GetUI(string name)
		{
			return null;
		}

		[Token(Token = "0x6005F61")]
		[Address(RVA = "0x71D8AE8", Offset = "0x71D4AE8", VA = "0x71D8AE8")]
		public int GetWindowNum()
		{
			return default;
		}

		[Token(Token = "0x6005F62")]
		[Address(RVA = "0x71D8CB4", Offset = "0x71D4CB4", VA = "0x71D8CB4")]
		[IteratorStateMachine(typeof(_003CUIAnim_003Ed__48))]
		public IEnumerator UIAnim(GameObject target, EUIAnim anim, float customerTime = 0f)
		{
			return null;
		}

		[Token(Token = "0x6005F63")]
		[Address(RVA = "0x71D8D5C", Offset = "0x71D4D5C", VA = "0x71D8D5C")]
		public UIModule()
		{
		}
		[Token(Token = "0x6005F64")]
		[Address(RVA = "0x71D8EA4", Offset = "0x71D4EA4", VA = "0x71D8EA4")]
		static UIModule()
		{
			UIScaleInTime = 0.5f;
			UIFadeOutTime = 0.3f;
			UIScaleOutTime = 0.2f;
			openUIStack = new List<BaseUI>();
		}

	}
}
