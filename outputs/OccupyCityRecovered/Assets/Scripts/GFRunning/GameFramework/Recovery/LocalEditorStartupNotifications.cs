#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace GameFramework.Recovery
{
    // These platform calls notify Android/reporting services. They do
    // not return a game initialization result. Editor records the unavailable
    // capability locally; it never invokes SDK callbacks or produces a gate.
    public static class LocalEditorStartupNotifications
    {
        [Serializable] private sealed class Notification
        {
            public string utc, originalTarget, originalRva, originalArgument;
            public string operation = "recorded_local_editor_capability_gap";
            public bool originalSdkInvoked;
            public int completionCallbacksInvoked;
        }
        [Serializable] private sealed class Receipt
        {
            public string provider = "LocalEditorStartupNotifications";
            public bool sdkLoginSupported;
            public bool androidNotificationSupported;
            public bool remoteAnalyticsSupported;
            public List<Notification> records = new List<Notification>();
        }
        private static readonly Receipt Recorded = new Receipt();

        public static void RecordGameLoadingNotification()
        {
            Record("DBTSDK.SDKToolManager.U3DGameStart_Override -> U3DGameStart", "0x70AE98C -> 0x70AE990");
        }

        public static void RecordGameInteractiveNotification(string info = "")
        {
            LocalEditorSession.RequireReady();
            Record("DBTSDK.SDKToolManager.ReportGameInteractive", "0x70AE6A4", info);
        }

        public static void RecordStartMineGameAnalytics()
        {
            Record("DBTSDK.ReportManager.StartMineGame", "0x73914C0");
        }

        public static void RecordStartGameModelAnalytics(MineGameModel model)
        {
            Record("DBTSDK.ReportManager.StartGameModel", "0x7391610 -> 0x739168C", model.ToString());
        }

        public static void RecordGamePlayTimeAnalytics(int times)
        {
            Record("DBTSDK.ReportManager.ReportGamePlayTime", "0x739160C", times.ToString(System.Globalization.CultureInfo.InvariantCulture));
        }

        public static string ReadUnavailableAppChannelGroup()
        {
            Record("DBTSDK.AppInfoManager.GetAppChannelGroup", "0x73A141C", "No Android distribution channel is supplied by the local Editor host");
            // This query is optional in the original caller. Null means that no
            // SDK distribution channel is available; no account decision is made.
            return null;
        }

        public static string ReadUnavailableOnlineConfig(string key)
        {
            LocalEditorSession.RequireReady();
            Record("DBTSDK.AppInfoManager.GetOnlineConfigParams", "0x739D3F0", key);
            // The original reader handles an unavailable provider through its
            // caller-supplied fallback. This host supplies no server parameters.
            return null;
        }

        private static void Record(string target, string rva, string argument = null)
        {
            Recorded.records.Add(new Notification { utc = DateTime.UtcNow.ToString("o"), originalTarget = target, originalRva = rva, originalArgument = argument });
            string project = Directory.GetParent(Application.dataPath).FullName;
            string report = Path.Combine(project, "RecoveryReports", "local-editor-platform-notifications.json");
            Directory.CreateDirectory(Path.GetDirectoryName(report));
            File.WriteAllText(report, JsonUtility.ToJson(Recorded, true));
            Debug.Log("[LocalEditorStartupNotifications] Recorded unavailable Android/analytics notification locally: " + target + "; no SDK call, login result, or completion callback.");
        }
    }
}
#endif
