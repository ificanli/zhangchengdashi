using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameFramework.SDK;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GameFramework.Tools
{
	[Token(Token = "0x200001A")]
	public class UIVideoBtn : Button, IDBTVideoBtn
	{
		[Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class _003CDelayReport_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000073")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000074")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000075")]
			[FieldOffset(Offset = "0x20")]
			public int n;

			[Token(Token = "0x4000076")]
			[FieldOffset(Offset = "0x28")]
			public UIVideoBtn _003C_003E4__this;

			[Token(Token = "0x1700001A")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000B0")]
				[Address(RVA = "0x706CF00", Offset = "0x7068F00", VA = "0x706CF00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700001B")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000B2")]
				[Address(RVA = "0x706CF40", Offset = "0x7068F40", VA = "0x706CF40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x706CC20", Offset = "0x7068C20", VA = "0x706CC20")]
			[DebuggerHidden]
			public _003CDelayReport_003Ed__41(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x706CE2C", Offset = "0x7068E2C", VA = "0x706CE2C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x706CE30", Offset = "0x7068E30", VA = "0x706CE30", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x706CF00", Offset = "0x7068F00", VA = "0x706CF00", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x706CF08", Offset = "0x7068F08", VA = "0x706CF08", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x706CF40", Offset = "0x7068F40", VA = "0x706CF40", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x108")]
		private VideoBtnEvent BtnOnClick;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x110")]
		private VideoBtnEvent VideoPlayCallBack;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x11C")]
		public int videoID;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x120")]
		private VideoBtnData videoBtnData;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x128")]
		private BtnReportState btnReportState;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x12C")]
		private bool IsCanShowAdsVideo;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x12D")]
		public bool AutoCallBtnShow;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x130")]
		private string m_ReportLable;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x138")]
		private string m_Video_param1;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x140")]
		private string m_Video_param2;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x148")]
		private bool m_islockVideoData;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x14C")]
		private float OnEnableWeekTime;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x150")]
		private bool isDestroy;

		[Token(Token = "0x400006D")]
		private const int PLAYVIDEOCD = 5;

		[Token(Token = "0x400006E")]
		private const int CLICKBTNCD = 1;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x0")]
		private static bool m_isPlayVideo;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x4")]
		private static float m_PlayVideoTimer;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x151")]
		private bool m_isClickVideo;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x154")]
		private float m_ClickVideoTimer;

		[Token(Token = "0x17000019")]
		private BtnState btnstate
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x706BAEC", Offset = "0x7067AEC", VA = "0x706BAEC")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x706BAF4", Offset = "0x7067AF4", VA = "0x706BAF4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x706BAFC", Offset = "0x7067AFC", VA = "0x706BAFC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x706BBEC", Offset = "0x7067BEC", VA = "0x706BBEC")]
		public void ResetVideoBtnData(int id)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x706BD5C", Offset = "0x7067D5C", VA = "0x706BD5C")]
		public void SetVideoBtnData(string ReportLablel, string Video_param1, string Video_param2)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x706BB50", Offset = "0x7067B50", VA = "0x706BB50")]
		private void GetVideoBtnData()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x706BD70", Offset = "0x7067D70", VA = "0x706BD70", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x706BE9C", Offset = "0x7067E9C", VA = "0x706BE9C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x706C180", Offset = "0x7068180", VA = "0x706C180")]
		public bool CheckCanShowVideo()
		{
			return default;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x706C304", Offset = "0x7068304", VA = "0x706C304", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x706C328", Offset = "0x7068328", VA = "0x706C328")]
		private void Update()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x706C32C", Offset = "0x706832C", VA = "0x706C32C")]
		private void CheckClickVideoBtnCD()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x706C3BC", Offset = "0x70683BC", VA = "0x706C3BC", Slot = "41")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x706C7A8", Offset = "0x70687A8", VA = "0x706C7A8")]
		private void VideoCallBack(string videFlag, bool i)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x706CACC", Offset = "0x7068ACC", VA = "0x706CACC", Slot = "45")]
		protected virtual void PlayAudio()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x706CB80", Offset = "0x7068B80", VA = "0x706CB80", Slot = "43")]
		public void SetButtonState(BtnState btnState)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x706CC1C", Offset = "0x7068C1C", VA = "0x706CC1C", Slot = "46")]
		protected virtual void SetGay(bool i)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x706C214", Offset = "0x7068214", VA = "0x706C214")]
		private void CreateVideoReport()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x706C28C", Offset = "0x706828C", VA = "0x706C28C")]
		private void VideoIsReadyReport()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x706C71C", Offset = "0x706871C", VA = "0x706C71C")]
		private void VideoClickReport()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x706C110", Offset = "0x7068110", VA = "0x706C110")]
		[IteratorStateMachine(typeof(_003CDelayReport_003Ed__41))]
		private IEnumerator DelayReport(int n)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x706C8B8", Offset = "0x70688B8", VA = "0x706C8B8")]
		private void ReportVideoPlayOver()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x706CCCC", Offset = "0x7068CCC", VA = "0x706CCCC", Slot = "47")]
		protected virtual void CustomizeReport()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x706CC48", Offset = "0x7068C48", VA = "0x706CC48")]
		protected void ReportEvent(string key, string label, int count = 1)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x706CCD0", Offset = "0x7068CD0", VA = "0x706CCD0")]
		public void AddVideoBtnEvent(UnityAction<bool> call)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x706CD5C", Offset = "0x7068D5C", VA = "0x706CD5C")]
		public void AddVideoPlayCallBack(UnityAction<bool> call)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x706CDE8", Offset = "0x7068DE8", VA = "0x706CDE8")]
		public void RemoveVideoBtnListeners()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x706C028", Offset = "0x7068028", VA = "0x706C028", Slot = "44")]
		public void VideoBtnShow(bool IsAvailable)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x706CE1C", Offset = "0x7068E1C", VA = "0x706CE1C")]
		public UIVideoBtn()
		{
		}
	}
}
