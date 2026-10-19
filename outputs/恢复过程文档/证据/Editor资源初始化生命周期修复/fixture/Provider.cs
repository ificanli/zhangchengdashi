using System;using System.Collections;using System.Collections.Generic;using System.IO;using System.Text;using GameFramework.Recovery;using GameFramework.Resources;using UnityEditor;using UnityEngine;
namespace OccupyCity.Recovery.LocalResources.Editor { public sealed class LocalEditorResourcesProvider:ILocalEditorResourcesProvider {
private bool _initializing;private string _receiptPath;private Receipt _receipt;private Registry _registry;private sealed class Registry{public string applicationName;}
public string ProviderId=>"LocalEditorResourcesProvider";public bool IsReady{get;private set;}public Exception Failure{get;private set;}public IBundleServices BundleServices{get;private set;}
public string ReceiptPath=>_sessionReceiptPath;public int CoreDisposals{get;private set;}public int CoreEntries{get;private set;}
public UnityEngine.Object LoadAsset(string b,string n,Type t)=>throw new NotSupportedException();public void RecordInstance(string b,string n,GameObject s,GameObject i,bool a)=>throw new NotSupportedException();
        [Serializable] public sealed class Receipt
        {
            public string providerId, runId, startedUtc, finishedUtc, status, failure, applicationName, receiptPath;
            public long initializationLeaseId;
            public string initializationSessionKind, sessionReceiptPath, cancellationReason;
            public string apkPath, apkSha256, manifestSha256, registrySha256, planSha256, settingsSha256, officialBuildReportSha256;
            public bool ready, originalManifestParsed, actualTypedLoadsCompleted, originalSdkCalled, nativeAndroidAssetBundleRuntimeSelected;
            public bool coreGameplayAccepted;
            public int manifestRecords, checkedPayloads, loadedLegacyTextAssets, directConfigConsumers, officialLocatorChecks, pendingMappings;
            public string firstPackLookup, firstPackName, firstPackLocalPath;
            public string[] capabilities, limitations;
            public List<PayloadRecord> payloads = new List<PayloadRecord>();
            public List<LoadRecord> loads = new List<LoadRecord>();
            public List<LookupRecord> lookups = new List<LookupRecord>();
            public List<InstanceRecord> instances = new List<InstanceRecord>();
            public List<string> operationFailures = new List<string>();
        }
        [Serializable] public sealed class PayloadRecord
        {
            public string logicalKey, archiveMember, declaredMd5, actualMd5;
            public long declaredBytes, actualBytes;
        }
        [Serializable] public sealed class LoadRecord
        {
            public string logicalKey, assetName, requestedType, actualType, actualName, assetPath, guid, localFileId, sha256, api, releasePolicy;
            public int instanceId, bytes;
            public bool actualLoadSucceeded, sourceBytesMatch, releaseRequired;
        }
        [Serializable] public sealed class LookupRecord { public string key, returnedName, returnedLocalPath; public bool foundInOriginalManifest; }
        [Serializable] public sealed class InstanceRecord { public string key, assetName, sourceType, sourceName; public int sourceInstanceId, createdInstanceId; public bool active; }
        private sealed class InitializationLease
        {
            internal long Id;
            internal bool StartedInPlayMode, Finished, Completed, CoreDisposed;
            internal string CancellationReason;
            internal IEnumerator Operation;
            internal Exception TerminalFailure;
        }
        private long _nextInitializationLeaseId;
        private InitializationLease _initializationLease;
        private string _sessionReceiptPath;
        private bool _publishedCanonicalReceipt;
        internal bool IsInitializing { get { return _initializing; } }
        internal long ActiveInitializationLeaseId { get { return _initializationLease == null ? 0 : _initializationLease.Id; } }
        internal bool InitializationStartedInPlayMode { get { return _initializationLease != null && _initializationLease.StartedInPlayMode; } }
        internal string CurrentRunId { get { return _receipt == null ? string.Empty : _receipt.runId; } }

        public IEnumerator Initialize(string applicationName)
        {
            if (Failure != null) throw new InvalidOperationException("This Editor provider has a sticky failure or cancelled session; a new explicit Editor session/domain reload is required.", Failure);
            if (IsReady)
            {
                if (applicationName != _registry.applicationName) throw new InvalidOperationException("A different application requested the initialized provider.");
                yield break;
            }
            if (_initializing) throw new InvalidOperationException("LocalEditorResourcesProvider initialization is already in progress.");
            var lease = new InitializationLease { Id = checked(++_nextInitializationLeaseId), StartedInPlayMode = EditorApplication.isPlaying };
            _initializationLease = lease;
            _initializing = true;
            try
            {
                lease.Operation = InitializeCore(applicationName);
                while (true)
                {
                    bool next; object current = null;
                    try
                    {
                        if (lease.Finished) throw lease.TerminalFailure ?? new InvalidOperationException("This initialization lease already ended.");
                        next = lease.Operation.MoveNext();
                        if (next) current = lease.Operation.Current;
                        else if (!IsReady || BundleServices == null)
                            throw new InvalidOperationException("Actual resource initialization ended without ready services and a saved receipt.");
                    }
                    catch (Exception exception)
                    {
                        FinishInitializationLease(lease, exception, exception is OperationCanceledException ? "cancelled_editor_session" : "failed_actual_resource_validation");
                        throw;
                    }
                    if (!next) { lease.Completed = true; break; }
                    yield return current;
                }
            }
            finally
            {
                if (!lease.Finished && !lease.Completed)
                    FinishInitializationLease(lease, new OperationCanceledException("The owner disposed initialization before actual resource completion."), "cancelled_editor_session");
                try { DisposeInitializationCore(lease); }
                finally
                {
                    if (!lease.Finished) FinishInitializationLease(lease, null, null);
                }
            }
        }

        internal bool CancelInitialization(long leaseId, string reason)
        {
            InitializationLease lease = _initializationLease;
            if (lease == null || lease.Finished || lease.Id != leaseId) return false;
            lease.CancellationReason = string.IsNullOrEmpty(reason) ? "Editor session ended before resource initialization completed." : reason;
            FinishInitializationLease(lease, new OperationCanceledException(lease.CancellationReason), "cancelled_editor_session");
            DisposeInitializationCore(lease);
            return true;
        }

        private void FinishInitializationLease(InitializationLease lease, Exception exception, string failureStatus)
        {
            if (lease.Finished) return;
            lease.Finished = true;
            lease.TerminalFailure = exception;
            if (ReferenceEquals(_initializationLease, lease)) { _initializationLease = null; _initializing = false; }
            if (exception == null) return; // InitializeCore already saved actual success before IsReady=true.
            Failure = exception;
            IsReady = false;
            BundleServices = null;
            if (_receipt != null)
            {
                _receipt.status = failureStatus;
                _receipt.failure = exception.ToString();
                _receipt.cancellationReason = exception is OperationCanceledException ? (lease.CancellationReason ?? exception.Message) : string.Empty;
                _receipt.ready = false;
                _receipt.finishedUtc = DateTime.UtcNow.ToString("o");
                SaveFailureReceipt(exception);
            }
        }

        private void DisposeInitializationCore(InitializationLease lease)
        {
            if (lease.CoreDisposed) return;
            lease.CoreDisposed = true;
            try { (lease.Operation as IDisposable)?.Dispose(); }
            catch (Exception exception)
            {
                if (lease.TerminalFailure == null)
                {
                    FinishInitializationLease(lease, exception, "failed_initialization_disposal");
                    throw;
                }
                lease.TerminalFailure.Data["InitializationDisposeFailure"] = exception;
                if (_receipt != null) { _receipt.operationFailures.Add(exception.ToString()); SaveFailureReceipt(lease.TerminalFailure); }
            }
        }

        private void SaveFailureReceipt(Exception originalFailure)
        {
            try { Save(); }
            catch (Exception saveFailure)
            {
                originalFailure.Data["ReceiptPersistenceFailure"] = saveFailure;
                Debug.LogError("The resource initialization failed and its terminal receipt could not be saved: " + saveFailure);
            }
        }


        private void Save()
        {
            if (_receipt == null || string.IsNullOrEmpty(_receiptPath)) return;
            string json = JsonUtility.ToJson(_receipt, true);
            if (!string.IsNullOrEmpty(_sessionReceiptPath)) WriteReceiptFile(_sessionReceiptPath, json);
            bool ownsCurrentReceipt = !_publishedCanonicalReceipt || !File.Exists(_receiptPath);
            if (!ownsCurrentReceipt)
            {
                Receipt current = JsonUtility.FromJson<Receipt>(File.ReadAllText(_receiptPath));
                ownsCurrentReceipt = current != null && current.runId == _receipt.runId;
            }
            if (ownsCurrentReceipt) WriteReceiptFile(_receiptPath, json);
            _publishedCanonicalReceipt = true;
        }
        private static void WriteReceiptFile(string path, string json)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            string temporary = path + ".tmp";
            File.WriteAllText(temporary, json, new UTF8Encoding(false));
            File.Copy(temporary, path, true);
            File.Delete(temporary);
        }

// Dependency-only adapter for the unchanged actual resource I/O coroutine.
private IEnumerator InitializeCore(string applicationName){CoreEntries++;try{
_registry=new Registry{applicationName=applicationName};_receiptPath=Env.Canonical;string runId=Guid.NewGuid().ToString("N");_sessionReceiptPath=Path.Combine(Env.RunRoot,runId+".json");
_receipt=new Receipt{runId=runId,ready=false,status="checking_actual_local_resources",initializationLeaseId=_initializationLease.Id,initializationSessionKind=_initializationLease.StartedInPlayMode?"play_owner":"independent_editor_owner",sessionReceiptPath=_sessionReceiptPath};Save();
while(!Env.HashReady)yield return null;
_receipt.checkedPayloads=34;Save();yield return null;
_receipt.loadedLegacyTextAssets=10;Save();yield return null;
if(Env.ResourceFailure)throw new InvalidDataException("actual I/O failure marker");
_receipt.loadedLegacyTextAssets=50;_receipt.originalManifestParsed=true;_receipt.actualTypedLoadsCompleted=true;_receipt.ready=true;_receipt.status="ready_actual_local_manifest_and_typed_loads";BundleServices=new TestServices();Save();IsReady=true;
}finally{CoreDisposals++;if(Env.CoreDisposeThrows)throw new IOException("core disposal marker");}}
}}
