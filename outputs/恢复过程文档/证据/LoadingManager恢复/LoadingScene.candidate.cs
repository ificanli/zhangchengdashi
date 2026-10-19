// Reconstruction candidate for LoadingModule.LoadingManager.LoadingScene.
// Evidence: 0x4083954.asm.txt, dump.cs fields, script.json native refs,
// and loading-constants.json. This file is NOT part of the Unity project.
// Transplant the method into the existing class only after integrating its
// real dependencies. No new placeholder Manager implementations are supplied.
using System.Collections;
using AssetsModule;
using DataModule;
using EventModule;
using GameModule;
using L_Tools;
using QuickTutor;
using SDKModule;
using UnityEngine;

namespace LoadingModule
{
    public partial class LoadingManager
    {
        // Existing fields used: _loadingPanel, currentMaxProgress, progress1,
        // progress2, IsLoadingCompleted, EnterHome. Their definitions stay original.
        private IEnumerator LoadingSceneRecoveredCandidate()
        {
            float p = 0f;
            _loadingPanel.UpdateInfo(p);
            while (p < progress1)
            {
                p += 0.01f; // .rodata RVA 0x1837464
                if (p >= currentMaxProgress)
                    p = currentMaxProgress;
                _loadingPanel.UpdateInfo(p);
                yield return null; // iterator state 1
            }

            float loadingTimer = 0f;
            while (AssetsManager.Instance.BundleLoadingProgress < 1f && loadingTimer < 0.1f)
            {
                loadingTimer += Time.deltaTime;
                yield return null; // state 2; only this progress wait has a timeout
            }
            while (!DataManager.Instance.LoadDataCompleted)
                yield return null; // state 3
            while (!TutorialManager.Instance.InitSteerInfoEnd)
                yield return null; // state 4

            EventManager.Instance.TriggerEvent("OnLoadingCompleted", null);
            while (!GameManager.Instance.InitComplete)
                yield return null; // state 5

            IsLoadingCompleted = true;
            EnterHome = true;
            HWIAPManager.Instance.EnterHomeInit();
            var gemCheck = new DailyTask("GemCheck");
            int lastGemCount = PlayerPrefs2Center.GetInt("LastGemCheck", 0);
            int gemCount = UserResourcesManager.Instance.GetResourceCount("20006");
            if (lastGemCount == 0 && gemCount >= 50001)
                ReportEventsManager.Instance.ReportGemStartCheckNumTooBig(gemCount);
            if (unchecked(gemCount - lastGemCount) >= 50001)
                ReportEventsManager.Instance.ReportGemChangeTooBig(lastGemCount, gemCount);
            if (gemCheck.Status == DailyTaskStatus.NoFinish)
            {
                PlayerPrefs2Center.SetInt("LastGemCheck", gemCount);
                gemCheck.Status = DailyTaskStatus.Finish;
            }
            EventManager.Instance.TriggerEvent("LoadEnd", null);

            p = progress1;
            while (p < progress2)
            {
                p = Mathf.Min(p + 0.01f, 0.9f); // constants from ELF, state 6
                _loadingPanel.UpdateInfo(p);
                yield return null;
            }
            if (!CompareCheat.Instance.StartCheck())
                yield break; // original false branch leaves loading panel intact

            _loadingPanel.UpdateInfo(1f);
            for (int index = 20; index > 0; --index)
                yield return null; // state 7
            Object.Destroy(_loadingPanel.gameObject);
            EventManager.Instance.TriggerEvent("CloseLoadPanel", null);
        }
    }
}
