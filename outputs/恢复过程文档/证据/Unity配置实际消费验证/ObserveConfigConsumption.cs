using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace OccupyCity.Recovery.Editor
{
    // No reference to Assembly-CSharp or UniTask: every production invocation is
    // resolved from the currently loaded Unity assemblies, never from a fixture.
    public static class ObserveConfigConsumption
    {
        private const string AddressPrefix = "Assets/_Res/Addressable/01FirstBundle/JsonData/";
        private const BindingFlags Fields = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        private static RunRecord _run;
        private static object _globalInfo;
        private static object _awaiter;
        private static PropertyInfo _isCompleted;
        private static MethodInfo _getResult;
        private static Assembly _production;
        private static Type _globalType;
        private static List<CallbackMap> _validationQueue;
        private static Dictionary<string, PayloadReadback> _payloads;
        private static Dictionary<string, OriginalPayload> _originalPayloads;
        private static string _workspace, _reportPath;
        private static double _nextSample, _nextSave;
        private static int _validationIndex;
        private static bool _active, _exitBatch, _getResultInvoked;

        [Serializable] public sealed class RunRecord
        {
            public string runId, startedUtc, finishedUtc, status, unityVersion, reportPath;
            public bool batchMode, playMode, originalPreconditionsRequested, originalPreconditionsInvoked;
            public string preconditionMethod, preconditionNativeRva, cultureBefore, cultureAfter, prerequisiteError;
            public string productionAssembly, productionAssemblyLocation, productionAssemblyMvid, productionAssemblySha256;
            public string globalInfoType, invokedMethod, returnType, awaitableType, awaiterType, awaiterAssembly, actualUniTaskAssembly;
            public bool productionConstructorInvoked, productionInitInvoked, getResultInvoked, productionAwaitCompleted;
            public bool configurationConsumptionPassed, coreGameplayAccepted, abContextConfirmed, productionMayStillBeRunning;
            public string acceptanceScope, abContextNote, exception, snapshotError, mappingPath, mappingSha256, actualLitJsonAssembly;
            public string originalResourceAuditPath, originalResourceAuditSha256;
            public double startedEditorTime, elapsedSeconds, timeoutSeconds;
            public int originalStaticAddressCount = 81, originalSelectedRequestCount = 65, selectedPathCount, pendingPathCount;
            public int validationCount, validationPassed, validationFailed, droppedLogs;
            public bool selectedRequestCountMatchesNative, pendingListConverged, schemaMappingAvailable;
            public string[] selectedPaths, pendingPaths;
            public List<AbValue> abValues = new List<AbValue>();
            public List<CollectionReadback> collectionsBefore = new List<CollectionReadback>();
            public List<CollectionReadback> collectionsAfter = new List<CollectionReadback>();
            public List<Sample> samples = new List<Sample>();
            public List<LogRecord> logs = new List<LogRecord>();
            public List<TypedCheck> typedChecks = new List<TypedCheck>();
            public List<PayloadReadback> selectedResourceReadbacks = new List<PayloadReadback>();
        }
        [Serializable] public sealed class AbValue
        {
            public string property, value, declaringType, getterIlSha256, getterIlHex, error;
            public bool getterIlAvailable, possibleConstantDefaultStub;
        }
        [Serializable] public sealed class CollectionReadback
        {
            public string field, declaredType, runtimeType, elementType, keyType, error;
            public bool isNull;
            public int count = -1;
        }
        [Serializable] public sealed class Sample
        {
            public string phase;
            public double elapsedSeconds;
            public int selectedPaths, pendingPaths;
            public string[] pending;
        }
        [Serializable] public sealed class LogRecord
        {
            public string type, text, stack;
            public double elapsedSeconds;
        }
        [Serializable] public sealed class TypedCheck
        {
            public int callback;
            public string selectedAddress, expectedElementType, listField, dictionaryField, expectedKeyMember, error;
            public string actualListDeclaredType, actualElementRuntimeType, actualDictionaryDeclaredType, actualNestedMapListDeclaredType;
            public int expectedRows = -1, actualRows = -1, actualDictionaryRows = -1, wrongElementTypes, dictionaryValueMismatches, nestedMapTypeOrValueMismatches;
            public bool listTypeMatches, dictionaryTypeMatches, nestedMapListTypeMatches, passed;
        }
        [Serializable] public sealed class PayloadReadback
        {
            public string selectedAddress, resourcesKey, textAssetName, textAssetRuntimeType, rawSha256, decodedSha256;
            public string evidenceScope, error;
            public string originalRawSha256, originalDecodedSha256;
            public bool resourcesPresent, originalRawBytesMatch, originalDecodedBytesMatch;
            public int rawBytes, decodedBytes, expectedRows = -1, nestedMapRows = -1, uniqueTileKeys = -1;
        }
        // This native-derived map is verification data only. It never supplies a
        // value to a production field and never drives which config is loaded.
        [Serializable] public sealed class MappingEnvelope { public CallbackMap[] items; }
        [Serializable] public sealed class CallbackMap
        {
            public int index;
            public string address, type, keyMember;
            public StoreMap[] fieldStores;
            public string[] possibleAddresses;
        }
        [Serializable] public sealed class StoreMap { public string offset, type, name; }
        [Serializable] public sealed class OriginalPayloadEnvelope { public OriginalPayload[] items; }
        [Serializable] public sealed class OriginalPayload
        {
            public string originalAddress, rawSha256, decodedSha256;
            public int rawBytes, decodedBytes, recordCount;
        }

        [MenuItem("Recovery/Observe Config Consumption/With Original InitGameSetting")]
        public static void RunWithOriginalPreconditions() { Start(true, false); }

        [MenuItem("Recovery/Observe Config Consumption/Without Invoking Preconditions")]
        public static void RunWithoutInvokingPreconditions() { Start(false, false); }

        // Batch invocation: use -executeMethod ...ObserveConfigConsumption.Run
        // without -quit. Only this explicit entry point exits a batch process.
        public static void Run()
        {
            bool skip = Environment.GetCommandLineArgs().Contains("-recoveryConfigSkipPreconditions");
            Start(!skip, Application.isBatchMode);
        }

        private static void Start(bool applyOriginalPreconditions, bool exitBatch)
        {
            if (_active) throw new InvalidOperationException("A config consumption observation is already active.");
            _workspace = Directory.GetParent(Directory.GetParent(Application.dataPath).FullName).Parent.FullName;
            string ledger = Path.GetFullPath(Path.Combine(_workspace, "work", "recovery-ledger"));
            string id = DateTime.UtcNow.ToString("yyyyMMdd-HHmmss-fff", CultureInfo.InvariantCulture) + "-" + Guid.NewGuid().ToString("N").Substring(0, 8);
            string[] args = Environment.GetCommandLineArgs();
            _reportPath = Path.GetFullPath(Argument(args, "-recoveryConfigReportPath", Path.Combine(ledger, id + "-config-consumption.json")));
            if (!_reportPath.StartsWith(ledger + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException("The config observation report must stay inside work/recovery-ledger.");
            if (!double.TryParse(Argument(args, "-recoveryConfigTimeoutSeconds", "120"), NumberStyles.Float,
                CultureInfo.InvariantCulture, out double timeout) || timeout < 10 || timeout > 600)
                throw new ArgumentException("Config observation timeout must be from 10 to 600 seconds.");
            Directory.CreateDirectory(ledger);
            _run = new RunRecord
            {
                runId = id, startedUtc = DateTime.UtcNow.ToString("o"), status = "preflight",
                reportPath = _reportPath, unityVersion = Application.unityVersion,
                batchMode = Application.isBatchMode, playMode = EditorApplication.isPlaying,
                originalPreconditionsRequested = applyOriginalPreconditions,
                startedEditorTime = EditorApplication.timeSinceStartup, timeoutSeconds = timeout,
                coreGameplayAccepted = false, abContextConfirmed = false,
                acceptanceScope = "Actual Unity GlobalInfo config consumption only; never whole-game or core-gameplay acceptance.",
                abContextNote = "This probe never explicitly calls ABTestManager.Init or writes an AB group. Reading the real Instance getter may cause lazy singleton construction. Getter values are observed only; the selected AB context is not established by this run."
            };
            _exitBatch = exitBatch; _getResultInvoked = false; _validationIndex = 0;
            _globalInfo = null; _awaiter = null; _isCompleted = null; _getResult = null;
            _payloads = new Dictionary<string, PayloadReadback>();
            _originalPayloads = new Dictionary<string, OriginalPayload>(StringComparer.Ordinal);
            _validationQueue = new List<CallbackMap>();
            _active = true; _nextSample = 0; _nextSave = 0;
            Application.logMessageReceived += OnLog;
            EditorApplication.update += Update;
            AssemblyReloadEvents.beforeAssemblyReload += OnBeforeReload;
            try
            {
                Save();
                if (EditorApplication.isCompiling || EditorApplication.isUpdating)
                { Finish("needs_completed_unity_import"); return; }
                if (EditorApplication.isPlayingOrWillChangePlaymode)
                { Finish("needs_idle_edit_mode"); return; }
                Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.GetName().Name == "Assembly-CSharp").ToArray();
                if (assemblies.Length != 1) throw new InvalidOperationException("Expected exactly one loaded production Assembly-CSharp, observed " + assemblies.Length + ".");
                _production = assemblies[0];
                _globalType = _production.GetType("DataModule.GlobalInfo", true);
                _run.productionAssembly = _production.FullName;
                _run.productionAssemblyLocation = _production.Location;
                _run.productionAssemblyMvid = _production.ManifestModule.ModuleVersionId.ToString();
                if (File.Exists(_production.Location)) _run.productionAssemblySha256 = Sha256(File.ReadAllBytes(_production.Location));
                _run.globalInfoType = _globalType.AssemblyQualifiedName;
                Type uniTask = FindLoadedType("Cysharp.Threading.Tasks.UniTask");
                _run.actualUniTaskAssembly = uniTask == null ? "not found" : uniTask.Assembly.FullName;
                _run.cultureBefore = CultureSummary();
                if (applyOriginalPreconditions)
                {
                    _run.preconditionMethod = "ljzs_lt.Procedure.ProcedurePreLoad.InitGameSetting";
                    _run.preconditionNativeRva = "0x439FA28";
                    Type procedure = _production.GetType("ljzs_lt.Procedure.ProcedurePreLoad", true);
                    MethodInfo init = procedure.GetMethod("InitGameSetting", BindingFlags.Instance | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
                    if (init == null) throw new MissingMethodException(procedure.FullName, "InitGameSetting");
                    object instance = Activator.CreateInstance(procedure, true);
                    Invoke(init, instance, null);
                    _run.originalPreconditionsInvoked = true;
                }
                else _run.prerequisiteError = "Original InitGameSetting was not invoked by this probe; existing parser/culture prerequisites are unverified, not asserted absent.";
                _run.cultureAfter = CultureSummary();
                ObserveAbValues();
                _globalInfo = Activator.CreateInstance(_globalType, true);
                _run.productionConstructorInvoked = true;
                _run.collectionsBefore = CaptureCollections();
                MethodInfo initInfo = _globalType.GetMethod("InitInfo", BindingFlags.Instance | BindingFlags.Public, null, Type.EmptyTypes, null);
                if (initInfo == null) throw new MissingMethodException(_globalType.FullName, "InitInfo");
                _run.invokedMethod = initInfo.DeclaringType.FullName + "." + initInfo.Name;
                _run.returnType = initInfo.ReturnType.AssemblyQualifiedName;
                _run.status = "invoking_production_init"; Save();
                _run.productionInitInvoked = true;
                object task = Invoke(initInfo, _globalInfo, null);
                if (task == null) throw new InvalidOperationException("Production InitInfo returned null instead of its real awaitable.");
                _run.awaitableType = task.GetType().AssemblyQualifiedName;
                MethodInfo getAwaiter = task.GetType().GetMethod("GetAwaiter", BindingFlags.Instance | BindingFlags.Public, null, Type.EmptyTypes, null);
                if (getAwaiter == null) throw new MissingMethodException(task.GetType().FullName, "GetAwaiter");
                _awaiter = Invoke(getAwaiter, task, null);
                _run.awaiterType = _awaiter.GetType().AssemblyQualifiedName;
                _run.awaiterAssembly = _awaiter.GetType().Assembly.FullName;
                _isCompleted = _awaiter.GetType().GetProperty("IsCompleted", BindingFlags.Instance | BindingFlags.Public);
                _getResult = _awaiter.GetType().GetMethod("GetResult", BindingFlags.Instance | BindingFlags.Public, null, Type.EmptyTypes, null);
                if (_isCompleted == null || _getResult == null) throw new MissingMemberException("The actual production awaiter lacks IsCompleted/GetResult.");
                _run.status = "awaiting_production_awaiter";
                SampleState(); Save();
            }
            catch (Exception exception)
            {
                _run.exception = Unwrap(exception).ToString();
                if (!_run.productionConstructorInvoked) _run.prerequisiteError = _run.exception;
                Finish("production_or_prerequisite_exception");
            }
        }

        private static void Update()
        {
            if (!_active || _run == null) return;
            try
            {
                double elapsed = EditorApplication.timeSinceStartup - _run.startedEditorTime;
                _run.elapsedSeconds = elapsed;
                if (elapsed > _run.timeoutSeconds)
                { Finish("observation_timeout_production_not_forced_complete"); return; }
                if (EditorApplication.isCompiling || EditorApplication.isUpdating || EditorApplication.isPlayingOrWillChangePlaymode)
                { Finish("editor_state_changed_observation_interrupted"); return; }
                if (elapsed >= _nextSample) { SampleState(); _nextSample = elapsed + 0.5; }
                if (_run.status == "awaiting_production_awaiter" && (bool)_isCompleted.GetValue(_awaiter, null))
                {
                    if (_getResultInvoked) throw new InvalidOperationException("An awaiter result must never be consumed twice.");
                    _getResultInvoked = true; _run.getResultInvoked = true;
                    Invoke(_getResult, _awaiter, null);
                    _run.productionAwaitCompleted = true;
                    SampleState();
                    _run.collectionsAfter = CaptureCollections();
                    PrepareTypedValidation();
                    _run.status = "validating_actual_typed_fields";
                }
                if (_run.status == "validating_actual_typed_fields")
                {
                    // At most one selected callback mapping per Editor update.
                    if (_validationIndex < _validationQueue.Count)
                        ValidateOne(_validationQueue[_validationIndex++]);
                    else
                    {
                        _run.validationCount = _run.typedChecks.Count;
                        _run.validationPassed = _run.typedChecks.Count(c => c.passed);
                        _run.validationFailed = _run.validationCount - _run.validationPassed;
                        bool logsClean = !_run.logs.Any(l => l.type == "Error" || l.type == "Exception" || l.type == "Assert");
                        _run.configurationConsumptionPassed = _run.productionAwaitCompleted && _run.pendingListConverged
                            && _run.selectedRequestCountMatchesNative && _run.schemaMappingAvailable
                            && _run.validationCount == 65 && _run.validationFailed == 0 && logsClean;
                        Finish(_run.configurationConsumptionPassed ? "current_config_consumption_passed_ab_context_unconfirmed" : "config_consumption_completed_validation_failed");
                        return;
                    }
                }
                if (elapsed >= _nextSave) { Save(); _nextSave = elapsed + 1; }
            }
            catch (Exception exception)
            {
                _run.exception = Unwrap(exception).ToString();
                Finish("production_awaiter_or_typed_validation_exception");
            }
        }

        private static void ObserveAbValues()
        {
            string[] properties = { "NewMachineCardIsB", "NewCardsV1IsB", "WeeklyCardEventIsB", "NewArtifactsPlayIsBTest",
                "ShopImproveV1IsBTest", "AbilitiesInAdvanceIsBTest", "NewArenaProcessIsBTest", "NewbieTutorialIsBTest",
                "GamePlayImproveV2Variant", "BalanceAdjustment03IsBTest", "WeeklyClashImprove01IsBTest" };
            try
            {
                Type type = _production.GetType("SDKModule.ABTestManager", true);
                PropertyInfo instance = type.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);
                object value = instance.GetValue(null, null);
                foreach (string name in properties)
                {
                    var entry = new AbValue { property = name };
                    _run.abValues.Add(entry);
                    try
                    {
                        PropertyInfo property = type.GetProperty(name, BindingFlags.Public | BindingFlags.Instance);
                        MethodInfo getter = property.GetGetMethod();
                        entry.declaringType = getter.DeclaringType.AssemblyQualifiedName;
                        entry.value = Convert.ToString(property.GetValue(value, null), CultureInfo.InvariantCulture);
                        byte[] il = getter.GetMethodBody()?.GetILAsByteArray();
                        if (il != null)
                        {
                            entry.getterIlAvailable = true;
                            entry.getterIlSha256 = Sha256(il); entry.getterIlHex = BitConverter.ToString(il).Replace("-", "");
                            entry.possibleConstantDefaultStub = IsConstantDefaultReturn(il);
                        }
                    }
                    catch (Exception exception) { entry.error = Unwrap(exception).ToString(); }
                }
            }
            catch (Exception exception) { _run.abValues.Add(new AbValue { property = "Instance", error = Unwrap(exception).ToString() }); }
        }

        private static bool IsConstantDefaultReturn(byte[] il)
        {
            // Conservative exact CIL shapes for release/default debug getters.
            string hex = BitConverter.ToString(il).Replace("-", "");
            return hex == "162A" || hex == "00162A" || hex == "00160A2B00062A" || hex == "160A2B00062A";
        }

        private static List<CollectionReadback> CaptureCollections()
        {
            var result = new List<CollectionReadback>();
            if (_globalInfo == null) return result;
            foreach (FieldInfo field in _globalType.GetFields(Fields))
            {
                if (!typeof(ICollection).IsAssignableFrom(field.FieldType)) continue;
                var row = new CollectionReadback { field = field.Name, declaredType = CanonicalType(field.FieldType) };
                result.Add(row);
                try
                {
                    object value = field.GetValue(_globalInfo); row.isNull = value == null;
                    if (value == null) continue;
                    row.runtimeType = value.GetType().AssemblyQualifiedName; row.count = ((ICollection)value).Count;
                    Type[] generic = field.FieldType.GetGenericArguments();
                    if (generic.Length == 1) row.elementType = generic[0].AssemblyQualifiedName;
                    if (generic.Length == 2) { row.keyType = generic[0].AssemblyQualifiedName; row.elementType = generic[1].AssemblyQualifiedName; }
                }
                catch (Exception exception) { row.error = Unwrap(exception).ToString(); }
            }
            return result;
        }

        private static string[] ReadPaths(string fieldName)
        {
            if (_globalInfo == null) return Array.Empty<string>();
            FieldInfo field = _globalType.GetField(fieldName, Fields);
            if (field == null) throw new MissingFieldException(_globalType.FullName, fieldName);
            IEnumerable value = field.GetValue(_globalInfo) as IEnumerable;
            return value == null ? Array.Empty<string>() : value.Cast<object>().Select(v => Convert.ToString(v, CultureInfo.InvariantCulture)).ToArray();
        }

        private static void SampleState()
        {
            if (_globalInfo == null) return;
            _run.selectedPaths = ReadPaths("hadLoadInfo"); _run.pendingPaths = ReadPaths("loadingConfig");
            _run.selectedPathCount = _run.selectedPaths.Length; _run.pendingPathCount = _run.pendingPaths.Length;
            _run.selectedRequestCountMatchesNative = _run.selectedPathCount == 65;
            _run.pendingListConverged = _run.pendingPathCount == 0;
            if (_run.samples.Count < 300)
                _run.samples.Add(new Sample { phase = _run.status, elapsedSeconds = _run.elapsedSeconds,
                    selectedPaths = _run.selectedPathCount, pendingPaths = _run.pendingPathCount, pending = _run.pendingPaths });
        }

        private static void PrepareTypedValidation()
        {
            _run.mappingPath = Path.Combine(_workspace, "outputs", "恢复过程文档", "证据", "新配置与DataManager恢复", "配置路径-类型-回调-字段映射.json");
            if (!File.Exists(_run.mappingPath)) return;
            byte[] raw = File.ReadAllBytes(_run.mappingPath); _run.mappingSha256 = Sha256(raw);
            MappingEnvelope mapping = JsonUtility.FromJson<MappingEnvelope>("{\"items\":" + Encoding.UTF8.GetString(raw) + "}");
            if (mapping?.items == null || mapping.items.Length != 72) throw new InvalidDataException("The native callback verification map must contain exactly 72 mappings.");
            _run.originalResourceAuditPath = Path.Combine(Path.GetDirectoryName(_run.mappingPath), "resource-audit.json");
            byte[] auditRaw = File.ReadAllBytes(_run.originalResourceAuditPath);
            _run.originalResourceAuditSha256 = Sha256(auditRaw);
            OriginalPayloadEnvelope audit = JsonUtility.FromJson<OriginalPayloadEnvelope>("{\"items\":" + Encoding.UTF8.GetString(auditRaw) + "}");
            if (audit?.items == null || audit.items.Length != 81) throw new InvalidDataException("The original resource audit must contain all 81 addresses.");
            foreach (OriginalPayload payload in audit.items) _originalPayloads.Add(payload.originalAddress, payload);
            var selected = new HashSet<string>(_run.selectedPaths, StringComparer.Ordinal);
            foreach (CallbackMap row in mapping.items)
            {
                if (row.possibleAddresses == null || row.possibleAddresses.Any(p => !p.StartsWith(AddressPrefix, StringComparison.Ordinal) || !p.EndsWith(".json", StringComparison.Ordinal)))
                    throw new InvalidDataException("The verification map contains a path outside the original new config chain.");
                if (row.possibleAddresses.Any(selected.Contains)) _validationQueue.Add(row);
            }
            _run.schemaMappingAvailable = true;
        }

        private static void ValidateOne(CallbackMap row)
        {
            string selected = row.possibleAddresses.Single(p => _run.selectedPaths.Contains(p));
            var check = new TypedCheck { callback = row.index, selectedAddress = selected,
                expectedElementType = row.type, expectedKeyMember = row.keyMember };
            _run.typedChecks.Add(check);
            try
            {
                if (row.fieldStores == null || row.fieldStores.Length == 0) throw new InvalidDataException("A selected callback has no verified field stores.");
                PayloadReadback payload = ReadPayload(selected);
                if (!string.IsNullOrEmpty(payload.error)) throw new InvalidDataException(payload.error);
                StoreMap listStore = row.fieldStores[0]; check.listField = listStore.name;
                FieldInfo listField = _globalType.GetField(listStore.name, Fields);
                if (listField == null) throw new MissingFieldException(_globalType.FullName, listStore.name);
                check.actualListDeclaredType = CanonicalType(listField.FieldType);
                check.listTypeMatches = Normalize(listStore.type) == Normalize(check.actualListDeclaredType);
                object listValue = listField.GetValue(_globalInfo);
                if (!(listValue is ICollection list)) throw new InvalidDataException("The real callback list is null or lacks ICollection: " + listStore.name);
                check.actualRows = list.Count; check.expectedRows = payload.expectedRows;
                Type expectedType = _production.GetType("DataModule." + row.type, false);
                if (expectedType == null) throw new TypeLoadException("The original model type was not found in production: " + row.type);
                foreach (object item in (IEnumerable)listValue)
                {
                    if (item == null || !expectedType.IsInstanceOfType(item)) ++check.wrongElementTypes;
                    else if (check.actualElementRuntimeType == null) check.actualElementRuntimeType = item.GetType().AssemblyQualifiedName;
                }
                check.dictionaryTypeMatches = true;
                if (row.fieldStores.Length == 2)
                {
                    StoreMap dictionary = row.fieldStores[1]; check.dictionaryField = dictionary.name;
                    FieldInfo field = _globalType.GetField(dictionary.name, Fields);
                    check.actualDictionaryDeclaredType = CanonicalType(field.FieldType);
                    check.dictionaryTypeMatches = Normalize(dictionary.type) == Normalize(check.actualDictionaryDeclaredType);
                    if (!(field.GetValue(_globalInfo) is ICollection actual)) throw new InvalidDataException("The real callback dictionary is null: " + dictionary.name);
                    check.actualDictionaryRows = actual.Count;
                    var actualDictionary = (IDictionary)actual;
                    Type keyType = field.FieldType.GetGenericArguments()[0];
                    foreach (object item in (IEnumerable)listValue)
                    {
                        object key = item.GetType().GetField(row.keyMember, Fields).GetValue(item);
                        if (keyType == typeof(int)) key = Convert.ToInt32(key, CultureInfo.InvariantCulture);
                        if (key == null || !actualDictionary.Contains(key) || !ReferenceEquals(actualDictionary[key], item))
                            ++check.dictionaryValueMismatches;
                    }
                }
                bool mapChecks = true;
                if (row.index == 47)
                {
                    if (row.fieldStores.Length != 3) throw new InvalidDataException("The main-city callback requires all three original field stores.");
                    FieldInfo tilesField = _globalType.GetField("tileInfos", Fields);
                    FieldInfo dictionaryField = _globalType.GetField("tileInfoDic", Fields);
                    check.actualNestedMapListDeclaredType = CanonicalType(tilesField.FieldType);
                    check.nestedMapListTypeMatches = Normalize(row.fieldStores[1].type) == Normalize(check.actualNestedMapListDeclaredType);
                    check.actualDictionaryDeclaredType = CanonicalType(dictionaryField.FieldType);
                    check.dictionaryTypeMatches = Normalize(row.fieldStores[2].type) == Normalize(check.actualDictionaryDeclaredType);
                    ICollection tiles = (ICollection)tilesField.GetValue(_globalInfo);
                    ICollection dictionary = (ICollection)dictionaryField.GetValue(_globalInfo);
                    mapChecks = tiles != null && dictionary != null && tiles.Count == payload.nestedMapRows && dictionary.Count == payload.uniqueTileKeys;
                    check.dictionaryField = "tileInfoDic"; check.actualDictionaryRows = dictionary?.Count ?? -1;
                    Type mapType = _production.GetType("DataModule.GlobalMapInfo", true);
                    if (tiles != null && dictionary is IDictionary actualDictionary)
                    {
                        foreach (object tile in (IEnumerable)tiles)
                        {
                            if (tile == null || !mapType.IsInstanceOfType(tile)) { ++check.nestedMapTypeOrValueMismatches; continue; }
                            object key = mapType.GetField("tileKey", Fields).GetValue(tile);
                            if (key == null || !actualDictionary.Contains(key) || !ReferenceEquals(actualDictionary[key], tile))
                                ++check.nestedMapTypeOrValueMismatches;
                        }
                    }
                    mapChecks &= check.nestedMapListTypeMatches && check.nestedMapTypeOrValueMismatches == 0;
                }
                check.passed = check.listTypeMatches && check.dictionaryTypeMatches && check.wrongElementTypes == 0 && check.dictionaryValueMismatches == 0
                    && check.actualRows == check.expectedRows && (row.fieldStores.Length != 2 || check.actualDictionaryRows == check.expectedRows) && mapChecks;
            }
            catch (Exception exception) { check.error = Unwrap(exception).ToString(); check.passed = false; }
        }

        private static PayloadReadback ReadPayload(string selected)
        {
            if (_payloads.TryGetValue(selected, out PayloadReadback cached)) return cached;
            var row = new PayloadReadback { selectedAddress = selected, resourcesKey = "JsonData/" + Path.GetFileNameWithoutExtension(selected),
                evidenceScope = "Path is from production hadLoadInfo. This secondary resource/decoded-row readback verifies the resulting real typed fields; it does not replace or instrument the production loader branch." };
            _payloads.Add(selected, row); _run.selectedResourceReadbacks.Add(row);
            try
            {
                TextAsset asset = Resources.Load<TextAsset>(row.resourcesKey);
                row.resourcesPresent = asset != null;
                if (asset == null) throw new InvalidDataException("No Resources readback is available; the production may have used its real Addressables fallback, which this probe does not substitute.");
                row.textAssetName = asset.name; row.textAssetRuntimeType = asset.GetType().AssemblyQualifiedName;
                byte[] raw = asset.bytes; row.rawBytes = raw.Length; row.rawSha256 = Sha256(raw);
                byte[] compressed = Convert.FromBase64String(asset.text);
                byte[] decoded;
                using (var input = new MemoryStream(compressed))
                using (var gzip = new GZipStream(input, CompressionMode.Decompress))
                using (var output = new MemoryStream()) { gzip.CopyTo(output); decoded = output.ToArray(); }
                row.decodedBytes = decoded.Length; row.decodedSha256 = Sha256(decoded);
                if (!_originalPayloads.TryGetValue(selected, out OriginalPayload original)) throw new InvalidDataException("The actual selected path is absent from the original resource audit.");
                row.originalRawSha256 = original.rawSha256; row.originalDecodedSha256 = original.decodedSha256;
                row.originalRawBytesMatch = row.rawBytes == original.rawBytes && row.rawSha256 == original.rawSha256;
                row.originalDecodedBytesMatch = row.decodedBytes == original.decodedBytes && row.decodedSha256 == original.decodedSha256;
                if (!row.originalRawBytesMatch || !row.originalDecodedBytesMatch) throw new InvalidDataException("Unity TextAsset bytes differ from the archived original payload audit.");
                // Read-only expected row counting through the actual restored
                // LitJson library. These JsonData objects never enter GlobalInfo.
                object json = ParseActualJson(Encoding.UTF8.GetString(decoded));
                row.expectedRows = JsonCount(json);
                if (row.expectedRows != original.recordCount) throw new InvalidDataException("The actual decoded row count differs from the archived original payload audit.");
                if (selected.EndsWith("/GlobalMainCityMapInfo.json", StringComparison.Ordinal))
                {
                    int nested = 0; var keys = new HashSet<string>(StringComparer.Ordinal);
                    for (int i = 0; i < row.expectedRows; ++i)
                    {
                        object outer = JsonItem(json, i);
                        object inner = ParseActualJson(Convert.ToString(JsonItem(outer, "infos"), CultureInfo.InvariantCulture));
                        int count = JsonCount(inner); nested += count;
                        for (int j = 0; j < count; ++j) keys.Add(Convert.ToString(JsonItem(JsonItem(inner, j), "tileKey"), CultureInfo.InvariantCulture));
                    }
                    row.nestedMapRows = nested; row.uniqueTileKeys = keys.Count;
                }
            }
            catch (Exception exception) { row.error = Unwrap(exception).ToString(); }
            return row;
        }

        private static object ParseActualJson(string json)
        {
            Type mapper = FindLoadedType("LitJson.JsonMapper");
            if (mapper == null) throw new TypeLoadException("The actual LitJson.JsonMapper is not loaded.");
            _run.actualLitJsonAssembly = mapper.Assembly.FullName;
            MethodInfo parse = mapper.GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Single(m => m.Name == "ToObject" && !m.IsGenericMethod && m.GetParameters().Length == 1 && m.GetParameters()[0].ParameterType == typeof(string));
            return Invoke(parse, null, new object[] { json });
        }
        private static int JsonCount(object value)
        {
            if (!(bool)value.GetType().GetProperty("IsArray").GetValue(value, null)) throw new InvalidDataException("The actual decoded root is not an array.");
            return (int)value.GetType().GetProperty("Count").GetValue(value, null);
        }
        private static object JsonItem(object value, object key)
        {
            PropertyInfo indexer = value.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Single(p => p.Name == "Item" && p.GetIndexParameters().Length == 1 && p.GetIndexParameters()[0].ParameterType == key.GetType());
            return indexer.GetValue(value, new[] { key });
        }
        private static Type FindLoadedType(string name)
        {
            Type[] matches = AppDomain.CurrentDomain.GetAssemblies().Select(a => a.GetType(name, false)).Where(t => t != null).Distinct().ToArray();
            if (matches.Length > 1) throw new AmbiguousMatchException("Multiple loaded runtime definitions for " + name + ". No fixture or shadow assembly will be selected.");
            return matches.Length == 0 ? null : matches[0];
        }
        private static object Invoke(MethodInfo method, object target, object[] args)
        {
            try { return method.Invoke(target, args); }
            catch (TargetInvocationException exception) { throw exception.InnerException ?? exception; }
        }
        private static Exception Unwrap(Exception exception)
        {
            while (exception is TargetInvocationException target && target.InnerException != null) exception = target.InnerException;
            return exception;
        }
        private static string CanonicalType(Type type)
        {
            if (type == typeof(string)) return "string";
            if (type == typeof(int)) return "int";
            if (!type.IsGenericType) return type.Name;
            return type.Name.Split('`')[0] + "<" + string.Join(",", type.GetGenericArguments().Select(CanonicalType)) + ">";
        }
        private static string Normalize(string value) { return value == null ? "" : value.Replace(" ", ""); }
        private static string CultureSummary()
        {
            return "thread=" + CultureInfo.CurrentCulture.Name + ";ui=" + CultureInfo.CurrentUICulture.Name
                + ";default=" + (CultureInfo.DefaultThreadCurrentCulture?.Name ?? "null")
                + ";defaultUi=" + (CultureInfo.DefaultThreadCurrentUICulture?.Name ?? "null");
        }
        private static string Sha256(byte[] bytes)
        {
            using (SHA256 sha = SHA256.Create()) return BitConverter.ToString(sha.ComputeHash(bytes)).Replace("-", "").ToLowerInvariant();
        }
        private static string Argument(string[] args, string key, string fallback)
        {
            int index = Array.IndexOf(args, key); return index >= 0 && index + 1 < args.Length ? args[index + 1] : fallback;
        }
        private static void OnLog(string text, string stack, LogType type)
        {
            if (!_active || _run == null) return;
            if (type != LogType.Error && type != LogType.Exception && type != LogType.Assert
                && !(type == LogType.Warning && text.StartsWith("配置文件文件不在Resources目录下", StringComparison.Ordinal))) return;
            if (_run.logs.Count >= 200) { ++_run.droppedLogs; return; }
            _run.logs.Add(new LogRecord { type = type.ToString(), text = text.Length > 32000 ? text.Substring(0, 32000) + " [truncated]" : text,
                stack = stack, elapsedSeconds = EditorApplication.timeSinceStartup - _run.startedEditorTime });
        }
        private static void OnBeforeReload() { if (_active) Finish("assembly_reload_interrupted", false); }
        private static void Finish(string status, bool permitBatchExit = true)
        {
            if (!_active || _run == null) return;
            _run.status = status; _run.finishedUtc = DateTime.UtcNow.ToString("o");
            _run.elapsedSeconds = EditorApplication.timeSinceStartup - _run.startedEditorTime;
            _run.productionMayStillBeRunning = _run.productionInitInvoked && !_run.productionAwaitCompleted;
            _run.coreGameplayAccepted = false;
            try
            {
                try { SampleState(); _run.collectionsAfter = CaptureCollections(); }
                catch (Exception exception) { _run.snapshotError = Unwrap(exception).ToString(); }
                Save();
            }
            finally
            {
                _active = false;
                Application.logMessageReceived -= OnLog; EditorApplication.update -= Update;
                AssemblyReloadEvents.beforeAssemblyReload -= OnBeforeReload;
            }
            UnityEngine.Debug.Log("Config consumption observation: " + status + " | " + _reportPath);
            if (_exitBatch && permitBatchExit) EditorApplication.Exit(_run.configurationConsumptionPassed ? 0 : 2);
        }
        private static void Save()
        {
            if (_run == null || string.IsNullOrEmpty(_reportPath)) return;
            string temporary = _reportPath + ".tmp";
            File.WriteAllText(temporary, JsonUtility.ToJson(_run, true), new UTF8Encoding(false));
            File.Copy(temporary, _reportPath, true); File.Delete(temporary);
        }
    }
}
