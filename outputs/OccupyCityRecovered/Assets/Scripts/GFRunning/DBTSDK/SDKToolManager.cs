using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using GameFramework;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

namespace DBTSDK
{
	[Token(Token = "0x20001E2")]
	public class SDKToolManager : MonoBehaviour
	{
		[Token(Token = "0x20001E3")]
		public class CheckSensitiveReult
		{
			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool IsOk;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string riskDescription;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string riskresult;

			[Token(Token = "0x60019AC")]
			[Address(RVA = "0x70ABB30", Offset = "0x70A7B30", VA = "0x70ABB30")]
			public CheckSensitiveReult()
			{
			}
		}

		[Token(Token = "0x20001E4")]
		public class SensitiveInfo
		{
			[Token(Token = "0x20001E5")]
			public class Data
			{
				[Token(Token = "0x40006A5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string riskDescription;

				[Token(Token = "0x40006A6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string riskresult;

				[Token(Token = "0x40006A7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public string requestId;

				[Token(Token = "0x40006A8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public bool levelFlag;

				[Token(Token = "0x60019AE")]
				[Address(RVA = "0x70B6CD4", Offset = "0x70B2CD4", VA = "0x70B6CD4")]
				public Data()
				{
				}
			}

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string code;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string msg;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Data data;

			[Token(Token = "0x60019AD")]
			[Address(RVA = "0x70B6C74", Offset = "0x70B2C74", VA = "0x70B6C74")]
			public SensitiveInfo()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001E7")]
		[CompilerGenerated]
		private struct _003CAwait_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SDKToolManager _003C_003E4__this;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60019B2")]
			[Address(RVA = "0x70B6D88", Offset = "0x70B2D88", VA = "0x70B6D88", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60019B3")]
			[Address(RVA = "0x70B700C", Offset = "0x70B300C", VA = "0x70B700C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20001E8")]
		[CompilerGenerated]
		private sealed class _003CAwaitLoadGameInfo_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x17000101")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60019B7")]
				[Address(RVA = "0x70B71A8", Offset = "0x70B31A8", VA = "0x70B71A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000102")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60019B9")]
				[Address(RVA = "0x70B71E8", Offset = "0x70B31E8", VA = "0x70B71E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60019B4")]
			[Address(RVA = "0x70ADD2C", Offset = "0x70A9D2C", VA = "0x70ADD2C")]
			[DebuggerHidden]
			public _003CAwaitLoadGameInfo_003Ed__64(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60019B5")]
			[Address(RVA = "0x70B7074", Offset = "0x70B3074", VA = "0x70B7074", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60019B6")]
			[Address(RVA = "0x70B7078", Offset = "0x70B3078", VA = "0x70B7078", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60019B7")]
			[Address(RVA = "0x70B71A8", Offset = "0x70B31A8", VA = "0x70B71A8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60019B8")]
			[Address(RVA = "0x70B71B0", Offset = "0x70B31B0", VA = "0x70B71B0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60019B9")]
			[Address(RVA = "0x70B71E8", Offset = "0x70B31E8", VA = "0x70B71E8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001E9")]
		[CompilerGenerated]
		private struct _003CIsCanShowGM_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SDKToolManager _003C_003E4__this;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60019BA")]
			[Address(RVA = "0x70B71F0", Offset = "0x70B31F0", VA = "0x70B71F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60019BB")]
			[Address(RVA = "0x70B7630", Offset = "0x70B3630", VA = "0x70B7630", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20001EA")]
		[CompilerGenerated]
		private sealed class _003CLoadGameInfo_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SDKToolManager _003C_003E4__this;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest _003Crequest_003E5__2;

			[Token(Token = "0x17000103")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60019BF")]
				[Address(RVA = "0x70B7BF4", Offset = "0x70B3BF4", VA = "0x70B7BF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000104")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60019C1")]
				[Address(RVA = "0x70B7C34", Offset = "0x70B3C34", VA = "0x70B7C34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60019BC")]
			[Address(RVA = "0x70ADCAC", Offset = "0x70A9CAC", VA = "0x70ADCAC")]
			[DebuggerHidden]
			public _003CLoadGameInfo_003Ed__63(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60019BD")]
			[Address(RVA = "0x70B76AC", Offset = "0x70B36AC", VA = "0x70B76AC", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60019BE")]
			[Address(RVA = "0x70B76B0", Offset = "0x70B36B0", VA = "0x70B76B0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60019BF")]
			[Address(RVA = "0x70B7BF4", Offset = "0x70B3BF4", VA = "0x70B7BF4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60019C0")]
			[Address(RVA = "0x70B7BFC", Offset = "0x70B3BFC", VA = "0x70B7BFC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60019C1")]
			[Address(RVA = "0x70B7C34", Offset = "0x70B3C34", VA = "0x70B7C34", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20001EB")]
		[CompilerGenerated]
		private sealed class _003CWebGLIsIntranet_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SDKToolManager _003C_003E4__this;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest _003Crequest_003E5__2;

			[Token(Token = "0x17000105")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60019C6")]
				[Address(RVA = "0x70B81B4", Offset = "0x70B41B4", VA = "0x70B81B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000106")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60019C8")]
				[Address(RVA = "0x70B81F4", Offset = "0x70B41F4", VA = "0x70B81F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60019C2")]
			[Address(RVA = "0x70AA144", Offset = "0x70A6144", VA = "0x70AA144")]
			[DebuggerHidden]
			public _003CWebGLIsIntranet_003Ed__23(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60019C3")]
			[Address(RVA = "0x70B7C3C", Offset = "0x70B3C3C", VA = "0x70B7C3C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60019C4")]
			[Address(RVA = "0x70B7C58", Offset = "0x70B3C58", VA = "0x70B7C58", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60019C5")]
			[Address(RVA = "0x70B8104", Offset = "0x70B4104", VA = "0x70B8104")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60019C6")]
			[Address(RVA = "0x70B81B4", Offset = "0x70B41B4", VA = "0x70B81B4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60019C7")]
			[Address(RVA = "0x70B81BC", Offset = "0x70B41BC", VA = "0x70B81BC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60019C8")]
			[Address(RVA = "0x70B81F4", Offset = "0x70B41F4", VA = "0x70B81F4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SDKToolManager Instance;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal bool IsDebugVer;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal FpsCounter m_fpsCounter;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool IsReportGameInteractive;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool IsActiveD;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool IntranetResult;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		private bool IsIntranetCheckOver;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action<string> QRcodeCallback;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action<CheckSensitiveReult> CheckThirdSensitiveInfoCallBack;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action<int, int> ShowPhotoCameraAuthorizationCallback;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent<int, List<CDKActivity>> CDKActivityInfo;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent<int, string> GenerateCdk;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UnityEvent<int, CDKInfo> VerifyCdk;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UnityEvent<int, string> OffCodeCdk;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Dictionary<string, int> downingGameAssets;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Dictionary<string, GameInfo> dicGameInfo;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool m_gameInfoReadOver;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Action<string, int> m_downloadGoogleAssetResultCallBack;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Action<string, long, long> m_downloadGoogleAssetProgressCallBack;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool IsSendGameStart;

		[Token(Token = "0x4000697")]
		private const int ServerTimeDifference = 28800000;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Action<string> fileSelectorCallBack;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action<UpLoadCloudArchiveResult> m_uploadCloudArchiveEventHandler;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Action<PullCloudArchiveResult> m_pullCloudArchiveEventHandler;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float debugInterval;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float debugWeekTime;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Action<List<ChannelGiftGoods>> m_getChannelGiftGoodsEventHandler;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Action<List<ChannelGiftGoods>> m_claimGiftGoodsEventHandler;

		[Token(Token = "0x17000100")]
		public bool IsGameHomeUnityEngine
		{
			[Token(Token = "0x60018F3")]
			[Address(RVA = "0x70A7F14", Offset = "0x70A3F14", VA = "0x70A7F14")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<string, int> DownloadGoogleAssetResultCallBack
		{
			[Token(Token = "0x6001920")]
			[Address(RVA = "0x70ADD54", Offset = "0x70A9D54", VA = "0x70ADD54")]
			add
			{
			}
			[Token(Token = "0x6001921")]
			[Address(RVA = "0x70ADDFC", Offset = "0x70A9DFC", VA = "0x70ADDFC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<string, long, long> DownloadGoogleAssetProgressEvent
		{
			[Token(Token = "0x6001922")]
			[Address(RVA = "0x70ADEA4", Offset = "0x70A9EA4", VA = "0x70ADEA4")]
			add
			{
			}
			[Token(Token = "0x6001923")]
			[Address(RVA = "0x70ADF4C", Offset = "0x70A9F4C", VA = "0x70ADF4C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<UpLoadCloudArchiveResult> UploadCloudArchiveCallBack
		{
			[Token(Token = "0x6001933")]
			[Address(RVA = "0x70AF980", Offset = "0x70AB980", VA = "0x70AF980")]
			add
			{
			}
			[Token(Token = "0x6001934")]
			[Address(RVA = "0x70AFA28", Offset = "0x70ABA28", VA = "0x70AFA28")]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event Action<PullCloudArchiveResult> PullCloudArchiveCallBack
		{
			[Token(Token = "0x6001936")]
			[Address(RVA = "0x70AFBF4", Offset = "0x70ABBF4", VA = "0x70AFBF4")]
			add
			{
			}
			[Token(Token = "0x6001937")]
			[Address(RVA = "0x70AFC9C", Offset = "0x70ABC9C", VA = "0x70AFC9C")]
			remove
			{
			}
		}

		[Token(Token = "0x60018F4")]
		[Address(RVA = "0x70A8054", Offset = "0x70A4054", VA = "0x70A8054")]
		private void Awake()
		{
		}

		[Token(Token = "0x60018F5")]
		[Address(RVA = "0x70A8250", Offset = "0x70A4250", VA = "0x70A8250")]
		private void Start()
		{
		}

		[Token(Token = "0x60018F6")]
		[Address(RVA = "0x70A8450", Offset = "0x70A4450", VA = "0x70A8450")]
		private void InitConfig()
		{
		}

		[Token(Token = "0x60018F7")]
		[Address(RVA = "0x70A87A4", Offset = "0x70A47A4", VA = "0x70A87A4")]
		private bool IsUseSDK()
		{
			return default;
		}

		[Token(Token = "0x60018F8")]
		[Address(RVA = "0x70A8800", Offset = "0x70A4800", VA = "0x70A8800")]
		public string GetGameBizDomainStatic_Override(string gamename, DType dType = DType.RD, string businessName = "")
		{
			return null;
		}

		[Token(Token = "0x60018F9")]
		[Address(RVA = "0x70A8BAC", Offset = "0x70A4BAC", VA = "0x70A8BAC")]
		public string GetGameBizDomainWithPort(string gamename, DType dType = DType.RD, string businessName = "")
		{
			return null;
		}

		[Token(Token = "0x60018FA")]
		[Address(RVA = "0x70A8E0C", Offset = "0x70A4E0C", VA = "0x70A8E0C")]
		private string GetGameBizDomainStaticWithPort(string gamename, string businessName = "")
		{
			return null;
		}

		[Token(Token = "0x60018FB")]
		[Address(RVA = "0x70A9098", Offset = "0x70A5098", VA = "0x70A9098")]
		private void ResolveGameBizInfo(string gamename, string businessName, out string domain, out string port, out string protocol)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SDKToolManager.ResolveGameBizInfo RVA=0x70A9098 Token=0x60018FB");
}

		[Token(Token = "0x60018FC")]
		[Address(RVA = "0x70A93B4", Offset = "0x70A53B4", VA = "0x70A93B4")]
		internal string GetWhcGameCDNDomain()
		{
			return null;
		}

		[Token(Token = "0x60018FD")]
		[Address(RVA = "0x70A9600", Offset = "0x70A5600", VA = "0x70A9600")]
		public string GetGameCDNDomainStatic_Override(CdnType cdnType = CdnType.New)
		{
			return null;
		}

		[Token(Token = "0x60018FE")]
		[Address(RVA = "0x70A972C", Offset = "0x70A572C", VA = "0x70A972C")]
		public string GetGameNewCDNDomainByTeam(TeamType teamType)
		{
			return null;
		}

		[Token(Token = "0x60018FF")]
		[Address(RVA = "0x70A9B48", Offset = "0x70A5B48", VA = "0x70A9B48")]
		internal string GetWhcCDNDomainByTeam(TeamType teamType)
		{
			return null;
		}

		[Token(Token = "0x6001900")]
		[Address(RVA = "0x70A9DB4", Offset = "0x70A5DB4", VA = "0x70A9DB4")]
		[AsyncStateMachine(typeof(_003CIsCanShowGM_003Ed__19))]
		public Task<bool> IsCanShowGM()
		{
			return null;
		}

		[Token(Token = "0x6001901")]
		[Address(RVA = "0x70A9EA4", Offset = "0x70A5EA4", VA = "0x70A9EA4")]
		private void IsIntranet()
		{
		}

		[Token(Token = "0x6001902")]
		[Address(RVA = "0x70AA0E4", Offset = "0x70A60E4", VA = "0x70AA0E4")]
		[IteratorStateMachine(typeof(_003CWebGLIsIntranet_003Ed__23))]
		private IEnumerator WebGLIsIntranet()
		{
			return null;
		}

		[Token(Token = "0x6001903")]
		[Address(RVA = "0x70AA16C", Offset = "0x70A616C", VA = "0x70AA16C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwait_003Ed__24))]
		public virtual Task Await()
		{
			return null;
		}

		[Token(Token = "0x6001904")]
		[Address(RVA = "0x70A9EF0", Offset = "0x70A5EF0", VA = "0x70A9EF0")]
		internal void checkTestModeCallback(string data)
		{
		}

		[Token(Token = "0x6001905")]
		[Address(RVA = "0x70AA354", Offset = "0x70A6354", VA = "0x70AA354")]
		private void OpenGMModules()
		{
		}

		[Token(Token = "0x6001906")]
		[Address(RVA = "0x70AA464", Offset = "0x70A6464", VA = "0x70AA464")]
		public void createQRcodeAsyncStatic_Override(string content, int widthPix, int heightPix, int padding, Action<string> callback)
		{
		}

		[Token(Token = "0x6001907")]
		[Address(RVA = "0x70AA5E0", Offset = "0x70A65E0", VA = "0x70AA5E0")]
		internal void createQRcodeCallback(string path)
		{
		}

		[Token(Token = "0x6001908")]
		[Address(RVA = "0x70AA5FC", Offset = "0x70A65FC", VA = "0x70AA5FC")]
		public void RequestNoticificationPermission_M()
		{
		}

		[Token(Token = "0x6001909")]
		[Address(RVA = "0x70AA724", Offset = "0x70A6724", VA = "0x70AA724")]
		[Obsolete("消息通知申请已过时，请使用最新的权限申请接口PushPermissionMgr", false)]
		public void CheckAllowedUserNotification()
		{
		}

		[Token(Token = "0x600190A")]
		[Address(RVA = "0x70AAACC", Offset = "0x70A6ACC", VA = "0x70AAACC")]
		public void CreateUserNotificationInfoStatic_Override(string title, string content, string dateStr, int type)
		{
		}

		[Token(Token = "0x600190B")]
		[Address(RVA = "0x70AAC6C", Offset = "0x70A6C6C", VA = "0x70AAC6C")]
		public void CreateBadgeNumberNotificationInfoStatic_Override(string dateStr)
		{
		}

		[Token(Token = "0x600190C")]
		[Address(RVA = "0x70AADAC", Offset = "0x70A6DAC", VA = "0x70AADAC")]
		public void CreateNotify(NotifyData notifyData)
		{
		}

		[Token(Token = "0x600190D")]
		[Address(RVA = "0x70AAF3C", Offset = "0x70A6F3C", VA = "0x70AAF3C")]
		public void ClearNotify(string NotifyId = "")
		{
		}

		[Token(Token = "0x600190E")]
		[Address(RVA = "0x70AB070", Offset = "0x70A7070", VA = "0x70AB070")]
		public NotifyParams GetNotifyParams()
		{
			return null;
		}

		[Token(Token = "0x600190F")]
		[Address(RVA = "0x70AB370", Offset = "0x70A7370", VA = "0x70AB370")]
		public string GetSensitiveConfig()
		{
			return null;
		}

		[Token(Token = "0x6001910")]
		[Address(RVA = "0x70AB54C", Offset = "0x70A754C", VA = "0x70AB54C")]
		private string GetSensitiveImp()
		{
			return null;
		}

		[Token(Token = "0x6001911")]
		[Address(RVA = "0x70AB5E0", Offset = "0x70A75E0", VA = "0x70AB5E0")]
		public void CheckThirdSensitiveInfo_M(string checkInfo, Action<CheckSensitiveReult> callBack, int etype = 1, string scenestr = "")
		{
		}

		[Token(Token = "0x6001912")]
		[Address(RVA = "0x70AB7BC", Offset = "0x70A77BC", VA = "0x70AB7BC")]
		internal void checkThirdSensitiveInfoCallback(string data)
		{
		}

		[Token(Token = "0x6001913")]
		[Address(RVA = "0x70ABB38", Offset = "0x70A7B38", VA = "0x70ABB38")]
		public void checkThirdSensitiveInfoCallback_XYX(string code, string msg, bool levelFlag)
		{
		}

		[Token(Token = "0x6001914")]
		[Address(RVA = "0x70ABCE8", Offset = "0x70A7CE8", VA = "0x70ABCE8")]
		private void checkThirdSensitiveInfoCallback_XYX(string data)
		{
		}

		[Token(Token = "0x6001915")]
		[Address(RVA = "0x70ABFF4", Offset = "0x70A7FF4", VA = "0x70ABFF4")]
		public void ShowPhotoCameraAuthorizationStatic_Override(int type, Action<int, int> Result)
		{
		}

		[Token(Token = "0x6001916")]
		[Address(RVA = "0x70AC12C", Offset = "0x70A812C", VA = "0x70AC12C")]
		internal void showPhotoCameraAuthorizationCallback(string data)
		{
		}

		[Token(Token = "0x6001917")]
		[Address(RVA = "0x70AC2B0", Offset = "0x70A82B0", VA = "0x70AC2B0")]
		internal void redeemGetAllInfoCallback(string data)
		{
		}

		[Token(Token = "0x6001918")]
		[Address(RVA = "0x70AC7D4", Offset = "0x70A87D4", VA = "0x70AC7D4")]
		internal void redeemGetCodeCallback(string data)
		{
		}

		[Token(Token = "0x6001919")]
		[Address(RVA = "0x70ACA14", Offset = "0x70A8A14", VA = "0x70ACA14")]
		internal void redeemVerifyCodeCallback(string data)
		{
		}

		[Token(Token = "0x600191A")]
		[Address(RVA = "0x70AD144", Offset = "0x70A9144", VA = "0x70AD144")]
		internal void redeemOffCodeCallback(string data)
		{
		}

		[Token(Token = "0x600191B")]
		[Address(RVA = "0x70AD384", Offset = "0x70A9384", VA = "0x70AD384")]
		public int GetGameAssetState(string GameName)
		{
			return default;
		}

		[Token(Token = "0x600191C")]
		[Address(RVA = "0x70AD788", Offset = "0x70A9788", VA = "0x70AD788")]
		public void DownGameAsset(string GameName)
		{
		}

		[Token(Token = "0x600191D")]
		[Address(RVA = "0x70AD5D0", Offset = "0x70A95D0", VA = "0x70AD5D0")]
		internal GPAssetPackType GetGameAssetType(string GameName)
		{
			return default;
		}

		[Token(Token = "0x600191E")]
		[Address(RVA = "0x70A8638", Offset = "0x70A4638", VA = "0x70A8638")]
		[IteratorStateMachine(typeof(_003CLoadGameInfo_003Ed__63))]
		internal IEnumerator LoadGameInfo()
		{
			return null;
		}

		[Token(Token = "0x600191F")]
		[Address(RVA = "0x70ADCD4", Offset = "0x70A9CD4", VA = "0x70ADCD4")]
		[IteratorStateMachine(typeof(_003CAwaitLoadGameInfo_003Ed__64))]
		internal IEnumerator AwaitLoadGameInfo()
		{
			return null;
		}

		[Token(Token = "0x6001924")]
		[Address(RVA = "0x70ADFF4", Offset = "0x70A9FF4", VA = "0x70ADFF4")]
		internal void downloadGoogleAssetSuccessCallBack(string data)
		{
		}

		[Token(Token = "0x6001925")]
		[Address(RVA = "0x70AE1AC", Offset = "0x70AA1AC", VA = "0x70AE1AC")]
		internal void downloadGoogleAssetFailCallBack(string data)
		{
		}

		[Token(Token = "0x6001926")]
		[Address(RVA = "0x70AE3DC", Offset = "0x70AA3DC", VA = "0x70AE3DC")]
		internal void downloadGoogleAssetScheduleCallBack(string data)
		{
		}

		[Token(Token = "0x6001927")]
		[Address(RVA = "0x70AE6A4", Offset = "0x70AA6A4", VA = "0x70AE6A4")]
		public void ReportGameInteractive(string info = "")
		{
		}

		[Token(Token = "0x6001928")]
		[Address(RVA = "0x70AE81C", Offset = "0x70AA81C", VA = "0x70AE81C")]
		public void CleanAllFileCache()
		{
		}

		[Token(Token = "0x6001929")]
		[Address(RVA = "0x70AE93C", Offset = "0x70AA93C", VA = "0x70AE93C")]
		public void AppQuit()
		{
		}

		[Token(Token = "0x600192A")]
		[Address(RVA = "0x70AE98C", Offset = "0x70AA98C", VA = "0x70AE98C")]
		public void U3DGameStart_Override()
		{
		}

		[Token(Token = "0x600192B")]
		[Address(RVA = "0x70AEAB4", Offset = "0x70AAAB4", VA = "0x70AEAB4")]
		public void VibrateStatic_Override(long milliseconds, int shakeLevel)
		{
		}

		[Token(Token = "0x600192C")]
		[Address(RVA = "0x70AEC80", Offset = "0x70AAC80", VA = "0x70AEC80")]
		public long GetServerTimeByServerTimeZone()
		{
			return default;
		}

		[Token(Token = "0x600192D")]
		[Address(RVA = "0x70AEEB8", Offset = "0x70AAEB8", VA = "0x70AEEB8")]
		public long GetServerTimestamp()
		{
			return default;
		}

		[Token(Token = "0x600192E")]
		[Address(RVA = "0x70AEEBC", Offset = "0x70AAEBC", VA = "0x70AEEBC")]
		public long GetServerTimeStaticZeroZone()
		{
			return default;
		}

		[Token(Token = "0x600192F")]
		[Address(RVA = "0x70AF0DC", Offset = "0x70AB0DC", VA = "0x70AF0DC")]
		public void StartSettingStatic_M(string pageTitle = "")
		{
		}

		[Token(Token = "0x6001930")]
		[Address(RVA = "0x70AF29C", Offset = "0x70AB29C", VA = "0x70AF29C")]
		public void FileSelector(string fileFormat, Action<string> callBack)
		{
		}

		[Token(Token = "0x6001931")]
		[Address(RVA = "0x70AF3D4", Offset = "0x70AB3D4", VA = "0x70AF3D4")]
		internal void serverFileSelectorCallBack(string data)
		{
		}

		[Token(Token = "0x6001932")]
		[Address(RVA = "0x70AF588", Offset = "0x70AB588", VA = "0x70AF588")]
		internal void certificationCallback(string data)
		{
		}

		[Token(Token = "0x6001935")]
		[Address(RVA = "0x70AFAD0", Offset = "0x70ABAD0", VA = "0x70AFAD0")]
		internal void uploadCloudArchiveCallback(string data)
		{
		}

		[Token(Token = "0x6001938")]
		[Address(RVA = "0x70AFD44", Offset = "0x70ABD44", VA = "0x70AFD44")]
		internal void pullCloudArchiveCallback(string data)
		{
		}

		[Token(Token = "0x6001939")]
		[Address(RVA = "0x70AFE68", Offset = "0x70ABE68", VA = "0x70AFE68")]
		private void DebugGameProInfo()
		{
		}

		[Token(Token = "0x600193A")]
		[Address(RVA = "0x70AFFC0", Offset = "0x70ABFC0", VA = "0x70AFFC0")]
		public void GetChannelGiftGoods_M(Action<List<ChannelGiftGoods>> callBack)
		{
		}

		[Token(Token = "0x600193B")]
		[Address(RVA = "0x70B0190", Offset = "0x70AC190", VA = "0x70B0190")]
		private void GetChannelGiftGoodsCallBack(string data)
		{
		}

		[Token(Token = "0x600193C")]
		[Address(RVA = "0x70B0394", Offset = "0x70AC394", VA = "0x70B0394")]
		public void ClaimChannelGiftGoods(Action<List<ChannelGiftGoods>> callBack, params string[] idList)
		{
		}

		[Token(Token = "0x600193D")]
		[Address(RVA = "0x70B07CC", Offset = "0x70AC7CC", VA = "0x70B07CC")]
		private void ClaimChannelGiftGoodsCallBack(string data)
		{
		}

		[Token(Token = "0x600193E")]
		[Address(RVA = "0x70B09D0", Offset = "0x70AC9D0", VA = "0x70B09D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600193F")]
		[Address(RVA = "0x70AEB34", Offset = "0x70AAB34", VA = "0x70AEB34")]
		internal void VibrateStatic(long milliseconds, int shakeLevel)
		{
		}

		[Token(Token = "0x6001940")]
		[Address(RVA = "0x70A8320", Offset = "0x70A4320", VA = "0x70A8320")]
		public void ShowToast(string msg)
		{
		}

		[Token(Token = "0x6001941")]
		[Address(RVA = "0x70B0A60", Offset = "0x70ACA60", VA = "0x70B0A60")]
		public void ShowExitDialog()
		{
		}

		[Token(Token = "0x6001942")]
		[Address(RVA = "0x70B0B84", Offset = "0x70ACB84", VA = "0x70B0B84")]
		public void OpenUrl(string url)
		{
		}

		[Token(Token = "0x6001943")]
		[Address(RVA = "0x70B0CB4", Offset = "0x70ACCB4", VA = "0x70B0CB4")]
		public void CopyMsgToClipboard(string msg)
		{
		}

		[Token(Token = "0x6001944")]
		[Address(RVA = "0x70B0DE4", Offset = "0x70ACDE4", VA = "0x70B0DE4")]
		public string GetClipboardMsg()
		{
			return null;
		}

		[Token(Token = "0x6001945")]
		[Address(RVA = "0x70B0F0C", Offset = "0x70ACF0C", VA = "0x70B0F0C")]
		public void Copy2SystemDCIM(string copyFile)
		{
		}

		[Token(Token = "0x6001946")]
		[Address(RVA = "0x70B103C", Offset = "0x70AD03C", VA = "0x70B103C")]
		public void GotoAppStore(string packageName)
		{
		}

		[Token(Token = "0x6001947")]
		[Address(RVA = "0x70B116C", Offset = "0x70AD16C", VA = "0x70B116C")]
		public string GetNetworkTypeStatic()
		{
			return null;
		}

		[Token(Token = "0x6001948")]
		[Address(RVA = "0x70B1294", Offset = "0x70AD294", VA = "0x70B1294")]
		public bool IsShowPolicy()
		{
			return default;
		}

		[Token(Token = "0x6001949")]
		[Address(RVA = "0x70B13BC", Offset = "0x70AD3BC", VA = "0x70B13BC")]
		public void GotoTermsServiceStatic()
		{
		}

		[Token(Token = "0x600194A")]
		[Address(RVA = "0x70B14E0", Offset = "0x70AD4E0", VA = "0x70B14E0")]
		public void GotoPrivacyPolicyStatic()
		{
		}

		[Token(Token = "0x600194B")]
		[Address(RVA = "0x70B1604", Offset = "0x70AD604", VA = "0x70B1604")]
		public void OpenApp(int id)
		{
		}

		[Token(Token = "0x600194C")]
		[Address(RVA = "0x70B1734", Offset = "0x70AD734", VA = "0x70B1734")]
		public bool IsAppInstalled(int id)
		{
			return default;
		}

		[Token(Token = "0x600194D")]
		[Address(RVA = "0x70B1868", Offset = "0x70AD868", VA = "0x70B1868")]
		public bool IsShowRealNameRegistration()
		{
			return default;
		}

		[Token(Token = "0x600194E")]
		[Address(RVA = "0x70B1990", Offset = "0x70AD990", VA = "0x70B1990")]
		public bool IsShowContactInformation()
		{
			return default;
		}

		[Token(Token = "0x600194F")]
		[Address(RVA = "0x70B1AB8", Offset = "0x70ADAB8", VA = "0x70B1AB8")]
		public int GetDurationTimeStatic()
		{
			return default;
		}

		[Token(Token = "0x6001950")]
		[Address(RVA = "0x70B1BE0", Offset = "0x70ADBE0", VA = "0x70B1BE0")]
		public bool OnlineResStatic()
		{
			return default;
		}

		[Token(Token = "0x6001951")]
		[Address(RVA = "0x70AE990", Offset = "0x70AA990", VA = "0x70AE990")]
		internal void U3DGameStart()
		{
		}

		[Token(Token = "0x6001952")]
		[Address(RVA = "0x70B1D08", Offset = "0x70ADD08", VA = "0x70B1D08")]
		public void PreloadEffect(string path)
		{
		}

		[Token(Token = "0x6001953")]
		[Address(RVA = "0x70B1E38", Offset = "0x70ADE38", VA = "0x70B1E38")]
		public int PlayEffect(string path, bool isLoop)
		{
			return default;
		}

		[Token(Token = "0x6001954")]
		[Address(RVA = "0x70B1F88", Offset = "0x70ADF88", VA = "0x70B1F88")]
		public int PlayEffect(string path, bool isLoop, float pitch, float pan, float gain)
		{
			return default;
		}

		[Token(Token = "0x6001955")]
		[Address(RVA = "0x70B211C", Offset = "0x70AE11C", VA = "0x70B211C")]
		public void PauseEffect(int soundId)
		{
		}

		[Token(Token = "0x6001956")]
		[Address(RVA = "0x70B224C", Offset = "0x70AE24C", VA = "0x70B224C")]
		public void ResumeEffect(int soundId)
		{
		}

		[Token(Token = "0x6001957")]
		[Address(RVA = "0x70B237C", Offset = "0x70AE37C", VA = "0x70B237C")]
		public void StopEffect(int soundId)
		{
		}

		[Token(Token = "0x6001958")]
		[Address(RVA = "0x70B24AC", Offset = "0x70AE4AC", VA = "0x70B24AC")]
		public float GetEffectsVolume()
		{
			return default;
		}

		[Token(Token = "0x6001959")]
		[Address(RVA = "0x70B26B4", Offset = "0x70AE6B4", VA = "0x70B26B4")]
		public void SetEffectsVolume(float volume)
		{
		}

		[Token(Token = "0x600195A")]
		[Address(RVA = "0x70B27F4", Offset = "0x70AE7F4", VA = "0x70B27F4")]
		public void UnloadEffect(string path)
		{
		}

		[Token(Token = "0x600195B")]
		[Address(RVA = "0x70B2924", Offset = "0x70AE924", VA = "0x70B2924")]
		public void PauseAllEffects()
		{
		}

		[Token(Token = "0x600195C")]
		[Address(RVA = "0x70B2A48", Offset = "0x70AEA48", VA = "0x70B2A48")]
		public void ResumeAllEffects()
		{
		}

		[Token(Token = "0x600195D")]
		[Address(RVA = "0x70B2B6C", Offset = "0x70AEB6C", VA = "0x70B2B6C")]
		public void StopAllEffects()
		{
		}

		[Token(Token = "0x600195E")]
		[Address(RVA = "0x70B2C90", Offset = "0x70AEC90", VA = "0x70B2C90")]
		public void SetAudioFocus(bool isAudioFocus)
		{
		}

		[Token(Token = "0x600195F")]
		[Address(RVA = "0x70B2DC0", Offset = "0x70AEDC0", VA = "0x70B2DC0")]
		public void End()
		{
		}

		[Token(Token = "0x6001960")]
		[Address(RVA = "0x70B2EE4", Offset = "0x70AEEE4", VA = "0x70B2EE4")]
		public int GetDaysByFirstLaunch()
		{
			return default;
		}

		[Token(Token = "0x6001961")]
		[Address(RVA = "0x70A8128", Offset = "0x70A4128", VA = "0x70A8128")]
		public bool IsDebugVersion()
		{
			return default;
		}

		[Token(Token = "0x6001962")]
		[Address(RVA = "0x70B300C", Offset = "0x70AF00C", VA = "0x70B300C")]
		public int GetGameBanHaoType()
		{
			return default;
		}

		[Token(Token = "0x6001963")]
		[Address(RVA = "0x70B3134", Offset = "0x70AF134", VA = "0x70B3134")]
		public void ShowGameBanHao()
		{
		}

		[Token(Token = "0x6001964")]
		[Address(RVA = "0x70B3258", Offset = "0x70AF258", VA = "0x70B3258")]
		public string CreateQRcodeSyncStatic(string content, int widthPix, int heightPix, int padding)
		{
			return null;
		}

		[Token(Token = "0x6001965")]
		[Address(RVA = "0x70AA46C", Offset = "0x70A646C", VA = "0x70AA46C")]
		internal void CreateQRcodeAsyncStatic(string content, int widthPix, int heightPix, int padding)
		{
		}

		[Token(Token = "0x6001966")]
		[Address(RVA = "0x70B33D0", Offset = "0x70AF3D0", VA = "0x70B33D0")]
		internal string CheckSensitiveWord(string content)
		{
			return null;
		}

		[Token(Token = "0x6001967")]
		[Address(RVA = "0x70B3504", Offset = "0x70AF504", VA = "0x70B3504")]
		public void ShowUnionGameStatic(int gameType, string gameName)
		{
		}

		[Token(Token = "0x6001968")]
		[Address(RVA = "0x70B3650", Offset = "0x70AF650", VA = "0x70B3650")]
		public void GoUnionGameHomeStatic()
		{
		}

		[Token(Token = "0x6001969")]
		[Address(RVA = "0x70A7F2C", Offset = "0x70A3F2C", VA = "0x70A7F2C")]
		public int GetGameHomePageEngineStatic()
		{
			return default;
		}

		[Token(Token = "0x600196A")]
		[Address(RVA = "0x70AA8A0", Offset = "0x70A68A0", VA = "0x70AA8A0")]
		public int IsAllowedUserNotificationStatic()
		{
			return default;
		}

		[Token(Token = "0x600196B")]
		[Address(RVA = "0x70AA9B8", Offset = "0x70A69B8", VA = "0x70AA9B8")]
		public void ShowAllowedUserNotificationStatic()
		{
		}

		[Token(Token = "0x600196C")]
		[Address(RVA = "0x70B3774", Offset = "0x70AF774", VA = "0x70B3774")]
		public void CancelUserNotificationInfoStatic()
		{
		}

		[Token(Token = "0x600196D")]
		[Address(RVA = "0x70AAB20", Offset = "0x70A6B20", VA = "0x70AAB20")]
		internal void CreateUserNotificationInfoStatic(string title, string content, string dateStr, int type)
		{
		}

		[Token(Token = "0x600196E")]
		[Address(RVA = "0x70AAC90", Offset = "0x70A6C90", VA = "0x70AAC90")]
		internal void CreateBadgeNumberNotificationInfoStatic(string dateStr)
		{
		}

		[Token(Token = "0x600196F")]
		[Address(RVA = "0x70B3888", Offset = "0x70AF888", VA = "0x70B3888")]
		public string GetPreviousVersion()
		{
			return null;
		}

		[Token(Token = "0x6001970")]
		[Address(RVA = "0x70B39B0", Offset = "0x70AF9B0", VA = "0x70B39B0")]
		public int GetNetworkingStateStatic()
		{
			return default;
		}

		[Token(Token = "0x6001971")]
		[Address(RVA = "0x70B3AD8", Offset = "0x70AFAD8", VA = "0x70B3AD8")]
		public string GetShiLingTiShiStatic()
		{
			return null;
		}

		[Token(Token = "0x6001972")]
		[Address(RVA = "0x70B3C00", Offset = "0x70AFC00", VA = "0x70B3C00")]
		public void SetAppDebugStatic(int debug)
		{
		}

		[Token(Token = "0x6001973")]
		[Address(RVA = "0x70B3D30", Offset = "0x70AFD30", VA = "0x70B3D30")]
		public int GetAppDebugStatic(int debugLevel)
		{
			return default;
		}

		[Token(Token = "0x6001974")]
		[Address(RVA = "0x70B3E64", Offset = "0x70AFE64", VA = "0x70B3E64")]
		public bool CanShowOppoGameCenterStatic()
		{
			return default;
		}

		[Token(Token = "0x6001975")]
		[Address(RVA = "0x70B4074", Offset = "0x70B0074", VA = "0x70B4074")]
		public void OpenOppoGameCenterStatic()
		{
		}

		[Token(Token = "0x6001976")]
		[Address(RVA = "0x70B4198", Offset = "0x70B0198", VA = "0x70B4198")]
		public int GetKeyboardHeightStatic()
		{
			return default;
		}

		[Token(Token = "0x6001977")]
		[Address(RVA = "0x70B42C0", Offset = "0x70B02C0", VA = "0x70B42C0")]
		public int GetPhotoCameraAuthorizationStateStatic(int ptype)
		{
			return default;
		}

		[Token(Token = "0x6001978")]
		[Address(RVA = "0x70ABFFC", Offset = "0x70A7FFC", VA = "0x70ABFFC")]
		internal void ShowPhotoCameraAuthorizationStatic(int ptype)
		{
		}

		[Token(Token = "0x6001979")]
		[Address(RVA = "0x70AED90", Offset = "0x70AAD90", VA = "0x70AED90")]
		public long GetServerTimeByServerTimeZoneStatic()
		{
			return default;
		}

		[Token(Token = "0x600197A")]
		[Address(RVA = "0x70B43F4", Offset = "0x70B03F4", VA = "0x70B43F4")]
		public int GetAppInfoPageVersion()
		{
			return default;
		}

		[Token(Token = "0x600197B")]
		[Address(RVA = "0x70ADB7C", Offset = "0x70A9B7C", VA = "0x70ADB7C")]
		public void DownloadGoogleAsset(string moduleName)
		{
		}

		[Token(Token = "0x600197C")]
		[Address(RVA = "0x70AD654", Offset = "0x70A9654", VA = "0x70AD654")]
		public string GetGoogleAssetPath(string moduleName)
		{
			return null;
		}

		[Token(Token = "0x600197D")]
		[Address(RVA = "0x70AAE0C", Offset = "0x70A6E0C", VA = "0x70AAE0C")]
		internal void GameShowDelayNotify(string jsonStr)
		{
		}

		[Token(Token = "0x600197E")]
		[Address(RVA = "0x70AAF40", Offset = "0x70A6F40", VA = "0x70AAF40")]
		internal void GameClearLocalNotify(string notifyId)
		{
		}

		[Token(Token = "0x600197F")]
		[Address(RVA = "0x70B451C", Offset = "0x70B051C", VA = "0x70B451C")]
		public bool GameGetNotificationOpenState()
		{
			return default;
		}

		[Token(Token = "0x6001980")]
		[Address(RVA = "0x70AB240", Offset = "0x70A7240", VA = "0x70AB240")]
		public string GetGlobeIntent()
		{
			return null;
		}

		[Token(Token = "0x6001981")]
		[Address(RVA = "0x70B4644", Offset = "0x70B0644", VA = "0x70B4644")]
		public bool IsPocoTestStatic()
		{
			return default;
		}

		[Token(Token = "0x6001982")]
		[Address(RVA = "0x70B476C", Offset = "0x70B076C", VA = "0x70B476C")]
		public void SetUserProperty(string jsonString, bool isSaveToLocal)
		{
		}

		[Token(Token = "0x6001983")]
		[Address(RVA = "0x70B48B8", Offset = "0x70B08B8", VA = "0x70B48B8")]
		internal void CheckSensitiveWordByUrlStatic(string value)
		{
		}

		[Token(Token = "0x6001984")]
		[Address(RVA = "0x70B49E8", Offset = "0x70B09E8", VA = "0x70B49E8")]
		public void RedeemGetAllInfoStatic()
		{
		}

		[Token(Token = "0x6001985")]
		[Address(RVA = "0x70B4B0C", Offset = "0x70B0B0C", VA = "0x70B4B0C")]
		public void RedeemGetCodeStatic(string InfoId)
		{
		}

		[Token(Token = "0x6001986")]
		[Address(RVA = "0x70B4C3C", Offset = "0x70B0C3C", VA = "0x70B4C3C")]
		public void RedeemVerifyCodeStatic(string CdkCode)
		{
		}

		[Token(Token = "0x6001987")]
		[Address(RVA = "0x70B4D6C", Offset = "0x70B0D6C", VA = "0x70B4D6C")]
		public void RedeemOffCodeStatic(string InfoId, string CdkCode)
		{
		}

		[Token(Token = "0x6001988")]
		[Address(RVA = "0x70A94CC", Offset = "0x70A54CC", VA = "0x70A94CC")]
		internal string GetGameCDNDomainStatic(string key)
		{
			return null;
		}

		[Token(Token = "0x6001989")]
		[Address(RVA = "0x70A8A5C", Offset = "0x70A4A5C", VA = "0x70A8A5C")]
		internal string GetGameBizDomainStatic(string gamename, string businessName)
		{
			return null;
		}

		[Token(Token = "0x600198A")]
		[Address(RVA = "0x70B4EB8", Offset = "0x70B0EB8", VA = "0x70B4EB8")]
		public string GetGameBizIpStatic(string gamename, string businessName)
		{
			return null;
		}

		[Token(Token = "0x600198B")]
		[Address(RVA = "0x70B5008", Offset = "0x70B1008", VA = "0x70B5008")]
		public bool CheckCanOpenAppStatic(string packageName, string appleUrl)
		{
			return default;
		}

		[Token(Token = "0x600198C")]
		[Address(RVA = "0x70B513C", Offset = "0x70B113C", VA = "0x70B513C")]
		public bool OpenJumpAppActionStatic(string packageName, string appleUrl)
		{
			return default;
		}

		[Token(Token = "0x600198D")]
		[Address(RVA = "0x70B528C", Offset = "0x70B128C", VA = "0x70B528C")]
		public string GetOpenAppUserInfoStatic()
		{
			return null;
		}

		[Token(Token = "0x600198E")]
		[Address(RVA = "0x70AA22C", Offset = "0x70A622C", VA = "0x70AA22C")]
		public bool IsSupportLogStatic()
		{
			return default;
		}

		[Token(Token = "0x600198F")]
		[Address(RVA = "0x70B53A4", Offset = "0x70B13A4", VA = "0x70B53A4")]
		public void SetForbiddenBackPressStatic(bool forbidden)
		{
		}

		[Token(Token = "0x6001990")]
		[Address(RVA = "0x70AF2A4", Offset = "0x70AB2A4", VA = "0x70AF2A4")]
		internal void FileSelectorStatic(string fileFormat)
		{
		}

		[Token(Token = "0x6001991")]
		[Address(RVA = "0x70AEFB4", Offset = "0x70AAFB4", VA = "0x70AEFB4")]
		public long GetServerTimeStatic()
		{
			return default;
		}

		[Token(Token = "0x6001992")]
		[Address(RVA = "0x70B54D4", Offset = "0x70B14D4", VA = "0x70B54D4")]
		public bool IsCurrentVersionOnlineParam()
		{
			return default;
		}

		[Token(Token = "0x6001993")]
		[Address(RVA = "0x70AF16C", Offset = "0x70AB16C", VA = "0x70AF16C")]
		internal void StartSettingStatic(string pageTitle)
		{
		}

		[Token(Token = "0x6001994")]
		[Address(RVA = "0x70B55FC", Offset = "0x70B15FC", VA = "0x70B55FC")]
		public bool IsShowMoreSettingStatic()
		{
			return default;
		}

		[Token(Token = "0x6001995")]
		[Address(RVA = "0x70B5724", Offset = "0x70B1724", VA = "0x70B5724")]
		public void SetGlobeIntent(string value)
		{
		}

		[Token(Token = "0x6001996")]
		[Address(RVA = "0x70AB664", Offset = "0x70A7664", VA = "0x70AB664")]
		internal void CheckThirdSensitiveInfoStatic(int etype, string checkInfo, string scenestr)
		{
		}

		[Token(Token = "0x6001997")]
		[Address(RVA = "0x70B5854", Offset = "0x70B1854", VA = "0x70B5854")]
		public long GetGoogleAssetTotalSize(string moduleName)
		{
			return default;
		}

		[Token(Token = "0x6001998")]
		[Address(RVA = "0x70B5988", Offset = "0x70B1988", VA = "0x70B5988")]
		public long GetGoogleAssetDownloadSize(string moduleName)
		{
			return default;
		}

		[Token(Token = "0x6001999")]
		[Address(RVA = "0x70B5ABC", Offset = "0x70B1ABC", VA = "0x70B5ABC")]
		public int GameGetDevicePerformanceScore()
		{
			return default;
		}

		[Token(Token = "0x600199A")]
		[Address(RVA = "0x70B5BE4", Offset = "0x70B1BE4", VA = "0x70B5BE4")]
		public string GameGetDevicePerformanceJson()
		{
			return null;
		}

		[Token(Token = "0x600199B")]
		[Address(RVA = "0x70B5D0C", Offset = "0x70B1D0C", VA = "0x70B5D0C")]
		public string GetGameNetGroup()
		{
			return null;
		}

		[Token(Token = "0x600199C")]
		[Address(RVA = "0x70B5E34", Offset = "0x70B1E34", VA = "0x70B5E34")]
		internal void ReportException(int etype, string ename, string message, string stackTrace, bool quitProgram)
		{
		}

		[Token(Token = "0x600199D")]
		[Address(RVA = "0x70B5FB4", Offset = "0x70B1FB4", VA = "0x70B5FB4")]
		public void SetGameLoginAccountId(string accountId, string serverGroupId, string serverId)
		{
		}

		[Token(Token = "0x600199E")]
		[Address(RVA = "0x70B610C", Offset = "0x70B210C", VA = "0x70B610C")]
		public void UploadCloudArchive(string key, string value)
		{
		}

		[Token(Token = "0x600199F")]
		[Address(RVA = "0x70B6258", Offset = "0x70B2258", VA = "0x70B6258")]
		public void PullCloudArchive(string key)
		{
		}

		[Token(Token = "0x60019A0")]
		[Address(RVA = "0x70B6388", Offset = "0x70B2388", VA = "0x70B6388")]
		public void RestartAppStatic()
		{
		}

		[Token(Token = "0x60019A1")]
		[Address(RVA = "0x70A9264", Offset = "0x70A5264", VA = "0x70A9264")]
		internal string GetGameBizInfoStatic(string gamename, string businessName)
		{
			return null;
		}

		[Token(Token = "0x60019A2")]
		[Address(RVA = "0x70B006C", Offset = "0x70AC06C", VA = "0x70B006C")]
		internal void GetChannelGiftGoods()
		{
		}

		[Token(Token = "0x60019A3")]
		[Address(RVA = "0x70B069C", Offset = "0x70AC69C", VA = "0x70B069C")]
		internal void ClaimChannelGiftGoods(string idList)
		{
		}

		[Token(Token = "0x60019A4")]
		[Address(RVA = "0x70B64AC", Offset = "0x70B24AC", VA = "0x70B64AC")]
		public void GameOpenFacebookUrl(string url)
		{
		}

		[Token(Token = "0x60019A5")]
		[Address(RVA = "0x70B65DC", Offset = "0x70B25DC", VA = "0x70B65DC")]
		public string QuerySqliteDataByKey(string key)
		{
			return null;
		}

		[Token(Token = "0x60019A6")]
		[Address(RVA = "0x70AA600", Offset = "0x70A6600", VA = "0x70AA600")]
		internal void RequestNoticificationPermission()
		{
		}

		[Token(Token = "0x60019A7")]
		[Address(RVA = "0x70B6854", Offset = "0x70B2854", VA = "0x70B6854")]
		internal void ScheduleInAppMessageStatic()
		{
		}

		[Token(Token = "0x60019A8")]
		[Address(RVA = "0x70B6978", Offset = "0x70B2978", VA = "0x70B6978")]
		public void JumpToNotificationSettings()
		{
		}

		[Token(Token = "0x60019A9")]
		[Address(RVA = "0x70B6A9C", Offset = "0x70B2A9C", VA = "0x70B6A9C")]
		internal void LogD(string tag, string msg)
		{
		}

		[Token(Token = "0x60019AA")]
		[Address(RVA = "0x70B6BE8", Offset = "0x70B2BE8", VA = "0x70B6BE8")]
		public SDKToolManager()
		{
		}
	}
}
