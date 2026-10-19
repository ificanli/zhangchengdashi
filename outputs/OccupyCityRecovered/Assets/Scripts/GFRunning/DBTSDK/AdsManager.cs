using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DBTSDK
{
	[Token(Token = "0x20001D1")]
	public class AdsManager : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001D2")]
		[CompilerGenerated]
		private struct _003CNotifyScreenSizeChanged_003Ed__60 : IAsyncStateMachine
		{
			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AdsManager _003C_003E4__this;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60017EF")]
			[Address(RVA = "0x739BB14", Offset = "0x7397B14", VA = "0x739BB14", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60017F0")]
			[Address(RVA = "0x739BF54", Offset = "0x7397F54", VA = "0x739BF54", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001D3")]
		[CompilerGenerated]
		private struct _003CShowVide_003Ed__36 : IAsyncStateMachine
		{
			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VideFlag videFlag;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AdsManager _003C_003E4__this;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<string, bool> CallBack;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int id;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private int _003CFlag_003E5__2;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60017F1")]
			[Address(RVA = "0x739BF60", Offset = "0x7397F60", VA = "0x739BF60", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60017F2")]
			[Address(RVA = "0x739C4CC", Offset = "0x73984CC", VA = "0x739C4CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20001D4")]
		[CompilerGenerated]
		private sealed class _003CWait05_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AdsManager _003C_003E4__this;

			[Token(Token = "0x170000FB")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60017F6")]
				[Address(RVA = "0x739C680", Offset = "0x7398680", VA = "0x739C680", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000FC")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60017F8")]
				[Address(RVA = "0x739C6C0", Offset = "0x73986C0", VA = "0x739C6C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60017F3")]
			[Address(RVA = "0x73956D0", Offset = "0x73916D0", VA = "0x73956D0")]
			[DebuggerHidden]
			public _003CWait05_003Ed__22(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60017F4")]
			[Address(RVA = "0x739C4D8", Offset = "0x73984D8", VA = "0x739C4D8", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60017F5")]
			[Address(RVA = "0x739C4DC", Offset = "0x73984DC", VA = "0x739C4DC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60017F6")]
			[Address(RVA = "0x739C680", Offset = "0x7398680", VA = "0x739C680", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60017F7")]
			[Address(RVA = "0x739C688", Offset = "0x7398688", VA = "0x739C688", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60017F8")]
			[Address(RVA = "0x739C6C0", Offset = "0x73986C0", VA = "0x739C6C0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal string GameName;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action<string, bool> videoPlayAction;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsOpenAdsRepory;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ImmersiveAdConfig immersiveAdConfig;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool forceJumpVideo;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float FirstInterstTimes;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static AdsManager Instance;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action<bool> m_InterstPlayCallBack;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action m_InterstCloseCallBack;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject eventSystem;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ShowVideoInterval;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private WaitForSecondsRealtime wait2;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int[] TitleColor;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int[] ActionBackgroundColor;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int[] ActionColor;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int InformationFlowscene;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int InformationFlowID;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool isUseNewInfoFlow;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int currInformationFlowId;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RectTransform LstInformationFlowRoot;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action<ImmersiveAdConfig> m_immersiveAdConfig;

		[Token(Token = "0x170000FA")]
		public bool ForceJumpVideo
		{
			[Token(Token = "0x60017A1")]
			[Address(RVA = "0x7394D7C", Offset = "0x7390D7C", VA = "0x7394D7C")]
			set
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event Action<bool> InterstPlayCallBack
		{
			[Token(Token = "0x60017A5")]
			[Address(RVA = "0x739509C", Offset = "0x739109C", VA = "0x739509C")]
			add
			{
			}
			[Token(Token = "0x60017A6")]
			[Address(RVA = "0x7395144", Offset = "0x7391144", VA = "0x7395144")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event Action InterstCloseCallBack
		{
			[Token(Token = "0x60017A7")]
			[Address(RVA = "0x73951EC", Offset = "0x73911EC", VA = "0x73951EC")]
			add
			{
			}
			[Token(Token = "0x60017A8")]
			[Address(RVA = "0x739526C", Offset = "0x739126C", VA = "0x739526C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event Action<ImmersiveAdConfig> ImmersiveAdConfigCallBack
		{
			[Token(Token = "0x60017C8")]
			[Address(RVA = "0x73999CC", Offset = "0x73959CC", VA = "0x73999CC")]
			add
			{
			}
			[Token(Token = "0x60017C9")]
			[Address(RVA = "0x7399A94", Offset = "0x7395A94", VA = "0x7399A94")]
			remove
			{
			}
		}

		[Token(Token = "0x60017A2")]
		[Address(RVA = "0x7394D88", Offset = "0x7390D88", VA = "0x7394D88")]
		private void Awake()
		{
		}

		[Token(Token = "0x60017A3")]
		[Address(RVA = "0x7394DD4", Offset = "0x7390DD4", VA = "0x7394DD4")]
		public void ShowBanner(int Pos = 1, bool filterHighMemorySDK = true)
		{
		}

		[Token(Token = "0x60017A4")]
		[Address(RVA = "0x7394F74", Offset = "0x7390F74", VA = "0x7394F74")]
		public void HideBanner()
		{
		}

		[Token(Token = "0x60017A9")]
		[Address(RVA = "0x73952EC", Offset = "0x73912EC", VA = "0x73952EC")]
		[Obsolete("老版本插屏接口，请用ShowInterstNew替换")]
		public void ShowInterst(bool IsPauseGame = true)
		{
		}

		[Token(Token = "0x60017AA")]
		[Address(RVA = "0x7395670", Offset = "0x7391670", VA = "0x7395670")]
		[IteratorStateMachine(typeof(_003CWait05_003Ed__22))]
		private IEnumerator Wait05()
		{
			return null;
		}

		[Token(Token = "0x60017AB")]
		[Address(RVA = "0x7395374", Offset = "0x7391374", VA = "0x7395374")]
		private bool CheckCanShowInterst()
		{
			return default;
		}

		[Token(Token = "0x60017AC")]
		[Address(RVA = "0x73956F8", Offset = "0x73916F8", VA = "0x73956F8")]
		public void ShowInterstNew(string interName, bool IsPauseGame = true)
		{
		}

		[Token(Token = "0x60017AD")]
		[Address(RVA = "0x7395CE4", Offset = "0x7391CE4", VA = "0x7395CE4")]
		public bool IsCanShowInters()
		{
			return default;
		}

		[Token(Token = "0x60017AE")]
		[Address(RVA = "0x7395D68", Offset = "0x7391D68", VA = "0x7395D68")]
		public bool IsCanShowTimerInters()
		{
			return default;
		}

		[Token(Token = "0x60017AF")]
		[Address(RVA = "0x7395DB0", Offset = "0x7391DB0", VA = "0x7395DB0")]
		public void ShowTimerInterst(string interName, bool IsPauseGame = true)
		{
		}

		[Token(Token = "0x60017B0")]
		[Address(RVA = "0x7395D2C", Offset = "0x7391D2C", VA = "0x7395D2C")]
		private bool IsCanShowInters(string mtype)
		{
			return default;
		}

		[Token(Token = "0x60017B1")]
		[Address(RVA = "0x7395E74", Offset = "0x7391E74", VA = "0x7395E74")]
		internal void showInterstitialResult(string data)
		{
		}

		[Token(Token = "0x60017B2")]
		[Address(RVA = "0x7396058", Offset = "0x7392058", VA = "0x7396058")]
		internal void showInterstitialClose()
		{
		}

		[Token(Token = "0x60017B3")]
		[Address(RVA = "0x739614C", Offset = "0x739214C", VA = "0x739614C")]
		public void SetFirstInterstTimes(float tiems)
		{
		}

		[Token(Token = "0x60017B4")]
		[Address(RVA = "0x7396154", Offset = "0x7392154", VA = "0x7396154")]
		public bool IsCanShowVideo()
		{
			return default;
		}

		[Token(Token = "0x60017B5")]
		[Address(RVA = "0x739639C", Offset = "0x739239C", VA = "0x739639C")]
		public bool isVideoReady()
		{
			return default;
		}

		[Token(Token = "0x60017B6")]
		[Address(RVA = "0x73967A8", Offset = "0x73927A8", VA = "0x73967A8")]
		[AsyncStateMachine(typeof(_003CShowVide_003Ed__36))]
		public void ShowVide(VideFlag videFlag, Action<string, bool> CallBack, int id = 0)
		{
		}

		[Token(Token = "0x60017B7")]
		[Address(RVA = "0x739685C", Offset = "0x739285C", VA = "0x739685C")]
		public void SetRemoveAds_M()
		{
		}

		[Token(Token = "0x60017B8")]
		[Address(RVA = "0x7396C54", Offset = "0x7392C54", VA = "0x7396C54")]
		public int GetRemoveAdsState_Override()
		{
			return default;
		}

		[Token(Token = "0x60017B9")]
		[Address(RVA = "0x7394E10", Offset = "0x7390E10", VA = "0x7394E10")]
		public bool IsOpenRemoveAds_Override()
		{
			return default;
		}

		[Token(Token = "0x60017BA")]
		[Address(RVA = "0x7396DDC", Offset = "0x7392DDC", VA = "0x7396DDC")]
		public void SetRestoreAdsStatic_Override()
		{
		}

		[Token(Token = "0x60017BB")]
		[Address(RVA = "0x7396F9C", Offset = "0x7392F9C", VA = "0x7396F9C")]
		internal void afterVideo(string data)
		{
		}

		[Token(Token = "0x60017BC")]
		[Address(RVA = "0x73973F8", Offset = "0x73933F8", VA = "0x73973F8")]
		private void afterVideoFailed(string videoFlag)
		{
		}

		[Token(Token = "0x60017BD")]
		[Address(RVA = "0x7397048", Offset = "0x7393048", VA = "0x7397048")]
		private void DataParesAfterVide(Dictionary<string, object> dicDic)
		{
		}

		[Token(Token = "0x60017BE")]
		[Address(RVA = "0x73974FC", Offset = "0x73934FC", VA = "0x73974FC")]
		internal void setVideoButtonStatus(string data)
		{
		}

		[Token(Token = "0x60017BF")]
		[Address(RVA = "0x7397518", Offset = "0x7393518", VA = "0x7397518")]
		private void DataParesSetVideoButtonStatus(Dictionary<string, object> dicDic)
		{
		}

		[Token(Token = "0x60017C0")]
		[Address(RVA = "0x73978BC", Offset = "0x73938BC", VA = "0x73978BC")]
		public void SetInformationFlowUIColor(int titleColorR, int titleColorG, int titleColorB, int actionBackgroundColorR, int actionBackgroundColorG, int actionBackgroundColorB, int actionColorR, int actionColorG, int actionColorB)
		{
		}

		[Token(Token = "0x60017C1")]
		[Address(RVA = "0x739795C", Offset = "0x739395C", VA = "0x739795C")]
		[Obsolete("请用ShowInformationFlowNew替换")]
		public int ShowInformationFlow(RectTransform InformationFlowRoot)
		{
			return default;
		}

		[Token(Token = "0x60017C2")]
		[Address(RVA = "0x7398614", Offset = "0x7394614", VA = "0x7398614")]
		public int ShowInformationFlowNew(RectTransform InformationFlowRoot, int SceneId = 2)
		{
			return default;
		}

		[Token(Token = "0x60017C3")]
		[Address(RVA = "0x7398324", Offset = "0x7394324", VA = "0x7398324")]
		private int[] CalculationPlatformRect(Vector2[] Points)
		{
			return null;
		}

		[Token(Token = "0x60017C4")]
		[Address(RVA = "0x7398BF0", Offset = "0x7394BF0", VA = "0x7398BF0")]
		public void RemoveInformationFlow(int id)
		{
		}

		[Token(Token = "0x60017C5")]
		[Address(RVA = "0x7398E58", Offset = "0x7394E58", VA = "0x7398E58")]
		internal void requestGameOverBigAdsCallback(string data)
		{
		}

		[Token(Token = "0x60017C6")]
		[Address(RVA = "0x73993D8", Offset = "0x73953D8", VA = "0x73993D8")]
		[AsyncStateMachine(typeof(_003CNotifyScreenSizeChanged_003Ed__60))]
		internal void NotifyScreenSizeChanged()
		{
		}

		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x7399468", Offset = "0x7395468", VA = "0x7399468")]
		public void ShowNatGameAd(RectTransform imageRectTransform)
		{
		}

		[Token(Token = "0x60017CA")]
		[Address(RVA = "0x7399B3C", Offset = "0x7395B3C", VA = "0x7399B3C")]
		internal void setAdConfig(string data)
		{
		}

		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x7399E48", Offset = "0x7395E48", VA = "0x7399E48")]
		private void Start()
		{
		}

		[Token(Token = "0x60017CC")]
		[Address(RVA = "0x7399E4C", Offset = "0x7395E4C", VA = "0x7399E4C")]
		internal void ShowBannerStatic(int pos)
		{
		}

		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x7394E28", Offset = "0x7390E28", VA = "0x7394E28")]
		public void ShowBannerStatic(int pos, bool filterHighMemorySDK)
		{
		}

		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x7394F78", Offset = "0x7390F78", VA = "0x7394F78")]
		internal void HideBannerStatic()
		{
		}

		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x7395540", Offset = "0x7391540", VA = "0x7395540")]
		internal void ShowInterstitialStatic(string game)
		{
		}

		[Token(Token = "0x60017D0")]
		[Address(RVA = "0x7396274", Offset = "0x7392274", VA = "0x7396274")]
		internal bool IsShowVideoStatic()
		{
			return default;
		}

		[Token(Token = "0x60017D1")]
		[Address(RVA = "0x7396680", Offset = "0x7392680", VA = "0x7396680")]
		internal bool IsVideoReadyStatic()
		{
			return default;
		}

		[Token(Token = "0x60017D2")]
		[Address(RVA = "0x7399F7C", Offset = "0x7395F7C", VA = "0x7399F7C")]
		internal void ShowVideoStatic(int flag, int tag)
		{
		}

		[Token(Token = "0x60017D3")]
		[Address(RVA = "0x73981D4", Offset = "0x73941D4", VA = "0x73981D4")]
		internal int GetAdsStatusStatic(int scene, int id)
		{
			return default;
		}

		[Token(Token = "0x60017D4")]
		[Address(RVA = "0x739844C", Offset = "0x739444C", VA = "0x739844C")]
		internal int ShowAdsStatic(int scene, int id, int[] rootRect, int[] pictureRect, int[] footerRect, int[] titleColor, int[] actionBackgroundColor, int[] actionColor)
		{
			return default;
		}

		[Token(Token = "0x60017D5")]
		[Address(RVA = "0x7398D28", Offset = "0x7394D28", VA = "0x7398D28")]
		internal void RemoveAdsWidgetStatic(int index)
		{
		}

		[Token(Token = "0x60017D6")]
		[Address(RVA = "0x739A0C4", Offset = "0x73960C4", VA = "0x739A0C4")]
		public void SetAdsVisibleStatic(int index, bool visible)
		{
		}

		[Token(Token = "0x60017D7")]
		[Address(RVA = "0x7396B30", Offset = "0x7392B30", VA = "0x7396B30")]
		internal void SetRemoveAdsStatic()
		{
		}

		[Token(Token = "0x60017D8")]
		[Address(RVA = "0x7396A08", Offset = "0x7392A08", VA = "0x7396A08")]
		public int GetRemoveAdsState()
		{
			return default;
		}

		[Token(Token = "0x60017D9")]
		[Address(RVA = "0x739A210", Offset = "0x7396210", VA = "0x739A210")]
		public bool IsOpenRemoveAds()
		{
			return default;
		}

		[Token(Token = "0x60017DA")]
		[Address(RVA = "0x7396E78", Offset = "0x7392E78", VA = "0x7396E78")]
		public void SetRestoreAdsStatic()
		{
		}

		[Token(Token = "0x60017DB")]
		[Address(RVA = "0x739A338", Offset = "0x7396338", VA = "0x739A338")]
		public int GetVideoStatus()
		{
			return default;
		}

		[Token(Token = "0x60017DC")]
		[Address(RVA = "0x739A460", Offset = "0x7396460", VA = "0x739A460")]
		public float GetBannerSizeScale(int pos)
		{
			return default;
		}

		[Token(Token = "0x60017DD")]
		[Address(RVA = "0x739A594", Offset = "0x7396594", VA = "0x739A594")]
		public bool DelayShowBigAdsStatic()
		{
			return default;
		}

		[Token(Token = "0x60017DE")]
		[Address(RVA = "0x739A6BC", Offset = "0x73966BC", VA = "0x739A6BC")]
		public void RequestGameOverBigAdsStatic()
		{
		}

		[Token(Token = "0x60017DF")]
		[Address(RVA = "0x739A7E0", Offset = "0x73967E0", VA = "0x739A7E0")]
		public int GetDrawVideoButtonStatusStatic()
		{
			return default;
		}

		[Token(Token = "0x60017E0")]
		[Address(RVA = "0x739A9EC", Offset = "0x73969EC", VA = "0x739A9EC")]
		public void ShowDrawVideoStatic()
		{
		}

		[Token(Token = "0x60017E1")]
		[Address(RVA = "0x73957BC", Offset = "0x73917BC", VA = "0x73957BC")]
		internal bool ShowInterstitialResult(string game, string interName, string mtype)
		{
			return default;
		}

		[Token(Token = "0x60017E2")]
		[Address(RVA = "0x7395AAC", Offset = "0x7391AAC", VA = "0x7395AAC")]
		internal bool IsInterstitialReadyStatic(string game, string mtype)
		{
			return default;
		}

		[Token(Token = "0x60017E3")]
		[Address(RVA = "0x739ABA4", Offset = "0x7396BA4", VA = "0x739ABA4")]
		internal void RequestVideoStatic(int flag)
		{
		}

		[Token(Token = "0x60017E4")]
		[Address(RVA = "0x739ADAC", Offset = "0x7396DAC", VA = "0x739ADAC")]
		public bool IsCustomVideoReadyStatic(int flag)
		{
			return default;
		}

		[Token(Token = "0x60017E5")]
		[Address(RVA = "0x739AFFC", Offset = "0x7396FFC", VA = "0x739AFFC")]
		internal void SetRemoveVideoAdsStatic()
		{
		}

		[Token(Token = "0x60017E6")]
		[Address(RVA = "0x739B1B4", Offset = "0x73971B4", VA = "0x739B1B4")]
		internal int GetRemoveVideoAdsState()
		{
			return default;
		}

		[Token(Token = "0x60017E7")]
		[Address(RVA = "0x739B3C0", Offset = "0x73973C0", VA = "0x739B3C0")]
		public void SetRestoreVideoAdsStatic()
		{
		}

		[Token(Token = "0x60017E8")]
		[Address(RVA = "0x7396568", Offset = "0x7392568", VA = "0x7396568")]
		public bool IsVideoDefaultShowStatic()
		{
			return default;
		}

		[Token(Token = "0x60017E9")]
		[Address(RVA = "0x739B578", Offset = "0x7397578", VA = "0x739B578")]
		public void ShowIconAds()
		{
		}

		[Token(Token = "0x60017EA")]
		[Address(RVA = "0x739B68C", Offset = "0x739768C", VA = "0x739B68C")]
		public void AdsGameAdStatusCallBack(string upType, string pid, string revenue)
		{
		}

		[Token(Token = "0x60017EB")]
		[Address(RVA = "0x7399858", Offset = "0x7395858", VA = "0x7399858")]
		internal void ShowNatGameAd(float topX, float topY, float maxWith, float maxHeight)
		{
		}

		[Token(Token = "0x60017EC")]
		[Address(RVA = "0x739B7E4", Offset = "0x73977E4", VA = "0x739B7E4")]
		public void HideNatGameAd()
		{
		}

		[Token(Token = "0x60017ED")]
		[Address(RVA = "0x739B908", Offset = "0x7397908", VA = "0x739B908")]
		public string GetRewardAd()
		{
			return null;
		}

		[Token(Token = "0x60017EE")]
		[Address(RVA = "0x739BA30", Offset = "0x7397A30", VA = "0x739BA30")]
		public AdsManager()
		{
		}
	}
}
