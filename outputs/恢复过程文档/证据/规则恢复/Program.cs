using System.Text.Json;

int failures = 0, checks = 0;
void Check(string label, int actual, int expected)
{
    checks++;
    if (actual != expected) { failures++; Console.WriteLine($"FAIL {label}: expected {expected}, got {actual}"); }
}
HexManager.HexCoord Coord(int q, int r) => new() { q = q, r = r };
Check("same coordinate", HexManager.HexDistance(Coord(5, -8), Coord(5, -8)), 0);
foreach (var point in new[] { Coord(1,0), Coord(0,1), Coord(-1,1), Coord(-1,0), Coord(0,-1), Coord(1,-1) })
    Check($"six adjacent tiles {point.q},{point.r}", HexManager.HexDistance(Coord(0,0), point), 1);
Check("axial distance", HexManager.HexDistance(Coord(2,-1), Coord(-1,3)), 4);
Check("native int32 sum wrap", HexManager.HexDistance(Coord(int.MaxValue,0), Coord(0,0)), -1);
Check("native CNEG int.MinValue does not throw", HexManager.HexDistance(Coord(int.MinValue,0), Coord(0,0)), 0);

var damage = new SynergyEffectManager();
Check("below threshold", damage.Evaluate(101, false, 3, 4), 101);
Check("threshold met, odd positive attack", damage.Evaluate(101, false, 4, 4), 151);
Check("negative truncates toward zero", damage.Evaluate(-101, true, 4, 4), -151);
Check("float32 precision before multiply", damage.Evaluate(16777219, false, 4, 4), 25165829);
Check("native addition wraps", damage.Evaluate(int.MaxValue, false, 4, 4), -1073741825);

if (args.Length != 0)
{
    using var json = JsonDocument.Parse(File.ReadAllText(args[0]));
    foreach (var row in json.RootElement.EnumerateArray())
    {
        Check("original ARM64 golden", damage.Evaluate(row.GetProperty("attack").GetInt32(), row.GetProperty("enemy").GetBoolean(), row.GetProperty("count").GetInt32(), row.GetProperty("required").GetInt32()), row.GetProperty("native").GetInt32());
    }
}
Console.WriteLine($"checks={checks} failures={failures}");
Environment.ExitCode = failures == 0 ? 0 : 1;
