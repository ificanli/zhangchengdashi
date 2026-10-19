using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Build.DataBuilders;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor.AddressableAssets.Settings.GroupSchemas;
using UnityEngine;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace OccupyCity.Recovery.Editor
{
    /// <summary>
    /// Builds genuine Addressables Fast Mode settings from a reviewed provenance plan.
    /// Never changes gameplay code, manufactures assets, or claims pending mappings work.
    /// </summary>
    public static class BuildRecoveryAddressables
    {
        private const string SettingsFolder = "Assets/RecoveryTools/GeneratedAddressables";
        private const string SettingsName = "RecoveryAddressableAssetSettings";
        private const string SettingsPath = SettingsFolder + "/" + SettingsName + ".asset";
        private const string GroupPrefix = "Recovery - ";

        [Serializable]
        public sealed class Plan
        {
            public int schemaVersion;
            public string apkSha256;
            public string projectRelativePath;
            public Entry[] entries;
            public Pending[] pending;
        }

        [Serializable]
        public sealed class Entry
        {
            public int catalogIndex;
            public string address;
            public string originalInternalId;
            public string requestedType;
            public string requestedAssembly;
            public string group;
            public string[] labels;
            public string assetPath;
            public string guid;
            public string evidenceKind;
            public string sourceFile;
            public string sourcePathId;
            public string sourceType;
            public string sourceName;
            public string sourceBundle;
            public bool pathIdMapConfirmed;
        }

        [Serializable]
        public sealed class Pending
        {
            public int catalogIndex;
            public string address;
            public string requestedType;
            public string reason;
        }

        [Serializable]
        public sealed class Issue
        {
            public int catalogIndex;
            public string address;
            public string requestedType;
            public string assetPath;
            public string message;
        }

        [Serializable]
        public sealed class Report
        {
            public string utcTime;
            public string planPath;
            public string apkSha256;
            public string projectPath;
            public string settingsPath;
            public bool buildPerformed;
            public bool complete;
            public int inputRows;
            public int inputPendingRows;
            public int validatedRows;
            public int entryCount;
            public int addressAliasLabels;
            public int locatorChecks;
            public List<Issue> validationFailures = new List<Issue>();
            public List<Issue> locatorFailures = new List<Issue>();
            public string fatalError;
        }

        [MenuItem("Tools/Occupy City Recovery/Validate Addressables Plan")]
        public static void ValidateOnly() => Run(false);

        [MenuItem("Tools/Occupy City Recovery/Build Addressables Fast Mode Settings")]
        public static void Build() => Run(true);

        private static void Run(bool build)
        {
            var project = Path.GetFullPath(Path.Combine(Application.dataPath, ".."));
            var planPath = GetArgument("-recoveryPlan") ?? Path.GetFullPath(
                Path.Combine(project, "..", "..", "work", "startup-restore", "addressable-recovery-plan.json"));
            var report = new Report
            {
                utcTime = DateTime.UtcNow.ToString("O"),
                planPath = Path.GetFullPath(planPath),
                projectPath = project,
                settingsPath = SettingsPath
            };
            try
            {
                if (EditorApplication.isPlayingOrWillChangePlaymode)
                    throw new InvalidOperationException("Run recovery settings preparation outside Play Mode.");
                var plan = JsonUtility.FromJson<Plan>(File.ReadAllText(report.planPath));
                if (plan == null || plan.schemaVersion != 1 || plan.entries == null)
                    throw new InvalidDataException("Expected recovery plan schemaVersion 1 with entries.");
                var intendedProject = Path.GetFullPath(Path.Combine(
                    Path.GetDirectoryName(report.planPath), "..", "..", plan.projectRelativePath ?? ""));
                if (!string.Equals(project.TrimEnd(Path.DirectorySeparatorChar),
                        intendedProject.TrimEnd(Path.DirectorySeparatorChar), StringComparison.OrdinalIgnoreCase))
                    throw new InvalidDataException("The plan targets a different project: " + intendedProject);

                report.apkSha256 = plan.apkSha256;
                report.inputRows = plan.entries.Length;
                report.inputPendingRows = plan.pending?.Length ?? 0;
                var valid = ValidateEntries(plan.entries, report);
                report.validatedRows = valid.Count;
                if (build)
                {
                    if (valid.Count == 0)
                        throw new InvalidDataException("No mappings passed validation; no settings were created.");
                    var settings = CreateSettings(valid, report);
                    report.buildPerformed = true;
                    CheckLocator(settings, valid, report);
                }

                report.complete = report.inputPendingRows == 0 &&
                    report.validationFailures.Count == 0 && report.locatorFailures.Count == 0;
                WriteReport(project, report, build);
                var message = $"Recovery Addressables {(build ? "settings preparation" : "plan validation")}: " +
                    $"{report.validatedRows}/{report.inputRows} rows validated, " +
                    $"{report.inputPendingRows} input rows pending, " +
                    $"{report.validationFailures.Count} validation failures, " +
                    $"{report.locatorFailures.Count} locator failures. " +
                    "This does not validate Play Mode or gameplay.";
                if (report.complete) Debug.Log(message);
                else Debug.LogWarning(message);
            }
            catch (Exception error)
            {
                report.complete = false;
                report.fatalError = error.ToString();
                WriteReport(project, report, build);
                throw;
            }
        }

        private static List<Entry> ValidateEntries(IEnumerable<Entry> entries, Report report)
        {
            var valid = new List<Entry>();
            var seen = new HashSet<string>(StringComparer.Ordinal);
            foreach (var entry in entries)
            {
                try
                {
                    if (entry == null || string.IsNullOrWhiteSpace(entry.address) ||
                        string.IsNullOrWhiteSpace(entry.assetPath) || string.IsNullOrWhiteSpace(entry.guid))
                        throw new InvalidDataException("Missing address, assetPath, or GUID.");
                    if (!entry.assetPath.StartsWith("Assets/", StringComparison.Ordinal) ||
                        entry.assetPath.Split('/').Any(part => part == ".."))
                        throw new InvalidDataException("Export target must be a project Assets path.");
                    if (!string.Equals(AssetDatabase.AssetPathToGUID(entry.assetPath), entry.guid, StringComparison.Ordinal))
                        throw new InvalidDataException("The imported GUID does not match the reviewed plan.");
                    if (entry.evidenceKind != "original-path-preserved" &&
                        (string.IsNullOrWhiteSpace(entry.sourceFile) || string.IsNullOrWhiteSpace(entry.sourcePathId) ||
                         string.IsNullOrWhiteSpace(entry.sourceBundle)))
                        throw new InvalidDataException("A changed path needs source bundle/file/PathID evidence.");
                    var requested = ResolveType(entry);
                    var imported = requested == typeof(SceneInstance) ? typeof(SceneAsset) : requested;
                    if (!typeof(UnityEngine.Object).IsAssignableFrom(imported))
                        throw new InvalidDataException("Expected a Unity asset type or SceneInstance.");
                    var mainType = AssetDatabase.GetMainAssetTypeAtPath(entry.assetPath);
                    if (mainType == null || !imported.IsAssignableFrom(mainType))
                    {
                        var subassets = AssetDatabase.LoadAllAssetsAtPath(entry.assetPath);
                        if (!subassets.Any(asset => asset != null && imported.IsInstanceOfType(asset)))
                            throw new InvalidDataException("Export does not contain requested imported type " + imported.FullName);
                    }

                    var key = entry.address + "\n" + entry.requestedType + "\n" + entry.guid;
                    if (seen.Add(key)) valid.Add(entry);
                }
                catch (Exception error)
                {
                    report.validationFailures.Add(ToIssue(entry, error.Message));
                }
            }
            return valid;
        }

        private static AddressableAssetSettings CreateSettings(List<Entry> valid, Report report)
        {
            var existingDefault = AddressableAssetSettingsDefaultObject.Settings;
            if (existingDefault != null && AssetDatabase.GetAssetPath(existingDefault) != SettingsPath)
                throw new InvalidOperationException("Another default Addressables settings asset is active; preserved: " +
                    AssetDatabase.GetAssetPath(existingDefault));
            EnsureFolder(SettingsFolder);
            EnsureFolder(AddressableAssetSettingsDefaultObject.kDefaultConfigFolder);
            var settings = AssetDatabase.LoadAssetAtPath<AddressableAssetSettings>(SettingsPath) ??
                AddressableAssetSettings.Create(SettingsFolder, SettingsName, true, true);
            var desiredGuids = new HashSet<string>(valid.Select(row => row.guid), StringComparer.Ordinal);
            // Only entries in this tool's owned settings/groups are reconciled.
            foreach (var group in settings.groups.Where(group => group != null && group.Name.StartsWith(GroupPrefix, StringComparison.Ordinal)).ToArray())
                foreach (var oldEntry in group.entries.Where(entry => !desiredGuids.Contains(entry.guid)).ToArray())
                    settings.RemoveAssetEntry(oldEntry.guid, false);

            foreach (var rows in valid.GroupBy(row => row.guid).OrderBy(group => group.Key, StringComparer.Ordinal))
            {
                var ordered = rows.OrderBy(row => row.address, StringComparer.Ordinal).ThenBy(row => row.requestedType, StringComparer.Ordinal).ToArray();
                var primary = ordered[0];
                var groupName = GroupPrefix + Sanitize(primary.group ?? "RecoveredCatalog");
                var group = settings.FindGroup(groupName) ?? settings.CreateGroup(groupName, false, false, false,
                    null, typeof(BundledAssetGroupSchema), typeof(ContentUpdateGroupSchema));
                var assetEntry = settings.CreateOrMoveEntry(primary.guid, group, false, false);
                assetEntry.SetAddress(primary.address, false);
                foreach (var oldLabel in assetEntry.labels.ToArray()) assetEntry.SetLabel(oldLabel, false, false, false);
                var labels = new HashSet<string>(ordered.SelectMany(row => row.labels ?? Array.Empty<string>()), StringComparer.Ordinal);
                foreach (var alias in ordered.Select(row => row.address).Distinct(StringComparer.Ordinal))
                {
                    if (alias == primary.address) continue;
                    labels.Add(alias);
                    report.addressAliasLabels++;
                }
                foreach (var label in labels) assetEntry.SetLabel(label, true, true, false);
                EditorUtility.SetDirty(group);
                report.entryCount++;
            }

            var fastIndex = settings.DataBuilders.FindIndex(builder => builder is BuildScriptFastMode);
            if (fastIndex < 0) throw new InvalidOperationException("Official BuildScriptFastMode was not created by settings initialization.");
            settings.ActivePlayModeDataBuilderIndex = fastIndex;
            AddressableAssetSettingsDefaultObject.Settings = settings;
            settings.SetDirty(AddressableAssetSettings.ModificationEvent.BatchModification, null, true, true);
            EditorUtility.SetDirty(settings);
            AssetDatabase.SaveAssets();
            return settings;
        }

        private static void CheckLocator(AddressableAssetSettings settings, IEnumerable<Entry> entries, Report report)
        {
            // Introspect the official 1.22.3 locator instead of installing a replacement provider.
            var locatorType = typeof(AddressableAssetSettings).Assembly.GetType(
                "UnityEditor.AddressableAssets.Settings.AddressableAssetSettingsLocator", true);
            var locator = (IResourceLocator)Activator.CreateInstance(locatorType, new object[] { settings });
            foreach (var entry in entries)
            {
                report.locatorChecks++;
                try
                {
                    var requested = ResolveType(entry);
                    if (!locator.Locate(entry.address, requested, out IList<IResourceLocation> locations))
                        throw new InvalidDataException("Official settings locator found no location.");
                    var distinct = locations.GroupBy(location => location.InternalId + "\n" + location.ResourceType.FullName)
                        .Select(group => group.First()).ToArray();
                    if (distinct.Length != 1 || distinct[0].InternalId != entry.assetPath)
                        throw new InvalidDataException("Address/type is ambiguous or resolves to a different export: " +
                            string.Join("; ", distinct.Select(location => location.InternalId + " [" + location.ResourceType.FullName + "]")));
                    var provider = requested == typeof(SceneInstance) ? typeof(SceneProvider).FullName : typeof(AssetDatabaseProvider).FullName;
                    if (distinct[0].ProviderId != provider)
                        throw new InvalidDataException("Unexpected official Fast Mode provider: " + distinct[0].ProviderId);
                }
                catch (Exception error)
                {
                    report.locatorFailures.Add(ToIssue(entry, error.Message));
                }
            }
        }

        private static Type ResolveType(Entry entry)
        {
            var type = Type.GetType(entry.requestedType + ", " + entry.requestedAssembly, false);
            if (type != null) return type;
            var matches = AppDomain.CurrentDomain.GetAssemblies().Select(assembly => assembly.GetType(entry.requestedType, false))
                .Where(candidate => candidate != null).Distinct().ToArray();
            if (matches.Length != 1)
                throw new TypeLoadException("Requested type is absent or ambiguous: " + entry.requestedType);
            return matches[0];
        }

        private static Issue ToIssue(Entry entry, string message) => new Issue
        {
            catalogIndex = entry?.catalogIndex ?? -1,
            address = entry?.address,
            requestedType = entry?.requestedType,
            assetPath = entry?.assetPath,
            message = message
        };

        private static string GetArgument(string name)
        {
            var args = Environment.GetCommandLineArgs();
            for (var index = 0; index + 1 < args.Length; index++)
                if (args[index] == name) return args[index + 1];
            return null;
        }

        private static string Sanitize(string name)
        {
            foreach (var character in Path.GetInvalidFileNameChars()) name = name.Replace(character, '_');
            return name.Replace('/', '_').Replace('\\', '_');
        }

        private static void EnsureFolder(string assetPath)
        {
            var current = "Assets";
            foreach (var part in assetPath.Split('/').Skip(1))
            {
                var next = current + "/" + part;
                if (!AssetDatabase.IsValidFolder(next)) AssetDatabase.CreateFolder(current, part);
                current = next;
            }
        }

        private static void WriteReport(string project, Report report, bool build)
        {
            var folder = Path.Combine(project, "RecoveryReports");
            Directory.CreateDirectory(folder);
            File.WriteAllText(Path.Combine(folder, build ? "addressables-build-report.json" : "addressables-validation-report.json"),
                JsonUtility.ToJson(report, true));
        }
    }
}
