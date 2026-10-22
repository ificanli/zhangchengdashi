#if UNITY_EDITOR
using System.IO;
using UnityEngine;

namespace GameFramework.Recovery
{
    internal static class LocalEditorSessionBootstrap
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void BeginLocalSession()
        {
            LocalEditorSession.Begin(Path.GetFullPath(Path.Combine(Application.dataPath, "../../../work/occupycity-singleplayer")));
            LocalEditorPlatformMetadata.InitializeForSelectedSession();
            EnsureLocalAppInfoProvider();
            // The independent Editor session keeps the original player loop running
            // while the user inspects the recovered project in another window.
            Application.runInBackground = true;
            Debug.Log("[LocalEditorSession] Independent single-player profile and save storage verified: "
                + LocalEditorSession.ProfileRoot + "; no SDK/server login result produced.");
        }
        private static void EnsureLocalAppInfoProvider()
        {
            LocalEditorSession.RequireReady();
            // Read the verified local mode before creating any platform metadata component.
            LocalEditorPlatformMetadata.ReadDesignMode();
            if (DBTSDK.AppInfoManager.Instance != null) return;
            GameObject provider = new GameObject("[LocalEditorSession] AppInfo metadata host");
            UnityEngine.Object.DontDestroyOnLoad(provider);
            DBTSDK.AppInfoManager created = provider.AddComponent<DBTSDK.AppInfoManager>();
            if (created == null || DBTSDK.AppInfoManager.Instance != created)
                throw new System.InvalidOperationException("The independent AppInfo component did not register through the restored original Awake.");
            Debug.Log("[LocalEditorPlatformMetadata] Original AppInfo Awake registered a local metadata host; no SDK initialization or success result was produced.");
        }

    }
}
#endif
