using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using GameFramework.Obfuscator;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace GameFramework
{
	[Token(Token = "0x200039C")]
	public class YOResourcesModule : GameFrameModule, IResIntegration
	{
		[Token(Token = "0x200039D")]
		[Confuse]
		private class WebGltionServices : IRuntimeSource
		{
			[Token(Token = "0x4001B97")]
			private const int primNum = 104729;

			[Token(Token = "0x6005CBD")]
			[Address(RVA = "0x71BF46C", Offset = "0x71BB46C", VA = "0x71BF46C", Slot = "4")]
			public ulong CompressAtlas(TFileInfo fileInfo)
			{
				return default;
			}

			[Token(Token = "0x6005CBE")]
			[Address(RVA = "0x71BF4A4", Offset = "0x71BB4A4", VA = "0x71BF4A4", Slot = "5")]
			public byte[] OptimizeTexture(TFileInfo fileInfo)
			{
				return null;
			}

			[Token(Token = "0x6005CBF")]
			[Address(RVA = "0x71BF638", Offset = "0x71BB638", VA = "0x71BF638", Slot = "6")]
			public Stream ParseRuntimeString(TFileInfo fileInfo)
			{
				return null;
			}

			[Token(Token = "0x6005CC0")]
			[Address(RVA = "0x71BF670", Offset = "0x71BB670", VA = "0x71BF670", Slot = "7")]
			public uint GetStagingSize()
			{
				return default;
			}

			[Token(Token = "0x6005CC1")]
			[Address(RVA = "0x71BE540", Offset = "0x71BA540", VA = "0x71BE540")]
			public WebGltionServices()
			{
			}
		}

		[Token(Token = "0x200039E")]
		[Confuse]
		private class Gametion : IRuntimeSource
		{
			[Token(Token = "0x4001B98")]
			private const int primNum = 104729;

			[Token(Token = "0x4001B99")]
			private const int bufferSize = 2048;

			[Token(Token = "0x6005CC2")]
			[Address(RVA = "0x71BF6A8", Offset = "0x71BB6A8", VA = "0x71BF6A8", Slot = "4")]
			public ulong CompressAtlas(TFileInfo fileInfo)
			{
				return default;
			}

			[Token(Token = "0x6005CC3")]
			[Address(RVA = "0x71BF6C8", Offset = "0x71BB6C8", VA = "0x71BF6C8", Slot = "5")]
			public byte[] OptimizeTexture(TFileInfo fileInfo)
			{
				return null;
			}

			[Token(Token = "0x6005CC4")]
			[Address(RVA = "0x71BF6F0", Offset = "0x71BB6F0", VA = "0x71BF6F0", Slot = "6")]
			public Stream ParseRuntimeString(TFileInfo fileInfo)
			{
				return null;
			}

			[Token(Token = "0x6005CC5")]
			[Address(RVA = "0x71BF8A4", Offset = "0x71BB8A4", VA = "0x71BF8A4", Slot = "7")]
			public uint GetStagingSize()
			{
				return default;
			}

			[Token(Token = "0x6005CC6")]
			[Address(RVA = "0x71BDA9C", Offset = "0x71B9A9C", VA = "0x71BDA9C")]
			public Gametion()
			{
			}
		}

		[Token(Token = "0x200039F")]
		private class GameRemoteServices : IRemoteServices
		{
			[Token(Token = "0x4001B9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly string _versionHost;

			[Token(Token = "0x4001B9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string _defaultHostServer;

			[Token(Token = "0x4001B9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private string _fallbackHostServer;

			[Token(Token = "0x6005CC7")]
			[Address(RVA = "0x71BE504", Offset = "0x71BA504", VA = "0x71BE504")]
			public GameRemoteServices(string defaultHostServer, string fallbackHostServer, string versionHost)
			{
			}

			[Token(Token = "0x6005CC8")]
			[Address(RVA = "0x71BE870", Offset = "0x71BA870", VA = "0x71BE870")]
			public void UpdateRemoteURL(string defaultHostServer, string fallbackHostServer)
			{
			}

			[Token(Token = "0x6005CC9")]
			[Address(RVA = "0x71BF8AC", Offset = "0x71BB8AC", VA = "0x71BF8AC", Slot = "4")]
			public string GetRemoteMainURL(string fileName, string bundleName)
			{
				return null;
			}

			[Token(Token = "0x6005CCA")]
			[Address(RVA = "0x71BFA6C", Offset = "0x71BBA6C", VA = "0x71BFA6C", Slot = "5")]
			public string GetRemoteFallbackURL(string fileName, string bundleName)
			{
				return null;
			}

			[Token(Token = "0x6005CCB")]
			[Address(RVA = "0x71BFAC8", Offset = "0x71BBAC8", VA = "0x71BFAC8", Slot = "6")]
			public string GetVersionUrl(string fileName)
			{
				return null;
			}
		}

		[Token(Token = "0x20003A0")]
		public delegate void LoadProgressHandler(float progress);

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003A4")]
		[CompilerGenerated]
		private struct _003CGetSpriteByTexture_003Ed__42 : IAsyncStateMachine
		{
			[Token(Token = "0x4001BA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001BA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AssetOperationHandle> _003C_003Et__builder;

			[Token(Token = "0x4001BA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string assetBundleName;

			[Token(Token = "0x4001BA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public YOResourcesModule _003C_003E4__this;

			[Token(Token = "0x4001BA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x6005CD6")]
			[Address(RVA = "0x71BFC8C", Offset = "0x71BBC8C", VA = "0x71BFC8C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005CD7")]
			[Address(RVA = "0x71BFF6C", Offset = "0x71BBF6C", VA = "0x71BFF6C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003A5")]
		[CompilerGenerated]
		private struct _003CLoadAssetAsync_003Ed__45<T> : IAsyncStateMachine where T : UnityEngine.Object
		{
			[Token(Token = "0x4001BA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001BA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<AssetOperationHandle> _003C_003Et__builder;

			[Token(Token = "0x4001BA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public YOResourcesModule _003C_003E4__this;

			[Token(Token = "0x4001BA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetBundleName;

			[Token(Token = "0x4001BA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x6005CD8")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005CD9")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003A6")]
		[CompilerGenerated]
		private struct _003CLoadPrefabAsync_003Ed__43 : IAsyncStateMachine
		{
			[Token(Token = "0x4001BAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001BAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AssetOperationHandle> _003C_003Et__builder;

			[Token(Token = "0x4001BAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string assetName;

			[Token(Token = "0x4001BAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string assetBundleName;

			[Token(Token = "0x4001BAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public YOResourcesModule _003C_003E4__this;

			[Token(Token = "0x4001BAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x6005CDA")]
			[Address(RVA = "0x71BFFE8", Offset = "0x71BBFE8", VA = "0x71BFFE8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005CDB")]
			[Address(RVA = "0x71C02E4", Offset = "0x71BC2E4", VA = "0x71C02E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003A7")]
		[CompilerGenerated]
		private struct _003CLoadSpriteAtlasAsync_003Ed__44 : IAsyncStateMachine
		{
			[Token(Token = "0x4001BB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001BB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AssetOperationHandle> _003C_003Et__builder;

			[Token(Token = "0x4001BB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string uiAtlasName;

			[Token(Token = "0x4001BB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public YOResourcesModule _003C_003E4__this;

			[Token(Token = "0x4001BB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x6005CDC")]
			[Address(RVA = "0x71C0360", Offset = "0x71BC360", VA = "0x71C0360", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005CDD")]
			[Address(RVA = "0x71C0604", Offset = "0x71BC604", VA = "0x71C0604", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003A8")]
		[CompilerGenerated]
		private struct _003C_LoadAssetAsync_003Ed__46<T> : IAsyncStateMachine where T : UnityEngine.Object
		{
			[Token(Token = "0x4001BB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001BB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<AssetOperationHandle> _003C_003Et__builder;

			[Token(Token = "0x4001BB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetBundleName;

			[Token(Token = "0x4001BB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public YOResourcesModule _003C_003E4__this;

			[Token(Token = "0x4001BB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private AssetOperationHandle _003Chandle_003E5__2;

			[Token(Token = "0x4001BBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6005CDE")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005CDF")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001B90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal EPlayMode PlayMode;

		[Token(Token = "0x4001B91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal ResourcePackage _package;

		[Token(Token = "0x4001B92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string googleDeliveryRootPath;

		[Token(Token = "0x4001B93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _resFolderName;

		[Token(Token = "0x4001B94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameRemoteServices _gameRemoteServices;

		[Token(Token = "0x4001B95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private object _prefixURL;

		[Token(Token = "0x4001B96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string _customerPathName;

		[Token(Token = "0x17001130")]
		internal ResourcePackage Package
		{
			[Token(Token = "0x6005C94")]
			[Address(RVA = "0x71BCDD8", Offset = "0x71B8DD8", VA = "0x71BCDD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005C95")]
		[Address(RVA = "0x71BCDE0", Offset = "0x71B8DE0", VA = "0x71BCDE0", Slot = "5")]
		internal override void Initialize(params object[] arg)
		{
		}

		[Token(Token = "0x6005C96")]
		[Address(RVA = "0x71BD9A0", Offset = "0x71B99A0", VA = "0x71BD9A0")]
		internal void InitCompoleteCallBack(AsyncOperationBase operation)
		{
		}

		[Token(Token = "0x6005C97")]
		[Address(RVA = "0x71BDA94", Offset = "0x71B9A94", VA = "0x71BDA94", Slot = "6")]
		internal override void Start()
		{
		}

		[Token(Token = "0x6005C98")]
		[Address(RVA = "0x71BDA98", Offset = "0x71B9A98", VA = "0x71BDA98", Slot = "7")]
		internal override void Update(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005C99")]
		[Address(RVA = "0x71BD078", Offset = "0x71B9078", VA = "0x71BD078")]
		private InitializationOperation InitPackageAsync(object prefixURL, object customerPathName)
		{
			return null;
		}

		[Token(Token = "0x6005C9A")]
		[Address(RVA = "0x71BDD8C", Offset = "0x71B9D8C", VA = "0x71BDD8C")]
		private string GetVersionUrl(object prefixURL)
		{
			return null;
		}

		[Token(Token = "0x6005C9B")]
		[Address(RVA = "0x71BDAD4", Offset = "0x71B9AD4", VA = "0x71BDAD4")]
		private string GetHostServerURL(bool isRedirectResFolder = false)
		{
			return null;
		}

		[Token(Token = "0x6005C9C")]
		[Address(RVA = "0x71BE5F0", Offset = "0x71BA5F0", VA = "0x71BE5F0")]
		private string GetBaseURL(object prefixURL)
		{
			return null;
		}

		[Token(Token = "0x6005C9D")]
		[Address(RVA = "0x71BE7AC", Offset = "0x71BA7AC", VA = "0x71BE7AC")]
		public void SetResFolderName(string resFolderName)
		{
		}

		[Token(Token = "0x6005C9E")]
		[Address(RVA = "0x71BE59C", Offset = "0x71BA59C", VA = "0x71BE59C")]
		internal string GetAppVer()
		{
			return null;
		}

		[Token(Token = "0x6005C9F")]
		[Address(RVA = "0x71BE548", Offset = "0x71BA548", VA = "0x71BE548")]
		internal static string GetPackageStr()
		{
			return null;
		}

		[Token(Token = "0x6005CA0")]
		[Address(RVA = "0x71BE76C", Offset = "0x71BA76C", VA = "0x71BE76C")]
		internal static string GetPlatformStr()
		{
			return null;
		}

		[Token(Token = "0x6005CA1")]
		[Address(RVA = "0x71BE988", Offset = "0x71BA988", VA = "0x71BE988")]
		public string GetLocalVersion()
		{
			return null;
		}

		[Token(Token = "0x6005CA2")]
		[Address(RVA = "0x71BE9A4", Offset = "0x71BA9A4", VA = "0x71BE9A4")]
		public string GetLoacalVerDesc()
		{
			return null;
		}

		[Token(Token = "0x6005CA3")]
		public AssetOperationHandle LoadAssetSync<T>(string assetBundleName) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005CA4")]
		[Address(RVA = "0x71BEA00", Offset = "0x71BAA00", VA = "0x71BEA00", Slot = "13")]
		public AssetOperationHandle LoadAssetSync(string assetBundleName)
		{
			return null;
		}

		[Token(Token = "0x6005CA5")]
		internal AssetOperationHandle _LoadSync<T>(string bundleName) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005CA6")]
		[Address(RVA = "0x71BEA2C", Offset = "0x71BAA2C", VA = "0x71BEA2C")]
		internal AssetOperationHandle _LoadSync(string bundleName)
		{
			return null;
		}

		[Token(Token = "0x6005CA7")]
		[Address(RVA = "0x71BEB2C", Offset = "0x71BAB2C", VA = "0x71BEB2C", Slot = "11")]
		public AssetOperationHandle LoadAsset(string assetBundleName, [Optional] Action<AssetOperationHandle> handler, [Optional] object[] Args)
		{
			return null;
		}

		[Token(Token = "0x6005CA8")]
		public AssetOperationHandle LoadAsset<T>(string assetBundleName, [Optional] Action<AssetOperationHandle> handler, [Optional] object[] Args) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005CA9")]
		[Address(RVA = "0x71BEC78", Offset = "0x71BAC78", VA = "0x71BEC78")]
		internal void _LoadAssetNow(string assetBundleName, [Optional] Action<AssetOperationHandle> handler, [Optional] object[] Args)
		{
		}

		[Token(Token = "0x6005CAA")]
		[Address(RVA = "0x71BECFC", Offset = "0x71BACFC", VA = "0x71BECFC")]
		private void LoadNow(string bundleName, int prority, [Optional] Action<AssetOperationHandle> handler, [Optional] object[] Args)
		{
		}

		[Token(Token = "0x6005CAB")]
		[Address(RVA = "0x71BEB70", Offset = "0x71BAB70", VA = "0x71BEB70")]
		internal AssetOperationHandle _LoadAsset(string assetBundleName, [Optional] Action<AssetOperationHandle> handler, [Optional] object[] Args)
		{
			return null;
		}

		[Token(Token = "0x6005CAC")]
		internal AssetOperationHandle _LoadAsset<T>(string assetBundleName, [Optional] Action<AssetOperationHandle> handler, [Optional] object[] Args) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005CAD")]
		[Address(RVA = "0x71BED10", Offset = "0x71BAD10", VA = "0x71BED10")]
		public void LoadAssetNoExtName(string assetBundleName, [Optional] Action<AssetOperationHandle> handler, [Optional] object[] Args)
		{
		}

		[Token(Token = "0x6005CAE")]
		[Address(RVA = "0x71BED14", Offset = "0x71BAD14", VA = "0x71BED14")]
		internal void _LoadAssetNoExtName(string assetBundleName, [Optional] Action<AssetOperationHandle> handler, [Optional] object[] Args)
		{
		}

		[Token(Token = "0x6005CAF")]
		[Address(RVA = "0x71BED58", Offset = "0x71BAD58", VA = "0x71BED58", Slot = "14")]
		public AssetOperationHandle LoadPrefab(string assetBundleName, [Optional] Action<AssetOperationHandle> handler, [Optional] object[] Args)
		{
			return null;
		}

		[Token(Token = "0x6005CB0")]
		[Address(RVA = "0x71BEDE4", Offset = "0x71BADE4", VA = "0x71BEDE4", Slot = "20")]
		public AssetOperationHandle LoadSpriteAtlas(string assetBundleName, [Optional] Action<AssetOperationHandle> handler, [Optional] object[] Args)
		{
			return null;
		}

		[Token(Token = "0x6005CB1")]
		[Address(RVA = "0x71BEEB4", Offset = "0x71BAEB4", VA = "0x71BEEB4", Slot = "21")]
		public AllAssetsOperationHandle LoadAllAssets(string location, [Optional] Action<AllAssetsOperationHandle> handler)
		{
			return null;
		}

		[Token(Token = "0x6005CB2")]
		[Address(RVA = "0x71BEEF8", Offset = "0x71BAEF8", VA = "0x71BEEF8", Slot = "15")]
		public SceneOperationHandle LoadScene(string sceneName, [Optional] Action<SceneOperationHandle> handler, [Optional][DefaultParameterValue(false)] bool isAdditive, [Optional][DefaultParameterValue(false)] bool suspendLoad, [Optional] object[] Args)
		{
			return null;
		}

		[Token(Token = "0x6005CB3")]
		[Address(RVA = "0x71BF060", Offset = "0x71BB060", VA = "0x71BF060", Slot = "19")]
		[AsyncStateMachine(typeof(_003CGetSpriteByTexture_003Ed__42))]
		public Task<AssetOperationHandle> GetSpriteByTexture(string assetBundleName)
		{
			return null;
		}

		[Token(Token = "0x6005CB4")]
		[Address(RVA = "0x71BF14C", Offset = "0x71BB14C", VA = "0x71BF14C", Slot = "17")]
		[AsyncStateMachine(typeof(_003CLoadPrefabAsync_003Ed__43))]
		public Task<AssetOperationHandle> LoadPrefabAsync(string assetBundleName, [Optional] string assetName)
		{
			return null;
		}

		[Token(Token = "0x6005CB5")]
		[Address(RVA = "0x71BF244", Offset = "0x71BB244", VA = "0x71BF244")]
		[AsyncStateMachine(typeof(_003CLoadSpriteAtlasAsync_003Ed__44))]
		public Task<AssetOperationHandle> LoadSpriteAtlasAsync(string uiAtlasName)
		{
			return null;
		}

		[Token(Token = "0x6005CB6")]
		[AsyncStateMachine(typeof(_003CLoadAssetAsync_003Ed__45<>))]
		public Task<AssetOperationHandle> LoadAssetAsync<T>(string assetBundleName) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005CB7")]
		[AsyncStateMachine(typeof(_003C_LoadAssetAsync_003Ed__46<>))]
		public Task<AssetOperationHandle> _LoadAssetAsync<T>(string assetBundleName) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005CB8")]
		[Address(RVA = "0x71BF330", Offset = "0x71BB330", VA = "0x71BF330")]
		public string GetBundleName(string location)
		{
			return null;
		}

		[Token(Token = "0x6005CB9")]
		[Address(RVA = "0x71BF34C", Offset = "0x71BB34C", VA = "0x71BF34C", Slot = "18")]
		public void UnloadUnusedAssets()
		{
		}

		[Token(Token = "0x6005CBA")]
		[Address(RVA = "0x71BF360", Offset = "0x71BB360", VA = "0x71BF360", Slot = "9")]
		internal override void Shutdown()
		{
		}

		[Token(Token = "0x6005CBB")]
		[Address(RVA = "0x71BF400", Offset = "0x71BB400", VA = "0x71BF400")]
		public bool GetIsWebPlayMode()
		{
			return default;
		}

		[Token(Token = "0x6005CBC")]
		[Address(RVA = "0x71BF410", Offset = "0x71BB410", VA = "0x71BF410")]
		public YOResourcesModule()
		{
		}
	}
}
