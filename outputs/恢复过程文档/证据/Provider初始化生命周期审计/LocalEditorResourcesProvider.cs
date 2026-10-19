using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GameFramework.Recovery;
using GameFramework.Resources;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace OccupyCity.Recovery.LocalResources.Editor
{
    [InitializeOnLoad]
    public sealed class LocalEditorResourcesProvider : ILocalEditorResourcesProvider
    {
        private const string RegistryPath = "Assets/RecoveredLegacy/LocalEditorResourceRegistry.json";
        private const string SettingsPath = "Assets/RecoveryTools/GeneratedAddressables/RecoveryAddressableAssetSettings.asset";
        private Registry _registry;
        private Receipt _receipt;
        private PatchManifest _manifest;
        private string _workspace, _project, _receiptPath, _apkPath;
        private readonly Dictionary<string, UnityEngine.Object> _loaded = new Dictionary<string, UnityEngine.Object>(StringComparer.Ordinal);
        private readonly Dictionary<string, byte[]> _payloads = new Dictionary<string, byte[]>(StringComparer.Ordinal);
        private bool _initializing;
        public string ProviderId { get { return "LocalEditorResourcesProvider"; } }
        public bool IsReady { get; private set; }
        public Exception Failure { get; private set; }
        public IBundleServices BundleServices { get; private set; }

        static LocalEditorResourcesProvider() { LocalEditorResourceBridge.Register(new LocalEditorResourcesProvider()); }

        [Serializable] public sealed class Registry
        {
            public int schemaVersion, manifestBytes;
            public string providerId, applicationName, apkRelativePath, apkSha256, manifestAssetPath, manifestSha256;
            public ResourceRow[] textAssets, prefabs;
        }
        [Serializable] public sealed class ResourceRow
        {
            public string logicalBundle, sourceStoredBundle, sourceContainer, sourceFile, sourcePathId, sourceType, sourceName;
            public string assetName, assetPath, guid, sha256, requestedType;
            public int bytes;
            public bool directConfigConsumer;
        }
        [Serializable] public sealed class Receipt
        {
            public string providerId, runId, startedUtc, finishedUtc, status, failure, applicationName, receiptPath;
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
        [Serializable] public sealed class Plan { public Entry[] entries; public Pending[] pending; }
        [Serializable] public sealed class Entry { public string address, requestedType, requestedAssembly, assetPath, guid; }
        [Serializable] public sealed class Pending { public string address, requestedType, reason; }
        [Serializable] public sealed class BuildReport
        {
            public bool buildPerformed, complete;
            public int inputRows, validatedRows, locatorChecks, inputPendingRows;
            public string settingsPath, fatalError;
            public Issue[] validationFailures, locatorFailures;
        }
        [Serializable] public sealed class Issue { public string message; }

        public IEnumerator Initialize(string applicationName)
        {
            if (Failure != null) throw new InvalidOperationException("This Editor provider has a sticky failure; repair and reload the domain before retrying.", Failure);
            if (IsReady)
            {
                if (applicationName != _registry.applicationName) throw new InvalidOperationException("A different application requested the initialized provider.");
                yield break;
            }
            if (_initializing) throw new InvalidOperationException("LocalEditorResourcesProvider initialization is already in progress.");
            _initializing = true;
            IEnumerator operation = InitializeCore(applicationName);
            while (true)
            {
                bool next; object current = null;
                try { next = operation.MoveNext(); if (next) current = operation.Current; }
                catch (Exception exception)
                {
                    Failure = exception; IsReady = false; _initializing = false;
                    if (_receipt != null) { _receipt.status = "failed_actual_resource_validation"; _receipt.failure = exception.ToString(); _receipt.ready = false; Save(); }
                    throw;
                }
                if (!next) break;
                yield return current;
            }
            _initializing = false;
        }

        private IEnumerator InitializeCore(string applicationName)
        {
            _project = Directory.GetParent(Application.dataPath).FullName;
            _workspace = Directory.GetParent(_project).Parent.FullName;
            _receiptPath = Path.Combine(_project, "RecoveryReports", "local-editor-resources-receipt.json");
            Directory.CreateDirectory(Path.GetDirectoryName(_receiptPath));
            _receipt = new Receipt
            {
                providerId = ProviderId, runId = DateTime.UtcNow.ToString("yyyyMMdd-HHmmss-fff") + "-" + Guid.NewGuid().ToString("N").Substring(0, 8),
                startedUtc = DateTime.UtcNow.ToString("o"), status = "checking_actual_local_resources", applicationName = applicationName, receiptPath = _receiptPath,
                originalSdkCalled = false, nativeAndroidAssetBundleRuntimeSelected = false, coreGameplayAccepted = false,
                capabilities = new[] { "Original APK manifest and verified local payload bytes", "Exact imported legacy TextAsset registry", "Actual original-mapped UIRoot GameObject", "Official Addressables Editor settings locator and typed AssetDatabase loads" },
                limitations = new[] { "Explicit Editor platform provider; no original SDK, remote update, delivery or download service", "Native Android AssetBundle runtime is not selected", "Pending address/type identities are not silently resolved", "No login/save/AB/user state or core gameplay acceptance", "AssetDatabase loads own no Addressables operation handle; no fictitious handle release is recorded" }
            };
            Save();
            TextAsset registryAsset = AssetDatabase.LoadAssetAtPath<TextAsset>(RegistryPath);
            if (registryAsset == null) throw new InvalidDataException("The original-identity Editor resource registry did not import as a TextAsset.");
            _receipt.registrySha256 = Sha(registryAsset.bytes);
            _registry = JsonUtility.FromJson<Registry>(registryAsset.text);
            if (_registry == null || _registry.providerId != ProviderId || _registry.schemaVersion != 1 || _registry.textAssets == null || _registry.textAssets.Length != 50 || _registry.prefabs == null || _registry.prefabs.Length != 1)
                throw new InvalidDataException("Expected the exact original-50 TextAsset registry and one proven UIRoot prefab.");
            if (applicationName != _registry.applicationName) throw new InvalidDataException("Original application name does not match the selected recovered APK registry: " + applicationName);
            _apkPath = Path.GetFullPath(Path.Combine(_workspace, _registry.apkRelativePath));
            _receipt.apkPath = _apkPath;
            Task<string> hashing = Task.Run(() => ShaFile(_apkPath));
            while (!hashing.IsCompleted) yield return null;
            _receipt.apkSha256 = hashing.GetAwaiter().GetResult();
            if (_receipt.apkSha256 != _registry.apkSha256) throw new InvalidDataException("The actual APK differs from the reviewed original input.");

            TextAsset manifestAsset = AssetDatabase.LoadAssetAtPath<TextAsset>(_registry.manifestAssetPath);
            if (manifestAsset == null || manifestAsset.bytes.Length != _registry.manifestBytes || Sha(manifestAsset.bytes) != _registry.manifestSha256)
                throw new InvalidDataException("The actual Unity ABFiles TextAsset does not equal the original decoded manifest.");
            _receipt.manifestSha256 = Sha(manifestAsset.bytes);
            _manifest = new PatchManifest(manifestAsset.text);
            if (_manifest.DicPatchInfo == null || _manifest.DicPatchInfo.Count != 34) throw new InvalidDataException("The actual original PatchManifest parser did not produce 34 records.");
            _receipt.originalManifestParsed = true; _receipt.manifestRecords = _manifest.DicPatchInfo.Count;
            RecordLoad("ABFiles.txt", "ABFiles", typeof(TextAsset), manifestAsset, _registry.manifestAssetPath, true, _receipt.manifestSha256, manifestAsset.bytes.Length);
            using (ZipArchive archive = ZipFile.OpenRead(_apkPath))
            {
                ZipArchiveEntry ciphertext = archive.GetEntry("assets/Android/ljzs_lt/ABFiles.txt");
                if (ciphertext == null || Sha(ReadEntry(ciphertext)) != "29e3c08db48df15428a32f87509b6e58fee0a82b4ceca8f85eccd45564d8f35a")
                    throw new InvalidDataException("Original encrypted ABFiles input identity did not match.");
                foreach (PatchElement element in _manifest.DicPatchInfo.Values)
                {
                    string member = "assets/Android/" + applicationName + "/" + element.ObfuscatorName;
                    ZipArchiveEntry entry = archive.GetEntry(member);
                    if (entry == null) throw new FileNotFoundException("An original manifest payload is absent from the actual APK.", member);
                    byte[] bytes = ReadEntry(entry);
                    string md5 = Md5(bytes);
                    if ((ulong)bytes.LongLength != element.Size || !string.Equals(md5, element.MD5, StringComparison.OrdinalIgnoreCase))
                        throw new InvalidDataException("Actual manifest payload length/MD5 failed: " + element.EName);
                    _payloads.Add(element.EName, bytes);
                    _receipt.payloads.Add(new PayloadRecord { logicalKey = element.EName, archiveMember = member, declaredMd5 = element.MD5, actualMd5 = md5, declaredBytes = checked((long)element.Size), actualBytes = bytes.LongLength });
                    ++_receipt.checkedPayloads;
                }
            }
            Save(); yield return null;

            foreach (ResourceRow row in _registry.textAssets)
            {
                RequireSourceRow(row);
                TextAsset asset = AssetDatabase.LoadAssetAtPath<TextAsset>(row.assetPath);
                if (asset == null || asset.name != row.assetName || asset.bytes.Length != row.bytes || Sha(asset.bytes) != row.sha256)
                    throw new InvalidDataException("Actual imported legacy TextAsset bytes/type/name failed: " + row.assetPath);
                _loaded.Add(ResourceKey(row.logicalBundle, row.assetName), asset);
                RecordLoad(row.logicalBundle, row.assetName, typeof(TextAsset), asset, row.assetPath, true, row.sha256, asset.bytes.Length);
                ++_receipt.loadedLegacyTextAssets;
                if (row.directConfigConsumer) ++_receipt.directConfigConsumers;
                yield return null;
            }
            if (_receipt.directConfigConsumers != 41) throw new InvalidDataException("The original direct ConfigMgr consumer registry does not contain 41 entries.");
            foreach (ResourceRow row in _registry.prefabs)
            {
                RequireSourceRow(row);
                if (ShaFile(Path.Combine(_project, row.assetPath)) != row.sha256) throw new InvalidDataException("The reviewed original-mapped prefab changed: " + row.assetPath);
                GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(row.assetPath);
                if (prefab == null || prefab.name != row.assetName || prefab.GetComponent<RectTransform>() == null)
                    throw new InvalidDataException("The actual original UIRoot prefab did not load as a GameObject with RectTransform.");
                int missing = prefab.GetComponentsInChildren<Transform>(true).Sum(transform => GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(transform.gameObject));
                if (missing != 0) throw new InvalidDataException("The required original UIRoot closure contains missing scripts: " + missing);
                _loaded.Add(ResourceKey(row.logicalBundle, row.assetName), prefab);
                RecordLoad(row.logicalBundle, row.assetName, typeof(GameObject), prefab, row.assetPath, true, row.sha256, 0);
            }

            string planPath = Path.Combine(_workspace, "work", "startup-restore", "addressable-recovery-plan.json");
            byte[] planRaw = File.ReadAllBytes(planPath); _receipt.planSha256 = Sha(planRaw);
            Plan plan = JsonUtility.FromJson<Plan>(Encoding.UTF8.GetString(planRaw));
            if (plan == null || plan.entries == null || plan.pending == null || plan.entries.Length != 5142 || plan.pending.Length != 60)
                throw new InvalidDataException("The actual reviewed Addressables plan changed; revalidate its current closure.");
            _receipt.pendingMappings = plan.pending.Length;
            string reportPath = Path.Combine(_project, "RecoveryReports", "addressables-build-report.json");
            byte[] reportRaw = File.ReadAllBytes(reportPath); _receipt.officialBuildReportSha256 = Sha(reportRaw);
            BuildReport build = JsonUtility.FromJson<BuildReport>(Encoding.UTF8.GetString(reportRaw));
            if (!build.buildPerformed || build.inputRows != plan.entries.Length || build.validatedRows != plan.entries.Length || build.locatorChecks != plan.entries.Length || build.inputPendingRows != plan.pending.Length || build.settingsPath != SettingsPath || !string.IsNullOrEmpty(build.fatalError) || build.validationFailures == null || build.locatorFailures == null || build.validationFailures.Length != 0 || build.locatorFailures.Length != 0)
                throw new InvalidDataException("The actual official Addressables build has not validated this resource plan.");
            AddressableAssetSettings settings = AddressableAssetSettingsDefaultObject.Settings;
            if (settings == null || AssetDatabase.GetAssetPath(settings) != SettingsPath) throw new InvalidDataException("The actual official recovered Addressables settings are not the active default.");
            _receipt.settingsSha256 = ShaFile(Path.Combine(_project, SettingsPath));
            Type locatorType = typeof(AddressableAssetSettings).Assembly.GetType("UnityEditor.AddressableAssets.Settings.AddressableAssetSettingsLocator", true);
            var locator = (IResourceLocator)Activator.CreateInstance(locatorType, new object[] { settings });
            foreach (Entry entry in plan.entries)
            {
                Type requested = ResolveType(entry.requestedType, entry.requestedAssembly);
                if (!locator.Locate(entry.address, requested, out IList<IResourceLocation> locations)) throw new InvalidDataException("Official live locator has no location: " + entry.address);
                var unique = locations.GroupBy(location => location.InternalId + "\n" + location.ResourceType.FullName).Select(group => group.First()).ToArray();
                if (unique.Length != 1 || unique[0].InternalId != entry.assetPath || AssetDatabase.AssetPathToGUID(entry.assetPath) != entry.guid)
                    throw new InvalidDataException("Official live locator identity is ambiguous or changed: " + entry.address + " / " + requested.FullName);
                ++_receipt.officialLocatorChecks;
                if (_receipt.officialLocatorChecks % 100 == 0) yield return null;
            }
            // This is an actual Unity typed load, distinct from locator/hash checks.
            const string requiredAddress = "Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalMainCityMapInfo.json";
            if (plan.pending.Any(row => row.address == requiredAddress && row.requestedType == typeof(TextAsset).FullName))
                throw new InvalidDataException("A required bootstrap typed address is still pending.");
            Entry required = plan.entries.Single(row => row.address == requiredAddress && row.requestedType == typeof(TextAsset).FullName);
            TextAsset requiredAsset = AssetDatabase.LoadAssetAtPath<TextAsset>(required.assetPath);
            if (requiredAsset == null) throw new InvalidDataException("The official mapped bootstrap TextAsset cannot actually load.");
            RecordLoad(requiredAddress, requiredAsset.name, typeof(TextAsset), requiredAsset, required.assetPath, false, Sha(requiredAsset.bytes), requiredAsset.bytes.Length);

            BundleServices = new OriginalManifestEditorServices(this, _manifest, _payloads, _apkPath, applicationName);
            BundleAssetInfo firstPack = BundleServices.GetAssetBundleInfo("firstpack.unity3d");
            _receipt.firstPackLookup = "firstpack.unity3d"; _receipt.firstPackName = firstPack.BundleName; _receipt.firstPackLocalPath = firstPack.LocalPath;
            if (firstPack.BundleName != "firstpack.unity3d") throw new InvalidDataException("The real missing-firstpack result lost its original requested Name.");
            _receipt.actualTypedLoadsCompleted = true;
            _receipt.ready = true; _receipt.status = "ready_actual_local_manifest_and_typed_loads"; _receipt.finishedUtc = DateTime.UtcNow.ToString("o");
            Save();
            IsReady = true;
            Debug.Log("LocalEditorResourcesProvider ready: actual manifest34/payload34, legacy TextAsset50, original UIRoot GameObject, official locator5142; pending60 remains incomplete | " + _receiptPath);
        }

        public UnityEngine.Object LoadAsset(string logicalBundle, string assetName, Type requestedType)
        {
            if (!IsReady || Failure != null) throw new InvalidOperationException("The actual local resource bootstrap has not succeeded.", Failure);
            try
            {
                ResourceRow[] rows = requestedType == typeof(GameObject) ? _registry.prefabs : _registry.textAssets;
                ResourceRow[] matching = rows.Where(row => row.logicalBundle == logicalBundle && (string.IsNullOrEmpty(assetName) || row.assetName == assetName)).ToArray();
                if (matching.Length != 1) throw new InvalidDataException("No unique original typed resource mapping: " + logicalBundle + ":" + assetName + " / " + requestedType.FullName);
                ResourceRow source = matching[0];
                UnityEngine.Object asset = AssetDatabase.LoadAssetAtPath(source.assetPath, requestedType);
                if (asset == null || !requestedType.IsInstanceOfType(asset)) throw new InvalidDataException("The actual typed Unity load failed: " + source.assetPath);
                if (asset is TextAsset text && (text.bytes.Length != source.bytes || Sha(text.bytes) != source.sha256)) throw new InvalidDataException("The actual legacy TextAsset changed since bootstrap: " + source.assetPath);
                RecordLoad(logicalBundle, source.assetName, requestedType, asset, source.assetPath, true, source.sha256, asset is TextAsset payload ? payload.bytes.Length : 0);
                Save(); return asset;
            }
            catch (Exception exception) { _receipt.operationFailures.Add(exception.ToString()); Save(); throw; }
        }

        public void RecordInstance(string logicalBundle, string assetName, GameObject source, GameObject instance, bool active)
        {
            if (!IsReady || source == null || instance == null) throw new InvalidOperationException("No actual prefab instance is available to record.");
            _receipt.instances.Add(new InstanceRecord { key = logicalBundle, assetName = assetName, sourceType = source.GetType().AssemblyQualifiedName, sourceName = source.name, sourceInstanceId = source.GetInstanceID(), createdInstanceId = instance.GetInstanceID(), active = active });
            Save();
        }

        private void RequireSourceRow(ResourceRow row)
        {
            if (row == null || string.IsNullOrEmpty(row.sourcePathId) || string.IsNullOrEmpty(row.sourceContainer) || string.IsNullOrEmpty(row.sourceStoredBundle) || AssetDatabase.AssetPathToGUID(row.assetPath) != row.guid)
                throw new InvalidDataException("A resource row lacks its actual original identity or matching imported GUID.");
            if (!_manifest.DicPatchInfo.TryGetValue(row.logicalBundle, out PatchElement element) || element.ObfuscatorName != row.sourceStoredBundle)
                throw new InvalidDataException("A resource registry row does not belong to the actual original manifest.");
        }
        private void RecordLoad(string key, string name, Type requested, UnityEngine.Object asset, string path, bool matches, string hash, int bytes)
        {
            if (asset == null) throw new InvalidDataException("A null object cannot be recorded as an actual load.");
            if (!AssetDatabase.TryGetGUIDAndLocalFileIdentifier(asset, out string guid, out long id)) throw new InvalidDataException("The actual imported Unity object has no GUID/local file identity: " + path);
            _receipt.loads.Add(new LoadRecord { logicalKey = key, assetName = name, requestedType = requested.AssemblyQualifiedName, actualType = asset.GetType().AssemblyQualifiedName, actualName = asset.name, assetPath = path, guid = guid, localFileId = id.ToString(), instanceId = asset.GetInstanceID(), actualLoadSucceeded = true, sourceBytesMatch = matches, sha256 = hash, bytes = bytes, api = "UnityEditor.AssetDatabase.LoadAssetAtPath", releaseRequired = false, releasePolicy = "No Addressables operation handle acquired; imported Editor asset remains owned by AssetDatabase" });
        }
        private static Type ResolveType(string name, string assembly)
        {
            Type type = Type.GetType(name + ", " + assembly, false);
            if (type != null) return type;
            Type[] matches = AppDomain.CurrentDomain.GetAssemblies().Select(value => value.GetType(name, false)).Where(value => value != null).Distinct().ToArray();
            if (matches.Length != 1) throw new TypeLoadException("The actual requested Unity type is missing or ambiguous: " + name);
            return matches[0];
        }
        private void Save()
        {
            if (_receipt == null || string.IsNullOrEmpty(_receiptPath)) return;
            string temporary = _receiptPath + ".tmp";
            File.WriteAllText(temporary, JsonUtility.ToJson(_receipt, true), new UTF8Encoding(false));
            File.Copy(temporary, _receiptPath, true); File.Delete(temporary);
        }
        private static string ResourceKey(string bundle, string asset) { return bundle + "\n" + asset; }
        private static byte[] ReadEntry(ZipArchiveEntry entry) { using (Stream input = entry.Open()) using (var output = new MemoryStream()) { input.CopyTo(output); return output.ToArray(); } }
        private static string Sha(byte[] data) { using (SHA256 hash = SHA256.Create()) return BitConverter.ToString(hash.ComputeHash(data)).Replace("-", "").ToLowerInvariant(); }
        private static string Md5(byte[] data) { using (MD5 hash = MD5.Create()) return BitConverter.ToString(hash.ComputeHash(data)).Replace("-", "").ToLowerInvariant(); }
        private static string ShaFile(string path) { using (Stream stream = File.OpenRead(path)) using (SHA256 hash = SHA256.Create()) return BitConverter.ToString(hash.ComputeHash(stream)).Replace("-", "").ToLowerInvariant(); }

        private sealed class OriginalManifestEditorServices : IBundleServices
        {
            private readonly LocalEditorResourcesProvider _owner;
            private readonly PatchManifest _manifest;
            private readonly Dictionary<string, byte[]> _payloads;
            private readonly string _apk, _app;
            public OriginalManifestEditorServices(LocalEditorResourcesProvider owner, PatchManifest manifest, Dictionary<string, byte[]> payloads, string apk, string app) { _owner = owner; _manifest = manifest; _payloads = payloads; _apk = apk; _app = app; }
            public bool CheckContentIntegrity(string key)
            {
                return _manifest.TryGetValue(key, out PatchElement element) && _payloads.TryGetValue(key, out byte[] bytes) && (ulong)bytes.LongLength == element.Size && string.Equals(Md5(bytes), element.MD5, StringComparison.OrdinalIgnoreCase);
            }
            public bool CheckHaveLocalAsset(string key) { return _manifest.TryGetValue(key, out PatchElement ignored) && _payloads.ContainsKey(key); }
            public BundleAssetInfo GetAssetBundleInfo(string key)
            {
                bool found = _manifest.TryGetValue(key, out PatchElement element);
                BundleAssetInfo value = found
                    ? new BundleAssetInfo(key, _apk + "!/assets/Android/" + _app + "/" + element.ObfuscatorName, string.Empty, element.Version, _manifest.IsEncrypAB, element.ObfuscatorName, _manifest.RandomSeed, true)
                    : new BundleAssetInfo(key, string.Empty);
                _owner._receipt.lookups.Add(new LookupRecord { key = key, foundInOriginalManifest = found, returnedName = value.BundleName, returnedLocalPath = value.LocalPath });
                if (_owner.IsReady) _owner.Save();
                return value;
            }
            public RawAssetInfo GetRawAssetInfo(string key) { throw new NotSupportedException("The Editor platform provider has not implemented original raw-asset I/O for " + key + "; no default success is returned."); }
        }
    }
}
