using System.Reflection;
using System.Runtime.Loader;
using System.Runtime.CompilerServices;
using System.Text.Json;

if (args.Length != 3) throw new ArgumentException("recovered-dll reference-dir native-golden-json");
AssemblyLoadContext.Default.Resolving += (context, name) =>
{
    var path = Path.Combine(args[1], name.Name + ".dll");
    return File.Exists(path) ? context.LoadFromAssemblyPath(Path.GetFullPath(path)) : null;
};
try
{
    var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(Path.GetFullPath(args[0]));
    var type = assembly.GetType("GameModule.SynergyEffectManager", throwOnError: true)!;
    var method = type.GetMethod("InternalCalculateDamage", BindingFlags.Instance | BindingFlags.NonPublic)!;
    // This method does not read instance state. Avoid invoking unrelated constructors from probe DLLs.
    var instance = RuntimeHelpers.GetUninitializedObject(type);
    Console.WriteLine("DIRECT_IL_RESULT=" + method.Invoke(instance, [100, false, 4, 4]));
    var vectors = JsonDocument.Parse(File.ReadAllText(args[2]));
    int tested = 0, failed = 0;
    foreach (var row in vectors.RootElement.EnumerateArray())
    {
        var input = new object[] { row.GetProperty("attack").GetInt32(), row.GetProperty("enemy").GetBoolean(), row.GetProperty("count").GetInt32(), row.GetProperty("required").GetInt32() };
        int expected = row.GetProperty("native").GetInt32();
        int actual = (int)method.Invoke(instance, input)!;
        ++tested;
        if (expected != actual)
        {
            ++failed;
            Console.WriteLine($"NATIVE_MISMATCH {row} actual={actual}");
        }
    }
    Console.WriteLine($"NATIVE_DIFFERENTIAL tested={tested} passed={tested-failed} failed={failed}");
    if (failed != 0) Environment.ExitCode = 1;
}
catch (Exception error)
{
    Console.WriteLine("DIRECT_IL_FAILURE=" + error);
    Environment.ExitCode = 1;
}
