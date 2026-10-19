using System;using System.Collections;using System.Collections.Generic;using GameFramework.Resources;using UnityEngine;namespace GameFramework.Recovery{    public interface ILocalEditorResourcesProvider
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
            ILocalEditorResourcesProvider provider = Provider;
            if (provider == null)
                throw new InvalidOperationException("LocalEditorResourcesProvider is not installed; no version completion is manufactured.");
            if (provider.Failure != null)
                throw new InvalidOperationException("LocalEditorResourcesProvider initialization previously failed.", provider.Failure);
            IEnumerator operation = provider.Initialize(applicationName);
            Exception primaryFailure = null;
            try
            {
                while (true)
                {
                    bool next; object current = null;
                    try { next = operation.MoveNext(); if (next) current = operation.Current; }
                    catch (Exception exception) { primaryFailure = exception; throw; }
                    if (!next) break;
                    yield return current;
                }
                try
                {
                    if (!ReferenceEquals(Provider, provider)) throw new InvalidOperationException("The resource provider changed during an active initialization lease.");
                    RequireReady();
                }
                catch (Exception exception) { primaryFailure = exception; throw; }
            }
            finally { DisposeEnumerator(operation, primaryFailure); }
        }

        public static ResourcesInfo CreateInfo(string logicalBundle)
        {
            RequireReady();
            return new LocalEditorResourcesInfo(logicalBundle);
        }

        public static IEnumerator Guard(IEnumerator operation, Action<Exception> onFailure)
        {
            if (operation == null) throw new ArgumentNullException(nameof(operation));
            var pending = new Stack<IEnumerator>();
            pending.Push(operation);
            Exception primaryFailure = null;
            try
            {
                while (pending.Count != 0)
                {
                    object current = null;
                    bool hasNext;
                    try
                    {
                        IEnumerator top = pending.Peek();
                        hasNext = top.MoveNext();
                        if (hasNext) current = top.Current;
                        else { pending.Pop(); DisposeEnumerator(top, null); }
                    }
                    catch (Exception exception) { primaryFailure = exception; onFailure?.Invoke(exception); throw; }
                    if (!hasNext) continue;
                    if (current is IEnumerator nested) { pending.Push(nested); continue; }
                    yield return current;
                }
            }
            finally
            {
                Exception disposalFailure = null;
                while (pending.Count != 0)
                {
                    try { DisposeEnumerator(pending.Pop(), primaryFailure ?? disposalFailure); }
                    catch (Exception exception) { disposalFailure = exception; }
                }
                if (primaryFailure == null && disposalFailure != null) { onFailure?.Invoke(disposalFailure); throw disposalFailure; }
            }
        }

        private static void DisposeEnumerator(IEnumerator operation, Exception primaryFailure)
        {
            try { (operation as IDisposable)?.Dispose(); }
            catch (Exception exception)
            {
                if (primaryFailure == null) throw;
                string key = "NestedEnumeratorDisposeFailure";
                int index = 0;
                while (primaryFailure.Data.Contains(key)) key = "NestedEnumeratorDisposeFailure" + (++index);
                primaryFailure.Data[key] = exception;
            }
        }
    }
public sealed class LocalEditorResourcesInfo:ResourcesInfo{public LocalEditorResourcesInfo(string value){}}}