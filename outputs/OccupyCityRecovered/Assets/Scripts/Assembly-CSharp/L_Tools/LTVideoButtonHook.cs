using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameFramework.SDK;
using GameFramework.Tools;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace L_Tools
{
	[Token(Token = "0x2000F83")]
	public class LTVideoButtonHook : MonoBehaviour, IDBTVideoBtn, IPointerClickHandler, IEventSystemHandler
	{
		[Token(Token = "0x2000F85")]
		[CompilerGenerated]
		private sealed class _003CDelayOnEnable_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006ADE")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006ADF")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006AE0")]
			[FieldOffset(Offset = "0x20")]
			public LTVideoButtonHook _003C_003E4__this;

			[Token(Token = "0x17000F94")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005D20")]
				[Address(RVA = "0x43B6698", Offset = "0x43B2698", VA = "0x43B6698", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000F95")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005D22")]
				[Address(RVA = "0x43B66D8", Offset = "0x43B26D8", VA = "0x43B66D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005D1D")]
			[Address(RVA = "0x43B5364", Offset = "0x43B1364", VA = "0x43B5364")]
			[DebuggerHidden]
			public _003CDelayOnEnable_003Ed__22(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005D1E")]
			[Address(RVA = "0x43B6570", Offset = "0x43B2570", VA = "0x43B6570", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005D1F")]
			[Address(RVA = "0x43B6574", Offset = "0x43B2574", VA = "0x43B6574", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005D20")]
			[Address(RVA = "0x43B6698", Offset = "0x43B2698", VA = "0x43B6698", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005D21")]
			[Address(RVA = "0x43B66A0", Offset = "0x43B26A0", VA = "0x43B66A0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005D22")]
			[Address(RVA = "0x43B66D8", Offset = "0x43B26D8", VA = "0x43B66D8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000F86")]
		[CompilerGenerated]
		private sealed class _003CDelayReport_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006AE1")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006AE2")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006AE3")]
			[FieldOffset(Offset = "0x20")]
			public int n;

			[Token(Token = "0x4006AE4")]
			[FieldOffset(Offset = "0x28")]
			public LTVideoButtonHook _003C_003E4__this;

			[Token(Token = "0x17000F96")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005D26")]
				[Address(RVA = "0x43B67B4", Offset = "0x43B27B4", VA = "0x43B67B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000F97")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005D28")]
				[Address(RVA = "0x43B67F4", Offset = "0x43B27F4", VA = "0x43B67F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005D23")]
			[Address(RVA = "0x43B62E4", Offset = "0x43B22E4", VA = "0x43B62E4")]
			[DebuggerHidden]
			public _003CDelayReport_003Ed__43(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005D24")]
			[Address(RVA = "0x43B66E0", Offset = "0x43B26E0", VA = "0x43B66E0", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005D25")]
			[Address(RVA = "0x43B66E4", Offset = "0x43B26E4", VA = "0x43B66E4", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005D26")]
			[Address(RVA = "0x43B67B4", Offset = "0x43B27B4", VA = "0x43B67B4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005D27")]
			[Address(RVA = "0x43B67BC", Offset = "0x43B27BC", VA = "0x43B67BC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005D28")]
			[Address(RVA = "0x43B67F4", Offset = "0x43B27F4", VA = "0x43B67F4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006AC6")]
		[FieldOffset(Offset = "0x20")]
		private VideoBtnEvent _btnOnClick;

		[Token(Token = "0x4006AC7")]
		[FieldOffset(Offset = "0x28")]
		private VideoBtnEvent _videoPlayCallBack;

		[Token(Token = "0x4006AC8")]
		[FieldOffset(Offset = "0x30")]
		private BtnState _btnState;

		[Token(Token = "0x4006AC9")]
		[FieldOffset(Offset = "0x34")]
		public int videoID;

		[Token(Token = "0x4006ACA")]
		[FieldOffset(Offset = "0x38")]
		protected VideoBtnData videoBtnData;

		[Token(Token = "0x4006ACB")]
		[FieldOffset(Offset = "0x40")]
		private BtnReportState _btnReportState;

		[Token(Token = "0x4006ACC")]
		[FieldOffset(Offset = "0x44")]
		private bool _isCanShowAdsVideo;

		[Token(Token = "0x4006ACD")]
		[FieldOffset(Offset = "0x48")]
		private Coroutine _delayOnEnable;

		[Token(Token = "0x4006ACE")]
		[FieldOffset(Offset = "0x50")]
		public bool AutoCallBtnShow;

		[Token(Token = "0x4006ACF")]
		[FieldOffset(Offset = "0x58")]
		private string _reportLabel;

		[Token(Token = "0x4006AD0")]
		[FieldOffset(Offset = "0x60")]
		private string _videoParam1;

		[Token(Token = "0x4006AD1")]
		[FieldOffset(Offset = "0x68")]
		private string _videoParam2;

		[Token(Token = "0x4006AD2")]
		[FieldOffset(Offset = "0x70")]
		public bool NeedCallGameLogin;

		[Token(Token = "0x4006AD3")]
		[FieldOffset(Offset = "0x78")]
		private Button _button;

		[Token(Token = "0x4006AD4")]
		[FieldOffset(Offset = "0x80")]
		private bool _isFree;

		[Token(Token = "0x4006AD5")]
		[FieldOffset(Offset = "0x81")]
		private bool _isDestroy;

		[Token(Token = "0x4006AD6")]
		private const int PlayVideoCd = 5;

		[Token(Token = "0x4006AD7")]
		private const int ClickBtnCd = 1;

		[Token(Token = "0x4006AD8")]
		[FieldOffset(Offset = "0x0")]
		private static bool _isPlayVideo;

		[Token(Token = "0x4006AD9")]
		[FieldOffset(Offset = "0x4")]
		private static float _playVideoTimer;

		[Token(Token = "0x4006ADA")]
		[FieldOffset(Offset = "0x82")]
		private bool _isClickVideo;

		[Token(Token = "0x4006ADB")]
		[FieldOffset(Offset = "0x84")]
		private float _clickVideoTimer;

		[Token(Token = "0x6005CFB")]
		[Address(RVA = "0x43B4FA0", Offset = "0x43B0FA0", VA = "0x43B4FA0")]
		protected void Awake()
		{
		}

		[Token(Token = "0x6005CFC")]
		[Address(RVA = "0x43B507C", Offset = "0x43B107C", VA = "0x43B507C")]
		public void SetButtonNode(Button btn)
		{
		}

		[Token(Token = "0x6005CFD")]
		[Address(RVA = "0x43B5084", Offset = "0x43B1084", VA = "0x43B5084")]
		public void ResetVideoBtnData(int id)
		{
		}

		[Token(Token = "0x6005CFE")]
		[Address(RVA = "0x43B4FE8", Offset = "0x43B0FE8", VA = "0x43B4FE8")]
		private void GetVideoBtnData()
		{
		}

		[Token(Token = "0x6005CFF")]
		[Address(RVA = "0x43B51F4", Offset = "0x43B11F4", VA = "0x43B51F4")]
		protected void Start()
		{
		}

		[Token(Token = "0x6005D00")]
		[Address(RVA = "0x43B52A0", Offset = "0x43B12A0", VA = "0x43B52A0")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x6005D01")]
		[Address(RVA = "0x43B5340", Offset = "0x43B1340", VA = "0x43B5340")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005D02")]
		[Address(RVA = "0x43B52E0", Offset = "0x43B12E0", VA = "0x43B52E0")]
		[IteratorStateMachine(typeof(_003CDelayOnEnable_003Ed__22))]
		private IEnumerator DelayOnEnable()
		{
			return null;
		}

		[Token(Token = "0x6005D03")]
		[Address(RVA = "0x43B538C", Offset = "0x43B138C", VA = "0x43B538C")]
		public bool CheckCanShowVideo()
		{
			return default;
		}

		[Token(Token = "0x6005D04")]
		[Address(RVA = "0x43B5528", Offset = "0x43B1528", VA = "0x43B5528")]
		protected void OnDestroy()
		{
		}

		[Token(Token = "0x6005D05")]
		[Address(RVA = "0x43B5538", Offset = "0x43B1538", VA = "0x43B5538")]
		private void Update()
		{
		}

		[Token(Token = "0x6005D06")]
		[Address(RVA = "0x43B553C", Offset = "0x43B153C", VA = "0x43B553C")]
		private void CheckClickVideoBtnCd()
		{
		}

		[Token(Token = "0x6005D07")]
		[Address(RVA = "0x43B55CC", Offset = "0x43B15CC", VA = "0x43B55CC", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6005D08")]
		[Address(RVA = "0x43B5E00", Offset = "0x43B1E00", VA = "0x43B5E00", Slot = "7")]
		protected virtual void CallLT_ADCenter(bool success, float clickTime)
		{
		}

		[Token(Token = "0x6005D09")]
		[Address(RVA = "0x43B5E08", Offset = "0x43B1E08", VA = "0x43B5E08")]
		private void VideoCallBack(string videFlag, bool i)
		{
		}

		[Token(Token = "0x6005D0A")]
		[Address(RVA = "0x43B6198", Offset = "0x43B2198", VA = "0x43B6198", Slot = "8")]
		protected virtual void PlayAudio()
		{
		}

		[Token(Token = "0x6005D0B")]
		[Address(RVA = "0x43B624C", Offset = "0x43B224C", VA = "0x43B624C", Slot = "4")]
		public void SetButtonState(BtnState btnState)
		{
		}

		[Token(Token = "0x6005D0C")]
		[Address(RVA = "0x43B62E0", Offset = "0x43B22E0", VA = "0x43B62E0", Slot = "9")]
		protected virtual void SetGay(bool i)
		{
		}

		[Token(Token = "0x6005D0D")]
		[Address(RVA = "0x43B5420", Offset = "0x43B1420", VA = "0x43B5420")]
		private void CreateVideoReport()
		{
		}

		[Token(Token = "0x6005D0E")]
		[Address(RVA = "0x43B54A4", Offset = "0x43B14A4", VA = "0x43B54A4")]
		private void VideoIsReadyReport()
		{
		}

		[Token(Token = "0x6005D0F")]
		[Address(RVA = "0x43B5C9C", Offset = "0x43B1C9C", VA = "0x43B5C9C")]
		private void VideoClickReport()
		{
		}

		[Token(Token = "0x6005D10")]
		[Address(RVA = "0x43B5F18", Offset = "0x43B1F18", VA = "0x43B5F18")]
		[IteratorStateMachine(typeof(_003CDelayReport_003Ed__43))]
		private IEnumerator DelayReport(int n)
		{
			return null;
		}

		[Token(Token = "0x6005D11")]
		[Address(RVA = "0x43B5F88", Offset = "0x43B1F88", VA = "0x43B5F88")]
		private void ReportVideoPlayOver()
		{
		}

		[Token(Token = "0x6005D12")]
		[Address(RVA = "0x43B6390", Offset = "0x43B2390", VA = "0x43B6390", Slot = "10")]
		protected virtual void CustomizeReport()
		{
		}

		[Token(Token = "0x6005D13")]
		[Address(RVA = "0x43B630C", Offset = "0x43B230C", VA = "0x43B630C")]
		protected void ReportEvent(string key, string label, int count = 1)
		{
		}

		[Token(Token = "0x6005D14")]
		[Address(RVA = "0x43B6394", Offset = "0x43B2394", VA = "0x43B6394")]
		public void AddVideoBtnEvent(UnityAction<bool> call)
		{
		}

		[Token(Token = "0x6005D15")]
		[Address(RVA = "0x43B5D74", Offset = "0x43B1D74", VA = "0x43B5D74")]
		public void AddVideoPlayCallBack(UnityAction<bool> call)
		{
		}

		[Token(Token = "0x6005D16")]
		[Address(RVA = "0x43B5D40", Offset = "0x43B1D40", VA = "0x43B5D40")]
		public void RemoveVideoBtnListeners()
		{
		}

		[Token(Token = "0x6005D17")]
		[Address(RVA = "0x43B6420", Offset = "0x43B2420", VA = "0x43B6420")]
		public void SetIsFree(bool isFree)
		{
		}

		[Token(Token = "0x6005D18")]
		[Address(RVA = "0x43B642C", Offset = "0x43B242C", VA = "0x43B642C", Slot = "5")]
		public void VideoBtnShow(bool isAvailable)
		{
		}

		[Token(Token = "0x6005D19")]
		[Address(RVA = "0x43B5B80", Offset = "0x43B1B80", VA = "0x43B5B80")]
		private bool CheckDontNeedAd()
		{
			return default;
		}

		[Token(Token = "0x6005D1A")]
		[Address(RVA = "0x43B6530", Offset = "0x43B2530", VA = "0x43B6530")]
		public LTVideoButtonHook()
		{
		}
	}
}
