using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameFramework.SDK;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace GameFramework.Tools
{
	[Token(Token = "0x2000017")]
	public class ModelVideoBtn : MonoBehaviour, IDBTVideoBtn
	{
		[Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class _003CDelayReport_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000057")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000058")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000059")]
			[FieldOffset(Offset = "0x20")]
			public int n;

			[Token(Token = "0x400005A")]
			[FieldOffset(Offset = "0x28")]
			public ModelVideoBtn _003C_003E4__this;

			[Token(Token = "0x17000017")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600008D")]
				[Address(RVA = "0x706BAA4", Offset = "0x7067AA4", VA = "0x706BAA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000018")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600008F")]
				[Address(RVA = "0x706BAE4", Offset = "0x7067AE4", VA = "0x706BAE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600008A")]
			[Address(RVA = "0x706B7BC", Offset = "0x70677BC", VA = "0x706B7BC")]
			[DebuggerHidden]
			public _003CDelayReport_003Ed__41(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600008B")]
			[Address(RVA = "0x706B9D0", Offset = "0x70679D0", VA = "0x706B9D0", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600008C")]
			[Address(RVA = "0x706B9D4", Offset = "0x70679D4", VA = "0x706B9D4", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600008D")]
			[Address(RVA = "0x706BAA4", Offset = "0x7067AA4", VA = "0x706BAA4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600008E")]
			[Address(RVA = "0x706BAAC", Offset = "0x7067AAC", VA = "0x706BAAC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600008F")]
			[Address(RVA = "0x706BAE4", Offset = "0x7067AE4", VA = "0x706BAE4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x20")]
		public bool UseThisMousDwon;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x28")]
		private VideoBtnEvent BtnOnClick;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x30")]
		private VideoBtnEvent VideoPlayCallBack;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x40")]
		private VideoBtnData videoBtnData;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x48")]
		public int videoID;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x4C")]
		protected BtnReportState btnReportState;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x50")]
		private bool IsCanShowAdsVideo;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x51")]
		public bool AutoCallBtnShow;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x58")]
		private string m_ReportLable;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x60")]
		private string m_Video_param1;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x68")]
		private string m_Video_param2;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x70")]
		private bool m_islockVideoData;

		[Token(Token = "0x4000051")]
		private const int PLAYVIDEOCD = 5;

		[Token(Token = "0x4000052")]
		private const int CLICKBTNCD = 1;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x0")]
		private static bool m_isPlayVideo;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x4")]
		private static float m_PlayVideoTimer;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x71")]
		private bool m_isClickVideo;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x74")]
		private float m_ClickVideoTimer;

		[Token(Token = "0x17000016")]
		private BtnState btnstate
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x706A470", Offset = "0x7066470", VA = "0x706A470")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x706A478", Offset = "0x7066478", VA = "0x706A478")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x706A480", Offset = "0x7066480", VA = "0x706A480", Slot = "6")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x706A554", Offset = "0x7066554", VA = "0x706A554")]
		public void ResetVideoBtnData(int id)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x706A708", Offset = "0x7066708", VA = "0x706A708")]
		public void SetVideoBtnData(string ReportLablel, string Video_param1, string Video_param2)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x706A71C", Offset = "0x706671C", VA = "0x706A71C", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x706A8A8", Offset = "0x70668A8", VA = "0x706A8A8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x706AA88", Offset = "0x7066A88", VA = "0x706AA88")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x706AB28", Offset = "0x7066B28", VA = "0x706AB28")]
		private void VideoButtonStatus(object[] Args)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x706AD2C", Offset = "0x7066D2C", VA = "0x706AD2C")]
		public bool CheckCanShowVideo()
		{
			return default;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x706AEAC", Offset = "0x7066EAC", VA = "0x706AEAC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x706AEB0", Offset = "0x7066EB0", VA = "0x706AEB0")]
		private void CheckClickVideoBtnCD()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x706AF40", Offset = "0x7066F40", VA = "0x706AF40", Slot = "8")]
		protected virtual void OnMouseUpAsButton()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x706AFC8", Offset = "0x7066FC8", VA = "0x706AFC8")]
		public void ClickVideoBtn()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x706B428", Offset = "0x7067428", VA = "0x706B428")]
		private void VideoCallBack(string videFlag, bool i)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x706B724", Offset = "0x7067724", VA = "0x706B724", Slot = "9")]
		protected virtual void PlayAudio()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x706A81C", Offset = "0x706681C", VA = "0x706A81C", Slot = "4")]
		public void SetButtonState(BtnState btnState)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x706B7B8", Offset = "0x70677B8", VA = "0x706B7B8", Slot = "10")]
		protected virtual void SetGay(bool i)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x706ADBC", Offset = "0x7066DBC", VA = "0x706ADBC")]
		private void CreateVideoReport()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x706AE34", Offset = "0x7066E34", VA = "0x706AE34")]
		private void VideoIsReadyReport()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x706B39C", Offset = "0x706739C", VA = "0x706B39C")]
		private void VideoClickReport()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x706AA18", Offset = "0x7066A18", VA = "0x706AA18")]
		[IteratorStateMachine(typeof(_003CDelayReport_003Ed__41))]
		private IEnumerator DelayReport(int n)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x706B514", Offset = "0x7067514", VA = "0x706B514")]
		private void ReportVideoPlayOver()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x706B868", Offset = "0x7067868", VA = "0x706B868", Slot = "11")]
		protected virtual void CustomizeReport()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x706B7E4", Offset = "0x70677E4", VA = "0x706B7E4")]
		protected void ReportEvent(string key, string label, int count = 1)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x706B86C", Offset = "0x706786C", VA = "0x706B86C")]
		public void AddVideoBtnEvent(UnityAction<bool> call)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x706B8F8", Offset = "0x70678F8", VA = "0x706B8F8")]
		public void AddVideoPlayCallBack(UnityAction<bool> call)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x706B984", Offset = "0x7067984", VA = "0x706B984")]
		public void RemoveVideoBtnListeners()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x706A930", Offset = "0x7066930", VA = "0x706A930", Slot = "5")]
		public void VideoBtnShow(bool IsAvailable)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x706B9B8", Offset = "0x70679B8", VA = "0x706B9B8")]
		public ModelVideoBtn()
		{
		}
	}
}
