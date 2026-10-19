using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameFramework.SDK;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace GameFramework.Tools
{
	[Token(Token = "0x2000F7F")]
	public class UIVideoEventHook : MonoBehaviour, IDBTVideoBtn
	{
		[Token(Token = "0x2000F80")]
		[CompilerGenerated]
		private sealed class _003CDelayReport_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006ABB")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006ABC")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006ABD")]
			[FieldOffset(Offset = "0x20")]
			public int n;

			[Token(Token = "0x4006ABE")]
			[FieldOffset(Offset = "0x28")]
			public UIVideoEventHook _003C_003E4__this;

			[Token(Token = "0x17000F92")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005CF1")]
				[Address(RVA = "0x43B4A1C", Offset = "0x43B0A1C", VA = "0x43B4A1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000F93")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005CF3")]
				[Address(RVA = "0x43B4A5C", Offset = "0x43B0A5C", VA = "0x43B4A5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005CEE")]
			[Address(RVA = "0x43B473C", Offset = "0x43B073C", VA = "0x43B473C")]
			[DebuggerHidden]
			public _003CDelayReport_003Ed__41(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005CEF")]
			[Address(RVA = "0x43B4948", Offset = "0x43B0948", VA = "0x43B4948", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005CF0")]
			[Address(RVA = "0x43B494C", Offset = "0x43B094C", VA = "0x43B494C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005CF1")]
			[Address(RVA = "0x43B4A1C", Offset = "0x43B0A1C", VA = "0x43B4A1C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005CF2")]
			[Address(RVA = "0x43B4A24", Offset = "0x43B0A24", VA = "0x43B4A24", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005CF3")]
			[Address(RVA = "0x43B4A5C", Offset = "0x43B0A5C", VA = "0x43B4A5C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006AA7")]
		[FieldOffset(Offset = "0x20")]
		private VideoBtnEvent BtnOnClick;

		[Token(Token = "0x4006AA8")]
		[FieldOffset(Offset = "0x28")]
		private VideoBtnEvent VideoPlayCallBack;

		[Token(Token = "0x4006AAA")]
		[FieldOffset(Offset = "0x34")]
		public int videoID;

		[Token(Token = "0x4006AAB")]
		[FieldOffset(Offset = "0x38")]
		private VideoBtnData videoBtnData;

		[Token(Token = "0x4006AAC")]
		[FieldOffset(Offset = "0x40")]
		private BtnReportState btnReportState;

		[Token(Token = "0x4006AAD")]
		[FieldOffset(Offset = "0x44")]
		private bool IsCanShowAdsVideo;

		[Token(Token = "0x4006AAE")]
		[FieldOffset(Offset = "0x45")]
		public bool AutoCallBtnShow;

		[Token(Token = "0x4006AAF")]
		[FieldOffset(Offset = "0x48")]
		private string m_ReportLable;

		[Token(Token = "0x4006AB0")]
		[FieldOffset(Offset = "0x50")]
		private string m_Video_param1;

		[Token(Token = "0x4006AB1")]
		[FieldOffset(Offset = "0x58")]
		private string m_Video_param2;

		[Token(Token = "0x4006AB2")]
		[FieldOffset(Offset = "0x60")]
		private bool m_islockVideoData;

		[Token(Token = "0x4006AB3")]
		[FieldOffset(Offset = "0x64")]
		private float OnEnableWeekTime;

		[Token(Token = "0x4006AB4")]
		[FieldOffset(Offset = "0x68")]
		private bool isDestroy;

		[Token(Token = "0x4006AB5")]
		private const int PLAYVIDEOCD = 5;

		[Token(Token = "0x4006AB6")]
		private const int CLICKBTNCD = 1;

		[Token(Token = "0x4006AB7")]
		[FieldOffset(Offset = "0x0")]
		private static bool m_isPlayVideo;

		[Token(Token = "0x4006AB8")]
		[FieldOffset(Offset = "0x4")]
		private static float m_PlayVideoTimer;

		[Token(Token = "0x4006AB9")]
		[FieldOffset(Offset = "0x69")]
		private bool m_isClickVideo;

		[Token(Token = "0x4006ABA")]
		[FieldOffset(Offset = "0x6C")]
		private float m_ClickVideoTimer;

		[Token(Token = "0x17000F91")]
		private BtnState btnstate
		{
			[Token(Token = "0x6005CD1")]
			[Address(RVA = "0x43B3770", Offset = "0x43AF770", VA = "0x43B3770")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6005CD2")]
			[Address(RVA = "0x43B3778", Offset = "0x43AF778", VA = "0x43B3778")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6005CD3")]
		[Address(RVA = "0x43B3780", Offset = "0x43AF780", VA = "0x43B3780")]
		protected void Awake()
		{
		}

		[Token(Token = "0x6005CD4")]
		[Address(RVA = "0x43B3864", Offset = "0x43AF864", VA = "0x43B3864")]
		public void ResetVideoBtnData(int id)
		{
		}

		[Token(Token = "0x6005CD5")]
		[Address(RVA = "0x43B39D4", Offset = "0x43AF9D4", VA = "0x43B39D4")]
		public void SetVideoBtnData(string ReportLablel, string Video_param1, string Video_param2)
		{
		}

		[Token(Token = "0x6005CD6")]
		[Address(RVA = "0x43B37C8", Offset = "0x43AF7C8", VA = "0x43B37C8")]
		private void GetVideoBtnData()
		{
		}

		[Token(Token = "0x6005CD7")]
		[Address(RVA = "0x43B39E8", Offset = "0x43AF9E8", VA = "0x43B39E8")]
		protected void Start()
		{
		}

		[Token(Token = "0x6005CD8")]
		[Address(RVA = "0x43B3A94", Offset = "0x43AFA94", VA = "0x43B3A94")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x6005CD9")]
		[Address(RVA = "0x43B3D6C", Offset = "0x43AFD6C", VA = "0x43B3D6C")]
		public bool CheckCanShowVideo()
		{
			return default;
		}

		[Token(Token = "0x6005CDA")]
		[Address(RVA = "0x43B3EF0", Offset = "0x43AFEF0", VA = "0x43B3EF0")]
		protected void OnDestroy()
		{
		}

		[Token(Token = "0x6005CDB")]
		[Address(RVA = "0x43B3F00", Offset = "0x43AFF00", VA = "0x43B3F00")]
		private void Update()
		{
		}

		[Token(Token = "0x6005CDC")]
		[Address(RVA = "0x43B3F04", Offset = "0x43AFF04", VA = "0x43B3F04")]
		private void CheckClickVideoBtnCD()
		{
		}

		[Token(Token = "0x6005CDD")]
		[Address(RVA = "0x43B3F94", Offset = "0x43AFF94", VA = "0x43B3F94")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6005CDE")]
		[Address(RVA = "0x43B42D0", Offset = "0x43B02D0", VA = "0x43B42D0")]
		private void VideoCallBack(string videFlag, bool i)
		{
		}

		[Token(Token = "0x6005CDF")]
		[Address(RVA = "0x43B45F0", Offset = "0x43B05F0", VA = "0x43B45F0", Slot = "6")]
		protected virtual void PlayAudio()
		{
		}

		[Token(Token = "0x6005CE0")]
		[Address(RVA = "0x43B46A4", Offset = "0x43B06A4", VA = "0x43B46A4", Slot = "4")]
		public void SetButtonState(BtnState btnState)
		{
		}

		[Token(Token = "0x6005CE1")]
		[Address(RVA = "0x43B4738", Offset = "0x43B0738", VA = "0x43B4738", Slot = "7")]
		protected virtual void SetGay(bool i)
		{
		}

		[Token(Token = "0x6005CE2")]
		[Address(RVA = "0x43B3E00", Offset = "0x43AFE00", VA = "0x43B3E00")]
		private void CreateVideoReport()
		{
		}

		[Token(Token = "0x6005CE3")]
		[Address(RVA = "0x43B3E78", Offset = "0x43AFE78", VA = "0x43B3E78")]
		private void VideoIsReadyReport()
		{
		}

		[Token(Token = "0x6005CE4")]
		[Address(RVA = "0x43B4244", Offset = "0x43B0244", VA = "0x43B4244")]
		private void VideoClickReport()
		{
		}

		[Token(Token = "0x6005CE5")]
		[Address(RVA = "0x43B3CFC", Offset = "0x43AFCFC", VA = "0x43B3CFC")]
		[IteratorStateMachine(typeof(_003CDelayReport_003Ed__41))]
		private IEnumerator DelayReport(int n)
		{
			return null;
		}

		[Token(Token = "0x6005CE6")]
		[Address(RVA = "0x43B43E0", Offset = "0x43B03E0", VA = "0x43B43E0")]
		private void ReportVideoPlayOver()
		{
		}

		[Token(Token = "0x6005CE7")]
		[Address(RVA = "0x43B47E8", Offset = "0x43B07E8", VA = "0x43B47E8", Slot = "8")]
		protected virtual void CustomizeReport()
		{
		}

		[Token(Token = "0x6005CE8")]
		[Address(RVA = "0x43B4764", Offset = "0x43B0764", VA = "0x43B4764")]
		protected void ReportEvent(string key, string label, int count = 1)
		{
		}

		[Token(Token = "0x6005CE9")]
		[Address(RVA = "0x43B47EC", Offset = "0x43B07EC", VA = "0x43B47EC")]
		public void AddVideoBtnEvent(UnityAction<bool> call)
		{
		}

		[Token(Token = "0x6005CEA")]
		[Address(RVA = "0x43B4878", Offset = "0x43B0878", VA = "0x43B4878")]
		public void AddVideoPlayCallBack(UnityAction<bool> call)
		{
		}

		[Token(Token = "0x6005CEB")]
		[Address(RVA = "0x43B4904", Offset = "0x43B0904", VA = "0x43B4904")]
		public void RemoveVideoBtnListeners()
		{
		}

		[Token(Token = "0x6005CEC")]
		[Address(RVA = "0x43B3C14", Offset = "0x43AFC14", VA = "0x43B3C14", Slot = "5")]
		public void VideoBtnShow(bool IsAvailable)
		{
		}

		[Token(Token = "0x6005CED")]
		[Address(RVA = "0x43B4938", Offset = "0x43B0938", VA = "0x43B4938")]
		public UIVideoEventHook()
		{
		}
	}
}
