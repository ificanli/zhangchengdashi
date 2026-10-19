using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YooAsset;

namespace GameFramework
{
	[Token(Token = "0x2000390")]
	public class PatchManager
	{
		[Token(Token = "0x2000391")]
		private sealed class _0088_00B7Uy_009C_0087 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001B66")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001B67")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001B68")]
			[FieldOffset(Offset = "0x20")]
			public PatchManager _003C_003E4__this;

			[Token(Token = "0x4001B69")]
			[FieldOffset(Offset = "0x28")]
			public _008BUv_0085_008F_00A1 patchResult;

			[Token(Token = "0x4001B6A")]
			[FieldOffset(Offset = "0x30")]
			public PatchProcess patchProcess;

			[Token(Token = "0x4001B6B")]
			[FieldOffset(Offset = "0x38")]
			private UpdatePackageVersionOperation _003CserverVersionInfoOperation_003E5__2;

			[Token(Token = "0x4001B6C")]
			[FieldOffset(Offset = "0x40")]
			private string _003Cver_003E5__3;

			[Token(Token = "0x4001B6D")]
			[FieldOffset(Offset = "0x48")]
			private long _003CserVer_L_003E5__4;

			[Token(Token = "0x4001B6E")]
			[FieldOffset(Offset = "0x50")]
			private long _003ClocalVersion_L_003E5__5;

			[Token(Token = "0x4001B6F")]
			[FieldOffset(Offset = "0x58")]
			private PreDownloadContentOperation _003CpreDownloadOperation_003E5__6;

			[Token(Token = "0x4001B70")]
			[FieldOffset(Offset = "0x60")]
			private ResourceDownloaderOperation _003Cdownloader_003E5__7;

			[Token(Token = "0x17001129")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005BE7")]
				[Address(RVA = "0x71B7900", Offset = "0x71B3900", VA = "0x71B7900", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700112A")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005BE9")]
				[Address(RVA = "0x71B7940", Offset = "0x71B3940", VA = "0x71B7940", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005BE4")]
			[Address(RVA = "0x71B6DE4", Offset = "0x71B2DE4", VA = "0x71B6DE4")]
			[DebuggerHidden]
			public _0088_00B7Uy_009C_0087(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005BE5")]
			[Address(RVA = "0x71B7130", Offset = "0x71B3130", VA = "0x71B7130", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005BE6")]
			[Address(RVA = "0x71B7134", Offset = "0x71B3134", VA = "0x71B7134", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005BE7")]
			[Address(RVA = "0x71B7900", Offset = "0x71B3900", VA = "0x71B7900", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005BE8")]
			[Address(RVA = "0x71B7908", Offset = "0x71B3908", VA = "0x71B7908", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005BE9")]
			[Address(RVA = "0x71B7940", Offset = "0x71B3940", VA = "0x71B7940", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000392")]
		private sealed class _0084_0094_0081_00A7_0095y : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001B71")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001B72")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001B73")]
			[FieldOffset(Offset = "0x20")]
			public PatchManager _003C_003E4__this;

			[Token(Token = "0x4001B74")]
			[FieldOffset(Offset = "0x28")]
			public Action<string, PatchResultErrorType> errorCallBack;

			[Token(Token = "0x4001B75")]
			[FieldOffset(Offset = "0x30")]
			public Action callback;

			[Token(Token = "0x4001B76")]
			[FieldOffset(Offset = "0x38")]
			private _008BUv_0085_008F_00A1 _003CpatchResult_003E5__2;

			[Token(Token = "0x1700112B")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005BED")]
				[Address(RVA = "0x71B7C1C", Offset = "0x71B3C1C", VA = "0x71B7C1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700112C")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005BEF")]
				[Address(RVA = "0x71B7C5C", Offset = "0x71B3C5C", VA = "0x71B7C5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005BEA")]
			[Address(RVA = "0x71B6B48", Offset = "0x71B2B48", VA = "0x71B6B48")]
			[DebuggerHidden]
			public _0084_0094_0081_00A7_0095y(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005BEB")]
			[Address(RVA = "0x71B7948", Offset = "0x71B3948", VA = "0x71B7948", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005BEC")]
			[Address(RVA = "0x71B794C", Offset = "0x71B394C", VA = "0x71B794C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005BED")]
			[Address(RVA = "0x71B7C1C", Offset = "0x71B3C1C", VA = "0x71B7C1C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005BEE")]
			[Address(RVA = "0x71B7C24", Offset = "0x71B3C24", VA = "0x71B7C24", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005BEF")]
			[Address(RVA = "0x71B7C5C", Offset = "0x71B3C5C", VA = "0x71B7C5C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4001B5A")]
		[FieldOffset(Offset = "0x10")]
		private PatchProcess _00A7_00B7uoU_00B2;

		[Token(Token = "0x4001B5B")]
		[FieldOffset(Offset = "0x18")]
		private ResourcePackage _00B1N_005D_009EV_009F;

		[Token(Token = "0x4001B5C")]
		private const int Y_0089lev_0083 = 10;

		[Token(Token = "0x4001B5D")]
		private const int _00BD_00B2F_00AF_00B8t = 3;

		[Token(Token = "0x4001B5E")]
		private const int _00AFF_00BD_0083_0087X = 10;

		[Token(Token = "0x4001B5F")]
		[FieldOffset(Offset = "0x20")]
		private EPlayMode _009C_00A4_007C_00A1_0083_0084;

		[Token(Token = "0x4001B60")]
		[FieldOffset(Offset = "0x24")]
		private bool _00AD_008Eu_0098Vª;

		[Token(Token = "0x4001B61")]
		[FieldOffset(Offset = "0x25")]
		private bool _00B1_0082_007B_0087_008B_0081;

		[Token(Token = "0x4001B62")]
		[FieldOffset(Offset = "0x28")]
		private DownloaderOperation.OnDownloadProgress dX_00BC_009C_00BE_00B8;

		[Token(Token = "0x4001B63")]
		[FieldOffset(Offset = "0x30")]
		private DownloaderOperation.OnStartDownloadFile h_00AC_00BFc_00B1_0085;

		[Token(Token = "0x4001B64")]
		[FieldOffset(Offset = "0x38")]
		private OnPreDownloadSize f_009Aµp_008CU;

		[Token(Token = "0x4001B65")]
		[FieldOffset(Offset = "0x40")]
		private bool T_0081_0098B_00BD_007C;

		[Token(Token = "0x17001125")]
		public DownloaderOperation.OnDownloadProgress OnDownloadProgressCallback
		{
			[Token(Token = "0x6005BBA")]
			[Address(RVA = "0x71B6C14", Offset = "0x71B2C14", VA = "0x71B6C14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BB2")]
			[Address(RVA = "0x71B6ACC", Offset = "0x71B2ACC", VA = "0x71B6ACC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001126")]
		public DownloaderOperation.OnStartDownloadFile OnStartDownloadFileCallback
		{
			[Token(Token = "0x6005BC6")]
			[Address(RVA = "0x71B6D68", Offset = "0x71B2D68", VA = "0x71B6D68")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BC8")]
			[Address(RVA = "0x71B6E0C", Offset = "0x71B2E0C", VA = "0x71B6E0C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001127")]
		public OnPreDownloadSize OnPreDownloadSizeCallBack
		{
			[Token(Token = "0x6005BD5")]
			[Address(RVA = "0x71B6F58", Offset = "0x71B2F58", VA = "0x71B6F58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BE0")]
			[Address(RVA = "0x71B7110", Offset = "0x71B3110", VA = "0x71B7110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001128")]
		public bool EmptyPackageFeature
		{
			[Token(Token = "0x6005BC3")]
			[Address(RVA = "0x71B6CAC", Offset = "0x71B2CAC", VA = "0x71B6CAC")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6005BCA")]
			[Address(RVA = "0x71B6E1C", Offset = "0x71B2E1C", VA = "0x71B6E1C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[SpecialName]
		[Token(Token = "0x6005BB0")]
		[Address(RVA = "0x71B6ABC", Offset = "0x71B2ABC", VA = "0x71B6ABC")]
		public DownloaderOperation.OnStartDownloadFile _007F_00A7Bn_00A7Á()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6005BB1")]
		[Address(RVA = "0x71B6AC4", Offset = "0x71B2AC4", VA = "0x71B6AC4")]
		public OnPreDownloadSize j_00ADQM_00B8D()
		{
			return null;
		}

		[Token(Token = "0x6005BB3")]
		[Address(RVA = "0x71B6AD4", Offset = "0x71B2AD4", VA = "0x71B6AD4")]
		private IEnumerator xI_00A7aÂµ(Action _00A3Y_0082I_00A7_00B4, Action<string, PatchResultErrorType> G_0092_009D_00A2gW)
		{
			return null;
		}

		[Token(Token = "0x6005BB4")]
		[Address(RVA = "0x71B6B70", Offset = "0x71B2B70", VA = "0x71B6B70")]
		[CompilerGenerated]
		private bool b_00BFQ_007FUl()
		{
			return default;
		}

		[Token(Token = "0x6005BB5")]
		[Address(RVA = "0x71B6B78", Offset = "0x71B2B78", VA = "0x71B6B78")]
		public void Retry()
		{
		}

		[SpecialName]
		[Token(Token = "0x6005BB6")]
		[Address(RVA = "0x71B6B84", Offset = "0x71B2B84", VA = "0x71B6B84")]
		public void _0087_00B2eY_0095_008D(OnPreDownloadSize _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6005BB7")]
		[Address(RVA = "0x71B6B8C", Offset = "0x71B2B8C", VA = "0x71B6B8C")]
		public bool _00AD_00B6l_008B_00B7U()
		{
			return default;
		}

		[Token(Token = "0x6005BB8")]
		[Address(RVA = "0x71B6B94", Offset = "0x71B2B94", VA = "0x71B6B94")]
		private IEnumerator _00AF_00B3at_008F_00B7(Action _00A3Y_0082I_00A7_00B4, Action<string, PatchResultErrorType> G_0092_009D_00A2gW)
		{
			return null;
		}

		[Token(Token = "0x6005BB9")]
		[Address(RVA = "0x71B6C0C", Offset = "0x71B2C0C", VA = "0x71B6C0C")]
		private bool _0086Q_00BBl_00ABB()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6005BBB")]
		[Address(RVA = "0x71B6C1C", Offset = "0x71B2C1C", VA = "0x71B6C1C")]
		public DownloaderOperation.OnDownloadProgress _00A1_008BÀ_00A6_00B3y()
		{
			return null;
		}

		[Token(Token = "0x6005BBC")]
		[Address(RVA = "0x71B6C24", Offset = "0x71B2C24", VA = "0x71B6C24")]
		public void _009A_00BDz_0088ªi()
		{
		}

		[SpecialName]
		[Token(Token = "0x6005BBD")]
		[Address(RVA = "0x71B6C2C", Offset = "0x71B2C2C", VA = "0x71B6C2C")]
		public DownloaderOperation.OnDownloadProgress l_0096DAvU()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6005BBE")]
		[Address(RVA = "0x71B6C34", Offset = "0x71B2C34", VA = "0x71B6C34")]
		public void T_0095_00A6av_0086(OnPreDownloadSize _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6005BBF")]
		[Address(RVA = "0x71B6C3C", Offset = "0x71B2C3C", VA = "0x71B6C3C")]
		public void E_00A2o_0080F_009C(Action _00A3Y_0082I_00A7_00B4, Action<string, PatchResultErrorType> G_0092_009D_00A2gW)
		{
		}

		[Token(Token = "0x6005BC0")]
		[Address(RVA = "0x71B6C94", Offset = "0x71B2C94", VA = "0x71B6C94")]
		[CompilerGenerated]
		private bool _00ABZe_009D_005Ez()
		{
			return default;
		}

		[Token(Token = "0x6005BC1")]
		[Address(RVA = "0x71B6C9C", Offset = "0x71B2C9C", VA = "0x71B6C9C")]
		private bool _009Cw_00BEL_008Ev()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6005BC2")]
		[Address(RVA = "0x71B6CA4", Offset = "0x71B2CA4", VA = "0x71B6CA4")]
		public bool O_0089V_00A9LF()
		{
			return default;
		}

		[Token(Token = "0x6005BC4")]
		[Address(RVA = "0x71B6CB4", Offset = "0x71B2CB4", VA = "0x71B6CB4")]
		public PatchManager(PatchProcess _00BE_009A_0083_00AB_0091G = PatchProcess.V1)
		{
		}

		[SpecialName]
		[Token(Token = "0x6005BC5")]
		[Address(RVA = "0x71B6D60", Offset = "0x71B2D60", VA = "0x71B6D60")]
		public bool d_0094W_00B1SI()
		{
			return default;
		}

		[Token(Token = "0x6005BC7")]
		[Address(RVA = "0x71B6D70", Offset = "0x71B2D70", VA = "0x71B6D70")]
		[IteratorStateMachine(typeof(_0088_00B7Uy_009C_0087))]
		private IEnumerator dB_0080_009F_0088_00AC(_008BUv_0085_008F_00A1 Q_00A5V_00B3l_00B6, PatchProcess _00BE_009A_0083_00AB_0091G = PatchProcess.V1)
		{
			return null;
		}

		[Token(Token = "0x6005BC9")]
		[Address(RVA = "0x71B6E14", Offset = "0x71B2E14", VA = "0x71B6E14")]
		public void j_00AB_008BI_0084_00A5()
		{
		}

		[Token(Token = "0x6005BCB")]
		[Address(RVA = "0x71B6E28", Offset = "0x71B2E28", VA = "0x71B6E28")]
		private IEnumerator QÂ_00B2Re_0083(_008BUv_0085_008F_00A1 Q_00A5V_00B3l_00B6, PatchProcess _00BE_009A_0083_00AB_0091G = PatchProcess.V1)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6005BCC")]
		[Address(RVA = "0x71B6E9C", Offset = "0x71B2E9C", VA = "0x71B6E9C")]
		public DownloaderOperation.OnStartDownloadFile _007C_00BB_007ERH_009E()
		{
			return null;
		}

		[Token(Token = "0x6005BCD")]
		[Address(RVA = "0x71B6EA4", Offset = "0x71B2EA4", VA = "0x71B6EA4")]
		public void _0088_0060z_00AD_009F_00B9()
		{
		}

		[SpecialName]
		[Token(Token = "0x6005BCE")]
		[Address(RVA = "0x71B6EAC", Offset = "0x71B2EAC", VA = "0x71B6EAC")]
		public DownloaderOperation.OnDownloadProgress _0094_008Er_00B0_008E_0096()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6005BCF")]
		[Address(RVA = "0x71B6EB4", Offset = "0x71B2EB4", VA = "0x71B6EB4")]
		public void yaµ_008A_0082_00B2(DownloaderOperation.OnDownloadProgress _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6005BD0")]
		[Address(RVA = "0x71B6EBC", Offset = "0x71B2EBC", VA = "0x71B6EBC")]
		private bool EO_0093_007F_00BD_00A6()
		{
			return default;
		}

		[Token(Token = "0x6005BD1")]
		[Address(RVA = "0x71B6EC4", Offset = "0x71B2EC4", VA = "0x71B6EC4")]
		public void ConfirmStart()
		{
		}

		[Token(Token = "0x6005BD2")]
		[Address(RVA = "0x71B6ED0", Offset = "0x71B2ED0", VA = "0x71B6ED0")]
		private bool ÁO_00BBXdT()
		{
			return default;
		}

		[Token(Token = "0x6005BD3")]
		[Address(RVA = "0x71B6ED8", Offset = "0x71B2ED8", VA = "0x71B6ED8")]
		private IEnumerator _00A6A_0093x_00AEU(_008BUv_0085_008F_00A1 Q_00A5V_00B3l_00B6, PatchProcess _00BE_009A_0083_00AB_0091G = PatchProcess.V1)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6005BD4")]
		[Address(RVA = "0x71B6F50", Offset = "0x71B2F50", VA = "0x71B6F50")]
		public DownloaderOperation.OnDownloadProgress _00A6À_0095OGp()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6005BD6")]
		[Address(RVA = "0x71B6F60", Offset = "0x71B2F60", VA = "0x71B6F60")]
		public DownloaderOperation.OnStartDownloadFile _0089W_0097e_005E_00B9()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6005BD7")]
		[Address(RVA = "0x71B6F68", Offset = "0x71B2F68", VA = "0x71B6F68")]
		public void Hn_0080_009BKi(OnPreDownloadSize _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6005BD8")]
		[Address(RVA = "0x71B6F70", Offset = "0x71B2F70", VA = "0x71B6F70")]
		public void _0083_007BA_00BD_0088k(Action _00A3Y_0082I_00A7_00B4, Action<string, PatchResultErrorType> G_0092_009D_00A2gW)
		{
		}

		[Token(Token = "0x6005BD9")]
		[Address(RVA = "0x71B6FC8", Offset = "0x71B2FC8", VA = "0x71B6FC8")]
		public void U_00A9_0091h_00AE_00A2()
		{
		}

		[Token(Token = "0x6005BDA")]
		[Address(RVA = "0x71B6FD4", Offset = "0x71B2FD4", VA = "0x71B6FD4")]
		[IteratorStateMachine(typeof(_0084_0094_0081_00A7_0095y))]
		private IEnumerator MÂR_00B6_0083_008C(Action _00A3Y_0082I_00A7_00B4, Action<string, PatchResultErrorType> G_0092_009D_00A2gW)
		{
			return null;
		}

		[Token(Token = "0x6005BDB")]
		[Address(RVA = "0x71B7048", Offset = "0x71B3048", VA = "0x71B7048")]
		public void _00A6pTÂ_00B8T()
		{
		}

		[SpecialName]
		[Token(Token = "0x6005BDC")]
		[Address(RVA = "0x71B7050", Offset = "0x71B3050", VA = "0x71B7050")]
		public DownloaderOperation.OnDownloadProgress O_00A0_0094_0085Y_0081()
		{
			return null;
		}

		[Token(Token = "0x6005BDD")]
		[Address(RVA = "0x71B7058", Offset = "0x71B3058", VA = "0x71B7058")]
		public void StartPatch(Action _00A3Y_0082I_00A7_00B4, Action<string, PatchResultErrorType> G_0092_009D_00A2gW)
		{
		}

		[SpecialName]
		[Token(Token = "0x6005BDE")]
		[Address(RVA = "0x71B70B0", Offset = "0x71B30B0", VA = "0x71B70B0")]
		public DownloaderOperation.OnDownloadProgress djYªx_0091()
		{
			return null;
		}

		[Token(Token = "0x6005BDF")]
		[Address(RVA = "0x71B70B8", Offset = "0x71B30B8", VA = "0x71B70B8")]
		public void _00AE_009FA_0060o_0098(Action _00A3Y_0082I_00A7_00B4, Action<string, PatchResultErrorType> G_0092_009D_00A2gW)
		{
		}

		[Token(Token = "0x6005BE1")]
		[Address(RVA = "0x71B7118", Offset = "0x71B3118", VA = "0x71B7118")]
		public void _0085tqH_00A5_00B3()
		{
		}

		[Token(Token = "0x6005BE2")]
		[Address(RVA = "0x71B7120", Offset = "0x71B3120", VA = "0x71B7120")]
		public void _00B3_008FGT_0097b()
		{
		}

		[Token(Token = "0x6005BE3")]
		[Address(RVA = "0x71B7128", Offset = "0x71B3128", VA = "0x71B7128")]
		private bool T_00A2_00A2Â_008C_00B7()
		{
			return default;
		}
	}
}
