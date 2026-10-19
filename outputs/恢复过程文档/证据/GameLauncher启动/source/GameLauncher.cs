using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using AssetsModule;
using DataModule;
using EventModule;
using GameConfigModule;
using GameModule;
using Il2CppDummyDll;
using LoadingModule;
using LocalizationModule.Runtime;
using SDKModule;
using TimeModuleO;
using TutorModule;
using UIFramework;
using UIModuleO;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using Debug = UnityEngine.Debug;

namespace CoreModule
{
	[Token(Token = "0x200020C")]
	public class GameLauncher : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200020E")]
		[CompilerGenerated]
		private struct _003CGameLogic_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4001D00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001D01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001D02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameLauncher _003C_003E4__this;

			[Token(Token = "0x4001D03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x4192468", Offset = "0x418E468", VA = "0x4192468", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x419297C", Offset = "0x418E97C", VA = "0x419297C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200020F")]
		[CompilerGenerated]
		private struct _003CInitBaseManager_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4001D04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001D05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001D06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameLauncher _003C_003E4__this;

			[Token(Token = "0x4001D07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x4192988", Offset = "0x418E988", VA = "0x4192988", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x4193298", Offset = "0x418F298", VA = "0x4193298", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000210")]
		[CompilerGenerated]
		private struct _003CInitGame_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4001D08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001D09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001D0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x41932A4", Offset = "0x418F2A4", VA = "0x41932A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600089B")]
			[Address(RVA = "0x41935A8", Offset = "0x418F5A8", VA = "0x41935A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000211")]
		[CompilerGenerated]
		private struct _003CInitManager_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4001D0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001D0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001D0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameLauncher _003C_003E4__this;

			[Token(Token = "0x4001D0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask _003CcustomBundlesManagerTask_003E5__2;

			[Token(Token = "0x4001D0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask _003CtimeManagerTask_003E5__3;

			[Token(Token = "0x4001D10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask _003CloadConfigTask_003E5__4;

			[Token(Token = "0x4001D11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4001D12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask<UIFramework.UIPanel>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x600089C")]
			[Address(RVA = "0x41935B4", Offset = "0x418F5B4", VA = "0x41935B4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x4195410", Offset = "0x4191410", VA = "0x4195410", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000212")]
		[CompilerGenerated]
		private struct _003CLogin_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4001D13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001D14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001D15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameLauncher _003C_003E4__this;

			[Token(Token = "0x4001D16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x419541C", Offset = "0x419141C", VA = "0x419541C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x41957CC", Offset = "0x41917CC", VA = "0x41957CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000213")]
		[CompilerGenerated]
		private struct _003CRunInitManager_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4001D17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001D18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001D19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameLauncher _003C_003E4__this;

			[Token(Token = "0x4001D1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x41957D8", Offset = "0x41917D8", VA = "0x41957D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x4195B64", Offset = "0x4191B64", VA = "0x4195B64", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000214")]
		[CompilerGenerated]
		private struct _003CStart_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4001D1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001D1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001D1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameLauncher _003C_003E4__this;

			[Token(Token = "0x4001D1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x4195B70", Offset = "0x4191B70", VA = "0x4195B70", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x4195E98", Offset = "0x4191E98", VA = "0x4195E98", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001CF8")]
		public const int DVersion = 17;

		[Token(Token = "0x4001CF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UniTask _initBaseManagerTask;

		[Token(Token = "0x4001CFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _isLoadingCompletedListening;

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x4190F40", Offset = "0x418CF40", VA = "0x4190F40")]
		private void Awake()
		{
			SetOptimalPerformanceSettings();
			_initBaseManagerTask = InitBaseManager();
			CheatControl.Instance.Init();
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x41911B8", Offset = "0x418D1B8", VA = "0x41911B8")]
		private async UniTask InitBaseManager()
		{
			await EventManager.Instance.Init();
			await UniTask.WaitUntil(() => AssetsManager.Instance.initcomplete);
			AssetsManager.Instance.transform.SetParent(transform);
			await GameConfigManager.Instance.Init();
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x4191244", Offset = "0x418D244", VA = "0x4191244")]
		private async void Start()
		{
			await _initBaseManagerTask;
			StartLoadingCompletedListening();
			LoadingManager.Instance.StartLoading();
			Login();
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x41912D0", Offset = "0x418D2D0", VA = "0x41912D0")]
		private async void Login()
		{
			await UniTask.WaitUntil(() => L_Tools.LoginControl.I.Curloginstate == L_Tools.LoginState.Success);
			GameLogic().Forget();
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x419135C", Offset = "0x418D35C", VA = "0x419135C")]
		private async UniTask GameLogic()
		{
			await ABTestManager.Instance.Init(Array.Empty<object>());
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			RunInitManager().Forget();
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x41913E8", Offset = "0x418D3E8", VA = "0x41913E8")]
		private async UniTaskVoid RunInitManager()
		{
			await InitManager();
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x4191460", Offset = "0x418D460", VA = "0x4191460")]
		private async UniTask InitManager()
		{
			Debug.Log("YYY  InitManager " + Time.time.ToString());
			UniTask customBundlesManagerTask = UniTask.WaitUntil(() => CustomBundlesManager.Instance.PreloadTaskCompleted);
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			UniTask timeManagerTask = TimeManager.Instance.Init();
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			UniTask loadConfigTask = DataManager.Instance.LoadConfig();
			await HWIAPManager.Instance.Init();
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			await DataManager.Instance.Init();
			await UIManager.Instance.Init();
			await loadConfigTask;
			await DataManager.Instance.LoadData();
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			if (!DataManager.Instance.LoadDataCompleted)
			{
				await UniTask.WaitUntil(() => DataManager.Instance.LoadDataCompleted);
			}
			await UserResourcesManager.Instance.Init();
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			await CameraModule.CameraManager.Instance.Init();
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			await UniTask.WhenAll(customBundlesManagerTask, timeManagerTask);
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			await CustomBundlesManager.Instance.Init();
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			await UIManager.Instance.GetPanel("Assets/_Res/Addressable/01FirstBundle/Prefabs/UI/Panels/NoInternetPanel.prefab");
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			Debug.Log("需要等待的必要相关管理器初始化完成");
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			StartBackgroundManagersInit();
			if (DbtSaveDataManager_PlayerCoreData.I.Data.firstEnterGameTime == DateTime.MinValue)
			{
				DbtSaveDataManager_PlayerCoreData.I.Data.firstEnterGameTime =
					DbtSaveDataManager_PlayerGuideData.I.Data.isFirstThroghGame
						? TimeManager.Instance.GetNetworkTime(false)
						: TimeManager.Instance.GetNetworkTime(false).AddDays(-4.0);
				DbtSaveDataManager_PlayerCoreData.I.Save();
			}
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x41914F8", Offset = "0x418D4F8", VA = "0x41914F8")]
		private void StartBackgroundManagersInit()
		{
			FeatureUnlockManager.Instance.Init().Forget();
			AudioManager.Instance.Init().Forget();
			UIHUDManager.Instance.Init().Forget();
			EffectManager.Instance.Init().Forget();
			UITextEffectManager.Instance.Init().Forget();
			MaterialsManager.Instance.Init().Forget();
			SteerManager.Instance.Init().Forget();
			CheckStayGetRewardManager.Instance.Init().Forget();
			ReportEventsManager.Instance.Init().Forget();
			PanelPopHandleManager.Instance.Init().Forget();
			PacksTipManager.Instance.Init().Forget();
			PropDetailsManager.Instance.Init().Forget();
			AdButtonManager.Instance.Init().Forget();
			AnnouncementManager.Instance.Init().Forget();
			ResourceObtainGuideManager.Instance.Init().Forget();
			CheckInRewardManager.Instance.Init().Forget();
			SubGameChaosTrailsManager.Instance.Init().Forget();
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x4191894", Offset = "0x418D894", VA = "0x4191894")]
		private void LoadingCompleted(object obj)
		{
			StopLoadingCompletedListening();
			InitGame();
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x41919FC", Offset = "0x418D9FC", VA = "0x41919FC")]
		private void StartLoadingCompletedListening()
		{
			if (!_isLoadingCompletedListening)
			{
				EventManager.Instance.StartListening("OnLoadingCompleted", LoadingCompleted);
				_isLoadingCompletedListening = true;
			}
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x41918A4", Offset = "0x418D8A4", VA = "0x41918A4")]
		private void StopLoadingCompletedListening()
		{
			if (_isLoadingCompletedListening)
			{
				EventManager.Instance.StopListening("OnLoadingCompleted", LoadingCompleted);
				_isLoadingCompletedListening = false;
			}
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x4191974", Offset = "0x418D974", VA = "0x4191974")]
		private async void InitGame()
		{
			await GameManager.Instance.Init();
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x4190FFC", Offset = "0x418CFFC", VA = "0x4190FFC")]
		private void SetOptimalPerformanceSettings()
		{
			int systemMemorySize = SystemInfo.systemMemorySize;
			bool supportsComputeShaders = SystemInfo.supportsComputeShaders;
			UniversalRenderPipelineAsset asset = GraphicsSettings.currentRenderPipeline as UniversalRenderPipelineAsset;
			if (asset != null)
			{
				Application.targetFrameRate = systemMemorySize < 3072 ? 30 : 60;
				asset.renderScale = systemMemorySize < 3072 ? 0.75f : 0.8f;
				if (!supportsComputeShaders)
				{
					asset.renderScale = Mathf.Max(asset.renderScale - 0.1f, 0.7f);
					Application.targetFrameRate = Mathf.Min(Application.targetFrameRate, 30);
				}
			}
			else
			{
				Application.targetFrameRate = systemMemorySize < 3072 ? 30 : 60;
			}
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x4191AD0", Offset = "0x418DAD0", VA = "0x4191AD0")]
		private void ApplyThirtyFpsRenderingSettings(UniversalRenderPipelineAsset asset)
		{
			if (asset == null)
			{
				return;
			}
			asset.msaaSampleCount = 1;
			ApplyThirtyFpsLightingSettings(asset);
			DisablePostProcessingForLoadedCameras();
			if (!TrySetRendererFeatureActive(asset, "Render Effects", false))
			{
				Debug.LogWarning("30帧策略：未能关闭Render Effects描边");
			}
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x4191BDC", Offset = "0x418DBDC", VA = "0x4191BDC")]
		private void ApplyThirtyFpsLightingSettings(UniversalRenderPipelineAsset asset)
		{
			asset.shadowDistance = 0f;
			TrySetPropertyOrField(asset, "supportsMainLightShadows", "m_MainLightShadowsSupported", false);
			TrySetPropertyOrField(asset, "supportsAdditionalLightShadows", "m_AdditionalLightShadowsSupported", false);
			TrySetPropertyOrField(asset, "supportsSoftShadows", "m_SoftShadowsSupported", false);
			TrySetPropertyOrField(asset, "m_AnyShadowsSupported", "m_AnyShadowsSupported", false);
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x4191D50", Offset = "0x418DD50", VA = "0x4191D50")]
		private void DisablePostProcessingForLoadedCameras()
		{
			int count = Camera.allCamerasCount;
			if (count <= 0)
			{
				Debug.LogWarning("30帧策略：当前没有已加载相机，跳过关闭Post-processing。");
				return;
			}
			Camera[] cameras = new Camera[count];
			int loadedCount = Camera.GetAllCameras(cameras);
			for (int i = 0; i < loadedCount; i++)
			{
				if (cameras[i] == null)
				{
					continue;
				}
				UniversalAdditionalCameraData cameraData = cameras[i].GetUniversalAdditionalCameraData();
				cameraData.renderPostProcessing = false;
				cameraData.antialiasing = AntialiasingMode.None;
			}
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x4191EA4", Offset = "0x418DEA4", VA = "0x4191EA4")]
		private bool TrySetRendererFeatureActive(UniversalRenderPipelineAsset asset, string featureName, bool active)
		{
			if (!TryGetDefaultRendererData(asset, out ScriptableRendererData rendererData))
			{
				Debug.LogWarning("无法获取当前URP默认RendererData，跳过Render Effects设置。");
				return false;
			}
			for (int i = 0; i < rendererData.rendererFeatures.Count; i++)
			{
				ScriptableRendererFeature feature = rendererData.rendererFeatures[i];
				if (feature != null && string.Equals(feature.name, featureName, StringComparison.OrdinalIgnoreCase))
				{
					feature.SetActive(active);
					return true;
				}
			}
			Debug.LogWarning("未找到Renderer Feature：" + featureName);
			return false;
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x4192068", Offset = "0x418E068", VA = "0x4192068")]
		private bool TryGetDefaultRendererData(UniversalRenderPipelineAsset asset, out ScriptableRendererData rendererData)
		{
			rendererData = null;
			if (asset == null)
			{
				return false;
			}
			Type type = asset.GetType();
			const BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
			PropertyInfo property = type.GetProperty("scriptableRendererData", flags);
			if (property?.GetValue(asset) is ScriptableRendererData defaultRendererData)
			{
				rendererData = defaultRendererData;
				return true;
			}
			FieldInfo listField = type.GetField("m_RendererDataList", flags);
			FieldInfo indexField = type.GetField("m_DefaultRendererIndex", flags);
			ScriptableRendererData[] rendererDataList = (ScriptableRendererData[])listField?.GetValue(asset);
			if (indexField != null && rendererDataList != null && indexField.GetValue(asset) is int index && index >= 0 && index < rendererDataList.Length)
			{
				rendererData = rendererDataList[index];
				return rendererData != null;
			}
			return false;
		}

		[Token(Token = "0x600088E")]
		private bool TrySetPropertyOrField<T>(object target, string propertyName, string fieldName, T value)
		{
			if (target == null)
			{
				return false;
			}
			Type type = target.GetType();
			PropertyInfo property = type.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			MethodInfo setter = property?.GetSetMethod(true);
			if (setter != null)
			{
				setter.Invoke(target, new object[] { value });
				return true;
			}
			FieldInfo field = type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
			if (field != null)
			{
				field.SetValue(target, value);
				return true;
			}
			return false;
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x41922E0", Offset = "0x418E2E0", VA = "0x41922E0")]
		public GameLauncher()
		{
		}
	}
}
