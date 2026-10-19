using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text.Json;

if (args.Length != 2) throw new ArgumentException("Expected DLL and output JSON paths.");
using var stream = File.OpenRead(args[0]);
using var pe = new PEReader(stream);
var reader = pe.GetMetadataReader();
var references = reader.AssemblyReferences.Select(handle =>
{
    var reference = reader.GetAssemblyReference(handle);
    return new { name = reader.GetString(reference.Name), version = reference.Version.ToString() };
}).OrderBy(value => value.name).ToArray();
string[] allowed = ["netstandard", "UnityEditor.CoreModule", "UnityEngine.CoreModule", "UnityEngine.JSONSerializeModule"];
var report = new
{
    scope = "PE metadata only; target assembly is not loaded or executed",
    assemblyPath = Path.GetFullPath(args[0]),
    sha256 = Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(args[0]))).ToLowerInvariant(),
    mvid = reader.GetGuid(reader.GetModuleDefinition().Mvid),
    assemblyReferences = references,
    onlyExpectedReferences = references.Select(value => value.name).Order().SequenceEqual(allowed.Order()),
    productionExecution = "not-run",
    unityExecution = "not-run"
};
File.WriteAllText(args[1], JsonSerializer.Serialize(report, new JsonSerializerOptions { WriteIndented = true }));
Console.WriteLine(JsonSerializer.Serialize(report));
