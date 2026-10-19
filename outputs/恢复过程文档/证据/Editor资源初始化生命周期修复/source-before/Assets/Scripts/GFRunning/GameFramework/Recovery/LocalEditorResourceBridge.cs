#if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using GameFramework.Resources;
using UnityEngine;

namespace GameFramework.Recovery
{
    // Explicit Editor platform I/O boundary. No UnityEditor/Addressables assembly
    // reference is introduced into GFRunning, and no SDK/user state is produced.
    public interface ILocalEditorResourcesProvider
    {
        string ProviderId { get; }
        bool IsReady { get; }
        Exception Failure { get; }
        IBundleServices BundleServices { get; }
        IEnumerator Initialize(string applicationName);
        UnityEngine.Object LoadAsset(string logicalBundle, string assetName, Type requestedType);
        void RecordInstance(string logicalBundle, string assetName, GameObject source, GameObject instance, bool active);
    }

    public static class LocalEditorResourceBridge
    {
        public static ILocalEditorResourcesProvider Provider { get; private set; }

        public static void Register(ILocalEditorResourcesProvider provider)
        {
            if (provider == null || provider.ProviderId != "LocalEditorResourcesProvider")
                throw new ArgumentException("An explicitly named LocalEditorResourcesProvider is required.");
            Provider = provider;
        }

        public static ILocalEditorResourcesProvider RequireReady()
        {
            if (Provider == null)
                throw new InvalidOperationException("LocalEditorResourcesProvider is not installed; the original SDK/download service is not invoked in Editor.");
            if (Provider.Failure != null)
                throw new InvalidOperationException("LocalEditorResourcesProvider has failed; a domain reload or explicit repair is required.", Provider.Failure);
            if (!Provider.IsReady)
                throw new InvalidOperationException("LocalEditorResourcesProvider has not completed actual manifest and typed resource loads.");
            return Provider;
        }

        public static IEnumerator Initialize(string applicationName)
        {
            if (Provider == null)
                throw new InvalidOperationException("LocalEditorResourcesProvider is not installed; no version completion is manufactured.");
            if (Provider.Failure != null)
                throw new InvalidOperationException("LocalEditorResourcesProvider initialization previously failed.", Provider.Failure);
            IEnumerator operation = Provider.Initialize(applicationName);
            while (operation.MoveNext()) yield return operation.Current;
            RequireReady();
        }

        public static ResourcesInfo CreateInfo(string logicalBundle)
        {
            RequireReady();
            return new LocalEditorResourcesInfo(logicalBundle);
        }

        public static IEnumerator Guard(IEnumerator operation, Action<Exception> onFailure)
        {
            var pending = new Stack<IEnumerator>();
            pending.Push(operation);
            while (pending.Count != 0)
            {
                object current = null;
                bool hasNext;
                try
                {
                    IEnumerator top = pending.Peek();
                    hasNext = top.MoveNext();
                    if (hasNext) current = top.Current;
                }
                catch (Exception exception) { onFailure?.Invoke(exception); throw; }
                if (!hasNext) { pending.Pop(); continue; }
                if (current is IEnumerator nested) { pending.Push(nested); continue; }
                yield return current;
            }
        }
    }

    public sealed class LocalEditorResourcesInfo : ResourcesInfo
    {
        public LocalEditorResourcesInfo(string logicalBundle)
        {
            if (string.IsNullOrEmpty(logicalBundle)) throw new ArgumentException("A real original bundle key is required.");
            bundleName = logicalBundle;
        }

        public T LoadTyped<T>(string assetName) where T : UnityEngine.Object
        {
            var asset = LocalEditorResourceBridge.RequireReady().LoadAsset(bundleName, assetName, typeof(T));
            if (!(asset is T typed))
                throw new InvalidOperationException("LocalEditorResourcesProvider returned no actual " + typeof(T).FullName + " for " + bundleName + ":" + assetName);
            return typed;
        }

        public override UnityEngine.Object mainObjectInner
        {
            get { return LocalEditorResourceBridge.RequireReady().LoadAsset(bundleName, null, typeof(GameObject)); }
        }

        public override GameObject Instantiate(string assetName, bool active)
        {
            GameObject source = LoadTyped<GameObject>(assetName);
            Utils.ResetShader(source);
            GameObject instance = UnityEngine.Object.Instantiate(source);
            if (instance == null) throw new InvalidOperationException("The real legacy prefab failed to instantiate: " + bundleName + ":" + assetName);
            instance.SetActive(active);
            instance.name = source.name;
            LocalEditorResourceBridge.RequireReady().RecordInstance(bundleName, assetName, source, instance, active);
            return instance;
        }

        public override GameObject Instantiate(bool active) { return Instantiate(null, active); }
        public override GameObject Instantiate() { return Instantiate(null, true); }
    }

    public sealed class LocalEditorResLoader : ResLoader
    {
        private bool _completed;
        private Exception _failure;
        public override bool isComplete { get { return _completed; } }
        public Exception Failure { get { return _failure; } }

        internal LocalEditorResLoader(ResourcesModule owner, string originalKey, ResourcesModule.LoadAssetCompleteHandler callback, object[] args)
        {
            _0093U_00A6k_00ABk = owner;
            j_0081xY_0088_0088 = originalKey;
            _00AE_00BB_005DXLP = callback;
            h_00A6_00BB_00B2_0089w = args;
        }

        internal void CompleteActualLoad()
        {
            if (_completed) return;
            if (_failure != null) throw new InvalidOperationException("This Editor resource request already failed.", _failure);
            try
            {
                _0088_00AB_0084E_0082F = LocalEditorResourceBridge.CreateInfo(j_0081xY_0088_0088);
                // Prefab requests must yield a real object before their callback.
                if (j_0081xY_0088_0088.EndsWith(".prefab.unity3d", StringComparison.Ordinal))
                    ((LocalEditorResourcesInfo)_0088_00AB_0084E_0082F).LoadTyped<GameObject>(null);
                _completed = true;
                _00AE_00BB_005DXLP?.Invoke(_0088_00AB_0084E_0082F);
            }
            catch (Exception exception) { _failure = exception; throw; }
        }
    }
}
#endif
