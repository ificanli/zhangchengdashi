using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;
using YooAsset;

namespace GameFramework
{
	[Token(Token = "0x20002F0")]
	public static class NewResLoadHelper
	{
		[Token(Token = "0x20002F1")]
		private sealed class i_00A5L_00A3_005Ek
		{
			[Token(Token = "0x4001854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<SpriteAtlas> callBack;

			[Token(Token = "0x600529E")]
			[Address(RVA = "0x7132228", Offset = "0x712E228", VA = "0x7132228")]
			public i_00A5L_00A3_005Ek()
			{
			}

			[Token(Token = "0x600529F")]
			[Address(RVA = "0x7132230", Offset = "0x712E230", VA = "0x7132230")]
			internal void _00A6_0087_005B_007CLV(AssetOperationHandle res)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002F2")]
		private struct l_00B8_0099_007E_00A8_00B3 : IAsyncStateMachine
		{
			[Token(Token = "0x4001855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AssetOperationHandle> _003C_003Et__builder;

			[Token(Token = "0x4001857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string location;

			[Token(Token = "0x4001858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x60052A0")]
			[Address(RVA = "0x71322DC", Offset = "0x712E2DC", VA = "0x71322DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60052A1")]
			[Address(RVA = "0x71325A8", Offset = "0x712E5A8", VA = "0x71325A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002F3")]
		private struct Dµ_00AE_00AED_007E<T> : IAsyncStateMachine where T : UnityEngine.Object
		{
			[Token(Token = "0x4001859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400185A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<AssetOperationHandle> _003C_003Et__builder;

			[Token(Token = "0x400185B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string location;

			[Token(Token = "0x400185C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x60052A2")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60052A3")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002F4")]
		private struct _005BMz_00A4_009Et : IAsyncStateMachine
		{
			[Token(Token = "0x400185D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400185E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AssetOperationHandle> _003C_003Et__builder;

			[Token(Token = "0x400185F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string location;

			[Token(Token = "0x4001860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x60052A4")]
			[Address(RVA = "0x7132624", Offset = "0x712E624", VA = "0x7132624", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60052A5")]
			[Address(RVA = "0x71328F4", Offset = "0x712E8F4", VA = "0x71328F4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002F5")]
		private struct oÀ_00B3_007BsJ : IAsyncStateMachine
		{
			[Token(Token = "0x4001861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AssetOperationHandle> _003C_003Et__builder;

			[Token(Token = "0x4001863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string uiAtlasName;

			[Token(Token = "0x4001864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x60052A6")]
			[Address(RVA = "0x7132970", Offset = "0x712E970", VA = "0x7132970", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60052A7")]
			[Address(RVA = "0x7132CB0", Offset = "0x712ECB0", VA = "0x7132CB0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002F6")]
		private struct UA_00B4BÁ_007F : IAsyncStateMachine
		{
			[Token(Token = "0x4001865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AssetOperationHandle> _003C_003Et__builder;

			[Token(Token = "0x4001867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string location;

			[Token(Token = "0x4001868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x60052A8")]
			[Address(RVA = "0x7132D2C", Offset = "0x712ED2C", VA = "0x7132D2C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60052A9")]
			[Address(RVA = "0x7133058", Offset = "0x712F058", VA = "0x7133058", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600527C")]
		[Address(RVA = "0x712FD08", Offset = "0x712BD08", VA = "0x712FD08")]
		public static IResIntegration GetNewResModule()
		{
			return null;
		}

		[Token(Token = "0x600527D")]
		[Address(RVA = "0x712FDEC", Offset = "0x712BDEC", VA = "0x712FDEC")]
		public static GameFrameModule GetNewResModule(bool _00A9m_00B4W_00BF_008B)
		{
			return null;
		}

		[Token(Token = "0x600527E")]
		[Address(RVA = "0x712FE70", Offset = "0x712BE70", VA = "0x712FE70")]
		public static void Initialize(GameFrameModule _009D_007FOz_00AFs, Action _00A3Y_0082I_00A7_00B4, EPlayMode _0097_0098_00B1_0080_007F_009F, TeamType _007C_008BzfÁX)
		{
		}

		[Token(Token = "0x600527F")]
		[Address(RVA = "0x712FFD0", Offset = "0x712BFD0", VA = "0x712FFD0")]
		public static AssetOperationHandle LoadAsset(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w)
		{
			return null;
		}

		[Token(Token = "0x6005280")]
		public static AssetOperationHandle LoadAsset<T>(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005281")]
		[Address(RVA = "0x71301EC", Offset = "0x712C1EC", VA = "0x71301EC")]
		public static AssetOperationHandle LoadPrefab(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w)
		{
			return null;
		}

		[Token(Token = "0x6005282")]
		[Address(RVA = "0x7130350", Offset = "0x712C350", VA = "0x7130350")]
		public static void LoadTexture(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005283")]
		[Address(RVA = "0x7130270", Offset = "0x712C270", VA = "0x7130270")]
		public static AssetOperationHandle LoadPrefabOri(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w)
		{
			return null;
		}

		[Token(Token = "0x6005284")]
		[Address(RVA = "0x71303D0", Offset = "0x712C3D0", VA = "0x71303D0")]
		public static AssetOperationHandle LoadMaterial(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w)
		{
			return null;
		}

		[Token(Token = "0x6005285")]
		[Address(RVA = "0x713046C", Offset = "0x712C46C", VA = "0x713046C")]
		public static SceneOperationHandle LoadScene(string x_008A_00BE_0098_007Ej, [Optional] Action<SceneOperationHandle> _0091_00BF_0099sB_007E, bool _005Ddk_00A3Ol = false, bool _00A7Â_007By_007D_008A = false)
		{
			return null;
		}

		[Token(Token = "0x6005286")]
		[Address(RVA = "0x7130558", Offset = "0x712C558", VA = "0x7130558")]
		public static string ShowAllABInfoInRuntime()
		{
			return null;
		}

		[Token(Token = "0x6005287")]
		[Address(RVA = "0x7130700", Offset = "0x712C700", VA = "0x7130700")]
		internal static int ºm_0099_00A5_008CW(string j_0081xY_0088_0088)
		{
			return default;
		}

		[Token(Token = "0x6005288")]
		[Address(RVA = "0x713089C", Offset = "0x712C89C", VA = "0x713089C")]
		public static AssetOperationHandle LoadSpriteAtlas(string _0084RfZSg, Action<SpriteAtlas> _009F_00A4WY_0097_00B1)
		{
			return null;
		}

		[Token(Token = "0x6005289")]
		[Address(RVA = "0x71309F0", Offset = "0x712C9F0", VA = "0x71309F0")]
		public static AllAssetsOperationHandle LoadAllAssets(string _00B8_007CL_0094_0090l, [Optional] Action<AllAssetsOperationHandle> _0091_00BF_0099sB_007E)
		{
			return null;
		}

		[Token(Token = "0x600528A")]
		[Address(RVA = "0x7130ABC", Offset = "0x712CABC", VA = "0x7130ABC")]
		[AsyncStateMachine(typeof(oÀ_00B3_007BsJ))]
		public static Task<AssetOperationHandle> LoadSpriteAtlasAsync(string _0084RfZSg)
		{
			return null;
		}

		[Token(Token = "0x600528B")]
		[AsyncStateMachine(typeof(global::GameFramework.NewResLoadHelper.Dµ_00AE_00AED_007E<>))]
		public static Task<AssetOperationHandle> LoadAssetAsync<T>(string _00B8_007CL_0094_0090l) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600528C")]
		[Address(RVA = "0x7130BA0", Offset = "0x712CBA0", VA = "0x7130BA0")]
		[AsyncStateMachine(typeof(UA_00B4BÁ_007F))]
		public static Task<AssetOperationHandle> LoadTextureAsync(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x600528D")]
		[Address(RVA = "0x7130C84", Offset = "0x712CC84", VA = "0x7130C84")]
		[AsyncStateMachine(typeof(global::GameFramework.NewResLoadHelper._005BMz_00A4_009Et))]
		public static Task<AssetOperationHandle> LoadPrefabAsync(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x600528E")]
		[Address(RVA = "0x7130D68", Offset = "0x712CD68", VA = "0x7130D68")]
		[AsyncStateMachine(typeof(l_00B8_0099_007E_00A8_00B3))]
		public static Task<AssetOperationHandle> GetSpriteByTexture(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x600528F")]
		public static AssetOperationHandle LoadAssetSync<T>(string _00B8_007CL_0094_0090l) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005290")]
		[Address(RVA = "0x7130E4C", Offset = "0x712CE4C", VA = "0x7130E4C")]
		public static AssetOperationHandle LoadAssetSync(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x6005291")]
		[Address(RVA = "0x7130F10", Offset = "0x712CF10", VA = "0x7130F10")]
		public static void UnloadUnusedAssets()
		{
		}

		[Token(Token = "0x6005292")]
		[Address(RVA = "0x71300B0", Offset = "0x712C0B0", VA = "0x71300B0")]
		public static bool CheckUseRightResLoad()
		{
			return default;
		}

		[Token(Token = "0x6005293")]
		[Address(RVA = "0x7130FAC", Offset = "0x712CFAC", VA = "0x7130FAC")]
		public static string GetLocalVersion()
		{
			return null;
		}

		[Token(Token = "0x6005294")]
		[Address(RVA = "0x713114C", Offset = "0x712D14C", VA = "0x713114C")]
		public static void SetCustomUnLoadABDelegate(UnLoadABDelegate P_00A3_00BFÁ_00ABt)
		{
		}

		[Token(Token = "0x6005295")]
		[Address(RVA = "0x71312AC", Offset = "0x712D2AC", VA = "0x71312AC")]
		public static void SetCustomGetABByHandlerDelegate(GetAbByDownHalder P_00A3_00BFÁ_00ABt)
		{
		}

		[Token(Token = "0x6005296")]
		[Address(RVA = "0x713140C", Offset = "0x712D40C", VA = "0x713140C")]
		public static void SetCustomVersionUrl(string _005Dh_00A8_00A3mq)
		{
		}

		[Token(Token = "0x6005297")]
		[Address(RVA = "0x71315AC", Offset = "0x712D5AC", VA = "0x71315AC")]
		public static void SetCustomWebGLHostServerUrl(string _005Dh_00A8_00A3mq)
		{
		}

		[Token(Token = "0x6005298")]
		[Address(RVA = "0x713174C", Offset = "0x712D74C", VA = "0x713174C")]
		public static void SetDownLoadRequesetDelegate(DownloadRequestDelegate P_00A3_00BFÁ_00ABt)
		{
		}

		[Token(Token = "0x6005299")]
		[Address(RVA = "0x71318F4", Offset = "0x712D8F4", VA = "0x71318F4")]
		public static void SetCacheSystemDisableCacheOnWebGL()
		{
		}

		[Token(Token = "0x600529A")]
		[Address(RVA = "0x7131A58", Offset = "0x712DA58", VA = "0x7131A58")]
		public static string GetGFVersion()
		{
			return null;
		}

		[Token(Token = "0x600529B")]
		[Address(RVA = "0x7131CC4", Offset = "0x712DCC4", VA = "0x7131CC4")]
		public static string GetUACBuildID()
		{
			return null;
		}

		[Token(Token = "0x600529C")]
		[Address(RVA = "0x7131F34", Offset = "0x712DF34", VA = "0x7131F34")]
		public static bool GetIsDeepObf()
		{
			return default;
		}

		[Token(Token = "0x600529D")]
		[Address(RVA = "0x71320C0", Offset = "0x712E0C0", VA = "0x71320C0")]
		internal static bool _007Eyr_0080_008Fr()
		{
			return default;
		}
	}
}
