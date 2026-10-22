using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace GameFramework.Recovery
{
    // Verified per-file local platform persistence. A batch of original model
    // Save calls remains nontransactional; prior successful writes are retained.
    public static class LocalEditorModelStore
    {
        public sealed class WriteFact
        {
            public string LocalPlayerId { get; internal set; }
            public string Key { get; internal set; }
            public string Path { get; internal set; }
            public bool Attempted { get; internal set; }
            public bool Written { get; internal set; }
            public bool Readback { get; internal set; }
            public bool PartialFailure { get; internal set; }
            public string Sha256 { get; internal set; }
            public string Error { get; internal set; }
            public DateTime AttemptedUtc { get; internal set; }
        }

        private static readonly object Gate = new object();
        private static readonly List<WriteFact> Facts = new List<WriteFact>();
        public static WriteFact[] Snapshot() { lock (Gate) { return Facts.ToArray(); } }

        private static void RequireSelected()
        {
            if (!LocalEditorSession.Selected)
                throw new NotSupportedException("Verified model files only belong to the selected independent local session; original server/cloud storage remains unsupported.");
            LocalEditorSession.RequireReady();
        }

        public static string PathFor(string key)
        {
            RequireSelected();
            if (key == null) throw new ArgumentNullException(nameof(key));
            using (var sha = SHA256.Create())
            {
                string name = BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(key))).Replace("-", "");
                return Path.Combine(LocalEditorSession.StoreRoot, name + ".save");
            }
        }

        public static void ProbeWritable()
        {
            RequireSelected();
            string path = Path.Combine(LocalEditorSession.StoreRoot, "preflight-" + Guid.NewGuid().ToString("N") + ".tmp");
            string content = Guid.NewGuid().ToString("N");
            try
            {
                File.WriteAllText(path, content, new UTF8Encoding(false));
                if (File.ReadAllText(path, Encoding.UTF8) != content)
                    throw new IOException("Independent local model storage preflight readback differs.");
            }
            finally { if (File.Exists(path)) File.Delete(path); }
        }

        public static WriteFact Write(string key, string value)
        {
            lock (Gate)
            {
                var fact = new WriteFact { Key = key, Attempted = true, AttemptedUtc = DateTime.UtcNow };
                Facts.Add(fact);
                string pending = null;
                try
                {
                    RequireSelected();
                    fact.LocalPlayerId = LocalEditorSession.LocalPlayerId;
                    fact.Path = PathFor(key);
                    if (value == null) throw new ArgumentNullException(nameof(value));
                    pending = Path.Combine(LocalEditorSession.StoreRoot, "model-" + Guid.NewGuid().ToString("N") + ".pending");
                    File.WriteAllText(pending, value, new UTF8Encoding(false));
                    if (File.ReadAllText(pending, Encoding.UTF8) != value)
                        throw new IOException("Independent local model staging readback differs.");
                    if (File.Exists(fact.Path)) File.Replace(pending, fact.Path, null);
                    else File.Move(pending, fact.Path);
                    fact.Written = true;
                    byte[] bytes = File.ReadAllBytes(fact.Path);
                    if (Encoding.UTF8.GetString(bytes) != value)
                        throw new IOException("Independent local model target readback differs.");
                    using (var sha = SHA256.Create())
                        fact.Sha256 = BitConverter.ToString(sha.ComputeHash(bytes)).Replace("-", "").ToLowerInvariant();
                    fact.Readback = true;
                    return fact;
                }
                catch (Exception ex)
                {
                    fact.Error = ex.GetType().Name + ": " + ex.Message;
                    fact.PartialFailure = fact.Written && !fact.Readback;
                    throw;
                }
                finally { if (pending != null && File.Exists(pending)) File.Delete(pending); }
            }
        }
    }
}
