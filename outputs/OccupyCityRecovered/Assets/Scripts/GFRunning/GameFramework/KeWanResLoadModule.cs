using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace GameFramework
{
	[Token(Token = "0x2000388")]
	public class KeWanResLoadModule : GameFrameModule, IResIntegration
	{
		[Token(Token = "0x2000389")]
		private sealed class _009CV_0083w_0095_0092
		{
			[Token(Token = "0x4001B41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sceneName;

			[Token(Token = "0x4001B42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string sceneNameToLoad;

			[Token(Token = "0x4001B43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<SceneOperationHandle> handler;

			[Token(Token = "0x4001B44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SceneOperationHandle soh;

			[Token(Token = "0x6005B79")]
			[Address(RVA = "0x71B1110", Offset = "0x71AD110", VA = "0x71B1110")]
			public _009CV_0083w_0095_0092()
			{
			}

			[Token(Token = "0x6005B7A")]
			[Address(RVA = "0x71B2D70", Offset = "0x71AED70", VA = "0x71B2D70")]
			internal void _0096ª_007Efl_0085(AsyncOperation op)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200038A")]
		private struct _008AA_00BC_009D_009EC : IAsyncStateMachine
		{
			[Token(Token = "0x4001B45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AssetOperationHandle> _003C_003Et__builder;

			[Token(Token = "0x4001B47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string assetBundleName;

			[Token(Token = "0x4001B48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public KeWanResLoadModule _003C_003E4__this;

			[Token(Token = "0x4001B49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x6005B7B")]
			[Address(RVA = "0x71B2EA0", Offset = "0x71AEEA0", VA = "0x71B2EA0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005B7C")]
			[Address(RVA = "0x71B315C", Offset = "0x71AF15C", VA = "0x71B315C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200038B")]
		private struct _005D_00BFB_009AU_009A<T> : IAsyncStateMachine where T : UnityEngine.Object
		{
			[Token(Token = "0x4001B4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<AssetOperationHandle> _003C_003Et__builder;

			[Token(Token = "0x4001B4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetBundleName;

			[Token(Token = "0x4001B4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public KeWanResLoadModule _003C_003E4__this;

			[Token(Token = "0x4001B4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x6005B7D")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005B7E")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200038C")]
		private struct _009Dc_008E_00AF_007CX : IAsyncStateMachine
		{
			[Token(Token = "0x4001B4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AssetOperationHandle> _003C_003Et__builder;

			[Token(Token = "0x4001B51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string assetBundleName;

			[Token(Token = "0x4001B52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public KeWanResLoadModule _003C_003E4__this;

			[Token(Token = "0x4001B53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x6005B7F")]
			[Address(RVA = "0x71B31D8", Offset = "0x71AF1D8", VA = "0x71B31D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005B80")]
			[Address(RVA = "0x71B3694", Offset = "0x71AF694", VA = "0x71B3694", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001B3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IResIntegration d_008AX_005EG_00A5;

		[Token(Token = "0x4001B3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, AssetItem> _00A3_00ACf_00A8_0084o;

		[Token(Token = "0x4001B3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, List<AssetItem>> _008D_00AF_0098W_00A3o;

		[Token(Token = "0x4001B40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<string> _0098Á_008F_00B4_009DJ;

		[Token(Token = "0x6005B2F")]
		[Address(RVA = "0x71AC8D4", Offset = "0x71A88D4", VA = "0x71AC8D4", Slot = "9")]
		internal override void Shutdown()
		{
		}

		[Token(Token = "0x6005B30")]
		[Address(RVA = "0x71AC950", Offset = "0x71A8950", VA = "0x71AC950")]
		public int _008EVN_00A0U_0087()
		{
			return default;
		}

		[Token(Token = "0x6005B31")]
		[Address(RVA = "0x71AC9AC", Offset = "0x71A89AC", VA = "0x71AC9AC")]
		public bool Â_00A7yx_007E_00B7(string _00AFdV_00B0_0099_0082)
		{
			return default;
		}

		[Token(Token = "0x6005B32")]
		[Address(RVA = "0x71ACA58", Offset = "0x71A8A58", VA = "0x71ACA58")]
		private UnityEngine.Object L_00A3_00A9vha(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B33")]
		[AsyncStateMachine(typeof(global::GameFramework.KeWanResLoadModule._005D_00BFB_009AU_009A<>))]
		public Task<AssetOperationHandle> LoadAssetAsync<T>(string µZºV_0089_00AB) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005B34")]
		[Address(RVA = "0x71ACCC8", Offset = "0x71A8CC8", VA = "0x71ACCC8")]
		public string _009F_00AE_00AB_0094jm(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B35")]
		[Address(RVA = "0x71ACEB4", Offset = "0x71A8EB4", VA = "0x71ACEB4", Slot = "19")]
		[AsyncStateMachine(typeof(_008AA_00BC_009D_009EC))]
		public Task<AssetOperationHandle> GetSpriteByTexture(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6005B36")]
		[Address(RVA = "0x71ACFA0", Offset = "0x71A8FA0", VA = "0x71ACFA0", Slot = "13")]
		public AssetOperationHandle LoadAssetSync(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6005B37")]
		[Address(RVA = "0x71ACFF8", Offset = "0x71A8FF8", VA = "0x71ACFF8")]
		private string _00A4WGUH_00B4(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B38")]
		public T GetAsset<T>(string _00AFdV_00B0_0099_0082) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005B39")]
		[Address(RVA = "0x71ACCCC", Offset = "0x71A8CCC", VA = "0x71ACCCC")]
		private string _00A8FÁd_00BBL(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B3A")]
		[Address(RVA = "0x71AD698", Offset = "0x71A9698", VA = "0x71AD698")]
		private string U_008Dv_0082_009A_008D(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B3B")]
		[Address(RVA = "0x71AD880", Offset = "0x71A9880", VA = "0x71AD880", Slot = "14")]
		public AssetOperationHandle LoadPrefab(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w)
		{
			return null;
		}

		[Token(Token = "0x6005B3C")]
		[Address(RVA = "0x71ADB40", Offset = "0x71A9B40", VA = "0x71ADB40")]
		private string _008A_007Ep_00A7d_00B6(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B3D")]
		[Address(RVA = "0x71ADD2C", Offset = "0x71A9D2C", VA = "0x71ADD2C")]
		public List<LoadedAssetInfo> E_0093GwAN()
		{
			return null;
		}

		[Token(Token = "0x6005B3E")]
		[Address(RVA = "0x71AE064", Offset = "0x71AA064", VA = "0x71AE064")]
		private void L_0097VGJ_00A1(string _00AFdV_00B0_0099_0082)
		{
		}

		[Token(Token = "0x6005B3F")]
		[Address(RVA = "0x71AE108", Offset = "0x71AA108", VA = "0x71AE108", Slot = "22")]
		public Task<AssetOperationHandle> _008F_009C_0096J_00A9C(string µZºV_0089_00AB, [Optional] string M_009E_00AD_005B_007CO)
		{
			return null;
		}

		[Token(Token = "0x6005B40")]
		[Address(RVA = "0x71AE1F4", Offset = "0x71AA1F4", VA = "0x71AE1F4")]
		public List<string> bzvxºM()
		{
			return null;
		}

		[Token(Token = "0x6005B41")]
		[Address(RVA = "0x71AE2BC", Offset = "0x71AA2BC", VA = "0x71AE2BC", Slot = "23")]
		public void _007CD_00B4_0083_00BB_009E()
		{
		}

		[Token(Token = "0x6005B42")]
		[Address(RVA = "0x71AE2C0", Offset = "0x71AA2C0", VA = "0x71AE2C0")]
		public string GetSceneName(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B43")]
		[Address(RVA = "0x71AE2C4", Offset = "0x71AA2C4", VA = "0x71AE2C4", Slot = "21")]
		public AllAssetsOperationHandle LoadAllAssets(string _00B8_007CL_0094_0090l, [Optional] Action<AllAssetsOperationHandle> _0091_00BF_0099sB_007E)
		{
			return null;
		}

		[Token(Token = "0x6005B44")]
		[Address(RVA = "0x71AE9B4", Offset = "0x71AA9B4", VA = "0x71AE9B4")]
		[Conditional("UNITY_EDITOR")]
		private void _00BE_005Eº_00BC_00BD_00A1(string _00AFdV_00B0_0099_0082)
		{
		}

		[Token(Token = "0x6005B45")]
		[Address(RVA = "0x71AEA58", Offset = "0x71AAA58", VA = "0x71AEA58")]
		public List<LoadedAssetInfo> _0091GACg_005D()
		{
			return null;
		}

		[Token(Token = "0x6005B46")]
		[Address(RVA = "0x71AED54", Offset = "0x71AAD54", VA = "0x71AED54", Slot = "11")]
		public AssetOperationHandle LoadAsset(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, [Optional] object[] h_00A6_00BB_00B2_0089w)
		{
			return null;
		}

		[Token(Token = "0x6005B47")]
		public AssetOperationHandle LoadAsset<T>(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, [Optional] object[] h_00A6_00BB_00B2_0089w) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005B48")]
		private T Yn_00A2q_008CI<T>(string _00AFdV_00B0_0099_0082) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005B49")]
		[Address(RVA = "0x71AF01C", Offset = "0x71AB01C", VA = "0x71AF01C")]
		public UnityEngine.Object _0083_00B4_008C_0094oX(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B4A")]
		[Address(RVA = "0x71AF04C", Offset = "0x71AB04C", VA = "0x71AF04C")]
		private string _00AB_005Ej_00A7nB(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B4B")]
		[Address(RVA = "0x71AD1E8", Offset = "0x71A91E8", VA = "0x71AD1E8")]
		private AssetItem Y_0084_0080y_008CK(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B4C")]
		[Address(RVA = "0x71AF0EC", Offset = "0x71AB0EC", VA = "0x71AF0EC", Slot = "6")]
		internal override void Start()
		{
		}

		[Token(Token = "0x6005B4D")]
		[Address(RVA = "0x71ACA70", Offset = "0x71A8A70", VA = "0x71ACA70")]
		private AssetItem Ât_008A_00AE_0087_0086(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B4E")]
		[Address(RVA = "0x71AF0F0", Offset = "0x71AB0F0", VA = "0x71AF0F0", Slot = "24")]
		public AssetOperationHandle _00BBx_0084_00B0_00B4_0080(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, [Optional] object[] h_00A6_00BB_00B2_0089w)
		{
			return null;
		}

		[Token(Token = "0x6005B4F")]
		[Address(RVA = "0x71AF3A4", Offset = "0x71AB3A4", VA = "0x71AF3A4", Slot = "18")]
		public void UnloadUnusedAssets()
		{
		}

		[Token(Token = "0x6005B50")]
		[Address(RVA = "0x71AF3A8", Offset = "0x71AB3A8", VA = "0x71AF3A8")]
		public int QC_00A5c_0091h()
		{
			return default;
		}

		[Token(Token = "0x6005B51")]
		public AssetOperationHandle LoadAssetSync<T>(string µZºV_0089_00AB) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005B52")]
		[Address(RVA = "0x71AF400", Offset = "0x71AB400", VA = "0x71AF400", Slot = "25")]
		public AssetOperationHandle _005D_009C_00B6_00A8_007D_0093(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
			return null;
		}

		[Token(Token = "0x6005B53")]
		[Address(RVA = "0x71AF6C4", Offset = "0x71AB6C4", VA = "0x71AF6C4")]
		public List<string> GetAllAddresses()
		{
			return null;
		}

		[Token(Token = "0x6005B54")]
		[Address(RVA = "0x71AF78C", Offset = "0x71AB78C", VA = "0x71AF78C")]
		public int GetLoadedAssetCount()
		{
			return default;
		}

		[Token(Token = "0x6005B55")]
		[Address(RVA = "0x71AF7D4", Offset = "0x71AB7D4", VA = "0x71AF7D4")]
		public KeWanResLoadModule()
		{
		}

		[Token(Token = "0x6005B56")]
		[Address(RVA = "0x71AF850", Offset = "0x71AB850", VA = "0x71AF850")]
		public AssetItem m_00A3_00BF_00A8_0093m(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B57")]
		[Address(RVA = "0x71AFAB0", Offset = "0x71ABAB0", VA = "0x71AFAB0")]
		public List<LoadedAssetInfo> GetLoadedAssetInfos()
		{
			return null;
		}

		[Token(Token = "0x6005B58")]
		[Address(RVA = "0x71AFD9C", Offset = "0x71ABD9C", VA = "0x71AFD9C")]
		public string GetAssetPath(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B59")]
		[Address(RVA = "0x71AFDB4", Offset = "0x71ABDB4", VA = "0x71AFDB4")]
		public int GetMappingCount()
		{
			return default;
		}

		[Token(Token = "0x6005B5A")]
		[Address(RVA = "0x71AFE0C", Offset = "0x71ABE0C", VA = "0x71AFE0C", Slot = "7")]
		internal override void Update(float _008EJ_0092_009BUc, float rfjÀ_0098L)
		{
		}

		[Token(Token = "0x6005B5B")]
		[Address(RVA = "0x71AFE10", Offset = "0x71ABE10", VA = "0x71AFE10")]
		public void ClearLoadedRecords()
		{
		}

		[Token(Token = "0x6005B5C")]
		[Address(RVA = "0x71AFF04", Offset = "0x71ABF04", VA = "0x71AFF04")]
		private void b_005DwI_00B4Â(string _00AFdV_00B0_0099_0082)
		{
		}

		[Token(Token = "0x6005B5D")]
		[Address(RVA = "0x71AFFA8", Offset = "0x71ABFA8", VA = "0x71AFFA8", Slot = "26")]
		public AssetOperationHandle _009D_00BDS_007D_0081Â(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, [Optional] object[] h_00A6_00BB_00B2_0089w)
		{
			return null;
		}

		[Token(Token = "0x6005B5E")]
		[Address(RVA = "0x71B032C", Offset = "0x71AC32C", VA = "0x71B032C")]
		public string x_0089r_008AJf(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B5F")]
		[Address(RVA = "0x71B0344", Offset = "0x71AC344", VA = "0x71B0344")]
		public int T_0097V_00AD_0099_009D()
		{
			return default;
		}

		[Token(Token = "0x6005B60")]
		[Address(RVA = "0x71B03A0", Offset = "0x71AC3A0", VA = "0x71B03A0", Slot = "27")]
		public AllAssetsOperationHandle _005E_0093_008C_0098_00A7K(string _00B8_007CL_0094_0090l, [Optional] Action<AllAssetsOperationHandle> _0091_00BF_0099sB_007E)
		{
			return null;
		}

		[Token(Token = "0x6005B61")]
		[Address(RVA = "0x71B0AC4", Offset = "0x71ACAC4", VA = "0x71B0AC4", Slot = "28")]
		public AssetOperationHandle _00A7_008FU_00B1_00AF_0096(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, [Optional] object[] h_00A6_00BB_00B2_0089w)
		{
			return null;
		}

		[Token(Token = "0x6005B62")]
		[Address(RVA = "0x71B0B94", Offset = "0x71ACB94", VA = "0x71B0B94", Slot = "29")]
		public SceneOperationHandle _007F_007D_008C_008B_007CZ(string x_008A_00BE_0098_007Ej, [Optional] Action<SceneOperationHandle> _0091_00BF_0099sB_007E, [Optional][DefaultParameterValue(false)] bool _005Ddk_00A3Ol, [Optional][DefaultParameterValue(false)] bool _00A7Â_007By_007D_008A, [Optional] object[] h_00A6_00BB_00B2_0089w)
		{
			return null;
		}

		[Token(Token = "0x6005B63")]
		[Address(RVA = "0x71B1118", Offset = "0x71AD118", VA = "0x71B1118")]
		public AssetItem Q_00B0Y_008Bv_00A9(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B64")]
		[Address(RVA = "0x71B111C", Offset = "0x71AD11C", VA = "0x71B111C")]
		public bool ContainsAddress(string _00AFdV_00B0_0099_0082)
		{
			return default;
		}

		[Token(Token = "0x6005B65")]
		[Address(RVA = "0x71B11AC", Offset = "0x71AD1AC", VA = "0x71B11AC", Slot = "20")]
		public AssetOperationHandle LoadSpriteAtlas(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, [Optional] object[] h_00A6_00BB_00B2_0089w)
		{
			return null;
		}

		[Token(Token = "0x6005B66")]
		[Address(RVA = "0x71B127C", Offset = "0x71AD27C", VA = "0x71B127C", Slot = "5")]
		internal override void Initialize(params object[] FuV_00B8_00B2D)
		{
		}

		[Token(Token = "0x6005B67")]
		[Address(RVA = "0x71B1AB8", Offset = "0x71ADAB8", VA = "0x71B1AB8")]
		public List<LoadedAssetInfo> pn_0085_00AC_00B1_00A5()
		{
			return null;
		}

		[Token(Token = "0x6005B68")]
		[Address(RVA = "0x71B1DB4", Offset = "0x71ADDB4", VA = "0x71B1DB4")]
		public AssetItem GetAssetItem(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B69")]
		[Address(RVA = "0x71B1DB8", Offset = "0x71ADDB8", VA = "0x71B1DB8", Slot = "15")]
		public SceneOperationHandle LoadScene(string x_008A_00BE_0098_007Ej, [Optional] Action<SceneOperationHandle> _0091_00BF_0099sB_007E, [Optional][DefaultParameterValue(false)] bool _005Ddk_00A3Ol, [Optional][DefaultParameterValue(false)] bool _00A7Â_007By_007D_008A, [Optional] object[] h_00A6_00BB_00B2_0089w)
		{
			return null;
		}

		[Token(Token = "0x6005B6A")]
		[Address(RVA = "0x71B2334", Offset = "0x71AE334", VA = "0x71B2334")]
		public List<string> GetLoadedAssetAddresses()
		{
			return null;
		}

		[Token(Token = "0x6005B6B")]
		[Address(RVA = "0x71B23B0", Offset = "0x71AE3B0", VA = "0x71B23B0")]
		public List<LoadedAssetInfo> n_0096ag_0097_00B7()
		{
			return null;
		}

		[Token(Token = "0x6005B6C")]
		[Address(RVA = "0x71B26AC", Offset = "0x71AE6AC", VA = "0x71B26AC")]
		public List<LoadedAssetInfo> _00A0xz_00B1E_0093()
		{
			return null;
		}

		[Token(Token = "0x6005B6D")]
		[Address(RVA = "0x71B29A8", Offset = "0x71AE9A8", VA = "0x71B29A8", Slot = "30")]
		public Task<AssetOperationHandle> ÀPeGmK(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6005B6E")]
		[Address(RVA = "0x71B2A94", Offset = "0x71AEA94", VA = "0x71B2A94", Slot = "17")]
		[AsyncStateMachine(typeof(_009Dc_008E_00AF_007CX))]
		public Task<AssetOperationHandle> LoadPrefabAsync(string µZºV_0089_00AB, [Optional] string M_009E_00AD_005B_007CO)
		{
			return null;
		}

		[Token(Token = "0x6005B6F")]
		[Address(RVA = "0x71B0078", Offset = "0x71AC078", VA = "0x71B0078", Slot = "31")]
		public AssetOperationHandle _00B0U_00B3Yo_0092(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, [Optional] object[] h_00A6_00BB_00B2_0089w)
		{
			return null;
		}

		[Token(Token = "0x6005B70")]
		[Address(RVA = "0x71AD444", Offset = "0x71A9444", VA = "0x71AD444")]
		private AssetItem o_00A7m_009E_0089_009D(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B71")]
		[Address(RVA = "0x71AF034", Offset = "0x71AB034", VA = "0x71AF034")]
		private UnityEngine.Object À_00A6B_00AD_00B0W(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B72")]
		[Address(RVA = "0x71B2B80", Offset = "0x71AEB80", VA = "0x71B2B80", Slot = "32")]
		public Task<AssetOperationHandle> _00B6_007F_0092xS_0095(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6005B73")]
		[Address(RVA = "0x71ACA3C", Offset = "0x71A8A3C", VA = "0x71ACA3C")]
		private string _00B2d_00A8C_00A8_00B0(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B74")]
		[Address(RVA = "0x71AF068", Offset = "0x71AB068", VA = "0x71AF068")]
		private string _008E_0088_00AC_0098qb(string P_0084c_007DÀ_00A3)
		{
			return null;
		}

		[Token(Token = "0x6005B75")]
		[Address(RVA = "0x71AF854", Offset = "0x71AB854", VA = "0x71AF854")]
		private AssetItem _0093U_00A4_009Aq_0084(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B76")]
		[Address(RVA = "0x71B2C6C", Offset = "0x71AEC6C", VA = "0x71B2C6C", Slot = "33")]
		public Task<AssetOperationHandle> _009Ct_00A5x_00B8ª(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6005B77")]
		[Address(RVA = "0x71AF004", Offset = "0x71AB004", VA = "0x71AF004")]
		private UnityEngine.Object Yn_00A2q_008CI(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005B78")]
		[Address(RVA = "0x71B2D58", Offset = "0x71AED58", VA = "0x71B2D58")]
		public UnityEngine.Object GetAsset(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}
	}
}
