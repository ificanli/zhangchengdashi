using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace GameFramework.Recovery
{
    // Explicit single-player service for the recovered Editor project.
    // This identity and state never represent an original SDK/server login.
    public static class LocalEditorSession
    {
#if UNITY_EDITOR
        public const bool Selected = true;
#else
        public const bool Selected = false;
#endif
        private const string Format = "OccupyCity.LocalEditorSession/v1";
        private static readonly object Gate = new object();
        public static bool IsReady { get; private set; }
        public static bool PersistenceVerified { get; private set; }
        public static string LocalPlayerId { get; private set; }
        public static string ProfileRoot { get; private set; }
        public static string StoreRoot { get; private set; }

        public static void Begin(string profileRoot)
        {
            if (string.IsNullOrWhiteSpace(profileRoot)) throw new ArgumentException("A local profile directory is required.", nameof(profileRoot));
            string resolved = Path.GetFullPath(profileRoot);
            lock (Gate)
            {
                if (IsReady)
                {
                    if (!string.Equals(ProfileRoot, resolved, StringComparison.OrdinalIgnoreCase))
                        throw new InvalidOperationException("A running local session cannot switch profiles.");
                    return;
                }
                Directory.CreateDirectory(resolved);
                string descriptor = Path.Combine(resolved, "profile.local");
                if (!File.Exists(descriptor))
                {
                    string pending = Path.Combine(resolved, "profile-" + Guid.NewGuid().ToString("N") + ".new");
                    try
                    {
                        File.WriteAllLines(pending, new[] { Format, "local-" + Guid.NewGuid().ToString("N"), DateTime.UtcNow.ToString("o", CultureInfo.InvariantCulture) }, new UTF8Encoding(false));
                        File.Move(pending, descriptor);
                    }
                    finally { if (File.Exists(pending)) File.Delete(pending); }
                }
                string[] lines = File.ReadAllLines(descriptor, Encoding.UTF8);
                if (lines.Length != 3 || lines[0] != Format || !lines[1].StartsWith("local-", StringComparison.Ordinal)
                    || !Guid.TryParseExact(lines[1].Substring(6), "N", out _)
                    || !DateTime.TryParseExact(lines[2], "o", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out _))
                    throw new InvalidDataException("The local profile is invalid; it has been preserved for inspection.");
                string saves = Path.Combine(resolved, "saves");
                Directory.CreateDirectory(saves);
                string probe = Path.Combine(saves, "session-check-" + Guid.NewGuid().ToString("N") + ".tmp");
                string payload = Guid.NewGuid().ToString("N");
                try
                {
                    File.WriteAllText(probe, payload, new UTF8Encoding(false));
                    if (File.ReadAllText(probe, Encoding.UTF8) != payload)
                        throw new IOException("Local save storage did not preserve the verification payload.");
                }
                finally { if (File.Exists(probe)) File.Delete(probe); }
                ProfileRoot = resolved;
                StoreRoot = saves;
                LocalPlayerId = lines[1];
                PersistenceVerified = true;
                IsReady = true;
            }
        }

        public static void RequireReady()
        {
            if (!IsReady || !PersistenceVerified)
                throw new InvalidOperationException("The independent local session has not completed its real profile and storage initialization.");
        }
    }
}
