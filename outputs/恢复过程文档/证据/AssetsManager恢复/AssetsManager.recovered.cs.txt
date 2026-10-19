using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using EventModule;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace AssetsModule
{
	[Token(Token = "0x2000632")]
	public class AssetsManager : ManagerBase<AssetsManager>
	{
		[Token(Token = "0x2000633")]
		private class AssetHandleInfo
		{
			[Token(Token = "0x40032B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncOperationHandle Handle;

			[Token(Token = "0x40032B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int RefCount;

			[Token(Token = "0x40032B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UniTaskCompletionSource<object> WaitSource;

			[Token(Token = "0x60020C7")]
			[Address(RVA = "0x3F136B4", Offset = "0x3F0F6B4", VA = "0x3F136B4")]
			public AssetHandleInfo()
			{
			}
		}

		[Token(Token = "0x2000634")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass19_0<T> where T : Object
		{
			[Token(Token = "0x40032B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AssetsManager _003C_003E4__this;

			[Token(Token = "0x40032B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetPath;

			[Token(Token = "0x40032B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string groupName;

			[Token(Token = "0x40032B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AssetHandleInfo newHandleInfo;

			[Token(Token = "0x60020C8")]
			public _003C_003Ec__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60020C9")]
			internal void _003CLoadAssetAsync_003Eb__0(AsyncOperationHandle<T> operationHandle)
			{
				_003C_003E4__this._lock.EnterWriteLock();
				try
				{
					if (operationHandle.Status != AsyncOperationStatus.Succeeded)
					{
						UnityEngine.Debug.LogError(string.Format("加载 Addressable 资源失败: {0}, 状态: {1}, 错误信息: {2}", assetPath, operationHandle.Status, operationHandle.OperationException?.Message));
						_003C_003E4__this._assetHandleMap.Remove(assetPath);
						Addressables.Release(operationHandle);
						if (_003C_003E4__this._assetGroupDict.ContainsKey(groupName))
						{
							_003C_003E4__this._assetGroupDict[groupName].Remove(assetPath);
						}
					}
					newHandleInfo.WaitSource?.TrySetResult(null);
				}
				finally
				{
					_003C_003E4__this._lock.ExitWriteLock();
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000635")]
		[CompilerGenerated]
		private struct _003CGenerateGroupsMap_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x40032BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40032BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40032BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AssetsManager _003C_003E4__this;

			[Token(Token = "0x60020CA")]
			[Address(RVA = "0x3F136BC", Offset = "0x3F0F6BC", VA = "0x3F136BC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60020CB")]
			[Address(RVA = "0x3F13BD8", Offset = "0x3F0FBD8", VA = "0x3F13BD8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000636")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40032BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40032BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40032BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AssetsManager _003C_003E4__this;

			[Token(Token = "0x40032C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60020CC")]
			[Address(RVA = "0x3F13BE4", Offset = "0x3F0FBE4", VA = "0x3F13BE4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60020CD")]
			[Address(RVA = "0x3F14074", Offset = "0x3F10074", VA = "0x3F14074", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000637")]
		[CompilerGenerated]
		private struct _003CLoadAssetAsync_003Ed__19<T> : IAsyncStateMachine where T : Object
		{
			[Token(Token = "0x40032C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40032C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x40032C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AssetsManager _003C_003E4__this;

			[Token(Token = "0x40032C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetPath;

			[Token(Token = "0x40032C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private _003C_003Ec__DisplayClass19_0<T> _003C_003E8__1;

			[Token(Token = "0x40032C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private AssetHandleInfo _003CexistingHandle_003E5__2;

			[Token(Token = "0x40032C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<object> _003C_003Eu__1;

			[Token(Token = "0x40032C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private AssetHandleInfo _003ChandleInfo_003E5__3;

			[Token(Token = "0x40032C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private AsyncOperationHandle<T> _003CnewHandle_003E5__4;

			[Token(Token = "0x40032CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<T> _003C_003Eu__2;

			[Token(Token = "0x60020CE")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60020CF")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40032A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, List<AsyncOperationHandle>> _assetHandles;

		[Token(Token = "0x40032A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _showDebugInfo;

		[Token(Token = "0x40032A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector2 _scrollPosition;

		[Token(Token = "0x40032A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<string, AssetHandleInfo> _assetHandleMap;

		[Token(Token = "0x40032A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly ReaderWriterLockSlim _lock;

		[Token(Token = "0x40032AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool initcomplete;

		[Token(Token = "0x40032AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, List<string>> _assetGroupDict;

		[Token(Token = "0x40032AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, AssetsPathInfo> _assetGroupNameDict;

		[Token(Token = "0x40032AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GUIStyle _largeLabelStyle;

		[Token(Token = "0x40032AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GUIStyle _largeButtonStyle;

		[Token(Token = "0x40032B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GUIStyle _headerStyle;

		[Token(Token = "0x40032B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool _showDetails;

		[Token(Token = "0x40032B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _fontSizeScale;

		[Token(Token = "0x170001C8")]
		public float BundleLoadingProgress
		{
			[Token(Token = "0x60020BA")]
			[Address(RVA = "0x3F12964", Offset = "0x3F0E964", VA = "0x3F12964")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x60020BB")]
			[Address(RVA = "0x3F1296C", Offset = "0x3F0E96C", VA = "0x3F1296C")]
			[CompilerGenerated]
			private set;
		}

		[Token(Token = "0x170001C9")]
		public bool IsUpdating
		{
			[Token(Token = "0x60020BC")]
			[Address(RVA = "0x3F12974", Offset = "0x3F0E974", VA = "0x3F12974")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x60020BD")]
			[Address(RVA = "0x3F1297C", Offset = "0x3F0E97C", VA = "0x3F1297C")]
			[CompilerGenerated]
			private set;
		}

		[Token(Token = "0x60020BE")]
		[Address(RVA = "0x3F12988", Offset = "0x3F0E988", VA = "0x3F12988", Slot = "4")]
		public override async UniTask Init()
		{
			await GenerateGroupsMap();
			BundleLoadingProgress = 1f;
			_ = ObjPoolManager.Instance.Init();
			EventManager.Instance.TriggerEvent("AssetsManagerInitComplete", null);
			initcomplete = true;
		}

		[Token(Token = "0x60020BF")]
		[Address(RVA = "0x3F12A14", Offset = "0x3F0EA14", VA = "0x3F12A14")]
		private async UniTask GenerateGroupsMap()
		{
			_assetGroupDict = new Dictionary<string, List<string>>();
			TextAsset config = UnityEngine.Resources.Load<TextAsset>("AddressablesConfig");
			List<AssetsPathInfo> items = JsonUtility.FromJson<AssetsPathInfoCollection>(config.text).items;
			_assetGroupNameDict = new Dictionary<string, AssetsPathInfo>();
			foreach (AssetsPathInfo item in items)
			{
				_assetGroupNameDict.Add(item.assetPath, item);
				if (!_assetGroupDict.ContainsKey(item.groupName))
				{
					_assetGroupDict.Add(item.groupName, new List<string>());
				}
			}
		}

		[Token(Token = "0x60020C0")]
		public async UniTask<T> LoadAssetAsync<T>(string assetPath) where T : Object
		{
			var context = new _003C_003Ec__DisplayClass19_0<T>
			{
				_003C_003E4__this = this,
				assetPath = assetPath
			};
			_lock.EnterUpgradeableReadLock();
			try
			{
				if (_assetHandleMap.TryGetValue(assetPath, out AssetHandleInfo existingHandle))
				{
					if (!existingHandle.Handle.IsDone)
					{
						Interlocked.Increment(ref existingHandle.RefCount);
						await existingHandle.Handle.Task;
						return (T)existingHandle.Handle.Result;
					}
					if (existingHandle.Handle.Status == AsyncOperationStatus.Succeeded)
					{
						Interlocked.Increment(ref existingHandle.RefCount);
						return (T)existingHandle.Handle.Result;
					}
				}
				_lock.EnterWriteLock();
				try
				{
					if (_assetHandleMap.TryGetValue(assetPath, out AssetHandleInfo handleInfo))
					{
						Interlocked.Increment(ref handleInfo.RefCount);
						await handleInfo.Handle.Task;
						return (T)handleInfo.Handle.Result;
					}
					if (!_assetGroupNameDict.ContainsKey(assetPath))
					{
						UnityEngine.Debug.LogError("资源路径 " + assetPath + " 不在 AddressablesConfig.json 中，请运行 Tools/AddressableConfig保存配置到JSON文件 更新配置");
						throw new global::System.Exception("资源路径 " + assetPath + " 未在 Addressable 配置中找到");
					}
					AsyncOperationHandle<T> newHandle = Addressables.LoadAssetAsync<T>(assetPath);
					context.newHandleInfo = new AssetHandleInfo
					{
						Handle = newHandle,
						RefCount = 1,
						WaitSource = new UniTaskCompletionSource<object>()
					};
					_assetHandleMap[assetPath] = context.newHandleInfo;
					context.groupName = _assetGroupNameDict[assetPath].groupName;
					if (!_assetGroupDict.ContainsKey(context.groupName))
					{
						_assetGroupDict[context.groupName] = new List<string>();
					}
					_assetGroupDict[context.groupName].Add(assetPath);
					newHandle.Completed += context._003CLoadAssetAsync_003Eb__0;
					await newHandle.Task;
					if (newHandle.Status == AsyncOperationStatus.Succeeded)
					{
						if (newHandle.Result == null)
						{
							UnityEngine.Debug.LogError("加载 Addressable 资源返回 null: " + assetPath);
							_assetHandleMap.Remove(assetPath);
							throw new global::System.Exception("加载 Addressable 资源返回 null: " + assetPath);
						}
						return newHandle.Result;
					}
					string error = newHandle.OperationException != null ? newHandle.OperationException.Message : string.Format("加载失败，状态: {0}", newHandle.Status);
					UnityEngine.Debug.LogError("加载 Addressable 资源失败: " + assetPath + ", " + error);
					_assetHandleMap.Remove(assetPath);
					throw new global::System.Exception("加载 Addressable 资源失败: " + assetPath + ", " + error);
				}
				finally
				{
					_lock.ExitWriteLock();
				}
			}
			finally
			{
				_lock.ExitUpgradeableReadLock();
			}
		}

		[Token(Token = "0x60020C1")]
		[Address(RVA = "0x3F12A98", Offset = "0x3F0EA98", VA = "0x3F12A98")]
		public void UnloadAsset(string assetPath)
		{
			_lock.EnterUpgradeableReadLock();
			try
			{
				if (_assetHandleMap.TryGetValue(assetPath, out AssetHandleInfo handleInfo))
				{
					_lock.EnterWriteLock();
					try
					{
						if (Interlocked.Decrement(ref handleInfo.RefCount) == 0)
						{
							if (handleInfo.Handle.IsValid())
							{
								Addressables.Release(handleInfo.Handle);
								_assetGroupDict[_assetGroupNameDict[assetPath].groupName].Remove(assetPath);
							}
							_assetHandleMap.Remove(assetPath);
						}
					}
					finally
					{
						_lock.ExitWriteLock();
					}
				}
			}
			finally
			{
				_lock.ExitUpgradeableReadLock();
			}
		}

		[Token(Token = "0x60020C2")]
		[Address(RVA = "0x3F12DB8", Offset = "0x3F0EDB8", VA = "0x3F12DB8")]
		public void UnloadGroup(string groupName)
		{
			foreach (string assetPath in new List<string>(_assetGroupDict[groupName]))
			{
				UnloadAsset(assetPath);
			}
			UnityEngine.Resources.UnloadUnusedAssets();
		}

		[Token(Token = "0x60020C3")]
		[Address(RVA = "0x3F12F6C", Offset = "0x3F0EF6C", VA = "0x3F12F6C")]
		private void InitGUIStyles()
		{
		}

		[Token(Token = "0x60020C4")]
		[Address(RVA = "0x3F1337C", Offset = "0x3F0F37C", VA = "0x3F1337C")]
		public void ForceUnloadUnusedAssets()
		{
			UnityEngine.Resources.UnloadUnusedAssets();
			global::System.GC.Collect();
		}

		[Token(Token = "0x60020C5")]
		[Address(RVA = "0x3F133D4", Offset = "0x3F0F3D4", VA = "0x3F133D4")]
		public void ForceUnloadAsset(string assetPath)
		{
			_lock.EnterWriteLock();
			try
			{
				if (_assetHandleMap.TryGetValue(assetPath, out AssetHandleInfo handleInfo))
				{
					if (handleInfo.Handle.IsValid())
					{
						Addressables.Release(handleInfo.Handle);
					}
					_assetHandleMap.Remove(assetPath);
				}
			}
			finally
			{
				_lock.ExitWriteLock();
			}
		}

		[Token(Token = "0x60020C6")]
		[Address(RVA = "0x3F13590", Offset = "0x3F0F590", VA = "0x3F13590")]
		public AssetsManager()
		{
			_assetHandles = new Dictionary<string, List<AsyncOperationHandle>>();
			_assetHandleMap = new Dictionary<string, AssetHandleInfo>();
			_lock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);
			_showDetails = true;
			_fontSizeScale = 1.2f;
		}
	}
}
