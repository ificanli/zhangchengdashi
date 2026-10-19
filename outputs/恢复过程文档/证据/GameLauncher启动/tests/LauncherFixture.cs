// Generated from current GameLauncher.cs; TEST ONLY, not installed into Unity.
using System;
using System.Reflection;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using AssetsModule;
using DataModule;
using EventModule;
using GameConfigModule;
using GameModule;
using LoadingModule;
using LocalizationModule.Runtime;
using SDKModule;
using TimeModuleO;
using TutorModule;
using UIFramework;
using UIModuleO;
namespace CoreModule { public class GameLauncher : MonoBehaviour { private Task _initBaseManagerTask; private bool _isLoadingCompletedListening;
private void Awake()
		{
			SetOptimalPerformanceSettings();
			_initBaseManagerTask = InitBaseManager();
			CheatControl.Instance.Init();
		}

private async Task InitBaseManager()
		{
			await EventManager.Instance.Init();
			await TestTasks.WaitUntil(() => AssetsManager.Instance.initcomplete);
			AssetsManager.Instance.transform.SetParent(transform);
			await GameConfigManager.Instance.Init();
		}

private async void Start()
		{
			await _initBaseManagerTask;
			StartLoadingCompletedListening();
			LoadingManager.Instance.StartLoading();
			Login();
		}

private async void Login()
		{
			await TestTasks.WaitUntil(() => L_Tools.LoginControl.I.Curloginstate == L_Tools.LoginState.Success);
			GameLogic().Forget();
		}

private async Task GameLogic()
		{
			await ABTestManager.Instance.Init(Array.Empty<object>());
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			RunInitManager().Forget();
		}

private async Task RunInitManager()
		{
			await InitManager();
		}

private async Task InitManager()
		{
			Debug.Log("YYY  InitManager " + Time.time.ToString());
			Task customBundlesManagerTask = TestTasks.WaitUntil(() => CustomBundlesManager.Instance.PreloadTaskCompleted);
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			Task timeManagerTask = TimeManager.Instance.Init();
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			Task loadConfigTask = DataManager.Instance.LoadConfig();
			await HWIAPManager.Instance.Init();
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			await DataManager.Instance.Init();
			await UIManager.Instance.Init();
			await loadConfigTask;
			await DataManager.Instance.LoadData();
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			if (!DataManager.Instance.LoadDataCompleted)
			{
				await TestTasks.WaitUntil(() => DataManager.Instance.LoadDataCompleted);
			}
			await UserResourcesManager.Instance.Init();
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			await CameraModule.CameraManager.Instance.Init();
			LoadingManager.Instance.AddCurrentMaxProgress(0.05f);
			await Task.WhenAll(customBundlesManagerTask, timeManagerTask);
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

private void LoadingCompleted(object obj)
		{
			StopLoadingCompletedListening();
			InitGame();
		}

private void StartLoadingCompletedListening()
		{
			if (!_isLoadingCompletedListening)
			{
				EventManager.Instance.StartListening("OnLoadingCompleted", LoadingCompleted);
				_isLoadingCompletedListening = true;
			}
		}

private void StopLoadingCompletedListening()
		{
			if (_isLoadingCompletedListening)
			{
				EventManager.Instance.StopListening("OnLoadingCompleted", LoadingCompleted);
				_isLoadingCompletedListening = false;
			}
		}

private async void InitGame()
		{
			await GameManager.Instance.Init();
		}

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

private void ApplyThirtyFpsLightingSettings(UniversalRenderPipelineAsset asset)
		{
			asset.shadowDistance = 0f;
			TrySetPropertyOrField(asset, "supportsMainLightShadows", "m_MainLightShadowsSupported", false);
			TrySetPropertyOrField(asset, "supportsAdditionalLightShadows", "m_AdditionalLightShadowsSupported", false);
			TrySetPropertyOrField(asset, "supportsSoftShadows", "m_SoftShadowsSupported", false);
			TrySetPropertyOrField(asset, "m_AnyShadowsSupported", "m_AnyShadowsSupported", false);
		}

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
}}
