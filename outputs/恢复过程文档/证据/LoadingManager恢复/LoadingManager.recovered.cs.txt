using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using L_Tools;
using QuickTutor;
using SDKModule;
using ToolModule;
using UIFramework;
using UnityEngine;

namespace LoadingModule
{
	[Token(Token = "0x20001CF")]
	public class LoadingManager : ManagerBase<LoadingManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001D0")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4001B86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001B88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LoadingManager _003C_003E4__this;

			[Token(Token = "0x4001B89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x40831A4", Offset = "0x407F1A4", VA = "0x40831A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x4083944", Offset = "0x407F944", VA = "0x4083944", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20001D1")]
		[CompilerGenerated]
		private sealed class _003CLoadingScene_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001B8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001B8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001B8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoadingManager _003C_003E4__this;

			[Token(Token = "0x4001B8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float _003Cp_003E5__2;

			[Token(Token = "0x4001B8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float _003CloadingTimer_003E5__3;

			[Token(Token = "0x4001B8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003Cindex_003E5__4;

			[Token(Token = "0x1700009F")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000770")]
				[Address(RVA = "0x4084190", Offset = "0x4080190", VA = "0x4084190", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000A0")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000772")]
				[Address(RVA = "0x40841D0", Offset = "0x40801D0", VA = "0x40841D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x4082E04", Offset = "0x407EE04", VA = "0x4082E04")]
			[DebuggerHidden]
			public _003CLoadingScene_003Ed__12(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x4083950", Offset = "0x407F950", VA = "0x4083950", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x4083954", Offset = "0x407F954", VA = "0x4083954", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x4084190", Offset = "0x4080190", VA = "0x4084190", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x4084198", Offset = "0x4080198", VA = "0x4084198", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x40841D0", Offset = "0x40801D0", VA = "0x40841D0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4001B7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UIPanel _loadingPanel;

		[Token(Token = "0x4001B7C")]
		private const float MaxLoadingTime = 0.1f;

		[Token(Token = "0x4001B7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float currentMaxProgress;

		[Token(Token = "0x4001B7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float progress1;

		[Token(Token = "0x4001B80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float progress2;

		[Token(Token = "0x4001B81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool EnterHome = false;

		[Token(Token = "0x4001B82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string SaveDirectory;

		[Token(Token = "0x4001B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string SaveInfo = "SaveInfo";

		[Token(Token = "0x4001B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string SaveDataStr = "SaveData";

		[Token(Token = "0x4001B85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool BeginStartGame;

		[Token(Token = "0x1700009E")]
		public bool IsLoadingCompleted
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x4082BDC", Offset = "0x407EBDC", VA = "0x4082BDC")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x4082BE4", Offset = "0x407EBE4", VA = "0x4082BE4")]
			[CompilerGenerated]
			set;
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x4082BF0", Offset = "0x407EBF0", VA = "0x4082BF0")]
		public void StartLoading()
		{
			_loadingPanel = GameObject.Find("LoadingPanel").GetComponent<UIPanel>();
			var loadingPanel = _loadingPanel as UIModuleO.LoadingPanel;
			if (loadingPanel != null)
			{
				loadingPanel.SetProgressBarActive(true);
			}
			_ = _loadingPanel?.Show(Array.Empty<object>());
			StartCoroutine(LoadingScene());
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x4082DEC", Offset = "0x407EDEC", VA = "0x4082DEC")]
		public void AddCurrentMaxProgress(float p)
		{
			currentMaxProgress = Mathf.Min(currentMaxProgress + p, progress1);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x4082D8C", Offset = "0x407ED8C", VA = "0x4082D8C")]
		private IEnumerator LoadingScene()
		{
			float p = 0f;
			_loadingPanel.UpdateInfo(p);
			while (p < progress1)
			{
				p += 0.01f;
				if (p >= currentMaxProgress)
				{
					p = currentMaxProgress;
				}
				_loadingPanel.UpdateInfo(p);
				yield return null;
			}
			float loadingTimer = 0f;
			while (AssetsManager.Instance.BundleLoadingProgress < 1f && loadingTimer < MaxLoadingTime)
			{
				loadingTimer += Time.deltaTime;
				yield return null;
			}
			while (!DataManager.Instance.LoadDataCompleted)
			{
				yield return null;
			}
			while (!TutorialManager.Instance.InitSteerInfoEnd)
			{
				yield return null;
			}
			EventManager.Instance.TriggerEvent("OnLoadingCompleted", null);
			while (!GameManager.Instance.InitComplete)
			{
				yield return null;
			}
			IsLoadingCompleted = true;
			EnterHome = true;
			HWIAPManager.Instance.EnterHomeInit();
			var gemCheck = new DailyTask("GemCheck");
			int lastGemCount = PlayerPrefs2Center.GetInt("LastGemCheck", 0);
			int gemCount = UserResourcesManager.Instance.GetResourceCount("20006");
			if (lastGemCount == 0 && gemCount >= 50001)
			{
				ReportEventsManager.Instance.ReportGemStartCheckNumTooBig(gemCount);
			}
			if (unchecked(gemCount - lastGemCount) >= 50001)
			{
				ReportEventsManager.Instance.ReportGemChangeTooBig(lastGemCount, gemCount);
			}
			if (gemCheck.Status == DailyTaskStatus.NoFinish)
			{
				PlayerPrefs2Center.SetInt("LastGemCheck", gemCount);
				gemCheck.Status = DailyTaskStatus.Finish;
			}
			EventManager.Instance.TriggerEvent("LoadEnd", null);
			p = progress1;
			while (p < progress2)
			{
				p = Mathf.Min(p + 0.01f, 0.9f);
				_loadingPanel.UpdateInfo(p);
				yield return null;
			}
			if (!CompareCheat.Instance.StartCheck())
			{
				yield break;
			}
			_loadingPanel.UpdateInfo(1f);
			for (int index = 20; index > 0; --index)
			{
				yield return null;
			}
			UnityEngine.Object.Destroy(_loadingPanel.gameObject);
			EventManager.Instance.TriggerEvent("CloseLoadPanel", null);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x4082E2C", Offset = "0x407EE2C", VA = "0x4082E2C", Slot = "5")]
		public virtual string GetData(string key)
		{
			string filePath = GetFilePath(key);
			return File.Exists(filePath) ? File.ReadAllText(filePath) : string.Empty;
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x4082EB4", Offset = "0x407EEB4", VA = "0x4082EB4")]
		private string GetFilePath(string key)
		{
			if (StringTool.IsNullOrEmpty(SaveDirectory, true))
			{
				_ = Init();
			}
			key = key.Replace("/", "_").Replace("\\", "_");
			return Path.Combine(SaveDirectory, key + ".txt");
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x4083028", Offset = "0x407F028", VA = "0x4083028", Slot = "4")]
		public override async UniTask Init()
		{
			if (GameConfigManager.GameGlobalConfig.OpenUploadDataLogic)
			{
				_loadingPanel = GameObject.Find("LoadingPanel").GetComponent<UIPanel>();
				var loadingPanel = _loadingPanel as UIModuleO.LoadingPanel;
				if (loadingPanel != null)
				{
					loadingPanel.SetProgressBarActive(true);
				}
				_loadingPanel.UpdateInfo(0f);
				EventManager.Instance.StartListening("OnLoadingPanelBtnUploadTestStartGameClicked", OnLoadingPanelBtnUploadTestStartGameClicked);
				SaveDirectory = Path.Combine(Application.persistentDataPath, SaveInfo);
				if (!Directory.Exists(SaveDirectory))
				{
					Directory.CreateDirectory(SaveDirectory);
				}
				string saveDataDirectory = SaveDirectory.Replace(SaveDataStr, SaveInfo);
				if (!Directory.Exists(saveDataDirectory))
				{
					Directory.CreateDirectory(saveDataDirectory);
				}
				await UniTask.WaitForSeconds(0.1f);
			}
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x40830B4", Offset = "0x407F0B4", VA = "0x40830B4")]
		private void OnLoadingPanelBtnUploadTestStartGameClicked(object o)
		{
			BeginStartGame = true;
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x40830C0", Offset = "0x407F0C0", VA = "0x40830C0")]
		public LoadingManager()
		{
			currentMaxProgress = 0.2f;
			progress1 = 0.64f;
			progress2 = 0.9f;
		}
	}
}
