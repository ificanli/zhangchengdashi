using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DBTSDK
{
	[Token(Token = "0x20001B7")]
	public class DBTSDKManager : MonoBehaviour
	{
		[Token(Token = "0x20001B8")]
		[CompilerGenerated]
		private sealed class _003CInitSDKOpenFunction_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000593")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000594")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000595")]
			[FieldOffset(Offset = "0x20")]
			public DBTSDKManager _003C_003E4__this;

			[Token(Token = "0x170000EB")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6001542")]
				[Address(RVA = "0x7384E0C", Offset = "0x7380E0C", VA = "0x7384E0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000EC")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6001544")]
				[Address(RVA = "0x7384E4C", Offset = "0x7380E4C", VA = "0x7384E4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600153F")]
			[Address(RVA = "0x7384944", Offset = "0x7380944", VA = "0x7384944")]
			[DebuggerHidden]
			public _003CInitSDKOpenFunction_003Ed__30(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6001540")]
			[Address(RVA = "0x738496C", Offset = "0x738096C", VA = "0x738496C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6001541")]
			[Address(RVA = "0x7384970", Offset = "0x7380970", VA = "0x7384970", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001542")]
			[Address(RVA = "0x7384E0C", Offset = "0x7380E0C", VA = "0x7384E0C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001543")]
			[Address(RVA = "0x7384E14", Offset = "0x7380E14", VA = "0x7384E14", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6001544")]
			[Address(RVA = "0x7384E4C", Offset = "0x7380E4C", VA = "0x7384E4C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400057E")]
		private const string adsObjName = "DBTSDKManager";

		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_SdkGameObject;

		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x28")]
		internal ISDK otherPlatformSdk;

		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x34")]
		public int useBugSystemType;

		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x0")]
		private static DBTSDKManager m_Instance;

		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x8")]
		public static bool useCommonGameActHelper = true;

		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x38")]
		private Action<string> onBackPressed;

		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x40")]
		private Action<string> StartGame;

		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x48")]
		internal bool IsInstance;

		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<SDKOpenFunction, bool> dicFunctionState;

		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<SDKOpenFunction, List<Button>> dicFunctionBtns;

		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<SDKOpenFunction, UnityAction> dicFunctionAction;

		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x9")]
		public static bool CloseAdsTips = false;

		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x10")]
		private static string VideoCallBackCode = "code";

		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x68")]
		private Queue<SDKCallbackData> m_CallBackQueue;

		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x70")]
		private float touchPointY;

		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x74")]
		private float minTouchPoint;

		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x78")]
		private float maxTouchPoint;

		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x7C")]
		private int EffectiveClick;

		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x80")]
		private float ClearTimer;

		[Token(Token = "0x170000E6")]
		internal static bool IsIgnoreSDK
		{
			[Token(Token = "0x600150F")]
			[Address(RVA = "0x7381760", Offset = "0x737D760", VA = "0x7381760")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E7")]
		internal static bool IsXYXNativeMode
		{
			[Token(Token = "0x6001510")]
			[Address(RVA = "0x73817B8", Offset = "0x737D7B8", VA = "0x73817B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E8")]
		public bool IsIgnoreBackKey
		{
			[Token(Token = "0x6001511")]
			[Address(RVA = "0x7381808", Offset = "0x737D808", VA = "0x7381808")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6001512")]
			[Address(RVA = "0x7381810", Offset = "0x737D810", VA = "0x7381810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public static DBTSDKManager Instance
		{
			[Token(Token = "0x6001513")]
			[Address(RVA = "0x738181C", Offset = "0x737D81C", VA = "0x738181C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EA")]
		public ISDK OtherPlatformSdk
		{
			[Token(Token = "0x6001514")]
			[Address(RVA = "0x73819CC", Offset = "0x737D9CC", VA = "0x73819CC")]
			set
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event Action<string> BackPressed
		{
			[Token(Token = "0x6001515")]
			[Address(RVA = "0x7381ADC", Offset = "0x737DADC", VA = "0x7381ADC")]
			add
			{
			}
			[Token(Token = "0x6001516")]
			[Address(RVA = "0x7381B84", Offset = "0x737DB84", VA = "0x7381B84")]
			remove
			{
			}
		}

		[Token(Token = "0x6001517")]
		[Address(RVA = "0x7381C2C", Offset = "0x737DC2C", VA = "0x7381C2C")]
		public static void InitSDK()
		{
		}

		[Token(Token = "0x6001518")]
		[Address(RVA = "0x7381F4C", Offset = "0x737DF4C", VA = "0x7381F4C")]
		public void InitDBTSDK()
		{
		}

		[Token(Token = "0x6001519")]
		internal void AddSdkMonoComponent<T>() where T : Component
		{
		}

		[Token(Token = "0x600151A")]
		[Address(RVA = "0x7382070", Offset = "0x737E070", VA = "0x7382070")]
		[IteratorStateMachine(typeof(_003CInitSDKOpenFunction_003Ed__30))]
		protected IEnumerator InitSDKOpenFunction()
		{
			return null;
		}

		[Token(Token = "0x600151B")]
		[Address(RVA = "0x73820D8", Offset = "0x737E0D8", VA = "0x73820D8")]
		public void CheckVideoIsReady()
		{
		}

		[Token(Token = "0x600151C")]
		[Address(RVA = "0x738215C", Offset = "0x737E15C", VA = "0x738215C")]
		public void ChangeVideoBtnState(bool IsReady)
		{
		}

		[Token(Token = "0x600151D")]
		[Address(RVA = "0x7382834", Offset = "0x737E834", VA = "0x7382834")]
		private void SetButtonGay(Button btn, bool i)
		{
		}

		[Token(Token = "0x600151E")]
		[Address(RVA = "0x7382838", Offset = "0x737E838", VA = "0x7382838")]
		public void BindFunctionBtn(SDKOpenFunction sDKOpenFunction, Button[] buttons, params object[] Args)
		{
		}

		[Token(Token = "0x600151F")]
		[Address(RVA = "0x7382AE0", Offset = "0x737EAE0", VA = "0x7382AE0")]
		private void ReshsdkFunctionBtnState(SDKOpenFunction sDKOpenFunction)
		{
		}

		[Token(Token = "0x6001520")]
		[Address(RVA = "0x7382704", Offset = "0x737E704", VA = "0x7382704")]
		private void CheckNull(SDKOpenFunction sDKOpenFunction)
		{
		}

		[Token(Token = "0x6001521")]
		[Address(RVA = "0x7382CF4", Offset = "0x737ECF4", VA = "0x7382CF4")]
		public bool GetSDKOpenFunctionState(SDKOpenFunction sDKOpenFunction, bool IsRefresh)
		{
			return default;
		}

		[Token(Token = "0x6001522")]
		[Address(RVA = "0x7382448", Offset = "0x737E448", VA = "0x7382448")]
		private void SetSDKFunctionState(SDKOpenFunction function, bool state)
		{
		}

		[Token(Token = "0x6001523")]
		[Address(RVA = "0x7382F90", Offset = "0x737EF90", VA = "0x7382F90")]
		private bool GetState(SDKOpenFunction function)
		{
			return default;
		}

		[Token(Token = "0x6001524")]
		[Address(RVA = "0x7383394", Offset = "0x737F394", VA = "0x7383394")]
		public void AdsVideoFunction()
		{
		}

		[Token(Token = "0x6001525")]
		[Address(RVA = "0x7383488", Offset = "0x737F488", VA = "0x7383488")]
		private void ShowShareFunction()
		{
		}

		[Token(Token = "0x6001526")]
		[Address(RVA = "0x738348C", Offset = "0x737F48C", VA = "0x738348C")]
		private void ShowLoginFunction()
		{
		}

		[Token(Token = "0x6001527")]
		[Address(RVA = "0x73834E4", Offset = "0x737F4E4", VA = "0x73834E4")]
		private void FeedbackFunction()
		{
		}

		[Token(Token = "0x6001528")]
		[Address(RVA = "0x7383538", Offset = "0x737F538", VA = "0x7383538")]
		private void GDPRUserFunction()
		{
		}

		[Token(Token = "0x6001529")]
		[Address(RVA = "0x738358C", Offset = "0x737F58C", VA = "0x738358C")]
		private void ShowPolicyFunction()
		{
		}

		[Token(Token = "0x600152A")]
		[Address(RVA = "0x73835E0", Offset = "0x737F5E0", VA = "0x73835E0")]
		private void ShowUserProtocolFunction()
		{
		}

		[Token(Token = "0x600152B")]
		[Address(RVA = "0x7383634", Offset = "0x737F634", VA = "0x7383634")]
		private void ShowGameBanHaoFunction()
		{
		}

		[Token(Token = "0x600152C")]
		[Address(RVA = "0x7383688", Offset = "0x737F688", VA = "0x7383688")]
		private void StartRestore()
		{
		}

		[Token(Token = "0x600152D")]
		[Address(RVA = "0x73836DC", Offset = "0x737F6DC", VA = "0x73836DC")]
		private void ShowOppoGameCenter()
		{
		}

		[Token(Token = "0x600152E")]
		[Address(RVA = "0x7383730", Offset = "0x737F730", VA = "0x7383730")]
		private void DrawVideo()
		{
		}

		[Token(Token = "0x600152F")]
		[Address(RVA = "0x7383784", Offset = "0x737F784", VA = "0x7383784")]
		private void OpenPrivacyRecall()
		{
		}

		[Token(Token = "0x6001530")]
		[Address(RVA = "0x73837D8", Offset = "0x737F7D8", VA = "0x73837D8")]
		public void onBackPressedCallback(string data)
		{
		}

		[Token(Token = "0x6001531")]
		[Address(RVA = "0x738397C", Offset = "0x737F97C", VA = "0x738397C")]
		public void onBackPressedCallbackIOS(string data)
		{
		}

		[Token(Token = "0x6001532")]
		[Address(RVA = "0x73837FC", Offset = "0x737F7FC", VA = "0x73837FC")]
		private void DataParse(Dictionary<string, object> dicDic)
		{
		}

		[Token(Token = "0x6001533")]
		[Address(RVA = "0x73839A0", Offset = "0x737F9A0", VA = "0x73839A0")]
		public void AdddStartGameAction(Action<string> callBack)
		{
		}

		[Token(Token = "0x6001534")]
		[Address(RVA = "0x73839A8", Offset = "0x737F9A8", VA = "0x73839A8")]
		public void showUnityGame(string data)
		{
		}

		[Token(Token = "0x6001535")]
		[Address(RVA = "0x7383A9C", Offset = "0x737FA9C", VA = "0x7383A9C")]
		internal void notifyScreenSizeChanged(string data)
		{
		}

		[Token(Token = "0x6001536")]
		[Address(RVA = "0x7383BB4", Offset = "0x737FBB4", VA = "0x7383BB4")]
		private void applicationWillResignActive()
		{
		}

		[Token(Token = "0x6001537")]
		[Address(RVA = "0x7383BF8", Offset = "0x737FBF8", VA = "0x7383BF8")]
		internal void isRequestLocationInEeaOrUnknownCallback(string data)
		{
		}

		[Token(Token = "0x6001538")]
		[Address(RVA = "0x7383E78", Offset = "0x737FE78", VA = "0x7383E78")]
		private void SDKCallBack(string data)
		{
		}

		[Token(Token = "0x6001539")]
		[Address(RVA = "0x7384234", Offset = "0x7380234", VA = "0x7384234")]
		private void UpdateSDKCallBack()
		{
		}

		[Token(Token = "0x600153A")]
		[Address(RVA = "0x7384398", Offset = "0x7380398", VA = "0x7384398")]
		private void Update()
		{
		}

		[Token(Token = "0x600153B")]
		[Address(RVA = "0x738444C", Offset = "0x738044C", VA = "0x738444C")]
		private void CheckTestMode()
		{
		}

		[Token(Token = "0x600153C")]
		[Address(RVA = "0x73846A0", Offset = "0x73806A0", VA = "0x73846A0")]
		internal void Shutdown()
		{
		}

		[Token(Token = "0x600153D")]
		[Address(RVA = "0x7384764", Offset = "0x7380764", VA = "0x7384764")]
		public DBTSDKManager()
		{
		}
	}
}
