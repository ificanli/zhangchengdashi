#if UNITY_EDITOR
using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

namespace GameFramework.Recovery
{
    // Independent local platform metadata. This is not an SDK configuration or SDK readiness result.
    public static class LocalEditorPlatformMetadata
    {
        private const string Format = "OccupyCity.LocalPlatformMetadata/v1";
        private const string FileName = "platform-metadata.local.v1";
        private const string NormalPlay = "normal-play";
        private static readonly object Gate = new object();
        private static readonly UTF8Encoding StrictUtf8 = new UTF8Encoding(false, true);
        private static bool initialized;
        private static string ownerId, configurationPath, configurationSha256;
        private static int designMode = -1;

        public static bool IsInitialized { get { lock (Gate) return initialized; } }
        public static string ConfigurationPath { get { lock (Gate) return configurationPath; } }
        public static string ConfigurationSha256 { get { lock (Gate) return configurationSha256; } }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetForRun()
        {
            lock (Gate) ClearVerifiedState();
        }

        private static void ClearVerifiedState()
        {
            initialized = false;
            ownerId = null;
            configurationPath = null;
            configurationSha256 = null;
            designMode = -1;
        }

        public static void InitializeForSelectedSession()
        {
            lock (Gate)
            {
                // A failed attempt cannot retain a previous run's accepted mode.
                ClearVerifiedState();
                if (!LocalEditorSession.Selected)
                    throw new NotSupportedException("Independent local platform metadata requires an explicitly selected local session.");
                LocalEditorSession.RequireReady();
                string root = Path.GetFullPath(LocalEditorSession.ProfileRoot);
                string owner = LocalEditorSession.LocalPlayerId;
                ValidateOwner(owner);
                if (!Directory.Exists(root))
                    throw new DirectoryNotFoundException("The verified local profile directory is missing; platform metadata initialization stopped.");
                string path = Path.GetFullPath(Path.Combine(root, FileName));
                string parent = Path.GetDirectoryName(path);
                if (!string.Equals(parent, root.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar), StringComparison.OrdinalIgnoreCase))
                    throw new InvalidOperationException("Local platform metadata must remain inside the selected profile.");

                if (!File.Exists(path))
                {
                    // Explicit first configuration for the selected independent profile, not a query fallback.
                    byte[] created = EncodeNormalPlay(owner);
                    string pending = Path.Combine(root, "platform-metadata-" + Guid.NewGuid().ToString("N") + ".new");
                    try
                    {
                        using (FileStream stream = new FileStream(pending, FileMode.CreateNew, FileAccess.Write, FileShare.None))
                        {
                            stream.Write(created, 0, created.Length);
                            stream.Flush(true);
                        }
                        byte[] readback = File.ReadAllBytes(pending);
                        if (!EqualBytes(created, readback))
                            throw new IOException("Local platform metadata did not preserve the explicit configuration payload.");
                        try { File.Move(pending, path); }
                        catch (IOException)
                        {
                            if (!File.Exists(path)) throw;
                            // A concurrent creator is accepted only after the same strict ownership/content validation below.
                        }
                    }
                    finally { if (File.Exists(pending)) File.Delete(pending); }
                }

                byte[] bytes = File.ReadAllBytes(path);
                int parsedMode = ParseAndVerify(bytes, owner);
                string sha = Digest(bytes);
                // Read the final named document again, not just the temporary payload.
                if (!EqualBytes(bytes, File.ReadAllBytes(path)))
                    throw new IOException("Local platform metadata changed during initialization.");
                Debug.Log("[LocalEditorPlatformMetadata] Verified independent normal-play metadata: " + path
                    + "; sha256=" + sha + "; this is not SDK configuration, login, advertising or purchase success.");
                ownerId = owner;
                configurationPath = path;
                configurationSha256 = sha;
                designMode = parsedMode;
                initialized = true;
            }
        }

        public static int ReadDesignMode()
        {
            if (!LocalEditorSession.Selected)
                throw new NotSupportedException("The independent local platform metadata provider is not selected.");
            LocalEditorSession.RequireReady();
            lock (Gate)
            {
                string expected = Path.GetFullPath(Path.Combine(LocalEditorSession.ProfileRoot, FileName));
                if (!initialized || designMode != 0
                    || !string.Equals(ownerId, LocalEditorSession.LocalPlayerId, StringComparison.Ordinal)
                    || !string.Equals(configurationPath, expected, StringComparison.OrdinalIgnoreCase))
                    throw new InvalidOperationException("Independent local platform metadata has not been initialized and verified for this profile.");
                // Immutable, validated configuration snapshot for this run; no per-query profile I/O.
                return designMode;
            }
        }

        private static byte[] EncodeNormalPlay(string owner)
        {
            string payload = Format + "\nowner=" + owner + "\nmode=" + NormalPlay + "\ndesignMode=0\n";
            byte[] content = StrictUtf8.GetBytes(payload);
            return StrictUtf8.GetBytes(payload + "sha256=" + Digest(content) + "\n");
        }

        private static int ParseAndVerify(byte[] bytes, string owner)
        {
            string text = StrictUtf8.GetString(bytes);
            string[] lines = text.Split('\n');
            if (lines.Length != 6 || lines[5].Length != 0 || text.IndexOf('\r') >= 0
                || lines[0] != Format || lines[1] != "owner=" + owner
                || lines[2] != "mode=" + NormalPlay || !lines[3].StartsWith("designMode=", StringComparison.Ordinal)
                || !lines[4].StartsWith("sha256=", StringComparison.Ordinal))
                throw new InvalidDataException("The local platform metadata format or profile ownership is invalid; the document has been preserved.");
            int parsed;
            string rawMode = lines[3].Substring("designMode=".Length);
            if (!int.TryParse(rawMode, NumberStyles.None, CultureInfo.InvariantCulture, out parsed)
                || rawMode != "0" || parsed != 0)
                throw new InvalidDataException("Only the explicitly configured independent normal-play mode is supported; no design-mode unlock is supplied.");
            string payload = lines[0] + "\n" + lines[1] + "\n" + lines[2] + "\n" + lines[3] + "\n";
            if (!string.Equals(lines[4], "sha256=" + Digest(StrictUtf8.GetBytes(payload)), StringComparison.Ordinal))
                throw new InvalidDataException("The local platform metadata checksum is invalid; the document has been preserved.");
            return parsed;
        }

        private static void ValidateOwner(string owner)
        {
            Guid id;
            if (string.IsNullOrEmpty(owner) || !owner.StartsWith("local-", StringComparison.Ordinal)
                || !Guid.TryParseExact(owner.Substring(6), "N", out id))
                throw new InvalidDataException("A verified independent local profile owner is required for platform metadata.");
        }

        private static string Digest(byte[] data)
        {
            using (SHA256 sha = SHA256.Create())
                return BitConverter.ToString(sha.ComputeHash(data)).Replace("-", "").ToLowerInvariant();
        }

        private static bool EqualBytes(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; ++i) if (a[i] != b[i]) return false;
            return true;
        }
    }
}
#endif
