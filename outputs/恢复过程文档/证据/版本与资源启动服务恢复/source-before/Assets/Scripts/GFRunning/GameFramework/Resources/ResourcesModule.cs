using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AssetBundles;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework.Resources
{
	[Token(Token = "0x20004DB")]
	public class ResourcesModule : GameFrameModule
	{
		[Token(Token = "0x20004DC")]
		public delegate void LoadAssetCompleteHandler(ResourcesInfo info);

		[Token(Token = "0x20004DD")]
		public delegate void LoaderCompleteHandler(ResLoader info);

		[Token(Token = "0x20004DE")]
		public delegate void LoadProgressHandler(float progress);

		[Token(Token = "0x20004DF")]
		[CompilerGenerated]
		private sealed class _003CLoadFirstPack_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001FEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001FEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001FEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<string> packList;

			[Token(Token = "0x4001FED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResourcesModule _003C_003E4__this;

			[Token(Token = "0x4001FEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AssetBundleLoadBundleOperation _003Crequest_003E5__2;

			[Token(Token = "0x17001259")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600742E")]
				[Address(RVA = "0x72F8C60", Offset = "0x72F4C60", VA = "0x72F8C60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700125A")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6007430")]
				[Address(RVA = "0x72F8CA0", Offset = "0x72F4CA0", VA = "0x72F8CA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600742B")]
			[Address(RVA = "0x72F59E8", Offset = "0x72F19E8", VA = "0x72F59E8")]
			[DebuggerHidden]
			public _003CLoadFirstPack_003Ed__24(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600742C")]
			[Address(RVA = "0x72F8958", Offset = "0x72F4958", VA = "0x72F8958", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600742D")]
			[Address(RVA = "0x72F895C", Offset = "0x72F495C", VA = "0x72F895C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600742E")]
			[Address(RVA = "0x72F8C60", Offset = "0x72F4C60", VA = "0x72F8C60", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600742F")]
			[Address(RVA = "0x72F8C68", Offset = "0x72F4C68", VA = "0x72F8C68", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6007430")]
			[Address(RVA = "0x72F8CA0", Offset = "0x72F4CA0", VA = "0x72F8CA0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4001FDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal AssetBundleManager bundleManager;

		[Token(Token = "0x4001FDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal ResourcesMono m_ResMono;

		[Token(Token = "0x4001FDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal GameObject m_ResMonoObj;

		[Token(Token = "0x4001FDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal bool SimulateAssetBundleInEditor;

		[Token(Token = "0x4001FDE")]
		private const int MAX_REQUEST = 100;

		[Token(Token = "0x4001FDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _requestRemain;

		[Token(Token = "0x4001FE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _isCurrentLoading;

		[Token(Token = "0x4001FE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<ResLoader> _requestQueue;

		[Token(Token = "0x4001FE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private HashSet<ResLoader> _nonCompleteLoaderSet;

		[Token(Token = "0x4001FE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private HashSet<ResLoader> _currentLoadQueue;

		[Token(Token = "0x4001FE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<string, ResLoader> _loaderCache;

		[Token(Token = "0x4001FE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<string, ResourcesInfo> _loadedAssetBundle;

		[Token(Token = "0x4001FE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IBundleServices bundleServices;

		[Token(Token = "0x4001FE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Dictionary<int, BundleAssetInfo> dicDownLoderById;

		[Token(Token = "0x4001FE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Dictionary<string, BundleAssetInfo> dicDownLoderByName;

		[Token(Token = "0x4001FE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static Dictionary<string, AssetBundle> dicABPack;

		[Token(Token = "0x17001257")]
		internal override int Priority
		{
			[Token(Token = "0x60073F3")]
			[Address(RVA = "0x72F5538", Offset = "0x72F1538", VA = "0x72F5538", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17001258")]
		internal bool isCurrentLoading
		{
			[Token(Token = "0x60073F4")]
			[Address(RVA = "0x72F5540", Offset = "0x72F1540", VA = "0x72F5540")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60073F5")]
		[Address(RVA = "0x72F5548", Offset = "0x72F1548", VA = "0x72F5548", Slot = "5")]
		internal override void Initialize(params object[] arg)
		{
		}

		[Token(Token = "0x60073F6")]
		[Address(RVA = "0x72F597C", Offset = "0x72F197C", VA = "0x72F597C")]
		[IteratorStateMachine(typeof(_003CLoadFirstPack_003Ed__24))]
		private IEnumerator LoadFirstPack(List<string> packList)
		{
			return null;
		}

		[Token(Token = "0x60073F7")]
		[Address(RVA = "0x72F5A10", Offset = "0x72F1A10", VA = "0x72F5A10")]
		private static void AddAssetBundlePackList(string aseetBundleName, AssetBundle packBundle)
		{
		}

		[Token(Token = "0x60073F8")]
		[Address(RVA = "0x72F5CAC", Offset = "0x72F1CAC", VA = "0x72F5CAC")]
		public static void AddABPack(List<string> bundeNameList, AssetBundle packBundle)
		{
		}

		[Token(Token = "0x60073F9")]
		[Address(RVA = "0x72F5D7C", Offset = "0x72F1D7C", VA = "0x72F5D7C", Slot = "6")]
		internal override void Start()
		{
		}

		[Token(Token = "0x60073FA")]
		[Address(RVA = "0x72F5D80", Offset = "0x72F1D80", VA = "0x72F5D80", Slot = "7")]
		internal override void Update(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x60073FB")]
		[Address(RVA = "0x72F5E30", Offset = "0x72F1E30", VA = "0x72F5E30")]
		private void CheckNewLoaders()
		{
		}

		[Token(Token = "0x60073FC")]
		[Address(RVA = "0x72F603C", Offset = "0x72F203C", VA = "0x72F603C")]
		private void CheckQueue()
		{
		}

		[Token(Token = "0x60073FD")]
		[Address(RVA = "0x72F6108", Offset = "0x72F2108", VA = "0x72F6108")]
		private void LoadBundle(ResLoader loader)
		{
		}

		[Token(Token = "0x60073FE")]
		[Address(RVA = "0x72F2304", Offset = "0x72EE304", VA = "0x72F2304")]
		internal void Enqueue(ResLoader loader)
		{
		}

		[Token(Token = "0x60073FF")]
		[Address(RVA = "0x72F6164", Offset = "0x72F2164", VA = "0x72F6164")]
		public ResLoader LoadPrefab(string assetBundleName, [Optional] LoadAssetCompleteHandler handler, [Optional] object[] Args)
		{
			return null;
		}

		[Token(Token = "0x6007400")]
		[Address(RVA = "0x72F6298", Offset = "0x72F2298", VA = "0x72F6298")]
		public ResLoader LoadAsset(string assetBundleName, [Optional] LoadAssetCompleteHandler handler, [Optional] object[] Args)
		{
			return null;
		}

		[Token(Token = "0x6007401")]
		[Address(RVA = "0x72F629C", Offset = "0x72F229C", VA = "0x72F629C")]
		public ResLoader LoadAssetNoExtName(string assetBundleName, [Optional] LoadAssetCompleteHandler handler, [Optional] object[] Args)
		{
			return null;
		}

		[Token(Token = "0x6007402")]
		[Address(RVA = "0x72F62A0", Offset = "0x72F22A0", VA = "0x72F62A0")]
		internal ResLoader _LoadAssetNoExtName(string assetBundleName, [Optional] LoadAssetCompleteHandler handler, [Optional] object[] Args)
		{
			return null;
		}

		[Token(Token = "0x6007403")]
		[Address(RVA = "0x72F61E0", Offset = "0x72F21E0", VA = "0x72F61E0")]
		internal ResLoader _LoadAsset(string assetBundleName, [Optional] LoadAssetCompleteHandler handler, [Optional] object[] Args)
		{
			return null;
		}

		[Token(Token = "0x6007404")]
		[Address(RVA = "0x72F63FC", Offset = "0x72F23FC", VA = "0x72F63FC")]
		public ResLoader LoadScene(string sceneName, [Optional] LoadAssetCompleteHandler handler, [Optional][DefaultParameterValue(false)] bool isAdditive, [Optional] LoadProgressHandler cbProgress)
		{
			return null;
		}

		[Token(Token = "0x6007405")]
		[Address(RVA = "0x72F62E4", Offset = "0x72F22E4", VA = "0x72F62E4")]
		private ResLoader Load(string bundleName, int prority, [Optional] LoadAssetCompleteHandler handler, [Optional] object[] Args)
		{
			return null;
		}

		[Token(Token = "0x6007406")]
		[Address(RVA = "0x72F6778", Offset = "0x72F2778", VA = "0x72F6778")]
		internal ResLoader _LoadAssetNow(string assetBundleName, [Optional] LoadAssetCompleteHandler handler, [Optional] object[] Args)
		{
			return null;
		}

		[Token(Token = "0x6007407")]
		[Address(RVA = "0x72F67FC", Offset = "0x72F27FC", VA = "0x72F67FC")]
		private ResLoader LoadNow(string bundleName, int prority, [Optional] LoadAssetCompleteHandler handler, [Optional] object[] Args)
		{
			return null;
		}

		[Token(Token = "0x6007408")]
		[Address(RVA = "0x72F6688", Offset = "0x72F2688", VA = "0x72F6688")]
		internal ResLoader CreateLoader(string bundleName, int LoaderType, [Optional] string oriName)
		{
			return null;
		}

		[Token(Token = "0x6007409")]
		[Address(RVA = "0x72F691C", Offset = "0x72F291C", VA = "0x72F691C", Slot = "10")]
		protected virtual ResLoader CreateLoader(int LoaderType)
		{
			return null;
		}

		[Token(Token = "0x600740A")]
		[Address(RVA = "0x72F69F8", Offset = "0x72F29F8", VA = "0x72F69F8")]
		public bool CheckLocalAssetHave(string assetBundleName)
		{
			return default;
		}

		[Token(Token = "0x600740B")]
		[Address(RVA = "0x72F6AA4", Offset = "0x72F2AA4", VA = "0x72F6AA4")]
		public int DownloadAsset(string assetBundleName, int priority = 0)
		{
			return default;
		}

		[Token(Token = "0x600740C")]
		[Address(RVA = "0x72F6D18", Offset = "0x72F2D18", VA = "0x72F6D18")]
		public void ChangeDownloadPriority(int serialId, int priority)
		{
		}

		[Token(Token = "0x600740D")]
		[Address(RVA = "0x72F115C", Offset = "0x72ED15C", VA = "0x72F115C")]
		internal void LoadComplete(ResLoader loader)
		{
		}

		[Token(Token = "0x600740E")]
		[Address(RVA = "0x72F0FEC", Offset = "0x72ECFEC", VA = "0x72F0FEC")]
		internal void LoadError(ResLoader loader)
		{
		}

		[Token(Token = "0x600740F")]
		[Address(RVA = "0x72F2610", Offset = "0x72EE610", VA = "0x72F2610")]
		internal ResourcesInfo CreateResourcesInfo(ResLoader loader, [Optional] ResourcesInfo abi, [Optional] AssetBundle assetBundle)
		{
			return null;
		}

		[Token(Token = "0x6007410")]
		[Address(RVA = "0x72F6D78", Offset = "0x72F2D78", VA = "0x72F6D78")]
		public ResourcesInfo GetBundleInfo(string bundleName)
		{
			return null;
		}

		[Token(Token = "0x6007411")]
		[Address(RVA = "0x72F6E4C", Offset = "0x72F2E4C", VA = "0x72F6E4C")]
		public void UnloadUnusedBundle(ResourcesInfo abi)
		{
		}

		[Token(Token = "0x6007412")]
		[Address(RVA = "0x72F712C", Offset = "0x72F312C", VA = "0x72F712C")]
		public void UnloadUnusedBundle(string bundleName)
		{
		}

		[Token(Token = "0x6007413")]
		[Address(RVA = "0x72F72B4", Offset = "0x72F32B4", VA = "0x72F72B4")]
		public void UnloadAllAssetBundle(List<string> ExcludeBundleNames)
		{
		}

		[Token(Token = "0x6007414")]
		[Address(RVA = "0x72F7CEC", Offset = "0x72F3CEC", VA = "0x72F7CEC")]
		public void UnloadAllAssetBundle(params string[] ExcludeBundleNames)
		{
		}

		[Token(Token = "0x6007415")]
		[Address(RVA = "0x72F7E44", Offset = "0x72F3E44", VA = "0x72F7E44")]
		public void UnloadAtlasForce(string atlasName)
		{
		}

		[Token(Token = "0x6007416")]
		[Address(RVA = "0x72F6FA0", Offset = "0x72F2FA0", VA = "0x72F6FA0")]
		internal void RemoveBundleInfo(ResourcesInfo abi)
		{
		}

		[Token(Token = "0x6007417")]
		[Address(RVA = "0x72F7FE8", Offset = "0x72F3FE8", VA = "0x72F7FE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6007418")]
		[Address(RVA = "0x72F7FEC", Offset = "0x72F3FEC", VA = "0x72F7FEC")]
		private void RemoveAll()
		{
		}

		[Token(Token = "0x6007419")]
		[Address(RVA = "0x72F80E4", Offset = "0x72F40E4", VA = "0x72F80E4", Slot = "9")]
		internal override void Shutdown()
		{
		}

		[Token(Token = "0x600741A")]
		[Address(RVA = "0x72F81D4", Offset = "0x72F41D4", VA = "0x72F81D4")]
		public string GetGFVersion()
		{
			return null;
		}

		[Token(Token = "0x600741B")]
		[Address(RVA = "0x72F82A0", Offset = "0x72F42A0", VA = "0x72F82A0")]
		public string GetUACBuildID()
		{
			return null;
		}

		[Token(Token = "0x600741C")]
		[Address(RVA = "0x72F8370", Offset = "0x72F4370", VA = "0x72F8370")]
		public bool GetIsDeepObf()
		{
			return default;
		}

		[Token(Token = "0x600741D")]
		[Address(RVA = "0x72F8428", Offset = "0x72F4428", VA = "0x72F8428")]
		public ResourcesModule()
		{
		}
	}
}
