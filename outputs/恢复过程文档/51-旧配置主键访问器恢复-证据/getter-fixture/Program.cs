using System.Reflection;
using System.Text.Json;
using GameFramework;

internal sealed class Target
{
    public string type { get; set; }
    public string field { get; set; }
    public string token { get; set; }
    public string rva { get; set; }
}

internal static class Program
{
    private static int Main(string[] args)
    {
        string mode = args[0];
        Target[] targets = JsonSerializer.Deserialize<Target[]>(File.ReadAllText(args[1]));
        List<object> types = new();
        int totalChecks = 0, failedChecks = 0, failedTypes = 0, nullGetterTypes = 0;
        int[] boundaries = { int.MinValue, -1, 0, 1, int.MaxValue };
        foreach (Target target in targets)
        {
            List<object> checks = new();
            int typeFailures = 0, boundaryNulls = 0;
            void Check(string name, bool passed, object expected = null, object actual = null)
            {
                totalChecks++;
                if (!passed) { failedChecks++; typeFailures++; }
                checks.Add(new { name, passed, expected, actual });
            }
            try
            {
                Type type = typeof(Program).Assembly.GetType("ljzs_lt." + target.type, true);
                FieldInfo field = type.GetField(target.field, BindingFlags.Public | BindingFlags.Instance);
                BaseConfig row = (BaseConfig)Activator.CreateInstance(type);
                BaseConfig secondRow = (BaseConfig)Activator.CreateInstance(type);
                Check("field-type-System.Int32", field != null && field.FieldType == typeof(int), "System.Int32", field?.FieldType.FullName);
                foreach (FieldInfo nonkey in type.GetFields(BindingFlags.Public | BindingFlags.Instance))
                    if (nonkey != field && nonkey.FieldType == typeof(int)) nonkey.SetValue(row, 123456789);
                foreach (int boundary in boundaries)
                {
                    field.SetValue(row, boundary);
                    object actual = row.UniqueID;
                    if (actual == null) boundaryNulls++;
                    Check("boundary-nonnull:" + boundary, actual != null, "boxed System.Int32", actual);
                    Check("boundary-type:" + boundary, actual?.GetType() == typeof(int), "System.Int32", actual?.GetType().FullName);
                    Check("boundary-value:" + boundary, actual is int value && value == boundary, boundary, actual);
                }
                field.SetValue(row, 1);
                field.SetValue(secondRow, 1);
                object firstKey = row.UniqueID;
                object secondKey = secondRow.UniqueID;
                Check("equal-int-key-different-row", firstKey is int && secondKey is int && firstKey.Equals(secondKey), true, firstKey?.Equals(secondKey));
                Dictionary<object, BaseConfig> dictionary = new();
                if (firstKey != null) dictionary.Add(firstKey, row);
                Check("dictionary-contains-equal-box", secondKey != null && dictionary.ContainsKey(secondKey), true, secondKey != null && dictionary.ContainsKey(secondKey));
                bool duplicateRejected = false;
                if (secondKey != null)
                {
                    try { dictionary.Add(secondKey, secondRow); }
                    catch (ArgumentException) { duplicateRejected = true; }
                }
                Check("dictionary-duplicate-key-rejected", duplicateRejected, true, duplicateRejected);
                Check("dictionary-original-row-identity", firstKey != null && dictionary.TryGetValue(firstKey, out BaseConfig original) && ReferenceEquals(original, row), true);
                Check("boxed-int-equality", firstKey != null && firstKey.Equals((object)1), true);
                Check("boxed-long-distinct", firstKey is int && !firstKey.Equals((object)1L), true);
                Check("boxed-uint-distinct", firstKey is int && !firstKey.Equals((object)1u), true);
                Check("string-distinct", firstKey is int && !firstKey.Equals("1"), true);
                Check("dictionary-long-key-distinct", firstKey is int && !dictionary.ContainsKey((object)1L), true);
                Check("dictionary-string-key-distinct", firstKey is int && !dictionary.ContainsKey("1"), true);
                field.SetValue(row, -1);
                object changedKey = row.UniqueID;
                Check("field-change-reread", changedKey is int reread && reread == -1, -1, changedKey);
                Check("old-boxed-key-value-retained", firstKey is int old && old == 1, 1, firstKey);
                Check("dictionary-retains-old-key", firstKey is int && dictionary.ContainsKey((object)1) && ReferenceEquals(dictionary[(object)1], row), true);
                Check("dictionary-does-not-move-key", changedKey is int && !dictionary.ContainsKey(changedKey), true);
                foreach (FieldInfo nonkey in type.GetFields(BindingFlags.Public | BindingFlags.Instance))
                    if (nonkey != field && nonkey.FieldType == typeof(int)) nonkey.SetValue(row, -123456789);
                object afterNonkeyChange = row.UniqueID;
                Check("nonkey-fields-do-not-select-key", afterNonkeyChange is int selected && selected == -1, -1, afterNonkeyChange);
            }
            catch (Exception ex)
            {
                Check("unexpected-exception", false, null, ex.ToString());
            }
            if (typeFailures > 0) failedTypes++;
            if (boundaryNulls == boundaries.Length) nullGetterTypes++;
            types.Add(new { target.type, target.field, target.token, target.rva, passed = typeFailures == 0, failedTestCount = typeFailures, boundaryNulls, checks });
        }
        bool expectedNegative = mode == "before";
        bool passedAll = failedChecks == 0 && failedTypes == 0 && targets.Length == 38;
        bool observedExpectedNegative = expectedNegative && !passedAll && failedTypes == 38 && nullGetterTypes == 38;
        object result = new
        {
            mode,
            passed = passedAll,
            expectedNegative,
            observedExpectedNegative,
            typeCount = targets.Length,
            failedTypeCount = failedTypes,
            failedTestCount = failedChecks,
            totalTestCount = totalChecks,
            nullGetterTypeCount = nullGetterTypes,
            boundaryValues = boundaries,
            limitation = "Direct Compile Include of 38 actual row sources. Reflection only supplies field values; UniqueID runs by virtual dispatch. No row getter implementation is copied into the fixture. Shared stage41 adapters provide external declarations; no JsonUtility or resource methods are called by these tests. This proves managed boxed-key behavior, not Unity runtime acceptance.",
            types
        };
        File.WriteAllText(args[2], JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }) + Environment.NewLine);
        Console.WriteLine(JsonSerializer.Serialize(new { mode, passed = passedAll, expectedNegative, observedExpectedNegative, typeCount = targets.Length, failedTypeCount = failedTypes, failedTestCount = failedChecks, totalTestCount = totalChecks, nullGetterTypeCount = nullGetterTypes }));
        return passedAll ? 0 : 1;
    }
}
