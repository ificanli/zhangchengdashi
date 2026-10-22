using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GameFramework.Recovery
{
    // Replacement platform storage for the explicitly selected independent local
    // session. This file is not an original account, SDK cache, or cloud receipt.
    public static class LocalEditorPreferences
    {
        private const string Format = "OccupyCity.IndependentLocalPreferences/v1";
        private static readonly object Gate = new object();
        private static readonly Dictionary<string, string> Strings = new Dictionary<string, string>(StringComparer.Ordinal);
        private static readonly Dictionary<string, int> Integers = new Dictionary<string, int>(StringComparer.Ordinal);
        private static string owner;
        private static bool loaded;

        public sealed class FlushReceipt
        {
            public string LocalPlayerId { get; internal set; }
            public string Path { get; internal set; }
            public string Sha256 { get; internal set; }
            public int ByteCount { get; internal set; }
            public DateTime VerifiedUtc { get; internal set; }
        }

        public sealed class FlushAttempt
        {
            public bool Attempted { get; internal set; }
            public bool Written { get; internal set; }
            public bool Readback { get; internal set; }
            public bool PartialFailure { get; internal set; }
            public string LocalPlayerId { get; internal set; }
            public string Path { get; internal set; }
            public string Error { get; internal set; }
        }

        [JsonObject(MemberSerialization.OptIn)]
        private sealed class Envelope
        {
            [JsonProperty(Required = Required.Always)] public string Format;
            [JsonProperty(Required = Required.Always)] public string LocalPlayerId;
            [JsonProperty(Required = Required.Always)] public SortedDictionary<string, string> Strings;
            [JsonProperty(Required = Required.Always)] public SortedDictionary<string, int> Integers;
        }

        public static FlushReceipt LastVerifiedFlush { get; private set; }
        public static FlushAttempt LastAttempt { get; private set; }

        private static string StoragePath
        {
            get { return Path.Combine(LocalEditorSession.StoreRoot, "preferences.independent-local"); }
        }

        public static void RequireReady()
        {
            lock (Gate) { EnsureLoaded(); }
        }

        private static void EnsureLoaded()
        {
            if (!LocalEditorSession.Selected)
                throw new NotSupportedException("Independent local preferences are not an original SDK/server storage service.");
            LocalEditorSession.RequireReady();
            if (loaded)
            {
                if (!string.Equals(owner, LocalEditorSession.LocalPlayerId, StringComparison.Ordinal))
                    throw new InvalidOperationException("The loaded independent preferences belong to another local session.");
                return;
            }
            var strings = new Dictionary<string, string>(StringComparer.Ordinal);
            var integers = new Dictionary<string, int>(StringComparer.Ordinal);
            if (File.Exists(StoragePath))
            {
                try
                {
                    JObject document;
                    using (var reader = new JsonTextReader(new StringReader(File.ReadAllText(StoragePath, Encoding.UTF8))))
                    {
                        document = JObject.Load(reader, new JsonLoadSettings { DuplicatePropertyNameHandling = DuplicatePropertyNameHandling.Error });
                        if (reader.Read()) throw new InvalidDataException("Independent preferences contain trailing data.");
                    }
                    var settings = new JsonSerializerSettings { MissingMemberHandling = MissingMemberHandling.Error, TypeNameHandling = TypeNameHandling.None };
                    Envelope data = document.ToObject<Envelope>(JsonSerializer.Create(settings));
                    if (data == null || data.Format != Format || data.LocalPlayerId != LocalEditorSession.LocalPlayerId
                        || data.Strings == null || data.Integers == null)
                        throw new InvalidDataException("Independent preferences format or local identity differs; the file has been preserved.");
                    foreach (var pair in data.Strings)
                    {
                        if (pair.Value == null) throw new InvalidDataException("Independent preference strings cannot be null.");
                        strings.Add(pair.Key, pair.Value);
                    }
                    foreach (var pair in data.Integers) integers.Add(pair.Key, pair.Value);
                }
                catch (JsonException ex) { throw new InvalidDataException("Independent preferences contain invalid JSON; the file has been preserved.", ex); }
            }
            Strings.Clear();
            Integers.Clear();
            foreach (var pair in strings) Strings.Add(pair.Key, pair.Value);
            foreach (var pair in integers) Integers.Add(pair.Key, pair.Value);
            owner = LocalEditorSession.LocalPlayerId;
            loaded = true;
        }

        private static void RequireKey(string key) { if (key == null) throw new ArgumentNullException(nameof(key)); }

        public static bool HasRawKey(string key)
        {
            RequireKey(key);
            lock (Gate) { EnsureLoaded(); return Strings.ContainsKey(key) || Integers.ContainsKey(key); }
        }

        public static void SetString(string key, string value)
        {
            RequireKey(key);
            if (value == null) throw new ArgumentNullException(nameof(value));
            lock (Gate) { EnsureLoaded(); Strings[key] = value; }
        }

        public static string GetString(string key, string defaultValue)
        {
            RequireKey(key);
            lock (Gate) { EnsureLoaded(); string value; return Strings.TryGetValue(key, out value) ? value : defaultValue; }
        }

        public static void SetInt(string key, int value)
        {
            RequireKey(key);
            lock (Gate) { EnsureLoaded(); Integers[key] = value; }
        }

        public static int GetInt(string key, int defaultValue)
        {
            RequireKey(key);
            lock (Gate) { EnsureLoaded(); int value; return Integers.TryGetValue(key, out value) ? value : defaultValue; }
        }

        public static void DeleteRawKey(string key)
        {
            RequireKey(key);
            lock (Gate) { EnsureLoaded(); Strings.Remove(key); Integers.Remove(key); }
        }

        public static bool HasKey(string key)
        {
            RequireKey(key);
            lock (Gate)
            {
                EnsureLoaded();
                return Strings.ContainsKey(key) || Integers.ContainsKey(key)
                    || Integers.ContainsKey("F_" + key) || Integers.ContainsKey("B_" + key);
            }
        }

        public static void DeleteKey(string key)
        {
            RequireKey(key);
            lock (Gate)
            {
                EnsureLoaded();
                // Original Runtime.DeleteKey removes only raw entries even when
                // HasKey is true because a prefixed float/bool entry exists.
                if (HasKey(key)) { Strings.Remove(key); Integers.Remove(key); }
            }
        }

        public static void SetBool(string key, bool value) { RequireKey(key); SetInt("B_" + key, value ? 1 : 0); }
        public static bool GetBool(string key, bool defaultValue)
        {
            RequireKey(key);
            return GetInt("B_" + key, defaultValue ? 1 : 0) == 1;
        }

        private static int EncodeFloat(float value)
        {
            float scaled = value * 100f;
            // Original ARM64 FCVTZS saturates finite overflow, maps NaN to0,
            // and has an explicit +Infinity comparison overriding to int.Min.
            if (float.IsNaN(scaled)) return 0;
            if (float.IsPositiveInfinity(scaled)) return int.MinValue;
            if (scaled >= 2147483648f) return int.MaxValue;
            if (scaled <= -2147483648f) return int.MinValue;
            return (int)scaled;
        }

        public static void SetFloat(string key, float value)
        {
            RequireKey(key);
            lock (Gate)
            {
                EnsureLoaded();
                string prefixed = "F_" + key;
                int encoded = EncodeFloat(value);
                int old;
                Integers.TryGetValue(prefixed, out old);
                if (old != encoded) Integers[prefixed] = encoded;
            }
        }

        public static float GetFloat(string key, float defaultValue)
        {
            RequireKey(key);
            lock (Gate)
            {
                EnsureLoaded();
                int encoded;
                return Integers.TryGetValue("F_" + key, out encoded) ? (float)encoded / 100f : defaultValue;
            }
        }

        public static void DeleteAll()
        {
            lock (Gate) { EnsureLoaded(); Strings.Clear(); Integers.Clear(); }
        }

        public static FlushReceipt Flush()
        {
            lock (Gate)
            {
                LastVerifiedFlush = null;
                LastAttempt = new FlushAttempt { Attempted = true };
                string pending = null;
                try
                {
                    EnsureLoaded();
                    string target = StoragePath;
                    LastAttempt.LocalPlayerId = owner;
                    LastAttempt.Path = target;
                    string payload = JsonConvert.SerializeObject(new Envelope
                    {
                        Format = Format,
                        LocalPlayerId = owner,
                        Strings = new SortedDictionary<string, string>(Strings, StringComparer.Ordinal),
                        Integers = new SortedDictionary<string, int>(Integers, StringComparer.Ordinal)
                    }, Formatting.None);
                    pending = Path.Combine(LocalEditorSession.StoreRoot, "preferences-" + Guid.NewGuid().ToString("N") + ".pending");
                    File.WriteAllText(pending, payload, new UTF8Encoding(false));
                    if (File.ReadAllText(pending, Encoding.UTF8) != payload)
                        throw new IOException("Independent preferences staging readback differs.");
                    if (File.Exists(target)) File.Replace(pending, target, null);
                    else File.Move(pending, target);
                    LastAttempt.Written = true;
                    byte[] bytes = File.ReadAllBytes(target);
                    if (Encoding.UTF8.GetString(bytes) != payload)
                        throw new IOException("Independent preferences final readback differs.");
                    LastAttempt.Readback = true;
                    string hash;
                    using (var digest = SHA256.Create())
                        hash = BitConverter.ToString(digest.ComputeHash(bytes)).Replace("-", "").ToLowerInvariant();
                    LastVerifiedFlush = new FlushReceipt
                    {
                        LocalPlayerId = owner,
                        Path = target,
                        Sha256 = hash,
                        ByteCount = bytes.Length,
                        VerifiedUtc = DateTime.UtcNow
                    };
                    return LastVerifiedFlush;
                }
                catch (Exception ex)
                {
                    LastAttempt.Error = ex.GetType().Name + ": " + ex.Message;
                    LastAttempt.PartialFailure = LastAttempt.Written && !LastAttempt.Readback;
                    throw;
                }
                finally { if (pending != null && File.Exists(pending)) File.Delete(pending); }
            }
        }
    }
}
